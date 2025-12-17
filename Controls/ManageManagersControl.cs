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
            LoadInactiveManagers();

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
                        reader["phonenumber"],
                        reader["email_"],
                        "Change",
                        "Delete"
                    );
                }
            }
        }

        private void LoadInactiveManagers()
        {
            string query = @"
                select 
                    fullname, 
                    phonenumber, 
                    email_, 
                    deactivated_at, 
                    reason 
                from inactive_managers 
                order by deactivated_at desc";

            try
            {
                using (var reader = DbConfig.ReadData(query))
                {
                    dataGridInactiveManagers.Rows.Clear();

                    while (reader.Read())
                    {
                        DateTime deactivatedAt = DateTime.Parse(reader["deactivated_at"].ToString());
                        string formattedDate = deactivatedAt.ToString("dd.MM.yyyy");

                        dataGridInactiveManagers.Rows.Add(
                            reader["fullname"],
                            reader["phonenumber"],
                            reader["email_"],
                            formattedDate,
                            reader["reason"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження звільнених менеджерів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridManagers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int managerId = Convert.ToInt32(dataGridManagers.Rows[e.RowIndex].Cells["Id"].Value);

            if (dataGridManagers.Columns[e.ColumnIndex].HeaderText.Equals("Редагувати"))
            {
                EditManagerForm editForm = new EditManagerForm(managerId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadManagers();
                }
            }

            if (dataGridManagers.Columns[e.ColumnIndex].HeaderText.Equals("Звільнити"))
            {
                var result = MessageBox.Show("Delete manager?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    
                    using (DeactivateManager deactivateForm = new DeactivateManager(managerId))
                    {
                        if (deactivateForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadManagers();
                            LoadInactiveManagers();
                        }
                    }
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
