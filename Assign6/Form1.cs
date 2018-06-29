using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assign6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Function to total an array of values
        private double fTotal(double[] dArray)
        {
            double total = 0;

            for(int i = 1; i < dArray.Length; i++)
            {
                total += dArray[i];
            }

            return total;
        }

        // Function to find the highest in an array of values
        private double fHigh(double[] dArray)
        {
            double highest;
            highest = dArray[0];

            for(int i = 1; i < dArray.Length; i++)
            {
                if(dArray[i] > highest)
                {
                    highest = dArray[i];
                }
            }

            return highest;
        }

        // Function to find the lowest in an array of values
        private double fLow(double[] dArray)
        {
            double lowest;
            lowest = dArray[0];

            for(int i = 1; i < dArray.Length; i++)
            {
                if(dArray[i] < lowest)
                {
                    lowest = dArray[i];
                }
            }

            return lowest;
        }

        // Function to average an array of values
        private double fAvg(double[] dArray)
        {
            double average;
            double sum = 0;

            for(int i = 1; i < dArray.Length; i++)
            {
                sum += dArray[i];
            }

            average = sum / dArray.Length;

            return average;
        }

        private void btnAnaSal_Click(object sender, EventArgs e)
        {
            double[] values = new double[7];

            // Call the streamreader utility to open and read the file
            StreamReader ifile;

            // Open the txt file
            ifile = File.OpenText("Sales.txt");
            int counter = 0;
            string text = "";

            // Loop through and read the values in the file
            while (ifile.EndOfStream == false)
            {
                text = ifile.ReadLine();
                values[counter] = double.Parse(text);
                counter++;
            }

            // Add the values in the file to the list box
            foreach (double val in values)
            {
                lstBxSales.Items.Add(val);
            }

            // Close the txt file
            ifile.Close();
            
            // Run the functions on the values from the file and set returns to vars
            double high = Math.Round(fHigh(values), 2);
            double low = Math.Round(fLow(values), 2);
            double avg = Math.Round(fAvg(values), 2);
            double total = Math.Round(fTotal(values), 2);

            // Set the labels to show the values
            lblAvgSalesVal.Text = "$" + String.Format("{0:n}", avg);
            lblHighSalesVal.Text = "$" + String.Format("{0:n}", high);
            lblTotSalesVal.Text = "$" + String.Format("{0:n}", total);
            lvlLowSalesVal.Text = "$" + String.Format("{0:n}", low);

        }

        private void lblHighSalesVal_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application on button click
            Application.Exit();
        }
    }
}
