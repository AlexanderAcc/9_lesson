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

namespace sum_numbers_overload
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
            List<string> mass = new List<string>(); // Список с неправильными значениями
            List<int> right_mass = new List<int>(); // Отфильтрованный список

            mass.Add(tx1.Text);
            mass.Add(tx2.Text);
            mass.Add(tx3.Text);
            mass.Add(tx4.Text); // Добавление значений в список

            for (int i = 0; i < mass.Count; i++) // Заполнение листа right_mass
            {
                if (Int32.TryParse(mass[i], out int j) == true)
                {
                    right_mass.Add(j);
                }
            }

            switch(right_mass.Count)
            {
                case 1:
                    lb1.Content = Class1.sum(right_mass[0]);
                    break;
                case 2:
                    lb1.Content = Class1.sum(right_mass[0], right_mass[1]);
                    break;
                case 3:
                    lb1.Content = Class1.sum(right_mass[0], right_mass[1], right_mass[2]);
                    break;
                case 4:
                    lb1.Content = Class1.sum(right_mass[0], right_mass[1], right_mass[2], right_mass[3]);
                    break;
                default:
                    lb1.Content = "null";
                    break;
            }
        }
    }
}
