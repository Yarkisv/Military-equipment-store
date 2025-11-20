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
    }
}
