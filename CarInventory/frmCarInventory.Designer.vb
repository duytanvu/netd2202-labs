<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.chkStatus = New System.Windows.Forms.CheckBox()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.infoToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lvwResult = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblMake, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblModel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblYear, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPrice, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNew, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtModel, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrice, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.chkStatus, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbMake, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbYear, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 127)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblMake
        '
        Me.lblMake.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblMake.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMake.Location = New System.Drawing.Point(28, 6)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(39, 13)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.infoToolTip.SetToolTip(Me.lblMake, "Car's Make")
        '
        'lblModel
        '
        Me.lblModel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblModel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblModel.Location = New System.Drawing.Point(28, 31)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(39, 13)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "Mo&del:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.infoToolTip.SetToolTip(Me.lblModel, "Car's Model")
        '
        'lblYear
        '
        Me.lblYear.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblYear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblYear.Location = New System.Drawing.Point(28, 56)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(39, 13)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.infoToolTip.SetToolTip(Me.lblYear, "Car's Year")
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPrice.Location = New System.Drawing.Point(28, 81)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(39, 13)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.infoToolTip.SetToolTip(Me.lblPrice, "Car's Price")
        '
        'lblNew
        '
        Me.lblNew.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblNew.Location = New System.Drawing.Point(28, 107)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(39, 13)
        Me.lblNew.TabIndex = 8
        Me.lblNew.Text = "&New:"
        Me.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.infoToolTip.SetToolTip(Me.lblNew, "Car's status")
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(73, 28)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(124, 20)
        Me.txtModel.TabIndex = 3
        Me.infoToolTip.SetToolTip(Me.txtModel, "Enter car's model")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(73, 78)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(124, 20)
        Me.txtPrice.TabIndex = 7
        Me.infoToolTip.SetToolTip(Me.txtPrice, "Enter car's price ")
        '
        'chkStatus
        '
        Me.chkStatus.AutoSize = True
        Me.chkStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkStatus.Location = New System.Drawing.Point(73, 103)
        Me.chkStatus.Name = "chkStatus"
        Me.chkStatus.Size = New System.Drawing.Size(124, 21)
        Me.chkStatus.TabIndex = 9
        Me.infoToolTip.SetToolTip(Me.chkStatus, "Click if car is new")
        Me.chkStatus.UseVisualStyleBackColor = True
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Volkswagen ", "General Motors", "Toyota", "Hyundai", "Honda", "Tesla", "Mitsubishi", "Subaru", "BMW", "Porsche", "Mercedes-Benz", "Audi", "Ferrari", "Lamborghini "})
        Me.cmbMake.Location = New System.Drawing.Point(73, 3)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(124, 21)
        Me.cmbMake.TabIndex = 1
        Me.infoToolTip.SetToolTip(Me.cmbMake, "Select car make from this list")
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(73, 53)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(124, 21)
        Me.cmbYear.TabIndex = 5
        Me.infoToolTip.SetToolTip(Me.cmbYear, "Select car's year of make from this list")
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnEnter, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnReset, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnExit, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 512)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(426, 33)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btnEnter
        '
        Me.btnEnter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEnter.Location = New System.Drawing.Point(3, 3)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(136, 27)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.infoToolTip.SetToolTip(Me.btnEnter, "Click this button to populate a car's properties")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReset.Location = New System.Drawing.Point(145, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(136, 27)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.infoToolTip.SetToolTip(Me.btnReset, "Click this button to reset all input fields")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExit.Location = New System.Drawing.Point(287, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(136, 27)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.infoToolTip.SetToolTip(Me.btnExit, "Click this button to exit the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblResult, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(12, 422)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(426, 84)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'lblResult
        '
        Me.lblResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(3, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(420, 84)
        Me.lblResult.TabIndex = 11
        Me.infoToolTip.SetToolTip(Me.lblResult, "The result displays here")
        '
        'lvwResult
        '
        Me.lvwResult.CheckBoxes = True
        Me.lvwResult.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwResult.FullRowSelect = True
        Me.lvwResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwResult.HideSelection = False
        Me.lvwResult.Location = New System.Drawing.Point(12, 135)
        Me.lvwResult.MultiSelect = False
        Me.lvwResult.Name = "lvwResult"
        Me.lvwResult.Size = New System.Drawing.Size(426, 281)
        Me.lvwResult.TabIndex = 10
        Me.infoToolTip.SetToolTip(Me.lvwResult, "This list viewer display all car objects with their properties")
        Me.lvwResult.UseCompatibleStateImageBehavior = False
        Me.lvwResult.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 48
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 63
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 85
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 77
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 67
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 78
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(450, 546)
        Me.Controls.Add(Me.lvwResult)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(466, 585)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(466, 585)
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory "
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents chkStatus As CheckBox
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents infoToolTip As ToolTip
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblResult As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents lvwResult As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
End Class
