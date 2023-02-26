Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim strMethod As String
        Dim intYearPurch, intNoYears As Integer
        Dim dblPurchAmount, dblDeprcAmount As Double
        Dim arrYear As Integer() = {}
        Dim arrValBegYear As Double() = {}
        Dim arrAmtDeprYear As Double() = {}
        Dim arrTotalDeprYear As Double() = {}

        If txtItemDesc.Text = "" Or txtItemDesc.Text = "<Enter Item Description>" Then
            MessageBox.Show("Must enter a Description.")
            Exit Sub
        End If

        If IsNumeric(txtYearPurch.Text) = False Then
            MessageBox.Show("Year Purchased is Not Numeric")
            Exit Sub
        Else
            If CInt(txtYearPurch.Text) < 1900 Or CInt(txtYearPurch.Text) > 9999 Then
                MessageBox.Show("Year Purchased is not between 1900 and 9999")
                Exit Sub
            Else
                intYearPurch = CInt(txtYearPurch.Text)
            End If
        End If

        If IsNumeric(txtPurchAmt.Text) = False Then
            MessageBox.Show("Purchase Amount is not numeric.")
            Exit Sub
        Else
            If CDbl(txtPurchAmt.Text) = 0 Then
                MessageBox.Show("Purchase Amount must be > zero.")
                Exit Sub
            Else
                dblPurchAmount = CDbl(txtPurchAmt.Text)
            End If
        End If

        If IsNumeric(txtNoYears.Text) = False Then
            MessageBox.Show("Years to Depreciate is not numeric.")
            Exit Sub
        Else
            If CInt(txtNoYears.Text) < 1 Or CInt(txtNoYears.Text) > 999 Then
                MessageBox.Show("Number of Years must be between 1 and 999.")
                Exit Sub
            Else
                intNoYears = CInt(txtNoYears.Text)
            End If
        End If

        If btnSLM.Checked = True Then
            strMethod = "straight-line-balance"
        Else
            strMethod = "double-declining-balance"
        End If
        Calculate(strMethod, intYearPurch, dblPurchAmount,
                      intNoYears, dblDeprcAmount, arrYear,
                      arrValBegYear, arrAmtDeprYear, arrTotalDeprYear)
        PrintOutput(strMethod,
                    arrYear,
                    arrValBegYear,
                    arrAmtDeprYear,
                    arrTotalDeprYear)
        Form2.Show()
    End Sub

    Function Depr_Amount(ByVal strMethod As String,
                         ByVal dblPurchAmt As Double,
                         ByVal intNoYears As Integer,
                         ByRef dblDeprPerc As Double)
        If strMethod = "straight-line-balance" Then
            dblDeprPerc = 1 / intNoYears
        Else ' if strMethod = "double-declining-balance"
            dblDeprPerc = 2 / intNoYears
        End If
    End Function

    Function Calculate(ByVal strMethod As String,
                      ByVal intYearPurch As Integer, ByVal dblPurchAmt As Double,
                       ByVal intNoYears As Integer, ByVal dblDeprcAmount As Double,
                       ByRef arrYear As Integer(),
                       ByRef arrValBegYear As Double(),
                       ByRef arrAmtDeprYear As Double(),
                       ByRef arrTotalDeprYear As Double())
        Dim dblRunTotal As Double = dblPurchAmt
        Dim dblDeprcTotal As Double = 0.0
        Dim intCurrentYear As Integer = intYearPurch
        Dim intYearCounter As Integer = intNoYears
        Dim dblDeprPerc As Double = 0.0

        arrYear = New Integer(intNoYears) {}
        arrValBegYear = New Double(intNoYears) {}
        arrAmtDeprYear = New Double(intNoYears) {}
        arrTotalDeprYear = New Double(intNoYears) {}

        Depr_Amount(strMethod, dblPurchAmt, intNoYears, dblDeprPerc)
        dblDeprcAmount = dblDeprPerc * dblRunTotal
        ' calculating first year only
        arrYear(0) = intYearPurch
        arrValBegYear(0) = dblPurchAmt
        dblRunTotal -= dblDeprcAmount
        arrAmtDeprYear(0) = dblDeprcAmount

        dblDeprcTotal += dblDeprcAmount
        arrTotalDeprYear(0) = dblDeprcTotal

        For i As Integer = 1 To intNoYears
            ' setting the year
            intCurrentYear += 1
            arrYear(i) = intCurrentYear

            ' setting value at the beginning of the year
            arrValBegYear(i) = dblRunTotal

            ' recalculate depreciation amount accordingly if a double-declining-balance
            If strMethod = "double-declining-balance" Then
                intYearCounter -= 1
                dblDeprcAmount = dblDeprPerc * dblRunTotal
                If intYearCounter = 1 Then
                    dblDeprcAmount = arrValBegYear(i)
                End If
            End If

            dblRunTotal -= dblDeprcAmount

            ' setting amount of depreciation for the year
            arrAmtDeprYear(i) = dblDeprcAmount

            ' setting year end total depreciation
            dblDeprcTotal += dblDeprcAmount
            arrTotalDeprYear(i) = dblDeprcTotal
        Next
        Return 0
    End Function

    Function PrintOutput(ByVal strMethod As String,
                        ByRef arrYear As Integer(),
                         ByVal arrValBegYear As Double(),
                         ByVal arrAmtDeprYear As Double(),
                         ByVal arrTotalDeprYear As Double())

        ' initializing number of years for a array counter
        Dim intYears As Integer = CInt(txtNoYears.Text)

        ' initializing a string object
        Dim result As String = ""

        ' instantiating a string array for columns
        Dim arrColumnHeaders1 = New String(3) {"Year",
            "Value at     ",
            "Amount Deprec",
            "Total Depreciation"}
        Dim arrColumnHeaders2 = New String(3) {" ", "beg of Year", "During Year", "to End of Year"}

        ' printing out the date and time
        result &= "Date/Time of Report" + vbTab + ": " + Now + vbCrLf + vbCrLf

        ' Descriptors
        result &= "Description" + vbTab + vbTab + ": " + txtItemDesc.Text + vbCrLf
        result &= "Year of Purchase" + vbTab + vbTab + ": " + txtYearPurch.Text + vbCrLf
        result &= "Cost" + vbTab + vbTab + vbTab + ": " + CDec(txtPurchAmt.Text).ToString("C2") + vbCrLf
        result &= "Estimated Life" + vbTab + vbTab + ": " + txtNoYears.Text + vbCrLf
        result &= "Method of depreciation" + vbTab + ": " + strMethod + vbCrLf

        result &= vbCrLf + vbCrLf

        For i As Integer = 0 To 3
            result &= arrColumnHeaders1(i) + vbTab
        Next
        result &= vbCrLf

        For i As Integer = 0 To 3
            result &= arrColumnHeaders2(i) + vbTab
        Next
        result &= vbCrLf + vbCrLf

        For i As Integer = 0 To intYears - 1
            result &= CStr(arrYear(i)) + vbTab
            result &= CDec(arrValBegYear(i)).ToString("C2") + vbTab
            result &= CDec(arrAmtDeprYear(i)).ToString("C2") + vbTab
            result &= CDec(arrTotalDeprYear(i)).ToString("C2") + vbCrLf
        Next

        Form2.txtBoxResult.Text = result


    End Function

End Class
