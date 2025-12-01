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
    public partial class OrderItemUserControl : UserControl
    {
        public OrderItemUserControl()
        {
            InitializeComponent();
        }

        public void SetItemData(string article, decimal price, int quantity, decimal total)
        {
            //lblName.Text = name;
            lblArticle.Text = $"Артикул: {article}";
            lblPrice.Text = $"Ціна: {price:N2} грн";
            lblQuantity.Text = $"Кількість: {quantity} шт";
            lblTotal.Text = $"{total:N2} грн";
        }
    }
}
