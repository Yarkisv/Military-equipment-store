namespace MilitaryEquipmentStore.Modal_windows
{
    partial class OrderDetailsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvItems = new DataGridView();
            colProductName = new DataGridViewTextBoxColumn();
            colArticle = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            panelFooter = new Panel();
            btnPrintReceipt = new Button();
            lblTotalSum = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvItems.BorderStyle = BorderStyle.None;
            dgvItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colProductName, colArticle, colType, colQuantity, colPrice, colDelete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle2;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.EnableHeadersVisualStyles = false;
            dgvItems.GridColor = Color.FromArgb(50, 50, 50);
            dgvItems.Location = new Point(0, 0);
            dgvItems.Margin = new Padding(4, 3, 4, 3);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidth = 40;
            dgvItems.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvItems.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvItems.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dgvItems.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dgvItems.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvItems.RowTemplate.Height = 35;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(798, 346);
            dgvItems.TabIndex = 0;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "product_name";
            colProductName.HeaderText = "Товар";
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colArticle
            // 
            colArticle.DataPropertyName = "article";
            colArticle.FillWeight = 80F;
            colArticle.HeaderText = "Артикул";
            colArticle.Name = "colArticle";
            colArticle.ReadOnly = true;
            // 
            // colType
            // 
            colType.DataPropertyName = "type";
            colType.FillWeight = 90F;
            colType.HeaderText = "Тип";
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "quantity";
            colQuantity.FillWeight = 60F;
            colQuantity.HeaderText = "Кількість";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "price";
            colPrice.FillWeight = 70F;
            colPrice.HeaderText = "Ціна";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colDelete
            // 
            colDelete.FillWeight = 60F;
            colDelete.HeaderText = "Видалити";
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "Видалити";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(20, 20, 20);
            panelFooter.Controls.Add(btnPrintReceipt);
            panelFooter.Controls.Add(lblTotalSum);
            panelFooter.Controls.Add(btnClose);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 346);
            panelFooter.Margin = new Padding(4, 3, 4, 3);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(798, 46);
            panelFooter.TabIndex = 1;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrintReceipt.BackColor = Color.FromArgb(40, 40, 40);
            btnPrintReceipt.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnPrintReceipt.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            btnPrintReceipt.FlatStyle = FlatStyle.Flat;
            btnPrintReceipt.Font = new Font("Segoe UI", 9F);
            btnPrintReceipt.ForeColor = Color.White;
            btnPrintReceipt.Location = new Point(574, 9);
            btnPrintReceipt.Margin = new Padding(4, 3, 4, 3);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.Size = new Size(114, 27);
            btnPrintReceipt.TabIndex = 2;
            btnPrintReceipt.Text = "Друкувати чек";
            btnPrintReceipt.UseVisualStyleBackColor = false;
            btnPrintReceipt.Click += btnPrintReceipt_Click;
            // 
            // lblTotalSum
            // 
            lblTotalSum.AutoSize = true;
            lblTotalSum.BackColor = Color.FromArgb(20, 20, 20);
            lblTotalSum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalSum.ForeColor = Color.White;
            lblTotalSum.Location = new Point(14, 14);
            lblTotalSum.Margin = new Padding(4, 0, 4, 0);
            lblTotalSum.Name = "lblTotalSum";
            lblTotalSum.Size = new Size(45, 15);
            lblTotalSum.TabIndex = 1;
            lblTotalSum.Text = "Разом:";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(40, 40, 40);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(696, 9);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(88, 27);
            btnClose.TabIndex = 0;
            btnClose.Text = "Закрити";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // OrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(798, 392);
            Controls.Add(dgvItems);
            Controls.Add(panelFooter);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrderDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Товари в замовленні";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvItems;
        private Panel panelFooter;
        private Label lblTotalSum;
        private Button btnClose;
        private Button btnPrintReceipt;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colArticle;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewButtonColumn colDelete;
    }
}