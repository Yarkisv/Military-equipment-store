using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
