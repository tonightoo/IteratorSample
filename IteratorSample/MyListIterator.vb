Public Class MyListIterator : Implements IEnumerator

    Private _myList As MyList
    Private _index As Integer

    Public Sub New(ByVal myList As MyList)
        Me._myList = myList
        _index = -1
    End Sub


    Public ReadOnly Property Current As Object Implements IEnumerator.Current
        Get
            Dim obj As Object = _myList.GetElementAt(_index)
            Return obj
        End Get
    End Property

    Public Sub Reset() Implements IEnumerator.Reset
        _index = -1
    End Sub

    Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
        _index += 1
        If _index < _myList.GetLength Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
