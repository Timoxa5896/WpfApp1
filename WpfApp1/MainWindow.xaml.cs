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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _result;
        private string _operator;
        private bool _isOperatorClicked;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(ResultTextBox.Text, out double secondOperand))
            {
                switch (_operator)
                {
                    case "+":
                        _result += secondOperand;
                        break;
                    case "-":
                        _result -= secondOperand;
                        break;
                    case "*":
                        _result *= secondOperand;
                        break;
                    case "/":
                        if (secondOperand != 0)
                        {
                            _result /= secondOperand;
                        }
                        else
                        {
                            MessageBox.Show("Деление на ноль невозможно!");
                            return;
                        }
                        break;
                }
                ResultTextBox.Text = _result.ToString();
            }
        }
    }
}
