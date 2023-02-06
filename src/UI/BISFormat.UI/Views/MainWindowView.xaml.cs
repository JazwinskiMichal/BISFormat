using BISFormat.UI.ViewModels;
using System.Windows;

namespace BISFormat.UI.Views
{
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
        }

        public void InitializeView(MainWindowVM viewModel)
        {
            DataContext = viewModel;
        }
    }
}
