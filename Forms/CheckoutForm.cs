using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryEquipmentStore.Controls;
using MilitaryEquipmentStore.Models;

namespace MilitaryEquipmentStore.Forms
{
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            flowOrderItems.Controls.Clear();

            var cartItems = Order.GetItems();

            if (cartItems == null || cartItems.Count == 0)
            {
                var emptyLabel = new Label
                {
                    Text = "Кошик порожній",
                    Font = new Font("Segoe UI", 11, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Height = 50
                };
                flowOrderItems.Controls.Add(emptyLabel);
                btnConfirmOrder.Enabled = false;
                return;
            }

            foreach (var item in cartItems)
            {
                var orderItemControl = new OrderItemUserControl();

                orderItemControl.SetItemData(
                    item.Article,
                    item.Price,
                    item.Quantity,
                    item.Total
                );

                flowOrderItems.Controls.Add(orderItemControl);
            }

            btnConfirmOrder.Enabled = (cartItems.Count > 0);
        }
    }
}
