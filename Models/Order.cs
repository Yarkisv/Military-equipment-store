using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

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
    }
}
