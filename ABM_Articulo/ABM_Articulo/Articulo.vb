Public Class Articulo

    Dim Codigo_ As Integer
    Public Property Codigo() As Integer
        Get
            Return Codigo_
        End Get
        Set(ByVal value As Integer)
            Codigo_ = value
        End Set
    End Property

    Dim Descripcion_ As String
    Public Property descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
        End Set
    End Property

    Dim Unidad_ As Integer
    Public Property unidad() As Integer
        Get
            Return Unidad_
        End Get
        Set(ByVal value As Integer)
            Unidad_ = value
        End Set
    End Property

    Dim Stock_ As Decimal
    Public Property stock() As Decimal
        Get
            Return Stock_
        End Get
        Set(ByVal value As Decimal)
            Stock_ = value
        End Set
    End Property

    Dim Costo_ As Decimal
    Public Property costo() As Decimal
        Get
            Return Codigo_
        End Get
        Set(ByVal value As Decimal)
            Costo_ = value
        End Set
    End Property

    Dim Iva_ As Integer
    Public Property iva() As Integer
        Get
            Return Iva_
        End Get
        Set(ByVal value As Integer)
            Iva_ = value
        End Set
    End Property

    Dim Utilidad_ As Decimal
    Public Property utilidad() As Decimal
        Get
            Return Utilidad_
        End Get
        Set(ByVal value As Decimal)
            Utilidad_ = value
        End Set
    End Property

    Dim Venta_ As Decimal
    Public ReadOnly Property venta() As Decimal
        Get
            venta = Costo_ * (1 + Iva_ / 100) * (1 + Utilidad_ / 100)
        End Get
    End Property

End Class
