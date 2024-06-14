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
    public partial class Program4 : Form
    {
        public Program4()
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            errorCount = 0;
            errorProvider1.Clear();
            tbfn.Clear();
            tbsn.Clear();
            cbAdd.Checked = true;
            cbSubtract.Checked = false;
            cbMultiply.Checked = false;
            cbDivide.Checked = false;

        }
        
        //main process
        private void btnCompute_Click(object sender, EventArgs e)
        {
            errorCount = 0;
            errorProvider1.Clear();
            checkInput1();
            checkInput2();
            checkError();
            if(errorCount == 0)
            {
                Num1 = float.Parse(tbfn.Text); 
                Num2 = float.Parse(tbsn.Text);
                String msg = "";
                if (cbAdd.Checked)
                {
                   Result = Num1 + Num2;
                    msg = msg + "Sum:" + Result + "\n";
                }
                if (cbSubtract.Checked)
                {
                    Result = Num1 - Num2;
                    msg = msg + "Difference:" + Result + "\n";
                }
                if (cbMultiply.Checked)
                {
                    Result = Num1 * Num2;
                    msg = msg + "Product:" + Result + "\n";
                }
                if (cbDivide.Checked)
                {
                    Result = Num1 / Num2;
                    msg = msg + "Quotient:" + Result + "\n";
                }
                if (msg != "")
                {
                    MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
