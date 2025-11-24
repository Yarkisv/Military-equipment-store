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
    public partial class ManageProductsControl : UserControl
    {
        public ManageProductsControl()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {

        }

        private void LoadProducts()
        {
            string query = "select type, article, name_, price, description_ from products";

            using (var reader = DbConfig.ReadData(query))
            {
                dataGridProducts.Rows.Clear();
                while (reader.Read())
                {
                    dataGridProducts.Rows.Add(reader["type"], reader["article"], reader["name_"], reader["price"], reader["description_"], "Edit", "Delete");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var article = dataGridProducts.Rows[e.RowIndex].Cells["Article"].Value.ToString();

            if (dataGridProducts.Columns[e.ColumnIndex].HeaderText.Equals("Edit"))
            {
                EditProductForm editProductForm = new EditProductForm(article);

                editProductForm.ShowDialog();
            }

            //if (dataGridProducts.Columns[e.ColumnIndex].HeaderText.Equals("Delete"))
            //{
            //    var result = MessageBox.Show(
            //        "Delete product?",
            //        "Confirmation",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Warning
            //    );

            //    if (result == DialogResult.Yes)
            //    {
            //        string deleteQuery = $"delete from users where id =";
            //        DbConfig.ExecuteQuery(deleteQuery);
            //    }
            //}
        }
    }
}
