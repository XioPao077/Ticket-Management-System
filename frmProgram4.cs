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
    public partial class frmProgram4 : Form
    {
        public frmProgram4()
        {
            InitializeComponent();
        }
        //variables
        private float adj,hyp,op,sin,cos,tan;
        private int errorCounter = 0;

        //validation
        private void checkAdj()
        {
            if (txtbxAdj.Text == "")
            {
                errorProvider1.SetError(txtbxAdj, "Input Cannot be Empty");
            }
        }
        private void checkHyp()
        {
            if (txtbxHyp.Text == "")
            {
                errorProvider1.SetError(txtbxHyp, "Input Cannot be Empty");
            }
        }
            private void checkOp()
        {
            if (txtbxOp.Text == "")
            {
                errorProvider1.SetError(txtbxOp, "Input Cannot be Empty");
            }
        }
        private void checkError()
        {
            //checks for error on each object
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                if (errorProvider1.GetError(c) != "")
                {
                    errorCounter++;
                }
            }
        }

        //checks if inputs are numbers
        private void txtbxAdj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                errorProvider1.SetError(txtbxAdj, "Input only accepts numbers");
            }
        }

        private void txtbxHyp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                errorProvider1.SetError(txtbxHyp, "Input only accepts numbers");
            }
        }

        private void txtbxOp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                errorProvider1.SetError(txtbxOp, "Input only accepts numbers");
            }
        }

        // main functions
        private void btnSin_Click(object sender, EventArgs e)
        {
            errorCounter = 0;
            errorProvider1.Clear();
            checkOp();
            checkHyp();
            checkError();

            if (errorCounter == 0)
            {
                hyp = float.Parse(txtbxHyp.Text);
                op = float.Parse(txtbxOp.Text);
                // process
                sin = op / hyp;
                //output
                txtbxSin.Text = sin.ToString();
                txtbxTan.Clear();
                txtbxCos.Clear();
            }
        }
        private void btnCos_Click(object sender, EventArgs e)
        {
            errorCounter = 0;
            errorProvider1.Clear();
            checkAdj();
            checkHyp();
            checkError();

            if (errorCounter == 0)
            {
                adj = float.Parse(txtbxAdj.Text);
                hyp = float.Parse(txtbxHyp.Text);
                // process
                cos = adj / hyp;
                //output
                txtbxCos.Text = cos.ToString();
                txtbxSin.Clear();
                txtbxTan.Clear();
            }
        }
        private void btnTan_Click(object sender, EventArgs e)
        {
            errorCounter = 0;
            errorProvider1.Clear();
            checkOp();
            checkAdj();
            checkError();

            if (errorCounter == 0)
            {
                adj = float.Parse(txtbxAdj.Text);
                op = float.Parse(txtbxOp.Text);
                // process
                tan = op / adj;
                //output
                txtbxTan.Text = tan.ToString();
                txtbxSin.Clear();
                txtbxCos.Clear();
            }
        }
     
        private void btnAll_Click(object sender, EventArgs e)
        {
            errorCounter = 0;
            errorProvider1.Clear();
            checkAdj();
            checkHyp();
            checkOp();
            checkError();

            if (errorCounter == 0)
            {
                adj = float.Parse(txtbxAdj.Text);
                hyp = float.Parse(txtbxHyp.Text);
                op = float.Parse(txtbxOp.Text);
                // process
                tan = op / adj;
                cos = adj / hyp;
                sin = op / hyp;
                //output
                txtbxTan.Text = tan.ToString();
                txtbxCos.Text = cos.ToString();
                txtbxSin.Text = sin.ToString();
            }
        }

        private void btnCLR_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtbxAdj.Clear();
            txtbxHyp.Clear();
            txtbxOp.Clear();
            txtbxSin.Clear();
            txtbxCos.Clear();
            txtbxTan.Clear();
            errorCounter = 0;

        }
    }
}
