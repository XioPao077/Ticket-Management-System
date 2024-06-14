using System;
using System.Data;
using System.Windows.Forms;

namespace CS311_22_23
{
    public partial class frmLogIN : Form
    {
        public frmLogIN()
        {
            InitializeComponent();
        }
        Class1 login = new Class1("DESKTOP-6H3H64O\\SQLEXPRESS", "CS3112022", "tampos", "1234");
        private void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                //create a datatable containing your SQL SELECT command 
                DataTable dt = login.GetData("SELECT * FROM tblaccounts WHERE username = '" + tbUsername.Text + "' AND password = '" + TbPassword.Text +
                    "'AND status = 'ACTIVE' ");
                // login Sucessful 
                if (dt.Rows.Count > 0)
                {
                   frmMain main = new frmMain(tbUsername.Text, dt.Rows[0].Field<string>("userType"));
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or password or account is inactive", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Login Button", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCLR_Click(object sender, EventArgs e)
        {
            try
            {
                tbUsername.Clear();
                TbPassword.Clear();
                cbShow.Checked = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Clear Button", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                TbPassword.PasswordChar = '\0';
            }
            else
            {
                TbPassword.PasswordChar = '*';
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            TbPassword_TextChanged(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToChar(e.KeyChar) == 13)
            {
                btnLogin_Click(sender,e);
            }
        }
    }
}
