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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            //Assumed login is correct
            User temp;
            if(BedieningRAD.Checked)
            {
                temp = new User(UsernameInput.Text,'S');//Serveerder
                //create a new form and show that
                new Bediening_menu_form().Show();
            }else if(BarRAD.Checked)
            {
                temp = new User(UsernameInput.Text, 'B');//Bar
                new BarKeukenForm(temp).Show();
            }
            else
            {
                temp = new User(UsernameInput.Text, 'K');//Keuken
                new BarKeukenForm(temp).Show();
            }
            this.Hide();

        }

        private void btnBetalen_Click(object sender, EventArgs e)
        {
            new RekeningForm_Overzicht().Show();
            this.Hide();
        }
    }
}
