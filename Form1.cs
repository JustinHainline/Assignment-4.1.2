using System.Diagnostics.Eventing.Reader;

namespace Assignment_4._1._2
{
    public partial class Calculator : Form, ICalculator
    {
        double firstNumber = 0;
        string Operation = "";


        public Calculator()
        {
            InitializeComponent();
        }

        public void Add()
        {
            firstNumber = Convert.ToDouble(Resulttextbox.Text);
            Resulttextbox.Text = "0";
            Operation = "+";
        }

        public void Subtract()
        {
            firstNumber = Convert.ToDouble(Resulttextbox.Text);
            Resulttextbox.Text = "0";
            Operation = "-";
        }

        public void Multiply()
        {
            firstNumber = Convert.ToDouble(Resulttextbox.Text);
            Resulttextbox.Text = "0";
            Operation = "*";
        }

        public void Divide()
        {
            firstNumber = Convert.ToDouble(Resulttextbox.Text);
            Resulttextbox.Text = "0";
            Operation = "/";
        }




        private void Onebutton_Click(object sender, EventArgs e)
        {
            if (Resulttextbox.Text == "0" && Resulttextbox.Text != null)
            {
                Resulttextbox.Text = "1";
            }
            else
            {
                Resulttextbox.Text = Resulttextbox.Text + "1";
            }
        }

        private void Twobutton_Click(object sender, EventArgs e)
        {
            if (Resulttextbox.Text == "0" && Resulttextbox.Text != null)
            {
                Resulttextbox.Text = "2";
            }
            else
            {
                Resulttextbox.Text = Resulttextbox.Text + "2";
            }
        }

        private void Threebutton_Click(object sender, EventArgs e)
        {
            if (Resulttextbox.Text == "0" && Resulttextbox.Text != null)
            {
                Resulttextbox.Text = "3";
            }
            else
            {
                Resulttextbox.Text = Resulttextbox.Text + "3";
            }
        }

        private void Fourbutton_Click(object sender, EventArgs e)
        {
            if (Resulttextbox.Text == "0" && Resulttextbox.Text != null)
            {
                Resulttextbox.Text = "4";
            }
            else
            {
                Resulttextbox.Text = Resulttextbox.Text + "4";
            }
        }

        private void Fivebutton_Click(object sender, EventArgs e)
        {
            if (Resulttextbox.Text == "0" && Resulttextbox.Text != null)
            {
                Resulttextbox.Text = "5";
            }
            else
            {
                Resulttextbox.Text = Resulttextbox.Text + "5";
            }
        }

        private void Sixbutton_Click(object sender, EventArgs e)
        {
            if (Resulttextbox.Text == "0" && Resulttextbox.Text != null)
            {
                Resulttextbox.Text = "6";
            }
            else
            {
                Resulttextbox.Text = Resulttextbox.Text + "6";
            }
        }

        private void Sevenbutton_Click(object sender, EventArgs e)
        {
            if (Resulttextbox.Text == "0" && Resulttextbox.Text != null)
            {
                Resulttextbox.Text = "7";
            }
            else
            {
                Resulttextbox.Text = Resulttextbox.Text + "7";
            }
        }

        private void Eightbutton_Click(object sender, EventArgs e)
        {
            if (Resulttextbox.Text == "0" && Resulttextbox.Text != null)
            {
                Resulttextbox.Text = "8";
            }
            else
            {
                Resulttextbox.Text = Resulttextbox.Text + "8";
            }
        }

        private void Ninebutton_Click(object sender, EventArgs e)
        {
            if (Resulttextbox.Text == "0" && Resulttextbox.Text != null)
            {
                Resulttextbox.Text = "9";
            }
            else
            {
                Resulttextbox.Text = Resulttextbox.Text + "9";
            }
        }

        private void Zerobutton_Click(object sender, EventArgs e)
        {
            if (Resulttextbox.Text == "0" && Resulttextbox.Text != null)
            {
                Resulttextbox.Text = "0";
            }
            else
            {
                Resulttextbox.Text = Resulttextbox.Text + "0";
            }
        }

        private void Decimalbutton_Click(object sender, EventArgs e)
        {
            if (Resulttextbox.Text == "0" && Resulttextbox.Text != null)
            {
                Resulttextbox.Text = ".";
            }
            else
            {
                Resulttextbox.Text = Resulttextbox.Text + ".";
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            if (Resulttextbox.Text == "0" && Resulttextbox.Text != null)
            {
                Resulttextbox.Text = "0";
            }
            else
            {
                Resulttextbox.Text = "0";
            }
        }

        private void Subtractbutton_Click(object sender, EventArgs e)
        {
            Subtract();
        }

        private void Plusbutton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Multiplybutton_Click(object sender, EventArgs e)
        {
            Multiply();
        }

        private void Dividebutton_Click(object sender, EventArgs e)
        {
            Divide();
        }

        private void Equalsbutton_Click(object sender, EventArgs e)
        {
           double secondNumber = Convert.ToDouble(Resulttextbox.Text);
            double result;

            switch (Operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    Resulttextbox.Text = Convert.ToString(result);
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    Resulttextbox.Text += Convert.ToString(result);
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    Resulttextbox.Text = Convert.ToString(result);
                    break;
                case "/":
                   if (secondNumber > 0)
                    {
                        result = firstNumber / secondNumber;
                        Resulttextbox.Text = Convert.ToString(result);
                    }
                   else
                    {
                        Resulttextbox.Text = "Divide by zero Error!";
                    }
                   break;
            }

           
        }
    }
}
