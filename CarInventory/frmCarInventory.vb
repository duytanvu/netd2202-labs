Option Strict On

''' <summary>
''' Author: Duy Tan Vu
''' Date: March 10, 2020
''' Program: Car Inventory
''' Description: This is a program used to store and display information of a car
'''              and store them in a list viewer which user can select and manipulate
'''              them later on.
''' </summary>

Public Class frmCarInventory

#Region "Variable Declarations"
    ''' <summary>
    ''' Variable declaration
    ''' </summary>
    Private carList As New SortedList   ' Store car's information in a list
    Private currentCarIdentificationNumber As String = String.Empty     ' Initialize the car identification number
    Private editMode As Boolean = False ' Declare edit mode as a boolean value
#End Region

#Region "Events handlers"
    ''' <summary>
    ''' When the form is loaded, add 100 years to the combo box "Year"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub frmCarInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For year As Integer = 1920 To 2020
            cmbYear.Items.Add(year)
        Next
    End Sub

    ''' <summary>
    ''' When user click the enter button, check if the info already existed or not then store them in the list viewer
    ''' Display error message if any fields is blank or the input value is not approriate (string instead of number)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Car                  ' Declare a car class
        Dim carItem As ListViewItem     ' Declare a list view item class

        ' Validate the input fields
        If (IsValidInput() = True) Then

            ' If all inputs are valid, then enable edit mode and display a message in the label "Result"
            editMode = True
            lblResult.Text = "It worked!"

            ' If the current identification number is null then it's a new object
            If (currentCarIdentificationNumber.Trim.Length = 0) Then
                ' Create a new object using parameterized constructor
                car = New Car(cmbMake.Text, txtModel.Text, Convert.ToInt32(cmbYear.Text), Convert.ToDecimal(txtPrice.Text), chkStatus.Checked)
                ' Add the car info to the collection and use the ID as key to find it in the collection later on
                carList.Add(car.IdentificationNumber.ToString(), car)

                ' If the identification number existed, then user selected a record from the list viewer
                ' It may be updated
            Else
                ' Use the ID and select it from the car collection
                car = CType(carList.Item(currentCarIdentificationNumber), Car)

                ' Update any field if user enter something 
                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Year = Convert.ToInt32(cmbYear.Text)
                car.Price = Convert.ToDecimal(txtPrice.Text)
                car.IsNew = chkStatus.Checked
            End If

            ' Clear the item in the list control
            lvwResult.Items.Clear()

            ' Using a for loop and display record of the list view
            For Each carEntry As DictionaryEntry In carList
                carItem = New ListViewItem()        ' Initialize a list view
                car = CType(carEntry.Value, Car)    ' Get the car from the list

                ' Assign the values to the checked control and subitems
                carItem.Checked = car.IsNew
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year.ToString())
                carItem.SubItems.Add(car.Price.ToString())

                ' Add them to the list viewer
                lvwResult.Items.Add(carItem)
            Next carEntry

            ' Clear the input fields
            Reset()

            ' Set edit mode to false
            editMode = False
        End If
    End Sub

    ''' <summary>
    ''' Call the reset function when "Reset" button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    ''' <summary>
    ''' Close the form when the "Exit" button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
#End Region

#Region "Methods"
    ''' <summary>
    ''' Reset function used to clear all the input fields and reset the car identification number
    ''' </summary>
    Private Sub Reset()
        cmbMake.SelectedIndex = -1
        txtModel.Text = String.Empty
        cmbYear.SelectedIndex = -1
        txtPrice.Text = String.Empty
        chkStatus.Checked = False
        currentCarIdentificationNumber = String.Empty

    End Sub

    ''' <summary>
    ''' Function used to prevent user check the checkbox in the list viewer if edit mode is false
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwResult_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwResult.ItemCheck
        ' If edit mode is false then listview cannot be edited by user
        If editMode = False Then
            e.NewValue = e.CurrentValue
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwResult_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwResult.SelectedIndexChanged
        ' Represent the index of the item in the list that holds car identification number
        Const identificationSubItemIndex As Integer = 1
        ' Get the car identification number
        currentCarIdentificationNumber = lvwResult.Items(lvwResult.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        ' Get the car info from the collection by the identification number
        Dim car As Car = CType(carList.Item(currentCarIdentificationNumber), Car)

        ' Get the properties and display them on approriate fields
        cmbMake.Text = car.Make
        txtModel.Text = car.Model
        cmbYear.Text = car.Year.ToString
        txtPrice.Text = car.Price.ToString
        chkStatus.Checked = car.IsNew

        ' Display the car's info to the result label using a to_string method
        lblResult.Text = car.GetCarData()
    End Sub

    ''' <summary>
    ''' Function used to validate all input fields
    ''' </summary>
    ''' <returns></returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True           ' Initialize a return value boolean as true
        Dim outputMessage As String = String.Empty  ' Initialize an empty error message

        ' If user did not choose an option from the make combo box
        If (cmbMake.SelectedIndex = -1) Then
            ' Concatenate error message to the string and set return value to false
            outputMessage &= "Please select the car make." & vbCrLf
            returnValue = False
        End If

        ' If user did not type anything in the make textbox
        If (txtModel.Text.Trim.Length = 0) Then
            ' Concatenate error message to the string and set return value to false
            outputMessage &= "Please enter car model." & vbCrLf
            returnValue = False
        End If

        ' If user did not choose an option from the year combo box
        If (cmbYear.SelectedIndex = -1) Then
            ' Concatenate error message to the string and set return value to false
            outputMessage &= "Please select year made." & vbCrLf
            returnValue = False
        End If

        ' If user left the textbox price blank or the value is less than 0
        If (txtPrice.Text = String.Empty Or Val(txtPrice.Text) <= 0) Then
            ' Concatenate error message to the string and set return value to false
            outputMessage &= "Please enter valid price." & vbCrLf
            returnValue = False
        End If

        ' If return value is false then display the error message to the result label
        If (returnValue = False) Then
            lblResult.Text = "ERRORS." & vbCrLf & outputMessage
        End If

        ' Return the value of the boolean variable
        Return returnValue
    End Function
#End Region

End Class
