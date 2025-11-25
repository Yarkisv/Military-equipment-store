using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryEquipmentStore.Models;

namespace MilitaryEquipmentStore.Controls
{
    public partial class CatalogUserControl : UserControl
    {
        private string category_;
        private Dictionary<string, Electronics> electronicsList = new Dictionary<string, Electronics>();
        private Dictionary<string, Transport> transportList = new Dictionary<string, Transport>();
        private Dictionary<string, Ammunition> ammunitionList = new Dictionary<string, Ammunition>();

        public CatalogUserControl(string category)
        {
            InitializeComponent();
            category_ = category;

            this.Load += CatalogUserControl_Load;
        }

        private void CatalogUserControl_Load(object sender, EventArgs e)
        {
            LoadProducts();
            RenderProducts();
        }

        private void LoadProducts()
        {
            string query = "";

            if (category_ == "радіоелектроніка") query = @"
                select 
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
                from products p
                join electronics e on p.article = e.article
                where p.type = 'радіоелектроніка';";
            else if (category_ == "транспорт") query = @"
                select 
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
                from products p
                join transport t on p.article = t.article
                where p.type = 'транспорт';";
            else if (category_ == "боєприпаси") query = @"
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
                if (reader == null) return;

                while (reader.Read())
                {
                    if (category_ == "радіоелектроніка")
                    {
                        var item = new Electronics
                        {
                            Article = reader["article"].ToString(),
                            DeviceType = reader["device_type"].ToString(),
                            RangeKm = reader.GetDecimal("range_km"),
                            FrequencyBand = reader["frequency_band"].ToString(),
                            PowerKw = reader.GetDecimal("power_kw"),
                            Weight = reader.GetDecimal("weight"),
                            ProtectionLevel = reader["protection_level"].ToString(),
                            PowerSupply = reader["power_supply"].ToString()
                        };

                        electronicsList[item.Article] = item;
                    }
                    else if (category_ == "транспорт")
                    {
                        var item = new Transport
                        {
                            Article = reader["article"].ToString(),
                            TransportType = reader["transport_type"].ToString(),
                            LoadCapacity = reader.GetDecimal("load_capacity"),
                            MaxSpeed = reader.GetInt32("max_speed"),
                            FuelType = reader["fuel_type"].ToString(),
                            EnginePower = reader.GetInt32("engine_power"),
                            Crew = reader.GetInt32("crew"),
                            TransmissionType = reader["transmission_type"].ToString(),
                            Weight = reader.GetDecimal("weight")
                        };

                        transportList[item.Article] = item;
                    }
                    else if (category_ == "боєприпаси")
                    {
                        var item = new Ammunition
                        {
                            Article = reader["article"].ToString(),
                            Caliber = reader["caliber"].ToString(),
                            AmmoType = reader["ammo_type"].ToString(),
                            Weight = reader.GetDecimal("weight"),
                            Length = reader.GetDecimal("length"),
                            ExplosiveType = reader["explosive_type"].ToString(),
                            EffectiveRange = reader.GetInt32("effective_range"),
                            StorageTemp = reader["storage_temp"].ToString(),
                            ShelfLife = reader.GetInt32("shelf_life")
                        };

                        ammunitionList[item.Article] = item;
                    }
                }
            }
        }

        private void RenderProducts()
        {
            flowLayoutPanelProducts.Controls.Clear();

            if (category_ == "радіоелектроніка")
            {
                foreach (var item in electronicsList.Values) 
                {
                    flowLayoutPanelProducts.Controls.Add(new ProductCardUserControl(item));
                }       
            }
            else if (category_ == "транспорт")
            {
                foreach (var item in transportList.Values)
                {
                    flowLayoutPanelProducts.Controls.Add(new ProductCardUserControl(item));
                }
                    
            }
            else if (category_ == "боєприпаси")
            {
                foreach (var item in ammunitionList.Values)
                {
                    flowLayoutPanelProducts.Controls.Add(new ProductCardUserControl(item));
                }
            }
        }
    }
}
