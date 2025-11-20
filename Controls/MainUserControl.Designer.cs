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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 72);
            button1.Name = "button1";
            button1.Size = new Size(150, 100);
            button1.TabIndex = 1;
            button1.Text = "Електроніка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(10, 178);
            button2.Name = "button2";
            button2.Size = new Size(150, 100);
            button2.TabIndex = 2;
            button2.Text = "Транспорт";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(10, 284);
            button3.Name = "button3";
            button3.Size = new Size(150, 100);
            button3.TabIndex = 3;
            button3.Text = "Аммуніція";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // manageManagersBtn
            // 
            manageManagersBtn.Location = new Point(10, 10);
            manageManagersBtn.Name = "manageManagersBtn";
            manageManagersBtn.Size = new Size(150, 25);
            manageManagersBtn.TabIndex = 4;
            manageManagersBtn.Text = "Manage managers";
            manageManagersBtn.UseVisualStyleBackColor = true;
            manageManagersBtn.Click += manageManagersBtn_Click_1;
            // 
            // manageProductsBtn
            // 
            manageProductsBtn.Location = new Point(10, 41);
            manageProductsBtn.Name = "manageProductsBtn";
            manageProductsBtn.Size = new Size(150, 25);
            manageProductsBtn.TabIndex = 5;
            manageProductsBtn.Text = "Manage products";
            manageProductsBtn.UseVisualStyleBackColor = true;
            manageProductsBtn.Click += manageProductsBtn_Click_1;
            // 
            // MainUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(manageProductsBtn);
            Controls.Add(manageManagersBtn);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainUserControl";
            Size = new Size(170, 396);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button manageManagersBtn;
        private Button manageProductsBtn;
    }
}
