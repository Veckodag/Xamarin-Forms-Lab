using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace MobileCloudLab.Droid
{
    //Change the MainLauncher to true for it fo first, Theme = "@style/SplashScreen"
    [Activity(Label = "MobileCloudLab.Droid", Icon = "@drawable/icon", Theme = "@style/SplashScreen", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            //StartActivity(typeof(MainActivity));

            Intent intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }
    }
}
