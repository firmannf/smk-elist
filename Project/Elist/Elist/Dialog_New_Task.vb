Imports System.Windows.Forms

Public Class Dialog_New_Task

    Private Sub Dialog_New_Task_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_Task.lstTask.SelectedItems.Clear()
    End Sub

    Private Sub Dialog_New_Task_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Module_Project.IdTask()
        txtTask.Focus()
        btnSave.Enabled = False
        txtIdTask.Hide()
        dtDueDate.BringToFront()
        dtDueDateTime.Format = DateTimePickerFormat.Custom
        dtDueDateTime.CustomFormat = "h:mm tt"
        dtDueDateTime.Value = Date.Now
        dtDueDate.Value = Date.Now
        dtDueDate.Format = DateTimePickerFormat.Custom
        dtDueDate.CustomFormat = "MM-dd-yyyy"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Module_Project.SaveDataTask()
        txtIdTask.Text = ""
        txtTask.Text = ""
        dtDueDate.Text = ""
        Me.Close()
        Form_Task.lstTask.SelectedItems.Clear()
        If Dialog_Open_Project.id_project <> "" Then
            Module_Project.ListTask(Dialog_Open_Project.id_project)
        Else
            Module_Project.ListTask(Dialog_New_project.txtId.Text)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtTask.Text = ""
        txtIdTask.Text = ""
        Form_Task.lstTask.SelectedItems.Clear()
        Me.Close()
    End Sub

    Private Sub txtTask_TextChanged(sender As Object, e As EventArgs) Handles txtTask.TextChanged
        If txtTask.Text <> "" Then btnSave.Enabled = True
        If txtTask.Text = "" Then btnSave.Enabled = False
    End Sub
End Class
