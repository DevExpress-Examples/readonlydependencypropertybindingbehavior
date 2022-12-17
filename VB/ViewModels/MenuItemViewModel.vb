Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm

Namespace DXSample.ViewModels

    Public Class MenuItemViewModel
        Inherits ViewModelBase

        Public Sub New()
            Items = New ObservableCollection(Of MenuItemViewModel)()
        End Sub

        Public Property Title As String
            Get
                Return GetProperty(Function() Me.Title)
            End Get

            Set(ByVal value As String)
                SetProperty(Function() Title, value)
            End Set
        End Property

        Public Property Items As ObservableCollection(Of MenuItemViewModel)
            Get
                Return GetProperty(Function() Me.Items)
            End Get

            Set(ByVal value As ObservableCollection(Of MenuItemViewModel))
                SetProperty(Function() Items, value)
            End Set
        End Property
    End Class
End Namespace
