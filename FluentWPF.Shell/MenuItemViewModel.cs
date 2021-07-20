using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FluentWPF.Shell
{
    [AddINotifyPropertyChangedInterface]
    public class MenuItemViewModel
    {
        public Visibility ChoosenIndicator { get; set; } = Visibility.Hidden;
        public string Name { get; set; }
        public string Glyph { get; set; }
        public object Page { get; set; }
    }
}
