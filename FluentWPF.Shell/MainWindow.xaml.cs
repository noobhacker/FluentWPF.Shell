using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FluentWPF.Shell
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        MainViewModel _viewModel = new();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _viewModel;

            if(_viewModel.MenuItems.Count != 0)
            {
                NavigationFrame.Navigate(_viewModel.MenuItems[0].Page);
                _viewModel.MenuItems[0].ChoosenIndicator = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var tag = ((Button)sender).Tag;

            // find item and navigate
            var selectedButton = _viewModel.MenuItems.FirstOrDefault(x => x.Name == tag);
            if (selectedButton == null)
            {
                selectedButton = _viewModel.BottomMenuItems.First(x => x.Name == tag);
            }
            NavigationFrame.Navigate(selectedButton.Page);

            // clear off main menu selected indicator
            var otherButtons = _viewModel.MenuItems.Where(x => x.Name != tag);
            foreach(var button in otherButtons)
            {
                button.ChoosenIndicator = Visibility.Hidden;
            }

            // clear off bottom menu selected indicator
            var bottomButtons = _viewModel.BottomMenuItems.Where(x => x.Name != tag);
            foreach (var button in bottomButtons)
            {
                button.ChoosenIndicator = Visibility.Hidden;
            }

            // set selected item in menu indicator
            selectedButton.ChoosenIndicator = Visibility.Visible;
        }
    }
}
