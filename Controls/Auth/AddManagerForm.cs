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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MilitaryEquipmentStore.Modal_windows
{
    public partial class AddManagerForm : Form
    {
        public AddManagerForm()
        {
            InitializeComponent();
        }

        private void AddManagerForm_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void addManager_Click(object sender, EventArgs e)
        {
            string newManagerFullname = textBox1.Text;
            string newManagerEmail = textBox2.Text;
            string newManagerPhone = textBox3.Text;
            string newManagerPassword = textBox4.Text;

            string newManagerHashedPassword = BCrypt.Net.BCrypt.HashPassword(newManagerPassword);

            string query = $"insert into users (fullname, hashPassword, phoneNumber, email_ ) values ('{newManagerFullname}', '{newManagerHashedPassword}', '{newManagerPhone}', '{newManagerEmail}')";

            DbConfig.ExecuteQuery(query);

            this.Hide();
        }
    }
}
