﻿using System;
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
using DataAdaptor;

namespace UI
{
    public partial class BestellingOpnemenForm : BaseFormMobile
    {
        private MenuItemService MenuItemService { get; }
        private BestelItemControl BestelItem { get; set; }
        private BestelKnoppenControl BestelKnoppen { get; set; }

        private WerknemerModel Werknemer { get; set;}
        private TafelModel Tafel { get; set; }
        private BestellingsitemModel BestellingItemModel { get; set; }
        private List<BestelItemControl> BestelItemControls = new List<BestelItemControl>();
        DAOFactory factory;
        //Lijst aanmaken van bestellingitems
        //Voorraad toonen


        public BestellingOpnemenForm(WerknemerModel werknemer, TafelModel tafel, DAOFactory factory)
        {
            this.Tafel = tafel;
            this.factory = factory;
            this.Werknemer = werknemer;
            this.BestelKnoppen = new BestelKnoppenControl(Tafel, factory, BestelItemControls);
            this.MenuItemService = new MenuItemService();

            txtTafel.Text += " " + Tafel.Id.ToString();

            foreach(MenuItemModel menuItem in MenuItemService.GetItems())
            {
                BestelItem = new BestelItemControl(menuItem, this, BestelKnoppen);
                BestelItemControls.Add(BestelItem);
                pnlMain.Controls.Add(BestelItem);
            }           

            pnlBottom.Controls.Add(BestelKnoppen);
        }
        private void Bestelling_opnemen_form_Load(object sender, EventArgs e)
        {
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
        }

        private void btnMenuAfrekenen_Click(object sender, EventArgs e)
        {
            new RekeningFormOverzicht(factory, Tafel).Show();
        }
    }
}
