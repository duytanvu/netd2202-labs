' Author: Duy Tan Vu
' Date: Feb 03, 2020
' Program: Semester Grades
' Description: This program will take grades for 7 courses from the user and display the 
'               equivalent gradepoint to the grade. At least one grade was entered, user 
'               click the "Calculate" button to calculate the semester grade and gradepoint.
'               User is able to reset the form and exit program anytime.

Option Strict On
Public Class frmSemesterGrades

#Region "Variables"
    ' Declare two arrays: one for input grades and one for output grade points
    Dim inputGradeList As TextBox()
    Dim outputGradeList As Label()

    ' Set total grade, semester grade and grade counter default to 0
    Dim totalGrade As Double = 0
    Dim courseCounter As Integer = 0
    Dim semesterGrade As Double = 0

    ' Constant Declarations
    Const MinimumGrade As Integer = 0
    Const MaximumGrade As Integer = 100
#End Region

#Region "Events Handler"
    ''' <summary>
    ''' Set input array and output array when the program starts 
    ''' </summary>
    Private Sub frmSemesterGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputGradeList = {txtCourse1Input, txtCourse2Input, txtCourse3Input, txtCourse4Input, txtCourse5Input, txtCourse6Input, txtCourse7Input}
        outputGradeList = {lblCourse1Output, lblCourse2Output, lblCourse3Output, lblCourse4Output, lblCourse5Output, lblCourse6Output, lblCourse7Output}
    End Sub

    ''' <summary>
    ''' When the "Calculate" button is clicked, perform the calculation if at least one course grade was entered
    ''' </summary>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Clear any error if it happened before
        lblResult.Text = String.Empty
        ' Validate if all input textboxes are valid 
        If (ValidateAllGrades(inputGradeList)) Then
            ' If all inputs are blank, the display error message and require user to enter at least one grade to continue
            ' This is done to avoid division by 0
            If (totalGrade = 0) Then
                lblResult.Text &= "Please enter at least one course grade to calculate." & vbCrLf
                txtCourse1Input.Select()
                ' If at least one textbox is valid and other textboxes are blank or all input textboxes are valid, start calcualte
            Else
                ' Disable the input textboxes
                SetTextBoxes(inputGradeList, False)
                ' Calculate and round the result
                semesterGrade = Math.Round((totalGrade / courseCounter), 2)
                ' Assign semester grade and semester gradepoint
                lblSemesterInput.Text &= semesterGrade
                lblSemesterOutput.Text &= GradePoints(semesterGrade)
                ' Disable the "Calculate" button and set the focus to "Reset" button
                btnCalculate.Enabled() = False
                btnReset.Select()
                ' I don't reset the value of total grade, course counter and semester grade here
                ' I will do that in the "SetDefault()" function
            End If
        End If
    End Sub

    ''' <summary>
    ''' Run the "SetDefault" function when "Reset" button is clicked
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefault()
    End Sub


    ''' <summary>
    ''' Close the form when the "Exit" button is clicked
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' The LoseFocus event is used to assign gradepoint to the valid grade
    ''' </summary>
    Private Sub TextBoxLoseFocus(sender As Object, e As EventArgs) Handles txtCourse1Input.LostFocus, txtCourse2Input.LostFocus, txtCourse3Input.LostFocus, txtCourse4Input.LostFocus, txtCourse5Input.LostFocus, txtCourse6Input.LostFocus, txtCourse7Input.LostFocus
        Dim grade As Double
        ' Go through the input array
        For gradeIndex As Integer = 0 To (inputGradeList.Length - 1)
            ' If the input is numeric, then run the method "GradePoints"
            If Double.TryParse(inputGradeList(gradeIndex).Text, grade) Then
                outputGradeList(gradeIndex).Text = GradePoints(grade)
            End If
        Next
    End Sub
#End Region

#Region "Functions"
    ' This function is used to clear text of input and output array
    Sub ClearControls(controlArray As Control())
        For Each controlToClear As Control In controlArray
            controlToClear.Text = String.Empty
        Next
    End Sub


    ' This function is used to set the status of an array
    Sub SetTextBoxes(textboxArray As TextBox(), enabledStatus As Boolean)
        For Each textboxToSet As TextBox In textboxArray
            textboxToSet.Enabled = enabledStatus
        Next
    End Sub

    ''' <summary>
    ''' This function is used to set the form to default when user clicks "Reset" button
    ''' </summary>
    Sub SetDefault()
        ' Enable and select "Calculate" button
        btnCalculate.Enabled = True
        btnCalculate.Select()
        ' Reset string value of all input and out put as well as result box
        ClearControls(inputGradeList)
        ClearControls(outputGradeList)
        lblSemesterInput.Text = String.Empty
        lblSemesterOutput.Text = String.Empty
        lblResult.Text = String.Empty
        ' Set the status of input array to true
        SetTextBoxes(inputGradeList, True)
        ' Set the focus to the textbox input of the first course
        txtCourse1Input.Select()
        ' Reset global variables
        totalGrade = 0
        courseCounter = 0
        semesterGrade = 0
    End Sub

    ''' <summary>
    ''' This function is used to validate each textbox. It will be called inside another function which validate all textboxes
    ''' </summary>
    Function ValidateGrade(txtGradeInput As TextBox) As Boolean
        Dim grade As Double
        ' If the input is numeric
        If Double.TryParse(txtGradeInput.Text, grade) Then
            ' If input is outside of valid range, then display error message
            If (grade < MinimumGrade Or grade > MaximumGrade) Then
                lblResult.Text &= txtGradeInput.Text & " is not between 0 and 100. Please try again." & vbCrLf
                ' Use focus and selectAll method to immediately select the invalid text for user to make changes 
                txtGradeInput.Focus()
                txtGradeInput.SelectAll()
                Return False
                ' If input is numeric and inside the valid range, then increase the course counter and add it to the total grade
            Else
                totalGrade += grade
                courseCounter += 1
                Return True
            End If
            ' If the input is not numeric, there are 2 possible situations
        Else

            ' If the string is empty (which means it's blank because user did not type anything), the input is valid
            ' but the course counter does not increase 
            If txtGradeInput.Text = String.Empty Then
                Return True
                ' Otherwise, input is invalid (including the case user type one or more spaces, it is considered as invalid)
            Else
                lblResult.Text &= Chr(34) & txtGradeInput.Text & Chr(34) & " is not numeric. Please try again." & vbCrLf
                ' Use focus and selectAll method to immediately select the invalid text for user to make changes 
                txtGradeInput.Focus()
                txtGradeInput.SelectAll()
                Return False
            End If
        End If
    End Function


    ''' <summary>
    ''' This function is used to determine whether all input are valid or not
    ''' </summary>
    Function ValidateAllGrades(gradeArray As TextBox()) As Boolean
        Dim isValid = True
        For Each element In inputGradeList
            isValid = isValid And ValidateGrade(element)
        Next
        Return isValid
    End Function

    ''' <summary>
    ''' This function used to display the grade letter equivalent to the grade scale
    ''' </summary>
    Function GradePoints(grade As Double) As String
        ' Two arrays to loop through
        Dim gradeScale() As Integer = {0, 50, 55, 60, 65, 70, 75, 80, 85, 90}
        Dim gradeLetter() As String = {"F", "D", "D+", "C", "B-", "B", "B+", "A-", "A", "A+"}
        Dim outputLevel As String = ""
        ' A loop will be executed to determine the grade letter
        For gradeLevel As Integer = 0 To (gradeScale.Length - 1)
            If (grade >= gradeScale(gradeLevel)) Then
                ' Because we use the operater greater than or equal so if the input is greater than 100
                ' the output grade letter will be equal to "A+"
                ' To avoid that, we add another if statement (There are many other ways to do that, this is one of them.)
                If (grade > MaximumGrade) Then
                    outputLevel = String.Empty
                Else
                    outputLevel = gradeLetter(gradeLevel)
                End If
            End If
        Next
        Return outputLevel
    End Function
#End Region

End Class