//namespace MilitaryEquipmentStore.Forms
//{
//    partial class Form1
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            rootPanel = new Panel();
//            contentPanel = new Panel();
//            sidebarPanel = new Panel();
//            rootPanel.SuspendLayout();
//            SuspendLayout();
//            // 
//            // rootPanel
//            // 
//            rootPanel.Controls.Add(contentPanel);
//            rootPanel.Controls.Add(sidebarPanel);
//            rootPanel.Dock = DockStyle.Fill;
//            rootPanel.Location = new Point(0, 0);
//            rootPanel.Name = "rootPanel";
//            rootPanel.Size = new Size(1179, 706);
//            rootPanel.TabIndex = 0;
//            // 
//            // contentPanel
//            // 
//            contentPanel.Dock = DockStyle.Fill;
//            contentPanel.Location = new Point(197, 0);
//            contentPanel.Name = "contentPanel";
//            contentPanel.Size = new Size(982, 706);
//            contentPanel.TabIndex = 1;
//            // 
//            // sidebarPanel
//            // 
//            sidebarPanel.Dock = DockStyle.Left;
//            sidebarPanel.Location = new Point(0, 0);
//            sidebarPanel.Name = "sidebarPanel";
//            sidebarPanel.Size = new Size(197, 706);
//            sidebarPanel.TabIndex = 0;
//            // 
//            // Form1
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            ClientSize = new Size(1179, 706);
//            Controls.Add(rootPanel);
//            Name = "Form1";
//            StartPosition = FormStartPosition.CenterScreen;
//            Text = "Form1";
//            rootPanel.ResumeLayout(false);
//            ResumeLayout(false);
//        }

//        #endregion
//        private Panel sidebarPanel;
//        private Panel rootPanel;
//        private Panel contentPanel;
//    }
//}

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
            panelSidebarContent = new Panel();
            panelSidebarHeader = new Panel();
            labelAppTitle = new Label();
            rootPanel.SuspendLayout();
            sidebarPanel.SuspendLayout();
            panelSidebarHeader.SuspendLayout();
            SuspendLayout();
            // 
            // rootPanel
            // 
            rootPanel.BackColor = Color.FromArgb(30, 30, 30);
            rootPanel.Controls.Add(contentPanel);
            rootPanel.Controls.Add(sidebarPanel);
            rootPanel.Dock = DockStyle.Fill;
            rootPanel.Location = new Point(0, 0);
            rootPanel.Name = "rootPanel";
            rootPanel.Size = new Size(1208, 736);
            rootPanel.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(25, 25, 25);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(220, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(1);
            contentPanel.Size = new Size(988, 736);
            contentPanel.TabIndex = 1;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(20, 20, 20);
            sidebarPanel.BorderStyle = BorderStyle.FixedSingle;
            sidebarPanel.Controls.Add(panelSidebarContent);
            sidebarPanel.Controls.Add(panelSidebarHeader);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(220, 736);
            sidebarPanel.TabIndex = 0;
            // 
            // panelSidebarContent
            // 
            panelSidebarContent.BackColor = Color.Transparent;
            panelSidebarContent.Dock = DockStyle.Fill;
            panelSidebarContent.Location = new Point(0, 80);
            panelSidebarContent.Name = "panelSidebarContent";
            panelSidebarContent.Padding = new Padding(5);
            panelSidebarContent.Size = new Size(218, 654);
            panelSidebarContent.TabIndex = 1;
            // 
            // panelSidebarHeader
            // 
            panelSidebarHeader.BackColor = Color.FromArgb(15, 15, 15);
            panelSidebarHeader.Controls.Add(labelAppTitle);
            panelSidebarHeader.Dock = DockStyle.Top;
            panelSidebarHeader.Location = new Point(0, 0);
            panelSidebarHeader.Name = "panelSidebarHeader";
            panelSidebarHeader.Size = new Size(218, 80);
            panelSidebarHeader.TabIndex = 0;
            // 
            // labelAppTitle
            // 
            labelAppTitle.Dock = DockStyle.Fill;
            labelAppTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAppTitle.ForeColor = Color.White;
            labelAppTitle.Location = new Point(0, 0);
            labelAppTitle.Name = "labelAppTitle";
            labelAppTitle.Padding = new Padding(10, 0, 0, 0);
            labelAppTitle.Size = new Size(218, 80);
            labelAppTitle.TabIndex = 0;
            labelAppTitle.Text = "🛡️ MILITARY STORE";
            labelAppTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1208, 736);
            Controls.Add(rootPanel);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.White;
            MinimumSize = new Size(800, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Military Equipment Store - Management System";
            rootPanel.ResumeLayout(false);
            sidebarPanel.ResumeLayout(false);
            panelSidebarHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel sidebarPanel;
        private Panel rootPanel;
        private Panel contentPanel;
        private Panel panelSidebarHeader;
        private Label labelAppTitle;
        private Panel panelSidebarContent;
    }
}