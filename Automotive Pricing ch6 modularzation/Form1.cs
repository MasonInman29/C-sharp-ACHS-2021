using System;
using System.Windows.Forms;

namespace Automotive_Pricing_ch6_modularzation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double OilLubeCharges()
        {
            double price = 0;
            if (oilChangeCheckBox.Checked)
            {
                price += 26;
            }
            if (lubeCheckBox.Checked)
            {
                price += 18;
            }
            return price;
        }
        private double FlushCharges()
        {
            double price = 0;
            if (radiatorFlushCheckBox.Checked)
            {
                price += 30;
            }
            if (transmissionFlushCheckBox.Checked)
            {
                price += 80;
            }
            return price;
        }
        private double MiscCharges()
        {
            double price = 0;
            if (inspectionCheckBox.Checked)
            {
                price += 15;
            }
            if (mufflerCheckBox.Checked)
            {
                price += 100;
            }
            if (tireRotationCheckBox.Checked)
            {
                price += 20;
            }
            return price;
        }
        private double OtherCharges()
        {
            double partsPrice, laborPrice;
            try
            {
                if (partsTextBox.Text != "")
                {
                    Double.TryParse(partsTextBox.Text, out partsPrice);
                }
                else //if user has left TB empty
                {
                    partsPrice = 0;
                }
                if (laborTextBox.Text != "") //if there is a number, try to parse
                {
                    Double.TryParse(laborTextBox.Text, out laborPrice);
                }
                else //if TB is empty
                {
                    laborPrice = 0;
                }
                return partsPrice + laborPrice;
            }
            catch
            {
                MessageBox.Show("Error\n\nPlease enter an integer.");
                return 0;
            }
        }
        private double TaxCharges()
        {
            try
            {
                double tax = 0;
                if (partsTextBox.Text == "")
                {
                    return 0;
                }
                else if (double.Parse(partsTextBox.Text) > 0)
                {
                    tax += double.Parse(partsTextBox.Text) * .06; //6% tax
                }
                return tax;
            }
            catch
            {
                return 0;
            }
        }
        private double TotalCharges()
        {
            return OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges();
        }
        private void ClearOilLube()
        {
            oilChangeCheckBox.Checked = false;
            lubeCheckBox.Checked = false;
        }
        private void ClearFlushes()
        {
            radiatorFlushCheckBox.Checked = false;
            transmissionFlushCheckBox.Checked = false;
        }
        private void ClearMisc()
        {
            inspectionCheckBox.Checked = false;
            mufflerCheckBox.Checked = false;
            tireRotationCheckBox.Checked = false;
        }
        private void ClearOther()
        {
            partsTextBox.Text = "";
            laborTextBox.Text = "";
        }
        private void ClearFees()
        {
            serviceAndLaborLbl.Text = "";
            partsTotalLbl.Text = "";
            taxTotalLbl.Text = "";
            totalFeeLbl.Text = "";
        }
        private void PartsLabel_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OilChangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LubeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadiatorFlushCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TransmissionFlushCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InspectionCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MufflerCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TireRotationCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PartsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LaborTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            //sets all check boxes to unchecked, empties text boxes, clears labels
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            totalFeeLbl.Text = TotalCharges().ToString("c");
            taxTotalLbl.Text = TaxCharges().ToString("c");
            double parts = 0, labor = 0;
            //if it can be parsed an is not empty then parts is set to the user input
            if (Double.TryParse(partsTextBox.Text, out parts) && partsTextBox.Text != "")
            {
                parts = double.Parse(partsTextBox.Text);
            }
            else  //else it is set to 0
            {
                parts = 0;
            }
            if (Double.TryParse(laborTextBox.Text, out labor) && laborTextBox.Text != "") //if text is entered
            {
                labor = double.Parse(laborTextBox.Text);
            }
            else
            {
                labor = 0;
            }
            partsTotalLbl.Text = parts.ToString("c");
            serviceAndLaborLbl.Text = labor.ToString("c");


        }

    }
}
