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

        public void Update(string article)
        {
            string query = $"update electronics set device_type = '{DeviceType}', range_km = '{RangeKm.ToString(System.Globalization.CultureInfo.InvariantCulture)}', frequency_band = '{FrequencyBand}', power_kw = '{PowerKw.ToString(System.Globalization.CultureInfo.InvariantCulture)}', weight = '{Weight.ToString(System.Globalization.CultureInfo.InvariantCulture)}', protection_level = '{ProtectionLevel}', power_supply = '{PowerSupply}' where article = '{Article}'";

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
