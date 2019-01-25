using System.Windows.Forms;
using System.Drawing;


namespace StyleGuide
{
    public class UitlogButton : Button
    {
        public UitlogButton()
        {
            FlatStyle = FlatStyle.Flat;
            Bitmap objBitmap = new Bitmap(Properties.Resources.logout, new Size(40, 40));
            Image image = objBitmap;
            BackgroundImage = image;
            Size = new Size(50, 50);
            ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
}
