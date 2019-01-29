using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class BarKeukenHeader : UserControl
    {
        public delegate void LogOut();
        LogOut logOut;
        public BarKeukenHeader(LogOut logOut)
        {
            InitializeComponent();
            this.logOut = logOut;
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            logOut();
        }
    }
}
