﻿Public Class Form1

    Private Sub BnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BnAdd.Click
        Dim newItem As String

        newItem = txtNewItem.Text()
        If newItem <> "" Then
            ListBox1.Items.Add(newItem)
            MsgBox(newItem & " Added to list box")
        End If
    End Sub

    Private Sub btnRemoveSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSel.Click
        Dim itemToRemove As Integer
        itemToRemove = ListBox1.SelectedIndex

        If itemToRemove = -1 Then
            MsgBox("No Item Selected")
        Else
            ListBox1.Items.RemoveAt(itemToRemove)
            MsgBox("Item removed from List Box")
        End If
    End Sub

    Private Sub btnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAll.Click
        ListBox1.Items.Clear()
        MsgBox("All items removed from list box")
    End Sub
    Private Sub btnmove_Click(sender As System.Object, e As System.EventArgs) Handles btnmove.Click
          Dim i As Integer
        For i = 0 To ListBox1.Items.Count - 1
            ListBox2.Items.Add(ListBox1.Items(i))

        Next
    Messagebox.Show("Moved all items")
End Class
