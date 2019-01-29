﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class RekeningService
    {
        public List<BestellingsitemModel> BesteldeItems(int bestellingsId)
        {
            List<BestellingsitemModel> besteldeItems = DAOFactory.Instance.CreateBestellingsItemDAO().HaalAlleItemsOp(bestellingsId);

            return besteldeItems;
        }

        //rekening opstellen Prijs
        public RekeningModel RekeningOpstellen(int BestellingsId)//Test de While Loop en BTW
        {
            List<BestellingsitemModel> besteldeItems = BesteldeItems(BestellingsId);

            double btw21 = 0;
            double btw09 = 0;
            double totaalBedrag = 0;

            foreach (BestellingsitemModel item in besteldeItems)
            {
                int hoeveelheid = item.Hoeveelheid;
                while (hoeveelheid > 0) //Deze testen
                {
                    double btwPercentage = 100 + item.BtwPercentage;
                    //if (item.Categorie == Categorie.SterkeDrank || item.Categorie == Categorie.Wijn || item.Categorie == Categorie.Bier)
                    if (item.BtwPercentage == 21)
                    {
                        
                        double btw = item.Prijs - (item.Prijs / btwPercentage * 100); //berekening van 21%
                        btw21 += btw;
                    }
                    else
                    {
                        double btw = item.Prijs - (item.Prijs / btwPercentage * 100); //berekening van 9 %
                        btw09 += btw;
                    }
                    totaalBedrag += item.Prijs;
                    hoeveelheid--;
                }
            }
            double db_btw = btw21 + btw09;
            RekeningModel rekening = new RekeningModel(totaalBedrag, btw09, btw21);

            return rekening;
        }

        //Fooi toevoegenbij Eindbedrag invullen
        public void FooiToevoegenInBedrag(ref RekeningModel rekening, double totaal)
        {
            double fooi = totaal - rekening.Totaalbedrag;
            rekening.Totaalbedrag += fooi;
            rekening.Fooi = fooi;
        }
        public void FooiLosToevoegen(ref RekeningModel rekening, double Fooi)
        {
            rekening.Totaalbedrag += Fooi;
            rekening.Fooi = Fooi;
        }

        //Fooi Controlleren bij Eindbedrag invullen
        public bool FooiControlleren(RekeningModel rekening, double totaal)
        {

            if (rekening.Totaalbedrag > totaal)
            {
                return true;
            }
            return false;
        }


        //rekening versturen
        public void RekeningBetaling(RekeningModel rekening)//naam verbeteren
        {
            //fooi en niew eindbedragtoevoegen


            RekeningDAO RekeningDataLaag = DAOFactory.Instance.CreateRekeningDAO();
            RekeningDataLaag.InsertRekening(rekening);
        }









        //private string Opmerking { get; set; }
        //public void OpmerkingToevoegen(string opmerking)
        //{
        //    this.Opmerking = opmerking;
        //}
        ////Opmerking Weergeven
        //public string OpmerkingWeergeven()
        //{
        //    return (string)Opmerking;
        //}
        //fooi handmatig toevoegen als er los fooi gegeven wordt.
        //public double NieuwTotaalbedrag(double fooi, RekeningModel rekening) //als het goed is kan deze weg
        //{
        //    rekening.Fooi = fooi;
        //    rekening.Totaalbedrag += fooi;

        //    return rekening.Totaalbedrag;
        //}
    }
}
