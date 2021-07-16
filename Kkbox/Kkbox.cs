using CefSharp;
using CefSharp.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kkbox
{
    public partial class Kkbox : Form
    {
        public ChromiumWebBrowser browser;
        public Lyrics lyric;
        private string l;
        public Kkbox(Lyrics lyric)
        {
            InitializeComponent();
            InitBrowser();
            this.lyric = lyric;
        }

        private void Kkbox_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Kkbox_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                lyric.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("https://play.kkbox.com");
            Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (browser.IsBrowserInitialized)
            {
                l = browser.GetBrowser().MainFrame.GetSourceAsync().Result;
                if (l.Contains("lyrics_0"))
                {
                    lyric.lblLyrics.Text = string.Join("\n", new Regex("(?<=<li id=\"lyrics_\\d+\" ng-repeat=\"lyric in lyrics\" class=\"active\"> <a ng-click=\"seekByLyrics\\(lyric.start_time\\)\">).*?(?=</a> </li>)").Matches(l).Cast<Match>().Select(m => m.Value).ToArray());
                }
            }
        }
    }
}
