using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DataAdaptor;

namespace Logica
{
    public class Fill_order_list_logica
    {
        public ListView ShowGerechten(List<Model.Menu> gerechten)
        {

            ListView listView = new ListView();

            listView.View = View.Details;
            listView.CheckBoxes = true;
            listView.GridLines = true;

            listView.Columns.Add("Naam");
            listView.Columns.Add("Prijs");
            listView.Columns.Add("Aantal");

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listView.Height = 325;
            listView.Width = 450;

            for (int i = 0; i < gerechten.Count; i++)
            {
                ListViewItem lv = new ListViewItem(gerechten[i].MenuItem);               
                lv.SubItems.Add(gerechten[i].Prijs.ToString());
                listView.Items.Add(lv);
            }
            return listView;
        }
    }
}
