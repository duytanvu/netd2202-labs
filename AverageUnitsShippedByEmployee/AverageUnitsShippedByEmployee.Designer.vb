<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShippedByEmployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtArrayResult1 = New System.Windows.Forms.TextBox()
        Me.txtArrayResult2 = New System.Windows.Forms.TextBox()
        Me.txtArrayResult3 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblResult1 = New System.Windows.Forms.Label()
        Me.lblResult2 = New System.Windows.Forms.Label()
        Me.lblResult3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalResult = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.infoToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblDay, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblUnits, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtInput, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(140, 64)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblDay
        '
        Me.lblDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(3, 9)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(64, 13)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblDay, "The date you are entering input")
        '
        'lblUnits
        '
        Me.lblUnits.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(3, 41)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(64, 13)
        Me.lblUnits.TabIndex = 1
        Me.lblUnits.Text = "&Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblUnits, "Press Alt + U to enter units")
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.Location = New System.Drawing.Point(73, 38)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(64, 20)
        Me.txtInput.TabIndex = 2
        Me.infoToolTip.SetToolTip(Me.txtInput, "Click here or press Alt + U to enter number of units shipped here")
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblEmployee1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblEmployee2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblEmployee3, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 82)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(600, 25)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmployee1.AutoSize = True
        Me.lblEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployee1.Location = New System.Drawing.Point(3, 6)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(194, 13)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblEmployee1, "This is the employee 1")
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmployee2.AutoSize = True
        Me.lblEmployee2.Location = New System.Drawing.Point(203, 6)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(194, 13)
        Me.lblEmployee2.TabIndex = 4
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblEmployee2, "This is the employee 2")
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEmployee3.AutoSize = True
        Me.lblEmployee3.Location = New System.Drawing.Point(403, 6)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(194, 13)
        Me.lblEmployee3.TabIndex = 5
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblEmployee3, "This is the employee 3")
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtArrayResult1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtArrayResult2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtArrayResult3, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(12, 113)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(600, 157)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'txtArrayResult1
        '
        Me.txtArrayResult1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtArrayResult1.Location = New System.Drawing.Point(3, 3)
        Me.txtArrayResult1.Multiline = True
        Me.txtArrayResult1.Name = "txtArrayResult1"
        Me.txtArrayResult1.ReadOnly = True
        Me.txtArrayResult1.Size = New System.Drawing.Size(194, 151)
        Me.txtArrayResult1.TabIndex = 6
        Me.infoToolTip.SetToolTip(Me.txtArrayResult1, "This is a list of inputs of 7 days of employee 1")
        '
        'txtArrayResult2
        '
        Me.txtArrayResult2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtArrayResult2.Location = New System.Drawing.Point(203, 3)
        Me.txtArrayResult2.Multiline = True
        Me.txtArrayResult2.Name = "txtArrayResult2"
        Me.txtArrayResult2.ReadOnly = True
        Me.txtArrayResult2.Size = New System.Drawing.Size(194, 151)
        Me.txtArrayResult2.TabIndex = 7
        Me.infoToolTip.SetToolTip(Me.txtArrayResult2, "This is a list of inputs of 7 days of employee 2")
        '
        'txtArrayResult3
        '
        Me.txtArrayResult3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtArrayResult3.Location = New System.Drawing.Point(403, 3)
        Me.txtArrayResult3.Multiline = True
        Me.txtArrayResult3.Name = "txtArrayResult3"
        Me.txtArrayResult3.ReadOnly = True
        Me.txtArrayResult3.Size = New System.Drawing.Size(194, 151)
        Me.txtArrayResult3.TabIndex = 8
        Me.infoToolTip.SetToolTip(Me.txtArrayResult3, "This is a list of inputs of 7 days of employee 3")
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblResult1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblResult2, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblResult3, 2, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(12, 276)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(600, 38)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'lblResult1
        '
        Me.lblResult1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResult1.Location = New System.Drawing.Point(3, 0)
        Me.lblResult1.Name = "lblResult1"
        Me.lblResult1.Size = New System.Drawing.Size(194, 38)
        Me.lblResult1.TabIndex = 9
        Me.lblResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblResult1, "This is the average units of employee 1")
        '
        'lblResult2
        '
        Me.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResult2.Location = New System.Drawing.Point(203, 0)
        Me.lblResult2.Name = "lblResult2"
        Me.lblResult2.Size = New System.Drawing.Size(194, 38)
        Me.lblResult2.TabIndex = 10
        Me.lblResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblResult2, "This is the average units of employee 2")
        '
        'lblResult3
        '
        Me.lblResult3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResult3.Location = New System.Drawing.Point(403, 0)
        Me.lblResult3.Name = "lblResult3"
        Me.lblResult3.Size = New System.Drawing.Size(194, 38)
        Me.lblResult3.TabIndex = 11
        Me.lblResult3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblResult3, "This is the average units of employee 3")
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lblTotalResult, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(12, 321)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(600, 35)
        Me.TableLayoutPanel5.TabIndex = 4
        '
        'lblTotalResult
        '
        Me.lblTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTotalResult.Location = New System.Drawing.Point(3, 0)
        Me.lblTotalResult.Name = "lblTotalResult"
        Me.lblTotalResult.Size = New System.Drawing.Size(594, 35)
        Me.lblTotalResult.TabIndex = 12
        Me.lblTotalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblTotalResult, "This is the average units of all three employees")
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel6.Controls.Add(Me.btnEnter, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btnReset, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.btnExit, 2, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(12, 363)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(600, 26)
        Me.TableLayoutPanel6.TabIndex = 5
        '
        'btnEnter
        '
        Me.btnEnter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEnter.Location = New System.Drawing.Point(3, 3)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(194, 20)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.infoToolTip.SetToolTip(Me.btnEnter, "Click here or press enter to calculate")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReset.Location = New System.Drawing.Point(203, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(194, 20)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.infoToolTip.SetToolTip(Me.btnReset, "Click here or press ESC to reset the application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExit.Location = New System.Drawing.Point(403, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(194, 20)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.infoToolTip.SetToolTip(Me.btnExit, "Click here to exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShippedByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(624, 401)
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(640, 440)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(640, 440)
        Me.Name = "frmAverageUnitsShippedByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee - Duy Tan Vu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblDay As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents txtArrayResult1 As TextBox
    Friend WithEvents txtArrayResult2 As TextBox
    Friend WithEvents txtArrayResult3 As TextBox
    Friend WithEvents lblResult1 As Label
    Friend WithEvents lblResult3 As Label
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblTotalResult As Label
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResult2 As Label
    Friend WithEvents infoToolTip As ToolTip
End Class
