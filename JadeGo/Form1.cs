using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace JadeGo
{
    public partial class Form1 : Form
    {
        private bool allowHttpPages = false;
        private enum SearchEngine
        {
            Google,
            Bing,
            DuckDuckGo
        }
        private SearchEngine selectedSearchEngine = SearchEngine.Google;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string name, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public string path;

        public void ReadWriteINIfile(string inipath)
        {
            path = inipath;
        }
        public void WriteINI(string name, string key, string value)
        {
            WritePrivateProfileString(name, key, value, this.path);
        }
        public string ReadINI(string name, string key)
        {
            StringBuilder sb = new StringBuilder(255);
            int ini = GetPrivateProfileString(name, key, "", sb, 255, this.path);
            return sb.ToString();
        }


        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            
            InitializeAsync();

            ReadWriteINIfile("./config.ini");

            // Get The saved search engine config
            string engineFromIni = ReadINI("SearchEngineConfig", "engine") == "" ? "Google" : ReadINI("SearchEngineConfig", "engine");

            webViewMain.NavigationStarting += EnsureHttps;

            Reload_Anim_label.Hide();

            selectedSearchEngine = (SearchEngine)Enum.Parse(typeof(SearchEngine), engineFromIni);
            selectSearchEngineToolStripMenuItem.Text = "Search Engine ("+engineFromIni+")";
            toolStripMenuItem3.Text = (webViewMain.ZoomFactor * 100).ToString();
        }



        private void Form_Resize(object sender, EventArgs e)
        {
            webViewMain.Size = this.ClientSize - new System.Drawing.Size(webViewMain.Location);
            //goButton.Left = this.ClientSize.Width - goButton.Width;
            //addressBar.Width = goButton.Left - addressBar.Left;
        }

        async void InitializeAsync()
        {
            await webViewMain.EnsureCoreWebView2Async(null);
            webViewMain.CoreWebView2.WebMessageReceived += UpdateAddressBar;

            await webViewMain.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            //await webViewMain.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");
        }

        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            textBox1.Text = uri;
            webViewMain.CoreWebView2.PostWebMessageAsString(uri);
        }

        public void Navigate(string url)
        {
            //MessageBox.Show("GO to " + url);
            if (webViewMain != null && webViewMain.CoreWebView2 != null)
            {
                var rawUrl = url;
                Uri uri = null;

                if (Uri.IsWellFormedUriString(rawUrl, UriKind.Absolute))
                {
                    uri = new Uri(rawUrl);
                }
                else if (!rawUrl.Contains(" ") && rawUrl.Contains("."))
                {
                    // An invalid URI contains a dot and no spaces, try tacking https://
                    uri = new Uri("https://" + rawUrl);
                }
                else
                {
                    // Otherwise treat it as a web search.
                    if (selectedSearchEngine == SearchEngine.Bing)
                    {
                        uri = new Uri("https://bing.com/search?q=" +
                        String.Join("+", Uri.EscapeDataString(rawUrl).Split(new string[] { "%20" }, StringSplitOptions.RemoveEmptyEntries)));
                    } else if (selectedSearchEngine == SearchEngine.DuckDuckGo)
                    {
                        uri = new Uri("https://duckduckgo.com/?q=" +
                        String.Join("+", Uri.EscapeDataString(rawUrl).Split(new string[] { "%20" }, StringSplitOptions.RemoveEmptyEntries)));
                    } else
                    {
                        uri = new Uri("https://google.com/search?q=" +
                        String.Join("+", Uri.EscapeDataString(rawUrl).Split(new string[] { "%20" }, StringSplitOptions.RemoveEmptyEntries)));
                    }
                    
                    
                }
                
                //MessageBox.Show("GO to " + uri.ToString());
                if (FixEnsureHttps(uri.ToString()))
                {
                    webViewMain.CoreWebView2.Navigate(uri.ToString());
                } else
                {
                    webViewMain.CoreWebView2.ExecuteScriptAsync($"alert('{url} is not an url')");

                }
                
            }
        }

        public void NavigateBack()
        {
            if (webViewMain.CoreWebView2.CanGoBack)
            {
                webViewMain.CoreWebView2.GoBack();
            }
        }

        public void NavigateForward()
        {
            if (webViewMain.CoreWebView2.CanGoForward)
            {
                webViewMain.CoreWebView2.GoForward();
            }
        }

        public void RefreshView()
        {
            webViewMain.CoreWebView2.Reload();
        }

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                if (!allowHttpPages)
                {
                    webViewMain.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                    args.Cancel = true;
                }
                
            }
        }

        bool FixEnsureHttps(string url)
        {
            if (url.StartsWith("https://") || url.StartsWith("http://")) {
                return true;
            }
            return false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("JadeGo\nby Harri Ahola\n2022.");
        }

        private void go_Click(object sender, EventArgs e)
        {
            Navigate(textBox1.Text);
        }

        private void back_Click(object sender, EventArgs e)
        {
            NavigateBack();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            NavigateForward();
        }

        private void webViewMain_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; //remove the ding sound
                Navigate(textBox1.Text);

            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; //remove the ding sound
            }
        }



        private void webViewMain_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            refresh.Hide();
            Reload_Anim_label.Show();
        }

        private void webViewMain_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            Reload_Anim_label.Hide();
            refresh.Show();
            
        }

        private void webViewMain_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            //MessageBox.Show("DEBUG: the webview is ready!");
        }

        private void allowHttpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (allowHttpPages)
            {
                allowHttpToolStripMenuItem.Text = "Allow Http";
                allowHttpPages = false;
                allowHttpToolStripMenuItem.ForeColor = Color.DarkGreen;
            } else
            {
                allowHttpPages = true;
                allowHttpToolStripMenuItem.Text = "Disallow http";
                allowHttpToolStripMenuItem.ForeColor = Color.Red;
            }
        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedSearchEngine = SearchEngine.Google;
            selectSearchEngineToolStripMenuItem.Text = "Search Engine (Google)";
            WriteINI("SearchEngineConfig", "engine", "Google");
        }

        private void duckDuckGoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedSearchEngine = SearchEngine.DuckDuckGo;
            selectSearchEngineToolStripMenuItem.Text = "Search Engine (DuckDuckGo)";
            WriteINI("SearchEngineConfig", "engine", "DuckDuckGo");
        }

        private void bingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedSearchEngine = SearchEngine.Bing;
            selectSearchEngineToolStripMenuItem.Text = "Search Engine (Bing)";
            WriteINI("SearchEngineConfig", "engine", "Bing");
        }

        private void selectSearchEngineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webViewMain.ZoomFactor += 0.1;
            toolStripMenuItem3.Text = (webViewMain.ZoomFactor * 100).ToString();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webViewMain.ZoomFactor -= 0.1;
            toolStripMenuItem3.Text = (webViewMain.ZoomFactor * 100).ToString();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
