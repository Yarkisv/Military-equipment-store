namespace MilitaryEquipmentStore.Modal_windows
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            panelCategories = new Panel();
            tabControlCategories = new TabControl();
            tabPageElectronics = new TabPage();
            cbPowerSupply = new ComboBox();
            label17 = new Label();
            cbProtectionLevel = new ComboBox();
            label16 = new Label();
            txtWeightElectronics = new TextBox();
            label15 = new Label();
            txtPowerKw = new TextBox();
            label14 = new Label();
            cbFrequencyBand = new ComboBox();
            label13 = new Label();
            txtRangeKm = new TextBox();
            label12 = new Label();
            cbDeviceType = new ComboBox();
            label11 = new Label();
            tabPageTransport = new TabPage();
            txtWeightTransport = new TextBox();
            label27 = new Label();
            cbTransmissionType = new ComboBox();
            label26 = new Label();
            txtCrew = new TextBox();
            label25 = new Label();
            txtEnginePower = new TextBox();
            label24 = new Label();
            cbFuelType = new ComboBox();
            label23 = new Label();
            txtMaxSpeed = new TextBox();
            label22 = new Label();
            txtLoadCapacity = new TextBox();
            label21 = new Label();
            cbTransportType = new ComboBox();
            label20 = new Label();
            tabPageAmmunition = new TabPage();
            txtShelfLife = new TextBox();
            label37 = new Label();
            txtStorageTemp = new TextBox();
            label36 = new Label();
            txtEffectiveRange = new TextBox();
            label35 = new Label();
            cbExplosiveType = new ComboBox();
            label34 = new Label();
            txtLength = new TextBox();
            label33 = new Label();
            txtWeightAmmo = new TextBox();
            label32 = new Label();
            cbAmmoType = new ComboBox();
            label31 = new Label();
            txtCaliber = new TextBox();
            label30 = new Label();
            panelProductInfo = new Panel();
            label10 = new Label();
            txtDescription = new TextBox();
            label9 = new Label();
            txtPrice = new TextBox();
            label8 = new Label();
            txtName = new TextBox();
            label7 = new Label();
            txtArticle = new TextBox();
            label6 = new Label();
            cbCategory = new ComboBox();
            lblTitle = new Label();
            panelMain.SuspendLayout();
            panelCategories.SuspendLayout();
            tabControlCategories.SuspendLayout();
            tabPageElectronics.SuspendLayout();
            tabPageTransport.SuspendLayout();
            tabPageAmmunition.SuspendLayout();
            panelProductInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.BackColor = Color.White;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(btnCancel);
            panelMain.Controls.Add(btnSave);
            panelMain.Controls.Add(panelCategories);
            panelMain.Controls.Add(panelProductInfo);
            panelMain.Controls.Add(lblTitle);
            panelMain.Location = new Point(20, 20);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(760, 650);
            panelMain.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.BackColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(390, 595);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "СКАСУВАТИ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSave.BackColor = Color.Black;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(200, 595);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 40);
            btnSave.TabIndex = 3;
            btnSave.Text = "ЗБЕРЕГТИ";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panelCategories
            // 
            panelCategories.BackColor = Color.FromArgb(240, 240, 240);
            panelCategories.BorderStyle = BorderStyle.FixedSingle;
            panelCategories.Controls.Add(tabControlCategories);
            panelCategories.Location = new Point(30, 300);
            panelCategories.Name = "panelCategories";
            panelCategories.Size = new Size(700, 280);
            panelCategories.TabIndex = 2;
            // 
            // tabControlCategories
            // 
            tabControlCategories.Controls.Add(tabPageElectronics);
            tabControlCategories.Controls.Add(tabPageTransport);
            tabControlCategories.Controls.Add(tabPageAmmunition);
            tabControlCategories.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControlCategories.Location = new Point(3, 3);
            tabControlCategories.Name = "tabControlCategories";
            tabControlCategories.SelectedIndex = 0;
            tabControlCategories.Size = new Size(692, 272);
            tabControlCategories.TabIndex = 0;
            // 
            // tabPageElectronics
            // 
            tabPageElectronics.BackColor = Color.FromArgb(240, 240, 240);
            tabPageElectronics.Controls.Add(cbPowerSupply);
            tabPageElectronics.Controls.Add(label17);
            tabPageElectronics.Controls.Add(cbProtectionLevel);
            tabPageElectronics.Controls.Add(label16);
            tabPageElectronics.Controls.Add(txtWeightElectronics);
            tabPageElectronics.Controls.Add(label15);
            tabPageElectronics.Controls.Add(txtPowerKw);
            tabPageElectronics.Controls.Add(label14);
            tabPageElectronics.Controls.Add(cbFrequencyBand);
            tabPageElectronics.Controls.Add(label13);
            tabPageElectronics.Controls.Add(txtRangeKm);
            tabPageElectronics.Controls.Add(label12);
            tabPageElectronics.Controls.Add(cbDeviceType);
            tabPageElectronics.Controls.Add(label11);
            tabPageElectronics.Location = new Point(4, 24);
            tabPageElectronics.Name = "tabPageElectronics";
            tabPageElectronics.Padding = new Padding(3);
            tabPageElectronics.Size = new Size(684, 244);
            tabPageElectronics.TabIndex = 0;
            tabPageElectronics.Text = "Радіоелектроніка";
            // 
            // cbPowerSupply
            // 
            cbPowerSupply.BackColor = Color.White;
            cbPowerSupply.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPowerSupply.FlatStyle = FlatStyle.Flat;
            cbPowerSupply.Font = new Font("Segoe UI", 9F);
            cbPowerSupply.ForeColor = Color.Black;
            cbPowerSupply.FormattingEnabled = true;
            cbPowerSupply.Items.AddRange(new object[] { "Акумулятор", "220В", "Бортова мережа", "Інший" });
            cbPowerSupply.Location = new Point(180, 200);
            cbPowerSupply.Name = "cbPowerSupply";
            cbPowerSupply.Size = new Size(200, 23);
            cbPowerSupply.TabIndex = 13;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(20, 203);
            label17.Name = "label17";
            label17.Size = new Size(69, 15);
            label17.TabIndex = 12;
            label17.Text = "Живлення";
            // 
            // cbProtectionLevel
            // 
            cbProtectionLevel.BackColor = Color.White;
            cbProtectionLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProtectionLevel.FlatStyle = FlatStyle.Flat;
            cbProtectionLevel.Font = new Font("Segoe UI", 9F);
            cbProtectionLevel.ForeColor = Color.Black;
            cbProtectionLevel.FormattingEnabled = true;
            cbProtectionLevel.Items.AddRange(new object[] { "IP54", "IP55", "IP65", "IP66", "IP67", "IP68", "Інший" });
            cbProtectionLevel.Location = new Point(180, 170);
            cbProtectionLevel.Name = "cbProtectionLevel";
            cbProtectionLevel.Size = new Size(200, 23);
            cbProtectionLevel.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(20, 173);
            label16.Name = "label16";
            label16.Size = new Size(92, 15);
            label16.TabIndex = 10;
            label16.Text = "Рівень захисту";
            // 
            // txtWeightElectronics
            // 
            txtWeightElectronics.BackColor = Color.White;
            txtWeightElectronics.BorderStyle = BorderStyle.FixedSingle;
            txtWeightElectronics.Font = new Font("Segoe UI", 9F);
            txtWeightElectronics.ForeColor = Color.Black;
            txtWeightElectronics.Location = new Point(180, 140);
            txtWeightElectronics.Name = "txtWeightElectronics";
            txtWeightElectronics.Size = new Size(200, 23);
            txtWeightElectronics.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(20, 143);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 8;
            label15.Text = "Вага (кг)";
            // 
            // txtPowerKw
            // 
            txtPowerKw.BackColor = Color.White;
            txtPowerKw.BorderStyle = BorderStyle.FixedSingle;
            txtPowerKw.Font = new Font("Segoe UI", 9F);
            txtPowerKw.ForeColor = Color.Black;
            txtPowerKw.Location = new Point(180, 110);
            txtPowerKw.Name = "txtPowerKw";
            txtPowerKw.Size = new Size(200, 23);
            txtPowerKw.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(20, 113);
            label14.Name = "label14";
            label14.Size = new Size(103, 15);
            label14.TabIndex = 6;
            label14.Text = "Потужність (кВт)";
            // 
            // cbFrequencyBand
            // 
            cbFrequencyBand.BackColor = Color.White;
            cbFrequencyBand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFrequencyBand.FlatStyle = FlatStyle.Flat;
            cbFrequencyBand.Font = new Font("Segoe UI", 9F);
            cbFrequencyBand.ForeColor = Color.Black;
            cbFrequencyBand.FormattingEnabled = true;
            cbFrequencyBand.Items.AddRange(new object[] { "VHF", "UHF", "HF", "SHF", "Інший" });
            cbFrequencyBand.Location = new Point(180, 80);
            cbFrequencyBand.Name = "cbFrequencyBand";
            cbFrequencyBand.Size = new Size(200, 23);
            cbFrequencyBand.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(20, 83);
            label13.Name = "label13";
            label13.Size = new Size(120, 15);
            label13.TabIndex = 4;
            label13.Text = "Частотний діапазон";
            // 
            // txtRangeKm
            // 
            txtRangeKm.BackColor = Color.White;
            txtRangeKm.BorderStyle = BorderStyle.FixedSingle;
            txtRangeKm.Font = new Font("Segoe UI", 9F);
            txtRangeKm.ForeColor = Color.Black;
            txtRangeKm.Location = new Point(180, 50);
            txtRangeKm.Name = "txtRangeKm";
            txtRangeKm.Size = new Size(200, 23);
            txtRangeKm.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(20, 53);
            label12.Name = "label12";
            label12.Size = new Size(135, 15);
            label12.TabIndex = 2;
            label12.Text = "Дальність роботи (км)";
            // 
            // cbDeviceType
            // 
            cbDeviceType.BackColor = Color.White;
            cbDeviceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDeviceType.FlatStyle = FlatStyle.Flat;
            cbDeviceType.Font = new Font("Segoe UI", 9F);
            cbDeviceType.ForeColor = Color.Black;
            cbDeviceType.FormattingEnabled = true;
            cbDeviceType.Items.AddRange(new object[] { "Радар", "Радіостанція", "Тепловізор", "Інший" });
            cbDeviceType.Location = new Point(180, 20);
            cbDeviceType.Name = "cbDeviceType";
            cbDeviceType.Size = new Size(200, 23);
            cbDeviceType.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(20, 23);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 0;
            label11.Text = "Тип пристрою";
            // 
            // tabPageTransport
            // 
            tabPageTransport.BackColor = Color.FromArgb(240, 240, 240);
            tabPageTransport.Controls.Add(txtWeightTransport);
            tabPageTransport.Controls.Add(label27);
            tabPageTransport.Controls.Add(cbTransmissionType);
            tabPageTransport.Controls.Add(label26);
            tabPageTransport.Controls.Add(txtCrew);
            tabPageTransport.Controls.Add(label25);
            tabPageTransport.Controls.Add(txtEnginePower);
            tabPageTransport.Controls.Add(label24);
            tabPageTransport.Controls.Add(cbFuelType);
            tabPageTransport.Controls.Add(label23);
            tabPageTransport.Controls.Add(txtMaxSpeed);
            tabPageTransport.Controls.Add(label22);
            tabPageTransport.Controls.Add(txtLoadCapacity);
            tabPageTransport.Controls.Add(label21);
            tabPageTransport.Controls.Add(cbTransportType);
            tabPageTransport.Controls.Add(label20);
            tabPageTransport.Location = new Point(4, 24);
            tabPageTransport.Name = "tabPageTransport";
            tabPageTransport.Padding = new Padding(3);
            tabPageTransport.Size = new Size(684, 244);
            tabPageTransport.TabIndex = 1;
            tabPageTransport.Text = "Транспорт";
            // 
            // txtWeightTransport
            // 
            txtWeightTransport.BackColor = Color.White;
            txtWeightTransport.BorderStyle = BorderStyle.FixedSingle;
            txtWeightTransport.Font = new Font("Segoe UI", 9F);
            txtWeightTransport.ForeColor = Color.Black;
            txtWeightTransport.Location = new Point(180, 200);
            txtWeightTransport.Name = "txtWeightTransport";
            txtWeightTransport.Size = new Size(200, 23);
            txtWeightTransport.TabIndex = 15;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label27.ForeColor = Color.Black;
            label27.Location = new Point(20, 203);
            label27.Name = "label27";
            label27.Size = new Size(73, 15);
            label27.TabIndex = 14;
            label27.Text = "Маса (тонн)";
            // 
            // cbTransmissionType
            // 
            cbTransmissionType.BackColor = Color.White;
            cbTransmissionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTransmissionType.FlatStyle = FlatStyle.Flat;
            cbTransmissionType.Font = new Font("Segoe UI", 9F);
            cbTransmissionType.ForeColor = Color.Black;
            cbTransmissionType.FormattingEnabled = true;
            cbTransmissionType.Items.AddRange(new object[] { "Механічна", "Автоматична", "Гідромеханічна", "Інша" });
            cbTransmissionType.Location = new Point(180, 170);
            cbTransmissionType.Name = "cbTransmissionType";
            cbTransmissionType.Size = new Size(200, 23);
            cbTransmissionType.TabIndex = 13;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label26.ForeColor = Color.Black;
            label26.Location = new Point(20, 173);
            label26.Name = "label26";
            label26.Size = new Size(86, 15);
            label26.TabIndex = 12;
            label26.Text = "Тип трансмісії";
            // 
            // txtCrew
            // 
            txtCrew.BackColor = Color.White;
            txtCrew.BorderStyle = BorderStyle.FixedSingle;
            txtCrew.Font = new Font("Segoe UI", 9F);
            txtCrew.ForeColor = Color.Black;
            txtCrew.Location = new Point(180, 140);
            txtCrew.Name = "txtCrew";
            txtCrew.Size = new Size(200, 23);
            txtCrew.TabIndex = 11;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label25.ForeColor = Color.Black;
            label25.Location = new Point(20, 143);
            label25.Name = "label25";
            label25.Size = new Size(46, 15);
            label25.TabIndex = 10;
            label25.Text = "Екіпаж";
            // 
            // txtEnginePower
            // 
            txtEnginePower.BackColor = Color.White;
            txtEnginePower.BorderStyle = BorderStyle.FixedSingle;
            txtEnginePower.Font = new Font("Segoe UI", 9F);
            txtEnginePower.ForeColor = Color.Black;
            txtEnginePower.Location = new Point(180, 110);
            txtEnginePower.Name = "txtEnginePower";
            txtEnginePower.Size = new Size(200, 23);
            txtEnginePower.TabIndex = 9;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label24.ForeColor = Color.Black;
            label24.Location = new Point(20, 113);
            label24.Name = "label24";
            label24.Size = new Size(151, 15);
            label24.TabIndex = 8;
            label24.Text = "Потужність двигуна (л.с.)";
            // 
            // cbFuelType
            // 
            cbFuelType.BackColor = Color.White;
            cbFuelType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFuelType.FlatStyle = FlatStyle.Flat;
            cbFuelType.Font = new Font("Segoe UI", 9F);
            cbFuelType.ForeColor = Color.Black;
            cbFuelType.FormattingEnabled = true;
            cbFuelType.Items.AddRange(new object[] { "Дизель", "Бензин", "Гібрид", "Електро", "Інший" });
            cbFuelType.Location = new Point(180, 80);
            cbFuelType.Name = "cbFuelType";
            cbFuelType.Size = new Size(200, 23);
            cbFuelType.TabIndex = 7;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label23.ForeColor = Color.Black;
            label23.Location = new Point(20, 83);
            label23.Name = "label23";
            label23.Size = new Size(72, 15);
            label23.TabIndex = 6;
            label23.Text = "Тип палива";
            // 
            // txtMaxSpeed
            // 
            txtMaxSpeed.BackColor = Color.White;
            txtMaxSpeed.BorderStyle = BorderStyle.FixedSingle;
            txtMaxSpeed.Font = new Font("Segoe UI", 9F);
            txtMaxSpeed.ForeColor = Color.Black;
            txtMaxSpeed.Location = new Point(180, 50);
            txtMaxSpeed.Name = "txtMaxSpeed";
            txtMaxSpeed.Size = new Size(200, 23);
            txtMaxSpeed.TabIndex = 5;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label22.ForeColor = Color.Black;
            label22.Location = new Point(20, 53);
            label22.Name = "label22";
            label22.Size = new Size(150, 15);
            label22.TabIndex = 4;
            label22.Text = "Максимальна швидкість";
            // 
            // txtLoadCapacity
            // 
            txtLoadCapacity.BackColor = Color.White;
            txtLoadCapacity.BorderStyle = BorderStyle.FixedSingle;
            txtLoadCapacity.Font = new Font("Segoe UI", 9F);
            txtLoadCapacity.ForeColor = Color.Black;
            txtLoadCapacity.Location = new Point(180, 20);
            txtLoadCapacity.Name = "txtLoadCapacity";
            txtLoadCapacity.Size = new Size(200, 23);
            txtLoadCapacity.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label21.ForeColor = Color.Black;
            label21.Location = new Point(20, 23);
            label21.Name = "label21";
            label21.Size = new Size(141, 15);
            label21.TabIndex = 2;
            label21.Text = "Вантажопідйомність (т)";
            // 
            // cbTransportType
            // 
            cbTransportType.BackColor = Color.White;
            cbTransportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTransportType.FlatStyle = FlatStyle.Flat;
            cbTransportType.Font = new Font("Segoe UI", 9F);
            cbTransportType.ForeColor = Color.Black;
            cbTransportType.FormattingEnabled = true;
            cbTransportType.Items.AddRange(new object[] { "Вантажівка", "Броньовик", "Джип", "Тягач", "Інший" });
            cbTransportType.Location = new Point(470, 20);
            cbTransportType.Name = "cbTransportType";
            cbTransportType.Size = new Size(200, 23);
            cbTransportType.TabIndex = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label20.ForeColor = Color.Black;
            label20.Location = new Point(390, 23);
            label20.Name = "label20";
            label20.Size = new Size(72, 15);
            label20.TabIndex = 0;
            label20.Text = "Тип трансп.";
            // 
            // tabPageAmmunition
            // 
            tabPageAmmunition.BackColor = Color.FromArgb(240, 240, 240);
            tabPageAmmunition.Controls.Add(txtShelfLife);
            tabPageAmmunition.Controls.Add(label37);
            tabPageAmmunition.Controls.Add(txtStorageTemp);
            tabPageAmmunition.Controls.Add(label36);
            tabPageAmmunition.Controls.Add(txtEffectiveRange);
            tabPageAmmunition.Controls.Add(label35);
            tabPageAmmunition.Controls.Add(cbExplosiveType);
            tabPageAmmunition.Controls.Add(label34);
            tabPageAmmunition.Controls.Add(txtLength);
            tabPageAmmunition.Controls.Add(label33);
            tabPageAmmunition.Controls.Add(txtWeightAmmo);
            tabPageAmmunition.Controls.Add(label32);
            tabPageAmmunition.Controls.Add(cbAmmoType);
            tabPageAmmunition.Controls.Add(label31);
            tabPageAmmunition.Controls.Add(txtCaliber);
            tabPageAmmunition.Controls.Add(label30);
            tabPageAmmunition.Location = new Point(4, 24);
            tabPageAmmunition.Name = "tabPageAmmunition";
            tabPageAmmunition.Padding = new Padding(3);
            tabPageAmmunition.Size = new Size(684, 244);
            tabPageAmmunition.TabIndex = 2;
            tabPageAmmunition.Text = "Боєприпаси";
            // 
            // txtShelfLife
            // 
            txtShelfLife.BackColor = Color.White;
            txtShelfLife.BorderStyle = BorderStyle.FixedSingle;
            txtShelfLife.Font = new Font("Segoe UI", 9F);
            txtShelfLife.ForeColor = Color.Black;
            txtShelfLife.Location = new Point(180, 200);
            txtShelfLife.Name = "txtShelfLife";
            txtShelfLife.Size = new Size(200, 23);
            txtShelfLife.TabIndex = 15;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label37.ForeColor = Color.Black;
            label37.Location = new Point(20, 203);
            label37.Name = "label37";
            label37.Size = new Size(135, 15);
            label37.TabIndex = 14;
            label37.Text = "Термін придатності (р)";
            // 
            // txtStorageTemp
            // 
            txtStorageTemp.BackColor = Color.White;
            txtStorageTemp.BorderStyle = BorderStyle.FixedSingle;
            txtStorageTemp.Font = new Font("Segoe UI", 9F);
            txtStorageTemp.ForeColor = Color.Black;
            txtStorageTemp.Location = new Point(180, 170);
            txtStorageTemp.Name = "txtStorageTemp";
            txtStorageTemp.Size = new Size(200, 23);
            txtStorageTemp.TabIndex = 13;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label36.ForeColor = Color.Black;
            label36.Location = new Point(20, 173);
            label36.Name = "label36";
            label36.Size = new Size(145, 15);
            label36.TabIndex = 12;
            label36.Text = "Температура зберігання";
            // 
            // txtEffectiveRange
            // 
            txtEffectiveRange.BackColor = Color.White;
            txtEffectiveRange.BorderStyle = BorderStyle.FixedSingle;
            txtEffectiveRange.Font = new Font("Segoe UI", 9F);
            txtEffectiveRange.ForeColor = Color.Black;
            txtEffectiveRange.Location = new Point(180, 140);
            txtEffectiveRange.Name = "txtEffectiveRange";
            txtEffectiveRange.Size = new Size(200, 23);
            txtEffectiveRange.TabIndex = 11;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label35.ForeColor = Color.Black;
            label35.Location = new Point(20, 143);
            label35.Name = "label35";
            label35.Size = new Size(166, 15);
            label35.TabIndex = 10;
            label35.Text = "Ефективна дальність (метр)";
            // 
            // cbExplosiveType
            // 
            cbExplosiveType.BackColor = Color.White;
            cbExplosiveType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbExplosiveType.FlatStyle = FlatStyle.Flat;
            cbExplosiveType.Font = new Font("Segoe UI", 9F);
            cbExplosiveType.ForeColor = Color.Black;
            cbExplosiveType.FormattingEnabled = true;
            cbExplosiveType.Items.AddRange(new object[] { "Без вибухівки", "ТНТ", "RDX", "Гексоген", "Інший" });
            cbExplosiveType.Location = new Point(180, 110);
            cbExplosiveType.Name = "cbExplosiveType";
            cbExplosiveType.Size = new Size(200, 23);
            cbExplosiveType.TabIndex = 9;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label34.ForeColor = Color.Black;
            label34.Location = new Point(20, 113);
            label34.Name = "label34";
            label34.Size = new Size(117, 15);
            label34.TabIndex = 8;
            label34.Text = "Тип вибухової реч.";
            // 
            // txtLength
            // 
            txtLength.BackColor = Color.White;
            txtLength.BorderStyle = BorderStyle.FixedSingle;
            txtLength.Font = new Font("Segoe UI", 9F);
            txtLength.ForeColor = Color.Black;
            txtLength.Location = new Point(180, 80);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(200, 23);
            txtLength.TabIndex = 7;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label33.ForeColor = Color.Black;
            label33.Location = new Point(20, 83);
            label33.Name = "label33";
            label33.Size = new Size(118, 15);
            label33.TabIndex = 6;
            label33.Text = "Довжина (снаряда)";
            // 
            // txtWeightAmmo
            // 
            txtWeightAmmo.BackColor = Color.White;
            txtWeightAmmo.BorderStyle = BorderStyle.FixedSingle;
            txtWeightAmmo.Font = new Font("Segoe UI", 9F);
            txtWeightAmmo.ForeColor = Color.Black;
            txtWeightAmmo.Location = new Point(180, 50);
            txtWeightAmmo.Name = "txtWeightAmmo";
            txtWeightAmmo.Size = new Size(200, 23);
            txtWeightAmmo.TabIndex = 5;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label32.ForeColor = Color.Black;
            label32.Location = new Point(20, 53);
            label32.Name = "label32";
            label32.Size = new Size(55, 15);
            label32.TabIndex = 4;
            label32.Text = "Вага (кг)";
            // 
            // cbAmmoType
            // 
            cbAmmoType.BackColor = Color.White;
            cbAmmoType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAmmoType.FlatStyle = FlatStyle.Flat;
            cbAmmoType.Font = new Font("Segoe UI", 9F);
            cbAmmoType.ForeColor = Color.Black;
            cbAmmoType.FormattingEnabled = true;
            cbAmmoType.Items.AddRange(new object[] { "БЗ", "ОФ", "Трасуючий", "Кумулятивний", "Інший" });
            cbAmmoType.Location = new Point(470, 20);
            cbAmmoType.Name = "cbAmmoType";
            cbAmmoType.Size = new Size(200, 23);
            cbAmmoType.TabIndex = 3;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label31.ForeColor = Color.Black;
            label31.Location = new Point(390, 23);
            label31.Name = "label31";
            label31.Size = new Size(68, 15);
            label31.TabIndex = 2;
            label31.Text = "Тип боєпр.";
            // 
            // txtCaliber
            // 
            txtCaliber.BackColor = Color.White;
            txtCaliber.BorderStyle = BorderStyle.FixedSingle;
            txtCaliber.Font = new Font("Segoe UI", 9F);
            txtCaliber.ForeColor = Color.Black;
            txtCaliber.Location = new Point(180, 20);
            txtCaliber.Name = "txtCaliber";
            txtCaliber.Size = new Size(200, 23);
            txtCaliber.TabIndex = 1;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label30.ForeColor = Color.Black;
            label30.Location = new Point(20, 23);
            label30.Name = "label30";
            label30.Size = new Size(45, 15);
            label30.TabIndex = 0;
            label30.Text = "Калібр";
            // 
            // panelProductInfo
            // 
            panelProductInfo.BackColor = Color.FromArgb(240, 240, 240);
            panelProductInfo.BorderStyle = BorderStyle.FixedSingle;
            panelProductInfo.Controls.Add(label10);
            panelProductInfo.Controls.Add(txtDescription);
            panelProductInfo.Controls.Add(label9);
            panelProductInfo.Controls.Add(txtPrice);
            panelProductInfo.Controls.Add(label8);
            panelProductInfo.Controls.Add(txtName);
            panelProductInfo.Controls.Add(label7);
            panelProductInfo.Controls.Add(txtArticle);
            panelProductInfo.Controls.Add(label6);
            panelProductInfo.Controls.Add(cbCategory);
            panelProductInfo.Location = new Point(30, 70);
            panelProductInfo.Name = "panelProductInfo";
            panelProductInfo.Size = new Size(700, 220);
            panelProductInfo.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(20, 140);
            label10.Name = "label10";
            label10.Size = new Size(37, 15);
            label10.TabIndex = 9;
            label10.Text = "Опис";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = Color.Black;
            txtDescription.Location = new Point(150, 138);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(530, 65);
            txtDescription.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(20, 110);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 7;
            label9.Text = "Ціна";
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.ForeColor = Color.Black;
            txtPrice.Location = new Point(150, 108);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 25);
            txtPrice.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(20, 80);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 5;
            label8.Text = "Назва товару";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(150, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(513, 25);
            txtName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(20, 50);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 3;
            label7.Text = "Артикул";
            // 
            // txtArticle
            // 
            txtArticle.BackColor = Color.White;
            txtArticle.BorderStyle = BorderStyle.FixedSingle;
            txtArticle.Font = new Font("Segoe UI", 10F);
            txtArticle.ForeColor = Color.Black;
            txtArticle.Location = new Point(150, 48);
            txtArticle.Name = "txtArticle";
            txtArticle.Size = new Size(200, 25);
            txtArticle.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(20, 20);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 1;
            label6.Text = "Категорія товару";
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.White;
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.Font = new Font("Segoe UI", 10F);
            cbCategory.ForeColor = Color.Black;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "радіоелектроніка", "транспорт", "боєприпаси" });
            cbCategory.Location = new Point(150, 18);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(200, 25);
            cbCategory.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(270, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(204, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ДОДАТИ ТОВАР";
            // 
            // AddProductFormcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 690);
            Controls.Add(panelMain);
            ForeColor = Color.White;
            Name = "AddProductFormcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додати товар";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelCategories.ResumeLayout(false);
            tabControlCategories.ResumeLayout(false);
            tabPageElectronics.ResumeLayout(false);
            tabPageElectronics.PerformLayout();
            tabPageTransport.ResumeLayout(false);
            tabPageTransport.PerformLayout();
            tabPageAmmunition.ResumeLayout(false);
            tabPageAmmunition.PerformLayout();
            panelProductInfo.ResumeLayout(false);
            panelProductInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label lblTitle;
        private Panel panelProductInfo;
        private Panel panelCategories;
        private TabControl tabControlCategories;
        private TabPage tabPageElectronics;
        private TabPage tabPageTransport;
        private TabPage tabPageAmmunition;
        private Label label6;
        private ComboBox cbCategory;
        private Label label7;
        private TextBox txtArticle;
        private Label label8;
        private TextBox txtName;
        private Label label9;
        private TextBox txtPrice;
        private Label label10;
        private TextBox txtDescription;
        private ComboBox cbDeviceType;
        private Label label11;
        private Label label12;
        private TextBox txtRangeKm;
        private ComboBox cbFrequencyBand;
        private Label label13;
        private TextBox txtPowerKw;
        private Label label14;
        private TextBox txtWeightElectronics;
        private Label label15;
        private ComboBox cbProtectionLevel;
        private Label label16;
        private ComboBox cbPowerSupply;
        private Label label17;
        private ComboBox cbTransportType;
        private Label label20;
        private TextBox txtLoadCapacity;
        private Label label21;
        private TextBox txtMaxSpeed;
        private Label label22;
        private ComboBox cbFuelType;
        private Label label23;
        private TextBox txtEnginePower;
        private Label label24;
        private TextBox txtCrew;
        private Label label25;
        private ComboBox cbTransmissionType;
        private Label label26;
        private TextBox txtWeightTransport;
        private Label label27;
        private TextBox txtCaliber;
        private Label label30;
        private ComboBox cbAmmoType;
        private Label label31;
        private TextBox txtWeightAmmo;
        private Label label32;
        private TextBox txtLength;
        private Label label33;
        private ComboBox cbExplosiveType;
        private Label label34;
        private TextBox txtEffectiveRange;
        private Label label35;
        private TextBox txtStorageTemp;
        private Label label36;
        private TextBox txtShelfLife;
        private Label label37;
        private Button btnSave;
        private Button btnCancel;
    }
}