Imports System.Windows.Forms

Public Class Dialog_New_project
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Module_Project.SaveData()
        Me.Close()
        Form_Main.Hide()
        Form_Task.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtProjectName.Text = ""
        Me.Close()
    End Sub

    Private Sub Dialog_New_project_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module_Project.IdProject()
        txtProjectName.Focus()
        btnCreate.Enabled = False
    End Sub

    Private Sub txtProjectName_TextChanged(sender As Object, e As EventArgs) Handles txtProjectName.TextChanged
        If txtProjectName.Text <> "" Then btnCreate.Enabled = True
        If txtProjectName.Text = "" Then btnCreate.Enabled = False
    End Sub

End Class
