<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dc
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
        Me.file = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'file
        '
        Me.file.AutoSize = True
        Me.file.Location = New System.Drawing.Point(13, 13)
        Me.file.Name = "file"
        Me.file.Size = New System.Drawing.Size(78, 13)
        Me.file.TabIndex = 0
        Me.file.Text = "decrypting file: "
        '
        'fname
        '
        Me.fname.AutoSize = True
        Me.fname.Location = New System.Drawing.Point(12, 36)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(23, 13)
        Me.fname.TabIndex = 1
        Me.fname.Text = "null"
        '
        'dc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 94)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.file)
        Me.Name = "dc"
        Me.Text = "dc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents file As System.Windows.Forms.Label
    Friend WithEvents fname As System.Windows.Forms.Label
End Class
