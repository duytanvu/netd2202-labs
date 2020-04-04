' Author: Duy Tan Vu
' Date: April 2, 2020
' Program: Text Editor
' Description: This is a simple text editor create using Visual Basic,
'               Some basic features are open file, save file, copy and paste text.

Option Strict On

Imports System.IO

Public Class frmTextEditor
#Region "Variables declaration"
    Dim openFilePath As String = String.Empty   ' Save path of the file opening
    Dim originalText As String = String.Empty   ' For bonus mark part 2
#End Region

#Region "Events Handlers"
    ''' <summary>
    ''' Original text when the form load is string.empty
    ''' </summary>
    Private Sub frmTextEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        originalText = String.Empty     ' When the application first loaded, the original state ox textbox is empty
        openFilePath = String.Empty     ' default file path when application started
    End Sub

    ''' <summary>
    ''' NEW menu is clicked
    ''' </summary>
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        ' If user agree to close then return TRUE value and clear everything
        If ConfirmClose() = True Then
            txtEditor.Clear()               ' Clear the textbox 
            openFilePath = String.Empty     ' Open path is empty
            originalText = String.Empty     ' Original state of textbox is empty
            UpdateFormTitle()               ' Clear previous path 
        End If
    End Sub

    ''' <summary>
    ''' OPEN menu is clicked
    ''' </summary>
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        ' If user agreed to close the form, return true then processing
        If ConfirmClose() = True Then
            ' Show File Explorer
            If opdOpen.ShowDialog() = DialogResult.OK Then
                openFilePath = opdOpen.FileName     ' Get the file path to open
                OpenFile(openFilePath)              ' Call function to open file
                UpdateFormTitle()                   ' Update the new file path
            End If
        End If
    End Sub

    ''' <summary>
    ''' SAVE menu is clicked
    ''' </summary>
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        ' If file path is empty so acts as [Save As] (new file)
        If openFilePath = String.Empty Then
            mnuFileSaveAs_Click(sender, e)      ' Send object to SaveAs event

            ' If file path already exists, save it without open File Explorer
        Else
            SaveFile(openFilePath)    ' Call function to save file
        End If
    End Sub

    ''' <summary>
    ''' SAVE AS menu is clicked
    ''' </summary>
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        ' Set up filters
        sfdSaveAs.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        ' Show File Explorer
        If sfdSaveAs.ShowDialog() = DialogResult.OK Then
            openFilePath = sfdSaveAs.FileName       ' Get path to save file
            SaveFile(openFilePath)                  ' Call function to save file
            UpdateFormTitle()                       ' Update the path to the title
        End If
    End Sub

    ''' <summary>
    ''' EXIT menu is clicked
    ''' </summary>
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Exit if user agree not to save
        If ConfirmClose() = True Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' COPY menu is clicked
    ''' </summary>
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        ' Check if selection portion length is greater than 0
        If txtEditor.SelectionLength > 0 Then
            txtEditor.Copy()
        End If
    End Sub

    ''' <summary>
    ''' CUT menu is clicked
    ''' </summary>
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        ' Check if selection portion length is greater than 0
        If txtEditor.SelectionLength > 0 Then
            txtEditor.Cut()
        End If
    End Sub

    ''' <summary>
    ''' PASTE menu is clicked
    ''' </summary>
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        ' Paste the text in the clipboard to the cursor point
        txtEditor.Paste()
    End Sub

    ''' <summary>
    ''' ABOUT menu is clicked
    ''' </summary>
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Pop up a bit info about the authors and application
        MsgBox("NETD2202 - 20.04.02" & vbCrLf & vbCrLf &
               "Lab #5 - Text Editor" & vbCrLf & vbCrLf &
               "Duy Tan Vu", MsgBoxStyle.Information, "About")
    End Sub
#End Region

#Region "Methods"
    ''' <summary>
    ''' BONUS marks: ConfirmClose() function
    ''' This function simplify everything without a boolean value to detect if a file is open or not.
    ''' If a text is unchaged, it will not pop up confirmation message (including new file)
    ''' </summary>
    Function ConfirmClose() As Boolean
        Dim currentText As String = txtEditor.Text      ' Save current text to a temporary string

        ' Compare current text VS. original text
        ' If return <> 0, that means there are changes have been mande
        If String.Compare(currentText, originalText) <> 0 Then

            ' Dim answer to confirm close as a long to holds result give back from MsgBoxResult
            Dim answerConfirmClose As Long
            answerConfirmClose = MsgBox("You haven't save this file. Do you want to close this file?", MsgBoxStyle.YesNo, "Warning!!!")

            ' If Yes button is clicked, then return true
            If answerConfirmClose = vbYes Then
                Return True

                ' If No button is clicked, then return false
            Else
                Return False
            End If

            ' If string.compare retuns = 0 so text is unchanged
            ' That is equal to user click 'Yes' in confirmation box, so return true
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Procedure to save a file
    ''' </summary>
    Friend Sub SaveFile(path As String)
        originalText = txtEditor.Text   ' Save current text to a string to compare to compare strings for confirmation

        ' Set up FileStream, StreamWriter then write text of the txtEditor to that path and close it
        Dim fileToSave As FileStream = New FileStream(path, FileMode.Create, FileAccess.Write)
        Dim fileWriter As StreamWriter = New StreamWriter(fileToSave)
        fileWriter.Write(txtEditor.Text)
        fileWriter.Close()
    End Sub

    ''' <summary>
    ''' Procedure to open a file
    ''' I pass it a parameter as textbox because I need to use it for reading file and compare files (for BONUS marks part 2)
    ''' </summary>
    Friend Sub OpenFile(path As String)
        ' Set up FileStream, StreamReader then read the file and close it
        Dim openFile As New FileStream(openFilePath, FileMode.Open, FileAccess.Read)
        Dim fileReader As New StreamReader(openFile)
        txtEditor.Text = fileReader.ReadToEnd
        originalText = txtEditor.Text   ' Save current text to a string after reading file to compare strings for confirmation
        fileReader.Close()
    End Sub

    ''' <summary>
    ''' Used to update the file path to the title
    ''' </summary>
    Friend Sub UpdateFormTitle()
        Me.Text = "Text Editor "
        ' Only add path to the title when a file is currently open
        If Not openFilePath = String.Empty Then
            Me.Text &= " - " & openFilePath & " OPEN"
        End If
    End Sub

#End Region
End Class
