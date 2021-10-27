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
using System.Windows.Shapes;
using System.Configuration;
using System.Collections.Specialized;

namespace FileManagerLastTry
{
    /// <summary>
    /// Логика взаимодействия для SettingWindow.xaml
    /// </summary>
    public partial class SettingWindow : Window
    {
        public SettingWindow()
        {
            InitializeComponent();
        }

        public string FilePathDoc { get; set; }
        public string FilePathBad { get; set; }

        private void ChooseButt1_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog OFD = new Microsoft.Win32.SaveFileDialog();
            OFD.FileName = "101";
            OFD.DefaultExt = ".txt";
            Nullable<bool> res = OFD.ShowDialog();
            if (res == true)
            {
                FilePathDoc = OFD.FileName;
            }
            TextBoxDoc.Text = FilePathDoc.Substring(0, FilePathDoc.Length - 7);
        }

        private void ChooseButt2_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog OFD = new Microsoft.Win32.SaveFileDialog();
            OFD.FileName = "101";
            OFD.DefaultExt = ".txt";
            Nullable<bool> res = OFD.ShowDialog();
            if (res == true)
            {
                FilePathBad = OFD.FileName;
            }
            TextBoxDoc.Text = FilePathBad.Substring(0, FilePathDoc.Length - 7);
        }

        private void ReadyButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
