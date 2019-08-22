using System;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;

namespace DXSample.ViewModels {
    public class MenuItemViewModel : ViewModelBase {
        public MenuItemViewModel() {
            Items = new ObservableCollection<MenuItemViewModel>();
        }

        public string Title {
            get { return GetProperty(() => Title); }
            set { SetProperty(() => Title, value); }
        }

        public ObservableCollection<MenuItemViewModel> Items {
            get { return GetProperty(() => Items); }
            set { SetProperty(() => Items, value); }
        }
    }
}