namespace Divisor
{
    partial class fmDivision
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
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textDivisor = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.lbAnswer = new System.Windows.Forms.ListBox();
            this.lblNumberloops = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(15, 39);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(132, 21);
            this.textNumber.TabIndex = 0;
            // 
            // textDivisor
            // 
            this.textDivisor.Location = new System.Drawing.Point(15, 97);
            this.textDivisor.Name = "textDivisor";
            this.textDivisor.Size = new System.Drawing.Size(132, 21);
            this.textDivisor.TabIndex = 1;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(15, 160);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(103, 40);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "Click Me";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lbAnswer
            // 
            this.lbAnswer.FormattingEnabled = true;
            this.lbAnswer.ItemHeight = 12;
            this.lbAnswer.Location = new System.Drawing.Point(153, 39);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(150, 196);
            this.lbAnswer.TabIndex = 3;
            // 
            // lblNumberloops
            // 
            this.lblNumberloops.AutoSize = true;
            this.lblNumberloops.Location = new System.Drawing.Point(13, 24);
            this.lblNumberloops.Name = "lblNumberloops";
            this.lblNumberloops.Size = new System.Drawing.Size(131, 12);
            this.lblNumberloops.TabIndex = 4;
            this.lblNumberloops.Text = "Enter Number of Loops";
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(13, 82);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(83, 12);
            this.lblDivisor.TabIndex = 5;
            this.lblDivisor.Text = "Enter Divisor";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(207, 24);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(41, 12);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Output";
            // 
            // fmDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 261);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.lblNumberloops);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.textDivisor);
            this.Controls.Add(this.textNumber);
            this.Name = "fmDivision";
            this.Text = "Division";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.TextBox textDivisor;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.ListBox lbAnswer;
        private System.Windows.Forms.Label lblNumberloops;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Label lblOutput;
    }
}

