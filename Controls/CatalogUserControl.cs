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
using MilitaryEquipmentStore.Controls.Panels;

namespace MilitaryEquipmentStore.Controls
{
    public partial class CatalogUserControl : UserControl
    {
        private string category_;

        private Dictionary<string, Transport> transportList = new Dictionary<string, Transport>();
        private Dictionary<string, Electronics> electronicsList = new Dictionary<string, Electronics>();
        private Dictionary<string, Ammunition> ammunitionList = new Dictionary<string, Ammunition>();

        private Dictionary<string, Product> filteredProducts = new Dictionary<string, Product>();

        public CatalogUserControl(string category)
        {
            InitializeComponent();
            category_ = category;

            this.Load += CatalogUserControl_Load;
        }

        private void CatalogUserControl_Load(object sender, EventArgs e)
        {
            LoadProducts();

            ApplyFilters(new Dictionary<string, object>());
            RenderProducts();

            filtersPanel.Controls.Clear();

            if (category_ == "транспорт")
            {
                TransportFiltersPanelControl1 filtersPanel1 = new TransportFiltersPanelControl1();
                filtersPanel1.Dock = DockStyle.Fill;
                filtersPanel1.FiltersChanged += OnTransportFiltersChanged;
                filtersPanel.Controls.Add(filtersPanel1);
            }
            else if (category_ == "радіоелектроніка")
            {
                ElectronicsFiltersPanelControl1 filtersPanel2 = new ElectronicsFiltersPanelControl1();
                filtersPanel2.FiltersChanged += OnElectronicsFiltersChanged;
                filtersPanel.Controls.Add(filtersPanel2);
            }
            else if (category_ == "боєприпаси")
            {
                AmmunitionFiltersPanelControl1 filtersPanel3 = new AmmunitionFiltersPanelControl1();
                filtersPanel3.Dock = DockStyle.Fill;
                filtersPanel3.FiltersChanged += OnAmmunitionFiltersChanged;
                filtersPanel.Controls.Add(filtersPanel3);
            }
        }

        private void OnTransportFiltersChanged(object sender, FilterEventArgs e)
        {
            ApplyFilters(e.Filters);
            RenderProducts();
        }

        private void OnElectronicsFiltersChanged(object sender, FilterEventArgs e)
        {
            ApplyFilters(e.Filters);
            RenderProducts();
        }

        private void OnAmmunitionFiltersChanged(object sender, FilterEventArgs e)
        {
            ApplyFilters(e.Filters);
            RenderProducts();
        }

        private void LoadProducts()
        {
            if (category_ == "радіоелектроніка")
                electronicsList = Electronics.GetAll();
            else if (category_ == "транспорт")
                transportList = Transport.GetAll();
            else if (category_ == "боєприпаси")
                ammunitionList = Ammunition.GetAll();
        }

        private void ApplyFilters(Dictionary<string, object> filters)
        {
            if (category_ == "транспорт")
            {
                filteredProducts = transportList
                    .Where(kvp => kvp.Value.ApplyFilters(filters))
                    .ToDictionary(kvp => kvp.Key, kvp => (Product)kvp.Value);
            }
            else if (category_ == "радіоелектроніка")
            {
                filteredProducts = electronicsList
                    .Where(kvp => kvp.Value.ApplyFilters(filters))
                    .ToDictionary(kvp => kvp.Key, kvp => (Product)kvp.Value);
            }
            else if (category_ == "боєприпаси")
            {
                filteredProducts = ammunitionList
                    .Where(kvp => kvp.Value.ApplyFilters(filters))
                    .ToDictionary(kvp => kvp.Key, kvp => (Product)kvp.Value);
            }
        }
        private void RenderProducts()
        {
            flowLayoutPanelProducts.Controls.Clear();

            foreach (var item in filteredProducts.Values)
            {
                if (category_ == "транспорт" && item is Transport transport)
                {
                    var card = new ProductCardUserControl(transport);
                    flowLayoutPanelProducts.Controls.Add(card);
                }
                else if (category_ == "радіоелектроніка" && item is Electronics electronics)
                {
                    var card = new ProductCardUserControl(electronics);
                    flowLayoutPanelProducts.Controls.Add(card);
                }
                else if (category_ == "боєприпаси" && item is Ammunition ammunition)
                {
                    var card = new ProductCardUserControl(ammunition);
                    flowLayoutPanelProducts.Controls.Add(card);
                }
            }
        }
    }
}