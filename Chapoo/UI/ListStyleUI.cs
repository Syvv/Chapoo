using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI
{
    public class ListStyleUI
    {
        public void StyleBestellingOpnemen(ListView listView)
        {
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.CheckBoxes = true;
            listView.Scrollable = true;

            listView.Columns.Add(" ");
            listView.Columns.Add("Naam");
            listView.Columns.Add("Aantal");
            listView.Columns.Add("Commentaar");

            listView.Name = "listView";

            listView.Columns[0].Width = 20;
            listView.Columns[1].Width = 200;
            listView.Columns[2].Width = 78;
            listView.Columns[3].Width = 100;

            listView.Height = 325;
        }
        public void StyleBestellingOverzicht(ListView listView)
        {
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Scrollable = true;

            listView.Columns.Add("Naam");
            listView.Columns.Add("Aantal");
            listView.Columns.Add("Commentaar");

            listView.Name = "listView";

            listView.Columns[0].Width = 200;
            listView.Columns[1].Width = 78;
            listView.Columns[2].Width = 100;
        }
    }
}
