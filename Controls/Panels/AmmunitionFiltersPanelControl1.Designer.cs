namespace MilitaryEquipmentStore.Controls.Panels
{
    partial class AmmunitionFiltersPanelControl1
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
        private void InitializeComponent()
        {
            groupAmmoType = new GroupBox();
            chkOtherAmmo = new CheckBox();
            chkCumulative = new CheckBox();
            chkTracer = new CheckBox();
            chkHighExplosive = new CheckBox();
            chkArmorPiercing = new CheckBox();
            chkAllAmmoTypes = new CheckBox();
            groupCaliber = new GroupBox();
            txtCaliber = new TextBox();
            groupWeight = new GroupBox();
            txtMaxWeight = new TextBox();
            txtMinWeight = new TextBox();
            lblMaxWeight = new Label();
            lblMinWeight = new Label();
            groupLength = new GroupBox();
            txtMaxLength = new TextBox();
            txtMinLength = new TextBox();
            lblMaxLength = new Label();
            lblMinLength = new Label();
            groupExplosiveType = new GroupBox();
            chkOtherExplosive = new CheckBox();
            chkHexogen = new CheckBox();
            chkRDX = new CheckBox();
            chkTNT = new CheckBox();
            chkNoExplosive = new CheckBox();
            chkAllExplosives = new CheckBox();
            groupEffectiveRange = new GroupBox();
            txtMaxRange = new TextBox();
            txtMinRange = new TextBox();
            lblMaxRange = new Label();
            lblMinRange = new Label();
            groupShelfLife = new GroupBox();
            txtMaxShelfLife = new TextBox();
            txtMinShelfLife = new TextBox();
            lblMaxShelfLife = new Label();
            lblMinShelfLife = new Label();
            btnApplyFilters = new Button();
            btnResetFilters = new Button();
            groupAmmoType.SuspendLayout();
            groupCaliber.SuspendLayout();
            groupWeight.SuspendLayout();
            groupLength.SuspendLayout();
            groupExplosiveType.SuspendLayout();
            groupEffectiveRange.SuspendLayout();
            groupShelfLife.SuspendLayout();
            SuspendLayout();
            // 
            // groupAmmoType
            // 
            groupAmmoType.BackColor = Color.FromArgb(25, 25, 25);
            groupAmmoType.Controls.Add(chkOtherAmmo);
            groupAmmoType.Controls.Add(chkCumulative);
            groupAmmoType.Controls.Add(chkTracer);
            groupAmmoType.Controls.Add(chkHighExplosive);
            groupAmmoType.Controls.Add(chkArmorPiercing);
            groupAmmoType.Controls.Add(chkAllAmmoTypes);
            groupAmmoType.ForeColor = Color.White;
            groupAmmoType.Location = new Point(10, 10);
            groupAmmoType.Name = "groupAmmoType";
            groupAmmoType.Size = new Size(220, 150);
            groupAmmoType.TabIndex = 0;
            groupAmmoType.TabStop = false;
            groupAmmoType.Text = "Тип боєприпаса";
            // 
            // chkOtherAmmo
            // 
            chkOtherAmmo.AutoSize = true;
            chkOtherAmmo.BackColor = Color.Transparent;
            chkOtherAmmo.ForeColor = Color.White;
            chkOtherAmmo.Location = new Point(120, 25);
            chkOtherAmmo.Name = "chkOtherAmmo";
            chkOtherAmmo.Size = new Size(61, 19);
            chkOtherAmmo.TabIndex = 5;
            chkOtherAmmo.Text = "Інший";
            chkOtherAmmo.UseVisualStyleBackColor = false;
            // 
            // chkCumulative
            // 
            chkCumulative.AutoSize = true;
            chkCumulative.BackColor = Color.Transparent;
            chkCumulative.ForeColor = Color.White;
            chkCumulative.Location = new Point(10, 125);
            chkCumulative.Name = "chkCumulative";
            chkCumulative.Size = new Size(106, 19);
            chkCumulative.TabIndex = 4;
            chkCumulative.Text = "Кумулятивний";
            chkCumulative.UseVisualStyleBackColor = false;
            // 
            // chkTracer
            // 
            chkTracer.AutoSize = true;
            chkTracer.BackColor = Color.Transparent;
            chkTracer.ForeColor = Color.White;
            chkTracer.Location = new Point(10, 100);
            chkTracer.Name = "chkTracer";
            chkTracer.Size = new Size(88, 19);
            chkTracer.TabIndex = 3;
            chkTracer.Text = "Трасуючий";
            chkTracer.UseVisualStyleBackColor = false;
            // 
            // chkHighExplosive
            // 
            chkHighExplosive.AutoSize = true;
            chkHighExplosive.BackColor = Color.Transparent;
            chkHighExplosive.ForeColor = Color.White;
            chkHighExplosive.Location = new Point(10, 75);
            chkHighExplosive.Name = "chkHighExplosive";
            chkHighExplosive.Size = new Size(44, 19);
            chkHighExplosive.TabIndex = 2;
            chkHighExplosive.Text = "ОФ";
            chkHighExplosive.UseVisualStyleBackColor = false;
            // 
            // chkArmorPiercing
            // 
            chkArmorPiercing.AutoSize = true;
            chkArmorPiercing.BackColor = Color.Transparent;
            chkArmorPiercing.ForeColor = Color.White;
            chkArmorPiercing.Location = new Point(10, 50);
            chkArmorPiercing.Name = "chkArmorPiercing";
            chkArmorPiercing.Size = new Size(40, 19);
            chkArmorPiercing.TabIndex = 1;
            chkArmorPiercing.Text = "БЗ";
            chkArmorPiercing.UseVisualStyleBackColor = false;
            // 
            // chkAllAmmoTypes
            // 
            chkAllAmmoTypes.AutoSize = true;
            chkAllAmmoTypes.BackColor = Color.Transparent;
            chkAllAmmoTypes.Checked = true;
            chkAllAmmoTypes.CheckState = CheckState.Checked;
            chkAllAmmoTypes.ForeColor = Color.White;
            chkAllAmmoTypes.Location = new Point(10, 25);
            chkAllAmmoTypes.Name = "chkAllAmmoTypes";
            chkAllAmmoTypes.Size = new Size(71, 19);
            chkAllAmmoTypes.TabIndex = 0;
            chkAllAmmoTypes.Text = "Всі типи";
            chkAllAmmoTypes.UseVisualStyleBackColor = false;
            // 
            // groupCaliber
            // 
            groupCaliber.BackColor = Color.FromArgb(25, 25, 25);
            groupCaliber.Controls.Add(txtCaliber);
            groupCaliber.ForeColor = Color.White;
            groupCaliber.Location = new Point(10, 170);
            groupCaliber.Name = "groupCaliber";
            groupCaliber.Size = new Size(220, 60);
            groupCaliber.TabIndex = 1;
            groupCaliber.TabStop = false;
            groupCaliber.Text = "Калібр";
            // 
            // txtCaliber
            // 
            txtCaliber.BackColor = Color.FromArgb(40, 40, 40);
            txtCaliber.BorderStyle = BorderStyle.FixedSingle;
            txtCaliber.ForeColor = Color.White;
            txtCaliber.Location = new Point(10, 25);
            txtCaliber.Name = "txtCaliber";
            txtCaliber.Size = new Size(200, 23);
            txtCaliber.TabIndex = 0;
            // 
            // groupWeight
            // 
            groupWeight.BackColor = Color.FromArgb(25, 25, 25);
            groupWeight.Controls.Add(txtMaxWeight);
            groupWeight.Controls.Add(txtMinWeight);
            groupWeight.Controls.Add(lblMaxWeight);
            groupWeight.Controls.Add(lblMinWeight);
            groupWeight.ForeColor = Color.White;
            groupWeight.Location = new Point(10, 240);
            groupWeight.Name = "groupWeight";
            groupWeight.Size = new Size(220, 80);
            groupWeight.TabIndex = 2;
            groupWeight.TabStop = false;
            groupWeight.Text = "Вага (кг)";
            // 
            // txtMaxWeight
            // 
            txtMaxWeight.BackColor = Color.FromArgb(40, 40, 40);
            txtMaxWeight.BorderStyle = BorderStyle.FixedSingle;
            txtMaxWeight.ForeColor = Color.White;
            txtMaxWeight.Location = new Point(50, 47);
            txtMaxWeight.Name = "txtMaxWeight";
            txtMaxWeight.Size = new Size(100, 23);
            txtMaxWeight.TabIndex = 3;
            // 
            // txtMinWeight
            // 
            txtMinWeight.BackColor = Color.FromArgb(40, 40, 40);
            txtMinWeight.BorderStyle = BorderStyle.FixedSingle;
            txtMinWeight.ForeColor = Color.White;
            txtMinWeight.Location = new Point(50, 22);
            txtMinWeight.Name = "txtMinWeight";
            txtMinWeight.Size = new Size(100, 23);
            txtMinWeight.TabIndex = 2;
            // 
            // lblMaxWeight
            // 
            lblMaxWeight.AutoSize = true;
            lblMaxWeight.BackColor = Color.Transparent;
            lblMaxWeight.ForeColor = Color.White;
            lblMaxWeight.Location = new Point(10, 50);
            lblMaxWeight.Name = "lblMaxWeight";
            lblMaxWeight.Size = new Size(25, 15);
            lblMaxWeight.TabIndex = 1;
            lblMaxWeight.Text = "До:";
            // 
            // lblMinWeight
            // 
            lblMinWeight.AutoSize = true;
            lblMinWeight.BackColor = Color.Transparent;
            lblMinWeight.ForeColor = Color.White;
            lblMinWeight.Location = new Point(10, 25);
            lblMinWeight.Name = "lblMinWeight";
            lblMinWeight.Size = new Size(26, 15);
            lblMinWeight.TabIndex = 0;
            lblMinWeight.Text = "Від:";
            // 
            // groupLength
            // 
            groupLength.BackColor = Color.FromArgb(25, 25, 25);
            groupLength.Controls.Add(txtMaxLength);
            groupLength.Controls.Add(txtMinLength);
            groupLength.Controls.Add(lblMaxLength);
            groupLength.Controls.Add(lblMinLength);
            groupLength.ForeColor = Color.White;
            groupLength.Location = new Point(10, 330);
            groupLength.Name = "groupLength";
            groupLength.Size = new Size(220, 80);
            groupLength.TabIndex = 3;
            groupLength.TabStop = false;
            groupLength.Text = "Довжина (мм)";
            // 
            // txtMaxLength
            // 
            txtMaxLength.BackColor = Color.FromArgb(40, 40, 40);
            txtMaxLength.BorderStyle = BorderStyle.FixedSingle;
            txtMaxLength.ForeColor = Color.White;
            txtMaxLength.Location = new Point(50, 47);
            txtMaxLength.Name = "txtMaxLength";
            txtMaxLength.Size = new Size(100, 23);
            txtMaxLength.TabIndex = 3;
            // 
            // txtMinLength
            // 
            txtMinLength.BackColor = Color.FromArgb(40, 40, 40);
            txtMinLength.BorderStyle = BorderStyle.FixedSingle;
            txtMinLength.ForeColor = Color.White;
            txtMinLength.Location = new Point(50, 22);
            txtMinLength.Name = "txtMinLength";
            txtMinLength.Size = new Size(100, 23);
            txtMinLength.TabIndex = 2;
            // 
            // lblMaxLength
            // 
            lblMaxLength.AutoSize = true;
            lblMaxLength.BackColor = Color.Transparent;
            lblMaxLength.ForeColor = Color.White;
            lblMaxLength.Location = new Point(10, 50);
            lblMaxLength.Name = "lblMaxLength";
            lblMaxLength.Size = new Size(25, 15);
            lblMaxLength.TabIndex = 1;
            lblMaxLength.Text = "До:";
            // 
            // lblMinLength
            // 
            lblMinLength.AutoSize = true;
            lblMinLength.BackColor = Color.Transparent;
            lblMinLength.ForeColor = Color.White;
            lblMinLength.Location = new Point(10, 25);
            lblMinLength.Name = "lblMinLength";
            lblMinLength.Size = new Size(26, 15);
            lblMinLength.TabIndex = 0;
            lblMinLength.Text = "Від:";
            // 
            // groupExplosiveType
            // 
            groupExplosiveType.BackColor = Color.FromArgb(25, 25, 25);
            groupExplosiveType.Controls.Add(chkOtherExplosive);
            groupExplosiveType.Controls.Add(chkHexogen);
            groupExplosiveType.Controls.Add(chkRDX);
            groupExplosiveType.Controls.Add(chkTNT);
            groupExplosiveType.Controls.Add(chkNoExplosive);
            groupExplosiveType.Controls.Add(chkAllExplosives);
            groupExplosiveType.ForeColor = Color.White;
            groupExplosiveType.Location = new Point(10, 420);
            groupExplosiveType.Name = "groupExplosiveType";
            groupExplosiveType.Size = new Size(220, 150);
            groupExplosiveType.TabIndex = 4;
            groupExplosiveType.TabStop = false;
            groupExplosiveType.Text = "Тип вибухівки";
            // 
            // chkOtherExplosive
            // 
            chkOtherExplosive.AutoSize = true;
            chkOtherExplosive.BackColor = Color.Transparent;
            chkOtherExplosive.ForeColor = Color.White;
            chkOtherExplosive.Location = new Point(120, 25);
            chkOtherExplosive.Name = "chkOtherExplosive";
            chkOtherExplosive.Size = new Size(61, 19);
            chkOtherExplosive.TabIndex = 5;
            chkOtherExplosive.Text = "Інший";
            chkOtherExplosive.UseVisualStyleBackColor = false;
            // 
            // chkHexogen
            // 
            chkHexogen.AutoSize = true;
            chkHexogen.BackColor = Color.Transparent;
            chkHexogen.ForeColor = Color.White;
            chkHexogen.Location = new Point(10, 125);
            chkHexogen.Name = "chkHexogen";
            chkHexogen.Size = new Size(75, 19);
            chkHexogen.TabIndex = 4;
            chkHexogen.Text = "Гексоген";
            chkHexogen.UseVisualStyleBackColor = false;
            // 
            // chkRDX
            // 
            chkRDX.AutoSize = true;
            chkRDX.BackColor = Color.Transparent;
            chkRDX.ForeColor = Color.White;
            chkRDX.Location = new Point(10, 100);
            chkRDX.Name = "chkRDX";
            chkRDX.Size = new Size(48, 19);
            chkRDX.TabIndex = 3;
            chkRDX.Text = "RDX";
            chkRDX.UseVisualStyleBackColor = false;
            // 
            // chkTNT
            // 
            chkTNT.AutoSize = true;
            chkTNT.BackColor = Color.Transparent;
            chkTNT.ForeColor = Color.White;
            chkTNT.Location = new Point(10, 75);
            chkTNT.Name = "chkTNT";
            chkTNT.Size = new Size(47, 19);
            chkTNT.TabIndex = 2;
            chkTNT.Text = "ТНТ";
            chkTNT.UseVisualStyleBackColor = false;
            // 
            // chkNoExplosive
            // 
            chkNoExplosive.AutoSize = true;
            chkNoExplosive.BackColor = Color.Transparent;
            chkNoExplosive.ForeColor = Color.White;
            chkNoExplosive.Location = new Point(10, 50);
            chkNoExplosive.Name = "chkNoExplosive";
            chkNoExplosive.Size = new Size(101, 19);
            chkNoExplosive.TabIndex = 1;
            chkNoExplosive.Text = "Без вибухівки";
            chkNoExplosive.UseVisualStyleBackColor = false;
            // 
            // chkAllExplosives
            // 
            chkAllExplosives.AutoSize = true;
            chkAllExplosives.BackColor = Color.Transparent;
            chkAllExplosives.Checked = true;
            chkAllExplosives.CheckState = CheckState.Checked;
            chkAllExplosives.ForeColor = Color.White;
            chkAllExplosives.Location = new Point(10, 25);
            chkAllExplosives.Name = "chkAllExplosives";
            chkAllExplosives.Size = new Size(71, 19);
            chkAllExplosives.TabIndex = 0;
            chkAllExplosives.Text = "Всі типи";
            chkAllExplosives.UseVisualStyleBackColor = false;
            // 
            // groupEffectiveRange
            // 
            groupEffectiveRange.BackColor = Color.FromArgb(25, 25, 25);
            groupEffectiveRange.Controls.Add(txtMaxRange);
            groupEffectiveRange.Controls.Add(txtMinRange);
            groupEffectiveRange.Controls.Add(lblMaxRange);
            groupEffectiveRange.Controls.Add(lblMinRange);
            groupEffectiveRange.ForeColor = Color.White;
            groupEffectiveRange.Location = new Point(10, 580);
            groupEffectiveRange.Name = "groupEffectiveRange";
            groupEffectiveRange.Size = new Size(220, 80);
            groupEffectiveRange.TabIndex = 5;
            groupEffectiveRange.TabStop = false;
            groupEffectiveRange.Text = "Ефективна дальність (м)";
            // 
            // txtMaxRange
            // 
            txtMaxRange.BackColor = Color.FromArgb(40, 40, 40);
            txtMaxRange.BorderStyle = BorderStyle.FixedSingle;
            txtMaxRange.ForeColor = Color.White;
            txtMaxRange.Location = new Point(50, 47);
            txtMaxRange.Name = "txtMaxRange";
            txtMaxRange.Size = new Size(100, 23);
            txtMaxRange.TabIndex = 3;
            // 
            // txtMinRange
            // 
            txtMinRange.BackColor = Color.FromArgb(40, 40, 40);
            txtMinRange.BorderStyle = BorderStyle.FixedSingle;
            txtMinRange.ForeColor = Color.White;
            txtMinRange.Location = new Point(50, 22);
            txtMinRange.Name = "txtMinRange";
            txtMinRange.Size = new Size(100, 23);
            txtMinRange.TabIndex = 2;
            // 
            // lblMaxRange
            // 
            lblMaxRange.AutoSize = true;
            lblMaxRange.BackColor = Color.Transparent;
            lblMaxRange.ForeColor = Color.White;
            lblMaxRange.Location = new Point(10, 50);
            lblMaxRange.Name = "lblMaxRange";
            lblMaxRange.Size = new Size(25, 15);
            lblMaxRange.TabIndex = 1;
            lblMaxRange.Text = "До:";
            // 
            // lblMinRange
            // 
            lblMinRange.AutoSize = true;
            lblMinRange.BackColor = Color.Transparent;
            lblMinRange.ForeColor = Color.White;
            lblMinRange.Location = new Point(10, 25);
            lblMinRange.Name = "lblMinRange";
            lblMinRange.Size = new Size(26, 15);
            lblMinRange.TabIndex = 0;
            lblMinRange.Text = "Від:";
            // 
            // groupShelfLife
            // 
            groupShelfLife.BackColor = Color.FromArgb(25, 25, 25);
            groupShelfLife.Controls.Add(txtMaxShelfLife);
            groupShelfLife.Controls.Add(txtMinShelfLife);
            groupShelfLife.Controls.Add(lblMaxShelfLife);
            groupShelfLife.Controls.Add(lblMinShelfLife);
            groupShelfLife.ForeColor = Color.White;
            groupShelfLife.Location = new Point(10, 670);
            groupShelfLife.Name = "groupShelfLife";
            groupShelfLife.Size = new Size(220, 80);
            groupShelfLife.TabIndex = 6;
            groupShelfLife.TabStop = false;
            groupShelfLife.Text = "Термін придатності (роки)";
            // 
            // txtMaxShelfLife
            // 
            txtMaxShelfLife.BackColor = Color.FromArgb(40, 40, 40);
            txtMaxShelfLife.BorderStyle = BorderStyle.FixedSingle;
            txtMaxShelfLife.ForeColor = Color.White;
            txtMaxShelfLife.Location = new Point(50, 47);
            txtMaxShelfLife.Name = "txtMaxShelfLife";
            txtMaxShelfLife.Size = new Size(100, 23);
            txtMaxShelfLife.TabIndex = 3;
            // 
            // txtMinShelfLife
            // 
            txtMinShelfLife.BackColor = Color.FromArgb(40, 40, 40);
            txtMinShelfLife.BorderStyle = BorderStyle.FixedSingle;
            txtMinShelfLife.ForeColor = Color.White;
            txtMinShelfLife.Location = new Point(50, 22);
            txtMinShelfLife.Name = "txtMinShelfLife";
            txtMinShelfLife.Size = new Size(100, 23);
            txtMinShelfLife.TabIndex = 2;
            // 
            // lblMaxShelfLife
            // 
            lblMaxShelfLife.AutoSize = true;
            lblMaxShelfLife.BackColor = Color.Transparent;
            lblMaxShelfLife.ForeColor = Color.White;
            lblMaxShelfLife.Location = new Point(10, 50);
            lblMaxShelfLife.Name = "lblMaxShelfLife";
            lblMaxShelfLife.Size = new Size(25, 15);
            lblMaxShelfLife.TabIndex = 1;
            lblMaxShelfLife.Text = "До:";
            // 
            // lblMinShelfLife
            // 
            lblMinShelfLife.AutoSize = true;
            lblMinShelfLife.BackColor = Color.Transparent;
            lblMinShelfLife.ForeColor = Color.White;
            lblMinShelfLife.Location = new Point(10, 25);
            lblMinShelfLife.Name = "lblMinShelfLife";
            lblMinShelfLife.Size = new Size(26, 15);
            lblMinShelfLife.TabIndex = 0;
            lblMinShelfLife.Text = "Від:";
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.BackColor = Color.FromArgb(40, 40, 40);
            btnApplyFilters.FlatStyle = FlatStyle.Flat;
            btnApplyFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnApplyFilters.ForeColor = Color.White;
            btnApplyFilters.Location = new Point(10, 760);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(100, 30);
            btnApplyFilters.TabIndex = 7;
            btnApplyFilters.Text = "Застосувати";
            btnApplyFilters.UseVisualStyleBackColor = false;
            btnApplyFilters.Click += btnApplyFilters_Click;
            // 
            // btnResetFilters
            // 
            btnResetFilters.BackColor = Color.FromArgb(40, 40, 40);
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnResetFilters.ForeColor = Color.White;
            btnResetFilters.Location = new Point(130, 760);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(100, 30);
            btnResetFilters.TabIndex = 8;
            btnResetFilters.Text = "Скинути";
            btnResetFilters.UseVisualStyleBackColor = false;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // AmmunitionFiltersPanelControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(btnResetFilters);
            Controls.Add(btnApplyFilters);
            Controls.Add(groupShelfLife);
            Controls.Add(groupEffectiveRange);
            Controls.Add(groupExplosiveType);
            Controls.Add(groupLength);
            Controls.Add(groupWeight);
            Controls.Add(groupCaliber);
            Controls.Add(groupAmmoType);
            Name = "AmmunitionFiltersPanelControl1";
            Size = new Size(240, 800);
            groupAmmoType.ResumeLayout(false);
            groupAmmoType.PerformLayout();
            groupCaliber.ResumeLayout(false);
            groupCaliber.PerformLayout();
            groupWeight.ResumeLayout(false);
            groupWeight.PerformLayout();
            groupLength.ResumeLayout(false);
            groupLength.PerformLayout();
            groupExplosiveType.ResumeLayout(false);
            groupExplosiveType.PerformLayout();
            groupEffectiveRange.ResumeLayout(false);
            groupEffectiveRange.PerformLayout();
            groupShelfLife.ResumeLayout(false);
            groupShelfLife.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupAmmoType;
        private System.Windows.Forms.CheckBox chkAllAmmoTypes;
        private System.Windows.Forms.CheckBox chkArmorPiercing;
        private System.Windows.Forms.CheckBox chkHighExplosive;
        private System.Windows.Forms.CheckBox chkTracer;
        private System.Windows.Forms.CheckBox chkCumulative;
        private System.Windows.Forms.CheckBox chkOtherAmmo;
        private System.Windows.Forms.GroupBox groupCaliber;
        private System.Windows.Forms.TextBox txtCaliber;
        private System.Windows.Forms.GroupBox groupWeight;
        private System.Windows.Forms.Label lblMinWeight;
        private System.Windows.Forms.Label lblMaxWeight;
        private System.Windows.Forms.TextBox txtMinWeight;
        private System.Windows.Forms.TextBox txtMaxWeight;
        private System.Windows.Forms.GroupBox groupLength;
        private System.Windows.Forms.Label lblMinLength;
        private System.Windows.Forms.Label lblMaxLength;
        private System.Windows.Forms.TextBox txtMinLength;
        private System.Windows.Forms.TextBox txtMaxLength;
        private System.Windows.Forms.GroupBox groupExplosiveType;
        private System.Windows.Forms.CheckBox chkAllExplosives;
        private System.Windows.Forms.CheckBox chkNoExplosive;
        private System.Windows.Forms.CheckBox chkTNT;
        private System.Windows.Forms.CheckBox chkRDX;
        private System.Windows.Forms.CheckBox chkHexogen;
        private System.Windows.Forms.CheckBox chkOtherExplosive;
        private System.Windows.Forms.GroupBox groupEffectiveRange;
        private System.Windows.Forms.Label lblMinRange;
        private System.Windows.Forms.Label lblMaxRange;
        private System.Windows.Forms.TextBox txtMinRange;
        private System.Windows.Forms.TextBox txtMaxRange;
        private System.Windows.Forms.GroupBox groupShelfLife;
        private System.Windows.Forms.Label lblMinShelfLife;
        private System.Windows.Forms.Label lblMaxShelfLife;
        private System.Windows.Forms.TextBox txtMinShelfLife;
        private System.Windows.Forms.TextBox txtMaxShelfLife;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnResetFilters;
    }
}