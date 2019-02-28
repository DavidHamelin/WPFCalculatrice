using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TP_Calculator
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long numberOne = 0;
        long numberTwo = 0;
        string operation = "";
        bool total = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
            {
                Reset();
            }

            if (operation == "")
            {
                numberOne = numberOne * 10;
                Output.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = numberTwo * 10;
                Output.Text = numberTwo.ToString();
            }
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
            {
                Reset();
            }

            if (operation == "")
            {
                numberOne = (numberOne * 10) + 1;
                Output.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 1;
                Output.Text = numberTwo.ToString();
            }
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
            {
                Reset();
            }

            if (operation == "")
            {
                numberOne = (numberOne * 10) + 2;
                Output.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 2;
                Output.Text = numberTwo.ToString();
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
            {
                Reset();
            }

            if (operation == "")
            {
                numberOne = (numberOne * 10) + 3;
                Output.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 3;
                Output.Text = numberTwo.ToString();
            }
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
            {
                Reset();
            }

            if (operation == "")
            {
                numberOne = (numberOne * 10) + 4;
                Output.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 4;
                Output.Text = numberTwo.ToString();
            }
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
            {
                Reset();
            }

            if (operation == "")
            {
                numberOne = (numberOne * 10) + 5;
                Output.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 5;
                Output.Text = numberTwo.ToString();
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
            {
                Reset();
            }

            if (operation == "")
            {
                numberOne = (numberOne * 10) + 6;
                Output.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 6;
                Output.Text = numberTwo.ToString();
            }
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
            {
                Reset();
            }

            if (operation == "")
            {
                numberOne = (numberOne * 10) + 7;
                Output.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 7;
                Output.Text = numberTwo.ToString();
            }
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
            {
                Reset();
            }

            if (operation == "")
            {
                numberOne = (numberOne * 10) + 8;
                Output.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 8;
                Output.Text = numberTwo.ToString();
            }
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (total == true)
            {
                Reset();
            }

            if (operation == "")
            {
                numberOne = (numberOne * 10) + 9;
                Output.Text = numberOne.ToString();
            }
            else
            {
                numberTwo = (numberTwo * 10) + 9;
                Output.Text = numberTwo.ToString();
            }
        }

        void Reset()
        {
            numberOne = 0;
            numberTwo = 0;
            operation = "";
            total = false;
            Output.Text = "0";
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            Output.Text = "0";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            Output.Text = "0";
        }

        private void Substract_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            Output.Text = "0";
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            Output.Text = "0";
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Output.Text = (numberOne + numberTwo).ToString();
                    break;
                case "-":
                    Output.Text = (numberOne - numberTwo).ToString();
                    break;
                case "*":
                    Output.Text = (numberOne * numberTwo).ToString();
                    break;
                case "/":
                    Output.Text = (numberOne / numberTwo).ToString();
                    break;
            }
            total = true;
        }
    }
}
