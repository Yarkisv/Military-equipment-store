using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryEquipmentStore.Modal_windows;

namespace MilitaryEquipmentStore.Controls
{
    public partial class ManageManagersControl : UserControl
    {
        public ManageManagersControl()
        {
            InitializeComponent();
            LoadManagers();

            dataGridManagers.Dock = DockStyle.Fill;
        }

        private void LoadManagers()
        {
            string query = "select id, fullname, email_, phonenumber from users where role_ ='manager'";

            using (var reader = DbConfig.ReadData(query))
            {
                dataGridManagers.Rows.Clear();

                while (reader.Read())
                {
                    dataGridManagers.Rows.Add(
                        reader["id"],
                        reader["fullname"],
                        reader["email_"],
                        reader["phonenumber"],
                        "Change",
                        "Delete"
                    );
                }
            }
        }

        private void dataGridManagers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int managerId = Convert.ToInt32(dataGridManagers.Rows[e.RowIndex].Cells["Id"].Value);

            if (dataGridManagers.Columns[e.ColumnIndex].HeaderText.Equals("Edit"))
            {
                EditManagerForm editForm = new EditManagerForm(managerId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadManagers();
                }
            }

            if (dataGridManagers.Columns[e.ColumnIndex].HeaderText.Equals("Delete"))
            {
                var result = MessageBox.Show(
                    "Delete manager?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = $"delete from users where id = {managerId}";
                    DbConfig.ExecuteQuery(deleteQuery);
                    LoadManagers();
                }
            }
        }

        private void addManagerBtn_Click(object sender, EventArgs e)
        {
            AddManagerForm addManagerForm = new AddManagerForm();

            if (addManagerForm.ShowDialog() == DialogResult.OK)
            {
                LoadManagers();
            }
        }
    }
}
