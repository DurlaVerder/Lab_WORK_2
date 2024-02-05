using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
using NCalc;

namespace Wpf_Lab2_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CultureInfo customCulture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;


        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            res_txt.Text += button.Content.ToString();
        }

        private void b_Click_equals(object sender, RoutedEventArgs e)
        {

            NCalc.Expression expression = new NCalc.Expression(res_txt.Text);

            res_txt.Text = Math.Round(Convert.ToDouble(expression.Evaluate()),8).ToString();
        }
    }
}
