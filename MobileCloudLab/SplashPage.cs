using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileCloudLab
{
    public class SplashPage : Page
    {
        async protected override void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(TimeSpan.FromSeconds(2));

            App.Current.MainPage = new FirstPage();
        }
    }
}