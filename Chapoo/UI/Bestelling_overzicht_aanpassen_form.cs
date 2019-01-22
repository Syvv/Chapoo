using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Bestelling_overzicht_aanpassen_form : Form
    {
 
        public Bestelling_overzicht_aanpassen_form(string comment, string aantal)
        {
            InitializeComponent();
            txtComment.Text = comment;
            txtAantal.Text = aantal;
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
               
        }
    }
}
