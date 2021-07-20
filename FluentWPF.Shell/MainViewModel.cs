using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentWPF.Shell
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel
    {
        public string Title { get; set; }
        public ObservableCollection<MenuItemViewModel> MenuItems { get; set; }
        public ObservableCollection<MenuItemViewModel> BottomMenuItems { get; set; }

        public MainViewModel()
        {
            MenuItems = new ObservableCollection<MenuItemViewModel>();
            BottomMenuItems = new ObservableCollection<MenuItemViewModel>();

            Title = "Test FluentWPF.Shell Library";
            MenuItems.Add(new MenuItemViewModel
            {
                Name = "Test Page 1",
                Glyph = "",
                ChoosenIndicator = System.Windows.Visibility.Visible
            });
            MenuItems.Add(new MenuItemViewModel
            {
                Name = "Test Page 2",
                Glyph = ""
            });
        }
    }
}
