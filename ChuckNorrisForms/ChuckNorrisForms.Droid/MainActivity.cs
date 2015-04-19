using Android.App;
using Android.Content.PM;
using Android.OS;
using OxyPlot.Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android;

namespace ChuckNorrisForms.Droid
{
    [Activity(Label = "ChuckNorrisForms", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Forms.Init();
            Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

