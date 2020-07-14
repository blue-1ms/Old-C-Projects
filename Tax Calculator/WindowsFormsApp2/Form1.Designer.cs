namespace WindowsFormsApp2
{
    partial class fmTax
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textIncome = new System.Windows.Forms.TextBox();
            this.textTax = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Annual Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your Tax Amount";
            // 
            // textIncome
            // 
            this.textIncome.Location = new System.Drawing.Point(14, 43);
            this.textIncome.Name = "textIncome";
            this.textIncome.Size = new System.Drawing.Size(111, 21);
            this.textIncome.TabIndex = 2;
            // 
            // textTax
            // 
            this.textTax.Location = new System.Drawing.Point(12, 174);
            this.textTax.Name = "textTax";
            this.textTax.Size = new System.Drawing.Size(113, 21);
            this.textTax.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(160, 27);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(88, 168);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate Tax";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // fmTax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 225);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.textTax);
            this.Controls.Add(this.textIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmTax";
            this.Text = "My Tax Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIncome;
        private System.Windows.Forms.TextBox textTax;
        private System.Windows.Forms.Button btnCalc;
    }
}

