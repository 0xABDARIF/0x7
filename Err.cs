using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _0x7_Protector_GUI
{
    public partial class Err : Form
    {
        public Err()
        {
            InitializeComponent();
        }
        public string msg
        {
            get
            {
                return iLabel2.Text;
            }
            set
            {
                iLabel2.Text = value;
            }
        }
        private void Err_Load(object sender, EventArgs e)
        {
            Opacity = 0.98;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
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
