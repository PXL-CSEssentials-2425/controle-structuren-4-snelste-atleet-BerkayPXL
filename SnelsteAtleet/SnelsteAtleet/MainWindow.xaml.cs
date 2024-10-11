using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SnelsteAtleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string nameFastest;
        int secondfastest = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox1.Clear();
            timeTextBox.Clear();
            resultTextBox.Clear();
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
              bool IsValidNumber = int.TryParse(timeTextBox.Text, out int secondcurrent);

            if (IsValidNumber)
            {
                if (secondcurrent == 0 || secondcurrent < secondfastest)
                {
                    secondfastest = secondcurrent;
                    nameFastest = nameTextBox1.Text;
                }
            }
        }

        private void fastestButton_Click(object sender, RoutedEventArgs e)
        {
        
        }
    }
}



            