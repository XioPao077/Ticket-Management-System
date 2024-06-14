using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CS311_22_23
{
    public partial class frmAccounts : Form
    {
        private string username;
        public static frmAccounts formAccInstance;
        public frmAccounts(string username)
        {
            InitializeComponent();
            this.username = username;
            formAccInstance = this;
        }

        public frmAccounts(){}

        //create object using class 
        Class1 accounts = new Class1("DESKTOP-6H3H64O\\SQLEXPRESS", "CS3112022", "tampos", "1234");

        private void frmAccounts_Load(object sender, EventArgs e)
        {
                loadData();
        }
        private void loadData()
        {
            try 
            { 
            DataTable dt = accounts.GetData("SELECT userName,passWord,userType,status,createdBy FROM tblaccounts WHERE userName <>'" + username + "'ORDER BY userName");
            dataGridView1.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Accounts Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = accounts.GetData("SELECT userName,passWord,userType,status,createdBy FROM tblaccounts WHERE userName <>'" + username + 
                    "'AND userName LIKE '%"+ textSearch.Text + "%'OR userType LIKE '%" + textSearch.Text + "%'ORDER BY userName");
                dataGridView1.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Text Search, Text Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddaccount addaccount = new frmAddaccount(username);
            addaccount.Show();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string editUsername,editPassword, editUsertype, editStatus;
            editUsername = dataGridView1.Rows[rowSelected].Cells[0].Value.ToString();
            editPassword = dataGridView1.Rows[rowSelected].Cells[1].Value.ToString();
            editUsertype = dataGridView1.Rows[rowSelected].Cells[2].Value.ToString();
            editStatus = dataGridView1.Rows[rowSelected].Cells[3].Value.ToString();
            frmUpdateaccount updateaccount = new frmUpdateaccount(editUsername,editPassword,editUsertype,editStatus,username);
            updateaccount.Show();
        }
        private int rowSelected;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            rowSelected = dataGridView1.CurrentCell.RowIndex;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 1 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            frmAccounts_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to DELETE? data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    accounts.executeSQL("DELETE FROM tblaccounts WHERE userName = '" + dataGridView1.Rows[rowSelected].Cells[0].Value.ToString() + "'");
                    if (accounts.rowAffected > 0)
                    {
                        MessageBox.Show("Account Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        accounts.executeSQL("INSERT INTO tblDeleteLogs VALUES('" + DateTime.Now.ToString("dd-MM-yyyy") + "' , '" + DateTime.Now.ToLongTimeString()+
                            "', 'Accounts Management' , '" + dataGridView1.Rows[rowSelected].Cells[0].Value.ToString() + "' , '" + username + "')");
                        btnRefresh_Click(sender,e);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
