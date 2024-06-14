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
    public partial class frmProgam1 : Form
    {
        public frmProgam1()
        {
            InitializeComponent();
        }
        //variables

        private int fn, sn, result;
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
            else if (int.Parse(tbfn.Text) < 0 || int.Parse(tbsn.Text) > 1000)
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
                if(errorProvider1.GetError(c) != "")
                { 
                    errorCount++; 
                }
            }
        }
        private void tbfn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char) 8 )
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
        // end of validation

        private void btnadd_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorCount = 0;
            checkInput1();
            checkInput2();
            checkError();
            if (errorCount == 0)
            {
                //input
                fn = int.Parse(tbfn.Text);
                sn = int.Parse(tbsn.Text);
                //process
                result = fn + sn;
                //output
                tbResult.Text = result.ToString();
            }

        }
        private void btndiv_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorCount = 0;
            checkInput1();
            checkInput2();
            checkError();
            if (errorCount == 0)
            {
                //input
                fn = int.Parse(tbfn.Text);
                sn = int.Parse(tbsn.Text);
                //process
                result = fn / sn;
                //output
                tbResult.Text = result.ToString();
            }
        }
        private void btnsub_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            errorCount = 0;
            checkInput1();
            checkInput2();
            checkError();
            if (errorCount == 0)
            {
                //input
                fn = int.Parse(tbfn.Text);
                sn = int.Parse(tbsn.Text);
                //process
                result = fn - sn;
                //output
                tbResult.Text = result.ToString();
            }
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorCount = 0;
            checkInput1();
            checkInput2(); ;
            checkError();
            if (errorCount == 0)
            {
                //input
                fn = int.Parse(tbfn.Text);
                sn = int.Parse(tbsn.Text);
                //process
                result = fn * sn;
                //output
                tbResult.Text = result.ToString();
            }
        }
        private void btnClr_Click(object sender, EventArgs e)
        {
            errorCount = 0;
            tbfn.Clear();
            tbsn.Clear();
            tbResult.Clear();
            errorProvider1.Clear();
        }
 

    }
}
