using BISFormat.Interfaces;
using BISFormat.Models;
using BISFormat.UI.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BISFormat.UI.ViewModels
{
    public class MainWindowVM : AViewModel
    {
        private string _text;
        private string _condition;
        private StringTestEnum _conditionSwitch;
        private bool _checkCaseSensitive;
        private bool _checkResult;

        public string Text
        {
            get { return _text; }
            set { _text = value; NotifyPropertyChanged(); }
        }

        public string Condition
        {
            get { return _condition; }
            set { _condition = value; NotifyPropertyChanged(); }
        }

        public StringTestEnum ConditionSwitch
        {
            get { return _conditionSwitch; }
            set { _conditionSwitch = value; NotifyPropertyChanged(); }
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

        public MainWindowVM(IStringTest stringTest)
        {

        }
    }
}
