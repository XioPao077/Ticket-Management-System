using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_22_23
{
    public partial class frmProgram2 : Form
    {
        public frmProgram2()
        {
            InitializeComponent();
        }
        //counter
        private int errorCount = 0;
        //-----validation-----
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
        private void tbsn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                errorProvider1.SetError(tbsn, "Input only accepts numbers");
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

        //main process
        //variables 
        private float result, fn, sn;
        private void btnCompute_Click(object sender, EventArgs e)
        {
            //calling of process
            errorCount = 0;
            errorProvider1.Clear();
            checkInput1();
            checkInput2();
            checkError();

            if (errorCount == 0)
            {
                //input
                fn = float.Parse(tbfn.Text);
                sn = float.Parse(tbsn.Text);
                //condition
                if (rbAdd.Checked)
                {
                    //process
                    result = fn + sn;
                    //output
                    MessageBox.Show("Sum:" + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbSubtract.Checked)
                {
                    //process
                    result = fn - sn;
                    //output
                    MessageBox.Show("Difference:" + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbMultiply.Checked)
                {
                    //process
                    result = fn * sn;
                    //output
                    MessageBox.Show("Product:" + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //process
                    result = fn / sn;
                    //output
                    MessageBox.Show("Quotient:" + result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbfn.Clear();
            tbsn.Clear();
            errorCount = 0;
            errorProvider1.Clear();
            
        }
    }
}
