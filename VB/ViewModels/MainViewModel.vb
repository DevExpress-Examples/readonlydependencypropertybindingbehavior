Imports System.Collections.ObjectModel
Imports System.Windows
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace DXSample.ViewModels

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property SelectedMenuItem As MenuItemViewModel
            Get
                Return GetProperty(Function() Me.SelectedMenuItem)
            End Get

            Set(ByVal value As MenuItemViewModel)
                SetProperty(Function() SelectedMenuItem, value)
            End Set
        End Property

        <Command>
        Public Sub Open()
            MessageBox.Show(SelectedMenuItem.Title)
        End Sub

        Public Property Menu As ObservableCollection(Of MenuItemViewModel)
            Get
                Return GetProperty(Function() Me.Menu)
            End Get

            Set(ByVal value As ObservableCollection(Of MenuItemViewModel))
                SetProperty(Function() Menu, value)
            End Set
        End Property

        Public Sub New()
            Menu = New ObservableCollection(Of MenuItemViewModel)() From {New MenuItemViewModel() With {.Title = "Root Item 1", .Items = New ObservableCollection(Of MenuItemViewModel)() From {New MenuItemViewModel() With {.Title = "Sub Item 11"}, New MenuItemViewModel() With {.Title = "Sub Item 12", .Items = New ObservableCollection(Of MenuItemViewModel)() From {New MenuItemViewModel() With {.Title = "Sub Item 121"}, New MenuItemViewModel() With {.Title = "Sub Item 122"}}}, New MenuItemViewModel() With {.Title = "Sub Item 13"}}}, New MenuItemViewModel() With {.Title = "Root Item 2", .Items = New ObservableCollection(Of MenuItemViewModel)() From {New MenuItemViewModel() With {.Title = "Sub Item 21"}, New MenuItemViewModel() With {.Title = "Sub Item 22"}, New MenuItemViewModel() With {.Title = "Sub Item 23"}}}}
        End Sub
    End Class
End Namespace
