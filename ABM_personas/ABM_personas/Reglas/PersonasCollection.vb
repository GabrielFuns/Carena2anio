Imports System.ComponentModel
Public Class PersonasCollection
    Inherits BindingList(Of PersonaClass)

    Protected Overrides Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)
        e.NewObject = New PersonaClass
    End Sub
End Class
