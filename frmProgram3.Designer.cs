namespace CS311_22_23
{
    partial class frmProgram3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgram3));
            this.label1 = new System.Windows.Forms.Label();
            this.tbadj = new System.Windows.Forms.TextBox();
            this.tbhyp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbtan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbcos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbsin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.butcomp = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Adjacent Side:";
            // 
            // tbadj
            // 
            this.tbadj.Location = new System.Drawing.Point(16, 25);
            this.tbadj.Name = "tbadj";
            this.tbadj.Size = new System.Drawing.Size(133, 20);
            this.tbadj.TabIndex = 1;
            // 
            // tbhyp
            // 
            this.tbhyp.Location = new System.Drawing.Point(16, 75);
            this.tbhyp.Name = "tbhyp";
            this.tbhyp.Size = new System.Drawing.Size(133, 20);
            this.tbhyp.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter  Hypotenuse Side:";
            // 
            // tbop
            // 
            this.tbop.Location = new System.Drawing.Point(15, 130);
            this.tbop.Name = "tbop";
            this.tbop.Size = new System.Drawing.Size(133, 20);
            this.tbop.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter  Opposite Side:";
            // 
            // tbtan
            // 
            this.tbtan.Location = new System.Drawing.Point(223, 130);
            this.tbtan.Name = "tbtan";
            this.tbtan.ReadOnly = true;
            this.tbtan.Size = new System.Drawing.Size(133, 20);
            this.tbtan.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tangent:";
            // 
            // tbcos
            // 
            this.tbcos.Location = new System.Drawing.Point(224, 75);
            this.tbcos.Name = "tbcos";
            this.tbcos.ReadOnly = true;
            this.tbcos.Size = new System.Drawing.Size(133, 20);
            this.tbcos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cosine:";
            // 
            // tbsin
            // 
            this.tbsin.Location = new System.Drawing.Point(224, 25);
            this.tbsin.Name = "tbsin";
            this.tbsin.ReadOnly = true;
            this.tbsin.Size = new System.Drawing.Size(133, 20);
            this.tbsin.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sine:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "=";
            // 
            // butcomp
            // 
            this.butcomp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butcomp.Location = new System.Drawing.Point(89, 182);
            this.butcomp.Name = "butcomp";
            this.butcomp.Size = new System.Drawing.Size(75, 23);
            this.butcomp.TabIndex = 13;
            this.butcomp.Text = "&Compute";
            this.butcomp.UseVisualStyleBackColor = true;
            this.butcomp.Click += new System.EventHandler(this.butcomp_Click);
            // 
            // btnclr
            // 
            this.btnclr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclr.Location = new System.Drawing.Point(209, 182);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(75, 23);
            this.btnclr.TabIndex = 14;
            this.btnclr.Text = "C&lear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // frmProgram3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 239);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.butcomp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbtan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbcos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbsin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbhyp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbadj);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProgram3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangle Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbadj;
        private System.Windows.Forms.TextBox tbhyp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbtan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbcos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbsin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butcomp;
        private System.Windows.Forms.Button btnclr;
    }
}