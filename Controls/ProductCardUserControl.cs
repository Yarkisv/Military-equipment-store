using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryEquipmentStore.Forms;
using MilitaryEquipmentStore.Models;

namespace MilitaryEquipmentStore.Controls
{
    public partial class ProductCardUserControl : UserControl
    {
        public string ProductArticle { get; set; }

        public ProductCardUserControl()
        {
            InitializeComponent();
            this.Click += (s, e) => OnClick();
            labelTitle.Click += (s, e) => OnClick();
            labelSpecs.Click += (s, e) => OnClick();
        }

        public ProductCardUserControl(Electronics e) : this()
        {
            ProductArticle = e.Article;
            labelTitle.Text = $"{e.Article} — {e.DeviceType}";
            labelSpecs.Text = $"Дальність: {e.RangeKm} км\nПотужність: {e.PowerKw} кВт\nВага: {e.Weight} кг";
        }

        public ProductCardUserControl(Transport t) : this()
        {
            ProductArticle = t.Article;
            labelTitle.Text = $"{t.Article} — {t.TransportType}";
            labelSpecs.Text = $"Макс. швидкість: {t.MaxSpeed} км/г\nПотужність двигуна: {t.EnginePower} л.с.\nВантажопід.: {t.LoadCapacity} т";
        }

        public ProductCardUserControl(Ammunition a) : this()
        {
            ProductArticle = a.Article;
            labelTitle.Text = $"{a.Article} — {a.AmmoType}";
            labelSpecs.Text = $"Калібр: {a.Caliber}\nВага: {a.Weight} кг\nДальність: {a.EffectiveRange} м";
        }

        private void OnClick()
        {
            if (!string.IsNullOrEmpty(ProductArticle))
            {
                var form = new ProductPageForm(ProductArticle);
                form.Show();
            }
        }
    }
}
