<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAverageUnitsShipped
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.infoToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnEnter, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReset, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExit, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 228)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(264, 43)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnEnter
        '
        Me.btnEnter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEnter.Location = New System.Drawing.Point(3, 3)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(82, 37)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.infoToolTip.SetToolTip(Me.btnEnter, "Click this to insert a number")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReset.Location = New System.Drawing.Point(91, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(82, 37)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.infoToolTip.SetToolTip(Me.btnReset, "Click this to reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExit.Location = New System.Drawing.Point(179, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 37)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.infoToolTip.SetToolTip(Me.btnExit, "Click this to exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(12, 202)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(240, 20)
        Me.txtResult.TabIndex = 4
        Me.infoToolTip.SetToolTip(Me.txtResult, "The average units of 7 days")
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(12, 54)
        Me.txtUnits.Multiline = True
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.ReadOnly = True
        Me.txtUnits.Size = New System.Drawing.Size(240, 142)
        Me.txtUnits.TabIndex = 3
        Me.infoToolTip.SetToolTip(Me.txtUnits, "The numbers of 7 days")
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtInput, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDay, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblUnits, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(264, 48)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInput.Location = New System.Drawing.Point(91, 14)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(82, 20)
        Me.txtInput.TabIndex = 1
        Me.infoToolTip.SetToolTip(Me.txtInput, "Enter the number shipped between 0 and 5000")
        '
        'lblDay
        '
        Me.lblDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDay.Location = New System.Drawing.Point(179, 8)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(82, 31)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblDay, "Enter the units shipped for this day")
        '
        'lblUnits
        '
        Me.lblUnits.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnits.Location = New System.Drawing.Point(3, 7)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(82, 33)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.infoToolTip.SetToolTip(Me.lblUnits, "This is Units")
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(264, 271)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(280, 310)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(280, 310)
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped - Duy Tan Vu"
        Me.infoToolTip.SetToolTip(Me, "The program will calculate the average units shipped of 7 days")
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents infoToolTip As ToolTip
End Class
