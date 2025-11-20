using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryEquipmentStore.Modal_windows
{
    public partial class EditManagerForm : Form
    {
        private int manager_id;

        public EditManagerForm(int id)
        {
            InitializeComponent();
            manager_id = id;
            LoadManager();
        }

        private void EditManagerForm_Load(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void LoadManager() 
        {
            string query = $"select fullname, email_, phonenumber from users where id = '{manager_id}'";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader.Read())
                {
                    textBox1.Text = reader["fullname"].ToString();
                    textBox2.Text = reader["email_"].ToString();
                    textBox3.Text = reader["phonenumber"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
