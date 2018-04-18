
namespace SaturdayMP.TextToSpeech.Platforms
{
    /// <summary>
    /// Interface for the platform specific text to speech
    /// implemenations.
    /// </summary>
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
