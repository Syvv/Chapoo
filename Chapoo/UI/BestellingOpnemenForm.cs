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
using Model;
using Logica;


namespace UI
{
    public partial class BestellingOpnemenForm : BaseFormMobile
    {
        public MenuItemService MenuItemService = new MenuItemService();

        public BestellingOpnemenForm(Werknemer werknemer, Tafel tafel)
        {
            foreach (Model.MenuItem menuItem in MenuItemService.GetItems())
            {
                BestelItem bestelItem = new BestelItem(menuItem);                
                pnlMain.Controls.Add(bestelItem);
            }
            BestelKnoppen bestelKnoppen = new BestelKnoppen();
            pnlBottom.Controls.Add(bestelKnoppen);
        }
        private void Bestelling_opnemen_form_Load(object sender, EventArgs e)
        {

        }

    }
}
