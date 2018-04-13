using Xamarin.Forms;

namespace SaturdayMP.TextToSpeech
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Create main page.
            MainPage = new Views.MainPage();
        }
    }
}
