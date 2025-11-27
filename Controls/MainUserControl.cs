using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryEquipmentStore.Forms;
using MilitaryEquipmentStore.Modal_windows;
using MilitaryEquipmentStore.Models;

namespace MilitaryEquipmentStore.Controls
{
    public partial class MainUserControl : UserControl
    {
        public MainUserControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenCatalog("радіоелектроніка");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenCatalog("транспорт");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenCatalog("боєприпаси");
        }
        private void MainUserControl_Load(object sender, EventArgs e)
        {
            if (UserSession.Role == "manager")
            {
                manageManagersBtn.Visible = false;
            }
            else if (UserSession.Role == "admin")
            {
                manageManagersBtn.Visible = true;
            }
        }

        private void OpenCatalog(string category)
        {
            var form = this.FindForm() as Form1;
            if (form == null) return;

            form.ShowCatalogView(category);
        }

        private void manageManagersBtn_Click_1(object sender, EventArgs e)
        {
            var form = this.FindForm() as Form1;
            if (form != null)
            {
                form.ShowManagersManagerView();
            }
        }

        private void manageProductsBtn_Click_1(object sender, EventArgs e)
        {
            var form = this.FindForm() as Form1;
            if (form != null)
            {
                form.ShowProductsManagerView();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as Form1;
            if (form != null) 
            {
                form.ShowOrdersManagerView();
            }
        }
    }
}
