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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            manageManagersBtn = new Button();
            manageProductsBtn = new Button();
            button4 = new Button();
            btnCart = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 250, 250);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(10, 100);
            button1.Name = "button1";
            button1.Size = new Size(160, 40);
            button1.TabIndex = 1;
            button1.Text = "Електроніка";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderColor = Color.Black;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 250, 250);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(10, 150);
            button2.Name = "button2";
            button2.Size = new Size(160, 40);
            button2.TabIndex = 2;
            button2.Text = "Транспорт";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(240, 240, 240);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 250, 250);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(10, 200);
            button3.Name = "button3";
            button3.Size = new Size(160, 40);
            button3.TabIndex = 3;
            button3.Text = "Аммуніція";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // manageManagersBtn
            // 
            manageManagersBtn.BackColor = Color.Black;
            manageManagersBtn.FlatAppearance.BorderColor = Color.Black;
            manageManagersBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            manageManagersBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            manageManagersBtn.FlatStyle = FlatStyle.Flat;
            manageManagersBtn.Font = new Font("Segoe UI", 9F);
            manageManagersBtn.ForeColor = Color.White;
            manageManagersBtn.Location = new Point(10, 10);
            manageManagersBtn.Name = "manageManagersBtn";
            manageManagersBtn.Size = new Size(160, 40);
            manageManagersBtn.TabIndex = 4;
            manageManagersBtn.Text = "Manage managers";
            manageManagersBtn.UseVisualStyleBackColor = false;
            manageManagersBtn.Click += manageManagersBtn_Click_1;
            // 
            // manageProductsBtn
            // 
            manageProductsBtn.BackColor = Color.Black;
            manageProductsBtn.FlatAppearance.BorderColor = Color.Black;
            manageProductsBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            manageProductsBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            manageProductsBtn.FlatStyle = FlatStyle.Flat;
            manageProductsBtn.Font = new Font("Segoe UI", 9F);
            manageProductsBtn.ForeColor = Color.White;
            manageProductsBtn.Location = new Point(10, 55);
            manageProductsBtn.Name = "manageProductsBtn";
            manageProductsBtn.Size = new Size(160, 40);
            manageProductsBtn.TabIndex = 5;
            manageProductsBtn.Text = "Manage products";
            manageProductsBtn.UseVisualStyleBackColor = false;
            manageProductsBtn.Click += manageProductsBtn_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(10, 250);
            button4.Name = "button4";
            button4.Size = new Size(160, 40);
            button4.TabIndex = 6;
            button4.Text = "Manage orders";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.Black;
            btnCart.FlatAppearance.BorderColor = Color.Black;
            btnCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 50, 50);
            btnCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Segoe UI", 10F);
            btnCart.ForeColor = Color.White;
            btnCart.Location = new Point(10, 296);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(160, 40);
            btnCart.TabIndex = 7;
            btnCart.Text = "Кошик";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCart);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(manageProductsBtn);
            panel1.Controls.Add(manageManagersBtn);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 423);
            panel1.TabIndex = 0;
            // 
            // MainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "MainUserControl";
            Size = new Size(180, 423);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button manageManagersBtn;
        private Button manageProductsBtn;
        private Button button4;
        private Button btnCart;
        private Panel panel1;
    }
}