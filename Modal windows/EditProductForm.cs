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
                        textBox6.Text = reader["frequency_band"].ToString();
                        textBox7.Text = reader["power_kw"].ToString();
                        textBox8.Text = reader["weight"].ToString();
                        textBox9.Text = reader["protection_level"].ToString();
                        textBox17.Text = reader["power_supply"].ToString();
                    }
                }
            }
            else if (_type == "транспорт")
            {
                transportFormPanel.Visible = true;

                string query = $"select * from transport where article = {_article}";

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
                    }
                }
            }
            else if (_type == "амуніція")
            {
                string query = $"select * from ammunition where article = {_article}";
            }
        }
    }
}
