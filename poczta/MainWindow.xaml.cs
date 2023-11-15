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

namespace poczta
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri postcardImg = new Uri("list.png", UriKind.Relative);
            Uri letterImg = new Uri("list1.png", UriKind.Relative);
            Uri packageImg = new Uri("list2.png", UriKind.Relative);

            if (pocztowka.IsChecked == true)
            {
                cena.Text = "Cena: 1zł";
                zdj.Source = new BitmapImage(postcardImg);
            }
            if (list.IsChecked == true)
            {
                cena.Text = "Cena: 1,5zł";
                zdj.Source = new BitmapImage(letterImg);
            }
            if (paczka.IsChecked == true)
            {
                cena.Text = "Cena: 10zł";
                zdj.Source = new BitmapImage(packageImg);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string postalCode = kod.Text;
            if (postalCode.Length == 5)
            {
                try
                {
                    int numericPostalCode = Convert.ToInt32(kod.Text);
                    MessageBox.Show("Dane prawidłowe");
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("W kodzie pocztowym powinny być tylko cyfry");
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowa długość kodu pocztowego!");
            }

        }

        private void list_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
