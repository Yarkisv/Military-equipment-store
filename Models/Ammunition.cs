using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEquipmentStore.Models
{
    public class Ammunition : Product
    {
        public string Caliber { get; set; }
        public string AmmoType { get; set; }
        public decimal Weight { get; set; }
        public decimal Length { get; set; }
        public string ExplosiveType { get; set; }
        public int EffectiveRange { get; set; }
        public string StorageTemp { get; set; }
        public int ShelfLife { get; set; }

        public static Dictionary<string, Ammunition> GetAll()
        {
            var result = new Dictionary<string, Ammunition>();
            string query = @"
            select 
                p.product_id,
                p.type,
                p.article,
                p.name_,
                p.price,
                p.description_,
                a.caliber,
                a.ammo_type,
                a.weight,
                a.length,
                a.explosive_type,
                a.effective_range,
                a.storage_temp,
                a.shelf_life
            from products p
            join ammunition a on p.article = a.article
            where p.type = 'боєприпаси';";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader == null) return result;

                while (reader.Read())
                {
                    var item = new Ammunition
                    {
                        Type = reader["type"].ToString(),
                        Article = reader["article"].ToString(),
                        Name = reader["name_"].ToString(),
                        Price = reader.GetDecimal("price"),
                        Description = reader["description_"].ToString(),
                        Caliber = reader["caliber"].ToString(),
                        AmmoType = reader["ammo_type"].ToString(),
                        Weight = reader.GetDecimal("weight"),
                        Length = reader.GetDecimal("length"),
                        ExplosiveType = reader["explosive_type"].ToString(),
                        EffectiveRange = reader.GetInt32("effective_range"),
                        StorageTemp = reader["storage_temp"].ToString(),
                        ShelfLife = reader.GetInt32("shelf_life")
                    };

                    result[item.Article] = item;
                }
            }

            return result;
        }

        public void Insert()
        {
            string query = $@"
            insert into ammunition (article, caliber, ammo_type, weight, length, explosive_type, effective_range, storage_temp, shelf_life)
            values ('{Article}', '{Caliber}', '{AmmoType}', {Weight.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {Length.ToString(System.Globalization.CultureInfo.InvariantCulture)}, '{ExplosiveType}', {EffectiveRange}, '{StorageTemp}', {ShelfLife})";

            DbConfig.ExecuteQuery(query);
        }

        public void Update(string article)
        {
            string query = $"update ammunition set caliber = '{Caliber}', ammo_type = '{AmmoType}', weight = '{Weight.ToString(System.Globalization.CultureInfo.InvariantCulture)}', length = '{Length.ToString(System.Globalization.CultureInfo.InvariantCulture)}', explosive_type = '{ExplosiveType}', effective_range = '{EffectiveRange}', storage_temp = '{StorageTemp}', shelf_life = '{ShelfLife}' where article = '{Article}'";

            DbConfig.ExecuteQuery(query);
        }

        public static Ammunition GetByArticle(string article)
        {
            string query = $"select * from ammunition where article = '{article}'";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader != null && reader.Read())
                {
                    return new Ammunition
                    {
                        Article = reader["article"].ToString(),
                        Caliber = reader["caliber"].ToString(),
                        AmmoType = reader["ammo_type"].ToString(),
                        Weight = Convert.ToDecimal(reader["weight"]),
                        Length = Convert.ToDecimal(reader["length"]),
                        ExplosiveType = reader["explosive_type"].ToString(),
                        EffectiveRange = Convert.ToInt32(reader["effective_range"]),
                        StorageTemp = reader["storage_temp"].ToString(),
                        ShelfLife = Convert.ToInt32(reader["shelf_life"])
                    };
                }
            }

            return null;
        }

        public bool ApplyFilters(Dictionary<string, object> filters)
        {
            if (!base.ApplyFilters(filters))
                return false;

            foreach (var filter in filters)
            {
                switch (filter.Key)
                {
                    case "AmmoType":
                        if (filter.Value is List<string> ammoTypes && ammoTypes.Any())
                        {
                            if (!ammoTypes.Contains(this.AmmoType))
                                return false;
                        }
                        break;

                    case "Caliber":
                        if (filter.Value is string caliber && !string.IsNullOrEmpty(caliber))
                        {
                            if (!this.Caliber.Contains(caliber, StringComparison.OrdinalIgnoreCase))
                                return false;
                        }
                        break;

                    case "MinWeight":
                        if (filter.Value is decimal minWeight && this.Weight < minWeight)
                            return false;
                        break;

                    case "MaxWeight":
                        if (filter.Value is decimal maxWeight && this.Weight > maxWeight)
                            return false;
                        break;

                    case "MinLength":
                        if (filter.Value is decimal minLength && this.Length < minLength)
                            return false;
                        break;

                    case "MaxLength":
                        if (filter.Value is decimal maxLength && this.Length > maxLength)
                            return false;
                        break;

                    case "ExplosiveType":
                        if (filter.Value is List<string> explosiveTypes && explosiveTypes.Any())
                        {
                            if (!explosiveTypes.Contains(this.ExplosiveType))
                                return false;
                        }
                        break;

                    case "MinEffectiveRange":
                        if (filter.Value is int minRange && this.EffectiveRange < minRange)
                            return false;
                        break;

                    case "MaxEffectiveRange":
                        if (filter.Value is int maxRange && this.EffectiveRange > maxRange)
                            return false;
                        break;

                    case "MinShelfLife":
                        if (filter.Value is int minShelfLife && this.ShelfLife < minShelfLife)
                            return false;
                        break;

                    case "MaxShelfLife":
                        if (filter.Value is int maxShelfLife && this.ShelfLife > maxShelfLife)
                            return false;
                        break;
                }
            }
            return true;
        }
    }
}
