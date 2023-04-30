' Program Name:     Most Rainfall in US
' Author:           Mark Bulmer
' Date:             3/27/2022
' Purpose:          The Most Rainfall program enters the rainfall
'                   from each month in a given year. It displays each
'                   rainfall value. After all rainfall values have been entered, 
'                   it displays the average rainfall for the year.

Option Strict On
Public Class frmRainfall
    Private Sub btnRainfall_Click(sender As Object, e As EventArgs) Handles btnRainfall.Click
        ' The btnRainfall_click event accepts and displays up to 12 rainfall values
        ' and then calculates and displays the average rainfall for the year

        ' Declare and initialize variables
        Dim strRainfall As String
        Dim decRainfall As Decimal
        Dim decAverageRainfall As Decimal
        Dim decTotalRainfall As Decimal = 0D
        Dim strInputMessage As String = "Enter the rainfall for month #"
        Dim strInputHeading As String = "Rainfall"
        Dim strNormalMessage As String = "Enter the rainfall loss for month #"
        Dim strNonNumericError As String = "Error - Enter a number for the rainfall of month #"
        Dim strNegativeError As String = "Error - Enter a positive number for the rainfall of month #"

        ' Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 12
        Dim intNumberOfEntries As Integer = 1

        ' This loop allows the user to enter the rainfall of up to 12 months.
        ' The loop terminates when the user has entered 12 rainfall values or the user
        ' clicks the Cancel button or the Close button in the InputBox
        strRainfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strRainfall = strCancelClicked
            If IsNumeric(strRainfall) Then
                decRainfall = Convert.ToDecimal(strRainfall)
                If decRainfall > 0 Then
                    lstRainfall.Items.Add(decRainfall)
                    decTotalRainfall += decRainfall
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strRainfall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        ' Calculates and displays average monthly rainfall
        If intNumberOfEntries > 1 Then
            lblAverageRainfall.Visible = True
            decAverageRainfall = decTotalRainfall / (intNumberOfEntries - 1)
            lblAverageRainfall.Text = "Average rainfall is " &
                decAverageRainfall.ToString("F1") & " inches"
        Else
            MsgBox("No rainfall value entered")
        End If

        ' Disables the Rainfall button
        btnRainfall.Enabled = False
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The mnuClear click event clears the ListBox object and hides 
        ' the average rainfall label. It also enables the Rainfall button

        lstRainfall.Items.Clear()
        lblAverageRainfall.Visible = False
        btnRainfall.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' The mnuExit click event closes the window and exits the application

        Close()
    End Sub
End Class
