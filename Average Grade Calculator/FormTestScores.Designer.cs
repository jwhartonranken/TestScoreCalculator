
namespace EX3_2
{
    partial class FormInputScores
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
            this.labelEnterScore = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelScoreNum = new System.Windows.Forms.Label();
            this.labelScoreSum = new System.Windows.Forms.Label();
            this.labelAvgScore = new System.Windows.Forms.Label();
            this.labelLowScore = new System.Windows.Forms.Label();
            this.labelHighScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEnterScore
            // 
            this.labelEnterScore.AutoSize = true;
            this.labelEnterScore.Location = new System.Drawing.Point(49, 40);
            this.labelEnterScore.Name = "labelEnterScore";
            this.labelEnterScore.Size = new System.Drawing.Size(439, 31);
            this.labelEnterScore.TabIndex = 0;
            this.labelEnterScore.Text = "Please enter a test score";
            // 
            // textBoxScore
            // 
            this.textBoxScore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxScore.Location = new System.Drawing.Point(49, 92);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(433, 38);
            this.textBoxScore.TabIndex = 0;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(210)))), ((int)(((byte)(187)))));
            this.buttonEnter.Location = new System.Drawing.Point(49, 151);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(128, 38);
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelScoreNum
            // 
            this.labelScoreNum.AutoSize = true;
            this.labelScoreNum.Location = new System.Drawing.Point(49, 210);
            this.labelScoreNum.Name = "labelScoreNum";
            this.labelScoreNum.Size = new System.Drawing.Size(303, 31);
            this.labelScoreNum.TabIndex = 3;
            this.labelScoreNum.Text = "Number of scores:";
            // 
            // labelScoreSum
            // 
            this.labelScoreSum.AutoSize = true;
            this.labelScoreSum.Location = new System.Drawing.Point(49, 262);
            this.labelScoreSum.Name = "labelScoreSum";
            this.labelScoreSum.Size = new System.Drawing.Size(337, 31);
            this.labelScoreSum.TabIndex = 4;
            this.labelScoreSum.Text = "Sum of test Scores:";
            // 
            // labelAvgScore
            // 
            this.labelAvgScore.AutoSize = true;
            this.labelAvgScore.Location = new System.Drawing.Point(49, 314);
            this.labelAvgScore.Name = "labelAvgScore";
            this.labelAvgScore.Size = new System.Drawing.Size(337, 31);
            this.labelAvgScore.TabIndex = 5;
            this.labelAvgScore.Text = "Average test score:";
            // 
            // labelLowScore
            // 
            this.labelLowScore.AutoSize = true;
            this.labelLowScore.Location = new System.Drawing.Point(49, 366);
            this.labelLowScore.Name = "labelLowScore";
            this.labelLowScore.Size = new System.Drawing.Size(320, 31);
            this.labelLowScore.TabIndex = 6;
            this.labelLowScore.Text = "Lowest test score:";
            // 
            // labelHighScore
            // 
            this.labelHighScore.AutoSize = true;
            this.labelHighScore.Location = new System.Drawing.Point(49, 418);
            this.labelHighScore.Name = "labelHighScore";
            this.labelHighScore.Size = new System.Drawing.Size(337, 31);
            this.labelHighScore.TabIndex = 7;
            this.labelHighScore.Text = "Highest test score:";
            // 
            // FormInputScores
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(188)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(657, 495);
            this.Controls.Add(this.labelHighScore);
            this.Controls.Add(this.labelLowScore);
            this.Controls.Add(this.labelAvgScore);
            this.Controls.Add(this.labelScoreSum);
            this.Controls.Add(this.labelScoreNum);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.labelEnterScore);
            this.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormInputScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Scores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterScore;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelScoreNum;
        private System.Windows.Forms.Label labelScoreSum;
        private System.Windows.Forms.Label labelAvgScore;
        private System.Windows.Forms.Label labelLowScore;
        private System.Windows.Forms.Label labelHighScore;
    }
}

