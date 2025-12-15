using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEquipmentStore.Models
{
    public class Product
    {
        public string Type { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public void Insert()
        {
            string query = $@"
                    insert into products (type, article, name_, price, description_)
                    values ('{Type}', '{Article}', '{Name}', {Price.ToString(System.Globalization.CultureInfo.InvariantCulture)}, '{Description}')";

            DbConfig.ExecuteQuery(query);
        }

        public void Update()
        {
            string query = $"update products set name_ = '{Name}', price = '{Price.ToString(System.Globalization.CultureInfo.InvariantCulture)}', description_ = '{Description}' where article = '{Article}'";

            DbConfig.ExecuteQuery(query);
        }

        public virtual bool ApplyFilters(Dictionary<string, object> filters)
        {
            foreach (var filter in filters)
            {
                switch (filter.Key)
                {
                    case "MinPrice":
                        if (filter.Value is decimal minPrice && this.Price < minPrice) return false;
                        break;

                    case "MaxPrice":
                        if (filter.Value is decimal maxPrice && this.Price > maxPrice) return false;
                        break;
                }
            }
            return true;
        }

        public static int GetProductId(string article) 
        {
            try
            {
                string query = $"select product_id from products where article = '{article}';";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null && reader.Read()) 
                    {
                        return reader.GetInt32("product_id"); 
                    }
                }
            }
            catch (Exception exception) 
            {
                throw new Exception("SQL exception");
            }

            return 0;
        }

        public static List<Product> GetAll()
        {
            List<Product> products = new List<Product>();

            string query = "SELECT type, article, name_, price, description_ FROM products";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Type = reader["type"].ToString(),
                            Article = reader["article"].ToString(),
                            Name = reader["name_"].ToString(),
                            Price = Convert.ToDecimal(reader["price"]),
                            Description = reader["description_"].ToString()
                        });
                    }
                }
            }

            return products;
        }
        public static Product GetByArticle(string article)
        {
            string query = $"SELECT type, article, name_, price, description_ FROM products WHERE article = '{article}'";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader != null && reader.Read())
                {
                    return new Product
                    {
                        Type = reader["type"].ToString(),
                        Article = reader["article"].ToString(),
                        Name = reader["name_"].ToString(),
                        Price = Convert.ToDecimal(reader["price"]),
                        Description = reader["description_"].ToString()
                    };
                }
            }

            return null;
        }
    }
}
