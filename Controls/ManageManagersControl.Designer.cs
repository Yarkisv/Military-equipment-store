namespace MilitaryEquipmentStore.Controls
{
    partial class ManageManagersControl
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
            button1 = new Button();
            dataGridManagers = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Fullname = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridManagers).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(649, 30);
            button1.TabIndex = 1;
            button1.Text = "Add Manager";
            button1.Click += button1_Click;
            // 
            // dataGridManagers
            // 
            dataGridManagers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridManagers.Columns.AddRange(new DataGridViewColumn[] { Id, Fullname, Phone, Email, Edit, Delete });
            dataGridManagers.Location = new Point(3, 36);
            dataGridManagers.Name = "dataGridManagers";
            dataGridManagers.Size = new Size(644, 436);
            dataGridManagers.TabIndex = 2;
            dataGridManagers.CellContentClick += dataGridManagers_CellContentClick_1;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Fullname
            // 
            Fullname.HeaderText = "Fullname";
            Fullname.Name = "Fullname";
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
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
            // ManageManagersControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridManagers);
            Controls.Add(button1);
            Name = "ManageManagersControl";
            Size = new Size(649, 475);
            ((System.ComponentModel.ISupportInitialize)dataGridManagers).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private DataGridView dataGridManagers;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}
