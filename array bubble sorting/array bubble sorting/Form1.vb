Public Class Form1
Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ar(5) As Integer
        Dim i, j, temp As Integer
        For i = 0 To 5
            ar(i) = InputBox("Enter element in array")
        Next
        For i = 0 To 4
            For j = i To 5
                If ar(i) > ar(j) Then
                    temp = ar(i)
                    ar(i) = ar(j)
                    ar(j) = temp
                End If
            Next
        Next
    End Sub

End Class
