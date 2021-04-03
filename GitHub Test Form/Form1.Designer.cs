
namespace GitHub_Test_Form
{
    partial class frmGitHub
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(27, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 100);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Location = new System.Drawing.Point(37, 39);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(113, 13);
            this.lblNumber1.TabIndex = 1;
            this.lblNumber1.Text = "Enter your 1st number:";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(37, 89);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(117, 13);
            this.lblNumber2.TabIndex = 2;
            this.lblNumber2.Text = "Enter your 2nd number:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(27, 216);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(160, 100);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(37, 143);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(31, 13);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "Sum:";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(40, 160);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(100, 20);
            this.txtSum.TabIndex = 5;
            this.txtSum.TextChanged += new System.EventHandler(this.txtSum_TextChanged);
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(40, 56);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 6;
            this.txtNumber1.TextChanged += new System.EventHandler(this.txtNumber1_TextChanged);
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(40, 106);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 7;
            this.txtNumber2.TextChanged += new System.EventHandler(this.txtNumber2_TextChanged);
            // 
            // frmGitHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 450);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClose);
            this.Name = "frmGitHub";
            this.Text = "GitHub Test Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
    }
}

