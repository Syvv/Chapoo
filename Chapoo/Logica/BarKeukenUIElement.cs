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


        public BarKeukenUIElement(Bestellingsitem b, Refresh del)
        {
            Item = b;
            Controls.Add(new Label { Text = Item.Name });
            Controls.Add(new Label { Text = Item.Amount.ToString() });
            Controls.Add(new Label { Text = "Tafel " + Item.Tafel.ToString() });
            Controls.Add(new Label { Text = Item.Comment.Substring(0,25) });
            Controls.Add(new Button { Text = "1 item gereedstellen"});
            Controls.Add(new Button { Text = "alle items gereedstellen" });

            Controls[4].Click += (s,e) => 
            {
                Item.Amount -= 1;
                if (Item.Amount < 1)
                {
                    BestelLijst.List.Remove(Item);
                    del();
                }
                else
                {
                    Controls[1].Text = Item.Amount.ToString();
                }
                
            };

            Controls[5].Click += (s, e) =>
            {
                BestelLijst.List.Remove(Item);
                del();
            };

            del();
        }
    }
}
