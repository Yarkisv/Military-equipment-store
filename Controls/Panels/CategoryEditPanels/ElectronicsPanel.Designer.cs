namespace MilitaryEquipmentStore.Controls.Panels.CategoryEditPanels
{
    partial class ElectronicsPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            electronicPanel = new Panel();
            cmbFrequencyBand = new ComboBox();
            txtPowerSupply = new TextBox();
            txtProtectionLevel = new TextBox();
            txtWeight = new TextBox();
            txtPower = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtRange = new TextBox();
            label6 = new Label();
            cmbDeviceType = new ComboBox();
            electronicPanel.SuspendLayout();
            SuspendLayout();
            // 
            // electronicPanel
            // 
            electronicPanel.BackColor = Color.FromArgb(20, 20, 20);
            electronicPanel.Controls.Add(cmbFrequencyBand);
            electronicPanel.Controls.Add(txtPowerSupply);
            electronicPanel.Controls.Add(txtProtectionLevel);
            electronicPanel.Controls.Add(txtWeight);
            electronicPanel.Controls.Add(txtPower);
            electronicPanel.Controls.Add(label11);
            electronicPanel.Controls.Add(label10);
            electronicPanel.Controls.Add(label9);
            electronicPanel.Controls.Add(label8);
            electronicPanel.Controls.Add(label7);
            electronicPanel.Controls.Add(txtRange);
            electronicPanel.Controls.Add(label6);
            electronicPanel.Controls.Add(cmbDeviceType);
            electronicPanel.Dock = DockStyle.Fill;
            electronicPanel.Location = new Point(0, 0);
            electronicPanel.Name = "electronicPanel";
            electronicPanel.Size = new Size(295, 419);
            electronicPanel.TabIndex = 2;
            // 
            // cmbFrequencyBand
            // 
            cmbFrequencyBand.BackColor = Color.FromArgb(40, 40, 40);
            cmbFrequencyBand.FlatStyle = FlatStyle.Flat;
            cmbFrequencyBand.Font = new Font("Segoe UI", 10F);
            cmbFrequencyBand.ForeColor = Color.White;
            cmbFrequencyBand.FormattingEnabled = true;
            cmbFrequencyBand.Items.AddRange(new object[] { "VHF", "UHF", "HF", "SHF", "Інший" });
            cmbFrequencyBand.Location = new Point(13, 110);
            cmbFrequencyBand.Name = "cmbFrequencyBand";
            cmbFrequencyBand.Size = new Size(267, 25);
            cmbFrequencyBand.TabIndex = 13;
            // 
            // txtPowerSupply
            // 
            txtPowerSupply.BackColor = Color.FromArgb(40, 40, 40);
            txtPowerSupply.BorderStyle = BorderStyle.FixedSingle;
            txtPowerSupply.Font = new Font("Segoe UI", 10F);
            txtPowerSupply.ForeColor = Color.White;
            txtPowerSupply.Location = new Point(13, 294);
            txtPowerSupply.Name = "txtPowerSupply";
            txtPowerSupply.Size = new Size(267, 25);
            txtPowerSupply.TabIndex = 12;
            // 
            // txtProtectionLevel
            // 
            txtProtectionLevel.BackColor = Color.FromArgb(40, 40, 40);
            txtProtectionLevel.BorderStyle = BorderStyle.FixedSingle;
            txtProtectionLevel.Font = new Font("Segoe UI", 10F);
            txtProtectionLevel.ForeColor = Color.White;
            txtProtectionLevel.Location = new Point(13, 248);
            txtProtectionLevel.Name = "txtProtectionLevel";
            txtProtectionLevel.Size = new Size(267, 25);
            txtProtectionLevel.TabIndex = 11;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.FromArgb(40, 40, 40);
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Font = new Font("Segoe UI", 10F);
            txtWeight.ForeColor = Color.White;
            txtWeight.Location = new Point(13, 202);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(267, 25);
            txtWeight.TabIndex = 10;
            // 
            // txtPower
            // 
            txtPower.BackColor = Color.FromArgb(40, 40, 40);
            txtPower.BorderStyle = BorderStyle.FixedSingle;
            txtPower.Font = new Font("Segoe UI", 10F);
            txtPower.ForeColor = Color.White;
            txtPower.Location = new Point(13, 156);
            txtPower.Name = "txtPower";
            txtPower.Size = new Size(267, 25);
            txtPower.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(13, 276);
            label11.Name = "label11";
            label11.Size = new Size(81, 15);
            label11.TabIndex = 7;
            label11.Text = "Power supply";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(13, 230);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 6;
            label10.Text = "Protection level";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(13, 184);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 5;
            label9.Text = "Weight";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(13, 138);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 4;
            label8.Text = "Power (kw)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 90);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 3;
            label7.Text = "Frequency band";
            // 
            // txtRange
            // 
            txtRange.BackColor = Color.FromArgb(40, 40, 40);
            txtRange.BorderStyle = BorderStyle.FixedSingle;
            txtRange.Font = new Font("Segoe UI", 10F);
            txtRange.ForeColor = Color.White;
            txtRange.Location = new Point(13, 60);
            txtRange.Name = "txtRange";
            txtRange.Size = new Size(267, 25);
            txtRange.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 40);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 1;
            label6.Text = "Range (km)";
            // 
            // cmbDeviceType
            // 
            cmbDeviceType.BackColor = Color.FromArgb(40, 40, 40);
            cmbDeviceType.FlatStyle = FlatStyle.Flat;
            cmbDeviceType.Font = new Font("Segoe UI", 10F);
            cmbDeviceType.ForeColor = Color.White;
            cmbDeviceType.FormattingEnabled = true;
            cmbDeviceType.Items.AddRange(new object[] { "радар", "рація", "тепловізор" });
            cmbDeviceType.Location = new Point(13, 15);
            cmbDeviceType.Name = "cmbDeviceType";
            cmbDeviceType.Size = new Size(267, 25);
            cmbDeviceType.TabIndex = 0;
            // 
            // ElectronicsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(electronicPanel);
            ForeColor = Color.White;
            Name = "ElectronicsPanel";
            Size = new Size(295, 419);
            electronicPanel.ResumeLayout(false);
            electronicPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public ComboBox cmbDeviceType;
        public TextBox txtRange;
        public ComboBox cmbFrequencyBand;
        public TextBox txtPower;
        public TextBox txtWeight;
        public TextBox txtProtectionLevel;
        public TextBox txtPowerSupply;
        private Panel electronicPanel;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}