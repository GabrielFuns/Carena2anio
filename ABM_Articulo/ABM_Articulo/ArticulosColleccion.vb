Imports System.ComponentModel
Public Class ArticulosColleccion
    Inherits BindingList(Of Articulo)
    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        'MyBase.OnAddingNew(e)
        e.NewObject = New Articulo
    End Sub
End Class
