namespace CS311_22_23
{
    partial class frmProgram2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgram2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbfn = new System.Windows.Forms.TextBox();
            this.tbsn = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbSubtract = new System.Windows.Forms.RadioButton();
            this.rbMultiply = new System.Windows.Forms.RadioButton();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input Number";
            // 
            // tbfn
            // 
            this.tbfn.Location = new System.Drawing.Point(29, 32);
            this.tbfn.Name = "tbfn";
            this.tbfn.Size = new System.Drawing.Size(151, 20);
            this.tbfn.TabIndex = 2;
            this.tbfn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbfn_KeyPress);
            // 
            // tbsn
            // 
            this.tbsn.Location = new System.Drawing.Point(29, 76);
            this.tbsn.Name = "tbsn";
            this.tbsn.Size = new System.Drawing.Size(151, 20);
            this.tbsn.TabIndex = 3;
            this.tbsn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsn_KeyPress);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(24, 159);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 12;
            this.btnCompute.Text = "&Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(114, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Checked = true;
            this.rbAdd.Location = new System.Drawing.Point(29, 102);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(44, 17);
            this.rbAdd.TabIndex = 14;
            this.rbAdd.TabStop = true;
            this.rbAdd.Text = "Add";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbSubtract
            // 
            this.rbSubtract.AutoSize = true;
            this.rbSubtract.Location = new System.Drawing.Point(114, 102);
            this.rbSubtract.Name = "rbSubtract";
            this.rbSubtract.Size = new System.Drawing.Size(65, 17);
            this.rbSubtract.TabIndex = 15;
            this.rbSubtract.Text = "Subtract";
            this.rbSubtract.UseVisualStyleBackColor = true;
            // 
            // rbMultiply
            // 
            this.rbMultiply.AutoSize = true;
            this.rbMultiply.Location = new System.Drawing.Point(29, 125);
            this.rbMultiply.Name = "rbMultiply";
            this.rbMultiply.Size = new System.Drawing.Size(60, 17);
            this.rbMultiply.TabIndex = 16;
            this.rbMultiply.Text = "Multiply";
            this.rbMultiply.UseVisualStyleBackColor = true;
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Location = new System.Drawing.Point(115, 125);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(55, 17);
            this.rbDivide.TabIndex = 17;
            this.rbDivide.Text = "Divide";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProgram2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 204);
            this.Controls.Add(this.rbDivide);
            this.Controls.Add(this.rbMultiply);
            this.Controls.Add(this.rbSubtract);
            this.Controls.Add(this.rbAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.tbsn);
            this.Controls.Add(this.tbfn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProgram2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULATOR";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbfn;
        private System.Windows.Forms.TextBox tbsn;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbSubtract;
        private System.Windows.Forms.RadioButton rbMultiply;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}