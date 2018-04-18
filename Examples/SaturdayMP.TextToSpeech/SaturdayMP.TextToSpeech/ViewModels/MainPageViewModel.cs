using System;
using Xamarin.Forms;

namespace SaturdayMP.TextToSpeech.ViewModels
{
    /// <summary>
    /// Main page for text to speech.
    /// </summary>
    public class MainPageViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SaturdayMP.TextToSpeech.ViewModels.MainPageViewModel"/> class.
        /// </summary>
        public MainPageViewModel()
        {
            SayItCommand = new Command(SayIt);
        }

        /// <summary>
        /// The text that should be spoken.
        /// </summary>
        public string SayItText { 
            get { return _sayItText; } 
            set { SetProperty(ref _sayItText, value); }
        }

        /// <summary>
        /// The text that should be spoken.
        /// </summary>
        /// <remarks>
        /// Xamarin view models need to call the SetPropty method
        /// so you can't use the auto-implementd proerties.
        /// </remarks>
        private string _sayItText;


        /// <summary>
        /// The command the view calls to speak the text.
        /// </summary>
        /// <value>The say it command.</value>
        public Command SayItCommand { get; private set; }

        /// <summary>
        /// Speak the text in the SayItText property.
        /// </summary>
        private void SayIt()
        {
            // Call the underlying platform specific implementation.
            DependencyService.Get<Platforms.ITextToSpeech>().Speak(SayItText);
        }
    }
}
