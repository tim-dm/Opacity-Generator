using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGWPF.ViewModels
{
    public class WindowViewModel : BaseViewModel
    {
        private BaseViewModel _currentView;

        public string WindowTitle
        {
            get { return ""; }
        }

        public BaseViewModel CurrentView
        {
            get { return _currentView; }
            set
            {
                if (_currentView != value)
                {
                    _currentView = value;
                    OnPropertyChanged();
                }
            }
        }

        public WindowViewModel()
        {
            CurrentView = new GeneratorViewModel();
        }
    }
}
