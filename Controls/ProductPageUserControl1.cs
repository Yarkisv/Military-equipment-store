using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilitaryEquipmentStore.Controls
{
    public partial class ProductPageUserControl1 : UserControl
    {
        private string _article;
        
        public ProductPageUserControl1(string article)
        {
            _article = article;
            InitializeComponent();
        }
    }
}
