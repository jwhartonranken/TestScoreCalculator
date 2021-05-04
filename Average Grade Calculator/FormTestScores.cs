using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * James Wharton
 * 
 * This code allows the user to enter a set of grades from a recent test. The program will accept the grade,
 * calculate the minimum, maximum, average, and then add together the sum. It checkss for numeric values and ensures the grade is between 0 and 100
 * inclusively.
 */


namespace EX3_2
{
    public partial class FormInputScores : Form
    {
        public FormInputScores()
        {
            InitializeComponent();
        }

        const double MINGRADE = 0;
        const double MAXGRADE = 100;
        double grade = 0;
        bool keepGoing = true;
        int scoreNum = 0;
        double scoreSum = 0;
        double lowestScore = 10000000;
        double highestScore = -100;
        
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            keepGoing = true;

            AcceptScore();
            if (keepGoing)
            {
                AddScore(grade);
            }
        }

        private void AcceptScore()
        {
            try
            {
                string gradeStr = textBoxScore.Text;
                bool isNumeric = true;
                isNumeric = ValidateIsNumeric(gradeStr);
                if (!isNumeric)
                {
                    throw new ArgumentException(
                        string.Format("Grade must be numeric."));
                }
                grade = Convert.ToDouble(gradeStr);
                if (grade < MINGRADE || grade > MAXGRADE)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format("Grade must be between 0 and 100"));
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                keepGoing = false;
                textBoxScore.Text = "";
                textBoxScore.Focus();
                MessageBox.Show("Exception Occurred\n" + ex.Message,
                              "OUT OF RANGE EXCEPTION!!!",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

            }
            catch (ArgumentException ex)
            {
                keepGoing = false;
                textBoxScore.Text = "";
                textBoxScore.Focus();
                MessageBox.Show("Exception Occurred\nGrade must be numeric.",
                              "FORMAT EXCEPTION!!!",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void AddScore(double grade)
        {
            scoreNum++;
            labelScoreNum.Text = "Number of scores: " + scoreNum;

            scoreSum += grade;
            labelScoreSum.Text = "Sum of test scores: " + scoreSum;

            double scoreAvg = scoreSum / scoreNum;
            labelAvgScore.Text = "Average test score: " + scoreAvg.ToString("f1");

            if (grade < lowestScore) { lowestScore = grade; }
            if (grade > highestScore) { highestScore = grade; }

            labelLowScore.Text = "Lowest test score: " + Convert.ToString(lowestScore);
            labelHighScore.Text = "Highest test score: " + Convert.ToString(highestScore);

        }

        private bool ValidateIsNumeric(string grade)
        {
            double test = 0;

            return double.TryParse(grade, out test);
        }
    }
}
