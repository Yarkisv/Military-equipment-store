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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MilitaryEquipmentStore.Controls.Auth
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();

            panelCard.Left = (this.ClientSize.Width - panelCard.Width) / 2;
            panelCard.Top = (this.ClientSize.Height - panelCard.Height) / 2;

            panelLogo.Left = (this.ClientSize.Width - panelLogo.Width) / 2;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userEmail = textBoxEmail.Text;
            string password = textBoxPassword.Text;

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

                    textBoxEmail.Text = "";
                    textBoxPassword.Text = "";

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
