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
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBox.Text = string.Empty;
            _result = 0;
            _operator = string.Empty;
            _isOperatorClicked = false;
        }
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (_isOperatorClicked)
            {
                ResultTextBox.Text = button.Content.ToString();
                _isOperatorClicked = false;
            }
            else
            {
                ResultTextBox.Text += button.Content.ToString();
            }
        }
        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(ResultTextBox.Text, out _result))
            {
                Button button = sender as Button;
                _operator = button.Content.ToString();
                _isOperatorClicked = true;
            }
        }
    }
}
