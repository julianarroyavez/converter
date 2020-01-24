
using System;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PerformConversion(double conversionRate, TextBox from, TextBox to)
        {
            double result;
            bool isValid = Double.TryParse(from.Text, out result);
            if (isValid)
            {
                double converted = result * conversionRate;
                to.Text = converted.ToString();
            }
            else
            {
                to.Text = "";
            }
        }

        private void MilesModifiedEvent(object sender, System.EventArgs e)
        {
            const double CONVERSION_MILES_TO_KILOMETERS = 1.60934;
            PerformConversion(CONVERSION_MILES_TO_KILOMETERS, txtMiles1, txtKilometers1);

        }

        private void KilometersModifiedEvent(object sender, System.EventArgs e)
        {
            const double CONVERSION_KILOMETERS_TO_MILES = 1 / 1.60934;
            PerformConversion(CONVERSION_KILOMETERS_TO_MILES, txtKilometers1, txtMiles1);
        }

        private void PondsModifiedEvent(object sender, System.EventArgs e)
        {
            const double CONVERSION_KILOGRAMS_TO_POUNDS = 0.453592;
            PerformConversion(CONVERSION_KILOGRAMS_TO_POUNDS, txtPounds1, txtKilograms1);

        }

        private void TxtKilograms1_TextChanged(object sender, System.EventArgs e)
        {
            const double CONVERSION_KILOGRAMS_TO_POUNDS = 1 / 0.453592;
            PerformConversion(CONVERSION_KILOGRAMS_TO_POUNDS, txtKilograms1, txtPounds1);
        }
    }
}
