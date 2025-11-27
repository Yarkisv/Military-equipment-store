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
        /// 
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblTotalSum;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;


        private void InitializeComponent()
        {
            dgvItems = new DataGridView();
            colProductName = new DataGridViewTextBoxColumn();
            colArticle = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            panelFooter = new Panel();
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
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colProductName, colArticle, colType, colQuantity, colPrice, colTotal });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 0);
            dgvItems.Margin = new Padding(4, 3, 4, 3);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(798, 346);
            dgvItems.TabIndex = 0;
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
            // colTotal
            // 
            colTotal.DataPropertyName = "total_price";
            colTotal.FillWeight = 80F;
            colTotal.HeaderText = "Сума";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(lblTotalSum);
            panelFooter.Controls.Add(btnClose);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 346);
            panelFooter.Margin = new Padding(4, 3, 4, 3);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(798, 46);
            panelFooter.TabIndex = 1;
            // 
            // lblTotalSum
            // 
            lblTotalSum.AutoSize = true;
            lblTotalSum.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTotalSum.Location = new Point(14, 14);
            lblTotalSum.Margin = new Padding(4, 0, 4, 0);
            lblTotalSum.Name = "lblTotalSum";
            lblTotalSum.Size = new Size(51, 15);
            lblTotalSum.TabIndex = 1;
            lblTotalSum.Text = "Разом:";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(696, 9);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(88, 27);
            btnClose.TabIndex = 0;
            btnClose.Text = "Закрити";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // OrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 392);
            Controls.Add(dgvItems);
            Controls.Add(panelFooter);
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
    }
}