using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _0x7_Protector_GUI
{
    public partial class Finished : Form
    {
        public Finished()
        {
            InitializeComponent();
        }
        private void Finished_Load(object sender, EventArgs e)
        {
            Opacity = 0.98;        
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (GUI.Virt == true)
            {
                Environment.Exit(0);
            }
            Close();
        }
        private void BrowseFile_Click(object sender, EventArgs e)
        {
            if (ICore.Context.samePath == true)
                Process.Start(GUI.browseDir2);
            else
            Process.Start(GUI.browseDir);
            if (GUI.Virt == true)
            {
                Environment.Exit(0);
            }
            Close();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void MPanel_MouseDown_1(object sender, MouseEventArgs e)
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
