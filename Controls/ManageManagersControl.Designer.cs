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
            dataGridManagers = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fullname = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            change = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridManagers).BeginInit();
            SuspendLayout();
            // 
            // dataGridManagers
            // 
            dataGridManagers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridManagers.Columns.AddRange(new DataGridViewColumn[] { id, fullname, phone, email, change, delete });
            dataGridManagers.Dock = DockStyle.Fill;
            dataGridManagers.Location = new Point(0, 30);
            dataGridManagers.Name = "dataGridManagers";
            dataGridManagers.Size = new Size(150, 120);
            dataGridManagers.TabIndex = 0;
            // 
            // id
            // 
            id.Name = "id";
            // 
            // fullname
            // 
            fullname.Name = "fullname";
            // 
            // phone
            // 
            phone.Name = "phone";
            // 
            // email
            // 
            email.Name = "email";
            // 
            // change
            // 
            change.Name = "change";
            // 
            // delete
            // 
            delete.Name = "delete";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(150, 30);
            button1.TabIndex = 1;
            button1.Text = "Add Manager";
            button1.Click += button1_Click;
            // 
            // ManageManagersControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridManagers);
            Controls.Add(button1);
            Name = "ManageManagersControl";
            ((System.ComponentModel.ISupportInitialize)dataGridManagers).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private DataGridView dataGridManagers;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fullname;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewButtonColumn change;
        private DataGridViewButtonColumn delete;
        private Button button1;
    }
}
