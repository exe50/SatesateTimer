using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
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
using System.Windows.Forms;
using System.Configuration;
using TweetSharp;



namespace SatesateTimer_WPF
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        static public TwitterService service = new TwitterService("0KVaGxWPhXfPs8Tm42Pdhg", "nL3dnrnVaZ4F6ZxK6SI7z2kYTSfzxi3pSHoxoqRXw");
        static public OAuthRequestToken requestToken = service.GetRequestToken();
        static public Uri uri = service.GetAuthenticationUrl(requestToken);

        public MainWindow()
        {
            InitializeComponent();

        }


        #region ConsumerKey & ConsumerSecret
        private static string ConsumerSecret
        {
            get { return ConfigurationManager.AppSettings["ConsumerSecret"]; }
        }

        private static string ConsumerKey
        {
            get { return ConfigurationManager.AppSettings["ConsumerKey"]; }
        }
        #endregion



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        public void Button_Click_2(object sender, RoutedEventArgs e)
        {
                //if (SharedState.Authorizer == null)
               new OAuth().Show();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
