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
    public partial class AmmunitionFiltersPanelControl1 : UserControl
    {
        public event EventHandler<FilterEventArgs> FiltersChanged;

        public AmmunitionFiltersPanelControl1()
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
                if (checkBox != chkAllAmmoTypes && checkBox != chkAllExplosives) checkBox.Checked = false;
            }

            chkAllAmmoTypes.Checked = true;
            chkAllExplosives.Checked = true;

            foreach (var textBox in GetAllTextBoxes())
            {
                textBox.Text = "";
            }
        }

        public Dictionary<string, object> GetCurrentFilters()
        {
            var filters = new Dictionary<string, object>();

            var ammoTypes = new List<string>();
            if (chkArmorPiercing.Checked) ammoTypes.Add("БЗ");
            if (chkHighExplosive.Checked) ammoTypes.Add("ОФ");
            if (chkTracer.Checked) ammoTypes.Add("Трасуючий");
            if (chkCumulative.Checked) ammoTypes.Add("Кумулятивний");
            if (chkOtherAmmo.Checked) ammoTypes.Add("Інший");
            if (ammoTypes.Any()) filters["AmmoType"] = ammoTypes;

            if (!string.IsNullOrWhiteSpace(txtCaliber.Text)) filters["Caliber"] = txtCaliber.Text.Trim();

            if (decimal.TryParse(txtMinWeight.Text, out decimal minWeight)) filters["MinWeight"] = minWeight;
            if (decimal.TryParse(txtMaxWeight.Text, out decimal maxWeight)) filters["MaxWeight"] = maxWeight;
            if (decimal.TryParse(txtMinLength.Text, out decimal minLength)) filters["MinLength"] = minLength;
            if (decimal.TryParse(txtMaxLength.Text, out decimal maxLength)) filters["MaxLength"] = maxLength;

            var explosiveTypes = new List<string>();
            if (chkNoExplosive.Checked) explosiveTypes.Add("Без вибухівки");
            if (chkTNT.Checked) explosiveTypes.Add("ТНТ");
            if (chkRDX.Checked) explosiveTypes.Add("RDX");
            if (chkHexogen.Checked) explosiveTypes.Add("Гексоген");
            if (chkOtherExplosive.Checked) explosiveTypes.Add("Інший");
            if (explosiveTypes.Any()) filters["ExplosiveType"] = explosiveTypes;

            if (int.TryParse(txtMinRange.Text, out int minRange)) filters["MinEffectiveRange"] = minRange;
            if (int.TryParse(txtMaxRange.Text, out int maxRange)) filters["MaxEffectiveRange"] = maxRange;

            if (int.TryParse(txtMinShelfLife.Text, out int minShelfLife)) filters["MinShelfLife"] = minShelfLife;
            if (int.TryParse(txtMaxShelfLife.Text, out int maxShelfLife)) filters["MaxShelfLife"] = maxShelfLife;

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
