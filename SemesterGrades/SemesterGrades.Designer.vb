<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSemesterGrades
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.lblCourse7 = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.txtCourse1Input = New System.Windows.Forms.TextBox()
        Me.txtCourse2Input = New System.Windows.Forms.TextBox()
        Me.txtCourse3Input = New System.Windows.Forms.TextBox()
        Me.txtCourse4Input = New System.Windows.Forms.TextBox()
        Me.txtCourse5Input = New System.Windows.Forms.TextBox()
        Me.txtCourse6Input = New System.Windows.Forms.TextBox()
        Me.txtCourse7Input = New System.Windows.Forms.TextBox()
        Me.lblCourse1Output = New System.Windows.Forms.Label()
        Me.lblCourse2Output = New System.Windows.Forms.Label()
        Me.lblCourse3Output = New System.Windows.Forms.Label()
        Me.lblCourse4Output = New System.Windows.Forms.Label()
        Me.lblCourse5Output = New System.Windows.Forms.Label()
        Me.lblCourse6Output = New System.Windows.Forms.Label()
        Me.lblCourse7Output = New System.Windows.Forms.Label()
        Me.lblSemesterOutput = New System.Windows.Forms.Label()
        Me.lblSemesterInput = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.infoToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSemester, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCourse1Input, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCourse2Input, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCourse3Input, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCourse4Input, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCourse5Input, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCourse6Input, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCourse7Input, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse1Output, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse2Output, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse3Output, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse4Output, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse5Output, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse6Output, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCourse7Output, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSemesterOutput, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSemesterInput, 1, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(319, 265)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblCourse1
        '
        Me.lblCourse1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse1.AutoSize = True
        Me.lblCourse1.Location = New System.Drawing.Point(3, 10)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(100, 13)
        Me.lblCourse1.TabIndex = 0
        Me.lblCourse1.Text = "Course 1:"
        Me.lblCourse1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse1, "The first course")
        '
        'lblCourse2
        '
        Me.lblCourse2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse2.AutoSize = True
        Me.lblCourse2.Location = New System.Drawing.Point(3, 43)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(100, 13)
        Me.lblCourse2.TabIndex = 3
        Me.lblCourse2.Text = "Course 2:"
        Me.lblCourse2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse2, "The second course")
        '
        'lblCourse3
        '
        Me.lblCourse3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse3.AutoSize = True
        Me.lblCourse3.Location = New System.Drawing.Point(3, 76)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(100, 13)
        Me.lblCourse3.TabIndex = 6
        Me.lblCourse3.Text = "Course 3:"
        Me.lblCourse3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse3, "The third course")
        '
        'lblCourse4
        '
        Me.lblCourse4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse4.AutoSize = True
        Me.lblCourse4.Location = New System.Drawing.Point(3, 109)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(100, 13)
        Me.lblCourse4.TabIndex = 9
        Me.lblCourse4.Text = "Course 4:"
        Me.lblCourse4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse4, "The fourth course")
        '
        'lblCourse5
        '
        Me.lblCourse5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse5.AutoSize = True
        Me.lblCourse5.Location = New System.Drawing.Point(3, 142)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(100, 13)
        Me.lblCourse5.TabIndex = 12
        Me.lblCourse5.Text = "Course 5:"
        Me.lblCourse5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse5, "The fifth course")
        '
        'lblCourse6
        '
        Me.lblCourse6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse6.AutoSize = True
        Me.lblCourse6.Location = New System.Drawing.Point(3, 175)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(100, 13)
        Me.lblCourse6.TabIndex = 15
        Me.lblCourse6.Text = "Course 6:"
        Me.lblCourse6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse6, "The sixth course")
        '
        'lblCourse7
        '
        Me.lblCourse7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse7.AutoSize = True
        Me.lblCourse7.Location = New System.Drawing.Point(3, 208)
        Me.lblCourse7.Name = "lblCourse7"
        Me.lblCourse7.Size = New System.Drawing.Size(100, 13)
        Me.lblCourse7.TabIndex = 18
        Me.lblCourse7.Text = "Course 7:"
        Me.lblCourse7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse7, "The seventh course")
        '
        'lblSemester
        '
        Me.lblSemester.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Location = New System.Drawing.Point(3, 241)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(100, 13)
        Me.lblSemester.TabIndex = 21
        Me.lblSemester.Text = "Semester:"
        Me.lblSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblSemester, "Average semester grade")
        '
        'txtCourse1Input
        '
        Me.txtCourse1Input.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCourse1Input.Location = New System.Drawing.Point(109, 6)
        Me.txtCourse1Input.Name = "txtCourse1Input"
        Me.txtCourse1Input.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse1Input.TabIndex = 1
        Me.txtCourse1Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.infoToolTip.SetToolTip(Me.txtCourse1Input, "Enter grade for the 1st course")
        '
        'txtCourse2Input
        '
        Me.txtCourse2Input.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCourse2Input.Location = New System.Drawing.Point(109, 39)
        Me.txtCourse2Input.Name = "txtCourse2Input"
        Me.txtCourse2Input.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse2Input.TabIndex = 4
        Me.txtCourse2Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.infoToolTip.SetToolTip(Me.txtCourse2Input, "Enter grade for the 2nd course")
        '
        'txtCourse3Input
        '
        Me.txtCourse3Input.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCourse3Input.Location = New System.Drawing.Point(109, 72)
        Me.txtCourse3Input.Name = "txtCourse3Input"
        Me.txtCourse3Input.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse3Input.TabIndex = 7
        Me.txtCourse3Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.infoToolTip.SetToolTip(Me.txtCourse3Input, "Enter grade for the 3rd coruse")
        '
        'txtCourse4Input
        '
        Me.txtCourse4Input.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCourse4Input.Location = New System.Drawing.Point(109, 105)
        Me.txtCourse4Input.Name = "txtCourse4Input"
        Me.txtCourse4Input.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse4Input.TabIndex = 10
        Me.txtCourse4Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.infoToolTip.SetToolTip(Me.txtCourse4Input, "Enter grade for the fourth course")
        '
        'txtCourse5Input
        '
        Me.txtCourse5Input.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCourse5Input.Location = New System.Drawing.Point(109, 138)
        Me.txtCourse5Input.Name = "txtCourse5Input"
        Me.txtCourse5Input.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse5Input.TabIndex = 13
        Me.txtCourse5Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.infoToolTip.SetToolTip(Me.txtCourse5Input, "Enter grade for the fifth course")
        '
        'txtCourse6Input
        '
        Me.txtCourse6Input.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCourse6Input.Location = New System.Drawing.Point(109, 171)
        Me.txtCourse6Input.Name = "txtCourse6Input"
        Me.txtCourse6Input.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse6Input.TabIndex = 16
        Me.txtCourse6Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.infoToolTip.SetToolTip(Me.txtCourse6Input, "Enter grade for the sixth course")
        '
        'txtCourse7Input
        '
        Me.txtCourse7Input.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCourse7Input.Location = New System.Drawing.Point(109, 204)
        Me.txtCourse7Input.Name = "txtCourse7Input"
        Me.txtCourse7Input.Size = New System.Drawing.Size(100, 20)
        Me.txtCourse7Input.TabIndex = 19
        Me.txtCourse7Input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.infoToolTip.SetToolTip(Me.txtCourse7Input, "Enter grade for the seventh course")
        '
        'lblCourse1Output
        '
        Me.lblCourse1Output.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse1Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse1Output.Location = New System.Drawing.Point(215, 9)
        Me.lblCourse1Output.Name = "lblCourse1Output"
        Me.lblCourse1Output.Size = New System.Drawing.Size(101, 15)
        Me.lblCourse1Output.TabIndex = 2
        Me.lblCourse1Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse1Output, "Equivalent grade letter")
        '
        'lblCourse2Output
        '
        Me.lblCourse2Output.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse2Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse2Output.Location = New System.Drawing.Point(215, 42)
        Me.lblCourse2Output.Name = "lblCourse2Output"
        Me.lblCourse2Output.Size = New System.Drawing.Size(101, 15)
        Me.lblCourse2Output.TabIndex = 5
        Me.lblCourse2Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse2Output, "Equivalent grade letter")
        '
        'lblCourse3Output
        '
        Me.lblCourse3Output.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse3Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse3Output.Location = New System.Drawing.Point(215, 75)
        Me.lblCourse3Output.Name = "lblCourse3Output"
        Me.lblCourse3Output.Size = New System.Drawing.Size(101, 15)
        Me.lblCourse3Output.TabIndex = 8
        Me.lblCourse3Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse3Output, "Equivalent grade letter")
        '
        'lblCourse4Output
        '
        Me.lblCourse4Output.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse4Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse4Output.Location = New System.Drawing.Point(215, 108)
        Me.lblCourse4Output.Name = "lblCourse4Output"
        Me.lblCourse4Output.Size = New System.Drawing.Size(101, 15)
        Me.lblCourse4Output.TabIndex = 11
        Me.lblCourse4Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse4Output, "Equivalent grade letter")
        '
        'lblCourse5Output
        '
        Me.lblCourse5Output.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse5Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse5Output.Location = New System.Drawing.Point(215, 141)
        Me.lblCourse5Output.Name = "lblCourse5Output"
        Me.lblCourse5Output.Size = New System.Drawing.Size(101, 15)
        Me.lblCourse5Output.TabIndex = 14
        Me.lblCourse5Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse5Output, "Equivalent grade letter")
        '
        'lblCourse6Output
        '
        Me.lblCourse6Output.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse6Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse6Output.Location = New System.Drawing.Point(215, 174)
        Me.lblCourse6Output.Name = "lblCourse6Output"
        Me.lblCourse6Output.Size = New System.Drawing.Size(101, 15)
        Me.lblCourse6Output.TabIndex = 17
        Me.lblCourse6Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse6Output, "Equivalent grade letter")
        '
        'lblCourse7Output
        '
        Me.lblCourse7Output.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCourse7Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCourse7Output.Location = New System.Drawing.Point(215, 207)
        Me.lblCourse7Output.Name = "lblCourse7Output"
        Me.lblCourse7Output.Size = New System.Drawing.Size(101, 15)
        Me.lblCourse7Output.TabIndex = 20
        Me.lblCourse7Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblCourse7Output, "Equivalent grade letter")
        '
        'lblSemesterOutput
        '
        Me.lblSemesterOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSemesterOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterOutput.Location = New System.Drawing.Point(215, 240)
        Me.lblSemesterOutput.Name = "lblSemesterOutput"
        Me.lblSemesterOutput.Size = New System.Drawing.Size(101, 15)
        Me.lblSemesterOutput.TabIndex = 23
        Me.lblSemesterOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblSemesterOutput, "Equivalent grade letter for semester average grade")
        '
        'lblSemesterInput
        '
        Me.lblSemesterInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSemesterInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterInput.Location = New System.Drawing.Point(109, 240)
        Me.lblSemesterInput.Name = "lblSemesterInput"
        Me.lblSemesterInput.Size = New System.Drawing.Size(100, 15)
        Me.lblSemesterInput.TabIndex = 22
        Me.lblSemesterInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblSemesterInput, "This is the average grade")
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnCalculate, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnReset, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnExit, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 410)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(319, 35)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCalculate.Location = New System.Drawing.Point(3, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 29)
        Me.btnCalculate.TabIndex = 25
        Me.btnCalculate.Text = "&Calculate"
        Me.infoToolTip.SetToolTip(Me.btnCalculate, "Click this button to calculate the semester average grade and gradepoint")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReset.Location = New System.Drawing.Point(109, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 29)
        Me.btnReset.TabIndex = 26
        Me.btnReset.Text = "&Reset"
        Me.infoToolTip.SetToolTip(Me.btnReset, "Click this button to reset the form to default state")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExit.Location = New System.Drawing.Point(215, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 29)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "&Exit"
        Me.infoToolTip.SetToolTip(Me.btnExit, "Click this button to exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(12, 268)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(295, 139)
        Me.lblResult.TabIndex = 24
        Me.infoToolTip.SetToolTip(Me.lblResult, "Error messages will be displayed here")
        '
        'frmSemesterGrades
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(319, 446)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(335, 485)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(335, 485)
        Me.Name = "frmSemesterGrades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades - Duy Tan Vu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblCourse1 As Label
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents lblCourse7 As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents txtCourse1Input As TextBox
    Friend WithEvents txtCourse2Input As TextBox
    Friend WithEvents txtCourse3Input As TextBox
    Friend WithEvents txtCourse4Input As TextBox
    Friend WithEvents txtCourse5Input As TextBox
    Friend WithEvents txtCourse6Input As TextBox
    Friend WithEvents txtCourse7Input As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCourse1Output As Label
    Friend WithEvents lblCourse2Output As Label
    Friend WithEvents lblCourse3Output As Label
    Friend WithEvents lblCourse4Output As Label
    Friend WithEvents lblCourse5Output As Label
    Friend WithEvents lblCourse6Output As Label
    Friend WithEvents lblCourse7Output As Label
    Friend WithEvents lblSemesterOutput As Label
    Friend WithEvents lblSemesterInput As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents infoToolTip As ToolTip
End Class
