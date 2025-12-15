using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryEquipmentStore.Controls.Panels.CategoryEditPanels;
using MilitaryEquipmentStore.Models;

namespace MilitaryEquipmentStore.Modal_windows
{
    public partial class EditProductForm : Form
    {
        private string _article;
        private string _type;
        private UserControl _currentCategoryControl;

        public EditProductForm(string article)
        {
            _article = article;
            InitializeComponent();

            LoadMainProductData();
            LoadCategoryData();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadMainProductData()
        {
            Product product = Product.GetByArticle(_article);
            if (product != null)
            {
                textBox1.Text = product.Article;
                textBox2.Text = product.Name;
                textBox3.Text = product.Price.ToString();
                textBox4.Text = product.Description;
                _type = product.Type;
            }
        }

        private void LoadCategoryData()
        {
            if (_currentCategoryControl != null)
            {
                otherPanel.Controls.Remove(_currentCategoryControl);
                _currentCategoryControl.Dispose();
            }

            if (_type == "транспорт")
            {
                var transportControl = new TransportPanel();
                transportControl.Dock = DockStyle.Fill;
                otherPanel.Controls.Add(transportControl);
                _currentCategoryControl = transportControl;

                Transport transport = Transport.GetByArticle(_article);
                if (transport != null)
                {
                    transportControl.txtLoadCapacity.Text = transport.LoadCapacity.ToString();
                    transportControl.txtMaxSpeed.Text = transport.MaxSpeed.ToString();
                    transportControl.txtFuelType.Text = transport.FuelType;
                    transportControl.txtEnginePower.Text = transport.EnginePower.ToString();
                    transportControl.txtCrew.Text = transport.Crew.ToString();
                    transportControl.txtTransmissionType.Text = transport.TransmissionType;
                    transportControl.txtWeight.Text = transport.Weight.ToString();
                    transportControl.cmbTransportType.SelectedItem = transport.TransportType;
                }
            }

            if (_type == "радіоелектроніка")
            {
                var electronicsControl = new ElectronicsPanel();
                electronicsControl.Dock = DockStyle.Fill;
                otherPanel.Controls.Add(electronicsControl);
                _currentCategoryControl = electronicsControl;

                Electronics electronics = Electronics.GetByArticle(_article);
                if (electronics != null)
                {
                    electronicsControl.txtRange.Text = electronics.RangeKm.ToString();
                    electronicsControl.txtPower.Text = electronics.PowerKw.ToString();
                    electronicsControl.txtWeight.Text = electronics.Weight.ToString();
                    electronicsControl.txtProtectionLevel.Text = electronics.ProtectionLevel;
                    electronicsControl.txtPowerSupply.Text = electronics.PowerSupply;
                    electronicsControl.cmbFrequencyBand.SelectedItem = electronics.FrequencyBand;
                    electronicsControl.cmbDeviceType.SelectedItem = electronics.DeviceType;
                }
            }

            if (_type == "боєприпаси")
            {
                var ammoControl = new AmmunitionPanel();
                ammoControl.Dock = DockStyle.Fill;
                otherPanel.Controls.Add(ammoControl);
                _currentCategoryControl = ammoControl;

                Ammunition ammo = Ammunition.GetByArticle(_article);
                if (ammo != null)
                {
                    ammoControl.txtCaliber.Text = ammo.Caliber;
                    ammoControl.txtWeight.Text = ammo.Weight.ToString();
                    ammoControl.txtLength.Text = ammo.Length.ToString();
                    ammoControl.txtEffectiveRange.Text = ammo.EffectiveRange.ToString();
                    ammoControl.txtStorageTemp.Text = ammo.StorageTemp;
                    ammoControl.txtShelfLife.Text = ammo.ShelfLife.ToString();
                    ammoControl.cmbAmmoType.SelectedItem = ammo.AmmoType;
                    ammoControl.cmbExplosiveType.SelectedItem = ammo.ExplosiveType;
                }
            }
        }

        private void UpdateProduct()
        {
            Product product = new Product
            {
                Article = textBox1.Text,
                Name = textBox2.Text,
                Price = decimal.TryParse(textBox3.Text, out var price) ? price : 0,
                Description = textBox4.Text
            };

            product.Update();
        }

        private void UpdateTransport()
        {
            if (_currentCategoryControl is TransportPanel transportControl)
            {
                Transport transport = new Transport
                {
                    Article = textBox1.Text,
                    TransportType = transportControl.cmbTransportType.SelectedItem?.ToString(),
                    LoadCapacity = decimal.TryParse(transportControl.txtLoadCapacity.Text, out var load) ? load : 0,
                    MaxSpeed = int.TryParse(transportControl.txtMaxSpeed.Text, out var speed) ? speed : 0,
                    FuelType = transportControl.txtFuelType.Text,
                    EnginePower = int.TryParse(transportControl.txtEnginePower.Text, out var power) ? power : 0,
                    Crew = int.TryParse(transportControl.txtCrew.Text, out var crew) ? crew : 0,
                    TransmissionType = transportControl.txtTransmissionType.Text,
                    Weight = decimal.TryParse(transportControl.txtWeight.Text, out var weight) ? weight : 0
                };

                transport.Update(_article);
            }
        }

        private void UpdateElectronics()
        {
            if (_currentCategoryControl is ElectronicsPanel electronicsControl)
            {
                Electronics electronics = new Electronics
                {
                    Article = textBox1.Text,
                    DeviceType = electronicsControl.cmbDeviceType.SelectedItem?.ToString(),
                    RangeKm = decimal.TryParse(electronicsControl.txtRange.Text, out var range) ? range : 0,
                    FrequencyBand = electronicsControl.cmbFrequencyBand.SelectedItem?.ToString(),
                    PowerKw = decimal.TryParse(electronicsControl.txtPower.Text, out var power) ? power : 0,
                    Weight = decimal.TryParse(electronicsControl.txtWeight.Text, out var weight) ? weight : 0,
                    ProtectionLevel = electronicsControl.txtProtectionLevel.Text,
                    PowerSupply = electronicsControl.txtPowerSupply.Text
                };

                electronics.Update(_article);
            }
        }

        private void UpdateAmmunition()
        {
            if (_currentCategoryControl is AmmunitionPanel ammoControl)
            {
                Ammunition ammunition = new Ammunition
                {
                    Article = textBox1.Text,
                    Caliber = ammoControl.txtCaliber.Text,
                    AmmoType = ammoControl.cmbAmmoType.SelectedItem?.ToString(),
                    Weight = decimal.TryParse(ammoControl.txtWeight.Text, out var weight) ? weight : 0,
                    Length = decimal.TryParse(ammoControl.txtLength.Text, out var length) ? length : 0,
                    ExplosiveType = ammoControl.cmbExplosiveType.SelectedItem?.ToString(),
                    EffectiveRange = int.TryParse(ammoControl.txtEffectiveRange.Text, out var range) ? range : 0,
                    StorageTemp = ammoControl.txtStorageTemp.Text,
                    ShelfLife = int.TryParse(ammoControl.txtShelfLife.Text, out var shelf) ? shelf : 0
                };

                ammunition.Update(_article);
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateProduct();

                if (_type == "транспорт")
                {
                    UpdateTransport();
                }
                else if (_type == "радіоелектроніка")
                {
                    UpdateElectronics();
                }
                else if (_type == "боєприпаси")
                {
                    UpdateAmmunition();
                }

                MessageBox.Show("Data has been successfyly updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during updating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
