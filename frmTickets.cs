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
    public partial class frmTickets : Form
    {
        public static frmTickets frmTckt;
        private string username,usertype;
        public frmTickets(string username, string usertype)
        {
            InitializeComponent();
            this.username = username;
            this.usertype = usertype;
            frmTckt = this;
        }
        //create object using class 
        Class1 tickets = new Class1("DESKTOP-6H3H64O\\SQLEXPRESS", "CS3112022", "tampos", "1234");
        private int rowSelected;
        //Data Selection
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            rowSelected = dataGridView1.CurrentCell.RowIndex;
        }
        private void frmTickets_Load(object sender, EventArgs e)
        {
            if (usertype == "USER")
            {
                try
                {
                    DataTable dt = tickets.GetData("SELECT ticketNumber,problem,details,date,time,status FROM tblTickets WHERE createdBy = '" + username + "' ORDER BY ticketNumber ");
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[2].Visible = false;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on Tickets Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(usertype == "TECHNICAL")
            {
                try
                {
                    DataTable dt = tickets.GetData("SELECT ticketNumber,problem,date,time,status FROM tblTickets WHERE assignedTo = '" + username + "' ORDER BY ticketNumber ");
                    dataGridView1.DataSource = dt;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on Tickets Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    DataTable dt = tickets.GetData("SELECT ticketNumber,problem,date,time,status FROM tblTickets ORDER BY ticketNumber ");
                    dataGridView1.DataSource = dt;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on Tickets Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddticket addticket = new frmAddticket(username);
            addticket.Show();
        }
        public void btnRefresh_Click(object sender, EventArgs e)
        {
            frmTickets_Load(sender, e);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
 
            try
            {
                if(dataGridView1.Rows[rowSelected].Cells[5].Value.ToString()== "COMPLETED")
                {
                    MessageBox.Show("Ticket cannot be deleted for it is already COMPLETED", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult answer = MessageBox.Show("Are you sure you want to DELETE? data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (answer == DialogResult.Yes)
                    {
                        tickets.executeSQL("DELETE FROM tblTickets WHERE ticketNumber = '" + dataGridView1.Rows[rowSelected].Cells[0].Value.ToString() + "'");
                        if (tickets.rowAffected > 0)
                        {
                            MessageBox.Show("Ticket Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tickets.executeSQL("INSERT INTO tblDeleteLogs VALUES('" + DateTime.Now.ToString("dd-MM-yyyy") + "' , '" + DateTime.Now.ToLongTimeString() +
                                "', 'Equipments Management' , '" + dataGridView1.Rows[rowSelected].Cells[0].Value.ToString() + "' , '" + username + "')");
                            btnRefresh_Click(sender, e);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[rowSelected].Cells[5].Value.ToString() == "PENDING")
            {
                string ticketNumber, EditProblem, EditDetails;
                ticketNumber = dataGridView1.Rows[rowSelected].Cells[0].Value.ToString();
                EditProblem = dataGridView1.Rows[rowSelected].Cells[1].Value.ToString();
                EditDetails = dataGridView1.Rows[rowSelected].Cells[2].Value.ToString();
                frmUpdateticket addticket = new frmUpdateticket(ticketNumber, EditProblem, EditDetails);
                addticket.Show();
            }
            else
            {
                MessageBox.Show("Ticket is already COMPLETED", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //search
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = tickets.GetData("SELECT ticketNumber,problem,date,time,status FROM tblTickets WHERE createdBy ='"+ username +"'AND ticketNumber LIKE '%" + textSearch.Text + "%'OR problem LIKE '%"
                        + textSearch.Text + "%'ORDER BY ticketNumber");
                dataGridView1.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Text Search, Text Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    }
