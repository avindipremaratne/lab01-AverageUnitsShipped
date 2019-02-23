'Program:       AverageUnitsShipped

'Author:        Avindi Premaratne
'Date:          January 24th 2019  
'Description:   A program which calculates the average units shipped per week by taking the input for each day in the week
''              and calculate and display the average to the user.


Option Strict On
Imports System.Text.RegularExpressions

Public Class MainForm
    Dim userInput As Integer                'stores the user input
    Dim days(6) As Integer                  'declaring the array to store the units per week
    Const arrayLength As Integer = 7        'stores the array length
    Dim totalUnits As Integer               'stores the total of all the units per week
    Dim count As Integer = 1                'stores the counter value
    Dim minNumber As Integer = 0            'stores the minimum number of the values for validation
    Dim maxNumber As Integer = 1000         'stores the maximum number of the values for validation
    Dim averageUnits As Double              'stores the average of the units per week


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub
    Private Sub lblDays_Click_1(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Displays the current day
        lbDays.Text = "Day " & count
        Me.Show()
    End Sub


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click, lbDays.Click
        'Accept the input and check whether the value is numeric
        If Integer.TryParse(tbInput.Text, userInput) Then

            'Checks whether the input is within the range 
            If (userInput >= minNumber) And (userInput <= maxNumber) Then

                'Assign the value to the array based on the counter value
                days(count - 1) = userInput

                'Display the value in the output texbox and goes to the next line
                tbDisplay.Text += days(count - 1) & vbCrLf

                'Checks whether the counter is equal to 7 to calculate the total and avarage
                If count = 7 Then

                    'Disables Enter button and Input textbox
                    btnEnter.Enabled = False
                    tbInput.Enabled = False

                    'Calculats the total units using For loop
                    For count1 = 1 To arrayLength
                        totalUnits += days(count1 - 1)
                    Next

                    'Calculate the average,converts it double and store it in averageUnits varialble
                    averageUnits = CDbl(totalUnits / arrayLength)

                    'Displays the average to two decimal places in the lblDisplayAverage label 
                    lbDisplayAverage.Text = "Avearge per day: " + Math.Round(averageUnits, 2).ToString
                End If

                'Clears the input textbox,set forcus on it and add one value to array index
                tbInput.Clear()
                tbInput.Focus()
                count = count + 1

                'Displays an error message if the input is less than 0 and greater than 1000
            Else
                MessageBox.Show("The value must be between 0 and 1000. Please try again.")

                'Clears the textbox
                tbInput.Clear()

            End If

            'Displays an error message if the input is not numeric
        Else
            MessageBox.Show("The value must be a whole number. Please try again.")

            'Clears the textbox
            tbInput.Clear()
        End If




    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            tbInput.Clear()
            tbDisplay.Clear()
            lbDisplayAverage.Text = ""
            lbDays.Text = "Day 1"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits the program
        Application.Exit()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        'Resets all the components when Escape key is pressed
        If e.KeyCode = Keys.Escape Then
            tbInput.Clear()
            tbDisplay.Clear()
            lbDisplayAverage.Text = ""
            lbDays.Text = "Day 1"
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clears all the textboxes, enables all the buttons and other components
        tbInput.Enabled = True
        tbDisplay.Clear()
        lbDisplayAverage.Text = ""
        lbDays.Text = "Day 1"
        btnEnter.Enabled = True
        ReDim days(7)
    End Sub
End Class
