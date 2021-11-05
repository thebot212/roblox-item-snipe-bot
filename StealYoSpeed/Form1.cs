using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StealYoSpeed
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEFKIDS";
            settings.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_4) AppleWebKit/605.1.15 (KHTML, like Gecko) Mobile/9B176 ROBLOX iOS App 2.445.410643 Hybrid RobloxApp/2.445.410643 (GlobalDist; AppleAppStore)";
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("about:blank");
            // Add it to the form and fill it to the form window.
            contain_browser.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
        }

        public Form1()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void button_enterid_Click(object sender, EventArgs e)
        {
            list_item.Items.Add(input_name.Text + "     [" + input_id.Text + "]     {R$" + input_price.Text + "}");
            Save.SaveInfo("Assets", input_name.Text + "     [" + input_id.Text + "]     {R$" + input_price.Text + "}", false);
            Globals.Print("Item Added [" + input_name.Text + "] for R$" + input_price.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string line in Save.GetInfo("Assets"))
            {
                list_item.Items.Add(line);
                Globals.Print(line);
            }
            Globals.Print("Loaded Assets");

            Thread t2 = new Thread(delegate ()
            {
                while (true)
                {
                    if (Globals.enable)
                    {
                        try
                        {
                            foreach (string item in list_item.Items)
                            {
                                string name = item.Split('[')[0];
                                string id = item.Split('[')[1].Split(']')[0];
                                string price = item.Split('{')[1].Replace("R", "").Replace("$", "").Replace("}", "");
                                if (BOT.CheckAsset(name, id, price))
                                {
                                    chromeBrowser.Load("https://www.roblox.com/catalog/" + id);
                                    Thread.Sleep(2000);

                                    var script = @"
function checkPrice(){
    var tobe = " + price + @"
    var rprice = document.getElementsByClassName('text-robux-lg wait-for-i18n-format-render')[0].innerText;
    var price = rprice.replaceAll(',', '');
    if(price <= tobe){
        document.getElementsByClassName('btn-fixed-width-lg btn-growth-lg PurchaseButton')[0].innerText = 'Fuck Kids';
        document.getElementsByClassName('btn-fixed-width-lg btn-growth-lg PurchaseButton')[0].click();
        document.getElementById('confirm-btn').click();
    }
}
checkPrice();


";
                                    chromeBrowser.ExecuteScriptAsync(script);
                                    Globals.buylist.Remove(name + "," + id);
                                }
                            }
                        }
                        catch(Exception es) { }
                    }
                    Thread.Sleep(100);
                }
            });
            t2.Start();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            Save.RemoveInfo("Assets", list_item.Items[list_item.SelectedIndex].ToString());
            list_item.Items.RemoveAt(list_item.SelectedIndex);
        }

        private void input_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            Globals.enable = !Globals.enable;
            if (!Globals.enable)
            {
                Globals.console = "";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
            Environment.Exit(0);
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            status.Text = Globals.enable.ToString().ToUpper();
            console.Text = Globals.console;

            list_buy.Items.Clear();
            foreach(string asset in Globals.buylist)
            {
                list_buy.Items.Add(asset);
            }
        }

        private void console_TextChanged(object sender, EventArgs e)
        {
            console.SelectionStart = console.Text.Length;
            console.ScrollToCaret();
        }

        private void login_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://www.roblox.com/login");
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Cef.GetGlobalCookieManager().DeleteCookies();
            chromeBrowser.Load("https://www.roblox.com/login");
        }
    }
}
