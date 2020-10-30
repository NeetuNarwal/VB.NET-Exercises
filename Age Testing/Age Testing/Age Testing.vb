Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click
        Dim age As String
        Dim msg As String

        age = Tb1.Text
        msg = Tb2.Text
        Select case age
        case <=13
            Tb2.Text = "you are a child"
        Case  <= 21 
            Tb2.Text = "you are a teenager"
        Case <= 65 
            Tb2.Text = "you are an adult"
        Case  > 65 
            Tb2.Text = "you are old"
        End Select

    End Sub
End Class
