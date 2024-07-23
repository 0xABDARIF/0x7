using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using KeyAuth;
using System.Net;
using Protection;

namespace _0x7_Protector_GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Q3X8VE.C53ETA.a = "1";
            Q3X8VE.C53ETA.b = 1;
            IDText.Text = Properties.Settings.Default["user"].ToString();
            PassText.Text = Properties.Settings.Default["pass"].ToString();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public static void cfu()
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                string url = "https://pastebin.com/raw/2G8G5STC";
                WebClient xx = new WebClient();
                string content = xx.DownloadString(url);
                if (content.Contains("7"))
                {
                    Form f = new NewUpdate();
                    f.ShowDialog();
                    return;
                }
            }
            catch (Exception xxx) { MessageBox.Show(xxx.ToString()); }
        }
        private void LoginButton_Click_1(object sender, EventArgs e)
        {        
            api.KeyAuthApp.init();
            //api.KeyAuthApp.check();
            api.KeyAuthApp.login(IDText.Text, PassText.Text);
            if (api.KeyAuthApp.response.success)
            {
                if (savesession.Checked)
                {
                    Properties.Settings.Default["user"] = IDText.Text;
                    Properties.Settings.Default["pass"] = PassText.Text;
                    Properties.Settings.Default.Save();
                    IDText.Text = null;
                    MemoryStringEncryption.SecureStringInMemory(IDText.Text);
                    PassText.Text = null;
                    MemoryStringEncryption.SecureStringInMemory(PassText.Text);
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
                cfu();
                Hide();
                var g = new GUI();
                g.Show();
                return;
            }
            Hide();
            var err = new Err();
            err.msg = "You're not activated !, Contact me: Inx#0308";
            err.ShowDialog();
        }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            var H = new Help();
            H.ShowDialog();
        }
        private void DiscordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/users/550441121822539834");
        }
        private void TeleButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/x7C53");
        }
        private void EndButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void MPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                Opacity = 0.96;
                Cursor = Cursors.Hand;
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                Opacity = 0.98;
                Cursor = Cursors.Default;
            }
        }
    }
}
