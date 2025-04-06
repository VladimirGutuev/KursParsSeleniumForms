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
            groupBoxInput = new GroupBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblArrival = new Label();
            dtpArrival = new DateTimePicker();
            lblDeparture = new Label();
            dtpDeparture = new DateTimePicker();
            lblMinCost = new Label();
            txtMinCost = new TextBox();
            lblMaxCost = new Label();
            txtMaxCost = new TextBox();
            lblSortMethod = new Label();
            cmbSortMethod = new ComboBox();
            btnStart = new Button();
            dgvListings = new DataGridView();
            btnOpenSelected = new Button();
            lblStatus = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListings).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(lblCity);
            groupBoxInput.Controls.Add(txtCity);
            groupBoxInput.Controls.Add(lblArrival);
            groupBoxInput.Controls.Add(dtpArrival);
            groupBoxInput.Controls.Add(lblDeparture);
            groupBoxInput.Controls.Add(dtpDeparture);
            groupBoxInput.Controls.Add(lblMinCost);
            groupBoxInput.Controls.Add(txtMinCost);
            groupBoxInput.Controls.Add(lblMaxCost);
            groupBoxInput.Controls.Add(txtMaxCost);
            groupBoxInput.Controls.Add(lblSortMethod);
            groupBoxInput.Controls.Add(cmbSortMethod);
            groupBoxInput.Controls.Add(btnStart);
            groupBoxInput.Location = new Point(26, 30);
            groupBoxInput.Margin = new Padding(6, 7, 6, 7);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Padding = new Padding(6, 7, 6, 7);
            groupBoxInput.Size = new Size(1647, 295);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Входные данные";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(13, 54);
            lblCity.Margin = new Padding(6, 0, 6, 0);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(180, 32);
            lblCity.TabIndex = 0;
            lblCity.Text = "Введите город:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(195, 47);
            txtCity.Margin = new Padding(6, 7, 6, 7);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(320, 39);
            txtCity.TabIndex = 1;
            // 
            // lblArrival
            // 
            lblArrival.AutoSize = true;
            lblArrival.Location = new Point(542, 54);
            lblArrival.Margin = new Padding(6, 0, 6, 0);
            lblArrival.Name = "lblArrival";
            lblArrival.Size = new Size(149, 32);
            lblArrival.TabIndex = 2;
            lblArrival.Text = "Дата заезда:";
            // 
            // dtpArrival
            // 
            dtpArrival.CustomFormat = "dd.MM.yyyy";
            dtpArrival.Format = DateTimePickerFormat.Custom;
            dtpArrival.Location = new Point(774, 47);
            dtpArrival.Margin = new Padding(6, 7, 6, 7);
            dtpArrival.Name = "dtpArrival";
            dtpArrival.Size = new Size(212, 39);
            dtpArrival.TabIndex = 3;
            // 
            // lblDeparture
            // 
            lblDeparture.AutoSize = true;
            lblDeparture.Location = new Point(1018, 54);
            lblDeparture.Margin = new Padding(6, 0, 6, 0);
            lblDeparture.Name = "lblDeparture";
            lblDeparture.Size = new Size(156, 32);
            lblDeparture.TabIndex = 4;
            lblDeparture.Text = "Дата выезда:";
            // 
            // dtpDeparture
            // 
            dtpDeparture.CustomFormat = "dd.MM.yyyy";
            dtpDeparture.Format = DateTimePickerFormat.Custom;
            dtpDeparture.Location = new Point(1250, 47);
            dtpDeparture.Margin = new Padding(6, 7, 6, 7);
            dtpDeparture.Name = "dtpDeparture";
            dtpDeparture.Size = new Size(212, 39);
            dtpDeparture.TabIndex = 5;
            // 
            // lblMinCost
            // 
            lblMinCost.AutoSize = true;
            lblMinCost.Location = new Point(13, 135);
            lblMinCost.Margin = new Padding(6, 0, 6, 0);
            lblMinCost.Name = "lblMinCost";
            lblMinCost.Size = new Size(295, 32);
            lblMinCost.TabIndex = 6;
            lblMinCost.Text = "Минимальная стоимость:";
            // 
            // txtMinCost
            // 
            txtMinCost.Location = new Point(325, 128);
            txtMinCost.Margin = new Padding(6, 7, 6, 7);
            txtMinCost.Name = "txtMinCost";
            txtMinCost.Size = new Size(190, 39);
            txtMinCost.TabIndex = 7;
            // 
            // lblMaxCost
            // 
            lblMaxCost.AutoSize = true;
            lblMaxCost.Location = new Point(542, 135);
            lblMaxCost.Margin = new Padding(6, 0, 6, 0);
            lblMaxCost.Name = "lblMaxCost";
            lblMaxCost.Size = new Size(302, 32);
            lblMaxCost.TabIndex = 8;
            lblMaxCost.Text = "Максимальная стоимость:";
            // 
            // txtMaxCost
            // 
            txtMaxCost.Location = new Point(871, 128);
            txtMaxCost.Margin = new Padding(6, 7, 6, 7);
            txtMaxCost.Name = "txtMaxCost";
            txtMaxCost.Size = new Size(190, 39);
            txtMaxCost.TabIndex = 9;
            // 
            // lblSortMethod
            // 
            lblSortMethod.AutoSize = true;
            lblSortMethod.Location = new Point(1062, 135);
            lblSortMethod.Margin = new Padding(6, 0, 6, 0);
            lblSortMethod.Name = "lblSortMethod";
            lblSortMethod.Size = new Size(228, 32);
            lblSortMethod.TabIndex = 10;
            lblSortMethod.Text = "Метод сортировки:";
            // 
            // cmbSortMethod
            // 
            cmbSortMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSortMethod.FormattingEnabled = true;
            cmbSortMethod.Location = new Point(1300, 128);
            cmbSortMethod.Margin = new Padding(6, 7, 6, 7);
            cmbSortMethod.Name = "cmbSortMethod";
            cmbSortMethod.Size = new Size(320, 40);
            cmbSortMethod.TabIndex = 11;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(13, 209);
            btnStart.Margin = new Padding(6, 7, 6, 7);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(217, 57);
            btnStart.TabIndex = 12;
            btnStart.Text = "Начать парсинг";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // dgvListings
            // 
            dgvListings.AllowUserToAddRows = false;
            dgvListings.AllowUserToDeleteRows = false;
            dgvListings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListings.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvListings.Location = new Point(26, 340);
            dgvListings.Margin = new Padding(6, 7, 6, 7);
            dgvListings.MultiSelect = false;
            dgvListings.Name = "dgvListings";
            dgvListings.ReadOnly = true;
            dgvListings.RowHeadersWidth = 82;
            dgvListings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListings.Size = new Size(1647, 738);
            dgvListings.TabIndex = 13;
            // 
            // btnOpenSelected
            // 
            btnOpenSelected.Location = new Point(26, 1093);
            btnOpenSelected.Margin = new Padding(6, 7, 6, 7);
            btnOpenSelected.Name = "btnOpenSelected";
            btnOpenSelected.Size = new Size(325, 57);
            btnOpenSelected.TabIndex = 14;
            btnOpenSelected.Text = "Открыть выбранное";
            btnOpenSelected.UseVisualStyleBackColor = true;
            btnOpenSelected.Click += btnOpenSelected_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(390, 1105);
            lblStatus.Margin = new Padding(6, 0, 6, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(89, 32);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "Статус:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 10;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 10;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 10;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 10;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 10;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.MinimumWidth = 10;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 200;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1699, 1184);
            Controls.Add(lblStatus);
            Controls.Add(btnOpenSelected);
            Controls.Add(dgvListings);
            Controls.Add(groupBoxInput);
            Margin = new Padding(6, 7, 6, 7);
            Name = "MainForm";
            Text = "СелениумПарс - Парсинг недвижимости";
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}