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

namespace MilitaryEquipmentStore.Modal_windows
{
    public partial class ResetPassword : Form
    {
        private int _managerId;

        public ResetPassword(int id)
        {
            _managerId = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = textBox1.Text;
            string confirmPassword = textBox2.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords not same");
                return;
            }

            try
            {
                User.ResetPassword(newPassword, _managerId);
                MessageBox.Show("Password successfuly reseted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during reseting {ex.Message}");
            }
        }
    }
}
