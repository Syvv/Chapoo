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
using Logica;

namespace UI
{
    public partial class Login : Form
    {
        WerknemerService logicaWerknemer;
        DAOFactory Factory;
        
        public Login(DAOFactory factory)
        {
            InitializeComponent();
            Factory = factory;
            logicaWerknemer = new WerknemerService();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            WerknemerModel werknemer = null;
            try
            {
                werknemer = logicaWerknemer.CheckInlogGegevens(UsernameInput.Text,PasswordInput.Text, Factory);
            }catch(Exception ex) when (ex is DataMisalignedException || ex is NoSuchUserException || ex is System.Data.SqlClient.SqlException)
            {
                if(ex is System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("Er is iets foutgegaan bij het verbinding maken met de database!", "Er is iets fout gegaan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(ex.Message, "Er is iets fout gegaan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
