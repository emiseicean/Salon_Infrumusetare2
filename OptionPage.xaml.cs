using Microsoft.Maui.Controls;
using System;
namespace Salon_Infrumusetare2
{
    public partial class OptionPage : ContentPage
    {
        public OptionPage()
        {
            InitializeComponent();
        }

        // Event handler pentru butonul "Specialiști"
        private async void OnSpecialistiClicked(object sender, EventArgs e)
        {
            // Presupunem că există o pagină numită SpecialiștiPage
            await Navigation.PushAsync(new SpecialistiPage());
        }

        // Event handler pentru butonul "Servicii"
        private async void OnServiciiClicked(object sender, EventArgs e)
        {
            // Presupunem că există o pagină numită ServiciiPage
            await Navigation.PushAsync(new ServiciiPage());
        }

        // Event handler pentru butonul "Recenzii"
        private async void OnRecenziiClicked(object sender, EventArgs e)
        {
            // Presupunem că există o pagină numită RecenziiPage
            await Navigation.PushAsync(new RecenziiPage());
        }

        // Event handler pentru butonul "Clienți"
        private async void OnClientiClicked(object sender, EventArgs e)
        {
            // Presupunem că există o pagină numită CliențiPage
            await Navigation.PushAsync(new ClientiPage());
        }
    }
}