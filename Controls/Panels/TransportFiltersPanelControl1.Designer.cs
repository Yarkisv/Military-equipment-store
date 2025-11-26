namespace MilitaryEquipmentStore.Controls.Panels
{
    partial class TransportFiltersPanelControl1
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
        ///
        private System.Windows.Forms.GroupBox groupTransportType;
        private System.Windows.Forms.RadioButton rbAllTypes;
        private System.Windows.Forms.RadioButton rbTruck;
        private System.Windows.Forms.RadioButton rbArmor;
        private System.Windows.Forms.RadioButton rbJeep;
        private System.Windows.Forms.RadioButton rbTow;
        private System.Windows.Forms.RadioButton rbOther;

        // Новые элементы для дополнительных фильтров
        private System.Windows.Forms.GroupBox groupPrice;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.TextBox txtMaxPrice;

        private System.Windows.Forms.GroupBox groupLoadCapacity;
        private System.Windows.Forms.Label lblMinLoadCapacity;
        private System.Windows.Forms.Label lblMaxLoadCapacity;
        private System.Windows.Forms.TextBox txtMinLoadCapacity;
        private System.Windows.Forms.TextBox txtMaxLoadCapacity;

        private System.Windows.Forms.GroupBox groupMaxSpeed;
        private System.Windows.Forms.Label lblMinMaxSpeed;
        private System.Windows.Forms.Label lblMaxMaxSpeed;
        private System.Windows.Forms.TextBox txtMinMaxSpeed;
        private System.Windows.Forms.TextBox txtMaxMaxSpeed;

        private System.Windows.Forms.GroupBox groupFuelType;
        private System.Windows.Forms.CheckBox chkAllFuelTypes;
        private System.Windows.Forms.CheckBox chkDiesel;
        private System.Windows.Forms.CheckBox chkPetrol;
        private System.Windows.Forms.CheckBox chkHybrid;
        private System.Windows.Forms.CheckBox chkElectric;
        private System.Windows.Forms.CheckBox chkOtherFuel;

        private System.Windows.Forms.GroupBox groupEnginePower;
        private System.Windows.Forms.Label lblMinEnginePower;
        private System.Windows.Forms.Label lblMaxEnginePower;
        private System.Windows.Forms.TextBox txtMinEnginePower;
        private System.Windows.Forms.TextBox txtMaxEnginePower;

        private System.Windows.Forms.GroupBox groupCrew;
        private System.Windows.Forms.Label lblMinCrew;
        private System.Windows.Forms.Label lblMaxCrew;
        private System.Windows.Forms.TextBox txtMinCrew;
        private System.Windows.Forms.TextBox txtMaxCrew;

        private System.Windows.Forms.GroupBox groupTransmission;
        private System.Windows.Forms.CheckBox chkAllTransmissions;
        private System.Windows.Forms.CheckBox chkMechanical;
        private System.Windows.Forms.CheckBox chkAutomatic;
        private System.Windows.Forms.CheckBox chkHydroMechanical;
        private System.Windows.Forms.CheckBox chkOtherTransmission;

        private System.Windows.Forms.GroupBox groupWeight;
        private System.Windows.Forms.Label lblMinWeight;
        private System.Windows.Forms.Label lblMaxWeight;
        private System.Windows.Forms.TextBox txtMinWeight;
        private System.Windows.Forms.TextBox txtMaxWeight;

        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnResetFilters;

        // Панель для скроллинга
        private System.Windows.Forms.Panel mainPanel;

        private void InitializeComponent()
        {
            groupTransportType = new GroupBox();
            rbOther = new RadioButton();
            rbTow = new RadioButton();
            rbJeep = new RadioButton();
            rbArmor = new RadioButton();
            rbTruck = new RadioButton();
            rbAllTypes = new RadioButton();
            groupPrice = new GroupBox();
            txtMaxPrice = new TextBox();
            txtMinPrice = new TextBox();
            lblMaxPrice = new Label();
            lblMinPrice = new Label();
            groupLoadCapacity = new GroupBox();
            txtMaxLoadCapacity = new TextBox();
            txtMinLoadCapacity = new TextBox();
            lblMaxLoadCapacity = new Label();
            lblMinLoadCapacity = new Label();
            groupMaxSpeed = new GroupBox();
            txtMaxMaxSpeed = new TextBox();
            txtMinMaxSpeed = new TextBox();
            lblMaxMaxSpeed = new Label();
            lblMinMaxSpeed = new Label();
            groupFuelType = new GroupBox();
            chkOtherFuel = new CheckBox();
            chkElectric = new CheckBox();
            chkHybrid = new CheckBox();
            chkPetrol = new CheckBox();
            chkDiesel = new CheckBox();
            chkAllFuelTypes = new CheckBox();
            groupEnginePower = new GroupBox();
            txtMaxEnginePower = new TextBox();
            txtMinEnginePower = new TextBox();
            lblMaxEnginePower = new Label();
            lblMinEnginePower = new Label();
            groupCrew = new GroupBox();
            txtMaxCrew = new TextBox();
            txtMinCrew = new TextBox();
            lblMaxCrew = new Label();
            lblMinCrew = new Label();
            groupTransmission = new GroupBox();
            chkOtherTransmission = new CheckBox();
            chkHydroMechanical = new CheckBox();
            chkAutomatic = new CheckBox();
            chkMechanical = new CheckBox();
            chkAllTransmissions = new CheckBox();
            groupWeight = new GroupBox();
            txtMaxWeight = new TextBox();
            txtMinWeight = new TextBox();
            lblMaxWeight = new Label();
            lblMinWeight = new Label();
            btnApplyFilters = new Button();
            btnResetFilters = new Button();
            mainPanel = new Panel();
            groupTransportType.SuspendLayout();
            groupPrice.SuspendLayout();
            groupLoadCapacity.SuspendLayout();
            groupMaxSpeed.SuspendLayout();
            groupFuelType.SuspendLayout();
            groupEnginePower.SuspendLayout();
            groupCrew.SuspendLayout();
            groupTransmission.SuspendLayout();
            groupWeight.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // groupTransportType
            // 
            groupTransportType.Controls.Add(rbOther);
            groupTransportType.Controls.Add(rbTow);
            groupTransportType.Controls.Add(rbJeep);
            groupTransportType.Controls.Add(rbArmor);
            groupTransportType.Controls.Add(rbTruck);
            groupTransportType.Controls.Add(rbAllTypes);
            groupTransportType.Location = new Point(10, 10);
            groupTransportType.Name = "groupTransportType";
            groupTransportType.Size = new Size(220, 200);
            groupTransportType.TabIndex = 0;
            groupTransportType.TabStop = false;
            groupTransportType.Text = "Тип транспорту";
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(10, 150);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(60, 19);
            rbOther.TabIndex = 5;
            rbOther.Text = "Інший";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbTow
            // 
            rbTow.AutoSize = true;
            rbTow.Location = new Point(10, 125);
            rbTow.Name = "rbTow";
            rbTow.Size = new Size(55, 19);
            rbTow.TabIndex = 4;
            rbTow.Text = "Тягач";
            rbTow.UseVisualStyleBackColor = true;
            // 
            // rbJeep
            // 
            rbJeep.AutoSize = true;
            rbJeep.Location = new Point(10, 100);
            rbJeep.Name = "rbJeep";
            rbJeep.Size = new Size(56, 19);
            rbJeep.TabIndex = 3;
            rbJeep.Text = "Джип";
            rbJeep.UseVisualStyleBackColor = true;
            // 
            // rbArmor
            // 
            rbArmor.AutoSize = true;
            rbArmor.Location = new Point(10, 75);
            rbArmor.Name = "rbArmor";
            rbArmor.Size = new Size(85, 19);
            rbArmor.TabIndex = 2;
            rbArmor.Text = "Броньовик";
            rbArmor.UseVisualStyleBackColor = true;
            // 
            // rbTruck
            // 
            rbTruck.AutoSize = true;
            rbTruck.Location = new Point(10, 50);
            rbTruck.Name = "rbTruck";
            rbTruck.Size = new Size(86, 19);
            rbTruck.TabIndex = 1;
            rbTruck.Text = "Вантажівка";
            rbTruck.UseVisualStyleBackColor = true;
            // 
            // rbAllTypes
            // 
            rbAllTypes.AutoSize = true;
            rbAllTypes.Checked = true;
            rbAllTypes.Location = new Point(10, 25);
            rbAllTypes.Name = "rbAllTypes";
            rbAllTypes.Size = new Size(70, 19);
            rbAllTypes.TabIndex = 0;
            rbAllTypes.TabStop = true;
            rbAllTypes.Text = "Всі типи";
            rbAllTypes.UseVisualStyleBackColor = true;
            // 
            // groupPrice
            // 
            groupPrice.Controls.Add(txtMaxPrice);
            groupPrice.Controls.Add(txtMinPrice);
            groupPrice.Controls.Add(lblMaxPrice);
            groupPrice.Controls.Add(lblMinPrice);
            groupPrice.Location = new Point(10, 220);
            groupPrice.Name = "groupPrice";
            groupPrice.Size = new Size(220, 80);
            groupPrice.TabIndex = 1;
            groupPrice.TabStop = false;
            groupPrice.Text = "Ціна (грн)";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(50, 47);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(100, 23);
            txtMaxPrice.TabIndex = 3;
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(50, 22);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(100, 23);
            txtMinPrice.TabIndex = 2;
            // 
            // lblMaxPrice
            // 
            lblMaxPrice.AutoSize = true;
            lblMaxPrice.Location = new Point(10, 50);
            lblMaxPrice.Name = "lblMaxPrice";
            lblMaxPrice.Size = new Size(25, 15);
            lblMaxPrice.TabIndex = 1;
            lblMaxPrice.Text = "До:";
            // 
            // lblMinPrice
            // 
            lblMinPrice.AutoSize = true;
            lblMinPrice.Location = new Point(10, 25);
            lblMinPrice.Name = "lblMinPrice";
            lblMinPrice.Size = new Size(26, 15);
            lblMinPrice.TabIndex = 0;
            lblMinPrice.Text = "Від:";
            // 
            // groupLoadCapacity
            // 
            groupLoadCapacity.Controls.Add(txtMaxLoadCapacity);
            groupLoadCapacity.Controls.Add(txtMinLoadCapacity);
            groupLoadCapacity.Controls.Add(lblMaxLoadCapacity);
            groupLoadCapacity.Controls.Add(lblMinLoadCapacity);
            groupLoadCapacity.Location = new Point(10, 310);
            groupLoadCapacity.Name = "groupLoadCapacity";
            groupLoadCapacity.Size = new Size(220, 80);
            groupLoadCapacity.TabIndex = 2;
            groupLoadCapacity.TabStop = false;
            groupLoadCapacity.Text = "Грузопідйомність (тонни)";
            // 
            // txtMaxLoadCapacity
            // 
            txtMaxLoadCapacity.Location = new Point(50, 47);
            txtMaxLoadCapacity.Name = "txtMaxLoadCapacity";
            txtMaxLoadCapacity.Size = new Size(100, 23);
            txtMaxLoadCapacity.TabIndex = 3;
            // 
            // txtMinLoadCapacity
            // 
            txtMinLoadCapacity.Location = new Point(50, 22);
            txtMinLoadCapacity.Name = "txtMinLoadCapacity";
            txtMinLoadCapacity.Size = new Size(100, 23);
            txtMinLoadCapacity.TabIndex = 2;
            // 
            // lblMaxLoadCapacity
            // 
            lblMaxLoadCapacity.AutoSize = true;
            lblMaxLoadCapacity.Location = new Point(10, 50);
            lblMaxLoadCapacity.Name = "lblMaxLoadCapacity";
            lblMaxLoadCapacity.Size = new Size(25, 15);
            lblMaxLoadCapacity.TabIndex = 1;
            lblMaxLoadCapacity.Text = "До:";
            // 
            // lblMinLoadCapacity
            // 
            lblMinLoadCapacity.AutoSize = true;
            lblMinLoadCapacity.Location = new Point(10, 25);
            lblMinLoadCapacity.Name = "lblMinLoadCapacity";
            lblMinLoadCapacity.Size = new Size(26, 15);
            lblMinLoadCapacity.TabIndex = 0;
            lblMinLoadCapacity.Text = "Від:";
            // 
            // groupMaxSpeed
            // 
            groupMaxSpeed.Controls.Add(txtMaxMaxSpeed);
            groupMaxSpeed.Controls.Add(txtMinMaxSpeed);
            groupMaxSpeed.Controls.Add(lblMaxMaxSpeed);
            groupMaxSpeed.Controls.Add(lblMinMaxSpeed);
            groupMaxSpeed.Location = new Point(10, 400);
            groupMaxSpeed.Name = "groupMaxSpeed";
            groupMaxSpeed.Size = new Size(220, 80);
            groupMaxSpeed.TabIndex = 3;
            groupMaxSpeed.TabStop = false;
            groupMaxSpeed.Text = "Максимальна швидкість (км/год)";
            // 
            // txtMaxMaxSpeed
            // 
            txtMaxMaxSpeed.Location = new Point(50, 47);
            txtMaxMaxSpeed.Name = "txtMaxMaxSpeed";
            txtMaxMaxSpeed.Size = new Size(100, 23);
            txtMaxMaxSpeed.TabIndex = 3;
            // 
            // txtMinMaxSpeed
            // 
            txtMinMaxSpeed.Location = new Point(50, 22);
            txtMinMaxSpeed.Name = "txtMinMaxSpeed";
            txtMinMaxSpeed.Size = new Size(100, 23);
            txtMinMaxSpeed.TabIndex = 2;
            // 
            // lblMaxMaxSpeed
            // 
            lblMaxMaxSpeed.AutoSize = true;
            lblMaxMaxSpeed.Location = new Point(10, 50);
            lblMaxMaxSpeed.Name = "lblMaxMaxSpeed";
            lblMaxMaxSpeed.Size = new Size(25, 15);
            lblMaxMaxSpeed.TabIndex = 1;
            lblMaxMaxSpeed.Text = "До:";
            // 
            // lblMinMaxSpeed
            // 
            lblMinMaxSpeed.AutoSize = true;
            lblMinMaxSpeed.Location = new Point(10, 25);
            lblMinMaxSpeed.Name = "lblMinMaxSpeed";
            lblMinMaxSpeed.Size = new Size(26, 15);
            lblMinMaxSpeed.TabIndex = 0;
            lblMinMaxSpeed.Text = "Від:";
            // 
            // groupFuelType
            // 
            groupFuelType.Controls.Add(chkOtherFuel);
            groupFuelType.Controls.Add(chkElectric);
            groupFuelType.Controls.Add(chkHybrid);
            groupFuelType.Controls.Add(chkPetrol);
            groupFuelType.Controls.Add(chkDiesel);
            groupFuelType.Controls.Add(chkAllFuelTypes);
            groupFuelType.Location = new Point(10, 490);
            groupFuelType.Name = "groupFuelType";
            groupFuelType.Size = new Size(220, 150);
            groupFuelType.TabIndex = 4;
            groupFuelType.TabStop = false;
            groupFuelType.Text = "Тип палива";
            // 
            // chkOtherFuel
            // 
            chkOtherFuel.AutoSize = true;
            chkOtherFuel.Location = new Point(100, 25);
            chkOtherFuel.Name = "chkOtherFuel";
            chkOtherFuel.Size = new Size(61, 19);
            chkOtherFuel.TabIndex = 5;
            chkOtherFuel.Text = "Інший";
            chkOtherFuel.UseVisualStyleBackColor = true;
            // 
            // chkElectric
            // 
            chkElectric.AutoSize = true;
            chkElectric.Location = new Point(10, 125);
            chkElectric.Name = "chkElectric";
            chkElectric.Size = new Size(70, 19);
            chkElectric.TabIndex = 4;
            chkElectric.Text = "Електро";
            chkElectric.UseVisualStyleBackColor = true;
            // 
            // chkHybrid
            // 
            chkHybrid.AutoSize = true;
            chkHybrid.Location = new Point(10, 100);
            chkHybrid.Name = "chkHybrid";
            chkHybrid.Size = new Size(62, 19);
            chkHybrid.TabIndex = 3;
            chkHybrid.Text = "Гібрид";
            chkHybrid.UseVisualStyleBackColor = true;
            // 
            // chkPetrol
            // 
            chkPetrol.AutoSize = true;
            chkPetrol.Location = new Point(10, 75);
            chkPetrol.Name = "chkPetrol";
            chkPetrol.Size = new Size(65, 19);
            chkPetrol.TabIndex = 2;
            chkPetrol.Text = "Бензин";
            chkPetrol.UseVisualStyleBackColor = true;
            // 
            // chkDiesel
            // 
            chkDiesel.AutoSize = true;
            chkDiesel.Location = new Point(10, 50);
            chkDiesel.Name = "chkDiesel";
            chkDiesel.Size = new Size(65, 19);
            chkDiesel.TabIndex = 1;
            chkDiesel.Text = "Дизель";
            chkDiesel.UseVisualStyleBackColor = true;
            // 
            // chkAllFuelTypes
            // 
            chkAllFuelTypes.AutoSize = true;
            chkAllFuelTypes.Checked = true;
            chkAllFuelTypes.CheckState = CheckState.Checked;
            chkAllFuelTypes.Location = new Point(10, 25);
            chkAllFuelTypes.Name = "chkAllFuelTypes";
            chkAllFuelTypes.Size = new Size(71, 19);
            chkAllFuelTypes.TabIndex = 0;
            chkAllFuelTypes.Text = "Всі типи";
            chkAllFuelTypes.UseVisualStyleBackColor = true;
            // 
            // groupEnginePower
            // 
            groupEnginePower.Controls.Add(txtMaxEnginePower);
            groupEnginePower.Controls.Add(txtMinEnginePower);
            groupEnginePower.Controls.Add(lblMaxEnginePower);
            groupEnginePower.Controls.Add(lblMinEnginePower);
            groupEnginePower.Location = new Point(10, 650);
            groupEnginePower.Name = "groupEnginePower";
            groupEnginePower.Size = new Size(220, 80);
            groupEnginePower.TabIndex = 5;
            groupEnginePower.TabStop = false;
            groupEnginePower.Text = "Потужність двигуна (к.с.)";
            // 
            // txtMaxEnginePower
            // 
            txtMaxEnginePower.Location = new Point(50, 47);
            txtMaxEnginePower.Name = "txtMaxEnginePower";
            txtMaxEnginePower.Size = new Size(100, 23);
            txtMaxEnginePower.TabIndex = 3;
            // 
            // txtMinEnginePower
            // 
            txtMinEnginePower.Location = new Point(50, 22);
            txtMinEnginePower.Name = "txtMinEnginePower";
            txtMinEnginePower.Size = new Size(100, 23);
            txtMinEnginePower.TabIndex = 2;
            // 
            // lblMaxEnginePower
            // 
            lblMaxEnginePower.AutoSize = true;
            lblMaxEnginePower.Location = new Point(10, 50);
            lblMaxEnginePower.Name = "lblMaxEnginePower";
            lblMaxEnginePower.Size = new Size(25, 15);
            lblMaxEnginePower.TabIndex = 1;
            lblMaxEnginePower.Text = "До:";
            // 
            // lblMinEnginePower
            // 
            lblMinEnginePower.AutoSize = true;
            lblMinEnginePower.Location = new Point(10, 25);
            lblMinEnginePower.Name = "lblMinEnginePower";
            lblMinEnginePower.Size = new Size(26, 15);
            lblMinEnginePower.TabIndex = 0;
            lblMinEnginePower.Text = "Від:";
            // 
            // groupCrew
            // 
            groupCrew.Controls.Add(txtMaxCrew);
            groupCrew.Controls.Add(txtMinCrew);
            groupCrew.Controls.Add(lblMaxCrew);
            groupCrew.Controls.Add(lblMinCrew);
            groupCrew.Location = new Point(10, 740);
            groupCrew.Name = "groupCrew";
            groupCrew.Size = new Size(220, 80);
            groupCrew.TabIndex = 6;
            groupCrew.TabStop = false;
            groupCrew.Text = "Кількість людей";
            // 
            // txtMaxCrew
            // 
            txtMaxCrew.Location = new Point(50, 47);
            txtMaxCrew.Name = "txtMaxCrew";
            txtMaxCrew.Size = new Size(100, 23);
            txtMaxCrew.TabIndex = 3;
            // 
            // txtMinCrew
            // 
            txtMinCrew.Location = new Point(50, 22);
            txtMinCrew.Name = "txtMinCrew";
            txtMinCrew.Size = new Size(100, 23);
            txtMinCrew.TabIndex = 2;
            // 
            // lblMaxCrew
            // 
            lblMaxCrew.AutoSize = true;
            lblMaxCrew.Location = new Point(10, 50);
            lblMaxCrew.Name = "lblMaxCrew";
            lblMaxCrew.Size = new Size(25, 15);
            lblMaxCrew.TabIndex = 1;
            lblMaxCrew.Text = "До:";
            // 
            // lblMinCrew
            // 
            lblMinCrew.AutoSize = true;
            lblMinCrew.Location = new Point(10, 25);
            lblMinCrew.Name = "lblMinCrew";
            lblMinCrew.Size = new Size(26, 15);
            lblMinCrew.TabIndex = 0;
            lblMinCrew.Text = "Від:";
            // 
            // groupTransmission
            // 
            groupTransmission.Controls.Add(chkOtherTransmission);
            groupTransmission.Controls.Add(chkHydroMechanical);
            groupTransmission.Controls.Add(chkAutomatic);
            groupTransmission.Controls.Add(chkMechanical);
            groupTransmission.Controls.Add(chkAllTransmissions);
            groupTransmission.Location = new Point(10, 830);
            groupTransmission.Name = "groupTransmission";
            groupTransmission.Size = new Size(220, 120);
            groupTransmission.TabIndex = 7;
            groupTransmission.TabStop = false;
            groupTransmission.Text = "Тип трансмісії";
            // 
            // chkOtherTransmission
            // 
            chkOtherTransmission.AutoSize = true;
            chkOtherTransmission.Location = new Point(120, 25);
            chkOtherTransmission.Name = "chkOtherTransmission";
            chkOtherTransmission.Size = new Size(53, 19);
            chkOtherTransmission.TabIndex = 4;
            chkOtherTransmission.Text = "Інша";
            chkOtherTransmission.UseVisualStyleBackColor = true;
            // 
            // chkHydroMechanical
            // 
            chkHydroMechanical.AutoSize = true;
            chkHydroMechanical.Location = new Point(10, 100);
            chkHydroMechanical.Name = "chkHydroMechanical";
            chkHydroMechanical.Size = new Size(112, 19);
            chkHydroMechanical.TabIndex = 3;
            chkHydroMechanical.Text = "Гідромеханічна";
            chkHydroMechanical.UseVisualStyleBackColor = true;
            // 
            // chkAutomatic
            // 
            chkAutomatic.AutoSize = true;
            chkAutomatic.Location = new Point(10, 75);
            chkAutomatic.Name = "chkAutomatic";
            chkAutomatic.Size = new Size(99, 19);
            chkAutomatic.TabIndex = 2;
            chkAutomatic.Text = "Автоматична";
            chkAutomatic.UseVisualStyleBackColor = true;
            // 
            // chkMechanical
            // 
            chkMechanical.AutoSize = true;
            chkMechanical.Location = new Point(10, 50);
            chkMechanical.Name = "chkMechanical";
            chkMechanical.Size = new Size(85, 19);
            chkMechanical.TabIndex = 1;
            chkMechanical.Text = "Механічна";
            chkMechanical.UseVisualStyleBackColor = true;
            // 
            // chkAllTransmissions
            // 
            chkAllTransmissions.AutoSize = true;
            chkAllTransmissions.Checked = true;
            chkAllTransmissions.CheckState = CheckState.Checked;
            chkAllTransmissions.Location = new Point(10, 25);
            chkAllTransmissions.Name = "chkAllTransmissions";
            chkAllTransmissions.Size = new Size(71, 19);
            chkAllTransmissions.TabIndex = 0;
            chkAllTransmissions.Text = "Всі типи";
            chkAllTransmissions.UseVisualStyleBackColor = true;
            // 
            // groupWeight
            // 
            groupWeight.Controls.Add(txtMaxWeight);
            groupWeight.Controls.Add(txtMinWeight);
            groupWeight.Controls.Add(lblMaxWeight);
            groupWeight.Controls.Add(lblMinWeight);
            groupWeight.Location = new Point(10, 960);
            groupWeight.Name = "groupWeight";
            groupWeight.Size = new Size(220, 80);
            groupWeight.TabIndex = 8;
            groupWeight.TabStop = false;
            groupWeight.Text = "Вага (тонни)";
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
            // btnApplyFilters
            // 
            btnApplyFilters.Location = new Point(10, 1050);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(100, 30);
            btnApplyFilters.TabIndex = 9;
            btnApplyFilters.Text = "Застосувати";
            btnApplyFilters.UseVisualStyleBackColor = true;
            btnApplyFilters.Click += btnApplyFilters_Click;
            // 
            // btnResetFilters
            // 
            btnResetFilters.Location = new Point(130, 1050);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(100, 30);
            btnResetFilters.TabIndex = 10;
            btnResetFilters.Text = "Скинути";
            btnResetFilters.UseVisualStyleBackColor = true;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Controls.Add(groupTransportType);
            mainPanel.Controls.Add(groupPrice);
            mainPanel.Controls.Add(groupLoadCapacity);
            mainPanel.Controls.Add(groupMaxSpeed);
            mainPanel.Controls.Add(groupFuelType);
            mainPanel.Controls.Add(groupEnginePower);
            mainPanel.Controls.Add(groupCrew);
            mainPanel.Controls.Add(groupTransmission);
            mainPanel.Controls.Add(groupWeight);
            mainPanel.Controls.Add(btnApplyFilters);
            mainPanel.Controls.Add(btnResetFilters);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(260, 600);
            mainPanel.TabIndex = 0;
            // 
            // TransportFiltersPanelControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPanel);
            Name = "TransportFiltersPanelControl1";
            Size = new Size(260, 600);
            groupTransportType.ResumeLayout(false);
            groupTransportType.PerformLayout();
            groupPrice.ResumeLayout(false);
            groupPrice.PerformLayout();
            groupLoadCapacity.ResumeLayout(false);
            groupLoadCapacity.PerformLayout();
            groupMaxSpeed.ResumeLayout(false);
            groupMaxSpeed.PerformLayout();
            groupFuelType.ResumeLayout(false);
            groupFuelType.PerformLayout();
            groupEnginePower.ResumeLayout(false);
            groupEnginePower.PerformLayout();
            groupCrew.ResumeLayout(false);
            groupCrew.PerformLayout();
            groupTransmission.ResumeLayout(false);
            groupTransmission.PerformLayout();
            groupWeight.ResumeLayout(false);
            groupWeight.PerformLayout();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
