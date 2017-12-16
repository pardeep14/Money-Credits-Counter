using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Credit_Counter
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1p_Click(object sender, EventArgs e)
        {
            double  CostPerCredit   = Convert.ToDouble(txtCostPerCredit.Text);         //converting the GUI text values 
            int     _1pEnt          = Convert.ToInt32(txt1pEnt.Text);                  //to usable variables
            int     TotalValuePence = Convert.ToInt32(txtTotalVPnc.Text);
            double  TotalValuePound = Convert.ToDouble(txtTotalVPnd.Text);
            double  CreditsTotal    = Convert.ToDouble(txtCurrentCredits.Text);

            if (CostPerCredit <= 0)                                                    //check if cost per credit is entered.
            {
                MessageBox.Show("Please Enter a Cost Per Credit");                     //if CostPerCredit is not entered
            }                                                                          //the user is prompted to do so
            else
            {
                _1pEnt = _1pEnt + 1;                                                   //increment amount of 1p entered.
                txt1pEnt.Text = Convert.ToString(_1pEnt);                              //displaying new amount of 1p entered.

                TotalValuePence = TotalValuePence + 1;                                 //increments the total pence counter.
                txtTotalVPnc.Text = Convert.ToString(TotalValuePence);                 //displays the new pence value. 

                TotalValuePound = TotalValuePound + 0.01;                              //increments the total pound counter.
                txtTotalVPnd.Text = string.Format("{0:n2}", TotalValuePound);          //displays the new pound value.

                CreditsTotal = TotalValuePence / CostPerCredit;                        //calculates the total credits.
                txtCurrentCredits.Text = Convert.ToString(Math.Floor(CreditsTotal));   //displayes the total credits while rounding down,
                                                                                       //so that only an integer value of credits is shown
            }          
        }

        private void btn2p_Click(object sender, EventArgs e)
        {
            double  CostPerCredit   = Convert.ToDouble(txtCostPerCredit.Text);         //converting the GUI text values 
            int     _2pEnt          = Convert.ToInt32(txt2pEnt.Text);                  //to usable variables
            int     TotalValuePence = Convert.ToInt32(txtTotalVPnc.Text);
            double  TotalValuePound = Convert.ToDouble(txtTotalVPnd.Text);
            double  CreditsTotal    = Convert.ToDouble(txtCurrentCredits.Text);

            if (CostPerCredit <= 0)                                                    //check if cost per credit is entered.
            {
                MessageBox.Show("Please Enter a Cost Per Credit");                     //if CostPerCredit is not entered
            }                                                                          //the user is prompted to do so
            else
            {
                _2pEnt = _2pEnt + 1;                                                   //increment amount of 2p entered.
                txt2pEnt.Text = Convert.ToString(_2pEnt);                              //displaying new amount of 2p entered.

                TotalValuePence = TotalValuePence + 2;                                 //increments the total pence counter.
                txtTotalVPnc.Text = Convert.ToString(TotalValuePence);                 //displays the new pence value. 

                TotalValuePound = TotalValuePound + 0.02;                              //increments the total pound counter.
                txtTotalVPnd.Text = string.Format("{0:n2}", TotalValuePound);          //displays the new pound value.

                CreditsTotal = TotalValuePence / CostPerCredit;                        //calculates the total credits.
                txtCurrentCredits.Text = Convert.ToString(Math.Floor(CreditsTotal));   //displayes the total credits while rounding down,
                                                                                       //so that only an integer value of credits is shown
            }
        }

        private void btn5p_Click(object sender, EventArgs e)
        {
            double  CostPerCredit   = Convert.ToDouble(txtCostPerCredit.Text);         //converting the GUI text values 
            int     _5pEnt          = Convert.ToInt32(txt5pEnt.Text);                  //to usable variables
            int     TotalValuePence = Convert.ToInt32(txtTotalVPnc.Text);
            double  TotalValuePound = Convert.ToDouble(txtTotalVPnd.Text);
            double  CreditsTotal    = Convert.ToDouble(txtCurrentCredits.Text);

            if (CostPerCredit <= 0)                                                    //check if cost per credit is entered.
            {
                MessageBox.Show("Please Enter a Cost Per Credit");                     //if CostPerCredit is not entered
            }                                                                          //the user is prompted to do so
            else
            {
                _5pEnt = _5pEnt + 1;                                                   //increment amount of 5p entered.
                txt5pEnt.Text = Convert.ToString(_5pEnt);                              //displaying new amount of 5p entered.

                TotalValuePence = TotalValuePence + 5;                                 //increments the total pence counter.
                txtTotalVPnc.Text = Convert.ToString(TotalValuePence);                 //displays the new pence value. 

                TotalValuePound = TotalValuePound + 0.05;                              //increments the total pound counter.
                txtTotalVPnd.Text = string.Format("{0:n2}", TotalValuePound);          //displays the new pound value.

                CreditsTotal = TotalValuePence / CostPerCredit;                        //calculates the total credits.
                txtCurrentCredits.Text = Convert.ToString(Math.Floor(CreditsTotal));   //displayes the total credits while rounding down,
                                                                                       //so that only an integer value of credits is shown
            }
        }

        private void btn10p_Click(object sender, EventArgs e)
        {
            double  CostPerCredit   = Convert.ToDouble(txtCostPerCredit.Text);         //converting the GUI text values 
            int     _10pEnt          = Convert.ToInt32(txt10pEnt.Text);                  //to usable variables
            int     TotalValuePence = Convert.ToInt32(txtTotalVPnc.Text);
            double  TotalValuePound = Convert.ToDouble(txtTotalVPnd.Text);
            double  CreditsTotal    = Convert.ToDouble(txtCurrentCredits.Text);

            if (CostPerCredit <= 0)                                                    //check if cost per credit is entered.
            {
                MessageBox.Show("Please Enter a Cost Per Credit");                     //if CostPerCredit is not entered
            }                                                                          //the user is prompted to do so
            else
            {
                _10pEnt = _10pEnt + 1;                                                 //increment amount of 10p entered.
                txt10pEnt.Text = Convert.ToString(_10pEnt);                            //displaying new amount of 10p entered.

                TotalValuePence = TotalValuePence + 10;                                //increments the total pence counter.
                txtTotalVPnc.Text = Convert.ToString(TotalValuePence);                 //displays the new pence value. 

                TotalValuePound = TotalValuePound + 0.10;                              //increments the total pound counter.
                txtTotalVPnd.Text = string.Format("{0:n2}", TotalValuePound);          //displays the new pound value.

                CreditsTotal = TotalValuePence / CostPerCredit;                        //calculates the total credits.
                txtCurrentCredits.Text = Convert.ToString(Math.Floor(CreditsTotal));   //displayes the total credits while rounding down,
                                                                                       //so that only an integer value of credits is shown
            }
        }

        private void btn20p_Click(object sender, EventArgs e)
        {
            double  CostPerCredit   = Convert.ToDouble(txtCostPerCredit.Text);         //converting the GUI text values 
            int     _20pEnt         = Convert.ToInt32(txt20pEnt.Text);                  //to usable variables
            int     TotalValuePence = Convert.ToInt32(txtTotalVPnc.Text);
            double  TotalValuePound = Convert.ToDouble(txtTotalVPnd.Text);
            double  CreditsTotal    = Convert.ToDouble(txtCurrentCredits.Text);

            if (CostPerCredit <= 0)                                                    //check if cost per credit is entered.
            {
                MessageBox.Show("Please Enter a Cost Per Credit");                     //if CostPerCredit is not entered
            }                                                                          //the user is prompted to do so
            else
            {
                _20pEnt = _20pEnt + 1;                                                 //increment amount of 20p entered.
                txt20pEnt.Text = Convert.ToString(_20pEnt);                            //displaying new amount of 20p entered.

                TotalValuePence = TotalValuePence + 20;                                //increments the total pence counter.
                txtTotalVPnc.Text = Convert.ToString(TotalValuePence);                 //displays the new pence value. 

                TotalValuePound = TotalValuePound + 0.20;                              //increments the total pound counter.
                txtTotalVPnd.Text = string.Format("{0:n2}", TotalValuePound);          //displays the new pound value.

                CreditsTotal = TotalValuePence / CostPerCredit;                        //calculates the total credits.
                txtCurrentCredits.Text = Convert.ToString(Math.Floor(CreditsTotal));   //displayes the total credits while rounding down,
                                                                                       //so that only an integer value of credits is shown
            }
        }

        private void btn50p_Click(object sender, EventArgs e)
        {
            double  CostPerCredit   = Convert.ToDouble(txtCostPerCredit.Text);         //converting the GUI text values 
            int     _50pEnt         = Convert.ToInt32(txt50pEnt.Text);                  //to usable variables
            int     TotalValuePence = Convert.ToInt32(txtTotalVPnc.Text);
            double  TotalValuePound = Convert.ToDouble(txtTotalVPnd.Text);
            double  CreditsTotal    = Convert.ToDouble(txtCurrentCredits.Text);

            if (CostPerCredit <= 0)                                                    //check if cost per credit is entered.
            {
                MessageBox.Show("Please Enter a Cost Per Credit");                     //if CostPerCredit is not entered
            }                                                                          //the user is prompted to do so
            else
            {
                _50pEnt = _50pEnt + 1;                                                 //increment amount of 50p entered.
                txt50pEnt.Text = Convert.ToString(_50pEnt);                            //displaying new amount of 50p entered.

                TotalValuePence = TotalValuePence + 50;                                //increments the total pence counter.
                txtTotalVPnc.Text = Convert.ToString(TotalValuePence);                 //displays the new pence value. 

                TotalValuePound = TotalValuePound + 0.50;                              //increments the total pound counter.
                txtTotalVPnd.Text = string.Format("{0:n2}", TotalValuePound);          //displays the new pound value.

                CreditsTotal = TotalValuePence / CostPerCredit;                        //calculates the total credits.
                txtCurrentCredits.Text = Convert.ToString(Math.Floor(CreditsTotal));   //displayes the total credits while rounding down,
                                                                                       //so that only an integer value of credits is shown
            }
        }

        private void btn100p_Click(object sender, EventArgs e)
        {
            double  CostPerCredit   = Convert.ToDouble(txtCostPerCredit.Text);         //converting the GUI text values 
            int     _100pEnt        = Convert.ToInt32(txt100pEnt.Text);                //to usable variables
            int     TotalValuePence = Convert.ToInt32(txtTotalVPnc.Text);
            double  TotalValuePound = Convert.ToDouble(txtTotalVPnd.Text);
            double  CreditsTotal    = Convert.ToDouble(txtCurrentCredits.Text);

            if (CostPerCredit <= 0)                                                    //check if cost per credit is entered.
            {
                MessageBox.Show("Please Enter a Cost Per Credit");                     //if CostPerCredit is not entered
            }                                                                          //the user is prompted to do so
            else
            {
                _100pEnt = _100pEnt + 1;                                               //increment amount of 100p entered.
                txt100pEnt.Text = Convert.ToString(_100pEnt);                          //displaying new amount of 100p entered.

                TotalValuePence = TotalValuePence + 100;                               //increments the total pence counter.
                txtTotalVPnc.Text = Convert.ToString(TotalValuePence);                 //displays the new pence value. 

                TotalValuePound = TotalValuePound + 1.00;                              //increments the total pound counter.
                txtTotalVPnd.Text = string.Format("{0:n2}", TotalValuePound);          //displays the new pound value.

                CreditsTotal = TotalValuePence / CostPerCredit;                        //calculates the total credits.
                txtCurrentCredits.Text = Convert.ToString(Math.Floor(CreditsTotal));   //displayes the total credits while rounding down,
                                                                                       //so that only an integer value of credits is shown
            }
        }

        private void btn200p_Click(object sender, EventArgs e)
        {
            double  CostPerCredit   = Convert.ToDouble(txtCostPerCredit.Text);         //converting the GUI text values 
            int     _200pEnt        = Convert.ToInt32(txt200pEnt.Text);                //to usable variables
            int     TotalValuePence = Convert.ToInt32(txtTotalVPnc.Text);
            double  TotalValuePound = Convert.ToDouble(txtTotalVPnd.Text);
            double  CreditsTotal    = Convert.ToDouble(txtCurrentCredits.Text);

            if (CostPerCredit <= 0)                                                    //check if cost per credit is entered.
            {
                MessageBox.Show("Please Enter a Cost Per Credit");                     //if CostPerCredit is not entered
            }                                                                          //the user is prompted to do so
            else
            {
                _200pEnt = _200pEnt + 1;                                               //increment amount of 200p entered.
                txt200pEnt.Text = Convert.ToString(_200pEnt);                          //displaying new amount of 200p entered.

                TotalValuePence = TotalValuePence + 200;                               //increments the total pence counter.
                txtTotalVPnc.Text = Convert.ToString(TotalValuePence);                 //displays the new pence value. 

                TotalValuePound = TotalValuePound + 2.00;                              //increments the total pound counter.
                txtTotalVPnd.Text = string.Format("{0:n2}", TotalValuePound);          //displays the new pound value.

                CreditsTotal = TotalValuePence / CostPerCredit;                        //calculates the total credits.
                txtCurrentCredits.Text = Convert.ToString(Math.Floor(CreditsTotal));   //displayes the total credits while rounding down,
                                                                                       //so that only an integer value of credits is shown
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTotalVPnd.Text       = Convert.ToString(0.00);                         //Clicking the reset button returns all 
            txtCostPerCredit.Text   = Convert.ToString(0.00);                         //values to 0
            txtCurrentCredits.Text  = Convert.ToString(0.00);                         
            txtTotalVPnc.Text       = Convert.ToString(0);
            txt1pEnt.Text           = Convert.ToString(0);
            txt2pEnt.Text           = Convert.ToString(0);
            txt5pEnt.Text           = Convert.ToString(0);
            txt10pEnt.Text          = Convert.ToString(0);
            txt20pEnt.Text          = Convert.ToString(0);
            txt50pEnt.Text          = Convert.ToString(0);
            txt100pEnt.Text         = Convert.ToString(0);
            txt200pEnt.Text         = Convert.ToString(0);
        }
    }
}
