Public Class Form_Splash

    Private Sub Timer1_Disposed(sender As Object, e As EventArgs) Handles Timer1.Disposed
        Form_Main.Show()
        Me.Close()
    End Sub
End Class