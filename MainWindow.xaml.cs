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

        public string code { get; set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FileBrowserPath.Navigate("C:/");
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (FileBrowserPath.CanGoBack)
            {
                FileBrowserPath.GoBack();
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (FileBrowserPath.CanGoForward)
            {
                FileBrowserPath.GoForward();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileBrowserPath.Refresh();
        }

        private void TextPathLink_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                FileBrowserPath.Navigate(TextPathLink.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void ConnectToODButton_Click(object sender, RoutedEventArgs e)
        {
            WindowAuth WA = new WindowAuth();
            WA.Show();
        }

        private void OneDriveFoldButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FileBrowserPath_Navigated(object sender, NavigationEventArgs e)
        {
            TextPathLink.Text = e.Uri.LocalPath;
        }
    }
}


