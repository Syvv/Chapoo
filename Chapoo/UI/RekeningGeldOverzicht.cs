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
using Logica;
using DataAdaptor;

namespace UI
{
    public partial class RekeningGeldOverzicht : UserControl
    {
        private RekeningModel rekening { get; set; }
        private DAOFactory Factory;
        public RekeningGeldOverzicht(RekeningModel rekening, DAOFactory factory)
        {
            InitializeComponent();
            this.rekening = rekening;
            this.Factory = factory;
            PrijzenWeergeven();
        }
        private void PrijzenWeergeven()
        {
            OutTotaalBedrag.Text = string.Format("€ {0:F2} ", rekening.Totaalbedrag);
            OutBtw21.Text = string.Format("€ {0:F2} ", rekening.Btw21);
            OutBtw6.Text = string.Format("€ {0:F2}", rekening.Btw6);
            OutFooi.Text = string.Format("€ {0:F2}", rekening.Fooi);
        }

        private void BtnOpmerking_Click(object sender, EventArgs e)
        {
            string opmerking = rekening.Opmerking;
            new RekeningOpmerkingForm(ref opmerking).ShowDialog();//kan niet kloppen
            this.rekening.Opmerking = opmerking;
        }

        private void BtnFooi_Click(object sender, EventArgs e)
        {
            new FooiToevoegen(this.rekening, Factory).Show();
        }
    }
}
