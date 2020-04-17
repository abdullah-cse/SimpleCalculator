using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class FormHome : Form
    {
        double numberOne;
        double numberTwo;
        double result;
        public FormHome()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            getNumber();
            Addition();
            textBoxResult.Text = result.ToString();

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            getNumber();
            Minus();
            textBoxResult.Text = result.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            getNumber();
            multiply();
            textBoxResult.Text = result.ToString();
        }

        private void buttonDivition_Click(object sender, EventArgs e)
        {
            getNumber();
            devide();
            textBoxResult.Text = result.ToString();
        }
        private void getNumber()
        {
            numberOne = Convert.ToDouble(textBoxNumberFirst.Text);
            numberTwo = Convert.ToDouble(textBoxNumberSecond.Text);
        }
        private double Addition()
        {
            result = numberOne + numberTwo;
            return result;
        }
        private double Minus()
        {
            result = numberOne - numberTwo;
            return result;
        }
        private double multiply()
        {
            result = numberOne * numberTwo;
            return result;
        }
        private double devide()
        {
            result = numberOne / numberTwo;
            return result;
        }
    }
}
