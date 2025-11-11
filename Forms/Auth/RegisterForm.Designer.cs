namespace MilitaryEquipmentStore.Forms.Auth
{
    partial class RegisterForm
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
            button1 = new Button();
            fullnameInput = new TextBox();
            fullname = new Label();
            email = new Label();
            emailInput = new TextBox();
            phoneInput = new TextBox();
            passwordInput = new TextBox();
            phone = new Label();
            password = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(380, 273);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fullnameInput
            // 
            fullnameInput.Location = new Point(327, 112);
            fullnameInput.Name = "fullnameInput";
            fullnameInput.Size = new Size(184, 23);
            fullnameInput.TabIndex = 1;
            // 
            // fullname
            // 
            fullname.AutoSize = true;
            fullname.Location = new Point(399, 94);
            fullname.Name = "fullname";
            fullname.Size = new Size(56, 15);
            fullname.TabIndex = 2;
            fullname.Text = "Fullname";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(399, 138);
            email.Name = "email";
            email.Size = new Size(36, 15);
            email.TabIndex = 3;
            email.Text = "Email";
            // 
            // emailInput
            // 
            emailInput.Location = new Point(325, 156);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(186, 23);
            emailInput.TabIndex = 4;
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(325, 200);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(186, 23);
            phoneInput.TabIndex = 5;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(327, 244);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(184, 23);
            passwordInput.TabIndex = 6;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Location = new Point(399, 182);
            phone.Name = "phone";
            phone.Size = new Size(41, 15);
            phone.TabIndex = 7;
            phone.Text = "Phone";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(399, 226);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 8;
            password.Text = "Password";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(password);
            Controls.Add(phone);
            Controls.Add(passwordInput);
            Controls.Add(phoneInput);
            Controls.Add(emailInput);
            Controls.Add(email);
            Controls.Add(fullname);
            Controls.Add(fullnameInput);
            Controls.Add(button1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox fullnameInput;
        private Label fullname;
        private Label email;
        private TextBox emailInput;
        private TextBox phoneInput;
        private TextBox passwordInput;
        private Label phone;
        private Label password;
    }
}