using Android.App;
using Android.OS;

namespace SaturdayMP.TextToSpeech.Droid
{
    /// <summary>
    /// Main activity for the TextToSpeech example application.
    /// </summary>
    [Activity(Label = "Text to Speech Example", MainLauncher = true, Theme = "@style/MyTheme")]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        /// <summary>
        /// Create a new main activity and setup the Instace propery.
        /// </summary>
        public MainActivity()
        {
            Instance = this;
        }

        /// <summary>
        /// The instance of the MainActivity.  This works because Xamarin
        /// Forms only creates one MainActivity.
        /// </summary>
        /// <value>The main activity of the application.</value>
        public static MainActivity Instance { get; private set; }

        /// <summary>
        /// Setup the Xamarin forms application.
        /// </summary>
        /// <param name="savedInstanceState">lsdjfl</param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            LoadApplication(new App());
        }
    }
}

