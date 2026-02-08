using System;
using System.Collections.ObjectModel;
using FinanceDashboard.Models;

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

        public ObservableCollection<Transaction> Transactions { get; set; }
        public MainViewModel()
        {
            AppName = "Finance Dashboard v1.0";
            WelcomeMessage = "Welcome to your finance dashboard.";

            Transactions = new ObservableCollection<Transaction>();

            //test data
            Transactions.Add(new Transaction { Title = "Salary", Amount = 5000, IsIncome = true });
            Transactions.Add(new Transaction { Title = "Lunch", Amount = 45.90m, IsIncome = false });
        }
    }
}