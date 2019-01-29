using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Model;
using DataAdaptor;

namespace UI
{
    public partial class FooiToevoegen : UserControl
    {
        private DAOFactory factory;
        private RekeningModel Rekening;
        private RekeningService RekeningLogica;

        public FooiToevoegen(RekeningModel rekening, DAOFactory factory)
        {
            InitializeComponent();
            this.Rekening = rekening;
            this.factory = factory;
            this.RekeningLogica = new RekeningService(factory);

            BeginPrijzenWeeergeven();
        }

        private void RadioBtnFooiInTotaal_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtnFooiInTotaal.Checked)
            {
                lblOptieKeuze.Text = "Fooi zit in het totaalbedrag";
                LblOption.Text = "Totaalbedrag";                
            }
        }

        private void RadioBtnFooiLos_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBtnFooiLos.Checked)
            {
                lblOptieKeuze.Text = "Fooi los toevoegen";
                LblOption.Text = "Fooi:";

                LblFooi.Hide();
                OutFooi.Hide();
            }
        }
        private void BeginPrijzenWeeergeven()
        {
            OutBedrag.Text = string.Format("€ {0:F2} ", Rekening.Totaalbedrag);
            OutTotaalbedrag.Text = string.Format("€ {0:F2} ", Rekening.Totaalbedrag);
        }

        private void FooiToevoegen_Load(object sender, EventArgs e)
        {

        }
    }
}
