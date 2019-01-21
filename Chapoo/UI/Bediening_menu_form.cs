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
    public partial class Bediening_menu_form : Style_guide.BaseFormMobile
    {
        public Bestelling_opnemen_form Bestelling_Opnemen_Form;
        public Bediening_menu_form(Bestelling_opnemen_form bestelling_Opnemen_Form)
        {
            InitializeComponent();
            this.Bestelling_Opnemen_Form = bestelling_Opnemen_Form;
        }
        public Bediening_menu_form()
        {
            InitializeComponent();
        }

        private void Bediening_menu_form_Load(object sender, EventArgs e)
        {

        }

        private void baseButton1_Click(object sender, EventArgs e)
        {
            new Bestelling_opnemen_form().Show();
            this.Close();        
        }

        private void baseButton2_Click(object sender, EventArgs e)
        {
            new Bestelling_overzicht_form().ShowDialog();
        }

        private void baseButton3_Click(object sender, EventArgs e)
        {
            new RekeningForm_Overzicht().Show();
            this.Close();
        }
    }
}
