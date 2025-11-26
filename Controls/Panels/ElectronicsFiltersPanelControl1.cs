using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryEquipmentStore.Controls.Panels
{
    public partial class ElectronicsFiltersPanelControl1 : UserControl
    {
        public event EventHandler<FilterEventArgs> FiltersChanged;

        public ElectronicsFiltersPanelControl1()
        {
            InitializeComponent();
        }

        private void btnApplyFilters_Click(object sender, EventArgs e)
        {
            var filters = GetCurrentFilters();
            FiltersChanged?.Invoke(this, new FilterEventArgs(filters));
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            ResetAllFilters();
            var filters = new Dictionary<string, object>();
            FiltersChanged?.Invoke(this, new FilterEventArgs(filters));
        }

        private void ResetAllFilters()
        {
            foreach (var checkBox in GetAllCheckBoxes())
            {
                if (checkBox != chkAllDeviceTypes && checkBox != chkAllFrequencies && checkBox != chkAllProtection && checkBox != chkAllPowerSupply) checkBox.Checked = false;
            }

            chkAllDeviceTypes.Checked = true;
            chkAllFrequencies.Checked = true;
            chkAllProtection.Checked = true;
            chkAllPowerSupply.Checked = true;

            foreach (var textBox in GetAllTextBoxes())
            {
                textBox.Text = "";
            }
        }

        public Dictionary<string, object> GetCurrentFilters()
        {
            var filters = new Dictionary<string, object>();

            var deviceTypes = new List<string>();
            if (chkRadar.Checked) deviceTypes.Add("Радар");
            if (chkRadio.Checked) deviceTypes.Add("Радіостанція");
            if (chkThermal.Checked) deviceTypes.Add("Тепловізор");
            if (chkOtherDevice.Checked) deviceTypes.Add("Інший");
            if (deviceTypes.Any()) filters["DeviceType"] = deviceTypes;

            if (decimal.TryParse(txtMinRange.Text, out decimal minRange)) filters["MinRange"] = minRange;
            if (decimal.TryParse(txtMaxRange.Text, out decimal maxRange)) filters["MaxRange"] = maxRange;

            var frequencyBands = new List<string>();
            if (chkVHF.Checked) frequencyBands.Add("VHF");
            if (chkUHF.Checked) frequencyBands.Add("UHF");
            if (chkHF.Checked) frequencyBands.Add("HF");
            if (chkSHF.Checked) frequencyBands.Add("SHF");
            if (chkOtherFrequency.Checked) frequencyBands.Add("Інший");
            if (frequencyBands.Any())
                filters["FrequencyBand"] = frequencyBands;

            if (decimal.TryParse(txtMinPower.Text, out decimal minPower)) filters["MinPower"] = minPower;
            if (decimal.TryParse(txtMaxPower.Text, out decimal maxPower)) filters["MaxPower"] = maxPower;

            if (decimal.TryParse(txtMinWeight.Text, out decimal minWeight)) filters["MinWeight"] = minWeight;
            if (decimal.TryParse(txtMaxWeight.Text, out decimal maxWeight)) filters["MaxWeight"] = maxWeight;

            var protectionLevels = new List<string>();
            if (chkIP54.Checked) protectionLevels.Add("IP54");
            if (chkIP55.Checked) protectionLevels.Add("IP55");
            if (chkIP65.Checked) protectionLevels.Add("IP65");
            if (chkIP66.Checked) protectionLevels.Add("IP66");
            if (chkIP67.Checked) protectionLevels.Add("IP67");
            if (chkIP68.Checked) protectionLevels.Add("IP68");
            if (chkOtherProtection.Checked) protectionLevels.Add("Інший");
            if (protectionLevels.Any()) filters["ProtectionLevel"] = protectionLevels;

            var powerSupplies = new List<string>();
            if (chkBattery.Checked) powerSupplies.Add("Акумулятор");
            if (chk220V.Checked) powerSupplies.Add("220В");
            if (chkVehicleNetwork.Checked) powerSupplies.Add("Бортова мережа");
            if (chkOtherPowerSupply.Checked) powerSupplies.Add("Інший");
            if (powerSupplies.Any()) filters["PowerSupply"] = powerSupplies;

            return filters;
        }

        private IEnumerable<TextBox> GetAllTextBoxes()
        {
            return this.Controls.OfType<TextBox>().Concat(this.Controls.OfType<GroupBox>().SelectMany(gb => gb.Controls.OfType<TextBox>()));
        }

        private IEnumerable<CheckBox> GetAllCheckBoxes()
        {
            return this.Controls.OfType<CheckBox>().Concat(this.Controls.OfType<GroupBox>().SelectMany(gb => gb.Controls.OfType<CheckBox>()));
        }
    }
}
