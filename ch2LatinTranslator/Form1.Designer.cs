namespace ch2LatinTranslator
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
            this.leftButton = new System.Windows.Forms.Button();
            this.centerButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.latinText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(26, 360);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(158, 53);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // centerButton
            // 
            this.centerButton.Location = new System.Drawing.Point(210, 360);
            this.centerButton.Name = "centerButton";
            this.centerButton.Size = new System.Drawing.Size(158, 53);
            this.centerButton.TabIndex = 1;
            this.centerButton.Text = "Center";
            this.centerButton.UseVisualStyleBackColor = true;
            this.centerButton.Click += new System.EventHandler(this.CenterButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(400, 360);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(158, 53);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(252, 419);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(62, 19);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 92);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click the left,  right, and center buttons to have those\r\n\r\nwords translated into" +
    " latin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latinText
            // 
            this.latinText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.latinText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latinText.Font = new System.Drawing.Font("MS PGothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latinText.Location = new System.Drawing.Point(62, 157);
            this.latinText.Name = "latinText";
            this.latinText.Size = new System.Drawing.Size(456, 175);
            this.latinText.TabIndex = 5;
            this.latinText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.latinText.Click += new System.EventHandler(this.LatinText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.latinText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.centerButton);
            this.Controls.Add(this.leftButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button centerButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label latinText;
    }
}

