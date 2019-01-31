
using System.Windows.Forms;
using System.Drawing;

namespace StyleGuide
{
    public class CommentIcon : Button
    {
        public CommentIcon()
        {
            FlatStyle = FlatStyle.Flat;
            BackgroundImage = Properties.Resources.comment;
            Size = new Size(20, 30);
            this.FlatAppearance.BorderSize = 0;
            ForeColor = Color.FromArgb(255, 255, 255);
            if (this.BackgroundImage == null)
                return;
            var pic = new Bitmap(this.BackgroundImage, new Size(this.Width, this.Height));
            this.BackgroundImage = pic;
            Text = " ";
        }
    }
}
