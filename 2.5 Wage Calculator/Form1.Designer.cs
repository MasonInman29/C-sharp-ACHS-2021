namespace _2._5_Wage_Calculator
{
    partial class PresQuestion
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
            this.answerLabel = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.revealAnswerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answerLabel
            // 
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.Location = new System.Drawing.Point(48, 77);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(200, 36);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(45, 37);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(195, 26);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "What former U.S. president is known for\r\ngoing on an African safari?";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.questionLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(173, 116);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 45);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // revealAnswerButton
            // 
            this.revealAnswerButton.Location = new System.Drawing.Point(48, 116);
            this.revealAnswerButton.Name = "revealAnswerButton";
            this.revealAnswerButton.Size = new System.Drawing.Size(75, 45);
            this.revealAnswerButton.TabIndex = 3;
            this.revealAnswerButton.Text = "Reveal Answer";
            this.revealAnswerButton.UseVisualStyleBackColor = true;
            this.revealAnswerButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // PresQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 173);
            this.Controls.Add(this.revealAnswerButton);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.answerLabel);
            this.Name = "PresQuestion";
            this.Text = "PresQuestion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button revealAnswerButton;
    }
}

