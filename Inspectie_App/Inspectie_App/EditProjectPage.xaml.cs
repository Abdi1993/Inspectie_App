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
    public partial class EditProjectPage : ContentPage
    {
        Project selectedPro;
        public EditProjectPage(Project selectedPro)
        {
            InitializeComponent();
            this.selectedPro = selectedPro;
            EditProjectEntry.Text = selectedPro.ProjectName;
        }

        private void DltSlctProjectBtn_Clicked(object sender, EventArgs e)
        {
            selectedPro.ProjectName = EditProjectEntry.Text;
            using(SQLiteConnection connection= new SQLiteConnection(App.databaseLoaction))
            {
                connection.CreateTable<Project>();
                int rows = connection.Delete(selectedPro);

                if(rows > 0)
                {
                    DisplayAlert("Bevesstiging", "Verwijderen is gelukt", "OK");
                }
                else
                {
                    DisplayAlert("Bevestiging", "Verwijderen is niet gelukt", "OK");
                }
                Navigation.PopAsync();
            }
        }

        private void EditSlctProjectBtn_Clicked(object sender, EventArgs e)
        {
            selectedPro.ProjectName = EditProjectEntry.Text;
            using(SQLiteConnection connection= new SQLiteConnection(App.databaseLoaction))
            {
                connection.CreateTable<Project>();
                int rows = connection.Update(selectedPro);

                if(rows > 0)
                {
                    DisplayAlert("Bevestiging", "De wijziging is gelukt", "OK");
                }
                else
                {
                    DisplayAlert("Besvestiging", "De wijziging is niet gelukt", "OK");
                }
            }
            Navigation.PopAsync();
        }
    }
}