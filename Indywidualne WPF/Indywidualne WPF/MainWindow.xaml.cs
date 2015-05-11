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
using System.Text.RegularExpressions;
using System.IO;

namespace Indywidualne_WPF
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
        
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private bool checkIfTextBoxesAreFull()
        {
            if (!String.IsNullOrEmpty(name.Text) &&
                !String.IsNullOrEmpty(style.Text) &&
                !String.IsNullOrEmpty(levelTxT.Text))
            {
                return true;
            }
            return false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (checkIfTextBoxesAreFull())
            {
                var csv = new StreamWriter(@"Text.txt", true);
                using (csv)
                {
                    var nameOfCharacter = name.Text;
                    var specialStyle = style.Text;
                    var lvl = levelTxT.Text;
                    var col = color.Text;
                    var newLine = string.Format("{0};{1};{2};{3}{4}", nameOfCharacter, specialStyle, lvl, col, Environment.NewLine);
                    csv.Write(newLine); 
                }
                cleanBoxes();
            }
        }
        private void cleanBoxes()
        {
            name.Text = "";
            style.Text = "";
            levelTxT.Text = "";
            color.SelectedIndex = 0;
        }

    }
}
