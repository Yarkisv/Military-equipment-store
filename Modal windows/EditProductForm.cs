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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MilitaryEquipmentStore.Modal_windows
{
    public partial class EditProductForm : Form
    {
        private string _article;
        private string _type;

        public EditProductForm(string article)
        {
            _article = article;
            InitializeComponent();

            transportFormPanel.Visible = false;
            electronicPanel.Visible = false;
            ammoPanel.Visible = false;

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
            if (_type == "радіоелектроніка")
            {
                electronicPanel.Visible = true;

                string query = $"select * from electronics where article = '{_article}'";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader.Read())
                    {
                        textBox5.Text = reader["range_km"].ToString();
                        textBox7.Text = reader["power_kw"].ToString();
                        textBox8.Text = reader["weight"].ToString();
                        textBox9.Text = reader["protection_level"].ToString();
                        textBox17.Text = reader["power_supply"].ToString();

                        comboBox5.SelectedItem = reader["frequency_band"].ToString();
                    }
                }
            }
            else if (_type == "транспорт")
            {
                transportFormPanel.Visible = true;

                string query = $"select * from transport where article = '{_article}'";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader.Read())
                    {
                        textBox10.Text = reader["load_capacity"].ToString();
                        textBox11.Text = reader["max_speed"].ToString();
                        textBox12.Text = reader["fuel_type"].ToString();
                        textBox13.Text = reader["engine_power"].ToString();
                        textBox14.Text = reader["crew"].ToString();
                        textBox15.Text = reader["transmission_type"].ToString();
                        textBox16.Text = reader["weight"].ToString();

                        comboBox2.SelectedItem = reader["transport_type"].ToString();
                    }
                }
            }
            else if (_type == "боєприпаси")
            {
                ammoPanel.Visible = true;

                string query = $"select * from ammunition where article = '{_article}'";

                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader.Read())
                    {
                        textBox18.Text = reader["caliber"].ToString();
                        textBox19.Text = reader["weight"].ToString();
                        textBox20.Text = reader["length"].ToString();
                        textBox21.Text = reader["effective_range"].ToString();
                        textBox22.Text = reader["storage_temp"].ToString();
                        textBox23.Text = reader["shelf_life"].ToString();

                        comboBox3.SelectedItem = reader["ammo_type"].ToString();
                        comboBox4.SelectedItem = reader["explosive_type"].ToString();
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
            Transport transport = new Transport
            {
                Article = textBox1.Text,
                TransportType = comboBox2.SelectedItem.ToString(),
                LoadCapacity = decimal.TryParse(textBox10.Text, out var load) ? load : 0,
                MaxSpeed = int.TryParse(textBox11.Text, out var speed) ? speed : 0,
                FuelType = textBox12.Text,
                EnginePower = int.TryParse(textBox13.Text, out var power) ? power : 0,
                Crew = int.TryParse(textBox14.Text, out var crew) ? crew : 0,
                TransmissionType = textBox15.Text,
                Weight = decimal.TryParse(textBox16.Text, out var weight) ? weight : 0
            };

            transport.Update(_article);
        }

        private void UpdateElectronics()
        {
            Electronics electronics = new Electronics
            {
                Article = textBox1.Text,
                DeviceType = comboBox1.SelectedItem.ToString(),
                RangeKm = decimal.TryParse(textBox5.Text, out var range) ? range : 0,
                FrequencyBand = comboBox5.SelectedItem.ToString(),
                PowerKw = decimal.TryParse(textBox7.Text, out var power) ? power : 0,
                Weight = decimal.TryParse(textBox8.Text, out var weight) ? weight : 0,
                ProtectionLevel = textBox9.Text,
                PowerSupply = textBox17.Text
            };

            electronics.Update(_article);
        }

        private void UpdateAmmunition()
        {
            Ammunition ammunition = new Ammunition
            {
                Article = textBox1.Text,
                Caliber = textBox18.Text,
                AmmoType = comboBox3.SelectedItem.ToString(),
                Weight = decimal.TryParse(textBox19.Text, out var weight) ? weight : 0,
                Length = decimal.TryParse(textBox20.Text, out var length) ? length : 0,
                ExplosiveType = comboBox4.SelectedItem.ToString(),
                EffectiveRange = int.TryParse(textBox21.Text, out var range) ? range : 0,
                StorageTemp = textBox22.Text,
                ShelfLife = int.TryParse(textBox23.Text, out var shelf) ? shelf : 0
            };

            ammunition.Update(_article);
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
