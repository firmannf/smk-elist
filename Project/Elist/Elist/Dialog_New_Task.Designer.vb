<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog_New_Task
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.dtDueDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtIdTask = New System.Windows.Forms.TextBox()
        Me.dtDueDateTime = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Task"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Due Date"
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(120, 10)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(239, 20)
        Me.txtTask.TabIndex = 2
        '
        'dtDueDate
        '
        Me.dtDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDueDate.Location = New System.Drawing.Point(200, 41)
        Me.dtDueDate.Name = "dtDueDate"
        Me.dtDueDate.Size = New System.Drawing.Size(159, 20)
        Me.dtDueDate.TabIndex = 3
        Me.dtDueDate.Value = New Date(2014, 2, 22, 0, 0, 0, 0)
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(32, 81)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(246, 29)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(284, 81)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 29)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtIdTask
        '
        Me.txtIdTask.Location = New System.Drawing.Point(41, 85)
        Me.txtIdTask.Name = "txtIdTask"
        Me.txtIdTask.Size = New System.Drawing.Size(28, 20)
        Me.txtIdTask.TabIndex = 6
        '
        'dtDueDateTime
        '
        Me.dtDueDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtDueDateTime.Location = New System.Drawing.Point(120, 41)
        Me.dtDueDateTime.Name = "dtDueDateTime"
        Me.dtDueDateTime.Size = New System.Drawing.Size(110, 20)
        Me.dtDueDateTime.TabIndex = 7
        Me.dtDueDateTime.Value = New Date(2014, 2, 28, 12, 0, 0, 0)
        '
        'Dialog_New_Task
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(381, 122)
        Me.Controls.Add(Me.dtDueDateTime)
        Me.Controls.Add(Me.txtIdTask)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtDueDate)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog_New_Task"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ELIST - New Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTask As System.Windows.Forms.TextBox
    Friend WithEvents dtDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtIdTask As System.Windows.Forms.TextBox
    Friend WithEvents dtDueDateTime As System.Windows.Forms.DateTimePicker

End Class
