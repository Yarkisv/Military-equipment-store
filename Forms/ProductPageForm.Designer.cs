    namespace MilitaryEquipmentStore.Forms
    {
        partial class ProductPageForm
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;
            private System.Windows.Forms.Panel panelHeader;
            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Panel panelMain;
            private System.Windows.Forms.Panel panelInfo;
            private System.Windows.Forms.Label lblArticle;
            private System.Windows.Forms.Label lblType;
            private System.Windows.Forms.Label lblPrice;
            private System.Windows.Forms.TextBox txtDescription;
            private System.Windows.Forms.Label labelDescription;
            private System.Windows.Forms.Panel panelDetails;
            private System.Windows.Forms.TextBox txtDetails;
            private System.Windows.Forms.Label labelDetails;
            private System.Windows.Forms.Button btnAddToCart;
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
            panelMain = new Panel();
            btnAddToCart = new Button();
            panelSeparator = new Panel();
            panelDetails = new Panel();
            txtDetails = new TextBox();
            labelDetails = new Label();
            panelInfo = new Panel();
            txtDescription = new TextBox();
            labelDescription = new Label();
            lblPrice = new Label();
            lblType = new Label();
            lblArticle = new Label();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelDetails.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Black;
            panelHeader.Controls.Add(lblTitle);
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
            lblTitle.Size = new Size(760, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Назва товару";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(btnAddToCart);
            panelMain.Controls.Add(panelSeparator);
            panelMain.Controls.Add(panelDetails);
            panelMain.Controls.Add(panelInfo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 60);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(800, 590);
            panelMain.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAddToCart.BackColor = Color.Black;
            btnAddToCart.FlatAppearance.BorderColor = Color.Black;
            btnAddToCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            btnAddToCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Location = new Point(20, 530);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(760, 40);
            btnAddToCart.TabIndex = 4;
            btnAddToCart.Text = "ДОДАТИ ДО КОШИКА";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // panelSeparator
            // 
            panelSeparator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSeparator.BackColor = Color.Silver;
            panelSeparator.Location = new Point(20, 390);
            panelSeparator.Name = "panelSeparator";
            panelSeparator.Size = new Size(760, 1);
            panelSeparator.TabIndex = 3;
            // 
            // panelDetails
            // 
            panelDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDetails.Controls.Add(txtDetails);
            panelDetails.Controls.Add(labelDetails);
            panelDetails.Location = new Point(20, 400);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(760, 120);
            panelDetails.TabIndex = 2;
            // 
            // txtDetails
            // 
            txtDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDetails.BackColor = Color.White;
            txtDetails.BorderStyle = BorderStyle.FixedSingle;
            txtDetails.Font = new Font("Segoe UI", 10F);
            txtDetails.ForeColor = Color.Black;
            txtDetails.Location = new Point(0, 25);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.ScrollBars = ScrollBars.Vertical;
            txtDetails.Size = new Size(760, 95);
            txtDetails.TabIndex = 1;
            // 
            // labelDetails
            // 
            labelDetails.AutoSize = true;
            labelDetails.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelDetails.ForeColor = Color.Black;
            labelDetails.Location = new Point(0, 0);
            labelDetails.Name = "labelDetails";
            labelDetails.Size = new Size(186, 20);
            labelDetails.TabIndex = 0;
            labelDetails.Text = "Технічні характеристики";
            // 
            // panelInfo
            // 
            panelInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelInfo.Controls.Add(txtDescription);
            panelInfo.Controls.Add(labelDescription);
            panelInfo.Controls.Add(lblPrice);
            panelInfo.Controls.Add(lblType);
            panelInfo.Controls.Add(lblArticle);
            panelInfo.Location = new Point(20, 20);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(760, 360);
            panelInfo.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.ForeColor = Color.Black;
            txtDescription.Location = new Point(0, 135);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(760, 225);
            txtDescription.TabIndex = 4;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelDescription.ForeColor = Color.Black;
            labelDescription.Location = new Point(0, 110);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(45, 20);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Опис";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(0, 60);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(110, 32);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "0,00 грн";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 10F);
            lblType.ForeColor = Color.Black;
            lblType.Location = new Point(0, 30);
            lblType.Name = "lblType";
            lblType.Size = new Size(84, 19);
            lblType.TabIndex = 1;
            lblType.Text = "Категорія: ...";
            // 
            // lblArticle
            // 
            lblArticle.AutoSize = true;
            lblArticle.Font = new Font("Segoe UI", 10F);
            lblArticle.ForeColor = Color.Black;
            lblArticle.Location = new Point(0, 0);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(77, 19);
            lblArticle.TabIndex = 0;
            lblArticle.Text = "Артикул: ...";
            // 
            // ProductPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(800, 650);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сторінка товару";
            panelHeader.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
    }