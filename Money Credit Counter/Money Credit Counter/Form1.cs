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
    }
}
