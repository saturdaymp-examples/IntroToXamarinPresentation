using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SaturdayMP.TextToSpeech.ViewModels
{
    /// <summary>
    /// Base view model with property changed common methods.
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Fired when a propery on the view model is changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// When a propery if changed raise the propery changed event.
        /// </summary>
        /// <param name="properyName">The name of the property that changed.</param>
        protected void OnPropertyChanged([CallerMemberName] string properyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properyName));
        }

        /// <summary>
        /// Set a property to a new value.
        /// </summary>
        /// <returns><c>true</c>, if new and old value is not the same, <c>false</c> otherwise.</returns>
        /// <param name="storage">The old value of the property.</param>
        /// <param name="value">The new value of the property</param>
        /// <param name="propertyName">The name of the property.</param>
        /// <typeparam name="T">The type of the property.</typeparam>
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
