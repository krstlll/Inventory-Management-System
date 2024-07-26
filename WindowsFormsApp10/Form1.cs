using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(OnMouseDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void OnMouseDown(object sender, MouseEventArgs e) // Changed method name
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clear_button_un_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = " ";
        }

        private void clear_button_pass_Click(object sender, EventArgs e)
        {
            guna2TextBox2.Text = " ";
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            mainForm.Show();

            WindowState = FormWindowState.Minimized;

        }
    }
}
