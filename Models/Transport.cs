using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEquipmentStore.Models
{
    public class Transport
    {
        public string Article { get; set; }
        public string TransportType { get; set; }
        public decimal LoadCapacity { get; set; }
        public int MaxSpeed { get; set; }
        public string FuelType { get; set; }
        public int EnginePower { get; set; }
        public int Crew { get; set; }
        public int RangeKm { get; set; }
        public string TransmissionType { get; set; }
        public decimal Weight { get; set; }
    }
}
