namespace MilitaryEquipmentStore.Modal_windows
{
    partial class DeactivateManager
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
            panel1 = new Panel();
            labelTitle = new Label();
            labelReason = new Label();
            textBoxReason = new TextBox();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(25, 25, 25);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelTitle);
            panel1.Controls.Add(labelReason);
            panel1.Controls.Add(textBoxReason);
            panel1.Controls.Add(buttonConfirm);
            panel1.Controls.Add(buttonCancel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 200);
            panel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(52, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(251, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Звільнити менеджера";
            // 
            // labelReason
            // 
            labelReason.AutoSize = true;
            labelReason.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelReason.ForeColor = Color.White;
            labelReason.Location = new Point(30, 60);
            labelReason.Name = "labelReason";
            labelReason.Size = new Size(59, 15);
            labelReason.TabIndex = 1;
            labelReason.Text = "Причина";
            // 
            // textBoxReason
            // 
            textBoxReason.BackColor = Color.FromArgb(40, 40, 40);
            textBoxReason.BorderStyle = BorderStyle.FixedSingle;
            textBoxReason.Font = new Font("Segoe UI", 10F);
            textBoxReason.ForeColor = Color.White;
            textBoxReason.Location = new Point(30, 80);
            textBoxReason.Multiline = true;
            textBoxReason.Name = "textBoxReason";
            textBoxReason.Size = new Size(290, 50);
            textBoxReason.TabIndex = 0;
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.FromArgb(40, 40, 40);
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(30, 140);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(140, 40);
            buttonConfirm.TabIndex = 1;
            buttonConfirm.Text = "Підтвердити";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(40, 40, 40);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(180, 140);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(140, 40);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Скасувати";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // DeactivateManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(376, 224);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "DeactivateManager";
            Text = "Звільнення менеджера";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTitle;
        private Label labelReason;
        private TextBox textBoxReason;
        private Button buttonConfirm;
        private Button buttonCancel;
    }
}