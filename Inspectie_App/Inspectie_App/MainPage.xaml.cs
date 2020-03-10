using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inspectie_App
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        static public HomePage home {get;set;}
        public MainPage()
        {
            InitializeComponent();
            
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new HomePage());
        }
    }
}
