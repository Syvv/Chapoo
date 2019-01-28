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

namespace UI
{
    public partial class BarKeukenUIElement : UserControl
    {
        public delegate void HerbouwUI(Bestellingsitem bestellingsitem);
        public BarKeukenUIElement(Bestellingsitem item, BestellingsItemLogica logica, HerbouwUI herbouwUI)
        {
            InitializeComponent();
            Tafelnummer.Text = "Tafel " + item.Tafel + ":";
            Hoeveelheid.Text = item.Hoeveelheid + "x";
            MenuItem.Text = item.Naam;
            Commentaar.Text = item.Commentaar;
            Timestamp.Text = item.Timestamp.ToShortTimeString();
            GereedstellenBtn.Height = Commentaar.Height+10;


            GereedstellenBtn.Click += (s, e) =>
            {
                logica.StelBestellingsItemGereed(item);
                herbouwUI(item);
            };
        }
    }
}
