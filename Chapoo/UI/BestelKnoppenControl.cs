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
using DataAdaptor;

namespace UI
{
    public partial class BestelKnoppenControl : UserControl
    {
        public BestellingModel Bestelling { get; set; }
        private MenuItemService MenuItemService { get; set; }
        public TafelModel Tafel { get; set; }
        public WerknemerModel Werknemer {get; set;} 
        private BestellingsItemService bestellingsItemService { get; set; }
        private BestellingOpnemenForm BestellingOpnemenForm { get; set; }
        public List<BestelItemControl> BestelItemControls = new List<BestelItemControl>();

        TimeSpan start = new TimeSpan(10, 0, 0);
        TimeSpan end = new TimeSpan(17, 0, 0);
        TimeSpan now = DateTime.Now.TimeOfDay;


        public BestelKnoppenControl(BestellingOpnemenForm bestellingOpnemenForm)
        {
            InitializeComponent();
            this.BestellingOpnemenForm = bestellingOpnemenForm;
            this.Tafel = bestellingOpnemenForm.Tafel;
            this.Werknemer = bestellingOpnemenForm.Werknemer;
            MenuItemService = new MenuItemService();

            this.btnVerstuur.Enabled = false;
            this.btnVerstuur.BackColor = Color.FromArgb(157, 199, 200);
            this.btnVerstuur.ForeColor = Color.FromArgb(255, 255, 255);

        }
        public BestelKnoppenControl()
        {
            InitializeComponent();
        }
        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            bestellingsItemService = new BestellingsItemService();
            Bestelling = new BestellingModel(Werknemer, Tafel);

            BestellingService bestellingService = new BestellingService();
            List<BestellingsitemModel> bestellingsItems = new List<BestellingsitemModel>();

            //Pak de laastebestelling id
            int laatsteBestellingId = bestellingService.GetLaatseBestelling(Tafel.Id);
            //Kijk of de bestelling nog openstaand, aan de hand van de bestellingId
            bool bestellingOpen = bestellingService.CheckVoorOpenstaandeBestelling(laatsteBestellingId);

            foreach (BestelItemControl bestelItemControl in BestelItemControls)
            {
                int menuId = bestelItemControl.MenuItem.MenuId;
                DateTime timestamp = bestelItemControl.TimeStamp;
                int hoeveelheid = bestelItemControl.Aantal;
                string commentaar = bestelItemControl.Commentaar;

                if (bestelItemControl.Add)
                {
                    BestellingsitemModel bestellingsitem;

                    if (bestellingOpen)
                    {
                        //Als de bestelling nog open is gebruik dan de laatsteBestellingId
                        bestellingsitem = new BestellingsitemModel(menuId, laatsteBestellingId, timestamp, hoeveelheid, commentaar);
                    }
                    else
                    {
                        //Als de bestelling niet open is maak een nieuwe bestelling
                        int bestellingId = bestellingService.InsertBestelling(Bestelling);
                        bestellingsitem = new BestellingsitemModel(menuId, bestellingId, timestamp, hoeveelheid, commentaar);
                    }

                    bestellingsItems.Add(bestellingsitem);
                }
            }

            if (bestellingsItems.Any())
            {
                bestellingsItemService.InsertBestellingItems(bestellingsItems);
            }

            BestellingOpnemenForm.pnlMain.Controls.Clear();
            BestelItemControls.Clear();
            btnFris.PerformClick();
            this.btnVerstuur.Enabled = false;
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            BestellingOpnemenForm.pnlMain.Controls.Clear();
            foreach (BestelItemControl bestelItemControl in BestelItemControls)
            {
                BestellingOpnemenForm.pnlMain.Controls.Add(bestelItemControl);
            }
            this.btnVerstuur.Enabled = true;
        }

        private void btnFris_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            List<MenuItemModel> menuItems = MenuItemService.Categoriseren(Categorie.Frisdrank);

            foreach (MenuItemModel menuItem in menuItems)
            {
                BestelItemControl bestelItem = new BestelItemControl(menuItem, BestellingOpnemenForm, this);
                if (menuItem.Voorraad == 0)
                {
                    bestelItem.addButton1.Hide();
                    bestelItem.lblItem.ForeColor = Color.FromArgb(255, 0, 0);
                }
                this.BestellingOpnemenForm.pnlMain.Controls.Add(bestelItem);
            }
        }

        private void btnBier_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();

            List<MenuItemModel> menuItems = MenuItemService.Categoriseren(Categorie.Bier);

            foreach(MenuItemModel menuItem in menuItems)
            {
                BestelItemControl bestelItem = new BestelItemControl(menuItem, BestellingOpnemenForm, this);
                if (menuItem.Voorraad == 0)
                {
                    bestelItem.addButton1.Hide();
                    bestelItem.lblItem.ForeColor = Color.FromArgb(255, 0, 0);
                }
                this.BestellingOpnemenForm.pnlMain.Controls.Add(bestelItem);
            }
        }

        private void btnWijn_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            List<MenuItemModel> menuItems = MenuItemService.Categoriseren(Categorie.Wijn);

            foreach (MenuItemModel menuItem in menuItems)
            {
                BestelItemControl bestelItem = new BestelItemControl(menuItem, BestellingOpnemenForm, this);
                if (menuItem.Voorraad == 0)
                {
                    bestelItem.addButton1.Hide();
                    bestelItem.lblItem.ForeColor = Color.FromArgb(255, 0, 0);
                }
                this.BestellingOpnemenForm.pnlMain.Controls.Add(bestelItem);
            }
        }

        private void btnSterk_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            List<MenuItemModel> menuItems = MenuItemService.Categoriseren(Categorie.SterkeDrank);

            foreach (MenuItemModel menuItem in menuItems)
            {
                BestelItemControl bestelItem = new BestelItemControl(menuItem, BestellingOpnemenForm, this);
                if (menuItem.Voorraad == 0)
                {
                    bestelItem.addButton1.Hide();
                    bestelItem.lblItem.ForeColor = Color.FromArgb(255, 0, 0);
                }
                this.BestellingOpnemenForm.pnlMain.Controls.Add(bestelItem);
            }
        }

        private void btnWarm_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            List<MenuItemModel> menuItems = MenuItemService.Categoriseren(Categorie.KoffieThee);

            foreach (MenuItemModel menuItem in menuItems)
            {
                BestelItemControl bestelItem = new BestelItemControl(menuItem, BestellingOpnemenForm, this);
                if (menuItem.Voorraad == 0)
                {
                    bestelItem.addButton1.Hide();
                    bestelItem.lblItem.ForeColor = Color.FromArgb(255, 0, 0);
                }
                this.BestellingOpnemenForm.pnlMain.Controls.Add(bestelItem);
            }
        }

        private void btnNa_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            List<MenuItemModel> menuItems;

            if ((now > start) && (now < end))
            {
                menuItems = MenuItemService.Categoriseren(Categorie.LunchNagerecht);
            }
            else
            {
               menuItems = MenuItemService.Categoriseren(Categorie.DinerNagerecht);
            }

            foreach (MenuItemModel menuItem in menuItems)
            {
                BestelItemControl bestelItem = new BestelItemControl(menuItem, BestellingOpnemenForm, this);
                if (menuItem.Voorraad == 0)
                {
                    bestelItem.addButton1.Hide();
                    bestelItem.lblItem.ForeColor = Color.FromArgb(255, 0, 0);
                }
                this.BestellingOpnemenForm.pnlMain.Controls.Add(bestelItem);
            }
        }

        private void btnVoor_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            List<MenuItemModel> menuItems;

            if ((now > start) && (now < end))
            {
                menuItems = MenuItemService.Categoriseren(Categorie.LunchVoorgerecht);
            }
            else
            {
                menuItems = MenuItemService.Categoriseren(Categorie.DinerVoorgerecht);
            }

            foreach (MenuItemModel menuItem in menuItems)
            {
                BestelItemControl bestelItem = new BestelItemControl(menuItem, BestellingOpnemenForm, this);
                if (menuItem.Voorraad == 0)
                {
                    bestelItem.addButton1.Hide();
                    bestelItem.lblItem.ForeColor = Color.FromArgb(255, 0, 0);
                }
                this.BestellingOpnemenForm.pnlMain.Controls.Add(bestelItem);
            }
        }

        private void btnHoofd_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            List<MenuItemModel> menuItems;

            if ((now > start) && (now < end))
            {
                menuItems = MenuItemService.Categoriseren(Categorie.LunchHoofdgerecht);
            }
            else
            {
                menuItems = MenuItemService.Categoriseren(Categorie.DinerHoofdgerecht);
            }

            foreach (MenuItemModel menuItem in menuItems)
            {
                BestelItemControl bestelItem = new BestelItemControl(menuItem, BestellingOpnemenForm, this);
                if (menuItem.Voorraad == 0)
                {
                    bestelItem.addButton1.Hide();
                    bestelItem.lblItem.ForeColor = Color.FromArgb(255, 0, 0);
                }
                this.BestellingOpnemenForm.pnlMain.Controls.Add(bestelItem);
            }
        }

        private void btnTussen_Click(object sender, EventArgs e)
        {
            this.BestellingOpnemenForm.pnlMain.Controls.Clear();
            List<MenuItemModel> menuItems = MenuItemService.Categoriseren(Categorie.DinerTussengerecht);

            foreach (MenuItemModel menuItem in menuItems)
            {
                BestelItemControl bestelItem = new BestelItemControl(menuItem, BestellingOpnemenForm, this);
                if (menuItem.Voorraad == 0)
                {
                    bestelItem.addButton1.Hide();
                    bestelItem.lblItem.ForeColor = Color.FromArgb(255, 0, 0);
                }
                this.BestellingOpnemenForm.pnlMain.Controls.Add(bestelItem);
            }
        }
    }
}
