
namespace Remoteclient
{
    partial class Form1
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnuml2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btnhighestnum = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(319, 170);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(61, 13);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Enter num1";
            // 
            // lblnuml2
            // 
            this.lblnuml2.AutoSize = true;
            this.lblnuml2.Location = new System.Drawing.Point(319, 241);
            this.lblnuml2.Name = "lblnuml2";
            this.lblnuml2.Size = new System.Drawing.Size(64, 13);
            this.lblnuml2.TabIndex = 1;
            this.lblnuml2.Text = "Enetr num 2";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(460, 167);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 2;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(460, 234);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 3;
            // 
            // btnhighestnum
            // 
            this.btnhighestnum.Location = new System.Drawing.Point(410, 314);
            this.btnhighestnum.Name = "btnhighestnum";
            this.btnhighestnum.Size = new System.Drawing.Size(150, 23);
            this.btnhighestnum.TabIndex = 4;
            this.btnhighestnum.Text = "Highestnumber";
            this.btnhighestnum.UseVisualStyleBackColor = true;
            this.btnhighestnum.Click += new System.EventHandler(this.btnhighestnum_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(593, 198);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(155, 20);
            this.txtresult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnhighestnum);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblnuml2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnuml2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button btnhighestnum;
        private System.Windows.Forms.TextBox txtresult;
    }
}

