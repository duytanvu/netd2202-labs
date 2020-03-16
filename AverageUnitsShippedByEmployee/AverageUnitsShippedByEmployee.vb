' Author: Duy Tan Vu
' Date: Feb 18, 2020
' Program: Average Units Shipped By Employee
' Description: This program is a more advanced Windows dekstop application that will take the input
'               from three employees of seven days then calculate each employee average number.
'               After that it will calculate the average of all three employees. Invalid input
'               or out_of_range number will leads to an error message pops up.
Option Strict On

Public Class frmAverageUnitsShippedByEmployee
#Region "Constants and variabbles"
    ' Two dimensional array to store 7 inputs of 3 employees
    Dim arrayResult(2, 6) As Integer
    Dim listTextbox As TextBox()  ' Used to move input to another textbox when 7 inputs are entered from previous employee
    Dim employeeLabel As Label()  ' Used to bold the name of the current employee who is entering input
    Dim resultLabel As Label()    ' Used to display the average units of each employee
    ' Constants declaration
    Const MinimumValue As Integer = 0
    Const MaximumValue As Integer = 5000
    ' Variables declarations
    Dim day As Integer = 0       ' The first index of the day dimension
    Dim employee As Integer = 0  ' The first index of employee dimension
    Dim labelDay As Integer = 1  ' Use to change the label [Day]
#End Region

#Region "Event Handlers"
    Private Sub frmAverageUnitsShippedByEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define a textbox array and two label arrays
        listTextbox = {txtArrayResult1, txtArrayResult2, txtArrayResult3}
        employeeLabel = {lblEmployee1, lblEmployee2, lblEmployee3}
        resultLabel = {lblResult1, lblResult2, lblResult3}
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Try to parse the input
        If Integer.TryParse(txtInput.Text, arrayResult(employee, day)) Then

            ' If the number is less than 0 or greater than 5000 then pop up an error message
            If (arrayResult(employee, day) < MinimumValue Or arrayResult(employee, day) > MaximumValue) Then
                MessageBox.Show("Valid range is between " & MinimumValue & " and " & MaximumValue & ". Please try again.")
                ' Select the invalid input immediately so the user can fix it quickly
                txtInput.Focus()
                txtInput.SelectAll()

                ' If the input is numeric and within valid range
            Else
                ' Clear the input textbox
                txtInput.Text = String.Empty
                ' Add input to the textbox of that employee
                listTextbox(employee).Text &= arrayResult(employee, day) & vbCrLf
                ' Increase the day to the label 
                labelDay += 1
                ' Display the next day on [day] label
                lblDay.Text = "Day " & labelDay
                ' Increase the index of [day] dimension
                day += 1

                ' If day = GetLength(1) that means all 7 inputs are entered,
                ' calculte the average and move to the next employee
                If (day = arrayResult.GetLength(1)) Then
                    ' Calculate the average figure of each employee
                    ' Declare a temporary average variable 
                    Dim averageValue As Double = 0
                    ' Use a for loop to calculate the total number first
                    For dayCount As Integer = 0 To arrayResult.GetUpperBound(1)
                        averageValue += arrayResult(employee, dayCount)
                    Next
                    ' Calculate and output the average to two decimals points
                    averageValue = Math.Round(averageValue / arrayResult.GetLength(1), 2)
                    resultLabel(employee).Text = averageValue.ToString
                    ' Change the font of the current employee to regular font
                    employeeLabel(employee).Font = New Font(employeeLabel(employee).Font, FontStyle.Regular)
                    ' Increase the index of [employee] dimension
                    employee += 1

                    ' If employee = GetLength(0) that means all three employees entered all inputs
                    If (employee = arrayResult.GetLength(0)) Then
                        ' Bold the first employee label when all three emmployees input are entered
                        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
                        ' Using a for loop to calculate the overall average
                        ' Declare a temporary overall average of three employees
                        Dim finalResult As Double = 0
                        ' Use a for loop to calculate total value first
                        For i As Integer = 0 To arrayResult.GetUpperBound(0)
                            For j As Integer = 0 To arrayResult.GetUpperBound(1)
                                finalResult += arrayResult(i, j)
                            Next
                        Next
                        ' Calculte and output the overall average to two decimal points
                        finalResult = Math.Round(finalResult / arrayResult.Length, 2)
                        lblTotalResult.Text = finalResult.ToString()
                        ' Set the label to 'Done', disable Enter button and select Reset button
                        lblDay.Text = "Done!"
                        txtInput.Enabled = False
                        btnEnter.Enabled = False
                        btnReset.Select()

                        ' If the employee index < 3 then bold the font of the current employee
                    Else
                        employeeLabel(employee).Font = New Font(employeeLabel(employee).Font, FontStyle.Bold)
                        ' Reset day index and the value of label [Day]
                        day = 0
                        labelDay = 1
                        lblDay.Text = "Day " & labelDay
                    End If
                End If
            End If

            ' If the input is not numeric, pop up an error message
        Else
            MessageBox.Show("Please enter a whole number.")
            ' Select the invalid input immediately so the user can fix it quickly
            txtInput.Focus()
            txtInput.SelectAll()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefault()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
#End Region

#Region "Function"
    ' Sub function to empty all string of a control array
    Sub ClearControls(controlArray As Control())
        For Each controlToClear As Control In controlArray
            controlToClear.Text = String.Empty
        Next
    End Sub

    Sub SetDefault()
        'Bold the font of employee 1 and reset regular font for employee 2 & 3 
        lblEmployee1.Font = New Font(lblEmployee1.Font, FontStyle.Bold)
        lblEmployee2.Font = New Font(lblEmployee2.Font, FontStyle.Regular)
        lblEmployee3.Font = New Font(lblEmployee3.Font, FontStyle.Regular)
        ' Enable and select enter button
        btnEnter.Enabled = True
        btnEnter.Select()
        ' Enable and select input textbox
        txtInput.Enabled = True
        txtInput.Select()
        ' Clear all textboxes and output labels
        ClearControls(listTextbox)
        ClearControls(resultLabel)
        txtInput.Text = String.Empty
        lblTotalResult.Text = String.Empty
        ' Reset global variables
        day = 0
        employee = 0
        labelDay = 1
        ' Reset the lable [Day]
        lblDay.Text = "Day " & labelDay
    End Sub
#End Region
End Class

