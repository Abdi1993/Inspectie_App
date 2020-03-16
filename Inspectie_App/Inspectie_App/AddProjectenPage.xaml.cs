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
    public partial class AddProjectenPage : ContentPage
    {
        public AddProjectenPage()
        {
            InitializeComponent();
           
        }

        private void AddProjectBtn_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new AddNewProjectPage());
            
        }

        private void AddGebiedBtn_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new AddNewAreaPage());
        }

        private void AddGebouwBtn_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new AddNewBuildingPage());
        }

        private void AddVerdiepingBtn_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new AddNewLvlPage());
        }

        private void DltVerdiepingBtn_Clicked(object sender, EventArgs e)
        {

        }

        private void EditAreaBtn_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new EditAreaPage());
        }

        private void EditBuildingBtn_Clicked(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new EditBuildingPage());
        }

        private void EditprojectsBtn_Clicked_1(object sender, EventArgs e)
        {
            _ = Navigation.PushAsync(new EditProjectPage());
        }
    }
}