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
    public partial class frmProgram3 : Form
    {
        public frmProgram3()
        {
            InitializeComponent();
        }
        //declaration
        private float adj, hyp, op, sin, cos, tan;

        private void btnclr_Click(object sender, EventArgs e)
        {
            tbadj.Clear();
            tbhyp.Clear();
            tbop.Clear();
            tbsin.Clear();
            tbtan.Clear();
            tbcos.Clear();
        }

        private void butcomp_Click(object sender, EventArgs e)
        {
            //input
            adj = int.Parse(tbadj.Text);
            hyp = int.Parse(tbhyp.Text);
            op = int.Parse(tbop.Text);
            //process
            sin = op / hyp;
            cos = adj / hyp;
            tan = op / adj;
            //outout
            tbsin.Text = sin.ToString();
            tbcos.Text = cos.ToString();
            tbtan.Text = tan.ToString();
        }
    }
}
