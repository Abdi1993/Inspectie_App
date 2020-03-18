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
    public partial class AddNewAreaPage : ContentPage
    {
        public AddNewAreaPage()
        {
            InitializeComponent();
        }

        private void AddNewAreaBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                Area area = new Area()
                {
                    AreaName = NewAreaEntry.Text
                    
                };
                using (SQLiteConnection connection = new SQLiteConnection(App.databaseLoaction))
                {
                    connection.CreateTable<Area>();
                    int rows = connection.Insert(area);
                    if (rows > 0)
                    {
                        DisplayAlert("Bevestiging", "Toevoegen is gelukt", "OK");
                    }
                    else
                    {
                        DisplayAlert("Bevestiging", "Toevoegen is niet gelukt", "OK");
                    }
                }
                Navigation.PopAsync();
            }
            catch(NullReferenceException nullex)
            {
                DisplayAlert("Fout", Convert.ToString(nullex.Message), "OK");
                Console.WriteLine(nullex.Message);
            }
            catch(Exception ex)
            {
                DisplayAlert("Fout", Convert.ToString(ex.Message), "OK");
                Console.WriteLine(ex.Message);
            }
        }

        private void AddNewAreaBtn_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}