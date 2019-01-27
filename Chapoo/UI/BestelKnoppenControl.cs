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
    public partial class BestelKnoppenControl : UserControl
    {
        public Bestelling Bestelling { get; set; }
        public BestellingService BestellingService { get; set; }
        public BestelKnoppenControl(Bestelling bestelling)
        {
            InitializeComponent();
            this.Bestelling = bestelling;
        }
        public BestelKnoppenControl()
        {
            InitializeComponent();
        }
        private void btnVerstuur_Click(object sender, EventArgs e)
        {
            BestellingService = new BestellingService();
            BestellingService.InsertBestelling(Bestelling);
        }
    }
}
