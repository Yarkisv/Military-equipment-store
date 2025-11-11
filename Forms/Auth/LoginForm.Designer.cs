namespace MilitaryEquipmentStore.Forms.Auth
{
    partial class LoginForm
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
            email = new Label();
            password = new Label();
            emailInput = new TextBox();
            passwordInput = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(339, 158);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(350, 67);
            email.Name = "email";
            email.Size = new Size(36, 15);
            email.TabIndex = 1;
            email.Text = "Email";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(350, 111);
            password.Name = "password";
            password.Size = new Size(57, 15);
            password.TabIndex = 2;
            password.Text = "Password";
            // 
            // emailInput
            // 
            emailInput.Location = new Point(326, 85);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(100, 23);
            emailInput.TabIndex = 3;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(326, 129);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(100, 23);
            passwordInput.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(294, 184);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(176, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't have an account? Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(passwordInput);
            Controls.Add(emailInput);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(button1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label email;
        private Label password;
        private TextBox emailInput;
        private TextBox passwordInput;
        private LinkLabel linkLabel1;
    }
}