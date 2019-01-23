﻿using System;
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
            //Controls.Add();
            GroupBox gr = new GroupBox { Top = y, Left = x, Height = 50, Width = 1600, BackColor = System.Drawing.Color.LightBlue };
            Controls.Add(new Label { Text = Item.Name, Top = y+15, Left = x + 140, Width = 650, Font = new System.Drawing.Font("Arial",16), Height = 30, BackColor = System.Drawing.Color.LightBlue });
            Controls.Add(new Label { Text = Item.Amount.ToString() + "x", Top = y+15, Left = x + 100, Width = 40, Font = new System.Drawing.Font("Arial", 16), Height = 30, BackColor = System.Drawing.Color.LightBlue });
            Controls.Add(new Label { Text = "Tafel " + Item.Tafel.ToString() + ":", Top = y+15, Left = x, Width = 100, Font = new System.Drawing.Font("Arial", 16), Height = 30, BackColor = System.Drawing.Color.LightBlue });
            //Cut off the comment_text if it is longer than 25 characters and replace the last 3 characters by '...' to indicate this
            if(Item.Comment.Length>25)
            {
                Controls.Add(new Label { Text = "("+ Item.Comment.Substring(0, 22) + "...)", Top = y+15, Left = x + 790, Width = 300, Font = new System.Drawing.Font("Arial", 16), Height = 30, BackColor = System.Drawing.Color.LightBlue });
            }
            else
            {
                Controls.Add(new Label { Text = "("+Item.Comment+")", Top = y+15, Left = x + 790, Width = 300, Font = new System.Drawing.Font("Arial", 16), Height = 30, BackColor = System.Drawing.Color.LightBlue });
            }
            Controls.Add(new Button { Text = "1 item gereedstellen", Top = y+7, Left = x + 1090, Width = 200, Font = new System.Drawing.Font("Arial", 12), Height = 40, TextAlign=System.Drawing.ContentAlignment.MiddleCenter });
            Controls.Add(new Button { Text = "Hele rij gereedstellen", Top = y+7, Left = x + 1290, Width = 200, Font = new System.Drawing.Font("Arial", 12), Height = 40, TextAlign = System.Drawing.ContentAlignment.MiddleCenter });
            Controls.Add(new Label { Text = Item.Timestamp.ToLongTimeString(), Top = y+15, Left = x + 1490, Width = 100, Font = new System.Drawing.Font("Arial", 16), Height = 30, BackColor = System.Drawing.Color.LightBlue });
            foreach(Control c in Controls)
            {
                gr.Controls.Add(c);
            }
            Controls.Add(gr);
            Controls[3].Click += (s, e) =>
            {
                //popup for extra info on the comment
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
                    if (!HasOpenOrders(Item))
                    {
                        BarKeukenQueue.SendNotification(Item.Tafel); //if there aren't, send a notification
                    }
                }
                else
                {
                    int index = BestelLijst.List.IndexOf(Item);
                    BestelLijst.List[index].Amount -= 1;
                    Controls[1].Text = Item.Amount.ToString() + "x";
                    BarKeukenQueue.UpdateAmountInDataBase(BestelLijst.List[index]);
                }
                
            };

            Controls[5].Click += (s, e) =>
            {
                BestelLijst.List.Remove(Item);
                del();
                Logica.BarKeukenQueue.removeItemFromQueue(Item);
                Model.BestellingsGeheugen.AddToReadyList(Item);
                //Check for open orders for the same table
                if(!HasOpenOrders(Item))
                {
                    BarKeukenQueue.SendNotification(Item.Tafel); //if there aren't, send a notification
                }
                
            };
            
        }

        private static bool HasOpenOrders(Bestellingsitem item)
        {
            foreach (Bestellingsitem bi in Model.BestelLijst.List)
            {
                if (bi.Tafel == item.Tafel)
                {
                    //There is an open order for the same table
                    return true;
                }
            }
            return false;//There are no open orders for that table
        }
    }
}
