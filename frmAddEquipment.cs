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
    public partial class frmAddEquipment : Form
    {
        public static frmAddEquipment AddEquipInstance;
        private string createdby;
        private int errorCount;
        public frmAddEquipment(string createdby)
        {
            InitializeComponent();
            this.createdby = createdby;
        }
        //create object using class 
        Class1 AddEquip = new Class1("DESKTOP-6H3H64O\\SQLEXPRESS", "CS3112022", "tampos", "1234");
        //validation 
        private void validateAssetNum()
        {
            DataTable dt = AddEquip.GetData("SELECT * FROM tblEquipments WHERE assetNumber = '" + txtAsset.Text + "'");
            if (txtAsset.Text == "")
            {
                errorProvider1.SetError(txtAsset, "Asset Number cannot be empty");
            }
            else if (dt.Rows.Count > 0)
            {
                errorProvider1.SetError(txtAsset, "Asset Number Already Exists");
            }
            else
            {
                errorProvider1.SetError(txtAsset, "");
            }
        }
        private void validateSerialNum()
        {
            DataTable dt = AddEquip.GetData("SELECT * FROM tblEquipments WHERE serialNumber = '" + txtSerial.Text + "'");
            if (txtAsset.Text == "")
            {
                errorProvider1.SetError(txtSerial, "Serial Number cannot be empty");
            }
            else if (dt.Rows.Count > 0)
            {
                errorProvider1.SetError(txtSerial, "Serial Number Already Exists");
            }
            else
            {
                errorProvider1.SetError(txtSerial, "");
            }
        }
        private void validateYear()
        {
            if (txtYearModel.Text == "")
            {
                errorProvider1.SetError(txtYearModel, "Please Enter Year model");
            }
            else if(int.Parse(txtYearModel.Text) < 1990 || int.Parse(txtYearModel.Text) > 3000)
            {
                errorProvider1.SetError(txtYearModel, "Year should not be less than 1990 or more than 3000");
            }
            else
            {
                errorProvider1.SetError(txtYearModel, "");
            }
        }
        private void validateManufacturer()
        {
            if (txtManufacturer.Text == "")
            {
                errorProvider1.SetError(txtManufacturer, "Please Enter Manufacturer");
            }
            else
            {
                errorProvider1.SetError(txtManufacturer, "");
            }
        }
        private void validateEquiptype()
        {
            if (cmbType.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbType, "Please Choose Equipment type");
            }
            else
            {
                errorProvider1.SetError(cmbType, "");
            }
        }
        private void validateBranch()
        {
            if (cmbBranch.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbBranch, "Please Indicate Branch");
            }
            else
            {
                errorProvider1.SetError(cmbBranch, "");
            }
        }
        private void validateDepartment()
        {
            if (cmbDepartment.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbDepartment, "Please Indicate Department");
            }
            else
            {
                errorProvider1.SetError(cmbDepartment, "");
            }
        }
        private void txtYearModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                errorProvider1.SetError(txtYearModel, "Input only accepts numbers");
            }
            else
            {
                errorProvider1.SetError(txtYearModel, "");
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            errorCount = 0;
            errorProvider1.Clear();
            validateAssetNum();
            validateSerialNum();
            validateBranch();
            validateYear();
            validateManufacturer();
            validateEquiptype();
            validateDepartment();
            countError();
            if(errorCount == 0)
            {
                try
                {
                    DialogResult answer = MessageBox.Show("Are you sure you want to save Equipment?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        AddEquip.executeSQL("INSERT INTO tblEquipments (assetNumber,serialNumber,type,manufacturer,yearModel,description,branch,department,status,createdBy,dateCreated) VALUES ('" + txtAsset.Text +
                       "','" + txtSerial.Text + "','" + cmbType.Text + "','" + txtManufacturer.Text + "','" + txtYearModel.Text + "','" + txtDescription.Text + "','" + cmbBranch.Text + "','" + cmbDepartment.Text + 
                       "', 'WORKING' ,'" + createdby + "','" + DateTime.Now.ToString("dd-MM-yyyy") + "')");
                        if (AddEquip.rowAffected > 0)
                        {
                            MessageBox.Show("New Equipment Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            frmEquipment.frmEqp.btnRfrsh_Click(sender, e);
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
            errorCount = 0;
            errorProvider1.Clear();
            txtAsset.Clear();
            txtSerial.Clear();
            txtDescription.Clear();
            txtManufacturer.Clear();
            txtYearModel.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
