using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Style_guide
{
    public partial class LogoutButton : UserControl
    {
        public LogoutButton()
        {
            InitializeComponent();
            //FlatStyle = FlatStyle.Flat;
            BackgroundImage = Properties.Resources.logout;
            btnLogout.Size = new Size(50, 50);
            btnLogout.ForeColor = Color.FromArgb(255, 255, 255);
            if (btnLogout.BackgroundImage == null)
                return;
            var pic = new Bitmap(btnLogout.BackgroundImage, new Size(btnLogout.Width, btnLogout.Height));
            btnLogout.BackgroundImage = pic;
            Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
