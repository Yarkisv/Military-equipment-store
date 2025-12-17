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
using MySql.Data.MySqlClient;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace MilitaryEquipmentStore.Modal_windows
{
    public partial class OrderDetailsForm : Form
    {
        private int orderId;
        private static readonly string ReceiptFolder = "D:/OrderReceipts/";

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

            LoadOrderItems();
        }

        private void LoadOrderItems()
        {
            try
            {
                string query = @$"select p.name_ as product_name, p.article, p.type, oi.quantity, oi.price
                                  from ordered_items oi
                                  join products p on p.product_id = oi.product_id
                                  where oi.order_id = {orderId};";

                string totalPriceQuery = $"select total_price from orders where order_id = {orderId}";

                dgvItems.Rows.Clear();

                using (var reader = DbConfig.ReadData(query))
                {
                    while (reader.Read())
                    {
                        dgvItems.Rows.Add(
                            reader["product_name"],
                            reader["article"],
                            reader["type"],
                            reader["quantity"],
                            reader["price"]
                        );
                    }
                }

                using (var reader = DbConfig.ReadData(totalPriceQuery))
                {
                    if (reader != null && reader.Read())
                    {
                        lblTotalSum.Text = $"Загальна сума: {reader["total_price"]} грн.";
                    }
                }
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

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                SaveReceiptAsDocx(orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при створенні чека: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveReceiptAsDocx(int orderId)
        {
            if (!Directory.Exists(ReceiptFolder))
            {
                Directory.CreateDirectory(ReceiptFolder);
            }

            string filePath = Path.Combine(ReceiptFolder, $"Receipt_Order_{orderId}.docx");

            using (DocX document = DocX.Create(filePath))
            {
                string orderQuery = $@"
                    select 
                        o.order_id,
                        o.order_date,
                        o.quantity,
                        o.total_price,
                        o.status_,
                        u.fullname as client_name
                    from orders o
                    join users u on u.id = o.client_id
                    where o.order_id = {orderId};";

                DateTime orderDate;
                decimal totalPrice;
                string clientName;
                string status;

                using (var reader = DbConfig.ReadData(orderQuery))
                {
                    if (!reader.Read())
                    {
                        throw new Exception("Замовлення не знайдено");
                    }

                    orderDate = Convert.ToDateTime(reader["order_date"]);
                    totalPrice = Convert.ToDecimal(reader["total_price"]);
                    clientName = reader["client_name"].ToString();
                    status = reader["status_"].ToString();
                }

                document.InsertParagraph("Чек замовлення").FontSize(16).Bold().Alignment = Alignment.center;

                document.InsertParagraph($"Номер замовлення: {orderId}");
                document.InsertParagraph($"Дата: {orderDate:dd.MM.yyyy}");
                document.InsertParagraph($"Клієнт: {clientName}");
                document.InsertParagraph($"Статус: {status}").SpacingAfter(15);

                string itemsQuery = $@"
                    select 
                        p.name_ as product_name,
                        p.article,
                        p.type,
                        oi.quantity,
                        oi.price
                    from ordered_items oi
                    join products p on p.product_id = oi.product_id
                    where oi.order_id = {orderId};";

                using (var reader = DbConfig.ReadData(itemsQuery))
                {
                    Table table = document.AddTable(1, 5);
                    table.Design = TableDesign.TableGrid;

                    table.Rows[0].Cells[0].Paragraphs[0].Append("Товар").Bold();
                    table.Rows[0].Cells[1].Paragraphs[0].Append("Артикул").Bold();
                    table.Rows[0].Cells[2].Paragraphs[0].Append("Тип").Bold();
                    table.Rows[0].Cells[3].Paragraphs[0].Append("К-сть").Bold();
                    table.Rows[0].Cells[4].Paragraphs[0].Append("Ціна").Bold();

                    while (reader.Read())
                    {
                        Row row = table.InsertRow();

                        row.Cells[0].Paragraphs[0].Append(reader["product_name"].ToString());
                        row.Cells[1].Paragraphs[0].Append(reader["article"].ToString());
                        row.Cells[2].Paragraphs[0].Append(reader["type"].ToString());
                        row.Cells[3].Paragraphs[0].Append(reader["quantity"].ToString());
                        row.Cells[4].Paragraphs[0].Append(Convert.ToDecimal(reader["price"]).ToString("F2"));
                    }

                    document.InsertTable(table);
                }

                document.InsertParagraph().SpacingBefore(15).Append($"Загальна сума: {totalPrice:F2} грн.").FontSize(14).Bold().Alignment = Alignment.right;

                document.Save();
            }

            MessageBox.Show($"Чек збережено:\n{filePath}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvItems.Columns[e.ColumnIndex].Name == "colDelete")
            {
                var result = MessageBox.Show("Ви дійсно хочете видалити товар із замовлення?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int orderId = this.orderId;
                    string article = dgvItems.Rows[e.RowIndex].Cells["colArticle"].Value.ToString();

                    DeleteOrderItem(orderId, article);

                    LoadOrderItems();
                }
            }
        }

        private void DeleteOrderItem(int orderId, string article)
        {
            try
            {
                string updateQuery = @$"update orders o
                                        join ordered_items oi on oi.order_id = o.order_id
                                        join products p on p.product_id = oi.product_id
                                        set 
                                            o.quantity = o.quantity - 1,
                                            o.total_price = o.total_price - oi.price
                                        where o.order_id = {orderId} and p.article = '{article}';";

                DbConfig.ExecuteQuery(updateQuery);

                string deleteQuery = $"delete oi from ordered_items oi join products p on p.product_id = oi.product_id where oi.order_id = {orderId} and p.article = '{article}';";

                DbConfig.ExecuteQuery(deleteQuery);

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }           
        }
    }
}