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
        public string TransmissionType { get; set; }
        public decimal Weight { get; set; }

        public void Update(string article) 
        {
            string query = $"update transport set transport_type = '{TransportType}', load_capacity = '{LoadCapacity.ToString(System.Globalization.CultureInfo.InvariantCulture)}', max_speed = '{MaxSpeed}', fuel_type = '{FuelType}', engine_power = '{EnginePower}', crew = '{Crew}', transmission_type = '{TransmissionType}', weight = '{Weight.ToString(System.Globalization.CultureInfo.InvariantCulture)}' where article = '{Article}'";

            DbConfig.ExecuteQuery(query);
        }
    }
}