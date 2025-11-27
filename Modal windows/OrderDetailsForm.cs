using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Crud;

namespace MilitaryEquipmentStore.Modal_windows
{
    public partial class OrderDetailsForm : Form
    {
        private int orderId;

        public OrderDetailsForm(int orderId, string customerName = "")
        {
            InitializeComponent();
            this.orderId = orderId;

            if (!string.IsNullOrEmpty(customerName))
            {
                this.Text = $"Товари в замовленні #{orderId} - {customerName}";
            }
            else
            {
                this.Text = $"Товары в замовленні #{orderId}";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            LoadOrderItems();
        }

        private void LoadOrderItems()
        {
            try
            {
                string query = $@"
                    select 
                        p.name_ as product_name,
                        p.article,
                        p.type,
                        oi.quantity,
                        oi.price,
                        oi.total_price
                    from ordered_items oi
                    inner join products p on oi.product_id = p.product_id
                    where oi.order_id = {orderId}";

                DataTable orderItems = new DataTable();

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null)
                    {
                        orderItems.Load(reader);
                    }
                }

                dgvItems.DataSource = orderItems;

                decimal totalSum = 0;
                foreach (DataRow row in orderItems.Rows)
                {
                    if (row["total_price"] != DBNull.Value)
                    {
                        totalSum += Convert.ToDecimal(row["total_price"]);
                    }
                }

                lblTotalSum.Text = $"Фінальна сума: {totalSum:N2}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні товарів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
