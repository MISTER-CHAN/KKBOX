using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Kkbox
{
    public partial class Lyric : Form
    {
        public Lyric()
        {
            InitializeComponent();
            new Kkbox(this).Show();
            SetWindowLong(Handle, -20, 0x20 | 0x80000);
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
                SetWindowLong(Handle, -20, 0x20 | 0x80000);
            }
        }

        [DllImport("user32.dll")]
        public static extern uint SetWindowLong(IntPtr h, int n, uint x);
    }
}
