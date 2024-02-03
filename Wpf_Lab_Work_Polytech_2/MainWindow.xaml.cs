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

namespace Wpf_Lab_Work_Polytech_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void f_b_clear(object sender, RoutedEventArgs e)
        {
            output_displ.Text = "";
        }

        private void f_b_percent(object sender, RoutedEventArgs e)
        {
            output_displ.Text += " " + b_percent.Content.ToString() + " ";
        }

        private void f_b_backspace(object sender, RoutedEventArgs e)
        {
            if (output_displ.Text.Length>0) output_displ.Text =  output_displ.Text.Remove(output_displ.Text.Length-1);


        }

        private void f_(object sender, RoutedEventArgs e)
        {
            // ???
        }

        private void f_b_slesh(object sender, RoutedEventArgs e)
        {
            output_displ.Text += " " + b_slesh.Content.ToString() + " ";
        }

        private void f_b_7(object sender, RoutedEventArgs e)
        {
            output_displ.Text += b7.Content.ToString();
        }

        private void f_b_8(object sender, RoutedEventArgs e)
        {
            output_displ.Text += b8.Content.ToString();
        }

        private void f_b_9(object sender, RoutedEventArgs e)
        {
            output_displ.Text += b9.Content.ToString();
        }

        private void f_b_X(object sender, RoutedEventArgs e)
        {
            output_displ.Text += " " + b_X.Content.ToString()+ " ";
        }

        private void f_b_4(object sender, RoutedEventArgs e)
        {
            output_displ.Text += b4.Content.ToString();
        }

        private void f_b_5(object sender, RoutedEventArgs e)
        {
            output_displ.Text += b5.Content.ToString();
        }

        private void f_b_6(object sender, RoutedEventArgs e)
        {
            output_displ.Text += b6.Content.ToString();
        }

        private void f_b_1(object sender, RoutedEventArgs e)
        {
            output_displ.Text += b1.Content.ToString();
        }

        private void f_b_2(object sender, RoutedEventArgs e)
        {
            output_displ.Text += b2.Content.ToString();
        }

        private void f_b_3(object sender, RoutedEventArgs e)
        {
            output_displ.Text += b3.Content.ToString();
        }

        private void f_b_minus(object sender, RoutedEventArgs e)
        {
            output_displ.Text += " " + b_minus.Content.ToString() + " ";
        }

        private void f_b_plus(object sender, RoutedEventArgs e)
        {
            output_displ.Text += " " + b_plus.Content.ToString() + " ";
        }

        private void f_b_00(object sender, RoutedEventArgs e)
        {
            output_displ.Text += b00.Content.ToString();
        }

        private void f_b_0(object sender, RoutedEventArgs e)
        {
            output_displ.Text += b0.Content.ToString();
        }

        private void f_b_point(object sender, RoutedEventArgs e)
        {
            output_displ.Text += b_point.Content.ToString();
        }


        private double f_percent(double a, double b)
        {
            return (a / 100) * b;
        }
        private void f_b_equels(object sender, RoutedEventArgs e)
        {
            double num1, num2;
            int size = output_displ.Text.Split().Length;
            string[] txt = new string[size];
            
            txt = output_displ.Text.Split(' ');
            
            num1 = double.Parse(txt[0]);
            num2 = double.Parse(txt[2]);

            

            if (txt[1] == "+") output_displ.Text = Convert.ToString(num1 + num2);

            if (txt[1] == "-") output_displ.Text = Convert.ToString(num1 - num2);

            if (txt[1] == "/") output_displ.Text = Convert.ToString(num1 / num2);

            if (txt[1] == "x") output_displ.Text = Convert.ToString((double)num1 * num2);

            if (txt[1] == "%") output_displ.Text = Convert.ToString(f_percent(num1,num2));



        }
    }
}
