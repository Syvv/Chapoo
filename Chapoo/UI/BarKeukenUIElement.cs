﻿using System;
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
        public BarKeukenUIElement(Bestellingsitem item, BestellingsItemLogica logica)
        {
            InitializeComponent();
            Tafelnummer.Text = "Tafel " + item.Tafel + ":";
            Hoeveelheid.Text = item.Hoeveelheid + "x";
            MenuItem.Text = item.Naam;
            Commentaar.Text = item.Commentaar;
            Timestamp.Text = item.Timestamp.ToShortTimeString();

            GereedstellenBtn.Click += (s, e) =>
            {
                logica.StelBestellingsItemGereed(item);
            };
        }
    }
}
