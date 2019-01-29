using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAdaptor;

namespace UI
{
    public partial class BarKeukenHeader : UserControl
    {
        public delegate void LogOutDelegate();
        LogOutDelegate logOut;
        public delegate void RefreshUIWithNewOrdersList(bool showOnlyCurrentOrders);
        RefreshUIWithNewOrdersList refresh;
        bool isKeuken;

        bool isShowingOnlyCurrentOrders = true;
        public BarKeukenHeader(LogOutDelegate logOut, RefreshUIWithNewOrdersList refresh, DAOFactory factory, bool isKeuken)
        {
            InitializeComponent();
            this.logOut = logOut;
            this.refresh = refresh;
            this.isKeuken = isKeuken;
            if(!isKeuken)
            {
                Headertext.Text = "Te bereiden drankjes in de Bar";
            }
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void Togglebtn_Click(object sender, EventArgs e)
        {
            isShowingOnlyCurrentOrders = !isShowingOnlyCurrentOrders;

            if(isShowingOnlyCurrentOrders)
            {
                Togglebtn.Text = "Bestellingen van vandaag laten zien";
                if(isKeuken)
                {
                    Headertext.Text = "Te bereiden gerechten in de Keuken";
                }
                else
                {
                    Headertext.Text = "Te bereiden drankjes in de Bar";
                }
            }
            else
            {
                Togglebtn.Text = "Te bereiden bestellingen laten zien";
                if (isKeuken)
                {
                    Headertext.Text = "Alle gerechten die vandaag besteld zijn";
                }
                else
                {
                    Headertext.Text = "Alle drankjes die vandaag besteld zijn";
                }
            }

            refresh(isShowingOnlyCurrentOrders);
        }
    }
}
