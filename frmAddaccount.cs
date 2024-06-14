using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_22_23
{
    public partial class frmAddaccount : Form
    {
        private string createdby;
        private int errorCount;
        public frmAddaccount(string createdby)
        {
            InitializeComponent();
            this.createdby = createdby;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
        //create object using class 
        Class1 Addaccount = new Class1("DESKTOP-6H3H64O\\SQLEXPRESS", "CS3112022", "tampos", "1234");
        //validation
        private void validateUsername()
        {
            DataTable dt = Addaccount.GetData("SELECT * FROM tblAccounts WHERE userName = '" + txtUsername.Text + "'");
            if(txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Please Enter Username");
            }
            else if(txtUsername.TextLength < 6)
            {
                errorProvider1.SetError(txtUsername, "Username should be at least 6 characters");
            }
            else if(dt.Rows.Count > 0)
            {
                errorProvider1.SetError(txtUsername, "Username Already Exists");
            }
            else
            {
                errorProvider1.SetError(txtUsername, "");
            }
        }
        private void validatePassword()
        {
            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Password cannot be Empty");
            }
            else if (txtPassword.TextLength < 6)
            {
                errorProvider1.SetError(txtPassword, "Password should be at least 6 characters");
            }
            else
            {
                errorProvider1.SetError(txtPassword, "");
            }
        }
        private void validateUsertype()
        {
            if(cmbUsertype.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbUsertype, "Please Choose User type");
            }
            else
            {
                errorProvider1.SetError(cmbUsertype, "");
            }
        }
        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword_TextChanged(sender, e);
        }
        public void countError()
        {
            errorCount = 0;
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                if (errorProvider1.GetError(c) != "")
                {
                    errorCount++;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            errorCount = 0;
            errorProvider1.Clear();
            validateUsername();
            validatePassword();
            validateUsertype();
            countError();
            if(errorCount == 0)
            {
                try
                {
                    DialogResult answer = MessageBox.Show("Are you sure you want to save data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(answer == DialogResult.Yes)
                    {
                        Addaccount.executeSQL("INSERT INTO tblAccounts (userName,passWord,userType,status,createdBy,dateCreated) VALUES ('" + txtUsername.Text +
                       "','" + txtPassword.Text + "','" + cmbUsertype.Text.ToUpper() + "', 'ACTIVE' ,'" + createdby + "','" +
                       DateTime.Now.ToString("dd-MM-yyyy") + "')");
                        if (Addaccount.rowAffected > 0)
                        {
                            MessageBox.Show("New Account Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            frmAccounts.formAccInstance.btnRefresh_Click(sender,e);
                        }
                    
                    }
                   
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbUsertype.SelectedIndex = -1;
            errorCount = 0;
            errorProvider1.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            cmbUsertype.SelectedIndex = -1;
            txtPassword.Clear();
            txtUsername.Clear();
            this.Close();
        }

    }
}
