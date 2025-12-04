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
using MilitaryEquipmentStore.Modal_windows;
using MilitaryEquipmentStore.Models;

namespace MilitaryEquipmentStore.Forms
{
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
            LoadCartItems();
            UpdateClientInfo();

            lblTotalPrice.Text = $"Загальна ціна: {Order.GetTotalPrice().ToString()}";
            lblTotalItems.Text = $"Кіл. товарів: {Order.GetItemCount().ToString()}";
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

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            using (var selectClientForm = new SelectClientForm())
            {
                if (selectClientForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateClientInfo();
                }
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            int selectedUserId = UserSession.CurrentUserId;
            decimal totalPrice = Order.GetTotalPrice();
            int quantity = Order.GetItemCount();

            Order.InsertOrderIntoDb(selectedUserId, quantity, totalPrice);

            Order.Clear();

            MessageBox.Show("Замовлення успішно підтверджено");

            LoadCartItems();
            lblTotalPrice.Text = "";
            lblTotalItems.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateClientInfo()
        {
            if (!string.IsNullOrEmpty(UserSession.CurrentUserEmail))
            {
                lblClientInfo.Text = $"Клієнт: {UserSession.CurrentUserEmail}";

                btnConfirmOrder.Enabled = true;
            }
            else
            {
                lblClientInfo.Text = "Клієнт не обраний";
                btnConfirmOrder.Enabled = false;
            }
        }
    }
}
