using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEquipmentStore.Models
{
    public class Electronics
    {
        public string Article { get; set; }
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
    }
}
