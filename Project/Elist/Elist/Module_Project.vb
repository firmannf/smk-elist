Imports System.Data
Imports System.Data.SqlClient
Module Module_Project
#Region "Declaration"
    Private sql As String
#End Region
#Region "Operation"
    Sub ListProject()
        dbConnection()
        Dim cmd As New SqlClient.SqlCommand
        Dim dtReader As SqlClient.SqlDataReader
        Dim item(2) As String
        Dim lstItem As ListViewItem
        Try
            Dialog_Open_Project.lstProject.Items.Clear()
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT * FROM project"
            dtReader = cmd.ExecuteReader
            If (dtReader.HasRows) Then
                Do While dtReader.Read()
                    item(0) = dtReader.Item("id_project")
                    item(1) = dtReader.Item("name_project")
                    lstItem = New ListViewItem(item)
                    Dialog_Open_Project.lstProject.Items.Add(lstItem)
                Loop
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error List Project")
        End Try
    End Sub
    Sub ListTask(ByVal id As String)
        dbConnection()
        Dim cmd As New SqlClient.SqlCommand
        Dim dtReader As SqlClient.SqlDataReader
        Dim item(3), status As String
        Dim lstItem As ListViewItem
        Try
            Form_Task.lstTask.Items.Clear()
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT project.name_project,task.id_task,task.id_project,task.name_task,task.due_date,task.status FROM project INNER JOIN task on project.id_project = task.id_project AND project.id_project = '" & id & "' ORDER BY task.due_date ASC"
            dtReader = cmd.ExecuteReader
            If (dtReader.HasRows) Then
                Do While dtReader.Read()
                    item(0) = dtReader.Item("id_task")
                    item(1) = dtReader.Item("name_task")
                    item(2) = dtReader.Item("due_date")
                    status = dtReader.Item("status")
                    If (CInt(status) = 0) Then
                        item(3) = "Undone"
                    Else
                        item(3) = "Done"
                    End If
                    lstItem = New ListViewItem(item)
                    Form_Task.lstTask.Items.Add(lstItem)
                    If (CInt(status) = 1) Then
                        lstItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    End If
                Loop
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error List Task")
        End Try
    End Sub
    Sub IdProject()
        dbConnection()
        Dim cmd As New SqlClient.SqlCommand
        Dim dtReader As SqlClient.SqlDataReader
        Dim id_project As String = Nothing
        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT TOP 1 id_project FROM project ORDER BY id_project DESC"
            dtReader = cmd.ExecuteReader
            If (dtReader.Read()) Then
                id_project = CInt(CStr(dtReader.GetValue(0))) + 1
                Dialog_New_project.txtId.Text = CStr(id_project)
            Else
                'MsgBox("Database is empty!", MsgBoxStyle.OkOnly, "Error")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Get Id Project")
        End Try
    End Sub
    Sub IdTask()
        dbConnection()
        Dim cmd As New SqlClient.SqlCommand
        Dim dtReader As SqlClient.SqlDataReader
        Dim id_task As String = Nothing
        Try
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "SELECT TOP 1 id_task FROM task ORDER BY id_task DESC"
            dtReader = cmd.ExecuteReader
            If (dtReader.Read()) Then
                id_task = CInt(CStr(dtReader.GetValue(0))) + 1
                Dialog_New_Task.txtIdTask.Text = CStr(id_task)
            Else
                'MsgBox("Database is empty!", MsgBoxStyle.OkOnly, "Error")
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Get Id Task")
        End Try
    End Sub
    Sub SaveData()
        With Dialog_New_project
            Try
                dbConnection()
                If .txtProjectName.Text = "" Then MsgBox("Project Name Must be filled!", MsgBoxStyle.Critical, "Error") : Exit Sub
                sql = "INSERT INTO project VALUES('" & .txtId.Text & "','" & .txtProjectName.Text & "')"
                cmd = New SqlClient.SqlCommand(sql)
                cmd.Connection = conn
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("'" & .txtProjectName.Text & "' Created!", MsgBoxStyle.Information, "Success")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error When Saving")
            End Try
        End With
    End Sub
    Sub SaveDataTask()
        With Dialog_New_Task
            Try
                dbConnection()
                If .txtTask.Text = "" Then MsgBox("Task Name Must be filled!", MsgBoxStyle.Critical, "Error") : Exit Sub
                sql = "INSERT INTO task VALUES('" & .txtIdTask.Text & "','" & Form_Task.id_project & "','" & .txtTask.Text & "','" & .dtDueDate.Text & " " & .dtDueDateTime.Text & "','0')"
                cmd = New SqlClient.SqlCommand(sql)
                cmd.Connection = conn
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("'" & .txtTask.Text & "' Created!", MsgBoxStyle.Information, "Success")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error When Saving")
            End Try
        End With
    End Sub
    Sub DeleteDataTask()
        With Form_Task
            Try
                dbConnection()
                Dim delete_task As Integer
                delete_task = MsgBox("Are you sure want to delete '" & .lstTask.SelectedItems(0).SubItems(1).Text & "' ?", MsgBoxStyle.OkCancel, "Are you sure?")
                Select Case delete_task
                    Case vbCancel
                        Exit Sub
                    Case vbOK
                        sql = "DELETE FROM task WHERE id_task = '" & .lstTask.SelectedItems(0).SubItems(0).Text & "'"
                        cmd = New SqlClient.SqlCommand(sql)
                        cmd.Connection = conn
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        conn.Close()
                        MsgBox("" & .lstTask.SelectedItems(0).SubItems(1).Text & " Deleted!", MsgBoxStyle.Information, "Success")
                        .lstTask.Items.RemoveAt(.lstTask.SelectedIndices(0))
                End Select
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error When Deleting")
            End Try
        End With
    End Sub
    Sub DeleteProject()
        With Form_Task
            Try
                dbConnection()
                Dim delete_task As Integer
                delete_task = MsgBox("Are you sure want to delete this project?", MsgBoxStyle.OkCancel, "Are you sure?")
                Select Case delete_task
                    Case vbCancel
                        Exit Sub
                    Case vbOK
                        sql = "DELETE FROM project WHERE id_project = '" & Form_Task.id_project & "'"
                        cmd = New SqlClient.SqlCommand(sql)
                        cmd.Connection = conn
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        conn.Close()
                        sql = "DELETE FROM task WHERE id_project = '" & Form_Task.id_project & "'"
                        cmd = New SqlClient.SqlCommand(sql)
                        cmd.Connection = conn
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        conn.Close()
                End Select
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error When Deleting")
            End Try
        End With
    End Sub
    Sub EditDataTask()
        With Dialog_Edit_Task
            Try
                Dim status As Integer
                If .cbStatus.Text = "Undone" Then
                    status = 0
                Else
                    status = 1
                End If
                If .txtTask.Text = "" Then MsgBox("Task Name Must be filled!", MsgBoxStyle.Critical, "Error") : Exit Sub
                sql = "UPDATE TASK set name_task = '" & .txtTask.Text & "',due_date = '" & .dtDueDate.Text & " " & .dtDueDateTime.Text & "',status = '" & status & "' WHERE id_task ='" & Form_Task.lstTask.SelectedItems(0).Text & "'"
                cmd = New SqlClient.SqlCommand(sql)
                cmd.Connection = conn
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Updated!", MsgBoxStyle.Information, "Success")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error When Updating")
            End Try
        End With
    End Sub
    Sub EditProject(ByVal id As String)
        With Dialog_Edit_Project
            Try
                If .txtProject.Text = "" Then MsgBox("Project Name Must be filled!", MsgBoxStyle.Critical, "Error") : Exit Sub
                sql = "UPDATE Project set name_project = '" & .txtProject.Text & "' WHERE id_project ='" & id & "'"
                cmd = New SqlClient.SqlCommand(sql)
                cmd.Connection = conn
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Updated!", MsgBoxStyle.Information, "Success")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Error When Updating")
            End Try
        End With
    End Sub
#End Region
End Module
