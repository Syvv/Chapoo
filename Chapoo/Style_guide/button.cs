using System.Windows.Forms;
using System.Drawing;

namespace Styleguide
{
    public class BaseButton : Button
    {
        public BaseButton()
        {
            FlatStyle = FlatStyle.Flat;
            ForeColor = Color.FromArgb(0, 0, 0);
            Size = new Size(100, 30);
        }
    }
}