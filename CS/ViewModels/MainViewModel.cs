using System;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;

namespace DXSample.ViewModels {
    public class MainViewModel : ViewModelBase {
        public MenuItemViewModel SelectedMenuItem {
            get { return GetProperty(() => SelectedMenuItem); }
            set { SetProperty(() => SelectedMenuItem, value); }
        }

        public ObservableCollection<MenuItemViewModel> Menu {
            get { return GetProperty(() => Menu); }
            set { SetProperty(() => Menu, value); }
        }

        public MainViewModel() {
            Menu = new ObservableCollection<MenuItemViewModel>() {
                new MenuItemViewModel() {
                    Title = "Root Item 1",
                    Items = new ObservableCollection<MenuItemViewModel>() {
                        new MenuItemViewModel() { Title = "Sub Item 11" },
                        new MenuItemViewModel() {
                            Title = "Sub Item 12",
                            Items = new ObservableCollection<MenuItemViewModel>() {
                                new MenuItemViewModel() { Title = "Sub Item 121" },
                                new MenuItemViewModel() { Title = "Sub Item 122" },
                            }                           
                        },
                        new MenuItemViewModel() { Title = "Sub Item 13" },
                    }
                },
                new MenuItemViewModel() {
                    Title = "Root Item 2",
                    Items = new ObservableCollection<MenuItemViewModel>() {
                        new MenuItemViewModel() { Title = "Sub Item 21" },
                        new MenuItemViewModel() { Title = "Sub Item 22" },
                        new MenuItemViewModel() { Title = "Sub Item 23" },
                    }
                }

            };
        }       
    }
}