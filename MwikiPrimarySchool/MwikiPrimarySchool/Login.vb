Public Class Login

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        If Txtpassword.Text = "123" Then
            Record_Navigation_Form.Show()
            Me.Hide()
        ElseIf Txtpassword.Text = "" Then
            MsgBox("Enter Password to proceed")
            Txtpassword.Focus()
        Else : MsgBox("Incorrect Password!")
        End If
        Txtpassword.Clear()
        Txtpassword.Focus()
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Dim ExitYN As System.Windows.Forms.DialogResult
        ExitYN = MsgBox("Do you really want to Logout?", MsgBoxStyle.YesNo)
        If ExitYN = MsgBoxResult.Yes Then
            Close()
        Else
        End If
    End Sub

    Private Sub LblTimeandDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblTimeandDate.Click
        LblTimeandDate.Text = "Date:" & Format(Now, "dd/MM/yyyy") & ControlChars.NewLine & "Time:" & Format(TimeOfDay)
    End Sub

    Private Sub Txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpassword.TextChanged

    End Sub
    Private Sub Txtpassword_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpassword.MouseHover
        Txtpassword.PasswordChar = ""
    End Sub
    Private Sub Txtpassword_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtpassword.MouseLeave
        Txtpassword.PasswordChar = "*"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblTimeandDate.Text = "Date:" & Format(Now, "dd/MM/yyyy") & ControlChars.NewLine & "Time:" & Format(TimeOfDay)
    End Sub
End Class