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

namespace FileManagerLastTry
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

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            (FileWeNeed.Child as System.Windows.Forms.WebBrowser).Url = new Uri("C:/");
            TextPathLink.Text = (FileWeNeed.Child as System.Windows.Forms.WebBrowser).Url.LocalPath;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if ((FileWeNeed.Child as System.Windows.Forms.WebBrowser).CanGoBack)
            {
                (FileWeNeed.Child as System.Windows.Forms.WebBrowser).GoBack();
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if ((FileWeNeed.Child as System.Windows.Forms.WebBrowser).CanGoForward)
            {
                (FileWeNeed.Child as System.Windows.Forms.WebBrowser).GoForward();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (FileWeNeed.Child as System.Windows.Forms.WebBrowser).Refresh();
        }

        private void TextPathLink_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                (FileWeNeed.Child as System.Windows.Forms.WebBrowser).Url = new Uri(TextPathLink.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void ConnectToODButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}


