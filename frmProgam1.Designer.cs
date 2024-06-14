namespace CS311_22_23
{
    partial class frmProgam1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgam1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbfn = new System.Windows.Forms.TextBox();
            this.tbsn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number:";
            // 
            // tbfn
            // 
            this.tbfn.Location = new System.Drawing.Point(166, 23);
            this.tbfn.Name = "tbfn";
            this.tbfn.Size = new System.Drawing.Size(124, 20);
            this.tbfn.TabIndex = 2;
            this.tbfn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbfn_KeyPress);
            // 
            // tbsn
            // 
            this.tbsn.Location = new System.Drawing.Point(166, 56);
            this.tbsn.Name = "tbsn";
            this.tbsn.Size = new System.Drawing.Size(124, 20);
            this.tbsn.TabIndex = 3;
            this.tbsn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsn_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result:";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(42, 97);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(51, 23);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(107, 97);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(51, 23);
            this.btnsub.TabIndex = 7;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmul
            // 
            this.btnmul.Location = new System.Drawing.Point(173, 97);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(51, 23);
            this.btnmul.TabIndex = 8;
            this.btnmul.Text = "x";
            this.btnmul.UseVisualStyleBackColor = true;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(239, 97);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(51, 23);
            this.btndiv.TabIndex = 9;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(229, 136);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(51, 23);
            this.btnClr.TabIndex = 10;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbResult
            // 
            this.tbResult.AcceptsTab = true;
            this.tbResult.Location = new System.Drawing.Point(99, 138);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(124, 20);
            this.tbResult.TabIndex = 11;
            // 
            // frmProgam1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 180);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbsn);
            this.Controls.Add(this.tbfn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProgam1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDAS Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbfn;
        private System.Windows.Forms.TextBox tbsn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbResult;
    }
}