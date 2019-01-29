using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Logica;

namespace UI
{
    public class BestellingHelperClass
    {
        public List<BestellingsitemModel> CreateBestellingItemList(List<BestelItemControl> bestelItemControls, BestellingModel bestelling, int tafelId)
        {
            BestellingService bestellingService = new BestellingService();
            List<BestellingsitemModel> bestellingsItems = new List<BestellingsitemModel>();

            int laatsteBestellingId = bestellingService.GetLaatseBestelling(tafelId);
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
                        bestellingsitem = new BestellingsitemModel(menuId, laatsteBestellingId, timestamp, hoeveelheid, commentaar);
                    }
                    else
                    {
                        int bestellingId = bestellingService.InsertBestelling(bestelling);
                        bestellingsitem = new BestellingsitemModel(menuId, bestellingId, timestamp, hoeveelheid, commentaar);
                    }
                    bestellingsItems.Add(bestellingsitem);
                }
            }

            return bestellingsItems;
        }
    }
}
