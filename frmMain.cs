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

namespace CS311_22_23
{
    public partial class frmMain : Form
    {
        private string username, usertype;
        public frmMain(string username, string usertype)
        {
            InitializeComponent();
            label1.Text = "Username: " + username;
            label2.Text = "User Type: " + usertype;
            this.username = username;
            this.usertype = usertype;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void frmMain_Load(object sender, EventArgs e)
        {
            if(usertype == "USER")
            {
                btnAccounts.Enabled = false;
                btnAccounts.Visible = false;
                btnEquip.Enabled = false;
                btnEquip.Visible = false;
                btnTickets.Enabled = true;
                btnAbout.Enabled = true;
                btnSettings.Enabled = true;
                BtnReports.Visible = false;
                BtnReports.Enabled = false;
                btnLogout.Enabled = true;
            }
            else if(usertype == "TECHNICAL")
            {
                btnAccounts.Enabled = false;
                btnAccounts.Visible = false;
                btnEquip.Enabled = true;
                btnTickets.Enabled = true;
                btnAbout.Enabled = true;
                btnSettings.Enabled = true;
                BtnReports.Enabled = true;
                btnLogout.Enabled = true;
            }
            else
            {
                btnAccounts.Enabled = true;
                btnEquip.Enabled = true;
                btnTickets.Enabled = true;  
                btnAbout.Enabled = true;
                btnSettings.Enabled = true;
                BtnReports.Enabled = true;
                btnLogout.Enabled = true;

            }
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogIN login = new frmLogIN();
            login.ShowDialog();
        }


        private void btnAccounts_Click(object sender, EventArgs e)
        {
            frmAccounts accounts = new frmAccounts(username);
            accounts.MdiParent = this;
            accounts.Show();
            accounts.BringToFront();
        }
        private void btnEquip_Click(object sender, EventArgs e)
        {
            frmEquipment equip = new frmEquipment(username);
            equip.MdiParent = this;
            equip.Show();
            equip.BringToFront();
        }
        private void btnTickets_Click(object sender, EventArgs e)
        {
            frmTickets ticket = new frmTickets(username,usertype);
            ticket.MdiParent = this;
            ticket.Show();
            ticket.BringToFront();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure you want to close the application? \n all changes you have made might not be saved.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
