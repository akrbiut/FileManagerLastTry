using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace FileManagerLastTry
{
    /// <summary>
    /// Логика взаимодействия для SortWindow.xaml
    /// </summary>
    public partial class SortWindow : Window
    {
        public SortWindow(string PathDa)
        {
            InitializeComponent();
            AURL = PathDa;
        }

        public string AURL;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SettingWindow SW = new SettingWindow();
            MainWindow MW = new MainWindow();
            ListFiles.Items.Clear();
            try
            {
                IEnumerable<string> allFiles = Directory.EnumerateFiles(AURL, "*.docx");
                foreach (string fileName in allFiles)
                {
                    ListFiles.Items.Add(fileName);
                }
            }
            catch (DirectoryNotFoundException)
            {
                ListFiles.Items.Add("В данном каталоге отсутствуют подходящие файлы!");
            }
        }

        private void ListFiles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
