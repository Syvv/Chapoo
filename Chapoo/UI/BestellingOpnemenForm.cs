using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StyleGuide;
using Logica;
using Model;


namespace UI
{
    public partial class BestellingOpnemenForm : StyleGuide.BaseFormMobile
    {

        public BestellingOpnemenForm()
        {
            BestelItem bestelItem = new BestelItem();
            mainPanel.Controls.Add(bestelItem);
        }
        private void Bestelling_opnemen_form_Load(object sender, EventArgs e)
        {

        }

    }
}
