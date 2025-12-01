namespace MilitaryEquipmentStore.Controls
{
    partial class OrderItemUserControl
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
        /// 
        private Panel panelMain;
        private Label lblName;
        private Label lblArticle;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblTotal;
        private Panel panelSeparator;

        private void InitializeComponent()
        {
            panelMain = new Panel();
            lblTotal = new Label();
            lblQuantity = new Label();
            lblPrice = new Label();
            lblArticle = new Label();
            lblName = new Label();
            panelSeparator = new Panel();
            panelMain.SuspendLayout();
            SuspendLayout();

            // panelMain
            // 
            panelMain.BackColor = Color.White;
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(lblTotal);
            panelMain.Controls.Add(lblQuantity);
            panelMain.Controls.Add(lblPrice);
            panelMain.Controls.Add(lblArticle);
            panelMain.Controls.Add(lblName);
            panelMain.Controls.Add(panelSeparator);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(10);
            panelMain.Size = new Size(740, 80);
            panelMain.TabIndex = 0;

            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(600, 40);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(130, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "0,00 грн";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;

            // lblQuantity
            // 
            lblQuantity.Font = new Font("Segoe UI", 10F);
            lblQuantity.ForeColor = Color.Black;
            lblQuantity.Location = new Point(10, 40);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(150, 25);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Кількість: 1 шт";
            lblQuantity.TextAlign = ContentAlignment.MiddleLeft;

            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrice.Font = new Font("Segoe UI", 10F);
            lblPrice.ForeColor = Color.Black;
            lblPrice.Location = new Point(600, 10);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(130, 25);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Ціна: 0,00 грн";
            lblPrice.TextAlign = ContentAlignment.MiddleRight;

            // lblArticle
            // 
            lblArticle.Font = new Font("Segoe UI", 9F);
            lblArticle.ForeColor = Color.Gray;
            lblArticle.Location = new Point(200, 10);
            lblArticle.Name = "lblArticle";
            lblArticle.Size = new Size(300, 25);
            lblArticle.TabIndex = 2;
            lblArticle.Text = "Артикул: ART-001";
            lblArticle.TextAlign = ContentAlignment.MiddleLeft;

            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(10, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(180, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Назва товару";
            lblName.TextAlign = ContentAlignment.MiddleLeft;

            // panelSeparator
            // 
            panelSeparator.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSeparator.BackColor = Color.Silver;
            panelSeparator.Location = new Point(10, 75);
            panelSeparator.Name = "panelSeparator";
            panelSeparator.Size = new Size(720, 1);
            panelSeparator.TabIndex = 0;

            // OrderItemUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panelMain);
            Name = "OrderItemUserControl";
            Size = new Size(740, 80);
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
