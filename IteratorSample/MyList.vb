Public Class MyList : Implements IEnumerable

    ''' <summary>
    ''' 要素の集合
    ''' </summary>
    Private _elements As Object()

    ''' <summary>
    ''' 要素数
    ''' </summary>
    Private _last As Integer = 0

    Public Sub New(ByVal maxSize As Integer)
        ReDim _elements(maxSize)
    End Sub

    ''' <summary>
    ''' indexの要素を取得する
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns></returns>
    Public Function GetElementAt(ByVal index As Integer) As Object
        Return _elements(index)
    End Function

    ''' <summary>
    ''' 要素を追加する
    ''' </summary>
    ''' <param name="obj"></param>
    Public Sub AppendElement(ByVal obj As Object)
        _elements(_last) = obj
        _last += 1
    End Sub

    ''' <summary>
    ''' 要素の数を取得する
    ''' </summary>
    ''' <returns></returns>
    Public Function GetLength() As Integer
        Return _last
    End Function

    ''' <summary>
    ''' 反復処理する列挙子を返す
    ''' </summary>
    ''' <returns></returns>
    Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Return New MyListIterator(Me)
    End Function


End Class
