namespace MilitaryEquipmentStore.Controls.Auth
{
    partial class LoginUserControl
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1 = new Panel();

            panel1.SuspendLayout();
            SuspendLayout();

            // panel1 – card style
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Padding = new Padding(10);
            panel1.Location = new Point(110, 110);
            panel1.Size = new Size(200, 170);

            // label1 (Email)
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            label1.Text = "Email";

            // textBox1 (Email)
            textBox1.Location = new Point(10, 30);
            textBox1.Size = new Size(175, 25);
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.BorderStyle = BorderStyle.FixedSingle;

            // label2 (Password)
            label2.AutoSize = true;
            label2.Location = new Point(10, 65);
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            label2.Text = "Password";

            // textBox2 (Password)
            textBox2.Location = new Point(10, 85);
            textBox2.Size = new Size(175, 25);
            textBox2.Font = new Font("Segoe UI", 10F);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.UseSystemPasswordChar = true;

            // button1 (Login)
            button1.Location = new Point(10, 120);
            button1.Size = new Size(175, 35);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Text = "Login";
            button1.BackColor = Color.FromArgb(0, 120, 215);   // Windows blue
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Cursor = Cursors.Hand;
            button1.Click += button1_Click;

            // add controls
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button1);

            Controls.Add(panel1);

            // UserControl
            BackColor = Color.FromArgb(245, 245, 245);
            Size = new Size(400, 400);

            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Panel panel1;
    }
}
