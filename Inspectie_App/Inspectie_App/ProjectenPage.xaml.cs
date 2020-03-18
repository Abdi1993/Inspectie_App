using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Inspectie_App.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inspectie_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProjectenPage : ContentPage
    {
        SQLiteConnection connection;
        public ProjectenPage()
        {
            InitializeComponent();
        }

        private void ProjectsEditBtn_Clicked(object sender, EventArgs e)
        {
            ToolbarItem item = (ToolbarItem)sender;
            _ = Navigation.PushAsync(new AddProjectenPage());
        }

        private void SelectBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KaartPage());
        }
    }
}