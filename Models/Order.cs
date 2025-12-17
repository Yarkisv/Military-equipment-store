using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEquipmentStore.Models
{
    public static class Order
    {
        private static List<OrderItems> orderItems = new List<OrderItems>();

        public static void addItemToOrder(int productId, string article, decimal price, int quantity = 1) 
        {
            var existingItem = orderItems.FirstOrDefault(x => x.ProductId == productId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                orderItems.Add(new OrderItems
                {
                    ProductId = productId,
                    Article = article,
                    Price = price,
                    Quantity = quantity
                });
            }
        }

        public static void RemoveItem(int productId)
        {
            var item = orderItems.FirstOrDefault(x => x.ProductId == productId);
            if (item != null)
            {
                orderItems.Remove(item);
            }
        }

        public static List<OrderItems> GetItems()
        {
            return new List<OrderItems>(orderItems);
        }

        public static void Clear()
        {
            orderItems.Clear();
        }

        public static int GetItemCount()
        {
            return orderItems.Sum(x => x.Quantity);
        }

        public static decimal GetTotalPrice()
        {
            return orderItems.Sum(x => x.Total);
        }

        public static bool IsEmpty()
        {
            return orderItems.Count == 0;
        }

        public static void InsertOrderIntoDb(int clientId, int quantity, decimal totalPrice, string status = "оформлено", DateTime? orderDate = null)
        {
            orderDate = DateTime.Now;

            string formattedDate = orderDate.Value.ToString("yyyy-MM-dd");
            string formattedPrice = totalPrice.ToString("0.00", CultureInfo.InvariantCulture);

            string query = @$"insert into orders (order_date, client_id, quantity, total_price, status_) 
                              values ('{formattedDate}', '{clientId}', '{quantity}', '{formattedPrice}', 'оформлено')";

            long orderId = DbConfig.ExecuteQueryWithLastId(query);

            Order.InsertOrderItems(orderId);

            UpdateProductAvailability();
        }

        private static void InsertOrderItems(long orderId)
        {
            foreach (var item in orderItems)
            {
                string price = item.Price.ToString("0.00", CultureInfo.InvariantCulture);

                string query = @$"insert into ordered_items (order_id, product_id, quantity, price) 
                                  values ('{orderId}', '{item.ProductId}', '{item.Quantity}', '{price}')";

                DbConfig.ExecuteQuery(query);
            }
        }

        private static void UpdateProductAvailability(string newAvailability = "Ні")
        {
            foreach (var item in orderItems)
            {
                string query = $"update products set is_available = '{newAvailability}' where product_id = {item.ProductId}";

                DbConfig.ExecuteQuery(query);
            }
        }
    }
}
