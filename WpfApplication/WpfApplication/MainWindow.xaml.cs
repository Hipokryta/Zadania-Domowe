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
using System.Drawing;
namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int kliker = 0;
        public MainWindow()
        {
            InitializeComponent();
            //Movie.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)hogwart.IsChecked)
            {
                Ron.Height = Ron.ActualHeight / 2;
                Ron.Width = Ron.ActualWidth / 2;
                RonText.FontSize = RonText.FontSize / 1.5;
            }
            else
            {
                Random rand = new Random();
                int randomOne = rand.Next(1, 100);
                int randomTwo = rand.Next(1, 250);
                Button button = new Button();
                button.Margin = new Thickness(randomOne, -2 * randomOne, 2 * randomTwo, randomTwo / 2);

                button.Click += new RoutedEventHandler(Button_Click);
                button.Height = 80;
                button.Width = 150;
                button.Content = "Tak";
                button.Background = new SolidColorBrush(Colors.Orange);
                button.Foreground = new SolidColorBrush(Colors.Black);
                gridd.Children.Add(button);
            }
           
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            gridd.Background = Brushes.Orange;

        }

        private void noButton_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)hogwart.IsChecked)
            {
                Ron.Height = Ron.ActualHeight * 2;
                Ron.Width = Ron.ActualWidth * 2;
                RonText.Opacity = 100;
                RonText.FontSize = RonText.FontSize * 1.5;

            }
            
        }
        
    }
}
