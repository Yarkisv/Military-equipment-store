using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEquipmentStore.Models
{
    internal class Product
    {
        public string Type { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public void Update()
        {
            string query = $"update products set name_ = '{Name}', price = '{Price.ToString(System.Globalization.CultureInfo.InvariantCulture)}', description_ = '{Description}' where article = '{Article}'";

            DbConfig.ExecuteQuery(query);
        }
    }
}
