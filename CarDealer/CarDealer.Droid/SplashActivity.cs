
using Android.Content;

namespace CarDealer.Droid
{

    using Android.App;
    using Android.OS;

    [Activity(Label = "CarDealer", Icon = "@drawable/icon", Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
    }
}