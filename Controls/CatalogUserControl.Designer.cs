namespace MilitaryEquipmentStore.Controls
{
    partial class CatalogUserControl
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
            flowLayoutPanelProducts = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.Location = new Point(3, 3);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(834, 606);
            flowLayoutPanelProducts.TabIndex = 0;
            // 
            // CatalogUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelProducts);
            Name = "CatalogUserControl";
            Size = new Size(840, 612);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelProducts;
    }
}
