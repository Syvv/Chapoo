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
    public partial class FooiToevoegen : UserControl
    {
        public FooiToevoegen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblOptieKeuze.Text = "Fooi los toevoegen";
        }

        private void btnTotaalBedrag_Click(object sender, EventArgs e)
        {
            lblOptieKeuze.Text = "Fooi zit in het totaalbedrag";
        }
    }
}
