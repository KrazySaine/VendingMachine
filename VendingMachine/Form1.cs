namespace VendingMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbZergling_Click(object sender, EventArgs e)
        {
            //"Two zerglings have been dispensed!"
        }

        private void pbFlashDrive_Click(object sender, EventArgs e)
        {
            //"sorry, product is currently out of stock"
        }

        private void pbGamerFuel_Click(object sender, EventArgs e)
        {
            //"product has been vended"
        }

        private void pbPeach_Click(object sender, EventArgs e)
        {
            //"sorry customer, but peach is in another vending machine"
        }

        private void pbRedPony_Click(object sender, EventArgs e)
        {
            //The red pony is.... freeeeeee???
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            //message saying "I'm not for sale!  Make another selection!"
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            //bool to show card has been "swiped" or "inserted"
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            //output message at beginning "welcome" and output messages when each picture
            // is clicked
        }

        private void btnVendOver_Click(object sender, EventArgs e)
        {
            //end vending process, show welcome message again, then close program
        }
    }
}
