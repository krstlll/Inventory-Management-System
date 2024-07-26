using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApp10.Controls;

namespace WindowsFormsApp10
{
    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        Controls.UserControlInventory ucInventory = new Controls.UserControlInventory();
        Controls.UserControlAddItem ucAdd = new Controls.UserControlAddItem();
        Controls.UserControlHelpMenu ucHelpMenu = new Controls.UserControlHelpMenu();

        public MainForm()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(OnMouseDown);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucAdd);
            ucAdd.Dock = DockStyle.Fill;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucInventory);
            ucInventory.Dock = DockStyle.Fill;
            ucInventory.ReloadData();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucHelpMenu);
            ucHelpMenu.Dock = DockStyle.Fill;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // Implementation for button 4 if needed
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (ucInventory != null)
            {
                DataTable inventoryDataTable = ucInventory.GetInventoryDataTable();
                if (inventoryDataTable != null)
                {
                    UserControlInventorySummary ucSummary = new UserControlInventorySummary(inventoryDataTable);
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(ucSummary);
                    ucSummary.Dock = DockStyle.Fill;
                }
            }
        }
        

         private void guna2Panel5_Paint_2(object sender, EventArgs e)
        {
           
        }

        private void guna2Panel3_Paint(object sender, EventArgs e)
        {
            
        }

        private void panelMain_Paint(object sender, EventArgs e)
        {
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucAdd);
            ucAdd.Dock = DockStyle.Fill;
        }
    }
}
