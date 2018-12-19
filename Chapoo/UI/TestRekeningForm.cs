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
using Logica;

namespace UI
{
    public partial class TestRekeningForm : Form
    {
        public TestRekeningForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBInvul.Text = RekeningLogica.PrijsOptellerMakkelijk().ToString();
        }
    }
}
