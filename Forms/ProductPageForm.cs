using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MilitaryEquipmentStore.Models;

namespace MilitaryEquipmentStore.Forms
{
    public partial class ProductPageForm : Form
    {
        private string productArticle;

        public ProductPageForm(string article)
        {
            InitializeComponent();
            productArticle = article;
            LoadProductData();
        }

        private void LoadProductData()
        {
            try
            {
                if (DbConfig.connection.State == System.Data.ConnectionState.Open)
                {
                    DbConfig.Close();
                }

                string productQuery = $@"
                    select p.* 
                    from products p 
                    where p.article = '{productArticle}'";

                using (var reader = DbConfig.ReadData(productQuery))
                {
                    if (reader != null && reader.Read())
                    {
                        Text = reader["name_"].ToString();
                        lblTitle.Text = reader["name_"].ToString();
                        lblArticle.Text = $"Артикул: {reader["article"]}";

                        string type = reader["type"].ToString();
                        lblType.Text = $"Категорія: {type}";

                        lblPrice.Text = reader["price"] != DBNull.Value ? $"{reader.GetDecimal("price"):N2} грн" : "Ціна не вказана";

                        txtDescription.Text = reader["description_"] != DBNull.Value ? reader["description_"].ToString() : "Опис відсутній";

                        reader.Close();
                        DbConfig.Close();

                        LoadSpecificDetails(type);
                    }
                    else
                    {
                        MessageBox.Show("Товар не знайдено", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSpecificDetails(string type)
        {
            string details = "";
            string query = "";

            if (type == "радіоелектроніка")
            {
                query = $@"
                    select 
                        e.device_type,
                        e.range_km,
                        e.frequency_band,
                        e.power_kw,
                        e.weight,
                        e.protection_level,
                        e.power_supply
                    from electronics e
                    where e.article = '{productArticle}'";
            }
            else if (type == "транспорт")
            {
                query = $@"
                    select 
                        t.transport_type,
                        t.load_capacity,
                        t.max_speed,
                        t.fuel_type,
                        t.engine_power,
                        t.crew,
                        t.transmission_type,
                        t.weight
                    from transport t
                    where t.article = '{productArticle}'";
            }
            else if (type == "боєприпаси")
            {
                query = $@"
                    select 
                        a.caliber,
                        a.ammo_type,
                        a.weight,
                        a.length,
                        a.explosive_type,
                        a.effective_range,
                        a.storage_temp,
                        a.shelf_life
                    from ammunition a
                    where a.article = '{productArticle}'";
            }

            if (!string.IsNullOrEmpty(query))
            {
                using (var reader = DbConfig.ReadData(query))
                {
                    if (reader != null && reader.Read())
                    {
                        if (type == "радіоелектроніка")
                        {
                            details = $@"Тип пристрою: {reader["device_type"]}
Дальність: {reader["range_km"]} км
Частотний діапазон: {reader["frequency_band"]}
Потужність: {reader["power_kw"]} кВт
Вага: {reader["weight"]} кг
Рівень захисту: {reader["protection_level"]}
Тип живлення: {reader["power_supply"]}";
                        }
                        else if (type == "транспорт")
                        {
                            details = $@"Тип транспорту: {reader["transport_type"]}
Вантажопідйомність: {reader["load_capacity"]} т
Макс. швидкість: {reader["max_speed"]} км/год
Тип палива: {reader["fuel_type"]}
Потужність двигуна: {reader["engine_power"]} л.с.
Екіпаж: {reader["crew"]} осіб
Тип трансмісії: {reader["transmission_type"]}
Вага: {reader["weight"]} т";
                        }
                        else if (type == "боєприпаси")
                        {
                            details = $@"Тип боєприпасу: {reader["ammo_type"]}
Калібр: {reader["caliber"]}
Вага: {reader["weight"]} кг
Довжина: {reader["length"]} мм
Тип вибухової речовини: {reader["explosive_type"]}
Ефективна дальність: {reader["effective_range"]} м
Температура зберігання: {reader["storage_temp"]}
Термін придатності: {reader["shelf_life"]} років";
                        }
                    }
                }
            }
             
            txtDetails.Text = details;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                string article = lblArticle.Text.Replace("Артикул: ", "").Trim();

                int productId = Product.GetProductId(article);

                if (productId <= 0)
                {
                    MessageBox.Show("Не вдалося знайти товар в базі даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string priceText = lblPrice.Text.Replace(" грн", "").Trim();

                if (decimal.TryParse(priceText, out decimal price))
                {
                    Order.addItemToOrder(productId, article, price);

                    MessageBox.Show($"Товар додано до кошика!\nВ кошику: {Order.GetItemCount()} товарів\nЗагальна сума: {Order.GetTotalPrice():N2} грн", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Помилка: {exception.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            MessageBox.Show($"Товар \"{lblTitle.Text}\" додано до кошика!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
