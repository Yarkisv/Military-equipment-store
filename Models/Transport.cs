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

        public static Dictionary<string, Transport> GetAll()
        {
            var result = new Dictionary<string, Transport>();
            string query = @"
            SELECT
                p.product_id,
                p.type,
                p.article,
                p.name_,
                p.price,
                p.description_,
                t.transport_type,
                t.load_capacity,
                t.max_speed,
                t.fuel_type,
                t.engine_power,
                t.crew,
                t.transmission_type,
                t.weight
            FROM products p
            JOIN transport t ON p.article = t.article
            WHERE p.type = 'транспорт';";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader == null) return result;

                while (reader.Read())
                {
                    var item = new Transport
                    {
                        Type = reader["type"].ToString(),
                        Article = reader["article"].ToString(),
                        Name = reader["name_"].ToString(),
                        Price = reader.GetDecimal("price"),
                        Description = reader["description_"].ToString(),
                        TransportType = reader["transport_type"].ToString(),
                        LoadCapacity = reader.GetDecimal("load_capacity"),
                        MaxSpeed = reader.GetInt32("max_speed"),
                        FuelType = reader["fuel_type"].ToString(),
                        EnginePower = reader.GetInt32("engine_power"),
                        Crew = reader.GetInt32("crew"),
                        TransmissionType = reader["transmission_type"].ToString(),
                        Weight = reader.GetDecimal("weight")
                    };

                    result[item.Article] = item;
                }
            }

            return result;
        }

        public void Update(string article) 
        {
            string query = $"update transport set transport_type = '{TransportType}', load_capacity = '{LoadCapacity.ToString(System.Globalization.CultureInfo.InvariantCulture)}', max_speed = '{MaxSpeed}', fuel_type = '{FuelType}', engine_power = '{EnginePower}', crew = '{Crew}', transmission_type = '{TransmissionType}', weight = '{Weight.ToString(System.Globalization.CultureInfo.InvariantCulture)}' where article = '{Article}'";

            DbConfig.ExecuteQuery(query);
        }

        public void Insert()
        {
            string query = $@"
                    insert into transport (article, transport_type, load_capacity, max_speed, fuel_type, engine_power, crew, transmission_type, weight)
                    values ('{Article}', '{TransportType}', {LoadCapacity.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {MaxSpeed}, '{FuelType}', {EnginePower}, {Crew}, '{TransmissionType}', {Weight.ToString(System.Globalization.CultureInfo.InvariantCulture)})";

            DbConfig.ExecuteQuery(query);
        }

        public static Transport GetByArticle(string article)
        {
            string query = $"SELECT * FROM transport WHERE article = '{article}'";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader != null && reader.Read())
                {
                    return new Transport
                    {
                        Article = reader["article"].ToString(),
                        TransportType = reader["transport_type"].ToString(),
                        LoadCapacity = Convert.ToDecimal(reader["load_capacity"]),
                        MaxSpeed = Convert.ToInt32(reader["max_speed"]),
                        FuelType = reader["fuel_type"].ToString(),
                        EnginePower = Convert.ToInt32(reader["engine_power"]),
                        Crew = Convert.ToInt32(reader["crew"]),
                        TransmissionType = reader["transmission_type"].ToString(),
                        Weight = Convert.ToDecimal(reader["weight"]),
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