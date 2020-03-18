using SQLite;
using Inspectie_App.Model;
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
        SQLiteConnection connection;
        //Project project;
        public AddProjectenPage()
        {
            InitializeComponent();
            
            //project = project;
            //connection = connection;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            

            using (SQLiteConnection connection = new SQLiteConnection(App.databaseLoaction))
            {
                
                connection.CreateTable<Project>();
                var projects = connection.Table<Project>().ToList();
                AddProjectList.ItemsSource = projects;
                /*.Where(i => i.ProjectId.Equals(AddProjectList.SelectedItem.ToString()));*/

            }
            //List<Project> projects = new List<Project>();
            //projects.Add(project);
            //AddProjectList.ItemsSource = projects;
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

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
            var selectedPro = AddProjectList.SelectedItem as Project;
            if (selectedPro != null)
            {
                _ = Navigation.PushAsync(new EditProjectPage(selectedPro));
            }
        }

        public void AddProjectList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.databaseLoaction))
            {
                Project project = new Project();
                
                connection.CreateTable<Area>();
                var Areas = connection.Table<Area>();/*.FirstOrDefault(x=>x.Project_Id==ProjectId)*/;
                AddGebiedList.ItemsSource = Areas;
                /*projects.Where(w => w.ProjectName.Contains(AddProjectList.SelectedItem.ToString())).OrderBy(o => o.ProjectName);*/
            }
        }
    }
}