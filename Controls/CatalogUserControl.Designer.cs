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
            filtersPanel = new Panel();
            panelHeader = new Panel();
            labelCategoryTitle = new Label();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.BackColor = Color.FromArgb(25, 25, 25);
            flowLayoutPanelProducts.Dock = DockStyle.Fill;
            flowLayoutPanelProducts.Location = new Point(0, 60);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Padding = new Padding(15);
            flowLayoutPanelProducts.Size = new Size(658, 646);
            flowLayoutPanelProducts.TabIndex = 0;
            // 
            // filtersPanel
            // 
            filtersPanel.AutoScroll = true;
            filtersPanel.BackColor = Color.FromArgb(25, 25, 25);
            filtersPanel.BorderStyle = BorderStyle.FixedSingle;
            filtersPanel.Dock = DockStyle.Right;
            filtersPanel.Location = new Point(658, 60);
            filtersPanel.Name = "filtersPanel";
            filtersPanel.Padding = new Padding(10);
            filtersPanel.Size = new Size(324, 646);
            filtersPanel.TabIndex = 1;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(20, 20, 20);
            panelHeader.Controls.Add(labelCategoryTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(982, 60);
            panelHeader.TabIndex = 2;
            // 
            // labelCategoryTitle
            // 
            labelCategoryTitle.AutoSize = true;
            labelCategoryTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelCategoryTitle.ForeColor = Color.White;
            labelCategoryTitle.Location = new Point(20, 18);
            labelCategoryTitle.Name = "labelCategoryTitle";
            labelCategoryTitle.Size = new Size(96, 30);
            labelCategoryTitle.TabIndex = 0;
            labelCategoryTitle.Text = "Каталог";
            // 
            // CatalogUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            Controls.Add(flowLayoutPanelProducts);
            Controls.Add(filtersPanel);
            Controls.Add(panelHeader);
            Name = "CatalogUserControl";
            Size = new Size(982, 706);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelProducts;
        private Panel filtersPanel;
        private Panel panelHeader;
        private Label labelCategoryTitle;
    }
}