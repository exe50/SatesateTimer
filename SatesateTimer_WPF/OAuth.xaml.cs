using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TweetSharp;
using System.Diagnostics;

namespace SatesateTimer_WPF
{
    public partial class OAuth : Window
    {

        public OAuth()
        {
            InitializeComponent();

            
            //Process.Start(uri.ToString());
            OAuthWebBrowser.Source = MainWindow.uri;
            //string verifier = Console.ReadLine();

            //OAuthAccessToken access = service.GetAccessToken(requestToken, verifier);
            //service.AuthenticateWith(access.Token, access.TokenSecret);

        }

    }
}
