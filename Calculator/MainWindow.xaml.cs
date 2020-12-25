using System;
using System.Collections.Generic;
using System.IO;
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
using System.Diagnostics;
using System.Globalization;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string language;
        public MainWindow()
        {
            InitializeComponent();
            language = "rus-RU";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x, y;
            double z;
            string S1 = textA.Text;
            string S2 = textB.Text;
            if ((S1 == "") || (S2 == ""))
            { MessageBox.Show("Вы не ввели значение в оба поля!!!"); }
            else
            {
                x = Convert.ToInt32(S1);
                y = Convert.ToInt32(S2);
                z = x * y;
                result.Content = z.ToString();
                StreamWriter sw = new StreamWriter(@"D:\vs\svp\Calculator\Calculator\Save_Result.txt", true);
                sw.WriteLine("умножение:" + result.Content);
                sw.Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int x, y;
            double z;
            string S1 = textA.Text;
            string S2 = textB.Text;
            if ((S1 == "") || (S2 == ""))
            { MessageBox.Show("Вы не ввели значение в оба поля!!!"); }
            else
            {
                x = Convert.ToInt32(S1);
                y = Convert.ToInt32(S2);
                z = x / y;
                result.Content = z.ToString();
                StreamWriter sw = new StreamWriter(@"D:\vs\svp\Calculator\Calculator\Save_Result.txt", true);
                sw.WriteLine("деление:" + result.Content);
                sw.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int x, y;
            double z;
            string S1 = textA.Text;
            string S2 = textB.Text;
            if ((S1 == "") || (S2 == ""))
            { MessageBox.Show("Вы не ввели значение в оба поля!!!"); }
            else
            {
                x = Convert.ToInt32(S1);
                y = Convert.ToInt32(S2);
                z = x + y;
                result.Content = z.ToString();
                StreamWriter sw = new StreamWriter(@"D:\vs\svp\Calculator\Calculator\Save_Result.txt", true);
                sw.WriteLine("сложение:" + result.Content);
                sw.Close();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int x, y;
            double z;
            string S1 = textA.Text;
            string S2 = textB.Text;
            if ((S1 == "") || (S2 == ""))
            { MessageBox.Show("Вы не ввели значение в оба поля!!!"); }
            else
            {
                x = Convert.ToInt32(S1);
                y = Convert.ToInt32(S2);
                z = x - y;
                result.Content = z.ToString();
                StreamWriter sw = new StreamWriter(@"D:\vs\svp\Calculator\Calculator\Save_Result.txt", true);
                sw.WriteLine("вычитание:" + result.Content);
                sw.Close();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textA.Text = "";
            textB.Text = "";
            result.Content = 0;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("notepad.exe", "D:\\vs\\svp\\Calculator\\Calculator\\Save_Result.txt");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                ComboBox cb = sender as ComboBox;
            language = (cb.SelectedItem as ComboBoxItem).Tag.ToString();

            if (language != null)
            {
                CultureInfo lang = new CultureInfo(language);

                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }
    }
}


        