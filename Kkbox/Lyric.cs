using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kkbox
{
    public partial class Lyric : Form
    {
        [DllImport("user32.dll")]
        public static extern uint
            SetWindowLong(IntPtr h, int n, uint x);

        public Lyric()
        {
            InitializeComponent();
            SetWindowLong(Handle, -20, 0x20 | 0x80000);
            new Kkbox(this).Show();
        }

        private void LblLyric_SizeChanged(object sender, EventArgs e)
        {
            if (lblLyric.Width > 0 && lblLyric.Height > 0)
            {
                lblLyric.Left = ClientRectangle.Width / 2 - lblLyric.Width / 2;
                Height = lblLyric.Height;
            }
        }

        private void Lyric_Load(object sender, EventArgs e)
        {
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, lblLyric.Height);
            Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - Height * 2);
            lblLyric.Left = ClientRectangle.Width / 2 - lblLyric.Width / 2;
        }

        private void Lyric_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
            }
        }
    }
}
