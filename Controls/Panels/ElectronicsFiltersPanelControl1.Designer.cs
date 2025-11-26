namespace MilitaryEquipmentStore.Controls.Panels
{
    partial class ElectronicsFiltersPanelControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        /// 

        private System.Windows.Forms.GroupBox groupDeviceType;
        private System.Windows.Forms.CheckBox chkAllDeviceTypes;
        private System.Windows.Forms.CheckBox chkRadar;
        private System.Windows.Forms.CheckBox chkRadio;
        private System.Windows.Forms.CheckBox chkThermal;
        private System.Windows.Forms.CheckBox chkOtherDevice;

        private System.Windows.Forms.GroupBox groupRange;
        private System.Windows.Forms.Label lblMinRange;
        private System.Windows.Forms.Label lblMaxRange;
        private System.Windows.Forms.TextBox txtMinRange;
        private System.Windows.Forms.TextBox txtMaxRange;

        private System.Windows.Forms.GroupBox groupFrequencyBand;
        private System.Windows.Forms.CheckBox chkAllFrequencies;
        private System.Windows.Forms.CheckBox chkVHF;
        private System.Windows.Forms.CheckBox chkUHF;
        private System.Windows.Forms.CheckBox chkHF;
        private System.Windows.Forms.CheckBox chkSHF;
        private System.Windows.Forms.CheckBox chkOtherFrequency;

        private System.Windows.Forms.GroupBox groupPower;
        private System.Windows.Forms.Label lblMinPower;
        private System.Windows.Forms.Label lblMaxPower;
        private System.Windows.Forms.TextBox txtMinPower;
        private System.Windows.Forms.TextBox txtMaxPower;

        private System.Windows.Forms.GroupBox groupWeight;
        private System.Windows.Forms.Label lblMinWeight;
        private System.Windows.Forms.Label lblMaxWeight;
        private System.Windows.Forms.TextBox txtMinWeight;
        private System.Windows.Forms.TextBox txtMaxWeight;

        private System.Windows.Forms.GroupBox groupProtectionLevel;
        private System.Windows.Forms.CheckBox chkAllProtection;
        private System.Windows.Forms.CheckBox chkIP54;
        private System.Windows.Forms.CheckBox chkIP55;
        private System.Windows.Forms.CheckBox chkIP65;
        private System.Windows.Forms.CheckBox chkIP66;
        private System.Windows.Forms.CheckBox chkIP67;
        private System.Windows.Forms.CheckBox chkIP68;
        private System.Windows.Forms.CheckBox chkOtherProtection;

        private System.Windows.Forms.GroupBox groupPowerSupply;
        private System.Windows.Forms.CheckBox chkAllPowerSupply;
        private System.Windows.Forms.CheckBox chkBattery;
        private System.Windows.Forms.CheckBox chk220V;
        private System.Windows.Forms.CheckBox chkVehicleNetwork;
        private System.Windows.Forms.CheckBox chkOtherPowerSupply;

        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnResetFilters;
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
            groupDeviceType = new GroupBox();
            chkOtherDevice = new CheckBox();
            chkThermal = new CheckBox();
            chkRadio = new CheckBox();
            chkRadar = new CheckBox();
            chkAllDeviceTypes = new CheckBox();
            groupRange = new GroupBox();
            txtMaxRange = new TextBox();
            txtMinRange = new TextBox();
            lblMaxRange = new Label();
            lblMinRange = new Label();
            groupFrequencyBand = new GroupBox();
            chkOtherFrequency = new CheckBox();
            chkSHF = new CheckBox();
            chkHF = new CheckBox();
            chkUHF = new CheckBox();
            chkVHF = new CheckBox();
            chkAllFrequencies = new CheckBox();
            groupPower = new GroupBox();
            txtMaxPower = new TextBox();
            txtMinPower = new TextBox();
            lblMaxPower = new Label();
            lblMinPower = new Label();
            groupWeight = new GroupBox();
            txtMaxWeight = new TextBox();
            txtMinWeight = new TextBox();
            lblMaxWeight = new Label();
            lblMinWeight = new Label();
            groupProtectionLevel = new GroupBox();
            chkOtherProtection = new CheckBox();
            chkIP68 = new CheckBox();
            chkIP67 = new CheckBox();
            chkIP66 = new CheckBox();
            chkIP65 = new CheckBox();
            chkIP55 = new CheckBox();
            chkIP54 = new CheckBox();
            chkAllProtection = new CheckBox();
            groupPowerSupply = new GroupBox();
            chkOtherPowerSupply = new CheckBox();
            chkVehicleNetwork = new CheckBox();
            chk220V = new CheckBox();
            chkBattery = new CheckBox();
            chkAllPowerSupply = new CheckBox();
            btnApplyFilters = new Button();
            btnResetFilters = new Button();
            groupDeviceType.SuspendLayout();
            groupRange.SuspendLayout();
            groupFrequencyBand.SuspendLayout();
            groupPower.SuspendLayout();
            groupWeight.SuspendLayout();
            groupProtectionLevel.SuspendLayout();
            groupPowerSupply.SuspendLayout();
            SuspendLayout();
            // 
            // groupDeviceType
            // 
            groupDeviceType.Controls.Add(chkOtherDevice);
            groupDeviceType.Controls.Add(chkThermal);
            groupDeviceType.Controls.Add(chkRadio);
            groupDeviceType.Controls.Add(chkRadar);
            groupDeviceType.Controls.Add(chkAllDeviceTypes);
            groupDeviceType.Location = new Point(10, 10);
            groupDeviceType.Name = "groupDeviceType";
            groupDeviceType.Size = new Size(220, 130);
            groupDeviceType.TabIndex = 0;
            groupDeviceType.TabStop = false;
            groupDeviceType.Text = "Тип пристрою";
            // 
            // chkOtherDevice
            // 
            chkOtherDevice.AutoSize = true;
            chkOtherDevice.Location = new Point(120, 25);
            chkOtherDevice.Name = "chkOtherDevice";
            chkOtherDevice.Size = new Size(61, 19);
            chkOtherDevice.TabIndex = 4;
            chkOtherDevice.Text = "Інший";
            chkOtherDevice.UseVisualStyleBackColor = true;
            // 
            // chkThermal
            // 
            chkThermal.AutoSize = true;
            chkThermal.Location = new Point(10, 100);
            chkThermal.Name = "chkThermal";
            chkThermal.Size = new Size(87, 19);
            chkThermal.TabIndex = 3;
            chkThermal.Text = "Тепловізор";
            chkThermal.UseVisualStyleBackColor = true;
            // 
            // chkRadio
            // 
            chkRadio.AutoSize = true;
            chkRadio.Location = new Point(10, 75);
            chkRadio.Name = "chkRadio";
            chkRadio.Size = new Size(95, 19);
            chkRadio.TabIndex = 2;
            chkRadio.Text = "Радіостанція";
            chkRadio.UseVisualStyleBackColor = true;
            // 
            // chkRadar
            // 
            chkRadar.AutoSize = true;
            chkRadar.Location = new Point(10, 50);
            chkRadar.Name = "chkRadar";
            chkRadar.Size = new Size(58, 19);
            chkRadar.TabIndex = 1;
            chkRadar.Text = "Радар";
            chkRadar.UseVisualStyleBackColor = true;
            // 
            // chkAllDeviceTypes
            // 
            chkAllDeviceTypes.AutoSize = true;
            chkAllDeviceTypes.Checked = true;
            chkAllDeviceTypes.CheckState = CheckState.Checked;
            chkAllDeviceTypes.Location = new Point(10, 25);
            chkAllDeviceTypes.Name = "chkAllDeviceTypes";
            chkAllDeviceTypes.Size = new Size(71, 19);
            chkAllDeviceTypes.TabIndex = 0;
            chkAllDeviceTypes.Text = "Всі типи";
            chkAllDeviceTypes.UseVisualStyleBackColor = true;
            // 
            // groupRange
            // 
            groupRange.Controls.Add(txtMaxRange);
            groupRange.Controls.Add(txtMinRange);
            groupRange.Controls.Add(lblMaxRange);
            groupRange.Controls.Add(lblMinRange);
            groupRange.Location = new Point(10, 150);
            groupRange.Name = "groupRange";
            groupRange.Size = new Size(220, 80);
            groupRange.TabIndex = 1;
            groupRange.TabStop = false;
            groupRange.Text = "Дальність (км)";
            // 
            // txtMaxRange
            // 
            txtMaxRange.Location = new Point(50, 47);
            txtMaxRange.Name = "txtMaxRange";
            txtMaxRange.Size = new Size(100, 23);
            txtMaxRange.TabIndex = 3;
            // 
            // txtMinRange
            // 
            txtMinRange.Location = new Point(50, 22);
            txtMinRange.Name = "txtMinRange";
            txtMinRange.Size = new Size(100, 23);
            txtMinRange.TabIndex = 2;
            // 
            // lblMaxRange
            // 
            lblMaxRange.AutoSize = true;
            lblMaxRange.Location = new Point(10, 50);
            lblMaxRange.Name = "lblMaxRange";
            lblMaxRange.Size = new Size(25, 15);
            lblMaxRange.TabIndex = 1;
            lblMaxRange.Text = "До:";
            // 
            // lblMinRange
            // 
            lblMinRange.AutoSize = true;
            lblMinRange.Location = new Point(10, 25);
            lblMinRange.Name = "lblMinRange";
            lblMinRange.Size = new Size(26, 15);
            lblMinRange.TabIndex = 0;
            lblMinRange.Text = "Від:";
            // 
            // groupFrequencyBand
            // 
            groupFrequencyBand.Controls.Add(chkOtherFrequency);
            groupFrequencyBand.Controls.Add(chkSHF);
            groupFrequencyBand.Controls.Add(chkHF);
            groupFrequencyBand.Controls.Add(chkUHF);
            groupFrequencyBand.Controls.Add(chkVHF);
            groupFrequencyBand.Controls.Add(chkAllFrequencies);
            groupFrequencyBand.Location = new Point(10, 240);
            groupFrequencyBand.Name = "groupFrequencyBand";
            groupFrequencyBand.Size = new Size(220, 150);
            groupFrequencyBand.TabIndex = 2;
            groupFrequencyBand.TabStop = false;
            groupFrequencyBand.Text = "Частотний діапазон";
            // 
            // chkOtherFrequency
            // 
            chkOtherFrequency.AutoSize = true;
            chkOtherFrequency.Location = new Point(120, 25);
            chkOtherFrequency.Name = "chkOtherFrequency";
            chkOtherFrequency.Size = new Size(61, 19);
            chkOtherFrequency.TabIndex = 5;
            chkOtherFrequency.Text = "Інший";
            chkOtherFrequency.UseVisualStyleBackColor = true;
            // 
            // chkSHF
            // 
            chkSHF.AutoSize = true;
            chkSHF.Location = new Point(10, 125);
            chkSHF.Name = "chkSHF";
            chkSHF.Size = new Size(47, 19);
            chkSHF.TabIndex = 4;
            chkSHF.Text = "SHF";
            chkSHF.UseVisualStyleBackColor = true;
            // 
            // chkHF
            // 
            chkHF.AutoSize = true;
            chkHF.Location = new Point(10, 100);
            chkHF.Name = "chkHF";
            chkHF.Size = new Size(41, 19);
            chkHF.TabIndex = 3;
            chkHF.Text = "HF";
            chkHF.UseVisualStyleBackColor = true;
            // 
            // chkUHF
            // 
            chkUHF.AutoSize = true;
            chkUHF.Location = new Point(10, 75);
            chkUHF.Name = "chkUHF";
            chkUHF.Size = new Size(49, 19);
            chkUHF.TabIndex = 2;
            chkUHF.Text = "UHF";
            chkUHF.UseVisualStyleBackColor = true;
            // 
            // chkVHF
            // 
            chkVHF.AutoSize = true;
            chkVHF.Location = new Point(10, 50);
            chkVHF.Name = "chkVHF";
            chkVHF.Size = new Size(48, 19);
            chkVHF.TabIndex = 1;
            chkVHF.Text = "VHF";
            chkVHF.UseVisualStyleBackColor = true;
            // 
            // chkAllFrequencies
            // 
            chkAllFrequencies.AutoSize = true;
            chkAllFrequencies.Checked = true;
            chkAllFrequencies.CheckState = CheckState.Checked;
            chkAllFrequencies.Location = new Point(10, 25);
            chkAllFrequencies.Name = "chkAllFrequencies";
            chkAllFrequencies.Size = new Size(71, 19);
            chkAllFrequencies.TabIndex = 0;
            chkAllFrequencies.Text = "Всі типи";
            chkAllFrequencies.UseVisualStyleBackColor = true;
            // 
            // groupPower
            // 
            groupPower.Controls.Add(txtMaxPower);
            groupPower.Controls.Add(txtMinPower);
            groupPower.Controls.Add(lblMaxPower);
            groupPower.Controls.Add(lblMinPower);
            groupPower.Location = new Point(10, 400);
            groupPower.Name = "groupPower";
            groupPower.Size = new Size(220, 80);
            groupPower.TabIndex = 3;
            groupPower.TabStop = false;
            groupPower.Text = "Потужність (кВт)";
            // 
            // txtMaxPower
            // 
            txtMaxPower.Location = new Point(50, 47);
            txtMaxPower.Name = "txtMaxPower";
            txtMaxPower.Size = new Size(100, 23);
            txtMaxPower.TabIndex = 3;
            // 
            // txtMinPower
            // 
            txtMinPower.Location = new Point(50, 22);
            txtMinPower.Name = "txtMinPower";
            txtMinPower.Size = new Size(100, 23);
            txtMinPower.TabIndex = 2;
            // 
            // lblMaxPower
            // 
            lblMaxPower.AutoSize = true;
            lblMaxPower.Location = new Point(10, 50);
            lblMaxPower.Name = "lblMaxPower";
            lblMaxPower.Size = new Size(25, 15);
            lblMaxPower.TabIndex = 1;
            lblMaxPower.Text = "До:";
            // 
            // lblMinPower
            // 
            lblMinPower.AutoSize = true;
            lblMinPower.Location = new Point(10, 25);
            lblMinPower.Name = "lblMinPower";
            lblMinPower.Size = new Size(26, 15);
            lblMinPower.TabIndex = 0;
            lblMinPower.Text = "Від:";
            // 
            // groupWeight
            // 
            groupWeight.Controls.Add(txtMaxWeight);
            groupWeight.Controls.Add(txtMinWeight);
            groupWeight.Controls.Add(lblMaxWeight);
            groupWeight.Controls.Add(lblMinWeight);
            groupWeight.Location = new Point(10, 490);
            groupWeight.Name = "groupWeight";
            groupWeight.Size = new Size(220, 80);
            groupWeight.TabIndex = 4;
            groupWeight.TabStop = false;
            groupWeight.Text = "Вага (кг)";
            // 
            // txtMaxWeight
            // 
            txtMaxWeight.Location = new Point(50, 47);
            txtMaxWeight.Name = "txtMaxWeight";
            txtMaxWeight.Size = new Size(100, 23);
            txtMaxWeight.TabIndex = 3;
            // 
            // txtMinWeight
            // 
            txtMinWeight.Location = new Point(50, 22);
            txtMinWeight.Name = "txtMinWeight";
            txtMinWeight.Size = new Size(100, 23);
            txtMinWeight.TabIndex = 2;
            // 
            // lblMaxWeight
            // 
            lblMaxWeight.AutoSize = true;
            lblMaxWeight.Location = new Point(10, 50);
            lblMaxWeight.Name = "lblMaxWeight";
            lblMaxWeight.Size = new Size(25, 15);
            lblMaxWeight.TabIndex = 1;
            lblMaxWeight.Text = "До:";
            // 
            // lblMinWeight
            // 
            lblMinWeight.AutoSize = true;
            lblMinWeight.Location = new Point(10, 25);
            lblMinWeight.Name = "lblMinWeight";
            lblMinWeight.Size = new Size(26, 15);
            lblMinWeight.TabIndex = 0;
            lblMinWeight.Text = "Від:";
            // 
            // groupProtectionLevel
            // 
            groupProtectionLevel.Controls.Add(chkOtherProtection);
            groupProtectionLevel.Controls.Add(chkIP68);
            groupProtectionLevel.Controls.Add(chkIP67);
            groupProtectionLevel.Controls.Add(chkIP66);
            groupProtectionLevel.Controls.Add(chkIP65);
            groupProtectionLevel.Controls.Add(chkIP55);
            groupProtectionLevel.Controls.Add(chkIP54);
            groupProtectionLevel.Controls.Add(chkAllProtection);
            groupProtectionLevel.Location = new Point(10, 580);
            groupProtectionLevel.Name = "groupProtectionLevel";
            groupProtectionLevel.Size = new Size(220, 180);
            groupProtectionLevel.TabIndex = 5;
            groupProtectionLevel.TabStop = false;
            groupProtectionLevel.Text = "Рівень захисту IP";
            // 
            // chkOtherProtection
            // 
            chkOtherProtection.AutoSize = true;
            chkOtherProtection.Location = new Point(100, 25);
            chkOtherProtection.Name = "chkOtherProtection";
            chkOtherProtection.Size = new Size(61, 19);
            chkOtherProtection.TabIndex = 7;
            chkOtherProtection.Text = "Інший";
            chkOtherProtection.UseVisualStyleBackColor = true;
            // 
            // chkIP68
            // 
            chkIP68.AutoSize = true;
            chkIP68.Location = new Point(100, 50);
            chkIP68.Name = "chkIP68";
            chkIP68.Size = new Size(48, 19);
            chkIP68.TabIndex = 6;
            chkIP68.Text = "IP68";
            chkIP68.UseVisualStyleBackColor = true;
            // 
            // chkIP67
            // 
            chkIP67.AutoSize = true;
            chkIP67.Location = new Point(10, 150);
            chkIP67.Name = "chkIP67";
            chkIP67.Size = new Size(48, 19);
            chkIP67.TabIndex = 5;
            chkIP67.Text = "IP67";
            chkIP67.UseVisualStyleBackColor = true;
            // 
            // chkIP66
            // 
            chkIP66.AutoSize = true;
            chkIP66.Location = new Point(10, 125);
            chkIP66.Name = "chkIP66";
            chkIP66.Size = new Size(48, 19);
            chkIP66.TabIndex = 4;
            chkIP66.Text = "IP66";
            chkIP66.UseVisualStyleBackColor = true;
            // 
            // chkIP65
            // 
            chkIP65.AutoSize = true;
            chkIP65.Location = new Point(10, 100);
            chkIP65.Name = "chkIP65";
            chkIP65.Size = new Size(48, 19);
            chkIP65.TabIndex = 3;
            chkIP65.Text = "IP65";
            chkIP65.UseVisualStyleBackColor = true;
            // 
            // chkIP55
            // 
            chkIP55.AutoSize = true;
            chkIP55.Location = new Point(10, 75);
            chkIP55.Name = "chkIP55";
            chkIP55.Size = new Size(48, 19);
            chkIP55.TabIndex = 2;
            chkIP55.Text = "IP55";
            chkIP55.UseVisualStyleBackColor = true;
            // 
            // chkIP54
            // 
            chkIP54.AutoSize = true;
            chkIP54.Location = new Point(10, 50);
            chkIP54.Name = "chkIP54";
            chkIP54.Size = new Size(48, 19);
            chkIP54.TabIndex = 1;
            chkIP54.Text = "IP54";
            chkIP54.UseVisualStyleBackColor = true;
            // 
            // chkAllProtection
            // 
            chkAllProtection.AutoSize = true;
            chkAllProtection.Checked = true;
            chkAllProtection.CheckState = CheckState.Checked;
            chkAllProtection.Location = new Point(10, 25);
            chkAllProtection.Name = "chkAllProtection";
            chkAllProtection.Size = new Size(71, 19);
            chkAllProtection.TabIndex = 0;
            chkAllProtection.Text = "Всі типи";
            chkAllProtection.UseVisualStyleBackColor = true;
            // 
            // groupPowerSupply
            // 
            groupPowerSupply.Controls.Add(chkOtherPowerSupply);
            groupPowerSupply.Controls.Add(chkVehicleNetwork);
            groupPowerSupply.Controls.Add(chk220V);
            groupPowerSupply.Controls.Add(chkBattery);
            groupPowerSupply.Controls.Add(chkAllPowerSupply);
            groupPowerSupply.Location = new Point(10, 770);
            groupPowerSupply.Name = "groupPowerSupply";
            groupPowerSupply.Size = new Size(220, 130);
            groupPowerSupply.TabIndex = 6;
            groupPowerSupply.TabStop = false;
            groupPowerSupply.Text = "Живлення";
            // 
            // chkOtherPowerSupply
            // 
            chkOtherPowerSupply.AutoSize = true;
            chkOtherPowerSupply.Location = new Point(120, 25);
            chkOtherPowerSupply.Name = "chkOtherPowerSupply";
            chkOtherPowerSupply.Size = new Size(61, 19);
            chkOtherPowerSupply.TabIndex = 4;
            chkOtherPowerSupply.Text = "Інший";
            chkOtherPowerSupply.UseVisualStyleBackColor = true;
            // 
            // chkVehicleNetwork
            // 
            chkVehicleNetwork.AutoSize = true;
            chkVehicleNetwork.Location = new Point(10, 100);
            chkVehicleNetwork.Name = "chkVehicleNetwork";
            chkVehicleNetwork.Size = new Size(117, 19);
            chkVehicleNetwork.TabIndex = 3;
            chkVehicleNetwork.Text = "Бортова мережа";
            chkVehicleNetwork.UseVisualStyleBackColor = true;
            // 
            // chk220V
            // 
            chk220V.AutoSize = true;
            chk220V.Location = new Point(10, 75);
            chk220V.Name = "chk220V";
            chk220V.Size = new Size(51, 19);
            chk220V.TabIndex = 2;
            chk220V.Text = "220В";
            chk220V.UseVisualStyleBackColor = true;
            // 
            // chkBattery
            // 
            chkBattery.AutoSize = true;
            chkBattery.Location = new Point(10, 50);
            chkBattery.Name = "chkBattery";
            chkBattery.Size = new Size(93, 19);
            chkBattery.TabIndex = 1;
            chkBattery.Text = "Акумулятор";
            chkBattery.UseVisualStyleBackColor = true;
            // 
            // chkAllPowerSupply
            // 
            chkAllPowerSupply.AutoSize = true;
            chkAllPowerSupply.Checked = true;
            chkAllPowerSupply.CheckState = CheckState.Checked;
            chkAllPowerSupply.Location = new Point(10, 25);
            chkAllPowerSupply.Name = "chkAllPowerSupply";
            chkAllPowerSupply.Size = new Size(71, 19);
            chkAllPowerSupply.TabIndex = 0;
            chkAllPowerSupply.Text = "Всі типи";
            chkAllPowerSupply.UseVisualStyleBackColor = true;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.Location = new Point(10, 910);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(100, 30);
            btnApplyFilters.TabIndex = 7;
            btnApplyFilters.Text = "Застосувати";
            btnApplyFilters.UseVisualStyleBackColor = true;
            btnApplyFilters.Click += btnApplyFilters_Click;
            // 
            // btnResetFilters
            // 
            btnResetFilters.Location = new Point(130, 910);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(100, 30);
            btnResetFilters.TabIndex = 8;
            btnResetFilters.Text = "Скинути";
            btnResetFilters.UseVisualStyleBackColor = true;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // ElectronicsFiltersPanelControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(btnResetFilters);
            Controls.Add(btnApplyFilters);
            Controls.Add(groupPowerSupply);
            Controls.Add(groupProtectionLevel);
            Controls.Add(groupWeight);
            Controls.Add(groupPower);
            Controls.Add(groupFrequencyBand);
            Controls.Add(groupRange);
            Controls.Add(groupDeviceType);
            Name = "ElectronicsFiltersPanelControl1";
            Size = new Size(240, 950);
            groupDeviceType.ResumeLayout(false);
            groupDeviceType.PerformLayout();
            groupRange.ResumeLayout(false);
            groupRange.PerformLayout();
            groupFrequencyBand.ResumeLayout(false);
            groupFrequencyBand.PerformLayout();
            groupPower.ResumeLayout(false);
            groupPower.PerformLayout();
            groupWeight.ResumeLayout(false);
            groupWeight.PerformLayout();
            groupProtectionLevel.ResumeLayout(false);
            groupProtectionLevel.PerformLayout();
            groupPowerSupply.ResumeLayout(false);
            groupPowerSupply.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}
