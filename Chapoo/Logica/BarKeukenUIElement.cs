using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Logica
{
    public class BarKeukenUIElement
    {

        List<Control> controls = new List<Control>();
        Bestellingsitem item;

        public List<Control> Controls { get => controls; set => controls = value; }
        public Bestellingsitem Item { get => item; set => item = value; }

        public delegate void Refresh();


        public BarKeukenUIElement(Bestellingsitem b, Refresh del, int x, int y)
        {
            Item = b;
            Controls.Add(new Label { Text = Item.Name, Top = y+5, Left = x, Width = 175 });
            Controls.Add(new Label { Text = Item.Amount.ToString() + "x", Top = y+5, Left = x + 180, Width = 20 });
            Controls.Add(new Label { Text = "Tafel " + Item.Tafel.ToString(), Top = y+5, Left = x +200, Width = 50});
            //Cut off the commenttext if it is longer than 25 characters and replace the last 3 characters by '...' to indicate this
            if(Item.Comment.Length>25)
            {
                Controls.Add(new Label { Text = Item.Comment.Substring(0, 22) + "...", Top = y+5, Left = x + 250, Width = 125});
            }
            else
            {
                Controls.Add(new Label { Text = Item.Comment, Top = y+5, Left = x + 250, Width = 125 });
            }
            
            Controls.Add(new Button { Text = "1 item gereedstellen", Top = y, Left = x + 375, Width = 100 });
            Controls.Add(new Button { Text = "alle items gereedstellen", Top = y, Left = x + 475, Width = 100 });
            Controls.Add(new Label { Text = Item.Timestamp.ToLongTimeString(), Top = y+5, Left = x + 575, Width = 50 });

            Controls[3].Click += (s, e) =>
            {
                MessageBox.Show(Item.Comment,Item.Name + " " + Item.Amount + "x",MessageBoxButtons.OK,MessageBoxIcon.Information);
            };
            Controls[4].Click += (s,e) => 
            {
                if (Item.Amount <= 1)
                {
                    BestelLijst.List.Remove(Item);
                    del();
                    Logica.BarKeukenQueue.removeItemFromQueue(Item);
                    Model.BestellingsGeheugen.AddToReadyList(Item);
                    //Check for open orders for the same table
                    foreach(Bestellingsitem bi in Model.BestelLijst.List)
                    {
                        if(bi.Tafel==Item.Tafel)
                        {
                            //if there is one, then don't do anything
                            return;
                        }
                    }
                    BarKeukenQueue.SendNotification(Item.Tafel); //else send a notification
                }
                else
                {
                    BestelLijst.List[BestelLijst.List.IndexOf(Item)].Amount -= 1;
                    Controls[1].Text = Item.Amount.ToString();
                }
                
            };

            Controls[5].Click += (s, e) =>
            {
                BestelLijst.List.Remove(Item);
                del();
                Logica.BarKeukenQueue.removeItemFromQueue(Item);
                Model.BestellingsGeheugen.AddToReadyList(Item);
                //Check for open orders for the same table
                foreach (Bestellingsitem bi in Model.BestelLijst.List)
                {
                    if (bi.Tafel == Item.Tafel)
                    {
                        //if there is one, then don't do anything
                        return;
                    }
                }
                BarKeukenQueue.SendNotification(Item.Tafel); //else send a notification
            };
            
        }
    }
}
