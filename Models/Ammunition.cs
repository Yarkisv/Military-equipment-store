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

        public void Update(string article)
        {
            string query = $"update ammunition set caliber = '{Caliber}', ammo_type = '{AmmoType}', weight = '{Weight.ToString(System.Globalization.CultureInfo.InvariantCulture)}', length = '{Length.ToString(System.Globalization.CultureInfo.InvariantCulture)}', explosive_type = '{ExplosiveType}', effective_range = '{EffectiveRange}', storage_temp = '{StorageTemp}', shelf_life = '{ShelfLife}' where article = '{Article}'";

            DbConfig.ExecuteQuery(query);
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
