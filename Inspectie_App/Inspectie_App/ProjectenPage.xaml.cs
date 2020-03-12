using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inspectie_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectenPage : ContentPage
    {
        public ProjectenPage()
        {
            InitializeComponent();
        }

        private void ProjectsEditBtn_Clicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            Navigation.PushAsync(new AddProjectenPage());
        }

        private void SelectBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KaartPage());
        }
    }
}