namespace MilitaryEquipmentStore.Modal_windows
{
    partial class EditProductForm
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
            mainPanel = new Panel();
            confirmButton = new Button();
            otherPanel = new Panel();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(25, 25, 25);
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Controls.Add(confirmButton);
            mainPanel.Controls.Add(otherPanel);
            mainPanel.Controls.Add(label5);
            mainPanel.Controls.Add(textBox4);
            mainPanel.Controls.Add(textBox3);
            mainPanel.Controls.Add(textBox2);
            mainPanel.Controls.Add(label4);
            mainPanel.Controls.Add(label3);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(textBox1);
            mainPanel.Controls.Add(label1);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(295, 684);
            mainPanel.TabIndex = 0;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.FromArgb(40, 40, 40);
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(3, 649);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(284, 30);
            confirmButton.TabIndex = 10;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // otherPanel
            // 
            otherPanel.BackColor = Color.FromArgb(20, 20, 20);
            otherPanel.BorderStyle = BorderStyle.FixedSingle;
            otherPanel.Location = new Point(0, 224);
            otherPanel.Name = "otherPanel";
            otherPanel.Size = new Size(295, 419);
            otherPanel.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(80, 13);
            label5.Name = "label5";
            label5.Size = new Size(176, 30);
            label5.TabIndex = 8;
            label5.Text = "Editing product";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(40, 40, 40);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 10F);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(13, 193);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(267, 25);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(40, 40, 40);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 10F);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(13, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 25);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(40, 40, 40);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(13, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(267, 25);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 175);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 4;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 131);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 3;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(17, 87);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(40, 40, 40);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(13, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 25);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 43);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Article";
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(318, 708);
            Controls.Add(mainPanel);
            ForeColor = Color.White;
            Name = "EditProductForm";
            Text = "Edit Product";
            Load += EditProductForm_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private TextBox textBox1;
        private Label label1;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel otherPanel;
        private Button confirmButton;
    }
}