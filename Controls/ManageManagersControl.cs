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
                
            button1.Dock = DockStyle.Top;
            dataGridManagers.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddManagerForm addManagerForm = new AddManagerForm();

            if (addManagerForm.ShowDialog() == DialogResult.OK)
            {
                LoadManagers();
            }
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

        private void DataGridManagers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int managerId = Convert.ToInt32(dataGridManagers.Rows[e.RowIndex].Cells["id"].Value);

            if (dataGridManagers.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                dataGridManagers.Columns[e.ColumnIndex].HeaderText == "Change")
            {
                EditManagerForm editForm = new EditManagerForm(managerId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadManagers();
                }
            }

            if (dataGridManagers.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                dataGridManagers.Columns[e.ColumnIndex].HeaderText == "Delete")
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
    }
}
