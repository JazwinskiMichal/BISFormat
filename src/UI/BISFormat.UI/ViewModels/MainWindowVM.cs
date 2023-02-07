using BISFormat.Interfaces;
using BISFormat.Models;
using BISFormat.UI.ViewModels.Base;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BISFormat.UI.ViewModels
{
    public class MainWindowVM : AViewModel
    {
        private IStringTest _stringTestService;

        private string _text;
        private string _condition;
        private bool _checkCaseSensitive;
        private bool _checkResult;
        private bool _showResultIndicator;
        private ObservableCollection<string> _stringTests;
        private string _selectedStringTest;

        public string Text
        {
            get { return _text; }
            set 
            { 
                _text = value;

                ShowResultIndicator = ValidateInputConditions(_text, _condition);

                NotifyPropertyChanged(); 
            }
        }

        public string Condition
        {
            get { return _condition; }
            set 
            { 
                _condition = value;

                ShowResultIndicator = ValidateInputConditions(_text, _condition);

                NotifyPropertyChanged(); 
            }
        }

        public bool CheckCaseSensitive
        {
            get { return _checkCaseSensitive; }
            set { _checkCaseSensitive = value; NotifyPropertyChanged(); }
        }

        public bool CheckResult
        {
            get { return _checkResult; }
            set { _checkResult = value; NotifyPropertyChanged(); }
        }

        public bool ShowResultIndicator
        {
            get { return _showResultIndicator; }
            set { _showResultIndicator = value; NotifyPropertyChanged(); }
        }

        public ObservableCollection<string> StringTests
        {
            get { return _stringTests; }
            set { _stringTests = value; NotifyPropertyChanged(); }
        }

        public string SelectedStringTest
        {
            get { return _selectedStringTest; }
            set { _selectedStringTest = value; NotifyPropertyChanged(); }
        }

        public ICommand CheckResultCommand { get; }   

        public MainWindowVM(IStringTest stringTest)
        {
            _stringTestService = stringTest;

            // Initialize StringTests
            StringTests = new();
            foreach (StringTestEnum test in (StringTestEnum[])Enum.GetValues(typeof(StringTestEnum)))
                StringTests.Add(test.ToString());
            SelectedStringTest = StringTests[0];

            // Initialize Commands
            CheckResultCommand = new RelayCommand(CheckResultMethod);
        }

        private bool ValidateInputConditions(string text, string condition)
        {
            return !string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(condition);
        }

        private void CheckResultMethod()
        {
           CheckResult = _stringTestService.TestString(Text,
                                                       (StringTestEnum)Enum.Parse(typeof(StringTestEnum), SelectedStringTest),
                                                       Condition, CheckCaseSensitive);
        }
    }
}
