Public Class MyList2

    Private _elements As Object()
    Private _last As Integer = 0

    Public Sub New(ByVal maxSize As Integer)
        ReDim _elements(maxSize)
    End Sub

    Public Function GetElementAt(ByVal index As Integer) As Object
        Return _elements(index)
    End Function

    Public Sub AppendElement(ByVal obj As Object)
        _elements(_last) = obj
        _last += 1
    End Sub

    Public Function GetLength() As Integer
        Return _last
    End Function

    Iterator Function GetEnumerable() As IEnumerable(Of Object)
        For i = 0 To _last - 1
            Yield _elements(i)
        Next
    End Function

    Iterator Function a() As IEnumerable
        Yield 6
        Yield 1
        Yield 5
    End Function

End Class
