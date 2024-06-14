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
    public partial class frmAddticket : Form
    {
        private string createdby;
        private int errorCount;
        public frmAddticket(string createdby)
        {
            InitializeComponent();
            this.createdby = createdby;
        }
        //create object using class 
        Class1 addTicket = new Class1("DESKTOP-6H3H64O\\SQLEXPRESS", "CS3112022", "tampos", "1234");
        //errorCounter
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
        //validation
        private void validateDetails()
        {
            if (txtDetails.Text == "")
            {
                errorProvider1.SetError(txtDetails, "Please give us context about the problem");
            }
            else
            {
                errorProvider1.SetError(txtDetails, "");
            }
        }
        private void validateProblem()
        {
            if (cmbProblem.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbProblem, "Please Specify Type of the Problem");
            }
            else
            {
                errorProvider1.SetError(cmbProblem, "");
            }
        }
        private void frmAddticket_Load(object sender, EventArgs e)
        {
                txtTicketNum.Text = DateTime.Now.ToString("yyMMddHHmmss");
        }
        //custom buttons
        private void btnExit_Click(object sender, EventArgs e)
        {
            txtTicketNum.Clear();
            cmbProblem.SelectedIndex = -1;
            txtDetails.Clear();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
                errorCount = 0;
                errorProvider1.Clear();
                cmbProblem.SelectedIndex = -1;
                txtDetails.Clear();
        }
        //Main Function
        private void btnSave_Click(object sender, EventArgs e)
        {
            errorCount = 0;
            errorProvider1.Clear();
            validateDetails();
            validateProblem();
            countError();
            if(errorCount == 0)
            {
                    try
                    {
                        DialogResult answer = MessageBox.Show("Are you sure of the necessary details you provided?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (answer == DialogResult.Yes)
                        {
                            addTicket.executeSQL("INSERT INTO tblTickets(ticketNumber,problem,details,status,date,time,createdBy)" +
                                " VALUES ('" + txtTicketNum.Text + "','" + cmbProblem.Text + "','" + txtDetails.Text + "', 'PENDING' , '" + DateTime.Now.ToString("dd-MM-yyyy") +
                                "','" + DateTime.Now.ToLongTimeString() + "','" + createdby + "')");
                        }
                        if (addTicket.rowAffected > 0)
                        {
                            MessageBox.Show("New Ticket Filed Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            frmTickets.frmTckt.btnRefresh_Click(sender, e);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Error on Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
    }
}
