namespace ch3_Statium_Seating_Project
{
    partial class StadiumSeating
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInputInstructions = new System.Windows.Forms.Label();
            this.classAInput = new System.Windows.Forms.TextBox();
            this.classBInput = new System.Windows.Forms.TextBox();
            this.classCInput = new System.Windows.Forms.TextBox();
            this.lblClassA = new System.Windows.Forms.Label();
            this.lblClassB = new System.Windows.Forms.Label();
            this.lblClassC = new System.Windows.Forms.Label();
            this.GroupBoxRevenue = new System.Windows.Forms.GroupBox();
            this.RevLblClassA = new System.Windows.Forms.Label();
            this.RevLblClassB = new System.Windows.Forms.Label();
            this.RevLblClassC = new System.Windows.Forms.Label();
            this.TotalLbl = new System.Windows.Forms.Label();
            this.ClassAOutput = new System.Windows.Forms.Label();
            this.ClassBOutput = new System.Windows.Forms.Label();
            this.ClassCOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.GroupBoxRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClassC);
            this.groupBox1.Controls.Add(this.lblClassB);
            this.groupBox1.Controls.Add(this.lblClassA);
            this.groupBox1.Controls.Add(this.classCInput);
            this.groupBox1.Controls.Add(this.classBInput);
            this.groupBox1.Controls.Add(this.classAInput);
            this.groupBox1.Controls.Add(this.lblInputInstructions);
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Sold";
            // 
            // lblInputInstructions
            // 
            this.lblInputInstructions.AutoSize = true;
            this.lblInputInstructions.Location = new System.Drawing.Point(34, 32);
            this.lblInputInstructions.Name = "lblInputInstructions";
            this.lblInputInstructions.Size = new System.Drawing.Size(156, 26);
            this.lblInputInstructions.TabIndex = 0;
            this.lblInputInstructions.Text = "Enter the number of tickets sold\r\nfor each class of seats.";
            this.lblInputInstructions.Click += new System.EventHandler(this.LblInputInstructions_Click);
            // 
            // classAInput
            // 
            this.classAInput.Location = new System.Drawing.Point(108, 73);
            this.classAInput.Name = "classAInput";
            this.classAInput.Size = new System.Drawing.Size(100, 20);
            this.classAInput.TabIndex = 1;
            this.classAInput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // classBInput
            // 
            this.classBInput.Location = new System.Drawing.Point(108, 110);
            this.classBInput.Name = "classBInput";
            this.classBInput.Size = new System.Drawing.Size(100, 20);
            this.classBInput.TabIndex = 2;
            // 
            // classCInput
            // 
            this.classCInput.Location = new System.Drawing.Point(108, 145);
            this.classCInput.Name = "classCInput";
            this.classCInput.Size = new System.Drawing.Size(100, 20);
            this.classCInput.TabIndex = 3;
            this.classCInput.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // lblClassA
            // 
            this.lblClassA.AutoSize = true;
            this.lblClassA.Location = new System.Drawing.Point(34, 76);
            this.lblClassA.Name = "lblClassA";
            this.lblClassA.Size = new System.Drawing.Size(45, 13);
            this.lblClassA.TabIndex = 4;
            this.lblClassA.Text = "Class A:";
            // 
            // lblClassB
            // 
            this.lblClassB.AutoSize = true;
            this.lblClassB.Location = new System.Drawing.Point(34, 113);
            this.lblClassB.Name = "lblClassB";
            this.lblClassB.Size = new System.Drawing.Size(45, 13);
            this.lblClassB.TabIndex = 5;
            this.lblClassB.Text = "Class B:";
            // 
            // lblClassC
            // 
            this.lblClassC.AutoSize = true;
            this.lblClassC.Location = new System.Drawing.Point(34, 148);
            this.lblClassC.Name = "lblClassC";
            this.lblClassC.Size = new System.Drawing.Size(45, 13);
            this.lblClassC.TabIndex = 6;
            this.lblClassC.Text = "Class C:";
            // 
            // GroupBoxRevenue
            // 
            this.GroupBoxRevenue.Controls.Add(this.totalOutput);
            this.GroupBoxRevenue.Controls.Add(this.ClassCOutput);
            this.GroupBoxRevenue.Controls.Add(this.ClassBOutput);
            this.GroupBoxRevenue.Controls.Add(this.ClassAOutput);
            this.GroupBoxRevenue.Controls.Add(this.TotalLbl);
            this.GroupBoxRevenue.Controls.Add(this.RevLblClassC);
            this.GroupBoxRevenue.Controls.Add(this.RevLblClassB);
            this.GroupBoxRevenue.Controls.Add(this.RevLblClassA);
            this.GroupBoxRevenue.Location = new System.Drawing.Point(287, 28);
            this.GroupBoxRevenue.Name = "GroupBoxRevenue";
            this.GroupBoxRevenue.Size = new System.Drawing.Size(230, 210);
            this.GroupBoxRevenue.TabIndex = 7;
            this.GroupBoxRevenue.TabStop = false;
            this.GroupBoxRevenue.Text = "Revenue Generated";
            // 
            // RevLblClassA
            // 
            this.RevLblClassA.AutoSize = true;
            this.RevLblClassA.Location = new System.Drawing.Point(39, 30);
            this.RevLblClassA.Name = "RevLblClassA";
            this.RevLblClassA.Size = new System.Drawing.Size(45, 13);
            this.RevLblClassA.TabIndex = 5;
            this.RevLblClassA.Text = "Class A:";
            // 
            // RevLblClassB
            // 
            this.RevLblClassB.AutoSize = true;
            this.RevLblClassB.Location = new System.Drawing.Point(39, 75);
            this.RevLblClassB.Name = "RevLblClassB";
            this.RevLblClassB.Size = new System.Drawing.Size(45, 13);
            this.RevLblClassB.TabIndex = 6;
            this.RevLblClassB.Text = "Class B:";
            // 
            // RevLblClassC
            // 
            this.RevLblClassC.AutoSize = true;
            this.RevLblClassC.Location = new System.Drawing.Point(39, 120);
            this.RevLblClassC.Name = "RevLblClassC";
            this.RevLblClassC.Size = new System.Drawing.Size(45, 13);
            this.RevLblClassC.TabIndex = 7;
            this.RevLblClassC.Text = "Class C:";
            // 
            // TotalLbl
            // 
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.Location = new System.Drawing.Point(50, 165);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(34, 13);
            this.TotalLbl.TabIndex = 8;
            this.TotalLbl.Text = "Total:";
            // 
            // ClassAOutput
            // 
            this.ClassAOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassAOutput.Location = new System.Drawing.Point(109, 30);
            this.ClassAOutput.Name = "ClassAOutput";
            this.ClassAOutput.Size = new System.Drawing.Size(100, 25);
            this.ClassAOutput.TabIndex = 9;
            this.ClassAOutput.Click += new System.EventHandler(this.ClassAOutput_Click);
            // 
            // ClassBOutput
            // 
            this.ClassBOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassBOutput.Location = new System.Drawing.Point(109, 75);
            this.ClassBOutput.Name = "ClassBOutput";
            this.ClassBOutput.Size = new System.Drawing.Size(100, 25);
            this.ClassBOutput.TabIndex = 10;
            // 
            // ClassCOutput
            // 
            this.ClassCOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassCOutput.Location = new System.Drawing.Point(109, 120);
            this.ClassCOutput.Name = "ClassCOutput";
            this.ClassCOutput.Size = new System.Drawing.Size(100, 25);
            this.ClassCOutput.TabIndex = 11;
            // 
            // totalOutput
            // 
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Location = new System.Drawing.Point(109, 165);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 25);
            this.totalOutput.TabIndex = 12;
            this.totalOutput.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(92, 244);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(80, 40);
            this.calcButton.TabIndex = 8;
            this.calcButton.Text = "Calculate Revenue";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(228, 244);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 40);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(361, 244);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 40);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StadiumSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(542, 303);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.GroupBoxRevenue);
            this.Controls.Add(this.groupBox1);
            this.Name = "StadiumSeating";
            this.Text = "Stadium Seating";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBoxRevenue.ResumeLayout(false);
            this.GroupBoxRevenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInputInstructions;
        private System.Windows.Forms.TextBox classAInput;
        private System.Windows.Forms.TextBox classCInput;
        private System.Windows.Forms.TextBox classBInput;
        private System.Windows.Forms.Label lblClassC;
        private System.Windows.Forms.Label lblClassB;
        private System.Windows.Forms.Label lblClassA;
        private System.Windows.Forms.GroupBox GroupBoxRevenue;
        private System.Windows.Forms.Label ClassBOutput;
        private System.Windows.Forms.Label ClassAOutput;
        private System.Windows.Forms.Label TotalLbl;
        private System.Windows.Forms.Label RevLblClassC;
        private System.Windows.Forms.Label RevLblClassB;
        private System.Windows.Forms.Label RevLblClassA;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label ClassCOutput;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

