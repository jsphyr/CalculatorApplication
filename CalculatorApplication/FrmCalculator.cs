namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);
    public partial class FrmCalculator : Form
    {
        private CalculatorClass cal;

        public FrmCalculator()
        {
            InitializeComponent();
            
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            CalculatorClass cal = new CalculatorClass();

            double num1, num2;
            try
            {
                num1 = Convert.ToDouble(txtBoxInput1.Text);
                num2 = Convert.ToDouble(txtBoxInput2.Text);

                switch (cbOperator.SelectedItem.ToString())
                {
                    case "+":
                        cal.CalculateEvent += new Formula<double>(cal.GetSum);
                        lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                        break;
                    case "-":
                        cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                        lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                        break;
                    case "*":
                        cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                        lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                        break;
                    case "/":
                        cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                        lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                        break;
                    default:
                        MessageBox.Show("Please select an operator.");
                        return;
                }
            }
            catch (FormatException)
            {
                lblDisplayTotal.Text = "Invalid input";
            }
            catch (DivideByZeroException ex)
            {
                lblDisplayTotal.Text = ex.Message;
            }
        }
        public class CalculatorClass
        {


            public Formula<double> Calculation;

            private event Formula<double> calculateEvent;

            public event Formula<double> CalculateEvent
            {
                add
                {
                    calculateEvent += value;
                    Console.WriteLine("Added the Delegate.");
                }
                remove
                {
                    calculateEvent -= value;
                    Console.WriteLine("Removed the Delegate.");
                }
            }

            public double GetSum(double num1, double num2)
            {
                return num1 + num2;
            }

            public double GetDifference(double num1, double num2)
            {
                return num1 - num2;
            }
            public double GetProduct(double num1, double num2)
            {
                return num1 * num2;
            }
            public double GetQuotient(double num1, double num2)
            {
                if (num2 != 0)
                {
                    return num1 / num2;
                }
                else
                {
                    throw new DivideByZeroException("Cannot Divide by zero.");
                }
            }
        }
    }
}
