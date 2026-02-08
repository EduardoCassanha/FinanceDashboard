using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FinanceDashboard.ViewModels
{
    // Abstract prevents this class from being instantiated directly
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        // Helper method to safely raise the PropertyChanged event 
        protected void OnPropertyChanged([CallerMemberName] string?  propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // <T> is a generic method to update values
        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string? propertyName = null)
        {

            // if the value is the same of the last one, return false
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false; 
            }

            // if changed, update variable
            storage = value;

            OnPropertyChanged(propertyName);
            return true;
        }
    }
}