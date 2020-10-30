Public Class Form1

    Private Sub bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bn1.Click

        'Variable Declarations
        Dim FirstName As String
        Dim SecondName As String

        FirstName = Tb1.Text
        SecondName = Tb2.Text
        If FirstName <> "" then
            Tb3.Text="Hello Mr/Ms." & FirstName
            if SecondName <> "" then
                Tb3.Text = " Hello, " & FirstName + " " & SecondName
            End If
        End if

    End Sub
End Class
