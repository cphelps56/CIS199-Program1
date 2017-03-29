// Colin Phelps
// Program 1
// 2/16/15
// CIS 199-01
// This program allows input for square feet covered, number of coats, and the cost of a gallon of paint and then outputs the total square feet covered, the total number of gallons covered, the total number of labor hours, the cost of labor, the cost of the paint, and the total cost.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
           // Constants declared
            const ushort FEET_PER_GALLON = 325;
            const int HOURS_PER_GALLON = 8;
            const decimal LABOR_RATE = 10.50m;

            // Variable to hold the total square feet
            decimal totalSquareFeet;
            // Variable to hold the number of gallons required
            decimal numberOfGallons;
            // Variable to hold the number of labor hours
            double hoursOfLabor;
            // Variable to hold the cost of the paint
            decimal costOfPaint;
            // Variable to hold the cost of labor
            decimal costOfLabor;
            // Variable to hold the total cost
            decimal totalCost;

            // Calculate and display the total square feet
            totalSquareFeet = decimal.Parse(squareFeetTextbox.Text) * int.Parse(numberOfCoatsTextbox.Text);
            totalSquareFeetOutputLabel.Text = totalSquareFeet.ToString("n1");

            // Calculate and display the total number of gallons
            numberOfGallons = (decimal) Math.Ceiling(totalSquareFeet /  FEET_PER_GALLON);
            numberOfGallonsOutputLabel.Text = numberOfGallons.ToString();

            // Calculate and display the number of hours of labor
            hoursOfLabor = (double)(totalSquareFeet / FEET_PER_GALLON) * HOURS_PER_GALLON;
            laborHoursOutputLabel.Text = hoursOfLabor.ToString("n1");

            // Calculate and display the total cost of the paint
            costOfPaint = numberOfGallons * decimal.Parse(pricePerGallonTextbox.Text);
            paintCostOutputLabel.Text = costOfPaint.ToString("c");

            // Calculate and display the total cost of labor
            costOfLabor = (decimal)hoursOfLabor * LABOR_RATE;
            laborCostOutputLabel.Text = costOfLabor.ToString("c");

            // Calculate and display the total cost
            totalCost = costOfLabor + costOfPaint;
            totalCostOutputLabel.Text = totalCost.ToString("c");

        }
    }
}
