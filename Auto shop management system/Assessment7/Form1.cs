/*Ahmed Matoussi
 * email: ahmedgeek1@gmail.com
 * This application is to calculate the total of money the customer owes after having services at Joe's automotive
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment7
{
    public partial class JoeAutomotive : Form
    {
        public JoeAutomotive()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //when the form loads the labels and textboxes of the Car Rental box are invisible
            txtBoxDailyPrice.Visible = false;
            lblNumberOfDaysRentalCarPrompt.Visible = false;
            txtBoxNumberOfDaysRentalCar.Visible = false;
            lblUserDailyPricePrompt.Visible = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            //declare variables and parameters to be used for each method
            int numberOfDays = 0;
            double partsTax = 0;
            decimal partsVar, parts, dailyPrice = 0;
            decimal servicesAndLaborSummaryTotal;

            //declare variables to store the results of methods needed (to avoid repetitioon of calling method everytime)
            decimal rentalCharges = RentalCharges(ref numberOfDays, ref dailyPrice);
            /*Here I am adding the rentalCharges to the totalCharges and storing them in a new variable totalCharges  (eliminate duplication of
             * validation message explained later in the totalCharges() method (see below totalCharges() method))
             */
            decimal totalCharges = TotalCharges() /*+ rentalCharges*/; //add the rentalCharges variable as part of the deplication solution
            decimal taxCharges = Convert.ToDecimal(TaxCharges(ref partsTax));

                if (decimal.TryParse(txtBoxPartsInput.Text, out parts) && parts>0)
                {  //if the input in the parts textbox is positive and valid decimal
                    partsVar = Convert.ToDecimal(txtBoxPartsInput.Text);
                }
            else
            {   //the partsVar get 0
                partsVar = 0;
            }

                servicesAndLaborSummaryTotal =totalCharges - (partsVar + taxCharges); //substract the parts costs and its taxcharge from the totalcharge for services because it is not service
                lblTotalFeesSummaryOutput.Text = totalCharges.ToString("c"); //total charges
                lblServicesAndLaborSummaryOutput.Text = (servicesAndLaborSummaryTotal - rentalCharges).ToString("c"); //services and labor - rentals
                lblRentalChargesOutput.Text = rentalCharges.ToString("c"); //rental charges 
                lblPartsSummaryOutput.Text = partsVar.ToString("c"); //parts costs
                lblTaxSummaryOutput.Text = taxCharges.ToString("c"); // parts tax charges
            
        }


        private decimal OilLubeCharges()
        {
            //method to return the charges of the opil and lube
            //declaring variables
            decimal oilCharges = 0m, lubeCharges = 0m, oilLubeSumCharges = 0m;

            //run conditionals on the checkboxes
            if(checkBoxOilChange.Checked == true && checkBoxLubeJob.Checked == false)
            {
                oilCharges = 26m;
                lubeCharges = 0m;
            }
            else if (checkBoxOilChange.Checked == false && checkBoxLubeJob.Checked == true)
            {
                oilCharges = 0m;
                lubeCharges = 18m;
            }
            else if (checkBoxOilChange.Checked == true && checkBoxLubeJob.Checked == true)
            {
                oilCharges = 26m;
                lubeCharges = 18m;
            }
            else
            {
                oilCharges = 0m;
                lubeCharges = 0m;
            }

            //sum of oilcharges and lube charges
            oilLubeSumCharges = oilCharges + lubeCharges;
            //return the sum
            return oilLubeSumCharges;
        }

        private decimal FlushCharges()
        {
            //method to return charges of the Flush services
            //declare variables 
            decimal radiatorCharges = 0m, transmissionCharges = 0m, radiatorTransmissionSumCharges = 0m;
            
            //run conditionals on the checkboxes
            if (checkBoxRadiatorFlush.Checked == true && checkBoxTransmissionFlush.Checked == false)
            {
                radiatorCharges = 30m;
                transmissionCharges = 0m;
            }
            else if (checkBoxTransmissionFlush.Checked == true && checkBoxRadiatorFlush.Checked == false)
            {
                radiatorCharges = 0m;
                transmissionCharges = 80m;
            }
            else if(checkBoxTransmissionFlush.Checked == true && checkBoxRadiatorFlush.Checked == true)
            {
                radiatorCharges = 30m;
                transmissionCharges = 80m;
            }
            else
            {
                radiatorCharges = 0m;
                transmissionCharges = 0m;
            }

            //sum of radiator and transmission charges
            radiatorTransmissionSumCharges = radiatorCharges + transmissionCharges;
            //return the sum
            return radiatorTransmissionSumCharges;
        }


        private decimal MiscCharges()
        {
            //method to return charges of misc services
            //declaring variables to be used in this method 
            decimal inspectionCharges = 0m, replaceMufferCharges = 0m, tireRotationCharges = 0m, miscSumCharges = 0m;
            //run conditionals on the checkboxes
            if (checkBoxInspection.Checked == true)
            {
                inspectionCharges = 15m;
            }
            
            if(checkBoxReplaceMuffler.Checked == true)
            {
                replaceMufferCharges = 100m;
            }

            if(checkBoxTireRotation.Checked == true)
            {
                tireRotationCharges = 20m;
            }

            //sum of the misc services charges
            miscSumCharges = inspectionCharges + replaceMufferCharges + tireRotationCharges;
            //return the sum
            return miscSumCharges;
        }

        private decimal OtherCharges(ref decimal parts, ref decimal labor)
        {
            //method to return different charges
            //declare variables
            decimal partsCharges, laborCharges, otherSumCharges;

            //run conditionals and datavalidation on the textboxes
            if (txtBoxPartsInput.Text !="" && decimal.TryParse(txtBoxPartsInput.Text, out parts) && parts >=0)
            {
                partsCharges = parts;
            }
            else if(txtBoxPartsInput.Text == "")
            {
                partsCharges = 0m;
            }
            else
            {
                partsCharges = 0m;
                MessageBox.Show("Please enter a valid positive parts cost");
                txtBoxPartsInput.Focus();
            }

            if(decimal.TryParse(txtBoxLaborInput.Text, out labor) && labor >= 0)
            {
                laborCharges = labor * 20;
            }
            else if (txtBoxLaborInput.Text == "")
            {
                laborCharges = 0m;
            }
            else
            {
                laborCharges = 0m;
                MessageBox.Show("Please enter a valid positive labor hours number");
                txtBoxLaborInput.Focus();
            }

            //sum of the other different charges
            otherSumCharges = laborCharges + partsCharges;
            //return the sum of the other different charges
            return otherSumCharges;
        }

        private decimal RentalCharges(ref int numberOfDays, ref decimal dailyPrice)
        {
            //method to return the charges of a rental car
            //declare the variables to be used in this method
            decimal DAILY_CAR_RENTAL_PRICE = 50m;
            decimal carRentalSumCharges = 0m;

            //run conditionals on the checkboxe
            //if the checkbox is checked 
            if (checkBoxRentalCar.Checked == true)
            {//run the datavalidation and the calculation of the rental charges
                if(decimal.TryParse(txtBoxDailyPrice.Text, out dailyPrice) && dailyPrice > 0)
                    {
                       if (dailyPrice > 0)
                      {
                            DAILY_CAR_RENTAL_PRICE = dailyPrice;
                        } else
                       {
                        DAILY_CAR_RENTAL_PRICE = 0m;
                        MessageBox.Show("Please enter a positive Daily price");
                        txtBoxDailyPrice.Focus();
                        }
                    }
                else if(txtBoxDailyPrice.Text == "")
                {
                    DAILY_CAR_RENTAL_PRICE = 50m;
                }
                else 
                {
                    DAILY_CAR_RENTAL_PRICE = 0m;
                    MessageBox.Show("Please enter a valid positive Daily price");
                    txtBoxDailyPrice.Focus();
                }

                if (int.TryParse(txtBoxNumberOfDaysRentalCar.Text, out numberOfDays))
                {
                    if (numberOfDays > 0)
                    {
                        carRentalSumCharges = numberOfDays * DAILY_CAR_RENTAL_PRICE;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a positive number of days");
                        txtBoxNumberOfDaysRentalCar.Focus();
                    }
                }
                else if (txtBoxNumberOfDaysRentalCar.Text == "")
                {
                    numberOfDays = 1;
                    carRentalSumCharges = numberOfDays * DAILY_CAR_RENTAL_PRICE;
                }
                else
                {
                    MessageBox.Show("Please enter a valid positive number of days");
                    txtBoxNumberOfDaysRentalCar.Focus();
                }

                if (decimal.TryParse(txtBoxDailyPrice.Text, out dailyPrice) && int.TryParse(txtBoxNumberOfDaysRentalCar.Text, out numberOfDays) && dailyPrice>0 && numberOfDays>0)
                {
                    carRentalSumCharges = numberOfDays * dailyPrice;
                }
            }

            //return the sum of all charges
            return carRentalSumCharges;
        }


       private double TaxCharges(ref double partsTax)
        {
            //method that returns the tax charges of the parts
            //declare the variable 
            double taxSumCharges;
            if (double.TryParse(txtBoxPartsInput.Text, out partsTax) && partsTax > 0)
            {
                taxSumCharges = partsTax * 0.06; //calculate the tax
            }
            else
            {
                taxSumCharges = 0;
            }

            return taxSumCharges;
       }

        private decimal TotalCharges()
        {
            //method to call all other methods and to return the sum of all charges for the user
            //declaring variables
            decimal totalSumCharges;
            decimal parts = 0m, labor = 0m, dailyPrice = 0m;
            int numberOfDays = 0;
            double partsTax = 0;
            decimal rentalCharges = RentalCharges(ref numberOfDays, ref dailyPrice);
            totalSumCharges = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges(ref parts, ref labor) +
                /*Explanation to understand why I think I should comment the rentalCharges() here
                 * So if I call the rentalCharges() here and in the btnCalculateTotal_Click() method, then the rentalCharges() method will be called
                 * 2 times, and that will create a duplicate validation MessageBoxes telling the user to enter a valid entry
                 * eliminating this here, and calling the rentalCharges()  only once in the btnCalculateTotal_Click() method will help us not having 
                 * the duplicate messageBox  
                 *In both cases the functionalities will work perfectly fine,
                 *  
                 * RentalCharges(ref numberOfDays, ref dailyPrice) +
                 * 
                 * I will keep it in the code, as it's the requirement in the assignment, but I would like to delete it from here as explained
                 * for the application to be more perfect
                 */
                 + rentalCharges+ Convert.ToDecimal(TaxCharges(ref partsTax));
            //return the sum of charges
            return totalSumCharges;
        }

        private void ClearOilLube()
        {
            //method to clear the checkboxes of the oilLube box
            checkBoxOilChange.Checked = false;
            checkBoxLubeJob.Checked = false;
        }

        private void ClearFlushes()
        {//method to clear the checkboxes of the Flushes box
            checkBoxRadiatorFlush.Checked = false;
            checkBoxTransmissionFlush.Checked = false;
        }

        private void ClearMisc()
        {//method to clear the checkboxes of the Misc box
            checkBoxInspection.Checked = false;
            checkBoxReplaceMuffler.Checked = false;
            checkBoxTireRotation.Checked = false;
        }

        private void ClearOther()
        {//method to clear the textBoxes of the other box
            txtBoxLaborInput.Text = "";
            txtBoxPartsInput.Text = "";
        }

        private void ClearFees()
        {//method to clear the labels that has results and fees
            lblServicesAndLaborSummaryOutput.Text = "";
            lblTaxSummaryOutput.Text = "";
            lblPartsSummaryOutput.Text = "";
            lblTotalFeesSummaryOutput.Text = "";
            lblRentalChargesOutput.Text = "";
        }

        private void ClearRental()
        {//method to clear the checkbox and the textboxes of the rental box
            checkBoxRentalCar.Checked = false;
            txtBoxDailyPrice.Text = "";
            txtBoxNumberOfDaysRentalCar.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {  //on click on the button clear, the method call all clear methods to clear all the form checkboxes and textboxes and labels
            ClearFees();
            ClearFlushes();
            ClearMisc();
            ClearOilLube();
            ClearOther();
            ClearRental();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
        }

        private void checkBoxRentalCar_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxDailyPrice.Visible = checkBoxRentalCar.Checked; //on checkbox, the textbox of the daily price appears
            lblUserDailyPricePrompt.Visible = checkBoxRentalCar.Checked;//on checkbox, the label prompt of the daily price appears
            txtBoxNumberOfDaysRentalCar.Visible = checkBoxRentalCar.Checked;//on checkbox, the textbox of the number of days for renting the car appears
            lblNumberOfDaysRentalCarPrompt.Visible = checkBoxRentalCar.Checked;//on checkbox, the label prompt of the daily price appear

        }
    }
}
