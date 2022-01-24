Public Class Form1
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If malebtn.Checked Then
            MsgBox(nametxt.Text + " " + agetxt.Text + " " + malebtn.Text + " " + addresstxt.Text + " " + contacttxt.Text + " " + purposetxt.Text)
        ElseIf femalebtn.Checked Then
            MsgBox(nametxt.Text + " " + agetxt.Text + " " + femalebtn.Text + " " + addresstxt.Text + " " + contacttxt.Text + " " + purposetxt.Text)
        Else
            MsgBox("Error 404::!Page not found!")
        End If
    End Sub
End Class
