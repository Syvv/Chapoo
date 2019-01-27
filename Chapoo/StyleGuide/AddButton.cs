using System.Windows.Forms;
using System.Drawing;

namespace StyleGuide
{
    public class AddButton : Button
    {
        public AddButton()
        {
            FlatStyle = FlatStyle.Flat;
            Size = new Size(50, 50);
            ForeColor = Color.FromArgb(15, 10, 10);
            this.Text = "+";
            Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
        }
    }
}
