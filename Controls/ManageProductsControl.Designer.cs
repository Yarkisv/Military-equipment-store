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
            Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).BeginInit();
            SuspendLayout();
            // 
            // addProductBtn
            // 
            addProductBtn.Dock = DockStyle.Top;
            addProductBtn.Location = new Point(0, 0);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(800, 30);
            addProductBtn.TabIndex = 1;
            addProductBtn.Text = "Add Product";
            addProductBtn.Click += addProductBtn_Click;
            // 
            // dataGridProducts
            // 
            dataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProducts.Columns.AddRange(new DataGridViewColumn[] { Type, Article, Name, Price, Description, Edit, Delete });
            dataGridProducts.Location = new Point(3, 36);
            dataGridProducts.Name = "dataGridProducts";
            dataGridProducts.Size = new Size(747, 372);
            dataGridProducts.TabIndex = 2;
            dataGridProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.Name = "Type";
            // 
            // Article
            // 
            Article.HeaderText = "Article";
            Article.Name = "Article";
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            // 
            // ManageProductsControl
            // 
            Controls.Add(dataGridProducts);
            Controls.Add(addProductBtn);
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)dataGridProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button addProductBtn;
        private DataGridView dataGridProducts;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Article;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}
