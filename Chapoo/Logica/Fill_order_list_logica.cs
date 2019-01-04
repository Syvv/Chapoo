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
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.CheckBoxes = true;

            listView.Columns.Add("Naam");
            listView.Columns.Add("Aantal");

            listView.Name = "listView";

            listView.Columns[0].Width = 200;
            listView.Columns[1].Width = 78;
            var txtBox = new TextBox();

            listView.Height = 325;
            listView.Width = 378;

            for (int i = 0; i < gerechten.Count; i++)
            {
                ListViewItem lv = new ListViewItem(gerechten[i].MenuItem);               
                listView.Items.Add(lv);
            }
            return listView;
        }
        public Control FillListView(ListView listView, List<Model.Menu> gerechten)
        {
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.CheckBoxes = true;

            listView.Columns.Add("Naam");
            listView.Columns.Add("Aantal");

            listView.Name = "listView";

            listView.Columns[0].Width = 200;
            listView.Columns[1].Width = 78;
            var txtBox = new TextBox();

            listView.Height = 325;
            listView.Width = 378;

            

            for (int i = 0; i < gerechten.Count; i++)
            {
                ListViewItem lv = new ListViewItem(gerechten[i].MenuItem);
                listView.Items.Add(lv);
            }
            return listView;
        }

    }
}
