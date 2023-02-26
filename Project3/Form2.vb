Public Class Form2
    Private Sub btnClose2_Click(sender As Object, e As EventArgs) Handles btnClose2.Click
        ' This event subprocedure closes the form upon click
        Close()
    End Sub

    ' I was playing around with the "closing prompt here, but couldn't configure the reset properly to form1
    ' Was getting an error saying that "Form1 may not be accessible

    '    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '   Dim strRestart As String = "Did you want to restart the program?"
    '  If MessageBox.Show(strRestart, "Closing the Form", MessageBoxButtons.YesNo) = DialogResult.Yes Then
    '         Form1.txtItemDesc.Text = "<Enter Item Description>"
    ''Form1.txtYearPurch.Text = "<Enter Year Purchased>"
    'Form1.txtPurchAmt.Text = "<Enter Amount>"
    'Form1.txtNoYears.Text = "<Enter Number of Years>"
    'Form1.btnSLM.Checked = True
    'End If
    'End Sub
End Class