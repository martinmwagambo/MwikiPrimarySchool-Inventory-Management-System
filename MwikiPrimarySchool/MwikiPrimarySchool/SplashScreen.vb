Public Class SplashScreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value <= 10 Then
            Label1.Text = "Initializing System"
        ElseIf ProgressBar1.Value <= 30 Then
            Label1.Text = "Loading all Components"
        ElseIf ProgressBar1.Value <= 50 Then
            Label1.Text = "Integrating Database"
        ElseIf ProgressBar1.Value <= 70 Then
            Label1.Text = "Please Wait"
        ElseIf ProgressBar1.Value <= 100 Then
            Label1.Text = "Welcome to Mwiki Primary School Inventory Management System "
            If ProgressBar1.Value = 100 Then
                Timer1.Dispose()
                Me.Hide()
                Login.Show()
            End If
        End If
    End Sub
End Class
