namespace MilitaryEquipmentStore.Controls.Auth
{
    partial class LoginUserControl
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
            loginButton = new Button();
            labelEmail = new Label();
            labelPassword = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            panelCard = new Panel();
            labelSubtitle = new Label();
            labelTitle = new Label();
            panelLogo = new Panel();
            labelLogo = new Label();
            panelCard.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            loginButton.BackColor = Color.FromArgb(40, 40, 40);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(30, 210);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(290, 40);
            loginButton.TabIndex = 3;
            loginButton.Text = "Увійти";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(30, 70);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(30, 130);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(50, 15);
            labelPassword.TabIndex = 0;
            labelPassword.Text = "Пароль";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.BackColor = Color.FromArgb(40, 40, 40);
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Segoe UI", 10F);
            textBoxEmail.ForeColor = Color.White;
            textBoxEmail.Location = new Point(30, 90);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(290, 25);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.BackColor = Color.FromArgb(40, 40, 40);
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 10F);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(30, 150);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(290, 25);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // panelCard
            // 
            panelCard.Anchor = AnchorStyles.None;
            panelCard.BackColor = Color.FromArgb(25, 25, 25);
            panelCard.BorderStyle = BorderStyle.FixedSingle;
            panelCard.Controls.Add(labelSubtitle);
            panelCard.Controls.Add(labelTitle);
            panelCard.Controls.Add(labelEmail);
            panelCard.Controls.Add(textBoxEmail);
            panelCard.Controls.Add(labelPassword);
            panelCard.Controls.Add(textBoxPassword);
            panelCard.Controls.Add(loginButton);
            panelCard.Location = new Point(150, 150);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(350, 280);
            panelCard.TabIndex = 0;
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new Font("Segoe UI", 9F);
            labelSubtitle.ForeColor = Color.FromArgb(150, 150, 150);
            labelSubtitle.Location = new Point(30, 260);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(269, 15);
            labelSubtitle.TabIndex = 5;
            labelSubtitle.Text = "Military Equipment Store © 2024 - Вхід в систему";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(167, 30);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Авторизація";
            // 
            // panelLogo
            // 
            panelLogo.Anchor = AnchorStyles.None;
            panelLogo.BackColor = Color.FromArgb(20, 20, 20);
            panelLogo.BorderStyle = BorderStyle.FixedSingle;
            panelLogo.Controls.Add(labelLogo);
            panelLogo.Location = new Point(150, 40);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(350, 80);
            panelLogo.TabIndex = 1;
            // 
            // labelLogo
            // 
            labelLogo.Dock = DockStyle.Fill;
            labelLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelLogo.ForeColor = Color.White;
            labelLogo.Location = new Point(0, 0);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(348, 78);
            labelLogo.TabIndex = 0;
            labelLogo.Text = "MILITARY STORE";
            labelLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panelLogo);
            Controls.Add(panelCard);
            Name = "LoginUserControl";
            Size = new Size(650, 500);
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            panelLogo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button loginButton;
        private Label labelEmail;
        private Label labelPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Panel panelCard;
        private Label labelTitle;
        private Label labelSubtitle;
        private Panel panelLogo;
        private Label labelLogo;
    }
}