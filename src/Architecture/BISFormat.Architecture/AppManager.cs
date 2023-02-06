using BISFormat.Interfaces;
using BISFormat.UI.ViewModels;
using BISFormat.UI.Views;

namespace BISFormat.Architecture
{
    public class AppManager : IAppManager
    {
        private MainWindowView _mainView;
        private IStringTest _stringTest;

        public AppManager(MainWindowView mainView, IStringTest stringTest)
        {
            _mainView = mainView;
            _stringTest = stringTest;
        }

        public void StartApp()
        {
            MainWindowVM mainViewVM = new(_stringTest);
            _mainView.InitializeView(mainViewVM);
            _mainView.Show();
        }
    }
}
