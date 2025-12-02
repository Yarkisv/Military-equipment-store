using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryEquipmentStore.Models;

namespace MilitaryEquipmentStore.Controls.Auth
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            string fullname = textBox1.Text;
            string email = textBox2.Text;
            string phone = textBox3.Text;
            string password = textBox4.Text;

            if (string.IsNullOrEmpty(fullname))
            {
                MessageBox.Show("Введіть повне ім'я клієнта", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Введіть email клієнта", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введіть пароль для клієнта", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }

            try
            {
                string query = $"select count(*) from users where email_ = '{email}';";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null && reader.Read())
                    {
                        int count = reader.GetInt32(0);

                        if (count > 0)
                        {
                            MessageBox.Show("Клієнт з таким email вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBox2.Focus();
                            return;
                        }
                    }
                }

                User.CreateUser(fullname, password, phone, email);

                MessageBox.Show("Клієнта успішно додано", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exception) 
            {
                MessageBox.Show($"Помилка створення клієнта: {exception.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
