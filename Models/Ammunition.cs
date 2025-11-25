using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryEquipmentStore.Models
{
    public class Ammunition
    {
        public string Article { get; set; }
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
    }
}
