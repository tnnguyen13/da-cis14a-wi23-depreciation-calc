<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnClose2 = New System.Windows.Forms.Button()
        Me.txtBoxResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnClose2
        '
        Me.btnClose2.Location = New System.Drawing.Point(280, 614)
        Me.btnClose2.Name = "btnClose2"
        Me.btnClose2.Size = New System.Drawing.Size(201, 60)
        Me.btnClose2.TabIndex = 1
        Me.btnClose2.Text = "Close"
        Me.btnClose2.UseVisualStyleBackColor = True
        '
        'txtBoxResult
        '
        Me.txtBoxResult.Location = New System.Drawing.Point(18, 16)
        Me.txtBoxResult.Multiline = True
        Me.txtBoxResult.Name = "txtBoxResult"
        Me.txtBoxResult.ReadOnly = True
        Me.txtBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBoxResult.Size = New System.Drawing.Size(766, 569)
        Me.txtBoxResult.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 705)
        Me.Controls.Add(Me.txtBoxResult)
        Me.Controls.Add(Me.btnClose2)
        Me.Name = "Form2"
        Me.Text = "Depreciation Schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose2 As Button
    Friend WithEvents txtBoxResult As TextBox
End Class
