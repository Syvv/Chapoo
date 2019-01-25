
using System.Windows.Forms;
using System.Drawing;

namespace StyleGuide
{
    public class HomeButton : Button
    {
        public HomeButton()
        {
            FlatStyle = FlatStyle.Flat;
            BackgroundImage = Properties.Resources.home1;
            Size = new Size(50, 50);
            ForeColor = Color.FromArgb(255, 255, 255);
            if (this.BackgroundImage == null)
                return;
            var pic = new Bitmap(this.BackgroundImage, new Size(this.Width, this.Height));
            this.BackgroundImage = pic;
            Text = " ";
        }
    }
}
