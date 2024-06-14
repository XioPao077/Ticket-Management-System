namespace CS311_22_23
{
    partial class Program4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program4));
            this.tbsn = new System.Windows.Forms.TextBox();
            this.tbfn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAdd = new System.Windows.Forms.CheckBox();
            this.cbSubtract = new System.Windows.Forms.CheckBox();
            this.cbDivide = new System.Windows.Forms.CheckBox();
            this.cbMultiply = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbsn
            // 
            this.tbsn.Location = new System.Drawing.Point(33, 74);
            this.tbsn.Name = "tbsn";
            this.tbsn.Size = new System.Drawing.Size(151, 20);
            this.tbsn.TabIndex = 11;
            this.tbsn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsn_KeyPress);
            // 
            // tbfn
            // 
            this.tbfn.Location = new System.Drawing.Point(33, 30);
            this.tbfn.Name = "tbfn";
            this.tbfn.Size = new System.Drawing.Size(151, 20);
            this.tbfn.TabIndex = 10;
            this.tbfn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbfn_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Input Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input Number";
            // 
            // cbAdd
            // 
            this.cbAdd.AutoSize = true;
            this.cbAdd.Checked = true;
            this.cbAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAdd.Location = new System.Drawing.Point(33, 110);
            this.cbAdd.Name = "cbAdd";
            this.cbAdd.Size = new System.Drawing.Size(45, 17);
            this.cbAdd.TabIndex = 12;
            this.cbAdd.Text = "Add";
            this.cbAdd.UseVisualStyleBackColor = true;
            // 
            // cbSubtract
            // 
            this.cbSubtract.AutoSize = true;
            this.cbSubtract.Location = new System.Drawing.Point(33, 133);
            this.cbSubtract.Name = "cbSubtract";
            this.cbSubtract.Size = new System.Drawing.Size(66, 17);
            this.cbSubtract.TabIndex = 13;
            this.cbSubtract.Text = "Subtract";
            this.cbSubtract.UseVisualStyleBackColor = true;
            // 
            // cbDivide
            // 
            this.cbDivide.AutoSize = true;
            this.cbDivide.Location = new System.Drawing.Point(118, 133);
            this.cbDivide.Name = "cbDivide";
            this.cbDivide.Size = new System.Drawing.Size(56, 17);
            this.cbDivide.TabIndex = 15;
            this.cbDivide.Text = "Divide";
            this.cbDivide.UseVisualStyleBackColor = true;
            // 
            // cbMultiply
            // 
            this.cbMultiply.AutoSize = true;
            this.cbMultiply.Location = new System.Drawing.Point(118, 110);
            this.cbMultiply.Name = "cbMultiply";
            this.cbMultiply.Size = new System.Drawing.Size(61, 17);
            this.cbMultiply.TabIndex = 14;
            this.cbMultiply.Text = "Multiply";
            this.cbMultiply.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(118, 177);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(28, 177);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 16;
            this.btnCompute.Text = "&Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Program4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 212);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.cbDivide);
            this.Controls.Add(this.cbMultiply);
            this.Controls.Add(this.cbSubtract);
            this.Controls.Add(this.cbAdd);
            this.Controls.Add(this.tbsn);
            this.Controls.Add(this.tbfn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Program4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDAS Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbsn;
        private System.Windows.Forms.TextBox tbfn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAdd;
        private System.Windows.Forms.CheckBox cbSubtract;
        private System.Windows.Forms.CheckBox cbDivide;
        private System.Windows.Forms.CheckBox cbMultiply;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}