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
    public partial class TransportFiltersPanelControl1 : UserControl
    {
        public event EventHandler<FilterEventArgs> FiltersChanged;

        public TransportFiltersPanelControl1()
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
            rbAllTypes.Checked = true;

            foreach (var textBox in GetAllTextBoxes())
            {
                textBox.Text = "";
            }

            foreach (var checkBox in GetAllCheckBoxes())
            {
                if (checkBox != chkAllFuelTypes && checkBox != chkAllTransmissions) checkBox.Checked = false;
            }

            chkAllFuelTypes.Checked = true;
            chkAllTransmissions.Checked = true;
        }

        public Dictionary<string, object> GetCurrentFilters()
        {
            var filters = new Dictionary<string, object>();

            var selectedTransportType = groupTransportType.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text;
            if (selectedTransportType != "Всі типи")
            {
                filters["TransportType"] = selectedTransportType;
            }

            if (decimal.TryParse(txtMinPrice.Text, out decimal minPrice)) filters["MinPrice"] = minPrice;
            if (decimal.TryParse(txtMaxPrice.Text, out decimal maxPrice)) filters["MaxPrice"] = maxPrice;

            if (decimal.TryParse(txtMinLoadCapacity.Text, out decimal minLoad)) filters["MinLoadCapacity"] = minLoad;
            if (decimal.TryParse(txtMaxLoadCapacity.Text, out decimal maxLoad)) filters["MaxLoadCapacity"] = maxLoad;

            if (int.TryParse(txtMinMaxSpeed.Text, out int minSpeed)) filters["MinMaxSpeed"] = minSpeed;
            if (int.TryParse(txtMaxMaxSpeed.Text, out int maxSpeed)) filters["MaxMaxSpeed"] = maxSpeed;

            var fuelTypes = new List<string>();
            if (chkDiesel.Checked) fuelTypes.Add("Дизель");
            if (chkPetrol.Checked) fuelTypes.Add("Бензин");
            if (chkHybrid.Checked) fuelTypes.Add("Гібрид");
            if (chkElectric.Checked) fuelTypes.Add("Електро");
            if (chkOtherFuel.Checked) fuelTypes.Add("Інший");
            if (fuelTypes.Any()) filters["FuelType"] = fuelTypes;

            if (int.TryParse(txtMinEnginePower.Text, out int minPower)) filters["MinEnginePower"] = minPower;
            if (int.TryParse(txtMaxEnginePower.Text, out int maxPower)) filters["MaxEnginePower"] = maxPower;

            if (int.TryParse(txtMinCrew.Text, out int minCrew)) filters["MinCrew"] = minCrew;
            if (int.TryParse(txtMaxCrew.Text, out int maxCrew)) filters["MaxCrew"] = maxCrew;

            var transmissionTypes = new List<string>();
            if (chkMechanical.Checked) transmissionTypes.Add("Механічна");
            if (chkAutomatic.Checked) transmissionTypes.Add("Автоматична");
            if (chkHydroMechanical.Checked) transmissionTypes.Add("Гідромеханічна");
            if (chkOtherTransmission.Checked) transmissionTypes.Add("Інша");
            if (transmissionTypes.Any())  filters["TransmissionType"] = transmissionTypes;

            if (decimal.TryParse(txtMinWeight.Text, out decimal minWeight)) filters["MinWeight"] = minWeight;
            if (decimal.TryParse(txtMaxWeight.Text, out decimal maxWeight)) filters["MaxWeight"] = maxWeight;

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

    public class FilterEventArgs : EventArgs
    {
        public Dictionary<string, object> Filters { get; }

        public FilterEventArgs(Dictionary<string, object> filters)
        {
            Filters = filters;
        }
    }
}
