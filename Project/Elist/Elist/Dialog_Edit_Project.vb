Imports System.Windows.Forms

Public Class Dialog_Edit_Project


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Dialog_Open_Project.id_project <> "" Then
            Module_Project.EditProject(Dialog_Open_Project.id_project)
        Else
            Module_Project.EditProject(Dialog_New_project.txtId.Text)
        End If
        Me.Close()
    End Sub

    Private Sub Dialog_Edit_Project_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtProject.Focus()
        If Dialog_Open_Project.id_project <> "" Then
            txtProject.Text = Dialog_Open_Project.lstProject.SelectedItems(0).SubItems(1).Text
        Else
            txtProject.Text = Dialog_New_project.txtProjectName.Text
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtProject.Text = ""
        Me.Close()
    End Sub
End Class
