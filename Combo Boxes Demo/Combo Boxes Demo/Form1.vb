Public Class Form1

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

        Dim newItem As String

        newItem = txtNewItem.Text()

        If newItem <> "" Then
            ComboBox1.Items.Add(newItem)
            MsgBox(newItem & " Added to combobox")
        End If
    End Sub

    Private Sub BtnRemoveSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveSel.Click
        Dim itemToRemove As Integer

        itemToRemove = ComboBox1.SelectedIndex
        If itemToRemove = -1 Then
            MsgBox("No Item Selected")
        Else
            ComboBox1.Items.RemoveAt(itemToRemove)
            MsgBox("item remove from comboBox")
        End If
    End Sub

    Private Sub BtnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveAll.Click
        ComboBox1.Items.Clear()
        MsgBox("All items remove from comboBox")
    End Sub
    Private Sub btnmove_Click(sender As System.Object, e As System.EventArgs) Handles btnmove.Click
          Dim i As Integer
        For i = 0 To ComboBox1.Items.Count - 1
            ComboBox2.Items.Add(ComboBox1.Items(i))

        Next
End Class
