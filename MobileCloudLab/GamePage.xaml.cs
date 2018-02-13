using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace MobileCloudLab
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        public GamePage()
        {
            InitializeComponent();

            BindingContext = new Game();
        }

        private async void GetGameBtn_Clicked(object sender, EventArgs e)
        {
            Game game = await GameManager.GameApiCall();
            game.SetBoxScore(game);
            BindingContext = game;
            getGameBtn.Text = "Search Again";
        }
    }
}
