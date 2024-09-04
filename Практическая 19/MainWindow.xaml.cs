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

namespace Практическая_19
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lb.Items.Add(zn.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lb.Items.Remove(lb.SelectedItem);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            lb.Items.Clear();
            rez.Clear();
            zn.Clear();
            zn1.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int i, n = Convert.ToInt32(zn1.Text);
            for (i = 1; i <= n; i++)
                lb.Items.Add(rnd.Next(-10, 10));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            int i, sum = 0;
            for ( i = 0; i< lb.Items.Count; i++)
                sum = sum + Convert.ToInt32(lb.Items[i]);
            rez.Text = sum.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
             MessageBox.Show("Гуреева Ирина Дмитриевна. \n19 практическая \nВвести n целых чисел(>0 или <0). Найти произведение чисел. Результат вывести на экран. \nНе замужем ", "Обо мне");
        
        }
    }
}
