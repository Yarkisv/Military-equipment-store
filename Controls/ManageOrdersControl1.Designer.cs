namespace MilitaryEquipmentStore.Controls
{
    partial class ManageOrdersControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            dgvOrders = new DataGridView();
            colOrderId = new DataGridViewTextBoxColumn();
            colOrderDate = new DataGridViewTextBoxColumn();
            colCustomerName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colTotalPrice = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewComboBoxColumn();
            cmbStatusFilter = new ComboBox();
            btnUpdateStatus = new Button();
            btnViewDetails = new Button();
            lblStatusFilter = new Label();
            panelTop = new Panel();
            lblTitle = new Label();
            panelContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            panelTop.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToResizeRows = false;
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOrders.ColumnHeadersHeight = 40;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colOrderDate, colCustomerName, colQuantity, colTotalPrice, colStatus });
            dgvOrders.EnableHeadersVisualStyles = false;
            dgvOrders.GridColor = Color.FromArgb(50, 50, 50);
            dgvOrders.Location = new Point(15, 15);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 40;
            dgvOrders.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgvOrders.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgvOrders.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dgvOrders.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dgvOrders.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvOrders.RowTemplate.Height = 35;
            dgvOrders.ScrollBars = ScrollBars.Vertical;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(952, 616);
            dgvOrders.TabIndex = 2;
            // 
            // colOrderId
            // 
            colOrderId.DataPropertyName = "order_id";
            colOrderId.FillWeight = 60F;
            colOrderId.HeaderText = "ID";
            colOrderId.Name = "colOrderId";
            colOrderId.ReadOnly = true;
            // 
            // colOrderDate
            // 
            colOrderDate.DataPropertyName = "order_date";
            colOrderDate.FillWeight = 120F;
            colOrderDate.HeaderText = "Дата замовлення";
            colOrderDate.Name = "colOrderDate";
            colOrderDate.ReadOnly = true;
            // 
            // colCustomerName
            // 
            colCustomerName.DataPropertyName = "customer_name";
            colCustomerName.HeaderText = "ПІБ замовника";
            colCustomerName.Name = "colCustomerName";
            colCustomerName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.DataPropertyName = "quantity";
            colQuantity.FillWeight = 80F;
            colQuantity.HeaderText = "Кількість";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colTotalPrice
            // 
            colTotalPrice.DataPropertyName = "total_price";
            colTotalPrice.FillWeight = 90F;
            colTotalPrice.HeaderText = "Сума";
            colTotalPrice.Name = "colTotalPrice";
            colTotalPrice.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "status_";
            colStatus.HeaderText = "Статус";
            colStatus.Name = "colStatus";
            colStatus.Resizable = DataGridViewTriState.True;
            colStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbStatusFilter.BackColor = Color.FromArgb(40, 40, 40);
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FlatStyle = FlatStyle.Flat;
            cmbStatusFilter.Font = new Font("Segoe UI", 9F);
            cmbStatusFilter.ForeColor = Color.White;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "Всі", "оформлено", "виконано", "скасовано" });
            cmbStatusFilter.Location = new Point(404, 19);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(140, 23);
            cmbStatusFilter.TabIndex = 1;
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateStatus.BackColor = Color.FromArgb(40, 40, 40);
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI", 9F);
            btnUpdateStatus.ForeColor = Color.White;
            btnUpdateStatus.Location = new Point(761, 12);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(100, 36);
            btnUpdateStatus.TabIndex = 3;
            btnUpdateStatus.Text = "Зберегти";
            btnUpdateStatus.UseVisualStyleBackColor = false;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnViewDetails.BackColor = Color.FromArgb(40, 40, 40);
            btnViewDetails.FlatStyle = FlatStyle.Flat;
            btnViewDetails.Font = new Font("Segoe UI", 9F);
            btnViewDetails.ForeColor = Color.White;
            btnViewDetails.Location = new Point(867, 12);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(100, 36);
            btnViewDetails.TabIndex = 4;
            btnViewDetails.Text = "Деталі";
            btnViewDetails.UseVisualStyleBackColor = false;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Font = new Font("Segoe UI", 9F);
            lblStatusFilter.ForeColor = Color.White;
            lblStatusFilter.Location = new Point(306, 22);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(90, 15);
            lblStatusFilter.TabIndex = 5;
            lblStatusFilter.Text = "Фільтр статусу:";
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(20, 20, 20);
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(lblStatusFilter);
            panelTop.Controls.Add(cmbStatusFilter);
            panelTop.Controls.Add(btnUpdateStatus);
            panelTop.Controls.Add(btnViewDetails);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(982, 60);
            panelTop.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(264, 25);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Управління замовленнями";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(25, 25, 25);
            panelContainer.Controls.Add(dgvOrders);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 60);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(15);
            panelContainer.Size = new Size(982, 646);
            panelContainer.TabIndex = 4;
            // 
            // ManageOrdersControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panelContainer);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "ManageOrdersControl1";
            Size = new Size(982, 706);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrders;
        private ComboBox cmbStatusFilter;
        private Button btnUpdateStatus;
        private Button btnViewDetails;
        private Label lblStatusFilter;
        private Panel panelTop;
        private Label lblTitle;
        private Panel panelContainer;
        private DataGridViewTextBoxColumn colOrderId;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colTotalPrice;
        private DataGridViewComboBoxColumn colStatus;
    }
}