
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Collections.Generic;


namespace CaclulatorMAUI;




class Calculator
{
    public static double GetNum(string numText) //function definition for Getnum
    {
        double numTemp = 0; //temporary value to store the outputted double

        if (numText != null) //if textbox is = 0
        {
            if (double.TryParse(numText, out numTemp)) //check if input is a valid double by converting the string to a double
            {
                return numTemp;//if it converts to a double, return the value
            }
            else
            {
                return 0;//if it fails, return 0
            }
        }
        else
        {
            return 0; //if the textbox is = 0, return 0
        }
    }
}




public partial class MainPage : ContentPage //create a new class to store code for our apps main page
    {
        int count = 0; //new global variable call count

        public MainPage() //new function called main paige
        {
            InitializeComponent(); //initializes our main page
        }

        //new gloabal global strings to store 
        public string correctText1; 
        public string correctText2;

        private void entryNum1_TextChanged(object sender, TextChangedEventArgs e) //new function for user entry 1
        {
            double numTemp1 = 0; //new temp double
            if(double.TryParse(entryNum1.Text, out numTemp1)) //try and convert string inputted by user into a double
        {
            correctText1 = entryNum1.Text; //store user input 1 in correct text string
        }
        else //otherwise
        {
            entryNum1.CursorPosition = correctText1.Length;//try and convert string inputted by user into a double, if successful, continue
            int selectionLength = e.NewTextValue.Length - correctText1.Length;//highlight all the characters that are invalid
            if (selectionLength > 0)//do not proceed until all invalid characters have been earsed
            {
                entryNum1.SelectionLength = selectionLength;//keep checking to see if invalid characters have been erased 
            }
        }

        }

        private void entryNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double numTemp2 = 0;
            if (double.TryParse(entryNum2.Text, out numTemp2)) //try and convert string inputted by user into a double, if successful, continue
        {
                correctText2 = entryNum1.Text; //store user input 2 in correct text string
        }
            else //otherwise
            {
                entryNum2.CursorPosition = correctText2.Length; //get the number of characters in user input 1, and set the position of the cursor
                int selectionLength = e.NewTextValue.Length - correctText2.Length; //highlight all the characters that are invalid
                if (selectionLength > 0) //do not proceed until all invalid characters have been earsed
                {
                    entryNum2.SelectionLength = selectionLength; //keep checking to see if invalid characters have been erased 
                }
            }
        }

        private void btnAdd_Clicked(object sender, EventArgs e) //if the 'add' button is clicked, call this function
        {
            //double num1 = Convert.ToDouble(entryNum1.Text); //didnt work for 123a and backspaces, i.e. got errors
            //double num2 = Convert.ToDouble(entryNum2.Text);

            double aNum1 = Calculator.GetNum(entryNum1.Text);//double to store first number inputted by the user
            double aNum2 = Calculator.GetNum(entryNum2.Text); //double to store second number inputted by the user   

            double ans = aNum1 + aNum2; //"Add"num1 + "Add"num2, store in a new double called answer
            txtAnswer.Text = Convert.ToString(ans); //convert double 'answer' to string and write it as the answer in the GUI
    }

        private void btnSubtract_Clicked(object sender, EventArgs e)//if the 'subtract' button is clicked, call this function
    {
             double sNum1 = Calculator.GetNum(entryNum1.Text);// double to store first number inputted by the user
             double sNum2 = Calculator.GetNum(entryNum2.Text);//double to store second number inputted by the user

        double ans = sNum1 - sNum2; //num1 - num2, store in a new double called answer
        txtAnswer.Text = Convert.ToString(ans); //convert double 'answer' to string and write it as the answer in the GUI
    }

        private void btnMultiply_Clicked(object sender, EventArgs e)//if the 'multiply' button is clicked, call this function
    {
            double mNum1 = Calculator.GetNum(entryNum1.Text);// double to store first number inputted by the user
            double mNum2 = Calculator.GetNum(entryNum2.Text);//double to store second number inputted by the user

            double ans = mNum1 * mNum2; //num1 * num2, store in a new double called answer
            txtAnswer.Text = Convert.ToString(ans);//convert double 'answer' to string and write it as the answer in the GUI
    }

        private void btnDivide_Clicked(object sender, EventArgs e)//if the 'divide' button is clicked, call this function
    {
            double dNum1 = Calculator.GetNum(entryNum1.Text);// double to store first number inputted by the user
            double dNum2 = Calculator.GetNum(entryNum2.Text);//double to store second number inputted by the user

            double ans = dNum1 / dNum2; //num1 / num2, store in a new double called answer
            txtAnswer.Text = Convert.ToString(ans); //convert double 'answer' to string and write it as the answer in the GUI
    }

    private void btnSquare_Clicked(object sender, EventArgs e)//if the 'square' button is clicked, call this function
    {
        double sqrNum1 = Calculator.GetNum(entryNum1.Text);// double to store first number inputted by the user
        double sqrNum2 = Calculator.GetNum(entryNum2.Text); //double to store second number inputted by the user

        double ans = System.Math.Pow(sqrNum1, sqrNum2); //num1 ^ (raised to the power of) num2, store in a new double called answer
        txtAnswer.Text = Convert.ToString(ans); //convert double 'answer' to string and write it as the answer in the GUI
    }

    private void btnSqrt_Clicked(object sender, EventArgs e)//if the 'square root' button is clicked, call this function
    {
        double sqrtNum1 = Calculator.GetNum(entryNum1.Text);// double to store first number inputted by the user
        double sqrtNum2 = Calculator.GetNum(entryNum2.Text);//double to store second number inputted by the user

        double ans = System.Math.Sqrt(sqrtNum1);//sqrt of num1, store in a new double called answer
        txtAnswer.Text = Convert.ToString(ans); //convert double 'answer' to string and write it as the answer in the GUI
    }

    private void btnExp_Clicked(object sender, EventArgs e)//if the 'exponent' button is clicked, call this function
    {
        double expNum1 = Calculator.GetNum(entryNum1.Text);// double to store first number inputted by the user
        double expNum2 = Calculator.GetNum(entryNum2.Text);//double to store second number inputted by the user

        double ans = System.Math.Exp(expNum1);//e ^ of num1, store in a new double called answer
        txtAnswer.Text = Convert.ToString(ans);//convert double 'answer' to string and write it as the answer in the GUI
    }

    private void btnCbrt_Clicked(object sender, EventArgs e)//if the 'cube root' button is clicked, call this function
    {
        double cbrtNum1 = Calculator.GetNum(entryNum1.Text);// double to store first number inputted by the user
        double cbrtNum2 = Calculator.GetNum(entryNum2.Text); //double to store second number inputted by the user

        double ans = System.Math.Cbrt(cbrtNum1);//cbrt of num1, store in a new double called answer
        txtAnswer.Text = Convert.ToString(ans); //convert double 'answer' to string and write it as the answer in the GUI
    }

  
    

    

    private void btnRndm_Clicked(object sender, EventArgs e)//if the 'random' button is clicked, call this function
    {
        double randNum1 = Calculator.GetNum(entryNum1.Text);// double to store first number inputted by the user
        double randNum2 = Calculator.GetNum(entryNum2.Text); //double to store second number inputted by the user

        
        
        Random rand = new Random(); //store new instance of random class in a Random variable called rand
       

        if(randNum1 <= randNum2) //if 1st number inputted is greater than the second number inputted
        {
            double answer = rand.Next((int)randNum1, (int)randNum2); //return a random number between 1st number inputted and second number inputted and store it in a new double called result

            if(answer == 12) //if the answer is = 12
            {
                txtAnswer.Text = Convert.ToString("Your number is 12, and my name is Matt Pearson"); // write the random number and my name as the answer
            }
            else //if not = 12
            {
                txtAnswer.Text = Convert.ToString(answer); //convert double 'answer' to string and write it as the answer in the GUI
            }
        
        } 
        else //if num2 is less than or = num1
        {
            double answer = rand.Next((int)randNum2, (int)randNum1); //return a random number between 2nd number inputted and 1st number inputted and store it in a new double called answer
            if (answer == 12) //if the random number is 12, write my name as the answer
            {
                txtAnswer.Text = Convert.ToString("Your number is 12, and my name is Matt Pearson"); //write the random number and my name as the answer
            }
            else //if not = 12
            {
                txtAnswer.Text = Convert.ToString(answer); //convert double 'answer' to string and write it as the answer in the GUI
            }
        }
        
    }
}
