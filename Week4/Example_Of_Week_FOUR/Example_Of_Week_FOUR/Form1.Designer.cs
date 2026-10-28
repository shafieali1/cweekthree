namespace Example_Of_Week_FOUR
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
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.TxtYearsExp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDecision = new System.Windows.Forms.Label();
            this.BtnCheckQuali = new System.Windows.Forms.Button();
            this.BtnChangeClr = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(249, 61);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(176, 26);
            this.TxtSalary.TabIndex = 0;
            this.TxtSalary.TextChanged += new System.EventHandler(this.TxtSalary_TextChanged);
            // 
            // TxtYearsExp
            // 
            this.TxtYearsExp.Location = new System.Drawing.Point(249, 105);
            this.TxtYearsExp.Name = "TxtYearsExp";
            this.TxtYearsExp.Size = new System.Drawing.Size(176, 26);
            this.TxtYearsExp.TabIndex = 1;
            this.TxtYearsExp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your Salary";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Your Experiance";
            // 
            // lblDecision
            // 
            this.lblDecision.AutoSize = true;
            this.lblDecision.Location = new System.Drawing.Point(573, 209);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(120, 20);
            this.lblDecision.TabIndex = 4;
            this.lblDecision.Text = "Decision Result";
            this.lblDecision.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnCheckQuali
            // 
            this.BtnCheckQuali.Location = new System.Drawing.Point(260, 296);
            this.BtnCheckQuali.Name = "BtnCheckQuali";
            this.BtnCheckQuali.Size = new System.Drawing.Size(254, 109);
            this.BtnCheckQuali.TabIndex = 5;
            this.BtnCheckQuali.Text = "Calculate Quality";
            this.BtnCheckQuali.UseVisualStyleBackColor = true;
            this.BtnCheckQuali.Click += new System.EventHandler(this.BtnCheckQuali_Click);
            // 
            // BtnChangeClr
            // 
            this.BtnChangeClr.Location = new System.Drawing.Point(535, 308);
            this.BtnChangeClr.Name = "BtnChangeClr";
            this.BtnChangeClr.Size = new System.Drawing.Size(231, 84);
            this.BtnChangeClr.TabIndex = 6;
            this.BtnChangeClr.Text = "Chance Btn Color";
            this.BtnChangeClr.UseVisualStyleBackColor = true;
            this.BtnChangeClr.Click += new System.EventHandler(this.BtnChangeClr_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(799, 308);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(231, 84);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(260, 245);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(770, 26);
            this.textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 516);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnChangeClr);
            this.Controls.Add(this.BtnCheckQuali);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtYearsExp);
            this.Controls.Add(this.TxtSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.TextBox TxtYearsExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Button BtnCheckQuali;
        private System.Windows.Forms.Button BtnChangeClr;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox textBox3;
    }
}

