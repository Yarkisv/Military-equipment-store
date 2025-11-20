namespace MilitaryEquipmentStore.Controls
{
    partial class ProductCardUserControl
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
            labelTitle = new Label();
            labelSpecs = new Label();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTitle.Location = new Point(10, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(240, 20);
            labelTitle.TabIndex = 0;
            // 
            // labelSpecs
            // 
            labelSpecs.Font = new Font("Segoe UI", 9F);
            labelSpecs.Location = new Point(10, 40);
            labelSpecs.Name = "labelSpecs";
            labelSpecs.Size = new Size(240, 75);
            labelSpecs.TabIndex = 1;
            // 
            // ProductCardUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelSpecs);
            Controls.Add(labelTitle);
            Margin = new Padding(10);
            Name = "ProductCardUserControl";
            Size = new Size(260, 126);
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Label labelSpecs;
    }
}
