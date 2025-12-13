namespace MilitaryEquipmentStore.Controls.Panels.CategoryEditPanels
{
    partial class AmmunitionPanel
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
            ammoPanel = new Panel();
            txtShelfLife = new TextBox();
            txtStorageTemp = new TextBox();
            txtEffectiveRange = new TextBox();
            cmbExplosiveType = new ComboBox();
            txtLength = new TextBox();
            txtWeight = new TextBox();
            cmbAmmoType = new ComboBox();
            txtCaliber = new TextBox();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            ammoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ammoPanel
            // 
            ammoPanel.BackColor = Color.FromArgb(20, 20, 20);
            ammoPanel.Controls.Add(txtShelfLife);
            ammoPanel.Controls.Add(txtStorageTemp);
            ammoPanel.Controls.Add(txtEffectiveRange);
            ammoPanel.Controls.Add(cmbExplosiveType);
            ammoPanel.Controls.Add(txtLength);
            ammoPanel.Controls.Add(txtWeight);
            ammoPanel.Controls.Add(cmbAmmoType);
            ammoPanel.Controls.Add(txtCaliber);
            ammoPanel.Controls.Add(label27);
            ammoPanel.Controls.Add(label26);
            ammoPanel.Controls.Add(label25);
            ammoPanel.Controls.Add(label24);
            ammoPanel.Controls.Add(label23);
            ammoPanel.Controls.Add(label22);
            ammoPanel.Controls.Add(label21);
            ammoPanel.Controls.Add(label20);
            ammoPanel.Dock = DockStyle.Fill;
            ammoPanel.Location = new Point(0, 0);
            ammoPanel.Name = "ammoPanel";
            ammoPanel.Size = new Size(295, 404);
            ammoPanel.TabIndex = 4;
            // 
            // txtShelfLife
            // 
            txtShelfLife.BackColor = Color.FromArgb(40, 40, 40);
            txtShelfLife.BorderStyle = BorderStyle.FixedSingle;
            txtShelfLife.Font = new Font("Segoe UI", 10F);
            txtShelfLife.ForeColor = Color.White;
            txtShelfLife.Location = new Point(13, 356);
            txtShelfLife.Name = "txtShelfLife";
            txtShelfLife.Size = new Size(267, 25);
            txtShelfLife.TabIndex = 15;
            // 
            // txtStorageTemp
            // 
            txtStorageTemp.BackColor = Color.FromArgb(40, 40, 40);
            txtStorageTemp.BorderStyle = BorderStyle.FixedSingle;
            txtStorageTemp.Font = new Font("Segoe UI", 10F);
            txtStorageTemp.ForeColor = Color.White;
            txtStorageTemp.Location = new Point(13, 310);
            txtStorageTemp.Name = "txtStorageTemp";
            txtStorageTemp.Size = new Size(267, 25);
            txtStorageTemp.TabIndex = 14;
            // 
            // txtEffectiveRange
            // 
            txtEffectiveRange.BackColor = Color.FromArgb(40, 40, 40);
            txtEffectiveRange.BorderStyle = BorderStyle.FixedSingle;
            txtEffectiveRange.Font = new Font("Segoe UI", 10F);
            txtEffectiveRange.ForeColor = Color.White;
            txtEffectiveRange.Location = new Point(13, 264);
            txtEffectiveRange.Name = "txtEffectiveRange";
            txtEffectiveRange.Size = new Size(267, 25);
            txtEffectiveRange.TabIndex = 13;
            // 
            // cmbExplosiveType
            // 
            cmbExplosiveType.BackColor = Color.FromArgb(40, 40, 40);
            cmbExplosiveType.FlatStyle = FlatStyle.Flat;
            cmbExplosiveType.Font = new Font("Segoe UI", 10F);
            cmbExplosiveType.ForeColor = Color.White;
            cmbExplosiveType.FormattingEnabled = true;
            cmbExplosiveType.Items.AddRange(new object[] { "Без вибухівки", "ТНТ", "RDX", "Гексоген", "Інший" });
            cmbExplosiveType.Location = new Point(13, 218);
            cmbExplosiveType.Name = "cmbExplosiveType";
            cmbExplosiveType.Size = new Size(267, 25);
            cmbExplosiveType.TabIndex = 12;
            // 
            // txtLength
            // 
            txtLength.BackColor = Color.FromArgb(40, 40, 40);
            txtLength.BorderStyle = BorderStyle.FixedSingle;
            txtLength.Font = new Font("Segoe UI", 10F);
            txtLength.ForeColor = Color.White;
            txtLength.Location = new Point(13, 172);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(267, 25);
            txtLength.TabIndex = 11;
            // 
            // txtWeight
            // 
            txtWeight.BackColor = Color.FromArgb(40, 40, 40);
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Font = new Font("Segoe UI", 10F);
            txtWeight.ForeColor = Color.White;
            txtWeight.Location = new Point(13, 126);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(267, 25);
            txtWeight.TabIndex = 10;
            // 
            // cmbAmmoType
            // 
            cmbAmmoType.BackColor = Color.FromArgb(40, 40, 40);
            cmbAmmoType.FlatStyle = FlatStyle.Flat;
            cmbAmmoType.Font = new Font("Segoe UI", 10F);
            cmbAmmoType.ForeColor = Color.White;
            cmbAmmoType.FormattingEnabled = true;
            cmbAmmoType.Items.AddRange(new object[] { "БЗ", "ОФ", "Трасуючий", "Кумулятивний", "Інший" });
            cmbAmmoType.Location = new Point(13, 80);
            cmbAmmoType.Name = "cmbAmmoType";
            cmbAmmoType.Size = new Size(267, 25);
            cmbAmmoType.TabIndex = 9;
            // 
            // txtCaliber
            // 
            txtCaliber.BackColor = Color.FromArgb(40, 40, 40);
            txtCaliber.BorderStyle = BorderStyle.FixedSingle;
            txtCaliber.Font = new Font("Segoe UI", 10F);
            txtCaliber.ForeColor = Color.White;
            txtCaliber.Location = new Point(13, 34);
            txtCaliber.Name = "txtCaliber";
            txtCaliber.Size = new Size(267, 25);
            txtCaliber.TabIndex = 8;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label27.ForeColor = Color.White;
            label27.Location = new Point(13, 338);
            label27.Name = "label27";
            label27.Size = new Size(57, 15);
            label27.TabIndex = 7;
            label27.Text = "Shelf life";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label26.ForeColor = Color.White;
            label26.Location = new Point(14, 292);
            label26.Name = "label26";
            label26.Size = new Size(84, 15);
            label26.TabIndex = 6;
            label26.Text = "Storage temp";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label25.ForeColor = Color.White;
            label25.Location = new Point(13, 246);
            label25.Name = "label25";
            label25.Size = new Size(93, 15);
            label25.TabIndex = 5;
            label25.Text = "Effective range";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label24.ForeColor = Color.White;
            label24.Location = new Point(14, 200);
            label24.Name = "label24";
            label24.Size = new Size(87, 15);
            label24.TabIndex = 4;
            label24.Text = "Explosive type";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label23.ForeColor = Color.White;
            label23.Location = new Point(13, 154);
            label23.Name = "label23";
            label23.Size = new Size(46, 15);
            label23.TabIndex = 3;
            label23.Text = "Length";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label22.ForeColor = Color.White;
            label22.Location = new Point(13, 108);
            label22.Name = "label22";
            label22.Size = new Size(48, 15);
            label22.TabIndex = 2;
            label22.Text = "Weight";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label21.ForeColor = Color.White;
            label21.Location = new Point(13, 62);
            label21.Name = "label21";
            label21.Size = new Size(72, 15);
            label21.TabIndex = 1;
            label21.Text = "Ammo type";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label20.ForeColor = Color.White;
            label20.Location = new Point(13, 16);
            label20.Name = "label20";
            label20.Size = new Size(45, 15);
            label20.TabIndex = 0;
            label20.Text = "Caliber";
            // 
            // AmmunitionPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(ammoPanel);
            ForeColor = Color.White;
            Name = "AmmunitionPanel";
            Size = new Size(295, 404);
            ammoPanel.ResumeLayout(false);
            ammoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public TextBox txtCaliber;
        public ComboBox cmbAmmoType;
        public TextBox txtWeight;
        public TextBox txtLength;
        public ComboBox cmbExplosiveType;
        public TextBox txtEffectiveRange;
        public TextBox txtStorageTemp;
        public TextBox txtShelfLife;
        private Panel ammoPanel;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
    }
}