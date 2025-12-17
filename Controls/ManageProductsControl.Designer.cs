namespace MilitaryEquipmentStore.Controls
{
    partial class ManageProductsControl
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
            addProductBtn = new Button();
            dataGridProducts = new DataGridView();
            Type = new DataGridViewTextBoxColumn();
            Article = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panelTop = new Panel();
            labelTitle = new Label();
            panelContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).BeginInit();
            panelTop.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // addProductBtn
            // 
            addProductBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addProductBtn.BackColor = Color.FromArgb(40, 40, 40);
            addProductBtn.FlatStyle = FlatStyle.Flat;
            addProductBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addProductBtn.ForeColor = Color.White;
            addProductBtn.Location = new Point(799, 12);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(180, 40);
            addProductBtn.TabIndex = 1;
            addProductBtn.Text = "➕ Новий товар";
            addProductBtn.UseVisualStyleBackColor = false;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // dataGridProducts
            // 
            dataGridProducts.AllowUserToAddRows = false;
            dataGridProducts.AllowUserToDeleteRows = false;
            dataGridProducts.AllowUserToResizeRows = false;
            dataGridProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProducts.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridProducts.BorderStyle = BorderStyle.None;
            dataGridProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridProducts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridProducts.ColumnHeadersHeight = 40;
            dataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridProducts.Columns.AddRange(new DataGridViewColumn[] { Type, Article, ProductName, Price, Description, Edit, Delete });
            dataGridProducts.EnableHeadersVisualStyles = false;
            dataGridProducts.GridColor = Color.FromArgb(50, 50, 50);
            dataGridProducts.Location = new Point(15, 15);
            dataGridProducts.MultiSelect = false;
            dataGridProducts.Name = "dataGridProducts";
            dataGridProducts.ReadOnly = true;
            dataGridProducts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridProducts.RowHeadersVisible = false;
            dataGridProducts.RowHeadersWidth = 40;
            dataGridProducts.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dataGridProducts.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dataGridProducts.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridProducts.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridProducts.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridProducts.RowTemplate.Height = 35;
            dataGridProducts.ScrollBars = ScrollBars.Vertical;
            dataGridProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProducts.Size = new Size(964, 616);
            dataGridProducts.TabIndex = 2;
            dataGridProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Type
            // 
            Type.DataPropertyName = "Type";
            Type.FillWeight = 120F;
            Type.HeaderText = "Категорія";
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // Article
            // 
            Article.DataPropertyName = "Article";
            Article.HeaderText = "Артикль";
            Article.Name = "Article";
            Article.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "Name";
            ProductName.FillWeight = 180F;
            ProductName.HeaderText = "Назва товара";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.FillWeight = 90F;
            Price.HeaderText = "Ціна (грн.)";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.FillWeight = 220F;
            Description.HeaderText = "Опис";
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.FillWeight = 70F;
            Edit.HeaderText = "Редагувати";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Редагувати";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.FillWeight = 70F;
            Delete.HeaderText = "Видалити";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Видалити";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(20, 20, 20);
            panelTop.Controls.Add(labelTitle);
            panelTop.Controls.Add(addProductBtn);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(982, 60);
            panelTop.TabIndex = 3;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(20, 18);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(215, 25);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Управління товарами";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(25, 25, 25);
            panelContainer.Controls.Add(dataGridProducts);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 60);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(15);
            panelContainer.Size = new Size(982, 646);
            panelContainer.TabIndex = 4;
            // 
            // ManageProductsControl
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panelContainer);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "ManageProductsControl";
            Size = new Size(982, 706);
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button addProductBtn;
        private DataGridView dataGridProducts;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Article;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Panel panelTop;
        private Label labelTitle;
        private Panel panelContainer;
    }
}