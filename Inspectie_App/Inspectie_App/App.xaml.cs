using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inspectie_App
{
    public partial class App : Application
    {

        public static string databaseLoaction = string.Empty;
        public App(string fullPath)
        {
            InitializeComponent();
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            MainPage = new NavigationPage(new MainPage());
            databaseLoaction = fullPath;
            
           
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
