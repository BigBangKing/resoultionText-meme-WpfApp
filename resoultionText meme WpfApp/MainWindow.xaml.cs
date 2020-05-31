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

namespace resoultionText_meme_WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string letterbox, meme = "";
            letterbox = letter.Text;
            int number = Int32.Parse(NumberTextBox.Text);

            for(int i = 0; i<= number; i++)
            {
                meme += letterbox;
            }

            memeBox.Text += meme;


        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            memeBox.Text = "";
            letter.Text = "";
            NumberTextBox.Text = "0";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            memeBox.TextAlignment = TextAlignment.Left;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            memeBox.TextAlignment = TextAlignment.Center;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            memeBox.TextAlignment = TextAlignment.Right;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            memeBox.Text = "";
        }
    }
}
