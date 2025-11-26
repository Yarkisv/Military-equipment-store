using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEquipmentStore.Models
{
    public class Transport : Product
    {
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

        public bool ApplyFilters(Dictionary<string, object> filters) 
        {
            if (!base.ApplyFilters(filters))
                return false;

            foreach (var filter in filters)
            {
                switch (filter.Key)
                {
                    case "TransportType":
                        if (filter.Value is string transportType && !string.IsNullOrEmpty(transportType))
                        {
                            if (transportType != "Всі типи" && this.TransportType != transportType)
                                return false;
                        }
                        break;

                    case "MinLoadCapacity":
                        if (filter.Value is decimal minLoad && this.LoadCapacity < minLoad)
                            return false;
                        break;

                    case "MaxLoadCapacity":
                        if (filter.Value is decimal maxLoad && this.LoadCapacity > maxLoad)
                            return false;
                        break;

                    case "MinMaxSpeed":
                        if (filter.Value is int minSpeed && this.MaxSpeed < minSpeed)
                            return false;
                        break;

                    case "MaxMaxSpeed":
                        if (filter.Value is int maxSpeed && this.MaxSpeed > maxSpeed)
                            return false;
                        break;

                    case "FuelType":
                        if (filter.Value is List<string> fuelTypes && fuelTypes.Any())
                        {
                            if (!fuelTypes.Contains(this.FuelType))
                                return false;
                        }
                        break;

                    case "MinEnginePower":
                        if (filter.Value is int minPower && this.EnginePower < minPower)
                            return false;
                        break;

                    case "MaxEnginePower":
                        if (filter.Value is int maxPower && this.EnginePower > maxPower)
                            return false;
                        break;

                    case "MinCrew":
                        if (filter.Value is int minCrew && this.Crew < minCrew)
                            return false;
                        break;

                    case "MaxCrew":
                        if (filter.Value is int maxCrew && this.Crew > maxCrew)
                            return false;
                        break;

                    case "TransmissionType":
                        if (filter.Value is List<string> transmissionTypes && transmissionTypes.Any())
                        {
                            if (!transmissionTypes.Contains(this.TransmissionType))
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
                }
            }
            return true;
        }
    }
}