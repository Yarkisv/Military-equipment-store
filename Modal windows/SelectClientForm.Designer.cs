namespace MilitaryEquipmentStore.Modal_windows
{
    partial class SelectClientForm
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
            txtEmail = new TextBox();
            btnSearch = new Button();
            lblEmail = new Label();
            lblClientInfo = new Label();
            btnSelect = new Button();
            btnCancel = new Button();
            btnAddClient = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(40, 40, 40);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(75, 14);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(381, 23);
            txtEmail.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(40, 40, 40);
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(464, 12);
            btnSearch.Margin = new Padding(4, 3, 4, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 27);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.FromArgb(30, 30, 30);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(14, 17);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // lblClientInfo
            // 
            lblClientInfo.AutoSize = true;
            lblClientInfo.BackColor = Color.FromArgb(30, 30, 30);
            lblClientInfo.ForeColor = Color.White;
            lblClientInfo.Location = new Point(14, 58);
            lblClientInfo.Margin = new Padding(4, 0, 4, 0);
            lblClientInfo.Name = "lblClientInfo";
            lblClientInfo.Size = new Size(78, 15);
            lblClientInfo.TabIndex = 2;
            lblClientInfo.Text = "Введіть email";
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(40, 40, 40);
            btnSelect.Enabled = false;
            btnSelect.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnSelect.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(272, 92);
            btnSelect.Margin = new Padding(4, 3, 4, 3);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(88, 27);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "Обрати";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(40, 40, 40);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(464, 92);
            btnCancel.Margin = new Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 27);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddClient
            // 
            btnAddClient.BackColor = Color.FromArgb(40, 40, 40);
            btnAddClient.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnAddClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            btnAddClient.FlatStyle = FlatStyle.Flat;
            btnAddClient.ForeColor = Color.White;
            btnAddClient.Location = new Point(368, 92);
            btnAddClient.Margin = new Padding(4, 3, 4, 3);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(88, 27);
            btnAddClient.TabIndex = 6;
            btnAddClient.Text = "Додати";
            btnAddClient.UseVisualStyleBackColor = false;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // SelectClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(565, 133);
            Controls.Add(btnAddClient);
            Controls.Add(btnCancel);
            Controls.Add(btnSelect);
            Controls.Add(lblClientInfo);
            Controls.Add(btnSearch);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectClientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Вибір клієнта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Button btnSearch;
        private Label lblEmail;
        private Label lblClientInfo;
        private Button btnSelect;
        private Button btnCancel;
        private Button btnAddClient;
    }
}