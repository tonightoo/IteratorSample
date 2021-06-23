Module module1

    Sub main()

        Dim list1 As New List(Of Integer) From {1, 2, 3}
        Dim arr As Integer() = {1, 2, 3}

        For i As Integer = 0 To arr.Count - 1
            Debug.WriteLine(arr(i))
        Next

        For Each element In list1
            Debug.WriteLine(element)
        Next

        Dim mylist As New MyList(10)
        mylist.AppendElement("a")
        mylist.AppendElement("b")
        mylist.AppendElement("c")
        mylist.AppendElement(1)

        Dim it As IEnumerator = mylist.GetEnumerator()

        While it.MoveNext
            Debug.WriteLine(it.Current)
        End While

        For Each element In mylist
            Debug.WriteLine(element)
        Next

        Dim mylist2 As New MyList2(10)
        mylist2.AppendElement("x")
        mylist2.AppendElement("y")
        mylist2.AppendElement("z")

        For Each element In mylist2.GetEnumerable
            Debug.WriteLine(element)
        Next


    End Sub

End Module
