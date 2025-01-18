using System.Security.Policy;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private bool myBool = false;
        private void pbZergling_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                txtDisplay.Text = "Two zerglings have been dispensed!";
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbFlashDrive_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                txtDisplay.Text = "Sorry, product is currently out of stock";
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbGamerFuel_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                txtDisplay.Text = "Product has been vended!";
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbPeach_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                txtDisplay.Text = "Sorry customer, but peach is in another vending machine";
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbRedPony_Click(object sender, EventArgs e)
        {
            if (myBool == true)
            {
                txtDisplay.Text = "The red pony is .. .. freeeeeee ??? PRODUCT HAS BEEN SET FOR DELIVERY!";
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            if (myBool == true) 
            {
                txtDisplay.Text = "I'm not for sale!  Make another selection!";
            }
            else
            {
                txtDisplay.Text = "Please insert card.";
            }
        }

 
        private void btnCard_Click(object sender, EventArgs e)
        {
            myBool = true;
            txtDisplay.Text = "Card Accepted, make a selection...";
            //bool to show card has been "swiped" or "inserted"
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            
            //output message at beginning "welcome" and output messages when each picture
            // is clicked
        }

        private void btnVendOver_Click(object sender, EventArgs e)
        {
            myBool = false;
            Application.Exit();
            //end vending process, then close program
        }
    }
}
