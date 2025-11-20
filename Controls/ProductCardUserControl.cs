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
    public partial class ProductCardUserControl : UserControl
    {
        public ProductCardUserControl()
        {
            InitializeComponent();
        }

        public ProductCardUserControl(Electronics e) : this()
        {
            labelTitle.Text = $"{e.Article} — {e.DeviceType}";
            labelSpecs.Text = $"Дальність: {e.RangeKm} км\n" + $"Потужність: {e.PowerKw} кВт\n" + $"Вага: {e.Weight} кг";
        }

        public ProductCardUserControl(Transport t) : this()
        {
            labelTitle.Text = $"{t.Article} — {t.TransportType}";
            labelSpecs.Text = $"Макс. швидкість: {t.MaxSpeed} км/г\n" + $"Потужність двигуна: {t.EnginePower} л.с.\n" + $"Вантажопід.: {t.LoadCapacity} т";
        }

        public ProductCardUserControl(Ammunition a) : this()
        {
            labelTitle.Text = $"{a.Article} — {a.AmmoType}";
            labelSpecs.Text = $"Калібр: {a.Caliber}\n" + $"Вага: {a.Weight} кг\n" + $"Дальність: {a.EffectiveRange} м";
        }
    }
}
