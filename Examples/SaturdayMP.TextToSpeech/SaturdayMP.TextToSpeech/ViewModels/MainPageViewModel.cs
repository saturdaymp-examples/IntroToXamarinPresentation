using System;
using Xamarin.Forms;

namespace SaturdayMP.TextToSpeech.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            SayItCommand = new Command(SayIt);
        }

        // Hold the text to say.
        public string SayItText { 
            get { return _sayItText; } 
            set { SetProperty(ref _sayItText, value); }
        }
        private string _sayItText;


        // SayIt command and implementation.
        public Command SayItCommand { get; private set; }

        private void SayIt()
        {
            Console.WriteLine($"Will say {SayItText}.");
        }
    }
}
