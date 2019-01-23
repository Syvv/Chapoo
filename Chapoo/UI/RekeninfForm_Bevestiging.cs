using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logica;
using Styleguide;

namespace UI
{
    public partial class RekeninfForm_Bevestiging : Style_guide.BaseFormMobile
    {
        public RekeninfForm_Bevestiging(int tafelnummer)
        {
            InitializeComponent();

            string tekst = ("tafel " +tafelnummer+ " is vrijgegeven");
            lblVrijgeven.Text = tekst;
            LblTafelnummer.Text = tafelnummer.ToString();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Bediening_menu_form form = new Bediening_menu_form();
            form.Show();
            this.Close();
        }

        private void homeButton2_Click(object sender, EventArgs e)
        {
            new Bediening_menu_form().Show();
            this.Close();
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            new Bediening_menu_form().Show();
            this.Close();
        }

        private void RekeninfForm_Bevestiging_Load(object sender, EventArgs e)
        {

        }
    }
}
