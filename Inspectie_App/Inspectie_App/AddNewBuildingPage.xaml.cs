using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inspectie_App.Model;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inspectie_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewBuildingPage : ContentPage
    {
        public AddNewBuildingPage()
        {
            InitializeComponent();
        }

        private void AddNewBuildingBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                Building building = new Building()
                {
                    BuildingName = NewBuildingEntry.Text
                };
                using (SQLiteConnection connection = new SQLiteConnection(App.databaseLoaction))
                {
                    connection.CreateTable<Building>();
                    int rows = connection.Insert(building);

                    if (rows > 0)
                    {
                        DisplayAlert("Bevestigen", "Toevoegen is gelukt", "OK");
                    }
                    else
                    {
                        DisplayAlert("Bevestigen", "Toevoegen is niet gelukt", "OK");
                    }
                }
                Navigation.PopAsync();
            }
            catch(NullReferenceException nullex)
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