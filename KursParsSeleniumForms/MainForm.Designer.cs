namespace KursParsSeleniumWinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.Label lblMinCost;
        private System.Windows.Forms.TextBox txtMinCost;
        private System.Windows.Forms.Label lblMaxCost;
        private System.Windows.Forms.TextBox txtMaxCost;
        private System.Windows.Forms.Label lblSortMethod;
        private System.Windows.Forms.ComboBox cmbSortMethod;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvListings;
        private System.Windows.Forms.Button btnOpenSelected;
        private System.Windows.Forms.Label lblStatus;

        /// <summary>
        /// Освобождение ресурсов.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblArrival = new System.Windows.Forms.Label();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.lblMinCost = new System.Windows.Forms.Label();
            this.txtMinCost = new System.Windows.Forms.TextBox();
            this.lblMaxCost = new System.Windows.Forms.Label();
            this.txtMaxCost = new System.Windows.Forms.TextBox();
            this.lblSortMethod = new System.Windows.Forms.Label();
            this.cmbSortMethod = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvListings = new System.Windows.Forms.DataGridView();
            this.btnOpenSelected = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListings)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.lblCity);
            this.groupBoxInput.Controls.Add(this.txtCity);
            this.groupBoxInput.Controls.Add(this.lblArrival);
            this.groupBoxInput.Controls.Add(this.dtpArrival);
            this.groupBoxInput.Controls.Add(this.lblDeparture);
            this.groupBoxInput.Controls.Add(this.dtpDeparture);
            this.groupBoxInput.Controls.Add(this.lblMinCost);
            this.groupBoxInput.Controls.Add(this.txtMinCost);
            this.groupBoxInput.Controls.Add(this.lblMaxCost);
            this.groupBoxInput.Controls.Add(this.txtMaxCost);
            this.groupBoxInput.Controls.Add(this.lblSortMethod);
            this.groupBoxInput.Controls.Add(this.cmbSortMethod);
            this.groupBoxInput.Controls.Add(this.btnStart);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(760, 120);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Входные данные";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 22);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(75, 13);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "Введите город:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(90, 19);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(150, 20);
            this.txtCity.TabIndex = 1;
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(250, 22);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(101, 13);
            this.lblArrival.TabIndex = 2;
            this.lblArrival.Text = "Дата заезда:";
            // 
            // dtpArrival
            // 
            this.dtpArrival.CustomFormat = "dd.MM.yyyy";
            this.dtpArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrival.Location = new System.Drawing.Point(357, 19);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(100, 20);
            this.dtpArrival.TabIndex = 3;
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(470, 22);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(101, 13);
            this.lblDeparture.TabIndex = 4;
            this.lblDeparture.Text = "Дата выезда:";
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.CustomFormat = "dd.MM.yyyy";
            this.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeparture.Location = new System.Drawing.Point(577, 19);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(100, 20);
            this.dtpDeparture.TabIndex = 5;
            // 
            // lblMinCost
            // 
            this.lblMinCost.AutoSize = true;
            this.lblMinCost.Location = new System.Drawing.Point(6, 55);
            this.lblMinCost.Name = "lblMinCost";
            this.lblMinCost.Size = new System.Drawing.Size(138, 13);
            this.lblMinCost.TabIndex = 6;
            this.lblMinCost.Text = "Минимальная стоимость:";
            // 
            // txtMinCost
            // 
            this.txtMinCost.Location = new System.Drawing.Point(150, 52);
            this.txtMinCost.Name = "txtMinCost";
            this.txtMinCost.Size = new System.Drawing.Size(90, 20);
            this.txtMinCost.TabIndex = 7;
            // 
            // lblMaxCost
            // 
            this.lblMaxCost.AutoSize = true;
            this.lblMaxCost.Location = new System.Drawing.Point(250, 55);
            this.lblMaxCost.Name = "lblMaxCost";
            this.lblMaxCost.Size = new System.Drawing.Size(146, 13);
            this.lblMaxCost.TabIndex = 8;
            this.lblMaxCost.Text = "Максимальная стоимость:";
            // 
            // txtMaxCost
            // 
            this.txtMaxCost.Location = new System.Drawing.Point(402, 52);
            this.txtMaxCost.Name = "txtMaxCost";
            this.txtMaxCost.Size = new System.Drawing.Size(90, 20);
            this.txtMaxCost.TabIndex = 9;
            // 
            // lblSortMethod
            // 
            this.lblSortMethod.AutoSize = true;
            this.lblSortMethod.Location = new System.Drawing.Point(495, 55);
            this.lblSortMethod.Name = "lblSortMethod";
            this.lblSortMethod.Size = new System.Drawing.Size(93, 13);
            this.lblSortMethod.TabIndex = 10;
            this.lblSortMethod.Text = "Метод сортировки:";
            // 
            // cmbSortMethod
            // 
            this.cmbSortMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortMethod.FormattingEnabled = true;
            this.cmbSortMethod.Location = new System.Drawing.Point(600, 52);
            this.cmbSortMethod.Name = "cmbSortMethod";
            this.cmbSortMethod.Size = new System.Drawing.Size(150, 21);
            this.cmbSortMethod.TabIndex = 11;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Начать парсинг";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dgvListings
            // 
            this.dgvListings.AllowUserToAddRows = false;
            this.dgvListings.AllowUserToDeleteRows = false;
            this.dgvListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Title", HeaderText = "Название отеля" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Price", HeaderText = "Цена" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Rating", HeaderText = "Оценка" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "ReviewsCount", HeaderText = "Кол-во отзывов" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "PriceQualityRatio", HeaderText = "Коэф. цена/качества" },
                new System.Windows.Forms.DataGridViewTextBoxColumn { Name = "Link", HeaderText = "Ссылка", Visible = false }
            });
            this.dgvListings.Location = new System.Drawing.Point(12, 138);
            this.dgvListings.MultiSelect = false;
            this.dgvListings.Name = "dgvListings";
            this.dgvListings.ReadOnly = true;
            this.dgvListings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListings.Size = new System.Drawing.Size(760, 300);
            this.dgvListings.TabIndex = 13;
            // 
            // btnOpenSelected
            // 
            this.btnOpenSelected.Location = new System.Drawing.Point(12, 444);
            this.btnOpenSelected.Name = "btnOpenSelected";
            this.btnOpenSelected.Size = new System.Drawing.Size(150, 23);
            this.btnOpenSelected.TabIndex = 14;
            this.btnOpenSelected.Text = "Открыть выбранное";
            this.btnOpenSelected.UseVisualStyleBackColor = true;
            this.btnOpenSelected.Click += new System.EventHandler(this.btnOpenSelected_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(180, 449);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Статус:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnOpenSelected);
            this.Controls.Add(this.dgvListings);
            this.Controls.Add(this.groupBoxInput);
            this.Name = "MainForm";
            this.Text = "СелениумПарс - Парсинг недвижимости";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}