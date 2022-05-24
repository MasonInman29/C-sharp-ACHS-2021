using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch3_Statium_Seating_Project
{
    public partial class StadiumSeating : Form
    {
        int classASeats;
        int classBSeats;
        int classCSeats;
        public StadiumSeating()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void LblInputInstructions_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ClassAOutput_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            try
            {
                //converts user input into int variables
                classASeats = int.Parse(classAInput.Text);
                classBSeats = int.Parse(classBInput.Text);
                classCSeats = int.Parse(classCInput.Text);

                //finds money generated based on number of seats
                int revenue = classASeats * 15 + classBSeats * 12 + classCSeats * 9;

                ClassAOutput.Text = (classASeats * 15).ToString("c");
                ClassBOutput.Text = (classBSeats * 12).ToString("c");
                ClassCOutput.Text = (classCSeats * 9).ToString("c");

                totalOutput.Text = revenue.ToString("c");
            }
            catch
            {
                //display an error message
                MessageBox.Show("Invalid data was entered. Please enter integer values.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clears all text boxes
            classAInput.Text = "";
            classBInput.Text = "";
            classCInput.Text = "";
            ClassAOutput.Text = "";
            ClassBOutput.Text = "";
            ClassCOutput.Text = "";
            totalOutput.Text = "";

            //sets fields to default values
            classASeats = 0;
            classBSeats = 0;
            classCSeats = 0;
        }
    }
}
