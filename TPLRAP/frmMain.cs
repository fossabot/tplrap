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
using CefSharp.WinForms.Internals;

namespace TPLRAP
{
    public partial class frmMain : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        public frmMain()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser("http://tplinkwifi.net/");
            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }
    }
}
