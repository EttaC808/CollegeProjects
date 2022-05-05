Option Strict On
Public Class mostRainfallUSAForm
    Private Sub enterRainfall_Clicked(sender As Object, e As EventArgs) Handles rainfallBtn.Click
        ' This Event Handler is executed when the user clicks the Enter Rainfall button.
        ' It displays the average rainfall based on the values entered by a user.
        ' If a user inputs less than 12 rainfall values, the average of those values are computed .
        ' Program Name: Most Rainfall in the USA
        ' Develper:     Paulette Crawford
        ' Date:         March 9th, 2021
        ' Purpose:      This application displays the average rainfall for the island of Kaua'i, Hawai'i, 
        '               a user can input 12 up to monthly values for the rainfall;
        '               the values are formated to one decimal place.

        ' Declare and initialize variables
        Dim strRainfall As String
        Dim decRainfall As Decimal
        Dim decAverageRainfall As Decimal
        Dim decTotalRainfall As Decimal = 0D

        Dim strInputMsg As String = "Enter up to 12 values for the rainfall #"
        Dim strInputHeading As String = "Rainfall #"
        Dim strNormalMsg As String = "Enter up to 12 values for the rainfall #"
        Dim strNonNumericError As String = "Invalid input - Enter a numeric value for the rainfall #"
        Dim strNegativeValueError As String = "Invalid input - Enter a positive value for the rainfall #"

        ' Declare and initiate loop variables
        Dim cancelButtonClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 12
        Dim intNumberOfEntries As Integer = 1

        ' Create a Do-Loop that allows the uder to enter up to 12 values for the rainfall.
        ' The loop ends once a user has entered 12 values for the rainfall, 
        ' or clicks the Cancel or the Close button in the InputBox.
        strRainfall = InputBox(strInputMsg & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strRainfall = cancelButtonClicked
            ' Confirm that the user inputs a number
            If IsNumeric(strRainfall) Then
                ' Convert the string to a decimal
                decRainfall = Convert.ToDecimal(strRainfall)
                ' Confirm the user enters a positive value
                If decRainfall > 0 Then
                    ' Perform the calculations when a valid numeric entry is input for the rainfall
                    rainfallListBox.Items.Add(decRainfall)
                    decTotalRainfall += decRainfall
                    intNumberOfEntries += 1
                    strInputMsg = strNormalMsg
                Else
                    strInputMsg = strNegativeValueError
                End If
            Else
                strInputMsg = strNonNumericError
            End If
            ' Create code for the InputBox
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strRainfall = InputBox(strInputMsg & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop
        ' Write code that calculates the average rainfall
        If intNumberOfEntries > 1 Then
            avgRainfallEstimateLbl.Visible = True
            decAverageRainfall = decTotalRainfall / (intNumberOfEntries - 1)
            avgRainfallEstimateLbl.Text = "Average Rainfall per Month is " &
                decAverageRainfall.ToString("F1") & " Inches"
        Else
            MsgBox("No rainfall values were entered")
        End If
        ' Disable the Enter Rainfall button
        rainfallBtn.Enabled = False
    End Sub

    Private Sub menuClear_Clicked(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' This Event Handler is executed when a user clicks the Clear button
        ' It enables the Enter Rainfall button, hides the average rainfall label
        ' and clears the ListBox
        rainfallListBox.Items.Clear()
        avgRainfallEstimateLbl.Visible = False
        rainfallBtn.Enabled = True
    End Sub

    Private Sub mnExit_Clicked(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' This Event Handler is executed when the Exit button is clicked
        ' It exits the program

        Close()
    End Sub
End Class