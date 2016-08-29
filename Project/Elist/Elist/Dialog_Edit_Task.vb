Imports System.Windows.Forms

Public Class Dialog_Edit_Task

    Private Sub Dialog_Edit_Task_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_Task.lstTask.SelectedItems.Clear()
    End Sub

    Private Sub Dialog_Edit_Task_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim dt As DateTime = New DateTime(Date.Now.Year, Date.Now.Month, Date.Now.Day - 1)
        'dtDueDate.MinDate = dt
        dtDueDate.BringToFront()
        txtTask.Focus()
        dtDueDateTime.Format = DateTimePickerFormat.Custom
        dtDueDateTime.CustomFormat = "h:mm tt"
        dtDueDate.Format = DateTimePickerFormat.Custom
        dtDueDate.CustomFormat = "MM-dd-yyyy"
        txtTask.Text = Form_Task.lstTask.SelectedItems(0).SubItems(1).Text
        dtDueDate.Text = Form_Task.lstTask.SelectedItems(0).SubItems(2).Text
        dtDueDateTime.Text = Form_Task.lstTask.SelectedItems(0).SubItems(2).Text
        cbStatus.Text = Form_Task.lstTask.SelectedItems(0).SubItems(3).Text
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Module_Project.EditDataTask()
        Form_Task.lstTask.SelectedItems.Clear()
        If Dialog_Open_Project.id_project <> "" Then
            Module_Project.ListTask(Dialog_Open_Project.id_project)
        Else
            Module_Project.ListTask(Dialog_New_project.txtId.Text)
        End If
        Me.Close()
    End Sub

    Private Sub txtTask_TextChanged(sender As Object, e As EventArgs) Handles txtTask.TextChanged
        If txtTask.Text <> "" Then btnSave.Enabled = True
        If txtTask.Text = "" Then btnSave.Enabled = False
    End Sub
End Class
