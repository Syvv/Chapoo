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
            char type;
            try
            {
                type = Logica.User.TestLoginInfo(UsernameInput.Text, PasswordInput.Text);
            }catch(Exception ex) when (ex is Model.NoSuchUserException || ex is DataMisalignedException)
            {
                MessageBox.Show(ex.Message, "Something was wrong",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Model.Werknemer user = new Werknemer(UsernameInput.Text,type);
            
            if(user.Type=='s')//Check which screen it has to show
            {
                //create a new form and show that
                new Bediening_menu_form().Show();
            }else if(user.Type=='b')
            {
                new BarKeukenForm(user).Show();
            }
            else
            {
                new BarKeukenForm(user).Show();
            }
            this.Hide();

        }
    }
}
