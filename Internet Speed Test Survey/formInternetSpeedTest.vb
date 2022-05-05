Public Class formInternetSpeedTest
    ' Program Name: Payroll Calculator
    ' Develper:     Paulette Crawford
    ' Date:         March 3rd, 2021
    ' Purpose:      This application displays the average internet speed entered by a user, 
    '               a user must enter 10 different non-negative numeric values;
    '               the values are formated to two decimal places.
    Private Sub calculateAvgInternetSpeed_Click(sender As Object, e As EventArgs) Handles enterInternetSpeedBtn.Click
        ' This code is executed when a user clicks the Enter Internet Speed button.
        ' It checks to see if the user entered a non-negative numerical value,
        ' and if invalid data is entered, then the user is notified to enter valid data.
        ' Variables are declared to calculate the average internet speed.

        Dim counter As Integer
        Dim internetSpeed, avgInternetSpeed As Double
        Dim internetUserInput As String

        ' Set counter and internetSpeed values
        counter = 0
        internetSpeed = 0

        ' Create a while loop to ask for user input and calculate internet values
        For internet As Integer = 1 To 10
            While True
                Try
                    internetUserInput = InputBox("Please enter your numeric values")
                    'Use If-Else statement to check for empty strings
                    If internetUserInput = "" Then
                        Exit For
                    End If
                    internetSpeed = Convert.ToDouble(internetUserInput)
                    If (internetSpeed < 0) Then
                        MsgBox("Negative values are not allowed. Please enter a numeric value")
                    Else
                        Exit While
                    End If
                    ' Use exception handling to display an error message box
                Catch ex As Exception
                    MsgBox("Invalid input. Please enter a numeric value")
                End Try
            End While
            counter += 1
            ' Utilize the counter variable and append the entered values 
            inputInternetSpeedListBox.Items.Add(internetSpeed)
                    avgInternetSpeed += internetSpeed
                    Next
        If (avgInternetSpeed = 0) Then
            MsgBox("No user values were entered")
        Else
            displayAvgInternetSpeedLbld.Text = displayAvgInternetSpeedLbld.Text + (avgInternetSpeed / counter).ToString("F") & " Mbps"
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles internetSpeedTestImage.Click

    End Sub

    Private Sub inputInternetSpeedListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles inputInternetSpeedListBox.SelectedIndexChanged

    End Sub

    Private Sub displayAvgInternetSpeedLbld_Click(sender As Object, e As EventArgs) Handles displayAvgInternetSpeedLbld.Click

    End Sub
End Class
