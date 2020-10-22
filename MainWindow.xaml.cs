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

namespace WPFMorseCodeConverter
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

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string str = txtToBeConverted.Text;
                char c = ' ';
                foreach (char ch in str)
                {
                    if (char.IsLetter(ch) && char.IsLower(ch))
                    {
                        c = char.ToUpper(ch);
                    }
                    else
                    {
                        c = ch;
                    }

                    switch (c)
                    {
                        case ' ': CodeList.Items.Add(" "); break;
                        case ',': CodeList.Items.Add("--..--"); break;
                        case '.': CodeList.Items.Add(".-.-.-"); break;
                        case '?': CodeList.Items.Add("..--.."); break;
                        case '0': CodeList.Items.Add("-----"); break;
                        case '1': CodeList.Items.Add(".----"); break;
                        case '2': CodeList.Items.Add("..---"); break;
                        case '3': CodeList.Items.Add("...--"); break;
                        case '4': CodeList.Items.Add("....-"); break;
                        case '5': CodeList.Items.Add("....."); break;
                        case '6': CodeList.Items.Add("-...."); break;
                        case '7': CodeList.Items.Add("--..."); break;
                        case '8': CodeList.Items.Add("---.."); break;
                        case '9': CodeList.Items.Add("----."); break;
                        case 'A': CodeList.Items.Add(".-"); break;
                        case 'B': CodeList.Items.Add("-..."); break;
                        case 'C': CodeList.Items.Add("-.-."); break;
                        case 'D': CodeList.Items.Add("-.."); break;
                        case 'E': CodeList.Items.Add("."); break;
                        case 'F': CodeList.Items.Add("..-."); break;
                        case 'G': CodeList.Items.Add("--."); break;
                        case 'H': CodeList.Items.Add("...."); break;
                        case 'I': CodeList.Items.Add(".."); break;
                        case 'J': CodeList.Items.Add(".---"); break;
                        case 'K': CodeList.Items.Add("-.-"); break;
                        case 'L': CodeList.Items.Add(".-.."); break;
                        case 'M': CodeList.Items.Add("--"); break;
                        case 'N': CodeList.Items.Add("-."); break;
                        case 'O': CodeList.Items.Add("---"); break;
                        case 'P': CodeList.Items.Add(".--."); break;
                        case 'Q': CodeList.Items.Add("--.-"); break;
                        case 'R': CodeList.Items.Add(".-."); break;
                        case 'S': CodeList.Items.Add("..."); break;
                        case 'T': CodeList.Items.Add("-"); break;
                        case 'U': CodeList.Items.Add("..-"); break;
                        case 'V': CodeList.Items.Add("...-"); break;
                        case 'W': CodeList.Items.Add(".--"); break;
                        case 'X': CodeList.Items.Add("-..-"); break;
                        case 'Y': CodeList.Items.Add("-.--"); break;
                        case 'Z': CodeList.Items.Add("--.."); break;
                        default: CodeList.Items.Add(""); break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
