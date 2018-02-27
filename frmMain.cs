using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class frmMain : Form
    {
        // Define the weight of each coin in grams.
        // The coin deposit function will evaluate by
        // weight to determine which coin was inserted.
        double nickelWeight = 5.000;
        double dimeWeight = 2.268;
        double quarterWeight = 5.670;
        double halfdollarWeight = 11.340;

        // Define the display names for each brand.
        string cokeBrandName = "Coca Cola";
        string pepsiBrandName = "Pepsi Cola";
        string drPepperBrandName = "Dr. Pepper";
        string SevenUPBrandName = "7UP";
        string AWRootBeerBrandName = "A&W Root Beer";

        // Define the value for each coin
        double nickelValue = .05;
        double dimeValue = .10;
        double quarterValue = .25;
        double halfdollorValue = .50;

        // Define sales price for each brand
        double cokeSalePrice = 1.50;
        double pepsiSalePrice = 1.50;
        double drpepperSalePrice = 1.50;
        double sevenupSalePrice = 1.25;
        double awrootbeerSalePrice = 1.00;

        // Each time a coin button is clicked a new 
        // instance of 'Coin' will be created with
        // the weight for the selected denomination.
        class Coin
        {
            public double weight;

            public Coin(double v)
            {
                this.weight = v;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit application.
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Set the remaining beverage counts for each brand to a
            // an initialized value of 10.
            SetUpDownControlValue(grpDrinkSelections, 10);

            // Set the remaining coin counts for each coin denomination.
            SetUpDownControlValue(grpCoins, 100);

            // Display the beginning coin balance
            GetBeginningCoinBalance();

            // Set the sales price for each brand
            SetSalesPriceText();
        }

        private void SetUpDownControlValue(GroupBox grpBox, int Value)
        {
            // Set the remaining control counts.
            foreach (Control x in grpBox.Controls)
            {
                if (x is NumericUpDown)
                {
                    NumericUpDown numControls = x as NumericUpDown;
                    numControls.Value = Value;
                }
            }
        }

        private void DepositCoin(Coin coin)
        {
            // Coins are evaluated by weight by the vending machine.
            if (coin.weight == nickelWeight)
            {
                DisplayCoinsInserted(nickelValue, nudNickel);
            }
            else if (coin.weight == dimeWeight)
            {
                DisplayCoinsInserted(dimeValue, nudDime);
            }
            else if (coin.weight == quarterWeight)
            {
                DisplayCoinsInserted(quarterValue,nudQuarter);
            }
            else if (coin.weight == halfdollarWeight)
            {
                DisplayCoinsInserted(halfdollorValue,nudHalfDollar);
            }
        }

        private void btnNickel_Click(object sender, EventArgs e)
        {
            DepositCoin(new Coin(nickelWeight));
        }

        private void btnDime_Click(object sender, EventArgs e)
        {
            DepositCoin(new Coin(dimeWeight));
        }

        private void btnQuarter_Click(object sender, EventArgs e)
        {
            DepositCoin(new Coin(quarterWeight));
        }

        private void btnHalfDollor_Click(object sender, EventArgs e)
        {
            DepositCoin(new Coin(halfdollarWeight));
        }

        private void timerChange_Tick(object sender, EventArgs e)
        {
            btnCancelSale.Enabled = double.Parse(lblAmountInserted.Text) > 0;
            btnTakeYourChange.Enabled = double.Parse(lblChangeReceived.Text) > 0;
        }

        private void SetToolTipText(Button btn, string sodaBrand, NumericUpDown n)
        {
            // Set the tool tip text for each drink.
            toolTip.SetToolTip(btn, "Total " + sodaBrand + " bottles available = " + n.Value.ToString());
        }

        private void btnCoke_MouseHover(object sender, EventArgs e)
        {
            SetToolTipText(btnCoke, cokeBrandName, nudCoke);
        }

        private void btnPepsi_MouseHover(object sender, EventArgs e)
        {
            SetToolTipText(btnPepsi, pepsiBrandName, nudPepsi);
        }

        private void btnDrPepper_MouseHover(object sender, EventArgs e)
        {
            SetToolTipText(btnDrPepper, drPepperBrandName, nudDrPepper);
        }

        private void btn7UP_MouseHover(object sender, EventArgs e)
        {
            SetToolTipText(btn7UP, SevenUPBrandName, nud7UP);
        }

        private void btnAWRootBeer_MouseHover(object sender, EventArgs e)
        {
            SetToolTipText(btnAWRootBeer, AWRootBeerBrandName, nudAWRootBeer);
        }

        private void GetBeginningCoinBalance()
        {
            // Calculate the dollar value of all coins on hand at startup.
            double coinBalance = 0;
            coinBalance += nickelValue * (double)nudNickel.Value;
            coinBalance += dimeValue * (double)nudDime.Value;
            coinBalance += quarterValue * (double)nudQuarter.Value;
            coinBalance += halfdollorValue * (double)nudHalfDollar.Value;

            txtCoinBalance.Text = "$" + string.Format("{0:N2}", coinBalance);
        }

        private void SetSalesPriceText()
        {
            // Set the sales price for each brand at startup.
            lblCokeSalePrice.Text = "$" + string.Format("{0:N2}", cokeSalePrice);
            lblPepsiSalePrice.Text = "$" + string.Format("{0:N2}", pepsiSalePrice);
            lblDrPepperSalePrice.Text = "$" + string.Format("{0:N2}", drpepperSalePrice);
            lbl7UPSalePrice.Text = "$" + string.Format("{0:N2}", sevenupSalePrice);
            lblAWRootBeerSalePrice.Text = "$" + string.Format("{0:N2}", awrootbeerSalePrice);
        }

        private void DisplayCoinsInserted(double coinValue, NumericUpDown nud)
        {
            double coinsInserted = double.Parse(lblAmountInserted.Text);
            lblAmountInserted.Text = string.Format("{0:N2}", coinsInserted + coinValue).ToString();
            nud.Value += 1;
        }

        private bool EnoughCoinsInserted(double brandSalesPrice, string brandName)
        {
            // Check to see if enough coins were inserted.
            bool results = false;
            double coinsInserted = double.Parse(lblAmountInserted.Text);

            if (coinsInserted < brandSalesPrice)
            {
                double amountRemaining = brandSalesPrice - coinsInserted;
                MessageBox.Show("Please insert an additional $" + string.Format("{0:N2}", amountRemaining) + 
                    " to purchase " + brandName + ".","More Coins Needed");
            }
            else
            {
                results = true;
            }

            return results;

        }

        private void btnCoke_Click(object sender, EventArgs e)
        {
            // If enough coins were inserted let's have a Coca Cola.
            if (EnoughCoinsInserted(cokeSalePrice,"a " + cokeBrandName))
            {
                MakeChange(cokeSalePrice,nudCoke,"a " + cokeBrandName);
            }
        }

        private void btnPepsi_Click(object sender, EventArgs e)
        {
            // If enough coins were inserted let's have a Pepsi.
            if (EnoughCoinsInserted(pepsiSalePrice, "a " + pepsiBrandName))
            {
                MakeChange(pepsiSalePrice, nudPepsi, "a " + pepsiBrandName);
            }
        }

        private void btnDrPepper_Click(object sender, EventArgs e)
        {
            // If enough coins were inserted let's have a Dr. Pepper.
            if (EnoughCoinsInserted(drpepperSalePrice, "a " + drPepperBrandName))
            {
                MakeChange(drpepperSalePrice, nudDrPepper, "a " + drPepperBrandName);
            }
        }

        private void btn7UP_Click(object sender, EventArgs e)
        {
            // If enough coins were inserted let's have a 7UP.
            if (EnoughCoinsInserted(sevenupSalePrice, "a " + SevenUPBrandName))
            {
                MakeChange(sevenupSalePrice, nud7UP, "a " + SevenUPBrandName);
            }
        }

        private void btnAWRootBeer_Click(object sender, EventArgs e)
        {
            // If enough coins were inserted let's have an A&W Root Beer.
            if (EnoughCoinsInserted(awrootbeerSalePrice, "an " + AWRootBeerBrandName))
            {
                MakeChange(awrootbeerSalePrice, nudAWRootBeer, "an" + AWRootBeerBrandName);
            }
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            CancelSale();
        }

        private void CancelSale()
        {
            // Sale cancelled so reset the amount inserted and make change.
            lblChangeReceived.Text = lblAmountInserted.Text;
            lblAmountInserted.Text = "0.00";

            // Disable all input until the user takes his/her change.
            grpDrinkSelections.Enabled = false;
            grpCoins.Enabled = false;

            MessageBox.Show("Sale cancelled.  Please take your change before continuing.", "No Sale");
        }

        private void btnTakeYourChange_Click(object sender, EventArgs e)
        {
            TakeYourChange();
        }

        private void TakeYourChange()
        {
            lblChangeReceived.Text = "0.00";

            grpDrinkSelections.Enabled = true;
            grpCoins.Enabled = true;
        }

        private void MakeChange(Double brandSalesPrice, NumericUpDown nud, string brandName)
        {
            // Get the value of the inserted coins.
            double coinsInsertedValue = double.Parse(lblAmountInserted.Text);
            // Get the value of change (if any) to be made.
            double change = coinsInsertedValue - brandSalesPrice;

            // Calculate and display total sales for this session.
            double currentSales = double.Parse(txtTotalSales.Text.Substring(1)) + brandSalesPrice;
            txtTotalSales.Text = "$" + string.Format("{0:N2}", currentSales);

            // Reduce the brand inventory by 1.
            nud.Value -= 1;

            if (change > 0)
            {
                // There was change to be given back.
                lblChangeReceived.Text = string.Format("{0:N2}", change);
                lblAmountInserted.Text = "0.00";

                // Disable all input until the user takes his/her change.
                grpDrinkSelections.Enabled = false;
                grpCoins.Enabled = false;

                // Let's make some change.  Start with half dollars.
                while (change >= halfdollorValue)
                {
                    nudHalfDollar.Value -= 1;
                    change = change - halfdollorValue;
                }

                // Continue making change with quarters.
                while (change >= quarterValue)
                {
                    nudQuarter.Value -= 1;
                    change = change - quarterValue;
                }

                // Continue making change with dimes.
                while (change >= dimeValue)
                {
                    nudQuarter.Value -= 1;
                    change = change - dimeValue;
                }

                // Continue making change with quarters.
                while (change >= nickelValue)
                {
                    nudQuarter.Value -= 1;
                    change = change - nickelValue;
                }

                MessageBox.Show("Thank you for purchasing " + brandName + "!  Please take your change.");
            }
            else
            {
                // No change needed.
                MessageBox.Show("Thank you for purchasing " + brandName + "!");
            }
        }
    }
}
