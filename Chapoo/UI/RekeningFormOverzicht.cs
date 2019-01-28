﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;
using StyleGuide;
using DataAdaptor;

namespace UI
{
    public partial class RekeningFormOverzicht : BaseFormMobile
    {
        RekeningLogica RekeningLogica { get; set; }
        private RekeningGeldOverzicht Geldoverzicht { get; set; }
        private RekeningItem Rekeningitem { get; set; }
        private Rekening Rekening { get; set; }
        private Tafel Tafel { get; set; }
        private DAOFactory factory;

        public RekeningFormOverzicht(DAOFactory factory, Tafel tafel)
        {
            InitializeComponent();
            this.factory = factory;
            
            this.RekeningLogica = new RekeningLogica(factory);            
            this.Tafel = tafel;

            WeergevenRekeningItems();
            WeergevenRekeningPrijzen();//naam aanpassen
        }

        private void WeergevenRekeningItems()
        {
            int bestellingId = Tafel.Bestelling.Id;
            List<Bestellingsitem> BestellingenLijst = RekeningLogica.BesteldeItems(bestellingId);
            int y = 50;
            int x = 50;

            foreach(Bestellingsitem item in BestellingenLijst) //lokoatie aanpassen
            {
                this.Rekeningitem = new RekeningItem(item.Naam, item.Hoeveelheid, item.Prijs, item.Hoeveelheid * item.Prijs);
                Rekeningitem.Top = y; //nog aanpassen
                Rekeningitem.Left = x; // nog aanpassen
                Controls.Add(this.Rekeningitem);

                y += 50;//de hoogte van de RekeningItem
            }            
        }
        private void WeergevenRekeningPrijzen()  //lokatie aanpassen
        {
            this.Geldoverzicht = new RekeningGeldOverzicht(Rekening);
            Geldoverzicht.Top = 550; //nog aanpassen
            Geldoverzicht.Left = 20; // nog aanpassen
            Controls.Add(this.Geldoverzicht);
        }
    }
}
