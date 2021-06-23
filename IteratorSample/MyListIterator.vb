Public Class MyListIterator : Implements IEnumerator

    Private _myList As MyList
    Private index As Integer

    Public Sub New(ByVal myList As MyList)
        Me._myList = myList
        index = 0
    End Sub


    Public ReadOnly Property Current As Object Implements IEnumerator.Current
        Get
            Dim obj As Object = _myList.GetElementAt(index)
            index += 1
            Return obj
        End Get
    End Property

    Public Sub Reset() Implements IEnumerator.Reset
        Throw New NotImplementedException()
    End Sub

    Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
        If index < _myList.GetLength Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
