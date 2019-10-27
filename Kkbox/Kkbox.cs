using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Text.RegularExpressions;

namespace Kkbox
{
    public partial class Kkbox : Form
    {
        public ChromiumWebBrowser browser;
        public Label lyric;
        private string l;
        public Kkbox(Lyric lyric)
        {
            InitializeComponent();
            InitBrowser();

            this.lyric = lyric.lblLyric;
        }
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("play.kkbox.com");
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
                    l = new Regex("(?<=<li id=\"lyrics_\\d+\" ng-repeat=\"lyric in lyrics\" class=\"active\"> <a ng-click=\"seekByLyrics\\(lyric.start_time\\)\">).*?(?=</a> </li>)").Match(l) + "";
                    lyric.Text = l;
                }
            }
        }
    }
}
