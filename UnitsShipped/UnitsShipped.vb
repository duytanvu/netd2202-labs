'Author: Duy Tan Vu
'Date: January 21, 2019
'Program name: Average Units Shipped
'Description: Takes input of user and then validate whether it is numeric or not,
'              and it must be in a range between 0 and 5000. After that calculate 
'              and display the average units shipped per day (after 7 days).

Option Strict On

Public Class frmAverageUnitsShipped

    ' Declare global variables
    Dim totalValue As Integer = 0
    Dim averageUnits As Double
    Dim total(6) As Integer ' An array to store 7 numbers
    Dim i As Integer = 0    'This is the index number of array Total
    Dim day As Integer = 1

    ''' <summary>
    ''' When the form is loaded, the input textbox is selected so that user can type input right away
    ''' </summary>
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInput.Select()
    End Sub

    ''' <summary>
    ''' Accept the user input when they type a number and hit the Enter button
    ''' </summary>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' To validate the input is an integer or not
        Dim input As Integer

        ' Validate whether user input is numeric or not
        If Integer.TryParse(txtInput.Text, input) Then

            ' Validate whether user input is in valid range
            If input < 0 Or input > 5000 Then
                ' Pops up an error message if input is not within valid range
                MessageBox.Show("The input must be between 0 and 5000!")
                txtInput.Clear()
                ' We don't need a txtInput.Select() here because it is done in the Handler Mybase.Load

                ' If user input is valid, then display the number to the Units textbox
            Else
                txtUnits.Text += input.ToString() + vbCrLf
                total(i) = input    'Store the user input into the array Total
                i += 1  ' Increse the index by 1
                day += 1    ' Increase day by 1
                lblDay.Text = "Day " + day.ToString()
                txtInput.Clear()    ' Clear the input textbox to get a new number
            End If

            ' If day = 8 means user already entered 7 numbers
            ' Stop the user typing more and display the average number
            If day = 8 Then
                lblDay.Text = "Day 7"
                txtInput.Clear()
                txtInput.ReadOnly = True
                btnEnter.Enabled = False

                'Calculate the total units in the array Total using a for loop
                For count As Integer = 0 To 6
                    totalValue += total(count)
                Next

                'Round the result to 2 decimal place
                ' The avarage = total / 7
                averageUnits = Math.Round((totalValue / 7), 2, MidpointRounding.AwayFromZero)
                txtResult.Text = "Average per day: " + averageUnits.ToString()
            End If

            ' If user type something that is not numeric, pops up an error message
        Else
            MessageBox.Show("Error - the input must be a whole number!")
            txtInput.Clear()
            ' We don't need a txtInput.Select() here because it is done in the Handler Mybase.Load
        End If
    End Sub

    ''' <summary>
    ''' Reset the form to the default view
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtInput.Clear()
        txtUnits.Clear()
        txtResult.Text = String.Empty
        lblDay.Text = "Day 1"
        txtInput.ReadOnly = False
        txtInput.Select()
        btnEnter.Enabled = True

        ' Reset the value of global variable
        i = 0
        day = 1
        totalValue = 0
    End Sub

    ''' <summary>
    ''' Me Close Form
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
