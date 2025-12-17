namespace MilitaryEquipmentStore.Modal_windows
{
    partial class AddManagerForm
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
            addManager = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panel1 = new Panel();
            labelTitle = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addManager
            // 
            addManager.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addManager.BackColor = Color.FromArgb(40, 40, 40);
            addManager.FlatStyle = FlatStyle.Flat;
            addManager.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addManager.ForeColor = Color.White;
            addManager.Location = new Point(88, 247);
            addManager.Name = "addManager";
            addManager.Size = new Size(149, 40);
            addManager.TabIndex = 3;
            addManager.Text = "Add manager";
            addManager.UseVisualStyleBackColor = false;
            addManager.Click += addManager_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 60);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Fullname";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(40, 40, 40);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(30, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 25);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 106);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 152);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 0;
            label3.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(32, 198);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 0;
            label4.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(40, 40, 40);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(30, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 25);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = Color.FromArgb(40, 40, 40);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 10F);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(30, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 25);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.BackColor = Color.FromArgb(40, 40, 40);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 10F);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(30, 216);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 25);
            textBox4.TabIndex = 4;
            textBox4.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(25, 25, 25);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(addManager);
            panel1.Location = new Point(35, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 327);
            panel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(90, 19);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(155, 30);
            labelTitle.TabIndex = 4;
            labelTitle.Text = "Add Manager";
            // 
            // AddManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(419, 432);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "AddManagerForm";
            Text = "Add Manager";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button addManager;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Panel panel1;
        private Label labelTitle;
    }
}