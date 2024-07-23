using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _0x7_Protector_GUI
{
    public partial class NewUpdate : Form
    {
        public NewUpdate()
        {
            InitializeComponent();
        }       
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void SkipUpdate_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void VisitDiscordServer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/bKQgcVW8fT");
        }
        private void NewUpdate_Load(object sender, EventArgs e)
        {
            Opacity = 0.98;
        }
        private void iLabel6_MouseDown(object sender, MouseEventArgs e)
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
