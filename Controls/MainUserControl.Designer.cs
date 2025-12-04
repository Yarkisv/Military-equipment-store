namespace MilitaryEquipmentStore.Controls
{
    partial class MainUserControl
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
            btnElectronics = new Button();
            btnTransport = new Button();
            btnAmmunition = new Button();
            manageManagersBtn = new Button();
            manageProductsBtn = new Button();
            manageOrdersBtn = new Button();
            btnCart = new Button();
            panelSidebar = new Panel();
            separator2 = new Panel();
            separator1 = new Panel();
            labelAdmin = new Label();
            labelCatalog = new Label();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // btnElectronics
            // 
            btnElectronics.BackColor = Color.FromArgb(40, 40, 40);
            btnElectronics.Dock = DockStyle.Top;
            btnElectronics.FlatAppearance.BorderSize = 0;
            btnElectronics.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            btnElectronics.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnElectronics.FlatStyle = FlatStyle.Flat;
            btnElectronics.Font = new Font("Segoe UI", 10F);
            btnElectronics.ForeColor = Color.White;
            btnElectronics.ImageAlign = ContentAlignment.MiddleLeft;
            btnElectronics.Location = new Point(10, 215);
            btnElectronics.Margin = new Padding(3, 0, 3, 0);
            btnElectronics.Name = "btnElectronics";
            btnElectronics.Padding = new Padding(10, 0, 0, 0);
            btnElectronics.Size = new Size(200, 45);
            btnElectronics.TabIndex = 1;
            btnElectronics.Text = "📱 Електроніка";
            btnElectronics.TextAlign = ContentAlignment.MiddleLeft;
            btnElectronics.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnElectronics.UseVisualStyleBackColor = false;
            btnElectronics.Click += btnElectronics_Click;
            // 
            // btnTransport
            // 
            btnTransport.BackColor = Color.FromArgb(40, 40, 40);
            btnTransport.Dock = DockStyle.Top;
            btnTransport.FlatAppearance.BorderSize = 0;
            btnTransport.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            btnTransport.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnTransport.FlatStyle = FlatStyle.Flat;
            btnTransport.Font = new Font("Segoe UI", 10F);
            btnTransport.ForeColor = Color.White;
            btnTransport.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransport.Location = new Point(10, 260);
            btnTransport.Margin = new Padding(3, 0, 3, 0);
            btnTransport.Name = "btnTransport";
            btnTransport.Padding = new Padding(10, 0, 0, 0);
            btnTransport.Size = new Size(200, 45);
            btnTransport.TabIndex = 2;
            btnTransport.Text = "🚗 Транспорт";
            btnTransport.TextAlign = ContentAlignment.MiddleLeft;
            btnTransport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransport.UseVisualStyleBackColor = false;
            btnTransport.Click += btnTransport_Click;
            // 
            // btnAmmunition
            // 
            btnAmmunition.BackColor = Color.FromArgb(40, 40, 40);
            btnAmmunition.Dock = DockStyle.Top;
            btnAmmunition.FlatAppearance.BorderSize = 0;
            btnAmmunition.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            btnAmmunition.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnAmmunition.FlatStyle = FlatStyle.Flat;
            btnAmmunition.Font = new Font("Segoe UI", 10F);
            btnAmmunition.ForeColor = Color.White;
            btnAmmunition.ImageAlign = ContentAlignment.MiddleLeft;
            btnAmmunition.Location = new Point(10, 305);
            btnAmmunition.Margin = new Padding(3, 0, 3, 0);
            btnAmmunition.Name = "btnAmmunition";
            btnAmmunition.Padding = new Padding(10, 0, 0, 0);
            btnAmmunition.Size = new Size(200, 45);
            btnAmmunition.TabIndex = 3;
            btnAmmunition.Text = "🔫 Аммуніція";
            btnAmmunition.TextAlign = ContentAlignment.MiddleLeft;
            btnAmmunition.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAmmunition.UseVisualStyleBackColor = false;
            btnAmmunition.Click += btnAmmunition_Click;
            // 
            // manageManagersBtn
            // 
            manageManagersBtn.BackColor = Color.FromArgb(40, 40, 40);
            manageManagersBtn.Dock = DockStyle.Top;
            manageManagersBtn.FlatAppearance.BorderSize = 0;
            manageManagersBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            manageManagersBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            manageManagersBtn.FlatStyle = FlatStyle.Flat;
            manageManagersBtn.Font = new Font("Segoe UI", 10F);
            manageManagersBtn.ForeColor = Color.White;
            manageManagersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageManagersBtn.Location = new Point(10, 80);
            manageManagersBtn.Margin = new Padding(3, 0, 3, 0);
            manageManagersBtn.Name = "manageManagersBtn";
            manageManagersBtn.Padding = new Padding(10, 0, 0, 0);
            manageManagersBtn.Size = new Size(200, 45);
            manageManagersBtn.TabIndex = 4;
            manageManagersBtn.Text = "👥 Менеджери";
            manageManagersBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageManagersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manageManagersBtn.UseVisualStyleBackColor = false;
            manageManagersBtn.Click += manageManagersBtn_Click;
            // 
            // manageProductsBtn
            // 
            manageProductsBtn.BackColor = Color.FromArgb(40, 40, 40);
            manageProductsBtn.Dock = DockStyle.Top;
            manageProductsBtn.FlatAppearance.BorderSize = 0;
            manageProductsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            manageProductsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            manageProductsBtn.FlatStyle = FlatStyle.Flat;
            manageProductsBtn.Font = new Font("Segoe UI", 10F);
            manageProductsBtn.ForeColor = Color.White;
            manageProductsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageProductsBtn.Location = new Point(10, 125);
            manageProductsBtn.Margin = new Padding(3, 0, 3, 0);
            manageProductsBtn.Name = "manageProductsBtn";
            manageProductsBtn.Padding = new Padding(10, 0, 0, 0);
            manageProductsBtn.Size = new Size(200, 45);
            manageProductsBtn.TabIndex = 5;
            manageProductsBtn.Text = "📦 Товари";
            manageProductsBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageProductsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manageProductsBtn.UseVisualStyleBackColor = false;
            manageProductsBtn.Click += manageProductsBtn_Click;
            // 
            // manageOrdersBtn
            // 
            manageOrdersBtn.BackColor = Color.FromArgb(40, 40, 40);
            manageOrdersBtn.Dock = DockStyle.Top;
            manageOrdersBtn.FlatAppearance.BorderSize = 0;
            manageOrdersBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            manageOrdersBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            manageOrdersBtn.FlatStyle = FlatStyle.Flat;
            manageOrdersBtn.Font = new Font("Segoe UI", 10F);
            manageOrdersBtn.ForeColor = Color.White;
            manageOrdersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            manageOrdersBtn.Location = new Point(10, 170);
            manageOrdersBtn.Margin = new Padding(3, 0, 3, 0);
            manageOrdersBtn.Name = "manageOrdersBtn";
            manageOrdersBtn.Padding = new Padding(10, 0, 0, 0);
            manageOrdersBtn.Size = new Size(200, 45);
            manageOrdersBtn.TabIndex = 6;
            manageOrdersBtn.Text = "📋 Замовлення";
            manageOrdersBtn.TextAlign = ContentAlignment.MiddleLeft;
            manageOrdersBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            manageOrdersBtn.UseVisualStyleBackColor = false;
            manageOrdersBtn.Click += manageOrdersBtn_Click;
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.FromArgb(40, 40, 40);
            btnCart.Dock = DockStyle.Top;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 60, 60);
            btnCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Segoe UI", 10F);
            btnCart.ForeColor = Color.White;
            btnCart.ImageAlign = ContentAlignment.MiddleLeft;
            btnCart.Location = new Point(10, 350);
            btnCart.Margin = new Padding(3, 0, 3, 0);
            btnCart.Name = "btnCart";
            btnCart.Padding = new Padding(10, 0, 0, 0);
            btnCart.Size = new Size(200, 45);
            btnCart.TabIndex = 7;
            btnCart.Text = "🛒 Кошик";
            btnCart.TextAlign = ContentAlignment.MiddleLeft;
            btnCart.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(20, 20, 20);
            panelSidebar.Controls.Add(btnCart);
            panelSidebar.Controls.Add(btnAmmunition);
            panelSidebar.Controls.Add(btnTransport);
            panelSidebar.Controls.Add(btnElectronics);
            panelSidebar.Controls.Add(separator2);
            panelSidebar.Controls.Add(manageOrdersBtn);
            panelSidebar.Controls.Add(manageProductsBtn);
            panelSidebar.Controls.Add(manageManagersBtn);
            panelSidebar.Controls.Add(separator1);
            panelSidebar.Controls.Add(labelCatalog);
            panelSidebar.Controls.Add(labelAdmin);
            panelSidebar.Dock = DockStyle.Fill;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(10);
            panelSidebar.Size = new Size(220, 706);
            panelSidebar.TabIndex = 0;
            // 
            // separator2
            // 
            separator2.BackColor = Color.FromArgb(50, 50, 50);
            separator2.Dock = DockStyle.Top;
            separator2.Location = new Point(10, 155);
            separator2.Name = "separator2";
            separator2.Size = new Size(200, 1);
            separator2.TabIndex = 9;
            // 
            // separator1
            // 
            separator1.BackColor = Color.FromArgb(50, 50, 50);
            separator1.Dock = DockStyle.Top;
            separator1.Location = new Point(10, 40);
            separator1.Name = "separator1";
            separator1.Size = new Size(200, 1);
            separator1.TabIndex = 8;
            // 
            // labelAdmin
            // 
            labelAdmin.Dock = DockStyle.Top;
            labelAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAdmin.ForeColor = Color.FromArgb(150, 150, 150);
            labelAdmin.Location = new Point(10, 10);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.Size = new Size(200, 30);
            labelAdmin.TabIndex = 0;
            labelAdmin.Text = "АДМІНІСТРУВАННЯ";
            labelAdmin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelCatalog
            // 
            labelCatalog.Dock = DockStyle.Top;
            labelCatalog.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCatalog.ForeColor = Color.FromArgb(150, 150, 150);
            labelCatalog.Location = new Point(10, 41);
            labelCatalog.Name = "labelCatalog";
            labelCatalog.Size = new Size(200, 30);
            labelCatalog.TabIndex = 10;
            labelCatalog.Text = "КАТАЛОГ ТОВАРІВ";
            labelCatalog.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Name = "MainUserControl";
            Size = new Size(220, 706);
            panelSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnElectronics;
        private Button btnTransport;
        private Button btnAmmunition;
        private Button manageManagersBtn;
        private Button manageProductsBtn;
        private Button manageOrdersBtn;
        private Button btnCart;
        private Panel panelSidebar;
        private Label labelAdmin;
        private Panel separator1;
        private Panel separator2;
        private Label labelCatalog;
    }
}