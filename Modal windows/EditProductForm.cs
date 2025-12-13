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
            string query = $"select type, article, name_, price, description_ from products where article = '{_article}'";

            using (var reader = DbConfig.ReadData(query))
            {
                if (reader.Read())
                {
                    textBox1.Text = reader["article"].ToString();
                    textBox2.Text = reader["name_"].ToString();
                    textBox3.Text = reader["price"].ToString();
                    textBox4.Text = reader["description_"].ToString();

                    _type = reader["type"].ToString();
                }
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

                string query = $"select * from transport where article = '{_article}'";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader.Read())
                    {
                        transportControl.txtLoadCapacity.Text = reader["load_capacity"].ToString();
                        transportControl.txtMaxSpeed.Text = reader["max_speed"].ToString();
                        transportControl.txtFuelType.Text = reader["fuel_type"].ToString();
                        transportControl.txtEnginePower.Text = reader["engine_power"].ToString();
                        transportControl.txtCrew.Text = reader["crew"].ToString();
                        transportControl.txtTransmissionType.Text = reader["transmission_type"].ToString();
                        transportControl.txtWeight.Text = reader["weight"].ToString();
                        transportControl.cmbTransportType.SelectedItem = reader["transport_type"].ToString();
                    }
                }
            }

            if (_type == "радіоелектроніка")
            {
                var electronicsControl = new ElectronicsPanel();
                electronicsControl.Dock = DockStyle.Fill;
                otherPanel.Controls.Add(electronicsControl);
                _currentCategoryControl = electronicsControl;

                string query = $"select * from electronics where article = '{_article}'";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader.Read())
                    {
                        electronicsControl.txtRange.Text = reader["range_km"].ToString();
                        electronicsControl.txtPower.Text = reader["power_kw"].ToString();
                        electronicsControl.txtWeight.Text = reader["weight"].ToString();
                        electronicsControl.txtProtectionLevel.Text = reader["protection_level"].ToString();
                        electronicsControl.txtPowerSupply.Text = reader["power_supply"].ToString();
                        electronicsControl.cmbFrequencyBand.SelectedItem = reader["frequency_band"].ToString();
                        electronicsControl.cmbDeviceType.SelectedItem = reader["device_type"].ToString();
                    }
                }
            }

            else if (_type == "боєприпаси")
            {
                var ammoControl = new AmmunitionPanel();
                ammoControl.Dock = DockStyle.Fill;
                otherPanel.Controls.Add(ammoControl);
                _currentCategoryControl = ammoControl;

                string query = $"select * from ammunition where article = '{_article}'";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader.Read())
                    {
                        ammoControl.txtCaliber.Text = reader["caliber"].ToString();
                        ammoControl.txtWeight.Text = reader["weight"].ToString();
                        ammoControl.txtLength.Text = reader["length"].ToString();
                        ammoControl.txtEffectiveRange.Text = reader["effective_range"].ToString();
                        ammoControl.txtStorageTemp.Text = reader["storage_temp"].ToString();
                        ammoControl.txtShelfLife.Text = reader["shelf_life"].ToString();
                        ammoControl.cmbAmmoType.SelectedItem = reader["ammo_type"].ToString();
                        ammoControl.cmbExplosiveType.SelectedItem = reader["explosive_type"].ToString();
                    }
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
