using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryEquipmentStore.Controls.Auth;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MilitaryEquipmentStore.Models;

namespace MilitaryEquipmentStore.Modal_windows
{
    public partial class SelectClientForm : Form
    {
        private int SelectedClientId;
        private string SelectedClientEmail;
        private string SelectedClientName;
        private string SelectedClientPhone;

        public SelectClientForm()
        {
            InitializeComponent();

            SelectedClientId = 0;
            SelectedClientEmail = "";
            SelectedClientName = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Введіть email для пошуку", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"select id, email_, fullname, phonenumber from users where email_ = '{email}' and role_ = 'client';";

            try
            {
                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader == null || !reader.Read())
                    {
                        lblClientInfo.Text = "Клієнт не знайдений";
                        btnSelect.Enabled = false;
                        SelectedClientId = 0;
                        SelectedClientEmail = "";
                        SelectedClientName = "";
                        SelectedClientPhone = "";
                        return;
                    }

                    SelectedClientId = reader.GetInt32("id");
                    SelectedClientEmail = reader.GetString("email_");
                    SelectedClientName = reader.GetString("fullname");
                    SelectedClientPhone = reader.GetString("phonenumber");

                    lblClientInfo.Text = $"Клієнт знайдений:\nІм'я: {SelectedClientName}\nEmail: {SelectedClientEmail}\nТелефон: {SelectedClientPhone}";

                    UserSession.CurrentUserId = SelectedClientId;
                    UserSession.CurrentUserEmail = SelectedClientEmail;
                    UserSession.CurrentUserFullname = SelectedClientName;
                    UserSession.CurrentUserPhone = SelectedClientPhone;

                    btnSelect.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка пошуку клієнта: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (SelectedClientId > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();

            addClientForm.ShowDialog();
        }
    }
}
