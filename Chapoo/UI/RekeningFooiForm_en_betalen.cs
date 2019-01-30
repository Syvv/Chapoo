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
        private int BestellingsId { get; set; }
        public RekeningFooiForm_en_betalen(RekeningModel Rekening, int BestellingsId)
        {
            InitializeComponent();
            this.Rekening = Rekening;
            this.BestellingsId = BestellingsId;
            OpenenUserControlFooiToevoegen();
        }
        
        private void OpenenUserControlFooiToevoegen()
        {
            Form = new FooiToevoegen(Rekening, BestellingsId);
            pnlMain.Controls.Add(this.Form);
        }
    }
}
