using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;
using DataAdaptor;

namespace UI
{
    public partial class BarKeukenUIElement : UserControl
    {
        public delegate void HerbouwUI(BestellingsitemModel bestellingsitem);
        public BarKeukenUIElement(BestellingsitemModel item, BestellingsItemService logica, HerbouwUI herbouwUI)
        {
            InitializeComponent();
            Tafelnummer.Text = "Tafel " + item.Tafel + ":";
            Hoeveelheid.Text = item.Hoeveelheid + "x";
            MenuItem.Text = item.Naam;
            Commentaar.Text = item.Commentaar;
            Timestamp.Text = item.Timestamp.ToLongTimeString();
            GereedstellenBtn.Height = Commentaar.Height+10;


            GereedstellenBtn.Click += (s, e) =>
            {
                logica.StelBestellingsItemGereed(item);
                herbouwUI(item);
            };
        }

        public void StyleAsFinished()
        {
            this.BackColor = Color.DarkGray;
            GereedstellenBtn.Enabled = false;
        }
    }
}
