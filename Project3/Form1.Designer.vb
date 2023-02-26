<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtLabel = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblYearPurchased = New System.Windows.Forms.Label()
        Me.lblPurchAmt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.txtYearPurch = New System.Windows.Forms.TextBox()
        Me.txtPurchAmt = New System.Windows.Forms.TextBox()
        Me.txtNoYears = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radDDM = New System.Windows.Forms.RadioButton()
        Me.radSLM = New System.Windows.Forms.RadioButton()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLabel
        '
        Me.txtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabel.Location = New System.Drawing.Point(52, 12)
        Me.txtLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLabel.Name = "txtLabel"
        Me.txtLabel.ReadOnly = True
        Me.txtLabel.Size = New System.Drawing.Size(898, 56)
        Me.txtLabel.TabIndex = 0
        Me.txtLabel.Text = "Depreciation to a Salvage Value of Zero"
        Me.txtLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(48, 106)
        Me.lblDesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(126, 25)
        Me.lblDesc.TabIndex = 1
        Me.lblDesc.Text = "Description:"
        '
        'lblYearPurchased
        '
        Me.lblYearPurchased.AutoSize = True
        Me.lblYearPurchased.Location = New System.Drawing.Point(48, 160)
        Me.lblYearPurchased.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYearPurchased.Name = "lblYearPurchased"
        Me.lblYearPurchased.Size = New System.Drawing.Size(173, 25)
        Me.lblYearPurchased.TabIndex = 2
        Me.lblYearPurchased.Text = "Year Purchased:"
        '
        'lblPurchAmt
        '
        Me.lblPurchAmt.AutoSize = True
        Me.lblPurchAmt.Location = New System.Drawing.Point(48, 204)
        Me.lblPurchAmt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPurchAmt.Name = "lblPurchAmt"
        Me.lblPurchAmt.Size = New System.Drawing.Size(188, 25)
        Me.lblPurchAmt.TabIndex = 3
        Me.lblPurchAmt.Text = "Purchase Amount:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 244)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 50)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Years to Depreciate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Over:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(360, 100)
        Me.txtItemDesc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(544, 31)
        Me.txtItemDesc.TabIndex = 5
        Me.txtItemDesc.Text = "<Enter Item Description>"
        '
        'txtYearPurch
        '
        Me.txtYearPurch.Location = New System.Drawing.Point(360, 154)
        Me.txtYearPurch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtYearPurch.Name = "txtYearPurch"
        Me.txtYearPurch.Size = New System.Drawing.Size(278, 31)
        Me.txtYearPurch.TabIndex = 6
        Me.txtYearPurch.Text = "<Enter Year Purchased>"
        '
        'txtPurchAmt
        '
        Me.txtPurchAmt.Location = New System.Drawing.Point(360, 198)
        Me.txtPurchAmt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPurchAmt.Name = "txtPurchAmt"
        Me.txtPurchAmt.Size = New System.Drawing.Size(278, 31)
        Me.txtPurchAmt.TabIndex = 7
        Me.txtPurchAmt.Text = "<Enter Amount>"
        '
        'txtNoYears
        '
        Me.txtNoYears.Location = New System.Drawing.Point(360, 244)
        Me.txtNoYears.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoYears.Name = "txtNoYears"
        Me.txtNoYears.Size = New System.Drawing.Size(278, 31)
        Me.txtNoYears.TabIndex = 8
        Me.txtNoYears.Text = "<Enter Number of Years>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDDM)
        Me.GroupBox1.Controls.Add(Me.radSLM)
        Me.GroupBox1.Location = New System.Drawing.Point(244, 377)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(464, 183)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Depreciation Method"
        '
        'radDDM
        '
        Me.radDDM.AutoSize = True
        Me.radDDM.Location = New System.Drawing.Point(56, 90)
        Me.radDDM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radDDM.Name = "radDDM"
        Me.radDDM.Size = New System.Drawing.Size(332, 29)
        Me.radDDM.TabIndex = 1
        Me.radDDM.Text = "Double-declining Method (2/n)"
        Me.radDDM.UseVisualStyleBackColor = True
        '
        'radSLM
        '
        Me.radSLM.AutoSize = True
        Me.radSLM.Checked = True
        Me.radSLM.Location = New System.Drawing.Point(56, 44)
        Me.radSLM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radSLM.Name = "radSLM"
        Me.radSLM.Size = New System.Drawing.Size(286, 29)
        Me.radSLM.TabIndex = 0
        Me.radSLM.TabStop = True
        Me.radSLM.Text = "Straight-line Method (1/n)"
        Me.radSLM.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(52, 619)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(260, 73)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Show Calculation"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(372, 619)
        Me.btnRestart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(260, 73)
        Me.btnRestart.TabIndex = 10
        Me.btnRestart.Text = "ReStart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(688, 619)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(260, 73)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 775)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNoYears)
        Me.Controls.Add(Me.txtPurchAmt)
        Me.Controls.Add(Me.txtYearPurch)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPurchAmt)
        Me.Controls.Add(Me.lblYearPurchased)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.txtLabel)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMain"
        Me.Text = "Project3: Depreciation to a Salvage Value of Zero"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLabel As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblYearPurchased As Label
    Friend WithEvents lblPurchAmt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtItemDesc As TextBox
    Friend WithEvents txtYearPurch As TextBox
    Friend WithEvents txtPurchAmt As TextBox
    Friend WithEvents txtNoYears As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radDDM As RadioButton
    Friend WithEvents radSLM As RadioButton
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents btnClose As Button
End Class
