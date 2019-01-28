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
using DataAdaptor;

namespace UI
{
    public partial class Login : Form
    {
        Logica.Werknemer logicaWerknemer;
        DAOFactory Factory;

        public Login()
        {
            InitializeComponent();
            Factory = new DAOFactory();
            logicaWerknemer = new Logica.Werknemer(Factory);
        }

        public Login(DAOFactory factory)
        {
            InitializeComponent();
            Factory = factory;
            logicaWerknemer = new Logica.Werknemer(Factory);
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Model.Werknemer werknemer = logicaWerknemer.CheckInlogGegevens(UsernameInput.Text,PasswordInput.Text);
            switch (werknemer.Functie)
            {
                case Functie.Bar:
                    new BarKeukenForm(werknemer, Factory).Show();
                    break;
                case Functie.Keuken:
                    new BarKeukenForm(werknemer, Factory).Show();
                    break;
                case Functie.Bediening:
                    new TafelOverzicht(werknemer, Factory).Show();
                    break;
            }
            this.Hide();

        }
    }
}
