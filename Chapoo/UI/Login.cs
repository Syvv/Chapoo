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

namespace UI
{
    public partial class Login : Form
    {
        Logica.WerknemerService logicaWerknemer;

        public Login()
        {
            InitializeComponent();
            logicaWerknemer = new Logica.WerknemerService();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            /*
            Model.Werknemer werknemer = logicaWerknemer.CheckInlogGegevens(UsernameInput.Text,PasswordInput.Text);
            switch (werknemer.Functie)
            {
                case Functie.Bar:
                    new BarKeukenForm(werknemer).Show();
                    break;
                case Functie.Keuken:
                    new BarKeukenForm(werknemer).Show();
                    break;
                case Functie.Bediening:
                    new TafelOverzicht(werknemer).Show();
                    break;
            }
            this.Hide();
            */
        }
    }
}
