using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace UI
{
    public partial class BestelItem : UserControl
    {
        public Model.MenuItem MenuItem { get; set; }
        public bool Add = false;

        public BestelItem(Model.MenuItem item)
        {
            InitializeComponent();
            this.MenuItem = item;
            this.lblItem.Text = MenuItem.Naam;
            this.BackColor = Color.FromArgb(245, 239, 237);
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            if(addButton1.Text == "+")
            {
                addButton1.Text = "x";
            }
            else
            {
                addButton1.Text = "+";
            }
            if (!Add)
            {
                Add = true;
            }
            else
            {
                Add = false;
            }
        }
    }
}
