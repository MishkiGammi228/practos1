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
using Lib_4;

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Вычислить_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int counts = Convert.ToInt32(count.Text);
                Practice.MiniNumber(counts, out int miniNumber, out string number);
                otvet.Text = miniNumber.ToString(); otvet2.Text = number;
            }
            catch
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }

        private void О_программе_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Найти минимум из n целых случайных чисел X, распределенных в диапазоне от 10 до 40." +
                "Вывести на экран на одной строке сгенерированные числа, на другой строке результат");

        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
