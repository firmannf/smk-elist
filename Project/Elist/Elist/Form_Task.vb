Public Class Form_Task

    Public id_project As String
    Private Sub Form_Task_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstTask.Clear()
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        lstTask.Columns.Add("Id", 34, HorizontalAlignment.Left)
        lstTask.Columns.Add("Task", 225, HorizontalAlignment.Left)
        lstTask.Columns.Add("Due Date", 130, HorizontalAlignment.Left)
        lstTask.Columns.Add("Done?", 54, HorizontalAlignment.Left)
        If Dialog_Open_Project.id_project <> "" Then
            Module_Project.ListTask(Dialog_Open_Project.id_project)
            id_project = Dialog_Open_Project.id_project
        Else
            id_project = Dialog_New_project.txtId.Text
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dialog_New_Task.ShowDialog()
    End Sub

    Private Sub lstTask_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTask.SelectedIndexChanged
        If lstTask.SelectedItems.Count > 0 Then
            btnEdit.Enabled = True
            btnDelete.Enabled = True
        Else
            btnEdit.Enabled = False
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Module_Project.DeleteDataTask()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dialog_Edit_Task.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Form_Main.Close()
    End Sub

    Private Sub GoToStartUpPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToStartUpPageToolStripMenuItem.Click
        Dialog_New_project.txtProjectName.Text = ""
        Dialog_New_project.txtId.Text = ""
        Dialog_Open_Project.id_project = ""
        Me.Close()
        Form_Main.Show()
    End Sub

    Private Sub DeleteThisProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteThisProjectToolStripMenuItem.Click
        Module_Project.DeleteProject()
        Me.Close()
        Form_Main.Show()
    End Sub

    Private Sub EditProjectNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProjectNameToolStripMenuItem.Click
        Dialog_Edit_Project.ShowDialog()
    End Sub
End Class