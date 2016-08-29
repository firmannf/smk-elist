Public Class Form_Main

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dialog_New_project.ShowDialog()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dialog_About.ShowDialog()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Dialog_Open_Project.ShowDialog()
    End Sub
End Class