using System;

namespace FinanceDashboard.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _appName = string.Empty;
        private string _welcomeMessage = string.Empty;

        public string AppName
        {
            get { return _appName; }
            set
            {
                SetProperty(ref _appName, value);
            }
        }

        public string WelcomeMessage
        {
            get { return _welcomeMessage; }
            set
            {
                SetProperty(ref _welcomeMessage, value);
            }

        }

        public MainViewModel()
        {
            AppName = "Finance Dashboard v1.0";
            WelcomeMessage = "Welcome to your finance dashboard.";
        }
    }
}