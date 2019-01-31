using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Model;
using Logica;
using System.Windows.Forms;

namespace UI
{
    public class BestellingHelperClass
    {
        //Leest de lijst met bestelItemControls uit, en maak hier een list met BestellingItems van
        public List<BestellingsitemModel> CreateBestellingItemList(List<BestelItemControl> bestelItemControls, BestellingModel bestelling, int tafelId)
        {
            BestellingService bestellingService = new BestellingService();
            List<BestellingsitemModel> bestellingsItems = new List<BestellingsitemModel>();

            //Pak de laastebestelling id
            int laatsteBestellingId = bestellingService.GetLaatseBestelling(tafelId);
            //Kijk of de bestelling nog openstaand, aan de hand van de bestellingId
            bool bestellingOpen = bestellingService.CheckVoorOpenstaandeBestelling(laatsteBestellingId);

            foreach (BestelItemControl bestelItemControl in bestelItemControls)
            {
                int menuId = bestelItemControl.MenuItem.MenuId;
                DateTime timestamp = bestelItemControl.TimeStamp;
                int hoeveelheid = bestelItemControl.Aantal;
                string commentaar = bestelItemControl.Commentaar;

                if (hoeveelheid > 0)
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
                        int bestellingId = bestellingService.InsertBestelling(bestelling);
                        bestellingsitem = new BestellingsitemModel(menuId, bestellingId, timestamp, hoeveelheid, commentaar);
                    }
                    bestellingsItems.Add(bestellingsitem);
                }
                else
                {
                    MessageBox.Show(bestelItemControl.naam + " vooraad is lager dan opgegeven hoeveelheid");
                }
            }

            return bestellingsItems;
        }
    }
}
