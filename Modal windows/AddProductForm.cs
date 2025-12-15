using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryEquipmentStore.Models;

namespace MilitaryEquipmentStore.Modal_windows
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();

            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArticle.Text))
            {
                MessageBox.Show("Введіть артикул товару", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtArticle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введіть назву товару", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Виберіть категорію товару", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbCategory.Focus();
                return;
            }

            if (ValidateInput())
            {
                AddProduct();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtArticle.Text))
            {
                MessageBox.Show("Введіть артикул товару", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtArticle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введіть назву товару", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Введіть коректну ціну", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return false;
            }

            if (cbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть категорію товару", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string category = cbCategory.SelectedItem.ToString();

            switch (category)
            {
                case "радіоелектроніка":
                    if (cbDeviceType.SelectedIndex == -1)
                    {
                        MessageBox.Show("Виберіть тип пристрою", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabControlCategories.SelectedTab = tabPageElectronics;
                        return false;
                    }
                    break;

                case "транспорт":
                    if (cbTransportType.SelectedIndex == -1)
                    {
                        MessageBox.Show("Виберіть тип транспорту", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabControlCategories.SelectedTab = tabPageTransport;
                        return false;
                    }
                    break;

                case "боєприпаси":
                    if (string.IsNullOrWhiteSpace(txtCaliber.Text))
                    {
                        MessageBox.Show("Введіть калібр", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tabControlCategories.SelectedTab = tabPageAmmunition;
                        txtCaliber.Focus();
                        return false;
                    }
                    break;
            }

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedItem != null)
            {
                tabControlCategories.Visible = true;

                switch (cbCategory.SelectedItem.ToString())
                {
                    case "радіоелектроніка":
                        tabControlCategories.SelectedTab = tabPageElectronics;
                        break;
                    case "транспорт":
                        tabControlCategories.SelectedTab = tabPageTransport;
                        break;
                    case "боєприпаси":
                        tabControlCategories.SelectedTab = tabPageAmmunition;
                        break;
                }
            }
            else
            {
                tabControlCategories.Visible = false;
            }
        }
        private void AddProduct()
        {
            Product product = new Product
            {
                Type = cbCategory.SelectedItem.ToString(),
                Article = txtArticle.Text.Trim(),
                Name = txtName.Text.Trim(),
                Price = decimal.Parse(txtPrice.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture),
                Description = txtDescription.Text.Trim()
            };

            product.Insert();

            switch (product.Type)
            {
                case "радіоелектроніка":
                    AddElectronics(product.Article);
                    break;

                case "транспорт":
                    AddTransport(product.Article);
                    break;

                case "боєприпаси":
                    AddAmmunition(product.Article);
                    break;
            }
        }


        private void AddElectronics(string article)
        {
            Electronics electronics = new Electronics
            {
                Article = article,
                DeviceType = cbDeviceType.SelectedItem?.ToString(),
                FrequencyBand = cbFrequencyBand.SelectedItem?.ToString(),
                ProtectionLevel = cbProtectionLevel.SelectedItem?.ToString(),
                PowerSupply = cbPowerSupply.SelectedItem?.ToString(),
                RangeKm = decimal.Parse(txtRangeKm.Text, CultureInfo.InvariantCulture),
                PowerKw = decimal.Parse(txtPowerKw.Text, CultureInfo.InvariantCulture),
                Weight = decimal.Parse(txtWeightElectronics.Text, CultureInfo.InvariantCulture)
            };

            electronics.Insert();
        }

        private void AddTransport(string article)
        {
            Transport transport = new Transport
            {
                Article = article,
                TransportType = cbTransportType.SelectedItem.ToString(),
                LoadCapacity = decimal.Parse(txtLoadCapacity.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture),
                MaxSpeed = int.Parse(txtMaxSpeed.Text),
                FuelType = cbFuelType.SelectedItem.ToString(),
                EnginePower = int.Parse(txtEnginePower.Text),
                Crew = int.Parse(txtCrew.Text),
                TransmissionType = cbTransmissionType.SelectedItem.ToString(),
                Weight = decimal.Parse(txtWeightTransport.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture)
            };

            transport.Insert();
        }

        private void AddAmmunition(string article)
        {
            Ammunition ammo = new Ammunition
            {
                Article = article,
                Caliber = txtCaliber.Text.Trim(),
                AmmoType = cbAmmoType.SelectedItem.ToString(),
                Weight = decimal.Parse(txtWeightAmmo.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture),
                Length = decimal.Parse(txtLength.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture),
                ExplosiveType = cbExplosiveType.SelectedItem.ToString(),
                EffectiveRange = int.Parse(txtEffectiveRange.Text),
                StorageTemp = txtStorageTemp.Text.Trim(),
                ShelfLife = int.Parse(txtShelfLife.Text)
            };

            ammo.Insert();
        }
    }
}
