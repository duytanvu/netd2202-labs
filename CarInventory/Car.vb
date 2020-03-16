Option Strict On

''' <summary>
''' Author: Duy Tan Vu
''' Date: March 10, 2020
''' File name: Car.vb
''' Description: This file is a class used to manipulate the form 
'''              with some car's properties and methods.
''' </summary>

Public Class Car

#Region "Variable Declarations"
    Private Shared carCount As Integer              ' Shared variable holds number of cars
    Private carIdentificationNumber As Integer = 0  ' Holds car identification number
    Private carMake As String = String.Empty        ' Holds car's make
    Private carModel As String = String.Empty       ' Holds car's model
    Private carYear As Integer = 0                  ' Holds car's year of make
    Private carPrice As Decimal = 0.0D              ' Holds car's price as decimal 
    Private carNewStatus As Boolean = True          ' Holds car's status as new or used
#End Region

#Region "Constructors"
    ''' <summary>
    ''' Default constructor for the car class; maintain a class count variable.
    ''' </summary>
    Friend Sub New()
        carCount += 1
        carIdentificationNumber = carCount
    End Sub

    ''' <summary>
    ''' Parameterized constuctor for the car class; sets several instance variables based on values passed in.
    ''' </summary>
    ''' <param name="makeValue"></param>
    ''' <param name="modelValue"></param>
    ''' <param name="yearValue"></param>
    ''' <param name="priceValue"></param>
    ''' <param name="statusValue"></param>
    Friend Sub New(makeValue As String, modelValue As String, yearValue As Integer, priceValue As Decimal, statusValue As Boolean)
        Me.New()
        carMake = makeValue
        carModel = modelValue
        carYear = yearValue
        carPrice = priceValue
        carNewStatus = statusValue
    End Sub
#End Region

#Region "Properties"
    ''' <summary>
    ''' Returns the number of car objects
    ''' </summary>
    ''' <returns>The number of car objects</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' Get a car's identification number
    ''' </summary>
    ''' <returns>A car identification number</returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' Gets and sets a car object's manufactor
    ''' </summary>
    ''' <returns>A car manufactor name</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car object's manufactor
    ''' </summary>
    ''' <returns>A car model name</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car object's year of production
    ''' </summary>
    ''' <returns>A car manufactor year</returns>
    Public Property Year() As Integer
        Get
            Return carYear
        End Get
        Set(value As Integer)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car object's manufactor
    ''' </summary>
    ''' <returns>A car manufactor name</returns>
    Public Property Price() As Decimal
        Get
            Return carPrice
        End Get
        Set(value As Decimal)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' Gets and sets a car object's manufactor
    ''' </summary>
    ''' <returns>A car manufactor name</returns>
    Public Property IsNew() As Boolean
        Get
            Return carNewStatus
        End Get
        Set(value As Boolean)
            carNewStatus = value
        End Set
    End Property
#End Region

#Region "Methods"
    ''' <summary>
    ''' This function used to display a car's properties when selected from the list viewer
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCarData() As String
        ' Use a conditional statement to display a car's properties
        If carNewStatus = True Then
            Return "New " & carYear.ToString() & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")
        Else
            Return "Used " & carYear.ToString() & " " & carMake & " " & carModel & " for " & carPrice.ToString("c")
        End If
    End Function
#End Region
End Class
