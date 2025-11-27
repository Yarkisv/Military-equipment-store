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
    public partial class ManageOrdersControl1 : UserControl
    {
        public ManageOrdersControl1()
        {
            InitializeComponent();

            colStatus.Items.AddRange("оформлено", "виконано", "скасовано");

            cmbStatusFilter.SelectedIndex = 0;

            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                string statusFilter = cmbStatusFilter.SelectedItem?.ToString() ?? "Всі";
                string query = @"
                    select 
                        o.order_id,
                        o.order_date,
                        u.fullname as customer_name,
                        o.quantity,
                        o.total_price,
                        o.status_
                    from orders o
                    inner join Users u on o.client_id = u.id";

                if (statusFilter != "Всі")
                {
                    query += $" where o.status_ = '{statusFilter}'";
                }

                query += " order by o.order_date desc";

                DataTable ordersTable = new DataTable();

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null)
                    {
                        ordersTable.Load(reader);
                    }
                }

                dgvOrders.DataSource = ordersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помиока при завантаженні замовлень: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvOrders.SelectedRows)
                {
                    if (row.IsNewRow) continue;

                    int orderId = Convert.ToInt32(row.Cells["colOrderId"].Value);
                    string newStatus = row.Cells["colStatus"].Value?.ToString();

                    if (!string.IsNullOrEmpty(newStatus))
                    {
                        string updateQuery = $@"
                            update orders 
                            set status_ = '{newStatus}' 
                            where order_id = {orderId}";

                        DbConfig.ExecuteQuery(updateQuery);
                    }
                }

                MessageBox.Show("Статуси замовленнь успішно оновлені", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помлка при оновленні статуса: {ex.Message}", "Поммлка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["colOrderId"].Value);
                string customerName = dgvOrders.SelectedRows[0].Cells["colCustomerName"].Value?.ToString() ?? "Неизвестно";

                ShowOrderDetails(orderId, customerName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні детелей замовлення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowOrderDetails(int orderId, string customerName)
        {
            try
            {
                OrderDetailsForm itemsForm = new OrderDetailsForm(orderId, customerName);
                itemsForm.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Помилка при завантаженні товарів замовлення: {exception.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshData()
        {
            LoadOrders();
        }
    }
}