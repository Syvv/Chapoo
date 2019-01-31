using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Model;
using StyleGuide;

namespace UI
{
    public partial class RekeningFooiForm_en_betalen : BaseFormMobile
    {
        RekeningModel Rekening { get; set; }
        FooiToevoegen Form { get; set; }
        private WerknemerModel Werknemer { get; set; }
        private TafelModel Tafel { get; set; }
        private int BestellingsId { get; set; }
        public RekeningFooiForm_en_betalen(RekeningModel Rekening, WerknemerModel werknemer, TafelModel tafel, int BestellingsId)
        {
            InitializeComponent();
            this.Rekening = Rekening;
            this.Werknemer = werknemer;
            this.Tafel = tafel;
            this.BestellingsId = BestellingsId;
            Test();
        }
        public RekeningFooiForm_en_betalen(RekeningModel rekening, int bestellingId)
        {
            InitializeComponent();
            this.Rekening = rekening;
            this.BestellingsId = bestellingId;
            Test();
        }
        private void Test()
        {
            Form = new FooiToevoegen(Rekening, BestellingsId, this);
            pnlMain.Controls.Add(Form);
        }

        private void btnMenuOpnemen_Click(object sender, EventArgs e)
        {
            new BestellingOpnemenForm(Werknemer, Tafel).Show();
            this.Close();
        }
    }
}
