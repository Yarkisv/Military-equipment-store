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
        public string Dimensions { get; set; }
        public string OperatingTemp { get; set; }
        public string ProtectionLevel { get; set; }
        public string PowerSupply { get; set; }
    }
}
