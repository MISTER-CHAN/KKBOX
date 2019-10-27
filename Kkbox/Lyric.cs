using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kkbox
{
    public partial class Lyric : Form
    {
        public Lyric()
        {
            InitializeComponent();
            new Kkbox(this).Show();
        }

        private void lblLyric_SizeChanged(object sender, EventArgs e)
        {
            if (lblLyric.Width > 0 && lblLyric.Height > 0)
            {
                lblLyric.Left = ClientRectangle.Width / 2 - lblLyric.Width / 2;
            }
        }

        private void lblLyric_DoubleClick(object sender, EventArgs e)
        {
            FormBorderStyle = 1 - FormBorderStyle;
        }

        private void Lyric_Load(object sender, EventArgs e)
        {
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, lblLyric.Height);
            Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - Height * 2);
            lblLyric.Left = ClientRectangle.Width / 2 - lblLyric.Width / 2;
        }
    }
}
