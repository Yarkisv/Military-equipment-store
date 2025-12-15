using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEquipmentStore.Models
{
    public class Electronics : Product
    {
        public string DeviceType { get; set; }
        public decimal RangeKm { get; set; }
        public string FrequencyBand { get; set; }
        public decimal PowerKw { get; set; }
        public decimal Weight { get; set; }
        public string ProtectionLevel { get; set; }
        public string PowerSupply { get; set; }

        public static Dictionary<string, Electronics> GetAll()
        {
            var result = new Dictionary<string, Electronics>();
            string query = @"
            SELECT 
                p.product_id,
                p.type,
                p.article,
                p.name_,
                p.price,
                p.description_,
                e.device_type,
                e.range_km,
                e.frequency_band,
                e.power_kw,
                e.weight,
                e.protection_level,
                e.power_supply
            FROM products p
            JOIN electronics e ON p.article = e.article
            WHERE p.type = 'радіоелектроніка';";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader == null) return result;

                while (reader.Read())
                {
                    var item = new Electronics
                    {
                        Type = reader["type"].ToString(),
                        Article = reader["article"].ToString(),
                        Name = reader["name_"].ToString(),
                        Price = reader.GetDecimal("price"),
                        Description = reader["description_"].ToString(),
                        DeviceType = reader["device_type"].ToString(),
                        RangeKm = reader.GetDecimal("range_km"),
                        FrequencyBand = reader["frequency_band"].ToString(),
                        PowerKw = reader.GetDecimal("power_kw"),
                        Weight = reader.GetDecimal("weight"),
                        ProtectionLevel = reader["protection_level"].ToString(),
                        PowerSupply = reader["power_supply"].ToString()
                    };

                    result[item.Article] = item;
                }
            }

            return result;
        }

        public void Update(string article)
        {
            string query = $"update electronics set device_type = '{DeviceType}', range_km = '{RangeKm.ToString(System.Globalization.CultureInfo.InvariantCulture)}', frequency_band = '{FrequencyBand}', power_kw = '{PowerKw.ToString(System.Globalization.CultureInfo.InvariantCulture)}', weight = '{Weight.ToString(System.Globalization.CultureInfo.InvariantCulture)}', protection_level = '{ProtectionLevel}', power_supply = '{PowerSupply}' where article = '{Article}'";

            DbConfig.ExecuteQuery(query);
        }

        public void Insert()
        {
            string query = $@"
                insert into electronics (article, device_type, range_km, frequency_band, power_kw, weight, protection_level, power_supply)
                values ('{Article}', '{DeviceType}', {RangeKm.ToString(System.Globalization.CultureInfo.InvariantCulture)}, '{FrequencyBand}', {PowerKw.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {Weight.ToString(System.Globalization.CultureInfo.InvariantCulture)}, '{ProtectionLevel}', '{PowerSupply}')";

            DbConfig.ExecuteQuery(query);
        }

        public static Electronics GetByArticle(string article)
        {
            string query = $"SELECT * FROM electronics WHERE article = '{article}'";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader != null && reader.Read())
                {
                    return new Electronics
                    {
                        Article = reader["article"].ToString(),
                        DeviceType = reader["device_type"].ToString(),
                        RangeKm = Convert.ToDecimal(reader["range_km"]),
                        FrequencyBand = reader["frequency_band"].ToString(),
                        PowerKw = Convert.ToDecimal(reader["power_kw"]),
                        Weight = Convert.ToDecimal(reader["weight"]),
                        ProtectionLevel = reader["protection_level"].ToString(),
                        PowerSupply = reader["power_supply"].ToString()
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
                    case "DeviceType":
                        if (filter.Value is List<string> deviceTypes && deviceTypes.Any())
                        {
                            if (!deviceTypes.Contains(this.DeviceType))
                                return false;
                        }
                        break;

                    case "MinRange":
                        if (filter.Value is decimal minRange && this.RangeKm < minRange)
                            return false;
                        break;

                    case "MaxRange":
                        if (filter.Value is decimal maxRange && this.RangeKm > maxRange)
                            return false;
                        break;

                    case "FrequencyBand":
                        if (filter.Value is List<string> frequencyBands && frequencyBands.Any())
                        {
                            if (!frequencyBands.Contains(this.FrequencyBand))
                                return false;
                        }
                        break;

                    case "MinPower":
                        if (filter.Value is decimal minPower && this.PowerKw < minPower)
                            return false;
                        break;

                    case "MaxPower":
                        if (filter.Value is decimal maxPower && this.PowerKw > maxPower)
                            return false;
                        break;

                    case "MinWeight":
                        if (filter.Value is decimal minWeight && this.Weight < minWeight)
                            return false;
                        break;

                    case "MaxWeight":
                        if (filter.Value is decimal maxWeight && this.Weight > maxWeight)
                            return false;
                        break;

                    case "ProtectionLevel":
                        if (filter.Value is List<string> protectionLevels && protectionLevels.Any())
                        {
                            if (!protectionLevels.Contains(this.ProtectionLevel))
                                return false;
                        }
                        break;

                    case "PowerSupply":
                        if (filter.Value is List<string> powerSupplies && powerSupplies.Any())
                        {
                            if (!powerSupplies.Contains(this.PowerSupply))
                                return false;
                        }
                        break;
                }
            }
            return true;
        }
    }
}
