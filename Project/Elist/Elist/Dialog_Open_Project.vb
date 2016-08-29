Imports System.Windows.Forms

Public Class Dialog_Open_Project
    Public id_project As String
    Public open_project As Boolean
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Dialog_Open_Project_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnOpen.Enabled = False
        lstProject.Clear()
        lstProject.Columns.Add("Id", 50, HorizontalAlignment.Left)
        lstProject.Columns.Add("Project", lstProject.Width - 50, HorizontalAlignment.Left)
        Module_Project.ListProject()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        id_project = lstProject.SelectedItems(0).SubItems(0).Text
        Me.Close()
        Form_Main.Hide()
        Form_Task.ShowDialog()
    End Sub

    Private Sub lstProject_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProject.SelectedIndexChanged
        btnOpen.Enabled = True
    End Sub
End Class