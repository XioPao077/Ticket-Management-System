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
    public partial class Program3 : Form
    {
        public Program3()
        {
            InitializeComponent();
        }
        //variables
        private int errorCount = 0;
        private float Num1, Num2, Result;
        //validation
        private void checkInput1()
        {
            if (tbfn.Text == "")
            {
                errorProvider1.SetError(tbfn, "Please Enter Data");
            }
            else if (int.Parse(tbfn.Text) < 0 || int.Parse(tbsn.Text) > 1000)
            {
                errorProvider1.SetError(tbfn, "Input should be from 1 to 1000 only.");
            }
            else
            {
                errorProvider1.SetError(tbfn, "");
            }
        }
        private void checkInput2()
        {
            if (tbsn.Text == "")
            {
                errorProvider1.SetError(tbsn, "Please Enter Data");
            }
            else if (int.Parse(tbsn.Text) < 0 || int.Parse(tbsn.Text) > 1000)
            {
                errorProvider1.SetError(tbsn, "Input should be from 1 to 1000 only.");
            }
            else
            {
                errorProvider1.SetError(tbsn, "");
            }
        }
        private void checkError()
        {
            //checks for error on each object
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                if (errorProvider1.GetError(c) != "")
                {
                    errorCount++;
                }
            }
        }
        private void tbfn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                errorProvider1.SetError(tbfn, "Input only accepts numbers");
            }
        }
        private void tbsn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                errorProvider1.SetError(tbsn, "Input only accepts numbers");
            }
        }
        //main process
        private void btnCompute_Click(object sender, EventArgs e)
        {
            //checking and calling processes
            errorCount = 0;
            errorProvider1.Clear();
            checkInput1();
            checkInput2();
            checkError();
            //checking if an operation is chosen
            if (cmbOperation.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmbOperation, "Please Select Operation.");
            }
            else
            {
                errorProvider1.SetError(cmbOperation, "");
            }
            if (errorCount == 0)
            {
                Num1 = float.Parse(tbfn.Text);
                Num2 = float.Parse(tbsn.Text);
                if(cmbOperation.SelectedIndex == 0)
                {
                    Result = Num1 + Num2;
                    MessageBox.Show("Sum:" + Result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbOperation.SelectedIndex == 1)
                {
                    Result = Num1 - Num2;
                    MessageBox.Show("Difference:" + Result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(cmbOperation.SelectedIndex == 2)
                {
                    Result = Num1 * Num2;
                    MessageBox.Show("Product:" + Result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if( cmbOperation.SelectedIndex == 3)
                {
                    Result = Num1 / Num2;
                    MessageBox.Show("Quotient:" + Result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider1.SetError(cmbOperation, "Please Select Operation.");
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbfn.Clear();
            tbsn.Clear();
            errorProvider1.Clear();
            errorCount = 0;
            cmbOperation.SelectedIndex = -1;
        }
    }
}
