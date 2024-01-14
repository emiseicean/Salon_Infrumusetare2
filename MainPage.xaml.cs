namespace Salon_Infrumusetare2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnExploreazaBtnClicked(object sender, EventArgs e)
        {
            // Navighează la noua pagină cu cele patru butoane
            await Navigation.PushAsync(new OptionPage());
        }
    }

}
