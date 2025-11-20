using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryEquipmentStore.Forms;
using MilitaryEquipmentStore.Models;

namespace MilitaryEquipmentStore.Controls.Auth
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();

            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userEmail = textBox1.Text;
            string password = textBox2.Text;

            string userRole = "";

            if (string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Input email or password");
                return;
            }

            string query = $"select * from users where email_ = '{userEmail}'";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader == null || !reader.Read())
                {
                    MessageBox.Show("User not found");

                    textBox1.Text = "";
                    textBox2.Text = "";

                    return;
                }

                string storedHash = reader["hashPassword"].ToString();

                bool valid = BCrypt.Net.BCrypt.Verify(password, storedHash);

                if (!valid)
                {
                    MessageBox.Show("Uncorrect password!");
                    return;
                }
                UserSession.Role = reader["role_"].ToString();

                MessageBox.Show("Login successful");
            }

            var form = this.FindForm() as Form1;
            if (form != null)
            {
                form.ShowMainView();
            }
        }
    }
}
