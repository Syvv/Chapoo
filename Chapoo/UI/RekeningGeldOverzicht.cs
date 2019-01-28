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

namespace UI
{
    public partial class RekeningGeldOverzicht : UserControl
    {
        private RekeningModel rekening;
        public RekeningGeldOverzicht(RekeningModel rekening)
        {
            InitializeComponent();
            this.rekening = rekening;
            PrijzenWeergeven();
        }
        private void PrijzenWeergeven()
        {
            OutTotaalBedrag.Text = string.Format("€ {0:F2} ", rekening.Totaalbedrag);
            OutBtw21.Text = string.Format("€ {0:F2} ", rekening.Btw21);
            OutBtw6.Text = string.Format("€ {0:F2}", rekening.Btw6);
            OutFooi.Text = string.Format("€ {0:F2}", rekening.Fooi);
        }
    }
}
