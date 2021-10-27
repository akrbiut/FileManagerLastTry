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
using CefSharp.Wpf;
using CefSharp;
using System.Web;
using System.Collections.Specialized;

namespace FileManagerLastTry
{
    /// <summary>
    /// Логика взаимодействия для WindowAuth.xaml
    /// </summary>
    public partial class WindowAuth : Window
    {
        public WindowAuth()
        {
            InitializeComponent();
        }

        private void AuthWindow_Loaded(object sender, RoutedEventArgs e)
        {
            string AuthURL = "https://login.microsoftonline.com/common/oauth2/v2.0/authorize?client_id=9c443a93-ef16-413e-b02d-d203a228216a&scope=files.readwrite.all offline_access&response_type=code&redirect_uri=https://www.fileproject.xyz/filemanagernocap";
            Uri URL = new Uri(AuthURL);
            CEFBrowserAuth.Address = AuthURL;
        }

        public string ResFirstAuth_Code { get; set; }
        public string AccessToken { get; set; }
        public string RefreshTokenMG { get; set; }
        public string ClientIDMG { get; set; }
        public string RedirectUriMG { get; set; }
        public string SecretIDMG { get; set; }
        public string MethodReQuest { get; set; }
        private void CEFBrowserAuth_AddressChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }
    }
}
