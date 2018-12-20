using System.Windows.Forms;
using System.Drawing;

namespace Style_guide
{
    public class HomeButton : Button
    {
        public HomeButton()
        {
            FlatStyle = FlatStyle.Flat;
            //Image = new Bitmap("../home.jpg");
            BackgroundImage = Image.FromFile("home.jpg");
            //ImageAlign = System.Drawing.ContentAlignment.TopRight;
        }
    }
}
