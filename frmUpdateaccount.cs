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
    public partial class frmUpdateaccount : Form
    {
        private string username, password, usertype, status, editBy;
        private int errorCount;
        public frmUpdateaccount(string username, string password, string usertype, string status, string editBy)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.usertype = usertype;
            this.status = status;
            this.editBy = editBy;
        }
        //object from class
        Class1 updateAccount = new Class1("DESKTOP-6H3H64O\\SQLEXPRESS", "CS3112022", "tampos", "1234");

        private void validatePassword()
        {
            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Password cannot be empty!");
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
            if (cmbUsertype.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbUsertype, "Please Choose User type");
            }
            else
            {
                errorProvider1.SetError(cmbUsertype, "");
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            cmbUsertype.SelectedIndex = -1;
            errorCount = 0;
            errorProvider1.Clear();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbUsertype.SelectedIndex = -1;
            errorCount = 0;
            errorProvider1.Clear();
            this.Close();
        }

        //custom buttons

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

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword_TextChanged(sender, e);
        }
        private void frmUpdateaccount_Load(object sender, EventArgs e)
        {
            txtUsername.Text = username;
            txtPassword.Text = password;
           if(usertype == "ADMINISTRATOR")
            {
                cmbUsertype.SelectedIndex = 0;
            }
           else if( usertype == "TECHNICAL")
            {
                cmbUsertype.SelectedIndex = 1;
            }
            else
            {
                cmbUsertype.SelectedIndex = 2;
            }
           if(status == "ACTIVE")
            {
                rbactive.Checked = true;
            }
            else
            {
                rbInactive.Checked = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            errorCount = 0;
            errorProvider1.Clear();
            validateUsertype();
            validatePassword();
            countError();
            if(errorCount == 0)
            {
                string newStatus;
                if (rbactive.Checked)
                {
                    newStatus = rbactive.Text.ToUpper();
                }
                else
                {
                    newStatus = rbInactive.Text.ToUpper();
                }
                try
                {
                    DialogResult answer = MessageBox.Show("Are you sure you want to Update data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        updateAccount.executeSQL("UPDATE tblAccounts SET passWord = '" + txtPassword.Text + "', userType = '" + cmbUsertype.Text.ToUpper() +
                    "', status = '" + newStatus + "' ,lastUpdateBy= '" + editBy + "', dateUpdated = '" + DateTime.Now.ToString("dd-MM-yyyy") +
                    "' WHERE userName ='" + txtUsername.Text + "'");
                        if (updateAccount.rowAffected > 0)
                        {
                            MessageBox.Show("New Account Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            frmAccounts.formAccInstance.btnRefresh_Click(sender, e);
                         
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on Accounts Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        }
    }

