using AVFoundation;
using SaturdayMP.TextToSpeech.Platforms;
using Xamarin.Forms;


[assembly: Dependency(typeof(SaturdayMP.TextToSpeech.iOS.Platforms.TextToSpeech))]
namespace SaturdayMP.TextToSpeech.iOS.Platforms
{
    /// <summary>
    /// Implment the iOS text to speech.
    /// </summary>
    public class TextToSpeech : ITextToSpeech
    {
        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();
            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 2,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}
