using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Kkbox
{
    public partial class Lyrics : Form
    {
        public Lyrics()
        {
            InitializeComponent();
            new Kkbox(this).Show();
            SetWindowLong(Handle, -20, 0x20 | 0x80000);
        }

        private void LblLyrics_SizeChanged(object sender, EventArgs e)
        {
            if (lblLyrics.Width > 0 && lblLyrics.Height > 0)
            {
                lblLyrics.Left = ClientRectangle.Width / 2 - lblLyrics.Width / 2;
                Height = lblLyrics.Height;
            }
        }

        private void Lyrics_Load(object sender, EventArgs e)
        {
            Size = new Size(Screen.PrimaryScreen.Bounds.Width, lblLyrics.Height);
            Location = new Point(0, Screen.PrimaryScreen.Bounds.Height - Height * 2);
            lblLyrics.Left = ClientRectangle.Width / 2 - lblLyrics.Width / 2;
        }

        private void Lyric_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                SetWindowLong(Handle, -20, 0x20 | 0x80000);
            }
        }

        [DllImport("user32.dll")]
        public static extern uint SetWindowLong(IntPtr h, int n, uint x);
    }
}
