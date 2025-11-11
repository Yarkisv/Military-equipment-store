using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MilitaryEquipmentStore.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userFullname = fullnameInput.Text;
            string userEmail = emailInput.Text;
            string userPhone = phoneInput.Text;
            string userPassword = passwordInput.Text;

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(userPassword);

            if (string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(userPassword) || string.IsNullOrEmpty(userPhone) || string.IsNullOrEmpty(userFullname))
            {
                return;
            }

            string query = $"insert into users (fullname, hashPassword, phoneNumber, email_ ) values ('{userFullname}', '{hashedPassword}', '{userPhone}', '{userEmail}')";

            DbConfig.ExecuteQuery(query);
        }
    }
}
