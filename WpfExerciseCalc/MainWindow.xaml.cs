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
using System.Text.RegularExpressions;

namespace WpfExerciseCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float firstNum;
        private float secondNum;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            
            if(CheckIfValid())
            {
                var sum = firstNum + secondNum;
                MessageBox.Show($"{firstNum} + {secondNum} = {sum}");   
            }                     
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            if(CheckIfValid())
            {
                var sum = firstNum - secondNum;
                MessageBox.Show($"{firstNum} - {secondNum} = {sum}");
            }
        }

        private void timesButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckIfValid())
            {
                var sum = firstNum * secondNum;
                MessageBox.Show($"{firstNum} x {secondNum} = {sum}");
            }
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckIfValid())
            {
                var sum = firstNum / secondNum;
                MessageBox.Show($"{firstNum} / {secondNum} = {sum}");
            }
        }

        public bool CheckIfValid()
        {
            if (firstTextBox.Text == "" || Regex.IsMatch(firstTextBox.Text,@"[a-zA-Z]"))
            {
                MessageBox.Show("You haven't entered a valid first number", "Error");
                return false;
            }                         
            else
                firstNum = int.Parse(firstTextBox.Text);

            if (secondTextBox.Text == "" || Regex.IsMatch(secondTextBox.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("You haven't entered a valid second number", "Error");
                return false;
            }
            else
            {
                int value;
                if(Int32.TryParse(secondTextBox.Text, out value))
                {
                    secondNum = int.Parse(secondTextBox.Text);
                }
                else
                {
                    secondNum = 0;
                }
            }

            return true;
        }              

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            firstTextBox.Text = "";
            secondTextBox.Text = "";
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
