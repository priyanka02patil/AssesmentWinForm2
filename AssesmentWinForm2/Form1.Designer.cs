namespace AssesmentWinForm2
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
            this.labelEmpID = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.labelEmpSal = new System.Windows.Forms.Label();
            this.labelHra = new System.Windows.Forms.Label();
            this.labelDa = new System.Windows.Forms.Label();
            this.labelTa = new System.Windows.Forms.Label();
            this.labelPf = new System.Windows.Forms.Label();
            this.textEmpId = new System.Windows.Forms.TextBox();
            this.textBoxEmpName = new System.Windows.Forms.TextBox();
            this.textBoxEmpSal = new System.Windows.Forms.TextBox();
            this.textBoxHra = new System.Windows.Forms.TextBox();
            this.textBoxDa = new System.Windows.Forms.TextBox();
            this.textBoxTa = new System.Windows.Forms.TextBox();
            this.textBoxPf = new System.Windows.Forms.TextBox();
            this.btmCal = new System.Windows.Forms.Button();
            this.labelpt = new System.Windows.Forms.Label();
            this.textBoxPt = new System.Windows.Forms.TextBox();
            this.textBoxGross = new System.Windows.Forms.TextBox();
            this.labelGross = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Location = new System.Drawing.Point(82, 30);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(143, 20);
            this.labelEmpID.TabIndex = 0;
            this.labelEmpID.Text = "Enter Employee ID";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Location = new System.Drawing.Point(82, 83);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(168, 20);
            this.labelEmpName.TabIndex = 1;
            this.labelEmpName.Text = "Enter Employee Name";
            // 
            // labelEmpSal
            // 
            this.labelEmpSal.AutoSize = true;
            this.labelEmpSal.Location = new System.Drawing.Point(82, 140);
            this.labelEmpSal.Name = "labelEmpSal";
            this.labelEmpSal.Size = new System.Drawing.Size(170, 20);
            this.labelEmpSal.TabIndex = 2;
            this.labelEmpSal.Text = "Enter Employee Salary";
            // 
            // labelHra
            // 
            this.labelHra.AutoSize = true;
            this.labelHra.Location = new System.Drawing.Point(82, 279);
            this.labelHra.Name = "labelHra";
            this.labelHra.Size = new System.Drawing.Size(44, 20);
            this.labelHra.TabIndex = 3;
            this.labelHra.Text = "HRA";
            // 
            // labelDa
            // 
            this.labelDa.AutoSize = true;
            this.labelDa.Location = new System.Drawing.Point(82, 337);
            this.labelDa.Name = "labelDa";
            this.labelDa.Size = new System.Drawing.Size(32, 20);
            this.labelDa.TabIndex = 4;
            this.labelDa.Text = "DA";
            // 
            // labelTa
            // 
            this.labelTa.AutoSize = true;
            this.labelTa.Location = new System.Drawing.Point(82, 394);
            this.labelTa.Name = "labelTa";
            this.labelTa.Size = new System.Drawing.Size(29, 20);
            this.labelTa.TabIndex = 5;
            this.labelTa.Text = "TA";
            // 
            // labelPf
            // 
            this.labelPf.AutoSize = true;
            this.labelPf.Location = new System.Drawing.Point(82, 456);
            this.labelPf.Name = "labelPf";
            this.labelPf.Size = new System.Drawing.Size(29, 20);
            this.labelPf.TabIndex = 6;
            this.labelPf.Text = "PF";
            // 
            // textEmpId
            // 
            this.textEmpId.Location = new System.Drawing.Point(274, 27);
            this.textEmpId.Name = "textEmpId";
            this.textEmpId.Size = new System.Drawing.Size(166, 26);
            this.textEmpId.TabIndex = 7;
            // 
            // textBoxEmpName
            // 
            this.textBoxEmpName.Location = new System.Drawing.Point(274, 83);
            this.textBoxEmpName.Name = "textBoxEmpName";
            this.textBoxEmpName.Size = new System.Drawing.Size(166, 26);
            this.textBoxEmpName.TabIndex = 8;
            // 
            // textBoxEmpSal
            // 
            this.textBoxEmpSal.Location = new System.Drawing.Point(274, 137);
            this.textBoxEmpSal.Name = "textBoxEmpSal";
            this.textBoxEmpSal.Size = new System.Drawing.Size(166, 26);
            this.textBoxEmpSal.TabIndex = 9;
            // 
            // textBoxHra
            // 
            this.textBoxHra.Location = new System.Drawing.Point(274, 273);
            this.textBoxHra.Name = "textBoxHra";
            this.textBoxHra.ReadOnly = true;
            this.textBoxHra.Size = new System.Drawing.Size(166, 26);
            this.textBoxHra.TabIndex = 10;
            this.textBoxHra.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxDa
            // 
            this.textBoxDa.Location = new System.Drawing.Point(274, 331);
            this.textBoxDa.Name = "textBoxDa";
            this.textBoxDa.ReadOnly = true;
            this.textBoxDa.Size = new System.Drawing.Size(166, 26);
            this.textBoxDa.TabIndex = 11;
            // 
            // textBoxTa
            // 
            this.textBoxTa.Location = new System.Drawing.Point(274, 388);
            this.textBoxTa.Name = "textBoxTa";
            this.textBoxTa.ReadOnly = true;
            this.textBoxTa.Size = new System.Drawing.Size(166, 26);
            this.textBoxTa.TabIndex = 12;
            // 
            // textBoxPf
            // 
            this.textBoxPf.Location = new System.Drawing.Point(274, 450);
            this.textBoxPf.Name = "textBoxPf";
            this.textBoxPf.ReadOnly = true;
            this.textBoxPf.Size = new System.Drawing.Size(166, 26);
            this.textBoxPf.TabIndex = 13;
            // 
            // btmCal
            // 
            this.btmCal.Location = new System.Drawing.Point(274, 206);
            this.btmCal.Name = "btmCal";
            this.btmCal.Size = new System.Drawing.Size(166, 45);
            this.btmCal.TabIndex = 14;
            this.btmCal.Text = "Calculate";
            this.btmCal.UseVisualStyleBackColor = true;
            this.btmCal.Click += new System.EventHandler(this.btmCal_Click);
            // 
            // labelpt
            // 
            this.labelpt.AutoSize = true;
            this.labelpt.Location = new System.Drawing.Point(82, 523);
            this.labelpt.Name = "labelpt";
            this.labelpt.Size = new System.Drawing.Size(28, 20);
            this.labelpt.TabIndex = 16;
            this.labelpt.Text = "PT";
            // 
            // textBoxPt
            // 
            this.textBoxPt.Location = new System.Drawing.Point(274, 520);
            this.textBoxPt.Name = "textBoxPt";
            this.textBoxPt.ReadOnly = true;
            this.textBoxPt.Size = new System.Drawing.Size(166, 26);
            this.textBoxPt.TabIndex = 17;
            this.textBoxPt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxGross
            // 
            this.textBoxGross.Location = new System.Drawing.Point(274, 583);
            this.textBoxGross.Name = "textBoxGross";
            this.textBoxGross.ReadOnly = true;
            this.textBoxGross.Size = new System.Drawing.Size(166, 26);
            this.textBoxGross.TabIndex = 18;
            // 
            // labelGross
            // 
            this.labelGross.AutoSize = true;
            this.labelGross.Location = new System.Drawing.Point(82, 583);
            this.labelGross.Name = "labelGross";
            this.labelGross.Size = new System.Drawing.Size(52, 20);
            this.labelGross.TabIndex = 19;
            this.labelGross.Text = "Gross";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 663);
            this.Controls.Add(this.labelGross);
            this.Controls.Add(this.textBoxGross);
            this.Controls.Add(this.textBoxPt);
            this.Controls.Add(this.labelpt);
            this.Controls.Add(this.btmCal);
            this.Controls.Add(this.textBoxPf);
            this.Controls.Add(this.textBoxTa);
            this.Controls.Add(this.textBoxDa);
            this.Controls.Add(this.textBoxHra);
            this.Controls.Add(this.textBoxEmpSal);
            this.Controls.Add(this.textBoxEmpName);
            this.Controls.Add(this.textEmpId);
            this.Controls.Add(this.labelPf);
            this.Controls.Add(this.labelTa);
            this.Controls.Add(this.labelDa);
            this.Controls.Add(this.labelHra);
            this.Controls.Add(this.labelEmpSal);
            this.Controls.Add(this.labelEmpName);
            this.Controls.Add(this.labelEmpID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label labelEmpSal;
        private System.Windows.Forms.Label labelHra;
        private System.Windows.Forms.Label labelDa;
        private System.Windows.Forms.Label labelTa;
        private System.Windows.Forms.Label labelPf;
        private System.Windows.Forms.TextBox textEmpId;
        private System.Windows.Forms.TextBox textBoxEmpName;
        private System.Windows.Forms.TextBox textBoxEmpSal;
        private System.Windows.Forms.TextBox textBoxHra;
        private System.Windows.Forms.TextBox textBoxDa;
        private System.Windows.Forms.TextBox textBoxTa;
        private System.Windows.Forms.TextBox textBoxPf;
        private System.Windows.Forms.Button btmCal;
        private System.Windows.Forms.Label labelpt;
        private System.Windows.Forms.TextBox textBoxPt;
        private System.Windows.Forms.TextBox textBoxGross;
        private System.Windows.Forms.Label labelGross;
    }
}

