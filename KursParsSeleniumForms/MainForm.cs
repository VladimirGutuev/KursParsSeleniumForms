using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using KursParsSelenium; // ���� ������������ ��� � ������� (UserInfo, SeleniumService, ListingInfo � �.�.)

namespace KursParsSeleniumWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // �������������� ������ ������� ����������
            cmbSortMethod.Items.AddRange(new string[]
            {
                "�� ����",
                "�� ��������",
                "�� ���������� �������",
                "����/��������"
            });
            cmbSortMethod.SelectedIndex = 0;
        }

        // ���������� ������� ������ "������ �������"
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // �������� �����
                if (string.IsNullOrWhiteSpace(txtCity.Text) ||
                    string.IsNullOrWhiteSpace(txtMinCost.Text) ||
                    string.IsNullOrWhiteSpace(txtMaxCost.Text))
                {
                    MessageBox.Show("����������, ��������� ��� ���� �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ������������ ������� � ������� ������������
                UserInfo user = new UserInfo();
                user.UserCity = txtCity.Text.Trim();
                // ���������� DateTimePicker ��� ���, ����������� � dd.MM.yyyy
                user.UserArrivalDate = dtpArrival.Value.ToString("dd.MM.yyyy");
                user.UserDepartureDate = dtpDeparture.Value.ToString("dd.MM.yyyy");

                if (!int.TryParse(txtMinCost.Text.Trim(), out int minCost) ||
                    !int.TryParse(txtMaxCost.Text.Trim(), out int maxCost))
                {
                    MessageBox.Show("������� ���������� �������� �������� ��� ���������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                user.UserMinCost = minCost;
                user.UserMaxCost = maxCost;

                // �������� ��������� ����� ���������� (������ + 1, ��� � �������� ����)
                int sortChoice = cmbSortMethod.SelectedIndex + 1;

                // ������� ������ Selenium � ��������� �������
                SeleniumService seleniumService = new SeleniumService();
                btnStart.Enabled = false;
                lblStatus.Text = "������� �������, ���������...";
                Application.DoEvents();

                List<ListingInfo> listings = seleniumService.Run(user);

                // ��������� � ������� ������� � ������������� ��������� ��� � ����� ������ �������
                listings.RemoveAll(item => item.Rating == "������� �����������" || item.ReviewsCount < 15);

                // ���������� �������� ���������� ������
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

                // ���������� ���������� � DataGridView
                dgvListings.Rows.Clear();
                foreach (var item in listings)
                {
                    dgvListings.Rows.Add(item.Title, item.Price, item.Rating, item.ReviewsCount, item.PriceQualityRatio, item.Link);
                }

                lblStatus.Text = $"������� ��������: {listings.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnStart.Enabled = true;
            }
        }

        // ���������� ������ "������� ���������" � ��������� ������ ���������� �������
        private void btnOpenSelected_Click(object sender, EventArgs e)
        {
            if (dgvListings.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvListings.SelectedRows[0];
                // ������ �������� � ������� ������� � �������� 5
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
                MessageBox.Show("����������, �������� ������ �� ������.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}