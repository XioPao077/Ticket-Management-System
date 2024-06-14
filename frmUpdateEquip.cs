using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS311_22_23
{
    public partial class frmUpdateEquip : Form

    {
        private string assetNum, serialNum, type, branch, status, editby, manufacturer, YearModel,Description,Department;
        private int errorCount;
        public frmUpdateEquip(string assetNum,string serialNum, string type,  string branch, string status, string editby, string manufacturer,string YearModel, string Description, string Department)
        {
            InitializeComponent();
            this.assetNum = assetNum;  
            this.serialNum = serialNum; 
            this.type = type;
            this.status = status;
            this.editby = editby;
            this.branch = branch;
            this.manufacturer = manufacturer;
            this.YearModel = YearModel;
            this.Description = Description;
            this.Department = Department;
        }
        //object from class
        Class1 updateEquip = new Class1("DESKTOP-6H3H64O\\SQLEXPRESS", "CS3112022", "tampos", "1234");
        private void validateSerialNum()
        {
            DataTable dt = updateEquip.GetData("SELECT * FROM tblEquipments WHERE assetNumber = '" + txtSerial.Text + "'");
            if (txtAsset.Text == "")
            {
                errorProvider1.SetError(txtSerial, "Serial Number is Required");
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
            else if (int.Parse(txtYearModel.Text) < 1990 || int.Parse(txtYearModel.Text) > 3000)
            {
                errorProvider1.SetError(txtYearModel, "Year should not be less than 1990 or more than 3000");
            }
            else
            {
                errorProvider1.SetError(txtYearModel, "");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
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
            else if (txtYearModel.Text.Length > 4 && e.KeyChar != (char)8)
            {
                e.Handled = true;
                errorProvider1.SetError(txtYearModel, "Year Input should not exceed 4 Digits");
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
            validateSerialNum();
            validateBranch();
            validateYear();
            validateManufacturer();
            validateEquiptype();
            validateDepartment();
            countError();
            if(errorCount == 0)
            {
                string newStatus;
                if (rbWorking.Checked)
                {
                    newStatus = rbWorking.Text.ToUpper();
                }
                else if (rbRepair.Checked)
                {
                    newStatus = rbRepair.Text.ToUpper();
                }
                else
                {
                    newStatus =rbRetired.Text.ToUpper();
                }
                try
                {
                    DialogResult answer = MessageBox.Show("Are you sure you want to Update Equipment?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        updateEquip.executeSQL("UPDATE tblEquipments SET serialNumber = '" + txtSerial.Text + "', type = '" + cmbType.Text.ToUpper() + "',manufacturer = '" + txtManufacturer.Text+
                            "',yearModel = '" + txtYearModel.Text + "',branch = '" + cmbBranch.Text + "',department = '" + cmbDepartment.Text + 
                            "', status = '" + newStatus + "' ,lastUpdateBy= '" + editby + "', lastUpdatedDate = '" + DateTime.Now.ToString("dd-MM-yyyy") +
                            "' WHERE assetNumber ='" + txtAsset.Text + "'");
                        if (updateEquip.rowAffected > 0)
                        {
                            MessageBox.Show("Equipment Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            frmEquipment.frmEqp.btnRfrsh_Click(sender, e);

                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error on Accounts Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            txtAsset.Clear();
            txtSerial.Clear();
            txtYearModel.Clear();
            txtDescription.Clear();
            txtManufacturer.Clear();
            cmbDepartment.SelectedIndex = -1;
            cmbBranch.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
        }

        private void frmUpdateEquip_Load(object sender, EventArgs e)
        {
            //loading asset number
            txtAsset.Text = assetNum;
            //loading serial number
            txtSerial.Text = serialNum;
            //loadingtype
            cmbType.Text = type;
            //loading Manufacturer
            txtManufacturer.Text = manufacturer;
            //Loading Year Model
            txtYearModel.Text = YearModel;
            //Loading Description
            txtDescription.Text = Description;
            //loading branch
            cmbBranch.Text = branch;
            //loading department
            cmbDepartment.Text = Department;
            //loading status
            if (status == "WORKING")
            {
                rbWorking.Checked = true;
            }
            else if(status == "ON REPAIR")
            {
                rbRepair.Checked = true;
            }
            else
            {
                rbRetired.Checked = true;
            }
        }
    }
}
