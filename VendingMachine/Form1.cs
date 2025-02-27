using System.Security.Policy;
using System.Windows.Forms;
using VendingMachine.Properties;

namespace VendingMachine
{
    public partial class Form1 : Form
    {
        private bool _myBool = false;
        private int _totalCost;
        private int _addedAmount;

        public Form1()
        {
            InitializeComponent();
            IntroMessage();
        }

        #region *** Item Selection ***
        private void pbZergling_Click(object sender, EventArgs e)
        {
            if (_myBool == true)
            {
                int itemCost = 25;
                int totalCost = _totalCost;

                if (itemCost > totalCost)
                {
                    lowFunds();
                }
                else if (totalCost <= 0)
                {
                    balanceBounce();
                }
                else
                {
                    itemPurchase(itemCost);
                    purchaseDisplay(itemCost);
                    txtDisplay.Text = "Two zerglings have been dispensed!";
                }
            }
            else
            {
                FailMessage();
            }
        }

        private void pbFlashDrive_Click(object sender, EventArgs e)
        {
            if (_myBool == true)
            {
                txtDisplay.Text = "Sorry, product is currently out of stock";
            }
            else
            {
                FailMessage();
            }
        }

        private void pbGamerFuel_Click(object sender, EventArgs e)
        {
            if (_myBool == true)
            {
                int itemCost = 50;
                int totalCost = _totalCost;

                if (itemCost > totalCost)
                {
                    lowFunds();
                }
                else if (totalCost <= 0)
                {
                    balanceBounce();
                }
                else
                {
                    itemPurchase(itemCost);
                    purchaseDisplay(itemCost);
                    txtDisplay.Text = "Product has been vended!";
                }
            }
            else
            {
                FailMessage();
            }
        }

        private void pbPeach_Click(object sender, EventArgs e)
        {
            if (_myBool == true)
            {
                txtDisplay.Text = "Sorry customer, but peach is in another vending machine";
            }
            else
            {
                FailMessage();
            }
        }

        private void pbRedPony_Click(object sender, EventArgs e)
        {
            if (_myBool == true)
            {
                int itemCost = -75;
                int totalCost = _totalCost;

                if (itemCost > totalCost)
                {
                    lowFunds();
                }
                else if (totalCost <= 0)
                {
                    balanceBounce();
                }
                else
                {
                    itemPurchase(itemCost);
                    purchaseDisplay(itemCost);
                    txtDisplay.Text = "The red pony is .. .. freeeeeee ??? PRODUCT HAS BEEN SET FOR DELIVERY!";
                }
            }
            else
            {
                FailMessage();
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            if (_myBool == true)
            {
                txtDisplay.Text = "I'm not for sale!  Make another selection!";
            }
            else
            {
                FailMessage();
            }
        }

        private void pbFungiFriends_Click(object sender, EventArgs e)
        {
            if (_myBool == true)
            {
                int itemCost = 25;
                int totalCost = _totalCost;

                if (itemCost > totalCost)
                {
                    lowFunds();
                }
                else if (totalCost <= 0)
                {
                    balanceBounce();
                }
                else
                {
                    itemPurchase(itemCost);
                    purchaseDisplay(itemCost);
                    txtDisplay.Text = "Let the warmth of this display warm your heart,and inspire you to follow their example.";
                }

                // Couple Mushroom Art
                DisplayPopup(
                    "The Couple Mushrooms",
                    "Celebrate love and connection with this enchanting couple mushroom print. Perfect for those who believe in soulmates and fungi that grow together!\n\nPrint Now at www.viberantzdesigns.com!"
                );
            }
            else
            {
                FailMessage();
            }
        }

        private void pbTravelingGuitarist_Click(object sender, EventArgs e)
        {
            if (_myBool == true)
            {
                int itemCost = 50;
                int totalCost = _totalCost;

                if (itemCost > totalCost)
                {
                    lowFunds();
                }
                else if (totalCost <= 0)
                {
                    balanceBounce();
                }
                else
                {
                    itemPurchase(itemCost);
                    purchaseDisplay(itemCost);
                    txtDisplay.Text = "Go on a journey and listing to the wild tales and melodies of the world!";
                }

                // Traveling Guitarist Mushroom Art
                DisplayPopup(
                    "The Traveling Guitarist Mushroom",
                    "Hit the road with the coolest mushroom in town! Whether it’s blues, rock, or a hint of jazz, this mushroom is strumming for your soul.\n\nPrint Now at www.viberantzdesigns.com!"
                );
            }
            else
            {
                FailMessage();
            }
        }

        private void pbNurse_Click(object sender, EventArgs e)
        {
            if (_myBool == true)
            {
                int itemCost = 15;
                int totalCost = _totalCost;

                if (itemCost > totalCost)
                {
                    lowFunds();
                }
                else if (totalCost <= 0)
                {
                    balanceBounce();
                }
                else
                {
                    itemPurchase(itemCost);
                    purchaseDisplay(itemCost);
                    txtDisplay.Text = "Cure your ailing heart with the nurturing hands of this sweet little angle.";
                }

                // Nurse Mushroom Art
                DisplayPopup(
                    "The Caring Nurse Mushroom",
                    "For the healers, the nurturers, and the ones who make the world better one bandage at a time! This nurse mushroom is for you!\n\nPrint Now at www.viberantzdesigns.com!"
                );
            }
            else
            {
                FailMessage();
            }
        }

        private void pbMotorcycle_Click(object sender, EventArgs e)
        {
            if (_myBool == true)
            {
                int itemCost = 25;
                int totalCost = _totalCost;

                if (itemCost > totalCost)
                {
                    lowFunds();
                }
                else if (totalCost <= 0)
                {
                    balanceBounce();
                }
                else
                {
                    purchaseDisplay(itemCost);
                    txtDisplay.Text = "Go for a ride and embrace your wild side with gusto knowing you have a bold heart!";
                }

                // Motorcycle Mushroom Art
                DisplayPopup(
                    "The Motorcycle Mushroom",
                    "Rev up your vibe with this bad-to-the-bone biker mushroom. Unique art for the wild souls who ride free and live boldly!\n\nPrint Now at www.viberantzdesigns.com!"
                );

            }
            else
            {
                FailMessage();
            }
        }
        #endregion

        #region *** Helper Method ***
        // Helper method for displaying pop-ups
        private void DisplayPopup(string title, string message)
        {
            DialogResult result = MessageBox.Show(
                $"{message}\n\nWould you like to visit the website now?",
                $"Unique Art for Unique Souls: {title}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
            );

            // Open the website if the user clicks 'Yes'
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://www.viberantzdesigns.com",
                    UseShellExecute = true
                });
            }
        }
        #endregion

        #region *** Card Medthods ***

        private void btnCard_Click(object sender, EventArgs e)
        {
            int Total;
            _myBool = true;
            txtDisplay.Text = "Card Accepted, make a selection...";
            txtCardValue.Text = "500 Brownie Points";
            balanceCheck(500);
            //bool to show card has been "swiped" or "inserted"
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

            //output message at beginning "welcome" and output messages when each picture
            // is clicked
        }

        private void btnVendOver_Click(object sender, EventArgs e)
        {
            _myBool = false;
            Application.Exit();
            //end vending process, then close program
        }
        #endregion

        #region *** Messages ***

        #region ** DisplayTxt **
        public void IntroMessage()
        {
            txtDisplay.Text = "Welcome to the First Stop Vending!\n Please make a selection and insert your bownie points.";
        }

        public void balanceBounce()
        {
            txtDisplay.Text = "Your account has no brownie points to spend...\n Please go refill your balance with more good deeds.";
        }

        public void lowFunds()
        {
            txtDisplay.Text = "You do not have enough Browie Points for this purchase. Do more for the world and come back again.";
        }

        public void FailMessage()
        {
            txtDisplay.Text = "Please insert card.";
        }
        #endregion

        #region ** CardValuetxt**
        public void purchaseDisplay(int itemCost)
        {
            txtCardValue.Text = "Cost: " + itemCost + " Brownie Points\n" + "Balance: " + _totalCost + " Brownie Points";
        }
        #endregion

        #endregion

        #region *** MathEngine ***
        public void balanceCheck(int totalCheck)
        {
            _totalCost = totalCheck;
        }

        public void itemPurchase(int itemCost)
        {
            _addedAmount = itemCost;
            arithmatic(itemCost);
        }

        public void arithmatic(int itemCost)
        {
            int total = _totalCost;
            total = total - itemCost;
            _totalCost = total;

        }
        #endregion
    }
}