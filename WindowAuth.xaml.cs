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

        private int a = 0;
        public string ResFirstAuth_Code { get; set; }
        public string AccessToken { get; set; }
        public string RefreshTokenMG { get; set; }
        public string ClientIDMG { get; set; }
        public string RedirectUriMG { get; set; }
        public string SecretIDMG { get; set; }
        public string MethodReQuest { get; set; }
        private void CEFBrowserAuth_AddressChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            ++a;
            if (a == 4)
            {
                //Получение кода авторизации
                var readyToDa = new UriBuilder(CEFBrowserAuth.Address);
                var qscoll = HttpUtility.ParseQueryString(readyToDa.Query);
                ResFirstAuth_Code = qscoll["code"];
                //Активация кода и получение маркеров доступа
                ClientIDMG = "9c443a93-ef16-413e-b02d-d203a228216a";
                RedirectUriMG = "https://www.fileproject.xyz/filemanagernocap";
                SecretIDMG = "uMW7Q~NyEMdLsdC6OZfcFWOU9Ps_7bLavvCsZ";
                System.Net.WebRequest POSTOAuth = System.Net.WebRequest.Create(@"https://login.microsoftonline.com/common/oauth2/v2.0/token");
                POSTOAuth.Method = "POST";
                POSTOAuth.Timeout = 120000;
                POSTOAuth.ContentType = "application/x-www-form-urlencoded";
                MethodReQuest = $"client_id={ClientIDMG}&redirect_uri={RedirectUriMG}&client_secret={SecretIDMG}&code={ResFirstAuth_Code}&grant_type = authorization_code";
                byte[] sentData = Encoding.UTF8.GetBytes(MethodReQuest);
                POSTOAuth.ContentLength = sentData.Length;
                System.IO.Stream sendStream = POSTOAuth.GetRequestStream();
                sendStream.Write(sentData, 0, sentData.Length);
                sendStream.Close();
                System.Net.WebResponse result = POSTOAuth.GetResponse();
                MessageBox.Show("OK");
            }
        }
    }
}
