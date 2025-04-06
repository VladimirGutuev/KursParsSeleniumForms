using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using KursParsSelenium; // Ваше пространство имён с логикой (UserInfo, SeleniumService, ListingInfo и т.д.)

namespace KursParsSeleniumWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Инициализируем список методов сортировки
            cmbSortMethod.Items.AddRange(new string[]
            {
                "По цене",
                "По рейтингу",
                "По количеству отзывов",
                "Цена/качество"
            });
            cmbSortMethod.SelectedIndex = 0;
        }

        // Обработчик нажатия кнопки "Начать парсинг"
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка ввода
                if (string.IsNullOrWhiteSpace(txtCity.Text) ||
                    string.IsNullOrWhiteSpace(txtMinCost.Text) ||
                    string.IsNullOrWhiteSpace(txtMaxCost.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Формирование объекта с данными пользователя
                UserInfo user = new UserInfo();
                user.UserCity = txtCity.Text.Trim();
                // Используем DateTimePicker для дат, форматируем в dd.MM.yyyy
                user.UserArrivalDate = dtpArrival.Value.ToString("dd.MM.yyyy");
                user.UserDepartureDate = dtpDeparture.Value.ToString("dd.MM.yyyy");

                if (!int.TryParse(txtMinCost.Text.Trim(), out int minCost) ||
                    !int.TryParse(txtMaxCost.Text.Trim(), out int maxCost))
                {
                    MessageBox.Show("Введите корректные числовые значения для стоимости.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                user.UserMinCost = minCost;
                user.UserMaxCost = maxCost;

                // Получаем выбранный метод сортировки (индекс + 1, как в исходном коде)
                int sortChoice = cmbSortMethod.SelectedIndex + 1;

                // Создаем сервис Selenium и запускаем парсинг
                SeleniumService seleniumService = new SeleniumService();
                btnStart.Enabled = false;
                lblStatus.Text = "Парсинг запущен, подождите...";
                Application.DoEvents();

                List<ListingInfo> listings = seleniumService.Run(user);

                // Фильтруем – удаляем объекты с отсутствующим рейтингом или с малым числом отзывов
                listings.RemoveAll(item => item.Rating == "Рейтинг отсутствует" || item.ReviewsCount < 15);

                // Сортировка согласно выбранному методу
                switch (sortChoice)
                {
                    case 1:
                        listings.Sort((a, b) => a.Price.CompareTo(b.Price));
                        break;
                    case 2:
                        listings.Sort((a, b) => a.Rating.CompareTo(b.Rating));
                        break;
                    case 3:
                        listings.Sort((a, b) => a.ReviewsCount.CompareTo(b.ReviewsCount));
                        break;
                    case 4:
                        listings.Sort((a, b) => b.PriceQualityRatio.CompareTo(a.PriceQualityRatio));
                        break;
                }

                // Отображаем результаты в DataGridView
                dgvListings.Rows.Clear();
                foreach (var item in listings)
                {
                    dgvListings.Rows.Add(item.Title, item.Price, item.Rating, item.ReviewsCount, item.PriceQualityRatio, item.Link);
                }

                lblStatus.Text = $"Найдено объектов: {listings.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnStart.Enabled = true;
            }
        }

        // Обработчик кнопки "Открыть выбранное" – открывает ссылку выбранного объекта
        private void btnOpenSelected_Click(object sender, EventArgs e)
        {
            if (dgvListings.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvListings.SelectedRows[0];
                // Ссылка хранится в скрытом столбце с индексом 5
                string url = row.Cells[5].Value.ToString();
                if (!string.IsNullOrEmpty(url))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите объект из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}