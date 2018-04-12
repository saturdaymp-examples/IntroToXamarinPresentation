using Android.App;
using Android.Widget;
using Android.OS;

namespace SaturdayMP.TextToSpeech.Droid
{
    [Activity(Label = "Text to Speech Example", MainLauncher = true, Theme = "@style/MyTheme")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App());
        }
    }
}

