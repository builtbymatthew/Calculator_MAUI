
using System;

namespace CaclulatorMAUI;

    class Calculator
{
    public static double GetNum(string numText)
    {
        double numTemp = 0;

        if (numText != null) //if textbox is = to 0
        {
            if (double.TryParse(numText, out numTemp))
            {
                return numTemp;//check if input is a valid double 
            }
            else
            {
                return 0;
            }
        }
        else
        {
            return 0;
        }
    }
}

    class EasterEgg
{
    public static string secretFunction(string numText2)
    {
        string strTemp = "EasterEgg";
        if (numText2 == strTemp)
        {
            return "The creator is Matthew Pearson";
        }
        else
        {
            return "0";
        }
    }


}


    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public string correctText1;
        public string correctText2;

        private void entryNum1_TextChanged(object sender, TextChangedEventArgs e)
        {
            double numTemp1 = 0;
            if(double.TryParse(entryNum1.Text, out numTemp1))
        {
            correctText1 = entryNum1.Text;
        }
        else
        {
            entryNum1.CursorPosition = correctText1.Length;
            int selectionLength = e.NewTextValue.Length - correctText1.Length;
            if (selectionLength > 0)
            {
                entryNum1.SelectionLength = selectionLength;
            }
        }

        }

        private void entryNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double numTemp2 = 0;
            if (double.TryParse(entryNum2.Text, out numTemp2))
            {
                correctText2 = entryNum1.Text;
            }
            else
            {
                entryNum2.CursorPosition = correctText2.Length;
                int selectionLength = e.NewTextValue.Length - correctText2.Length;
                if (selectionLength > 0)
                {
                    entryNum2.SelectionLength = selectionLength;
                }
            }
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            //double num1 = Convert.ToDouble(entryNum1.Text); //didnt work for 123a and backspaces, i.e. got errors
            //double num2 = Convert.ToDouble(entryNum2.Text);

            double aNum1 = Calculator.GetNum(entryNum1.Text);
            double aNum2 = Calculator.GetNum(entryNum2.Text);    

            double ans = aNum1 + aNum2; //"Add"num1 + "Add"num2
            txtAnswer.Text = Convert.ToString(ans);
        }

        private void btnSubtract_Clicked(object sender, EventArgs e)
        {
             double sNum1 = Calculator.GetNum(entryNum1.Text);
             double sNum2 = Calculator.GetNum(entryNum2.Text);

             double ans = sNum1 - sNum2;
             txtAnswer.Text = Convert.ToString(ans);
    }

        private void btnMultiply_Clicked(object sender, EventArgs e)
        {
            double mNum1 = Calculator.GetNum(entryNum1.Text);
            double mNum2 = Calculator.GetNum(entryNum2.Text);

            double ans = mNum1 * mNum2;
            txtAnswer.Text = Convert.ToString(ans);
    }

        private void btnDivide_Clicked(object sender, EventArgs e)
        {
            double dNum1 = Calculator.GetNum(entryNum1.Text);
            double dNum2 = Calculator.GetNum(entryNum2.Text);

            double ans = dNum1 / dNum2;
            txtAnswer.Text = Convert.ToString(ans);
    }

    private void btnSquare_Clicked(object sender, EventArgs e)
    {
        double sqrNum1 = Calculator.GetNum(entryNum1.Text);
        double sqrNum2 = Calculator.GetNum(entryNum2.Text); 

        double ans = System.Math.Pow(sqrNum1, sqrNum2);
        txtAnswer.Text = Convert.ToString(ans); 
    }

    private void btnSqrt_Clicked(object sender, EventArgs e)
    {
        double sqrtNum1 = Calculator.GetNum(entryNum1.Text);
        double sqrtNum2 = Calculator.GetNum(entryNum2.Text);

        double ans = System.Math.Sqrt(sqrtNum1);
        txtAnswer.Text = Convert.ToString(ans);
    }

    private void btnExp_Clicked(object sender, EventArgs e)
    {
        double expNum1 = Calculator.GetNum(entryNum1.Text);
        double expNum2 = Calculator.GetNum(entryNum2.Text);

        double ans = System.Math.Exp(expNum1);
        txtAnswer.Text = Convert.ToString(ans);
    }

    private void btnCbrt_Clicked(object sender, EventArgs e)
    {
        double cbrtNum1 = Calculator.GetNum(entryNum1.Text);
        double cbrtNum2 = Calculator.GetNum(entryNum2.Text);

        double ans = System.Math.Cbrt(cbrtNum1);
        txtAnswer.Text = Convert.ToString(ans);
    }
}
