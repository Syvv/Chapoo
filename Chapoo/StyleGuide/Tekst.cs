using System.Windows.Forms;
using System.Drawing;

namespace StyleGuide
{
    public class Tekst : Label
    {
        public Tekst()
        {
            FlatStyle = FlatStyle.Flat;
            Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
            ForeColor = Color.FromArgb(15, 10, 10);
            Text = " ";
        }
    }
}
