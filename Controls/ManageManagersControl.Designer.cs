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
            addManagerBtn = new Button();
            dataGridManagers = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Fullname = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            panelTop = new Panel();
            labelTitle = new Label();
            panelContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridManagers).BeginInit();
            panelTop.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // addManagerBtn
            // 
            addManagerBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addManagerBtn.BackColor = Color.FromArgb(40, 40, 40);
            addManagerBtn.FlatStyle = FlatStyle.Flat;
            addManagerBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addManagerBtn.ForeColor = Color.White;
            addManagerBtn.Location = new Point(789, 12);
            addManagerBtn.Name = "addManagerBtn";
            addManagerBtn.Size = new Size(180, 40);
            addManagerBtn.TabIndex = 1;
            addManagerBtn.Text = "+ Додати менеджера";
            addManagerBtn.UseVisualStyleBackColor = false;
            addManagerBtn.Click += addManagerBtn_Click;
            // 
            // dataGridManagers
            // 
            dataGridManagers.AllowUserToAddRows = false;
            dataGridManagers.AllowUserToDeleteRows = false;
            dataGridManagers.AllowUserToResizeRows = false;
            dataGridManagers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridManagers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridManagers.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridManagers.BorderStyle = BorderStyle.None;
            dataGridManagers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridManagers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridManagers.ColumnHeadersHeight = 40;
            dataGridManagers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridManagers.Columns.AddRange(new DataGridViewColumn[] { Id, Fullname, Phone, Email, Edit, Delete });
            dataGridManagers.EnableHeadersVisualStyles = false;
            dataGridManagers.GridColor = Color.FromArgb(50, 50, 50);
            dataGridManagers.Location = new Point(15, 15);
            dataGridManagers.MultiSelect = false;
            dataGridManagers.Name = "dataGridManagers";
            dataGridManagers.ReadOnly = true;
            dataGridManagers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridManagers.RowHeadersVisible = false;
            dataGridManagers.RowHeadersWidth = 40;
            dataGridManagers.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dataGridManagers.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dataGridManagers.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridManagers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 60, 60);
            dataGridManagers.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridManagers.RowTemplate.Height = 35;
            dataGridManagers.ScrollBars = ScrollBars.Vertical;
            dataGridManagers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridManagers.Size = new Size(949, 616);
            dataGridManagers.TabIndex = 2;
            dataGridManagers.CellContentClick += dataGridManagers_CellContentClick_1;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 70F;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Fullname
            // 
            Fullname.DataPropertyName = "Fullname";
            Fullname.FillWeight = 200F;
            Fullname.HeaderText = "Full Name";
            Fullname.Name = "Fullname";
            Fullname.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.FillWeight = 150F;
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.FillWeight = 250F;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.FillWeight = 80F;
            Edit.HeaderText = "Edit"; // ИЗМЕНЕНО: установлен заголовок "Edit"
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.FillWeight = 80F;
            Delete.HeaderText = "Delete"; // ИЗМЕНЕНО: установлен заголовок "Delete"
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(20, 20, 20);
            panelTop.Controls.Add(labelTitle);
            panelTop.Controls.Add(addManagerBtn);
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
            labelTitle.Size = new Size(258, 25);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Управління менеджерами";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.FromArgb(25, 25, 25);
            panelContainer.Controls.Add(dataGridManagers);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 60);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(15);
            panelContainer.Size = new Size(982, 646);
            panelContainer.TabIndex = 4;
            // 
            // ManageManagersControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panelContainer);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "ManageManagersControl";
            Size = new Size(982, 706);
            ((System.ComponentModel.ISupportInitialize)dataGridManagers).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button addManagerBtn;
        private DataGridView dataGridManagers;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private Panel panelTop;
        private Label labelTitle;
        private Panel panelContainer;
    }
}