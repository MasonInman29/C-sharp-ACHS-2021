namespace Automotive_Pricing_ch6_modularzation
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
            this.oilAndLubeGroupBox = new System.Windows.Forms.GroupBox();
            this.lubeCheckBox = new System.Windows.Forms.CheckBox();
            this.oilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.flushesGroupBox = new System.Windows.Forms.GroupBox();
            this.transmissionFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.radiatorFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.miscGroupBox = new System.Windows.Forms.GroupBox();
            this.tireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.mufflerCheckBox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.partsAndLaborGroupBox = new System.Windows.Forms.GroupBox();
            this.laborLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.laborTextBox = new System.Windows.Forms.TextBox();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.summaryGB = new System.Windows.Forms.GroupBox();
            this.totalFeeLbl = new System.Windows.Forms.Label();
            this.taxTotalLbl = new System.Windows.Forms.Label();
            this.partsTotalLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceAndLaborLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.oilAndLubeGroupBox.SuspendLayout();
            this.flushesGroupBox.SuspendLayout();
            this.miscGroupBox.SuspendLayout();
            this.partsAndLaborGroupBox.SuspendLayout();
            this.summaryGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // oilAndLubeGroupBox
            // 
            this.oilAndLubeGroupBox.Controls.Add(this.lubeCheckBox);
            this.oilAndLubeGroupBox.Controls.Add(this.oilChangeCheckBox);
            this.oilAndLubeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.oilAndLubeGroupBox.Name = "oilAndLubeGroupBox";
            this.oilAndLubeGroupBox.Size = new System.Drawing.Size(200, 65);
            this.oilAndLubeGroupBox.TabIndex = 0;
            this.oilAndLubeGroupBox.TabStop = false;
            this.oilAndLubeGroupBox.Text = "Oil and Lube";
            // 
            // lubeCheckBox
            // 
            this.lubeCheckBox.AutoSize = true;
            this.lubeCheckBox.Location = new System.Drawing.Point(6, 42);
            this.lubeCheckBox.Name = "lubeCheckBox";
            this.lubeCheckBox.Size = new System.Drawing.Size(97, 17);
            this.lubeCheckBox.TabIndex = 2;
            this.lubeCheckBox.Text = "Lube Job ($18)";
            this.lubeCheckBox.UseVisualStyleBackColor = true;
            this.lubeCheckBox.CheckedChanged += new System.EventHandler(this.LubeCheckBox_CheckedChanged);
            // 
            // oilChangeCheckBox
            // 
            this.oilChangeCheckBox.AutoSize = true;
            this.oilChangeCheckBox.Location = new System.Drawing.Point(6, 19);
            this.oilChangeCheckBox.Name = "oilChangeCheckBox";
            this.oilChangeCheckBox.Size = new System.Drawing.Size(105, 17);
            this.oilChangeCheckBox.TabIndex = 1;
            this.oilChangeCheckBox.Text = "Oil Change ($26)";
            this.oilChangeCheckBox.UseVisualStyleBackColor = true;
            this.oilChangeCheckBox.CheckedChanged += new System.EventHandler(this.OilChangeCheckBox_CheckedChanged);
            // 
            // flushesGroupBox
            // 
            this.flushesGroupBox.Controls.Add(this.transmissionFlushCheckBox);
            this.flushesGroupBox.Controls.Add(this.radiatorFlushCheckBox);
            this.flushesGroupBox.Location = new System.Drawing.Point(218, 12);
            this.flushesGroupBox.Name = "flushesGroupBox";
            this.flushesGroupBox.Size = new System.Drawing.Size(200, 65);
            this.flushesGroupBox.TabIndex = 1;
            this.flushesGroupBox.TabStop = false;
            this.flushesGroupBox.Text = "Flushes";
            // 
            // transmissionFlushCheckBox
            // 
            this.transmissionFlushCheckBox.AutoSize = true;
            this.transmissionFlushCheckBox.Location = new System.Drawing.Point(6, 42);
            this.transmissionFlushCheckBox.Name = "transmissionFlushCheckBox";
            this.transmissionFlushCheckBox.Size = new System.Drawing.Size(142, 17);
            this.transmissionFlushCheckBox.TabIndex = 1;
            this.transmissionFlushCheckBox.Text = "Transmission Flush ($80)";
            this.transmissionFlushCheckBox.UseVisualStyleBackColor = true;
            this.transmissionFlushCheckBox.CheckedChanged += new System.EventHandler(this.TransmissionFlushCheckBox_CheckedChanged);
            // 
            // radiatorFlushCheckBox
            // 
            this.radiatorFlushCheckBox.AutoSize = true;
            this.radiatorFlushCheckBox.Location = new System.Drawing.Point(6, 19);
            this.radiatorFlushCheckBox.Name = "radiatorFlushCheckBox";
            this.radiatorFlushCheckBox.Size = new System.Drawing.Size(121, 17);
            this.radiatorFlushCheckBox.TabIndex = 0;
            this.radiatorFlushCheckBox.Text = "Radiator Flush ($30)";
            this.radiatorFlushCheckBox.UseVisualStyleBackColor = true;
            this.radiatorFlushCheckBox.CheckedChanged += new System.EventHandler(this.RadiatorFlushCheckBox_CheckedChanged);
            // 
            // miscGroupBox
            // 
            this.miscGroupBox.Controls.Add(this.tireRotationCheckBox);
            this.miscGroupBox.Controls.Add(this.mufflerCheckBox);
            this.miscGroupBox.Controls.Add(this.inspectionCheckBox);
            this.miscGroupBox.Location = new System.Drawing.Point(12, 83);
            this.miscGroupBox.Name = "miscGroupBox";
            this.miscGroupBox.Size = new System.Drawing.Size(200, 88);
            this.miscGroupBox.TabIndex = 2;
            this.miscGroupBox.TabStop = false;
            this.miscGroupBox.Text = "Misc";
            // 
            // tireRotationCheckBox
            // 
            this.tireRotationCheckBox.AutoSize = true;
            this.tireRotationCheckBox.Location = new System.Drawing.Point(6, 65);
            this.tireRotationCheckBox.Name = "tireRotationCheckBox";
            this.tireRotationCheckBox.Size = new System.Drawing.Size(114, 17);
            this.tireRotationCheckBox.TabIndex = 3;
            this.tireRotationCheckBox.Text = "Tire Rotation ($20)";
            this.tireRotationCheckBox.UseVisualStyleBackColor = true;
            this.tireRotationCheckBox.CheckedChanged += new System.EventHandler(this.TireRotationCheckBox_CheckedChanged);
            // 
            // mufflerCheckBox
            // 
            this.mufflerCheckBox.AutoSize = true;
            this.mufflerCheckBox.Location = new System.Drawing.Point(6, 42);
            this.mufflerCheckBox.Name = "mufflerCheckBox";
            this.mufflerCheckBox.Size = new System.Drawing.Size(134, 17);
            this.mufflerCheckBox.TabIndex = 2;
            this.mufflerCheckBox.Text = "Replace Muffler ($100)";
            this.mufflerCheckBox.UseVisualStyleBackColor = true;
            this.mufflerCheckBox.CheckedChanged += new System.EventHandler(this.MufflerCheckBox_CheckedChanged);
            // 
            // inspectionCheckBox
            // 
            this.inspectionCheckBox.AutoSize = true;
            this.inspectionCheckBox.Location = new System.Drawing.Point(6, 19);
            this.inspectionCheckBox.Name = "inspectionCheckBox";
            this.inspectionCheckBox.Size = new System.Drawing.Size(102, 17);
            this.inspectionCheckBox.TabIndex = 1;
            this.inspectionCheckBox.Text = "Inspection ($15)";
            this.inspectionCheckBox.UseVisualStyleBackColor = true;
            this.inspectionCheckBox.CheckedChanged += new System.EventHandler(this.InspectionCheckBox_CheckedChanged);
            // 
            // partsAndLaborGroupBox
            // 
            this.partsAndLaborGroupBox.Controls.Add(this.laborLabel);
            this.partsAndLaborGroupBox.Controls.Add(this.partsLabel);
            this.partsAndLaborGroupBox.Controls.Add(this.laborTextBox);
            this.partsAndLaborGroupBox.Controls.Add(this.partsTextBox);
            this.partsAndLaborGroupBox.Location = new System.Drawing.Point(218, 83);
            this.partsAndLaborGroupBox.Name = "partsAndLaborGroupBox";
            this.partsAndLaborGroupBox.Size = new System.Drawing.Size(200, 88);
            this.partsAndLaborGroupBox.TabIndex = 3;
            this.partsAndLaborGroupBox.TabStop = false;
            this.partsAndLaborGroupBox.Text = "Parts and Labor";
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(6, 58);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(89, 13);
            this.laborLabel.TabIndex = 3;
            this.laborLabel.Text = "Labor ($20/Hour)";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(49, 32);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(46, 13);
            this.partsLabel.TabIndex = 2;
            this.partsLabel.Text = "Parts ($)";
            this.partsLabel.Click += new System.EventHandler(this.PartsLabel_Click);
            // 
            // laborTextBox
            // 
            this.laborTextBox.Location = new System.Drawing.Point(101, 58);
            this.laborTextBox.Name = "laborTextBox";
            this.laborTextBox.Size = new System.Drawing.Size(48, 20);
            this.laborTextBox.TabIndex = 1;
            this.laborTextBox.TextChanged += new System.EventHandler(this.LaborTextBox_TextChanged);
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(101, 29);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(48, 20);
            this.partsTextBox.TabIndex = 0;
            this.partsTextBox.TextChanged += new System.EventHandler(this.PartsTextBox_TextChanged);
            // 
            // summaryGB
            // 
            this.summaryGB.Controls.Add(this.totalFeeLbl);
            this.summaryGB.Controls.Add(this.taxTotalLbl);
            this.summaryGB.Controls.Add(this.partsTotalLbl);
            this.summaryGB.Controls.Add(this.label4);
            this.summaryGB.Controls.Add(this.label3);
            this.summaryGB.Controls.Add(this.label2);
            this.summaryGB.Controls.Add(this.label1);
            this.summaryGB.Controls.Add(this.serviceAndLaborLbl);
            this.summaryGB.Location = new System.Drawing.Point(12, 177);
            this.summaryGB.Name = "summaryGB";
            this.summaryGB.Size = new System.Drawing.Size(406, 171);
            this.summaryGB.TabIndex = 4;
            this.summaryGB.TabStop = false;
            this.summaryGB.Text = "Summary and Totals";
            // 
            // totalFeeLbl
            // 
            this.totalFeeLbl.BackColor = System.Drawing.SystemColors.Window;
            this.totalFeeLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalFeeLbl.Location = new System.Drawing.Point(119, 135);
            this.totalFeeLbl.Name = "totalFeeLbl";
            this.totalFeeLbl.Size = new System.Drawing.Size(100, 23);
            this.totalFeeLbl.TabIndex = 7;
            // 
            // taxTotalLbl
            // 
            this.taxTotalLbl.BackColor = System.Drawing.SystemColors.Window;
            this.taxTotalLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxTotalLbl.Location = new System.Drawing.Point(119, 99);
            this.taxTotalLbl.Name = "taxTotalLbl";
            this.taxTotalLbl.Size = new System.Drawing.Size(100, 23);
            this.taxTotalLbl.TabIndex = 6;
            // 
            // partsTotalLbl
            // 
            this.partsTotalLbl.BackColor = System.Drawing.SystemColors.Window;
            this.partsTotalLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.partsTotalLbl.Location = new System.Drawing.Point(119, 62);
            this.partsTotalLbl.Name = "partsTotalLbl";
            this.partsTotalLbl.Size = new System.Drawing.Size(100, 23);
            this.partsTotalLbl.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tax (for parts)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service and Labor";
            // 
            // serviceAndLaborLbl
            // 
            this.serviceAndLaborLbl.BackColor = System.Drawing.SystemColors.Window;
            this.serviceAndLaborLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serviceAndLaborLbl.Location = new System.Drawing.Point(119, 29);
            this.serviceAndLaborLbl.Name = "serviceAndLaborLbl";
            this.serviceAndLaborLbl.Size = new System.Drawing.Size(100, 23);
            this.serviceAndLaborLbl.TabIndex = 0;
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.SystemColors.Window;
            this.calcBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcBtn.Location = new System.Drawing.Point(94, 354);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 5;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Location = new System.Drawing.Point(175, 354);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Location = new System.Drawing.Point(256, 354);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(430, 392);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.summaryGB);
            this.Controls.Add(this.partsAndLaborGroupBox);
            this.Controls.Add(this.miscGroupBox);
            this.Controls.Add(this.flushesGroupBox);
            this.Controls.Add(this.oilAndLubeGroupBox);
            this.Name = "Form1";
            this.Text = "Mason\'s Automotive";
            this.oilAndLubeGroupBox.ResumeLayout(false);
            this.oilAndLubeGroupBox.PerformLayout();
            this.flushesGroupBox.ResumeLayout(false);
            this.flushesGroupBox.PerformLayout();
            this.miscGroupBox.ResumeLayout(false);
            this.miscGroupBox.PerformLayout();
            this.partsAndLaborGroupBox.ResumeLayout(false);
            this.partsAndLaborGroupBox.PerformLayout();
            this.summaryGB.ResumeLayout(false);
            this.summaryGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oilAndLubeGroupBox;
        private System.Windows.Forms.CheckBox lubeCheckBox;
        private System.Windows.Forms.CheckBox oilChangeCheckBox;
        private System.Windows.Forms.GroupBox flushesGroupBox;
        private System.Windows.Forms.CheckBox transmissionFlushCheckBox;
        private System.Windows.Forms.CheckBox radiatorFlushCheckBox;
        private System.Windows.Forms.GroupBox miscGroupBox;
        private System.Windows.Forms.CheckBox tireRotationCheckBox;
        private System.Windows.Forms.CheckBox mufflerCheckBox;
        private System.Windows.Forms.CheckBox inspectionCheckBox;
        private System.Windows.Forms.GroupBox partsAndLaborGroupBox;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.TextBox laborTextBox;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.GroupBox summaryGB;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label totalFeeLbl;
        private System.Windows.Forms.Label taxTotalLbl;
        private System.Windows.Forms.Label partsTotalLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label serviceAndLaborLbl;
    }
}

