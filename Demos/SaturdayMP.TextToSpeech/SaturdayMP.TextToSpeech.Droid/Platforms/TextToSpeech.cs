using Android.Speech.Tts;
using Xamarin.Forms;

[assembly: Dependency(typeof(SaturdayMP.TextToSpeech.Droid.Platforms.TextToSpeech))]
namespace SaturdayMP.TextToSpeech.Droid.Platforms
{
    /// <summary>
    /// Implements the Driod speech to text.
    /// </summary>
    public class TextToSpeech : Java.Lang.Object, SaturdayMP.TextToSpeech.Platforms.ITextToSpeech, Android.Speech.Tts.TextToSpeech.IOnInitListener
    {
        Android.Speech.Tts.TextToSpeech speaker;
        string toSpeak;

        public void Speak(string text)
        {
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new Android.Speech.Tts.TextToSpeech(MainActivity.Instance, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }
    }
}
