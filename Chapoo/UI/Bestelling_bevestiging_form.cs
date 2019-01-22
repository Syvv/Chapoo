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
    public partial class Bestelling_bevestiging_form : Form
    {
        public bool confirmatie = false;
        public Bestelling_bevestiging_form()
        {
            InitializeComponent();
        }

        private void titel1_Click(object sender, EventArgs e)
        {

        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            confirmatie = true;
            this.Close();
        }
    }
}
