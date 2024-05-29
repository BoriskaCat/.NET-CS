using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator    //8-digit numeral system
{
    public partial class CalculatorForm : Form
    {
        private bool lastOperationWasEquals = false;
        private bool exceptionWasThrown = false;
        private string[] eightDigitSymbols = { "0", "1", "2", "3", "4", "5", "6", "7" };

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string buttonText = button.Text;

            if (lastOperationWasEquals)
            {
                ResultLabel.Text = "";
                lastOperationWasEquals = false;
            }

            AppendToInput(buttonText);
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string operation = button.Text;

            if (!string.IsNullOrEmpty(ResultLabel.Text))
                AppendToInput(operation);

            if (string.IsNullOrEmpty(ResultLabel.Text) && ResultLabel.Text != "0" && operation == "-")
                AppendToInput(operation);

            lastOperationWasEquals = false;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ResultLabel.Text))
            {
                ResultLabel.Text = "Error: No input";
                exceptionWasThrown = true;
                return;
            }
            if (exceptionWasThrown)
            {
                ResultLabel.Text = "0";
                exceptionWasThrown = false;
                return;
            }


            try
            {
                string expression = ResultLabel.Text;
                Console.WriteLine("Expression: " + expression);
                string decimalExpression = ConvertExpressionFromBase8(expression);
                Console.WriteLine("Decimal Expression: " + decimalExpression);

                // Evaluate the decimal equation
                var result = Convert.ToDouble(new DataTable().Compute(decimalExpression, null));
                Console.WriteLine("Result in Decimal: " + result);
                result = Math.Round(result, 6);

                // Display the result in the ResultLabel
                string base9Result = ConvertToEightDigitSystem(result);
                ResultLabel.Text = base9Result;

                lastOperationWasEquals = true;
            }
            catch (Exception ex)
            {
                ResultLabel.Text = "#Err: " + ex.Message;
                Console.WriteLine("#Err: " + ex.Message);
                exceptionWasThrown = true;
            }
        }

        private void ParenthesesOpenButton_Click(object sender, EventArgs e)
        {
            AppendToInput("(");
            lastOperationWasEquals = false;
        }

        private void ParenthesesCloseButton_Click(object sender, EventArgs e)
        {
            AppendToInput(")");
            lastOperationWasEquals = false;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = "0";
            exceptionWasThrown = false;
        }

        private void AppendToInput(string text)
        {
            // Define valid operators and the decimal point
            string validOperators = "./+\\-*";

            // If the text is an operator or a decimal point
            if (validOperators.Contains(text))
            {
                // Split the current input into tokens based on operators
                string[] tokens = ResultLabel.Text.Split(new char[] { '+', '-', '*', '/' });

                // Get the last token (the current number being input)
                string currentNumber = tokens.Length > 0 ? tokens[tokens.Length - 1] : "";

                if (text == "." && currentNumber.Contains("."))
                {
                    return;
                }

                // Append the operator or decimal point to the input
                ResultLabel.Text += text;
            }
            else if (ResultLabel.Text == "0")
            {
                // If the current input is 0 and the new text is a valid number, replace 0 with the new text
                ResultLabel.Text = text;
            }
            else
            {
                if (text == "×")
                {
                    ResultLabel.Text += "*";
                }
                else if (text == "÷") {
                    ResultLabel.Text += "/";
                }
                else
                {
                    // Append the new text to the input
                    ResultLabel.Text += text;
                }
            }
        }


        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (ResultLabel.Text.Length > 0)
            {
                ResultLabel.Text = ResultLabel.Text.Substring(0, ResultLabel.Text.Length - 1);
            }
            lastOperationWasEquals = false;
            exceptionWasThrown = false;
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            AppendToInput(".");
            lastOperationWasEquals = false;
        }


        public string ConvertExpressionFromBase8(string expression)
        {
            Regex letterRegex = new Regex(@"[a-zA-Z]");


            if (letterRegex.IsMatch(expression))
            {
                throw new ArgumentException("Invalid input: Expression contains letters.");
            }

            // Regex to match numbers in the expression, including those starting with a decimal point
            Regex numberRegex = new Regex(@"(\d*\.\d+|\d+)");

            return numberRegex.Replace(expression, match =>
            {
                string matchedValue = match.Value;

                // Add '0' before the decimal point if the number starts with a decimal point
                if (matchedValue.StartsWith("."))
                {
                    matchedValue = "0" + matchedValue;
                    Console.WriteLine("Corrected number with leading zero: " + matchedValue); // Debug output to check condition
                }

                // Convert the base-9 number to decimal and return it as a string
                return ConvertToDecimalSystem(matchedValue).ToString();
            });
        }

        private double ConvertToDecimalSystem(string base8Number)
        {
            try
            {
                string[] parts = base8Number.Split('.');
                double result = 0;

                // Convert integer part
                foreach (char digit in parts[0])
                {
                    int value = int.Parse(digit.ToString());
                    result = result * 8 + value;
                }

                // Convert fractional part
                if (parts.Length > 1)
                {
                    double fractionalPart = 0;
                    for (int i = 0; i < parts[1].Length; i++)
                    {
                        int value = int.Parse(parts[1][i].ToString());
                        fractionalPart += value / Math.Pow(8, i + 1);
                    }
                    result += fractionalPart;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new FormatException("Invalid Base", ex);
            }
        }

        private string ConvertToEightDigitSystem(double number)
        {
            if (Double.IsInfinity(number))
            {
                throw new ArgumentException("You cannot divide by 0");
            }
            bool isNegative = number < 0;
            if (isNegative)
            {
                number = -number;
            }

            string eightDigitSymbols = "01234567";
            int integerPart = (int)number;
            double fractionalPart = number - integerPart;

            string base8IntegerPart = ConvertToBase8String(integerPart);
            string base8FractionalPart = "";

            // Convert fractional part to base 8 with rounding
            for (int i = 0; i < 5; i++)
            {
                fractionalPart *= 8;
                int fractionalDigit = (int)fractionalPart;
                base8FractionalPart += eightDigitSymbols[fractionalDigit];
                fractionalPart -= fractionalDigit;
            }

            // Handle rounding up
            fractionalPart *= 8;
            if ((int)fractionalPart >= 5)
            {
                base8FractionalPart = RoundBase8FractionalPart(base8FractionalPart);
            }
            base8FractionalPart = base8FractionalPart.ToString().TrimEnd('0');

            string result = base8IntegerPart + (base8FractionalPart != "" ? "." + base8FractionalPart : "");
            return isNegative ? "-" + result : result;
        }

        private string ConvertToBase8String(int number)
        {
            if (number == 0) return "0";

            string result = "";
            int n = number;
            while (n > 0)
            {
                int remainder = n % 8;
                result = remainder + result;
                n /= 8;
            }
            return result;
        }

        private string RoundBase8FractionalPart(string fractionalPart)
        {
            char[] digits = fractionalPart.ToCharArray();

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < '7')
                {
                    digits[i]++;
                    break;
                }
                else
                {
                    digits[i] = '0';
                    if (i == 0)
                    {
                        return "1" + new string(digits);
                    }
                }
            }

            return new string(digits);
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}

