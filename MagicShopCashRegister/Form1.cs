using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MagicShopCashRegister
{
    public partial class Form1 : Form
    {
        //creating needed global variables

        double wandsPrice = 27.75;
        double cauldronPrice = 45.55;
        double cloakPrice = 18.90;
        double wandsAmount;
        double cauldronAmount;
        double cloakAmount;
        double subtotal;
        double taxRate = 0.13;
        double taxAmount;
        double totalCost;
        double tendered;
        double change;
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                //enable the next buttons

                changeButton.Enabled = true;
                newOrderButton.Enabled = true;

                // place the content of the text boxes in the appropriate variables

                wandsAmount = Convert.ToDouble(wandsInput.Text);
                cauldronAmount = Convert.ToDouble(cauldronsInput.Text);
                cloakAmount = Convert.ToDouble(cloaksInput.Text);

                //calculate different totals and display them 

                double wandsTotal = wandsPrice * wandsAmount;
                double cauldronsTotal = cauldronAmount * cauldronPrice;
                double cloakTotal = cloakAmount * cloakPrice;

                subtotal = wandsTotal + cauldronsTotal + cloakTotal;
                subtotalOutput.Text = $"{subtotal.ToString("C")}";

                taxAmount = subtotal * taxRate;
                taxOutput.Text = $"{taxAmount.ToString("C")}";

                totalCost = subtotal + taxAmount;
                totalOutput.Text = $"{totalCost.ToString("C")}";
            }

            catch
            {
                //an error message is displayed and the next button is disabled if anything but numbers is put in the text boxes

                subtotalOutput.Text = $"ERROR";
                taxOutput.Text = $"ERROR";
                totalOutput.Text = $"ERROR";
                changeButton.Enabled = false;
            }

            //click sound plays

            System.Media.SoundPlayer clickSound = new System.Media.SoundPlayer(Properties.Resources.clickSound);
            clickSound.Play();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //enable next button

                receiptButton.Enabled = true;

                //place the content of the text box in the appropriate variable

                tendered = Convert.ToDouble(tenderedInput.Text);

                //calculate change and display it

                change = tendered - totalCost;
                changeOutput.Text = $"{change.ToString("C")}";
            }

            catch
            {
                //an error message is displayed and the next button is disabled if anything but numbers is put in the text box

                changeOutput.Text = "ERROR";
                receiptButton.Enabled = false;
            }

            //an error message is displayed and the next button is disabled if the tendered amount is lower than the total cost

            if (tendered < totalCost)
            {
                changeOutput.Text = $"ERROR";
            }
            if (tendered < totalCost)
            {
                receiptButton.Enabled = false;
            }
                
            
            //click sound plays

            System.Media.SoundPlayer clickSound = new System.Media.SoundPlayer(Properties.Resources.clickSound);
            clickSound.Play();

        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            //printing sound plays

            System.Media.SoundPlayer printSound = new System.Media.SoundPlayer(Properties.Resources.printSound);
            printSound.Play();

            //screen opens up

            Size = new Size(505,423);

            //receipt prints text and totals (only values greater than 0)

            outputLabel.Text = $"THE MAGIC SHOP";

            Refresh();
            Thread.Sleep(300);

            if (wandsAmount > 0)
            {
                outputLabel.Text += $"\n\nMAGIC WANDS:_x{wandsAmount} @ ${wandsPrice}";
            }

            Refresh();
            Thread.Sleep(300);

            if (cauldronAmount > 0)
            {
                outputLabel.Text += $"\nCAULDRONS:___x{cauldronAmount} @ ${cauldronPrice}";
            }
            Refresh();
            Thread.Sleep(300);
            
            if (cloakAmount > 0)
            {
                outputLabel.Text += $"\nCLOAKS:______x{cloakAmount} @ ${cloakPrice}";
            }

            Refresh();
            Thread.Sleep(300);

            if (subtotal > 0)
            {
                outputLabel.Text += $"\n\nSUBTOTAL:_________{subtotal.ToString("C")}";
            }

            Refresh();
            Thread.Sleep(300);

            if (taxAmount > 0)
            {
                outputLabel.Text += $"\nTAX:______________{taxAmount.ToString("C")}";
            }

            Refresh();
            Thread.Sleep(300);

            if (totalCost > 0)
            {
                outputLabel.Text += $"\nTOTAL:____________{totalCost.ToString("C")}";
            }

            Refresh();
            Thread.Sleep(300);

            outputLabel.Text += $"\n\nTENDERED:_________{tendered.ToString("C")}";

            Refresh();
            Thread.Sleep(300);
            
            if (change > 0)
            {
                outputLabel.Text += $"\nCHANGE:___________{change.ToString("C")}";
            }

            Refresh();
            Thread.Sleep(300);
            outputLabel.Text += $"\n\nTHANK YOU FOR SHOPPING WITH US!!"; 

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //text boxes are cleared

            wandsInput.Clear();
            cauldronsInput.Clear();
            cloaksInput.Clear();

            //output labels are cleared

            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";

            tenderedInput.Clear();
            changeOutput.Text = "";

            outputLabel.Text = "";

            //buttons other than the first one are disabled

            changeButton.Enabled = false;
            receiptButton.Enabled = false;

            //click sound plays

            System.Media.SoundPlayer clickSound = new System.Media.SoundPlayer(Properties.Resources.clickSound);
            clickSound.Play();

            //screen closes back down

            Size = new Size(254, 423);
        }
        
    }
}
