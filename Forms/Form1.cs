using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MilitaryEquipmentStore.Controls;
using MilitaryEquipmentStore.Controls.Auth;

namespace MilitaryEquipmentStore.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidebarPanel.Visible = false;
            ShowLoginView();
        }

        public void ShowLoginView()
        {
            sidebarPanel.Visible = false;
            contentPanel.Visible = false;

            var loginControl = new LoginUserControl();
            loginControl.Name = "loginTempControl";
            loginControl.Dock = DockStyle.None;

            rootPanel.Controls.Add(loginControl);
            loginControl.BringToFront();

            loginControl.Left = (rootPanel.Width - loginControl.Width) / 2;
            loginControl.Top = (rootPanel.Height - loginControl.Height) / 2;
        }


        public void ShowMainView()
        {
            var login = rootPanel.Controls["loginTempControl"];
            if (login != null) 
            {
                rootPanel.Controls.Remove(login);
            }
            
            sidebarPanel.Visible = true;
            contentPanel.Visible = true;

            sidebarPanel.Controls.Clear();
            sidebarPanel.Controls.Add(new MainUserControl());
        }

        public void ShowCatalogView(string category)
        {
            contentPanel.Controls.Clear();
            CatalogUserControl catalogUserControl = new CatalogUserControl(category);

            contentPanel.Controls.Add(catalogUserControl);
        }

        public void ShowManagersManagerView()
        {
            contentPanel.Controls.Clear();

            ManageManagersControl manageManagersControl = new ManageManagersControl();
            //manageManagersControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(manageManagersControl);
        }

        public void ShowProductsManagerView()
        {
            contentPanel.Controls.Clear();

            ManageProductsControl manageProductsControl = new ManageProductsControl();
            manageProductsControl.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(manageProductsControl);
        }

        public void ShowOrdersManagerView()
        {
            contentPanel.Controls.Clear();

            ManageOrdersControl1 ordersControl1 = new ManageOrdersControl1();
            ordersControl1.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(ordersControl1);
        }
    }
}
