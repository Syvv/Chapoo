using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class RekeningItem : UserControl
    {
        public RekeningItem(string item, int aantal, double prijs, double totPrijs)
        {
            InitializeComponent();
            lblItem.Text = item;
            LblAantal.Text = aantal.ToString() + "x";
            LblPrijs.Text = string.Format("€ {0:F2} ", prijs);
            LblTotaalprijs.Text = string.Format("€ {0:F2} ", totPrijs);
        }

        private void LblAantal_Click(object sender, EventArgs e)
        {

        }

        private void lblItem_Click(object sender, EventArgs e)
        {

        }
    }
}
