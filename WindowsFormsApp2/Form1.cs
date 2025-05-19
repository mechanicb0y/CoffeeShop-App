using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // Prices for drinks and cakes (set as constants for this example)

        private const double priceLatte = 10.0;
        private const double priceEspresso = 14.0;
        private const double priceIceLatte = 12.5;
        private const double priceVale = 5.0;
        private const double priceCappuccino = 11.0;
        private const double priceAfricanCoffee = 19.5;
        private const double priceAmericanCoffee = 20.0;
        private const double priceIcedCappuccino = 10.5;

        private const double priceCoffeeCake = 15.5;
        private const double priceRedVelvetCake = 7.5;
        private const double priceBlackForestCake = 12.0;
        private const double priceBostonCake = 20.5;
        private const double priceLagosChoCake = 10.0;
        private const double priceKilburnChoCake = 12.5;
        private const double priceCarltonHillCake = 7.5;
        private const double priceQueensParkCake = 22.0;

        // Fixed service charge

        private const double serviceCharge = 2.50;


        public Form1()
        {
            InitializeComponent();
            textBox7.Text = "10";
            textBox7.TextAlign = HorizontalAlignment.Center;
            textBox8.Text = "14";
            textBox8.TextAlign = HorizontalAlignment.Center;
            textBox9.Text = "12.5";
            textBox9.TextAlign = HorizontalAlignment.Center;
            textBox10.Text = "5";
            textBox10.TextAlign = HorizontalAlignment.Center;
            textBox11.Text = "11";
            textBox11.TextAlign = HorizontalAlignment.Center;
            textBox12.Text = "19.5";
            textBox12.TextAlign = HorizontalAlignment.Center;
            textBox13.Text = "20";
            textBox13.TextAlign = HorizontalAlignment.Center;
            textBox14.Text = "10.5";
            textBox14.TextAlign = HorizontalAlignment.Center;
            textBox15.Text = "15.5";
            textBox15.TextAlign = HorizontalAlignment.Center;
            textBox16.Text = "7.5";
            textBox16.TextAlign = HorizontalAlignment.Center;
            textBox17.Text = "12";
            textBox17.TextAlign = HorizontalAlignment.Center;
            textBox18.Text = "20.5";
            textBox18.TextAlign = HorizontalAlignment.Center;
            textBox19.Text = "10";
            textBox19.TextAlign = HorizontalAlignment.Center;
            textBox20.Text = "12.5";
            textBox20.TextAlign = HorizontalAlignment.Center;
            textBox21.Text = "7.5";
            textBox21.TextAlign = HorizontalAlignment.Center;
            textBox22.Text = "22";
            textBox22.TextAlign = HorizontalAlignment.Center;
            textBox3.Text = "RM2.50";
            textBox3.TextAlign = HorizontalAlignment.Center;
            const string V = "5%";
            textBox4.Text = V;
            textBox4.TextAlign = HorizontalAlignment.Center;




        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("h:m:s tt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string fileContent = System.IO.File.ReadAllText(openFileDialog.FileName);
                textBox1.Text = fileContent;  
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
              
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += (s, args) => args.Graphics.DrawString(textBox1.Text, new Font("Arial", 12), Brushes.Black, 100, 100);
                printDoc.Print();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.SelectedText))
            {
                Clipboard.SetText(textBox1.SelectedText);
                textBox1.SelectedText = string.Empty;
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.SelectedText))
            {
                Clipboard.SetText(textBox1.SelectedText);
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                textBox1.Paste();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the help section.\nHere you can find the documentation for this application.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double costOfDrinks = 0;
            double costOfCakes = 0;


            // Check and add drink prices
            if (checkBox1.Checked) costOfDrinks += priceLatte;
            if (checkBox2.Checked) costOfDrinks += priceEspresso;
            if (checkBox3.Checked) costOfDrinks += priceIceLatte;
            if (checkBox4.Checked) costOfDrinks += priceVale;
            if (checkBox5.Checked) costOfDrinks += priceCappuccino;
            if (checkBox6.Checked) costOfDrinks += priceAfricanCoffee;
            if (checkBox7.Checked) costOfDrinks += priceAmericanCoffee;
            if (checkBox8.Checked) costOfDrinks += priceIcedCappuccino;

            // Check and add cake prices

            if (checkBox9.Checked) costOfCakes += priceCoffeeCake;
            if (checkBox10.Checked) costOfCakes += priceRedVelvetCake;
            if (checkBox11.Checked) costOfCakes += priceBlackForestCake;
            if (checkBox12.Checked) costOfCakes += priceBostonCake;
            if (checkBox13.Checked) costOfCakes += priceLagosChoCake;
            if (checkBox14.Checked) costOfCakes += priceKilburnChoCake;
            if (checkBox15.Checked) costOfCakes += priceCarltonHillCake;
            if (checkBox16.Checked) costOfCakes += priceQueensParkCake;

            // Calculate Subtotal, Tax, and Total

            double subTotal = costOfDrinks + costOfCakes;
            double tax = subTotal * 0.05;  // 5% tax
            double total = subTotal + serviceCharge + tax;

            // Display costs in TextBoxes (Cost of Drinks and Cakes)

            textBox1.Text = costOfDrinks.ToString("0.00");
            textBox2.Text = costOfCakes.ToString("0.00");

            // Display Subtotal, Tax, and Total in TextBoxes

            textBox5.Text = subTotal.ToString("0.00");
            textBox4.Text = tax.ToString("0.00");
            textBox6.Text = total.ToString("0.00");

            // Show the breakdown in richTextBox1

            richTextBox1.Clear();
            //richTextBox1.AppendText(" TOTAL \n");
            //richTextBox1.AppendText($"Cost of Drinks:\tRM{costOfDrinks:0.00}\n");
            //richTextBox1.AppendText($"Cost of Cakes:\tRM{costOfCakes:0.00}\n");
            //richTextBox1.AppendText($"SubTotal:\tRM{subTotal:0.00}\n");
            //richTextBox1.AppendText($"Tax (5%):\tRM{tax:0.00}\n");
            //richTextBox1.AppendText($"Service Charge:\tRM{serviceCharge:0.00}\n");
            richTextBox1.AppendText($"Total:\tRM{total:0.00}\n");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double costOfDrinks = 0;
            double costOfCakes = 0;

            richTextBox1.Clear();
            richTextBox1.AppendText("RECEIPT \n\n");

            // Add drink items to receipt if checked

            if (checkBox1.Checked) { costOfDrinks += priceLatte; richTextBox1.AppendText($"Latte \t\tRM{priceLatte:0.00}\n"); }
            if (checkBox2.Checked) { costOfDrinks += priceEspresso; richTextBox1.AppendText($"Espresso \tRM{priceEspresso:0.00}\n"); }
            if (checkBox3.Checked) { costOfDrinks += priceIceLatte; richTextBox1.AppendText($"Ice Latte \tRM{priceIceLatte:0.00}\n"); }
            if (checkBox4.Checked) { costOfDrinks += priceVale; richTextBox1.AppendText($"Vale Coffee \tRM{priceVale:0.00}\n"); }
            if (checkBox5.Checked) { costOfDrinks += priceCappuccino; richTextBox1.AppendText($"Cappuccino \tRM{priceCappuccino:0.00}\n"); }
            if (checkBox6.Checked) { costOfDrinks += priceAfricanCoffee; richTextBox1.AppendText($"African Coffee \tRM{priceAfricanCoffee:0.00}\n"); }
            if (checkBox7.Checked) { costOfDrinks += priceAmericanCoffee; richTextBox1.AppendText($"American Coffee \tRM{priceAmericanCoffee:0.00}\n"); }
            if (checkBox8.Checked) { costOfDrinks += priceIcedCappuccino; richTextBox1.AppendText($"Iced Cappuccino \tRM{priceIcedCappuccino:0.00}\n"); }

            // Add cake items to receipt if checked

            if (checkBox9.Checked) { costOfCakes += priceCoffeeCake; richTextBox1.AppendText($"Coffee Cake \tRM{priceCoffeeCake:0.00}\n"); }
            if (checkBox10.Checked) { costOfCakes += priceRedVelvetCake; richTextBox1.AppendText($"Red Velvet Cake \tRM{priceRedVelvetCake:0.00}\n"); }
            if (checkBox11.Checked) { costOfCakes += priceBlackForestCake; richTextBox1.AppendText($"Black Forest Cake \tRM{priceBlackForestCake:0.00}\n"); }
            if (checkBox12.Checked) { costOfCakes += priceBostonCake; richTextBox1.AppendText($"Boston Cake \tRM{priceBostonCake:0.00}\n"); }
            if (checkBox13.Checked) { costOfCakes += priceLagosChoCake; richTextBox1.AppendText($"Lagos Cho Cake \tRM{priceLagosChoCake:0.00}\n"); }
            if (checkBox14.Checked) { costOfCakes += priceKilburnChoCake; richTextBox1.AppendText($"Kilburn Cho Cake \tRM{priceKilburnChoCake:0.00}\n"); }
            if (checkBox15.Checked) { costOfCakes += priceCarltonHillCake; richTextBox1.AppendText($"Carlton Hill Cake \tRM{priceCarltonHillCake:0.00}\n"); }
            if (checkBox16.Checked) { costOfCakes += priceQueensParkCake; richTextBox1.AppendText($"Queen's Park Cake \tRM{priceQueensParkCake:0.00}\n"); }

            // Calculate SubTotal, Tax, and Total

            double subTotal = costOfDrinks + costOfCakes;
            double tax = subTotal * 0.05;
            double total = subTotal + serviceCharge + tax;

            // Display totals in receipt

            //richTextBox1.AppendText("-----------------------------\n");
            richTextBox1.AppendText($"SubTotal:\tRM{subTotal:0.00}\n");
            richTextBox1.AppendText($"Tax (5%):\tRM{tax:0.00}\n");
            richTextBox1.AppendText($"Service Charge:\tRM{serviceCharge:0.00}\n");
            richTextBox1.AppendText($"Total:\tRM{total:0.00}\n");
            //richTextBox1.AppendText("*****************************");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Uncheck all checkboxes

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;

            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;

            // Clear all TextBox values

            textBox1.Clear();
            textBox2.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox6.Clear();

            // Clear the receipt display

            richTextBox1.Clear();
        }
    }
}
