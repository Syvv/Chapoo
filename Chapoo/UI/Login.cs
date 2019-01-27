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
        Logica.Werknemer logicaWerknemer;

        public Login()
        {
            InitializeComponent();
            logicaWerknemer = new Logica.Werknemer();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Model.Werknemer werknemer = logicaWerknemer.CheckInlogGegevens(UsernameInput.Text,PasswordInput.Text);
            switch (werknemer.Functie)
            {
                case FunctieType.Bar:
                    throw new NotImplementedException("Volgende formulier nog niet geïmplementeerd");
                    break;
                case FunctieType.Keuken:
                    throw new NotImplementedException("Volgende formulier nog niet geïmplementeerd");
                    break;
                case FunctieType.Bediening:
                    new TafelOverzicht(werknemer).Show();
                    break;
            }
            this.Hide();

        }
    }
}
