namespace CS311_22_23
{
    partial class frmProgram4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgram4));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxAdj = new System.Windows.Forms.TextBox();
            this.txtbxHyp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxOp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxSin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxCos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxTan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnCLR = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adjacent Side:";
            // 
            // txtbxAdj
            // 
            this.txtbxAdj.Location = new System.Drawing.Point(123, 15);
            this.txtbxAdj.Name = "txtbxAdj";
            this.txtbxAdj.Size = new System.Drawing.Size(143, 20);
            this.txtbxAdj.TabIndex = 1;
            this.txtbxAdj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAdj_KeyPress);
            // 
            // txtbxHyp
            // 
            this.txtbxHyp.Location = new System.Drawing.Point(123, 41);
            this.txtbxHyp.Name = "txtbxHyp";
            this.txtbxHyp.Size = new System.Drawing.Size(143, 20);
            this.txtbxHyp.TabIndex = 3;
            this.txtbxHyp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxHyp_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hypotenuse Side:";
            // 
            // txtbxOp
            // 
            this.txtbxOp.Location = new System.Drawing.Point(123, 67);
            this.txtbxOp.Name = "txtbxOp";
            this.txtbxOp.Size = new System.Drawing.Size(143, 20);
            this.txtbxOp.TabIndex = 5;
            this.txtbxOp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxOp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opposite Side:";
            // 
            // txtbxSin
            // 
            this.txtbxSin.Location = new System.Drawing.Point(128, 143);
            this.txtbxSin.Name = "txtbxSin";
            this.txtbxSin.ReadOnly = true;
            this.txtbxSin.Size = new System.Drawing.Size(143, 20);
            this.txtbxSin.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sine:";
            // 
            // txtbxCos
            // 
            this.txtbxCos.Location = new System.Drawing.Point(128, 169);
            this.txtbxCos.Name = "txtbxCos";
            this.txtbxCos.ReadOnly = true;
            this.txtbxCos.Size = new System.Drawing.Size(143, 20);
            this.txtbxCos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cosine:";
            // 
            // txtbxTan
            // 
            this.txtbxTan.Location = new System.Drawing.Point(128, 195);
            this.txtbxTan.Name = "txtbxTan";
            this.txtbxTan.ReadOnly = true;
            this.txtbxTan.Size = new System.Drawing.Size(143, 20);
            this.txtbxTan.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tangent:";
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(22, 106);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(59, 23);
            this.btnSin.TabIndex = 12;
            this.btnSin.Text = "&Sine";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(87, 106);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(59, 23);
            this.btnCos.TabIndex = 13;
            this.btnCos.Text = "C&osine";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(152, 106);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(59, 23);
            this.btnTan.TabIndex = 14;
            this.btnTan.Text = "&Tangent";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(217, 106);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(59, 23);
            this.btnAll.TabIndex = 15;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnCLR
            // 
            this.btnCLR.BackColor = System.Drawing.Color.Crimson;
            this.btnCLR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCLR.Location = new System.Drawing.Point(217, 233);
            this.btnCLR.Name = "btnCLR";
            this.btnCLR.Size = new System.Drawing.Size(59, 23);
            this.btnCLR.TabIndex = 16;
            this.btnCLR.Text = "&Clear";
            this.btnCLR.UseVisualStyleBackColor = false;
            this.btnCLR.Click += new System.EventHandler(this.btnCLR_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProgram4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 268);
            this.Controls.Add(this.btnCLR);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.txtbxTan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbxCos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxSin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxOp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxHyp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxAdj);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProgram4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangle Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxAdj;
        protected internal System.Windows.Forms.TextBox txtbxHyp;
        protected internal System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.TextBox txtbxOp;
        protected internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxSin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxCos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxTan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnCLR;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}