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
    public class VulBestelOpnemenService
    {
        public void ListViewStyle(ListView listView)
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
        public void FillListView(ListView listView, List<MenuModel> gerechten)
        {   
            for (int i = 0; i < gerechten.Count; i++)
            {
                ListViewItem lv = new ListViewItem(new[] {gerechten[i].MenuId.ToString(), gerechten[i].MenuItem, "", ""});
                lv.Tag = gerechten[i].Categorie;
                listView.Items.Add(lv);
            }
        }

    }
}
