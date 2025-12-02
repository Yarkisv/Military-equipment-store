namespace MilitaryEquipmentStore.Forms
{
    partial class CheckoutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelClientInfo;
        private System.Windows.Forms.Label lblSelectClient;
        private System.Windows.Forms.Button btnSelectClient;
        private System.Windows.Forms.Label lblClientInfo;
        private System.Windows.Forms.Panel panelOrderItems;
        private System.Windows.Forms.Label lblOrderItems;
        private System.Windows.Forms.FlowLayoutPanel flowOrderItems;
        private System.Windows.Forms.Panel panelOrderSummary;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Panel panelSeparator;


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
            panelHeader = new Panel();
            lblTitle = new Label();
            btnClose = new Button();
            panelMain = new Panel();
            btnConfirmOrder = new Button();
            panelSeparator = new Panel();
            panelOrderSummary = new Panel();
            lblTotalPrice = new Label();
            lblTotalItems = new Label();
            panelOrderItems = new Panel();
            flowOrderItems = new FlowLayoutPanel();
            lblOrderItems = new Label();
            panelClientInfo = new Panel();
            lblClientInfo = new Label();
            btnSelectClient = new Button();
            lblSelectClient = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelOrderSummary.SuspendLayout();
            panelOrderItems.SuspendLayout();
            panelClientInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Black;
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(650, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ОФОРМЛЕННЯ ЗАМОВЛЕННЯ";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(740, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 40);
            btnClose.TabIndex = 1;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(btnConfirmOrder);
            panelMain.Controls.Add(panelSeparator);
            panelMain.Controls.Add(panelOrderSummary);
            panelMain.Controls.Add(panelOrderItems);
            panelMain.Controls.Add(panelClientInfo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 60);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(800, 690);
            panelMain.TabIndex = 1;
            // 
            // btnConfirmOrder
            // 
            btnConfirmOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnConfirmOrder.BackColor = Color.Black;
            btnConfirmOrder.Enabled = false;
            btnConfirmOrder.FlatAppearance.BorderColor = Color.Black;
            btnConfirmOrder.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            btnConfirmOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            btnConfirmOrder.FlatStyle = FlatStyle.Flat;
            btnConfirmOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirmOrder.ForeColor = Color.White;
            btnConfirmOrder.Location = new Point(20, 630);
            btnConfirmOrder.Name = "btnConfirmOrder";
            btnConfirmOrder.Size = new Size(760, 40);
            btnConfirmOrder.TabIndex = 4;
            btnConfirmOrder.Text = "ПІДТВЕРДИТИ ЗАМОВЛЕННЯ";
            btnConfirmOrder.UseVisualStyleBackColor = false;
            btnConfirmOrder.Click += btnConfirmOrder_Click;
            // 
            // panelSeparator
            // 
            panelSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSeparator.BackColor = Color.Silver;
            panelSeparator.Location = new Point(20, 570);
            panelSeparator.Name = "panelSeparator";
            panelSeparator.Size = new Size(760, 1);
            panelSeparator.TabIndex = 3;
            // 
            // panelOrderSummary
            // 
            panelOrderSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelOrderSummary.Controls.Add(lblTotalPrice);
            panelOrderSummary.Controls.Add(lblTotalItems);
            panelOrderSummary.Location = new Point(20, 580);
            panelOrderSummary.Name = "panelOrderSummary";
            panelOrderSummary.Size = new Size(760, 40);
            panelOrderSummary.TabIndex = 2;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalPrice.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalPrice.ForeColor = Color.Black;
            lblTotalPrice.Location = new Point(400, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(360, 40);
            lblTotalPrice.TabIndex = 1;
            lblTotalPrice.Text = "Загальна сума: 0,00 грн";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotalItems
            // 
            lblTotalItems.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalItems.ForeColor = Color.Black;
            lblTotalItems.Location = new Point(0, 0);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(360, 40);
            lblTotalItems.TabIndex = 0;
            lblTotalItems.Text = "Товарів: 0 шт";
            lblTotalItems.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelOrderItems
            // 
            panelOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelOrderItems.Controls.Add(flowOrderItems);
            panelOrderItems.Controls.Add(lblOrderItems);
            panelOrderItems.Location = new Point(20, 180);
            panelOrderItems.Name = "panelOrderItems";
            panelOrderItems.Size = new Size(760, 380);
            panelOrderItems.TabIndex = 1;
            // 
            // flowOrderItems
            // 
            flowOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowOrderItems.AutoScroll = true;
            flowOrderItems.BackColor = Color.White;
            flowOrderItems.BorderStyle = BorderStyle.FixedSingle;
            flowOrderItems.Location = new Point(0, 30);
            flowOrderItems.Name = "flowOrderItems";
            flowOrderItems.Padding = new Padding(5);
            flowOrderItems.Size = new Size(760, 350);
            flowOrderItems.TabIndex = 1;
            // 
            // lblOrderItems
            // 
            lblOrderItems.AutoSize = true;
            lblOrderItems.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblOrderItems.ForeColor = Color.Black;
            lblOrderItems.Location = new Point(0, 0);
            lblOrderItems.Name = "lblOrderItems";
            lblOrderItems.Size = new Size(162, 20);
            lblOrderItems.TabIndex = 0;
            lblOrderItems.Text = "Товари в замовленні";
            // 
            // panelClientInfo
            // 
            panelClientInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelClientInfo.Controls.Add(lblClientInfo);
            panelClientInfo.Controls.Add(btnSelectClient);
            panelClientInfo.Controls.Add(lblSelectClient);
            panelClientInfo.Location = new Point(20, 20);
            panelClientInfo.Name = "panelClientInfo";
            panelClientInfo.Size = new Size(760, 150);
            panelClientInfo.TabIndex = 0;
            // 
            // lblClientInfo
            // 
            lblClientInfo.AutoSize = true;
            lblClientInfo.Font = new Font("Segoe UI", 10F);
            lblClientInfo.ForeColor = Color.Black;
            lblClientInfo.Location = new Point(0, 88);
            lblClientInfo.Name = "lblClientInfo";
            lblClientInfo.Size = new Size(125, 19);
            lblClientInfo.TabIndex = 3;
            lblClientInfo.Text = "Клієнт не обраний";
            // 
            // btnSelectClient
            // 
            btnSelectClient.BackColor = Color.Black;
            btnSelectClient.FlatAppearance.BorderColor = Color.Black;
            btnSelectClient.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            btnSelectClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            btnSelectClient.FlatStyle = FlatStyle.Flat;
            btnSelectClient.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSelectClient.ForeColor = Color.White;
            btnSelectClient.Location = new Point(0, 23);
            btnSelectClient.Name = "btnSelectClient";
            btnSelectClient.Size = new Size(200, 30);
            btnSelectClient.TabIndex = 2;
            btnSelectClient.Text = "Обрати клієнта";
            btnSelectClient.UseVisualStyleBackColor = false;
            btnSelectClient.Click += btnSelectClient_Click;
            // 
            // lblSelectClient
            // 
            lblSelectClient.AutoSize = true;
            lblSelectClient.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSelectClient.ForeColor = Color.Black;
            lblSelectClient.Location = new Point(0, 0);
            lblSelectClient.Name = "lblSelectClient";
            lblSelectClient.Size = new Size(121, 20);
            lblSelectClient.TabIndex = 0;
            lblSelectClient.Text = "Оберіть клієнта";
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(800, 750);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CheckoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оформлення замовлення";
            panelHeader.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelOrderSummary.ResumeLayout(false);
            panelOrderItems.ResumeLayout(false);
            panelOrderItems.PerformLayout();
            panelClientInfo.ResumeLayout(false);
            panelClientInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}