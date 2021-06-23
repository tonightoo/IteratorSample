Public Class MyList2

    Private elements As Object()
    Private last As Integer = 0

    Public Sub New(ByVal maxSize As Integer)
        ReDim elements(maxSize)
    End Sub

    Public Function GetElementAt(ByVal index As Integer) As Object
        Return elements(index)
    End Function

    Public Sub AppendElement(ByVal obj As Object)
        elements(last) = obj
        last += 1
    End Sub

    Public Function GetLength() As Integer
        Return last
    End Function

    Iterator Function GetEnumerable() As IEnumerable(Of Object)
        For i = 0 To last - 1
            Yield elements(i)
        Next
    End Function

End Class
