Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Main event that handles data validation and calculation management
        ' following the user clicking on "Show Calculation"

        ' initializing function variables
        Dim strMethod As String
        Dim intYearPurch, intNoYears As Integer
        Dim dblPurchAmount, dblDeprcAmount As Double

        ' initializing arrays for later output
        Dim arrYear As Integer() = {}
        Dim arrValBegYear As Double() = {}
        Dim arrAmtDeprYear As Double() = {}
        Dim arrTotalDeprYear As Double() = {}

        ' data validation
        ' item description
        If txtItemDesc.Text = "" Or txtItemDesc.Text = "<Enter Item Description>" Then
            MessageBox.Show("Must enter a Description.")
            Exit Sub
        End If

        ' year purchased - two checks; first if numeric, second if in range 1900-9999 inclusive
        ' converts to integer format following checks
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

        ' purchase amount - two checks; first if numeric, second if > 0
        ' converts to double format following checks
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

        ' number of years for depreciation - two checks; first if numeric, second if between 1 and 99 inclusive
        ' converts to integer following checks
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

        ' checker for radio button option (straight-line-balance vs double-declining-balance)
        If radSLM.Checked = True Then
            strMethod = "straight-line-balance"
        Else
            strMethod = "double-declining-balance"
        End If

        ' runs calculate subprocedure with validated data points
        Calculate(strMethod,
                  intYearPurch,
                  dblPurchAmount,
                  intNoYears,
                  arrYear,
                  arrValBegYear,
                  arrAmtDeprYear,
                  arrTotalDeprYear)

        ' runs output subprocedure
        PrintOutput(strMethod,
                    arrYear,
                    arrValBegYear,
                    arrAmtDeprYear,
                    arrTotalDeprYear)

        ' show form after everything is done!
        Form2.Show()
    End Sub

    Private Sub Depr_Amount(ByVal strMethod As String,
                         ByVal intNoYears As Integer,
                         ByRef dblDeprPerc As Double)
        ' This subprocedure takes in the method of depreciation, along with a variable for
        ' the current running dollar amount, the number of years to depreciate by,
        ' and a ByRef variable that gets adjusted after the depreciation percentage is calculated

        If strMethod = "straight-line-balance" Then
            dblDeprPerc = 1 / intNoYears
        Else ' if strMethod = "double-declining-balance"
            dblDeprPerc = 2 / intNoYears
        End If
    End Sub

    Private Sub Calculate(ByVal strMethod As String,
                          ByVal intYearPurch As Integer,
                          ByVal dblPurchAmt As Double,
                          ByVal intNoYears As Integer,
                          ByRef arrYear As Integer(),
                          ByRef arrValBegYear As Double(),
                          ByRef arrAmtDeprYear As Double(),
                          ByRef arrTotalDeprYear As Double()
                          )
        ' This subprocedure takes in a number of parameters
        ' strMethod is the type of depreciation method to be calculated
        ' intYearPurch is the year that the item was purchased
        ' dblPurchAmt is the amount the item was purchased for
        ' intNoYears is the amount of years to depreciate by
        ' arrYear is an array of the years of depreciation - this gets adjusted and added to
        ' arrValBegYear is an array of the beginning values - this gets adjusted and added to
        ' arrAmtDeprYear is an array of the depr per year - this get adjusted and added to
        ' arrTotalDeprYear is an array that accumulates total depr - this gets adjusted and added to

        ' instantiating subprocedure variables
        Dim dblRunTotal As Double = dblPurchAmt
        Dim dblDeprcAmount As Double
        Dim dblDeprcTotal As Double = 0.0
        Dim intCurrentYear As Integer = intYearPurch
        Dim intYearCounter As Integer = intNoYears
        Dim dblDeprPerc As Double = 0.0

        arrYear = New Integer(intNoYears) {}
        arrValBegYear = New Double(intNoYears) {}
        arrAmtDeprYear = New Double(intNoYears) {}
        arrTotalDeprYear = New Double(intNoYears) {}

        ' in hindsight, probably could have written depr_amount as a function instead of a sub
        ' oh well
        Depr_Amount(strMethod, intNoYears, dblDeprPerc)
        dblDeprcAmount = dblDeprPerc * dblRunTotal

        ' calculating first year only
        arrYear(0) = intYearPurch
        arrValBegYear(0) = dblPurchAmt
        dblRunTotal -= dblDeprcAmount
        arrAmtDeprYear(0) = dblDeprcAmount

        dblDeprcTotal += dblDeprcAmount
        arrTotalDeprYear(0) = dblDeprcTotal

        ' calculating from the second year through the end
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

    End Sub

    Private Sub PrintOutput(ByVal strMethod As String,
                            ByVal arrYear As Integer(),
                            ByVal arrValBegYear As Double(),
                            ByVal arrAmtDeprYear As Double(),
                            ByVal arrTotalDeprYear As Double()
                            )
        ' This subprocedure organizes all the arrays into readable text format via a string, strOut
        ' strMethod is the type of depreciation calculation used
        ' arrYear is an array containing the years within the calculation
        ' arrValBegYear is an array containing the beginning value of the item with each passing year
        ' arrAmtDeprYear is an array containing the amt of depreciation per year
        ' arrTotalDeprYear is an array accumulating depreciation each year

        ' initializing number of years for a array counter
        Dim intYears As Integer = CInt(txtNoYears.Text)

        ' initializing a string object
        Dim strOut As String = ""

        ' instantiating a string array for columns
        Dim arrColumnHeaders1 = New String(3) {"Year",
            "Value at     ",
            "Amount Deprec",
            "Total Depreciation"}
        Dim arrColumnHeaders2 = New String(3) {" ", "beg of Year", "During Year", "to End of Year"}

        ' printing out the date and time
        strOut &= "Date/Time of Report" + vbTab + ": " + Now + vbCrLf + vbCrLf

        ' Descriptors
        strOut &= "Description" + vbTab + vbTab + ": " + txtItemDesc.Text + vbCrLf
        strOut &= "Year of Purchase" + vbTab + vbTab + ": " + txtYearPurch.Text + vbCrLf
        strOut &= "Cost" + vbTab + vbTab + vbTab + ": " + CDec(txtPurchAmt.Text).ToString("C2") + vbCrLf
        strOut &= "Estimated Life" + vbTab + vbTab + ": " + txtNoYears.Text + vbCrLf
        strOut &= "Method of depreciation" + vbTab + ": " + strMethod + vbCrLf

        strOut &= vbCrLf + vbCrLf

        ' adding header
        For i As Integer = 0 To 3
            strOut &= arrColumnHeaders1(i) + vbTab
        Next
        strOut &= vbCrLf

        For i As Integer = 0 To 3
            strOut &= arrColumnHeaders2(i) + vbTab
        Next
        strOut &= vbCrLf + vbCrLf

        ' Adding data points from respective arrays
        For i As Integer = 0 To intYears - 1
            strOut &= CStr(arrYear(i)) + vbTab
            strOut &= CDec(arrValBegYear(i)).ToString("C2") + vbTab
            strOut &= CDec(arrAmtDeprYear(i)).ToString("C2") + vbTab
            strOut &= CDec(arrTotalDeprYear(i)).ToString("C2") + vbCrLf
        Next

        ' Reading the strOut to the textbox in form 2
        Form2.txtBoxResult.Text = strOut

    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        ' This event subprocedure resets the text boxes and radio button to default when the button is clicked
        txtItemDesc.Text = "<Enter Item Description>"
        txtYearPurch.Text = "<Enter Year Purchased>"
        txtPurchAmt.Text = "<Enter Amount>"
        txtNoYears.Text = "<Enter Number of Years>"
        radSLM.Checked = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' This event subprocedure closes the form when the button is clicked
        Close()
    End Sub
End Class
