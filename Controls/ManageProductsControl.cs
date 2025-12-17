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
using MilitaryEquipmentStore.Models;

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
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void LoadProducts()
        {
            dataGridProducts.Rows.Clear();

            foreach (var product in Product.GetAll())
            {
                dataGridProducts.Rows.Add(product.Type, product.Article, product.Name, product.Price, product.Description, "Edit", "Delete");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var article = dataGridProducts.Rows[e.RowIndex].Cells["Article"].Value.ToString();

            if (dataGridProducts.Columns[e.ColumnIndex].HeaderText.Equals("Редагувати"))
            {
                EditProductForm editProductForm = new EditProductForm(article);

                editProductForm.ShowDialog();
            }

            if (dataGridProducts.Columns[e.ColumnIndex].HeaderText.Equals("Видалити"))
            {
                var result = MessageBox.Show(
                    "Delete product?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = $"delete from products where article = '{article}';";
                    DbConfig.ExecuteQuery(deleteQuery);
                    LoadProducts();
                }
            }
        }
    }
}
