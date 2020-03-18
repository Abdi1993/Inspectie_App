using Inspectie_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Inspectie_App;

namespace Inspectie_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewProjectPage : ContentPage
    {
        
        public AddNewProjectPage()
        {
            
            InitializeComponent();
            
        }
        
        private void AddNewProjectBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                Project project = new Project()
                {
                    
                    ProjectName = NewProjectEntry.Text,
                    
                };
                using (SQLiteConnection connection = new SQLiteConnection(App.databaseLoaction))
                {
                    connection.CreateTable<Project>();
                    int rows = connection.Insert(project);
                    if (rows > 0)
                    {
                        DisplayAlert("Bevestiging", "Project is toegevoegd", "OK");
                    }
                    else
                    {
                        DisplayAlert("Fout", "Project is niet toegevoegd", "OK");
                    }
                }
                Navigation.PopAsync();
                

            }
            catch (NullReferenceException nullex)
            {
                DisplayAlert("Fout", Convert.ToString(nullex.Message), "OK");
                Console.WriteLine(nullex.Message);
            }
            catch (Exception ex)
            {
                DisplayAlert("Fout", Convert.ToString(ex.Message), "OK");
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}