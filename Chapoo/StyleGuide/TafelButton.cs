using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace StyleGuide
{
    public class TafelButton : Button
    {
        public TafelButton()
        {
            FlatStyle = FlatStyle.Flat;
            ForeColor = Color.FromArgb(192, 64, 0);
            Size = new Size(75, 75);
            UseVisualStyleBackColor = true;

            Text = "tafel";
        }
    }
}
