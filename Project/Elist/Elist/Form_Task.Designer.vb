<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Task
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
        Me.lstTask = New System.Windows.Forms.ListView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProjectNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteThisProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToStartUpPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstTask
        '
        Me.lstTask.FullRowSelect = True
        Me.lstTask.Location = New System.Drawing.Point(12, 80)
        Me.lstTask.MultiSelect = False
        Me.lstTask.Name = "lstTask"
        Me.lstTask.Size = New System.Drawing.Size(469, 269)
        Me.lstTask.TabIndex = 0
        Me.lstTask.UseCompatibleStateImageBehavior = False
        Me.lstTask.View = System.Windows.Forms.View.Details
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 37)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(69, 37)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add Task"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(219, 37)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(128, 37)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "Edit Selected Task"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(353, 37)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 37)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete Selected Task"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(493, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProjectNameToolStripMenuItem, Me.DeleteThisProjectToolStripMenuItem, Me.GoToStartUpPageToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'EditProjectNameToolStripMenuItem
        '
        Me.EditProjectNameToolStripMenuItem.Name = "EditProjectNameToolStripMenuItem"
        Me.EditProjectNameToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EditProjectNameToolStripMenuItem.Text = "Edit project name"
        '
        'DeleteThisProjectToolStripMenuItem
        '
        Me.DeleteThisProjectToolStripMenuItem.Name = "DeleteThisProjectToolStripMenuItem"
        Me.DeleteThisProjectToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DeleteThisProjectToolStripMenuItem.Text = "Delete this project"
        '
        'GoToStartUpPageToolStripMenuItem
        '
        Me.GoToStartUpPageToolStripMenuItem.Name = "GoToStartUpPageToolStripMenuItem"
        Me.GoToStartUpPageToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.GoToStartUpPageToolStripMenuItem.Text = "Go to startup page"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form_Task
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 361)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstTask)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form_Task"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ELIST - Your Task"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTask As System.Windows.Forms.ListView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteThisProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToStartUpPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditProjectNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
