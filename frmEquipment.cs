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
    public partial class frmEquipment : Form
    {
        public static frmEquipment frmEqp;
        private string username;
        public frmEquipment(string username)
        {
            InitializeComponent();
            this.username = username;
            frmEqp = this;
        }
        //create object using class 
        Class1 equipments = new Class1("DESKTOP-6H3H64O\\SQLEXPRESS", "CS3112022", "tampos", "1234");
        private void frmEquipment_Load(object sender, EventArgs e)
        { 
            try
            {
                DataTable dt = equipments.GetData("SELECT assetNumber,serialNumber,type,manufacturer,yearModel,Description,branch,department,status FROM tblEquipments ORDER BY assetNumber");
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[7].Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Data Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void btnRfrsh_Click(object sender, EventArgs e)
        {
            frmEquipment_Load(sender, e);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEquipment addEquip = new frmAddEquipment(username);
            addEquip.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string editAssetnumber, editSerialnumber, editType, editbranch, editStatus, editmanufacturer,editYearModel,editDescription,editDepartment;
            editAssetnumber = dataGridView1.Rows[rowSelected].Cells[0].Value.ToString();
            editSerialnumber = dataGridView1.Rows[rowSelected].Cells[1].Value.ToString();
            editType = dataGridView1.Rows[rowSelected].Cells[2].Value.ToString();
            editbranch = dataGridView1.Rows[rowSelected].Cells[6].Value.ToString();
            editStatus = dataGridView1.Rows[rowSelected].Cells[8].Value.ToString();
            editmanufacturer = dataGridView1.Rows[rowSelected].Cells[3].Value.ToString();
            editYearModel = dataGridView1.Rows[rowSelected].Cells[4].Value.ToString();
            editDescription = dataGridView1.Rows[rowSelected].Cells[5].Value.ToString();
            editDepartment = dataGridView1.Rows[rowSelected].Cells[7].Value.ToString();
            frmUpdateEquip updateEquip = new frmUpdateEquip(editAssetnumber, editSerialnumber, editType, editbranch, editStatus, username,
                editmanufacturer, editYearModel, editDescription, editDepartment);
            updateEquip.Show();
        }
        private int rowSelected;
 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult answer = MessageBox.Show("Are you sure you want to DELETE? data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.Yes)
                {
                    equipments.executeSQL("DELETE FROM tblEquipments WHERE assetNumber = '" + dataGridView1.Rows[rowSelected].Cells[0].Value.ToString() + "'");
                    if (equipments.rowAffected > 0)
                    {
                        MessageBox.Show("Equipment Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        equipments.executeSQL("INSERT INTO tblDeleteLogs VALUES('" + DateTime.Now.ToString("dd-MM-yyyy") + "' , '" + DateTime.Now.ToLongTimeString() +
                            "', 'Equipments Management' , '" + dataGridView1.Rows[rowSelected].Cells[0].Value.ToString() + "' , '" + username + "')");
                        btnRfrsh_Click(sender, e);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = equipments.GetData("SELECT assetNumber,serialNumber,type,branch ,status FROM tblEquipments WHERE assetNumber LIKE '%" + textSearch.Text + "%'OR type LIKE '%" + textSearch.Text + "%'ORDER BY assetNumber");
                dataGridView1.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error on Text Search, Text Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            rowSelected = dataGridView1.CurrentCell.RowIndex;
        }
    }
}
