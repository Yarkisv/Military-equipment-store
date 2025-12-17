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
    public partial class DeactivateManager : Form
    {
        private int id;

        public DeactivateManager(int managerId)
        {
            id = managerId;
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string reason = textBoxReason.Text.Trim();

            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Буль ласка, введіть причину звільнення", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string selectQuery = $"select fullname, phonenumber, email_ from users where id = {id}";

                string fullname = "";
                string phonenumber = "";
                string email = "";

                using (var reader = DbConfig.ReadData(selectQuery))
                {
                    if (reader.Read())
                    {
                        fullname = reader["fullname"].ToString();
                        phonenumber = reader["phonenumber"].ToString();
                        email = reader["email_"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Менеджера не знайдено.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string insertQuery = $@"insert into inactive_managers (fullname, phonenumber, email_, deactivated_at, reason)
                                        values ('{fullname}', '{phonenumber}', '{email}', curdate(), '{reason}');";
                DbConfig.ExecuteQuery(insertQuery);

                string deleteQuery = $"delete from users where id = {id}";
                DbConfig.ExecuteQuery(deleteQuery);

                MessageBox.Show("Менеджера було успішно звільнено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
