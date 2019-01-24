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
        public void FillListView(ListView listView, List<Model.MenuItem> gerechten)
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
