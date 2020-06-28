using System;
using System.Windows.Forms;

namespace IntegralCalc
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (RectangleMethodFlag.Checked)
            {
                ResultTextBox.Text = IntegralCalc.RectangleMethod(FunctionText.Text, Double.Parse(LowerLimitTextBox.Text), Double.Parse(UpperLimitTextBox.Text), int.Parse(KnotQuantityTextBox.Text));
            }
            if (TrapetionMethodFlag.Checked)
            {
                ResultTextBox.Text = IntegralCalc.TrapetionMethod(FunctionText.Text, Double.Parse(LowerLimitTextBox.Text), Double.Parse(UpperLimitTextBox.Text), int.Parse(KnotQuantityTextBox.Text));
            }
            if (SimpsonMethodFlag.Checked)
            {
                ResultTextBox.Text = IntegralCalc.SimpsonMethod(FunctionText.Text, Double.Parse(LowerLimitTextBox.Text), Double.Parse(UpperLimitTextBox.Text), int.Parse(KnotQuantityTextBox.Text));
            }

        }

        private void ResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
