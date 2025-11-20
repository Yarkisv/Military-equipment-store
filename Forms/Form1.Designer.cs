namespace MilitaryEquipmentStore.Forms
{
    partial class Form1
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
            rootPanel = new Panel();
            contentPanel = new Panel();
            sidebarPanel = new Panel();
            rootPanel.SuspendLayout();
            SuspendLayout();
            // 
            // rootPanel
            // 
            rootPanel.Controls.Add(contentPanel);
            rootPanel.Controls.Add(sidebarPanel);
            rootPanel.Dock = DockStyle.Fill;
            rootPanel.Location = new Point(0, 0);
            rootPanel.Name = "rootPanel";
            rootPanel.Size = new Size(1144, 706);
            rootPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(171, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(973, 706);
            contentPanel.TabIndex = 1;
            // 
            // sidebarPanel
            // 
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(171, 706);
            sidebarPanel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 706);
            Controls.Add(rootPanel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            rootPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel sidebarPanel;
        private Panel rootPanel;
        private Panel contentPanel;
    }
}