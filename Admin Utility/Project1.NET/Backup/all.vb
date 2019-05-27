Option Strict Off
Option Explicit On
Friend Class Form10
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Text4 As System.Windows.Forms.TextBox
	Public WithEvents Text5 As System.Windows.Forms.TextBox
	Public WithEvents Text6 As System.Windows.Forms.TextBox
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Text7 As System.Windows.Forms.TextBox
	Public WithEvents Text11 As System.Windows.Forms.TextBox
	Public WithEvents Text10 As System.Windows.Forms.TextBox
	Public WithEvents Text8 As System.Windows.Forms.TextBox
	Public WithEvents Text9 As System.Windows.Forms.TextBox
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form10))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Command4 = New System.Windows.Forms.Button
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Combo1 = New System.Windows.Forms.ComboBox
		Me.Text2 = New System.Windows.Forms.TextBox
		Me.Text3 = New System.Windows.Forms.TextBox
		Me.Text4 = New System.Windows.Forms.TextBox
		Me.Text5 = New System.Windows.Forms.TextBox
		Me.Text6 = New System.Windows.Forms.TextBox
		Me.Label16 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Text7 = New System.Windows.Forms.TextBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.Text11 = New System.Windows.Forms.TextBox
		Me.Text10 = New System.Windows.Forms.TextBox
		Me.Text8 = New System.Windows.Forms.TextBox
		Me.Text9 = New System.Windows.Forms.TextBox
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Command1 = New System.Windows.Forms.Button
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.Text = "Form10"
		Me.ClientSize = New System.Drawing.Size(456, 573)
		Me.Location = New System.Drawing.Point(11, -101)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "Form10"
		Me.Command4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command4.Text = "Previous Order"
		Me.Command4.Enabled = False
		Me.Command4.Size = New System.Drawing.Size(81, 25)
		Me.Command4.Location = New System.Drawing.Point(16, 536)
		Me.Command4.TabIndex = 30
		Me.Command4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command4.BackColor = System.Drawing.SystemColors.Control
		Me.Command4.CausesValidation = True
		Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command4.TabStop = True
		Me.Command4.Name = "Command4"
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command3.Text = "Next Order"
		Me.Command3.Size = New System.Drawing.Size(81, 25)
		Me.Command3.Location = New System.Drawing.Point(328, 536)
		Me.Command3.TabIndex = 29
		Me.Command3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command3.BackColor = System.Drawing.SystemColors.Control
		Me.Command3.CausesValidation = True
		Me.Command3.Enabled = True
		Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command3.TabStop = True
		Me.Command3.Name = "Command3"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "Back"
		Me.Command2.Size = New System.Drawing.Size(81, 25)
		Me.Command2.Location = New System.Drawing.Point(176, 536)
		Me.Command2.TabIndex = 28
		Me.Command2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Frame1.Size = New System.Drawing.Size(361, 241)
		Me.Frame1.Location = New System.Drawing.Point(32, 80)
		Me.Frame1.TabIndex = 6
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.Combo1.Size = New System.Drawing.Size(81, 21)
		Me.Combo1.Location = New System.Drawing.Point(112, 24)
		Me.Combo1.TabIndex = 12
		Me.Combo1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Combo1.BackColor = System.Drawing.SystemColors.Window
		Me.Combo1.CausesValidation = True
		Me.Combo1.Enabled = True
		Me.Combo1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Combo1.IntegralHeight = True
		Me.Combo1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Combo1.Sorted = False
		Me.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.Combo1.TabStop = True
		Me.Combo1.Visible = True
		Me.Combo1.Name = "Combo1"
		Me.Text2.AutoSize = False
		Me.Text2.Enabled = False
		Me.Text2.Size = New System.Drawing.Size(177, 19)
		Me.Text2.Location = New System.Drawing.Point(112, 64)
		Me.Text2.TabIndex = 11
		Me.Text2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text2.AcceptsReturn = True
		Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text2.BackColor = System.Drawing.SystemColors.Window
		Me.Text2.CausesValidation = True
		Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text2.HideSelection = True
		Me.Text2.ReadOnly = False
		Me.Text2.Maxlength = 0
		Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text2.MultiLine = False
		Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text2.TabStop = True
		Me.Text2.Visible = True
		Me.Text2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text2.Name = "Text2"
		Me.Text3.AutoSize = False
		Me.Text3.Enabled = False
		Me.Text3.Size = New System.Drawing.Size(57, 19)
		Me.Text3.Location = New System.Drawing.Point(112, 96)
		Me.Text3.TabIndex = 10
		Me.Text3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text3.AcceptsReturn = True
		Me.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text3.BackColor = System.Drawing.SystemColors.Window
		Me.Text3.CausesValidation = True
		Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text3.HideSelection = True
		Me.Text3.ReadOnly = False
		Me.Text3.Maxlength = 0
		Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text3.MultiLine = False
		Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text3.TabStop = True
		Me.Text3.Visible = True
		Me.Text3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text3.Name = "Text3"
		Me.Text4.AutoSize = False
		Me.Text4.Enabled = False
		Me.Text4.Size = New System.Drawing.Size(81, 19)
		Me.Text4.Location = New System.Drawing.Point(136, 136)
		Me.Text4.TabIndex = 9
		Me.Text4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text4.AcceptsReturn = True
		Me.Text4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text4.BackColor = System.Drawing.SystemColors.Window
		Me.Text4.CausesValidation = True
		Me.Text4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text4.HideSelection = True
		Me.Text4.ReadOnly = False
		Me.Text4.Maxlength = 0
		Me.Text4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text4.MultiLine = False
		Me.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text4.TabStop = True
		Me.Text4.Visible = True
		Me.Text4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text4.Name = "Text4"
		Me.Text5.AutoSize = False
		Me.Text5.Enabled = False
		Me.Text5.Size = New System.Drawing.Size(41, 19)
		Me.Text5.Location = New System.Drawing.Point(112, 168)
		Me.Text5.TabIndex = 8
		Me.Text5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text5.AcceptsReturn = True
		Me.Text5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text5.BackColor = System.Drawing.SystemColors.Window
		Me.Text5.CausesValidation = True
		Me.Text5.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text5.HideSelection = True
		Me.Text5.ReadOnly = False
		Me.Text5.Maxlength = 0
		Me.Text5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text5.MultiLine = False
		Me.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text5.TabStop = True
		Me.Text5.Visible = True
		Me.Text5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text5.Name = "Text5"
		Me.Text6.AutoSize = False
		Me.Text6.Enabled = False
		Me.Text6.Size = New System.Drawing.Size(81, 19)
		Me.Text6.Location = New System.Drawing.Point(136, 200)
		Me.Text6.TabIndex = 7
		Me.Text6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text6.AcceptsReturn = True
		Me.Text6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text6.BackColor = System.Drawing.SystemColors.Window
		Me.Text6.CausesValidation = True
		Me.Text6.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text6.HideSelection = True
		Me.Text6.ReadOnly = False
		Me.Text6.Maxlength = 0
		Me.Text6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text6.MultiLine = False
		Me.Text6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text6.TabStop = True
		Me.Text6.Visible = True
		Me.Text6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text6.Name = "Text6"
		Me.Label16.Text = "per piece"
		Me.Label16.Size = New System.Drawing.Size(49, 17)
		Me.Label16.Location = New System.Drawing.Point(232, 136)
		Me.Label16.TabIndex = 33
		Me.Label16.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label16.BackColor = System.Drawing.SystemColors.Control
		Me.Label16.Enabled = True
		Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label16.UseMnemonic = True
		Me.Label16.Visible = True
		Me.Label16.AutoSize = False
		Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label16.Name = "Label16"
		Me.Label2.Text = "    Item Code"
		Me.Label2.Size = New System.Drawing.Size(73, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 24)
		Me.Label2.TabIndex = 20
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label3.Text = "     Name"
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(32, 64)
		Me.Label3.TabIndex = 19
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label4.Text = "   Quantity"
		Me.Label4.Size = New System.Drawing.Size(65, 17)
		Me.Label4.Location = New System.Drawing.Point(32, 96)
		Me.Label4.TabIndex = 18
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label5.Text = " Original Price"
		Me.Label5.Size = New System.Drawing.Size(73, 17)
		Me.Label5.Location = New System.Drawing.Point(32, 136)
		Me.Label5.TabIndex = 17
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label6.Text = "Rs"
		Me.Label6.Size = New System.Drawing.Size(25, 17)
		Me.Label6.Location = New System.Drawing.Point(112, 136)
		Me.Label6.TabIndex = 16
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label7.Text = "    Discount"
		Me.Label7.Size = New System.Drawing.Size(73, 17)
		Me.Label7.Location = New System.Drawing.Point(32, 168)
		Me.Label7.TabIndex = 15
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label8.Text = "    Amount"
		Me.Label8.Size = New System.Drawing.Size(73, 17)
		Me.Label8.Location = New System.Drawing.Point(32, 200)
		Me.Label8.TabIndex = 14
		Me.Label8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label9.Text = "Rs"
		Me.Label9.Size = New System.Drawing.Size(25, 17)
		Me.Label9.Location = New System.Drawing.Point(112, 200)
		Me.Label9.TabIndex = 13
		Me.Label9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Text7.AutoSize = False
		Me.Text7.Enabled = False
		Me.Text7.Size = New System.Drawing.Size(65, 19)
		Me.Text7.Location = New System.Drawing.Point(160, 360)
		Me.Text7.TabIndex = 4
		Me.Text7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text7.AcceptsReturn = True
		Me.Text7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text7.BackColor = System.Drawing.SystemColors.Window
		Me.Text7.CausesValidation = True
		Me.Text7.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text7.HideSelection = True
		Me.Text7.ReadOnly = False
		Me.Text7.Maxlength = 0
		Me.Text7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text7.MultiLine = False
		Me.Text7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text7.TabStop = True
		Me.Text7.Visible = True
		Me.Text7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text7.Name = "Text7"
		Me.Frame2.Size = New System.Drawing.Size(361, 193)
		Me.Frame2.Location = New System.Drawing.Point(32, 328)
		Me.Frame2.TabIndex = 3
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.Text11.AutoSize = False
		Me.Text11.Enabled = False
		Me.Text11.Size = New System.Drawing.Size(105, 19)
		Me.Text11.Location = New System.Drawing.Point(128, 152)
		Me.Text11.TabIndex = 32
		Me.Text11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text11.AcceptsReturn = True
		Me.Text11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text11.BackColor = System.Drawing.SystemColors.Window
		Me.Text11.CausesValidation = True
		Me.Text11.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text11.HideSelection = True
		Me.Text11.ReadOnly = False
		Me.Text11.Maxlength = 0
		Me.Text11.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text11.MultiLine = False
		Me.Text11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text11.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text11.TabStop = True
		Me.Text11.Visible = True
		Me.Text11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text11.Name = "Text11"
		Me.Text10.AutoSize = False
		Me.Text10.Enabled = False
		Me.Text10.Size = New System.Drawing.Size(105, 19)
		Me.Text10.Location = New System.Drawing.Point(128, 120)
		Me.Text10.TabIndex = 27
		Me.Text10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text10.AcceptsReturn = True
		Me.Text10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text10.BackColor = System.Drawing.SystemColors.Window
		Me.Text10.CausesValidation = True
		Me.Text10.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text10.HideSelection = True
		Me.Text10.ReadOnly = False
		Me.Text10.Maxlength = 0
		Me.Text10.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text10.MultiLine = False
		Me.Text10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text10.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text10.TabStop = True
		Me.Text10.Visible = True
		Me.Text10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text10.Name = "Text10"
		Me.Text8.AutoSize = False
		Me.Text8.Enabled = False
		Me.Text8.Size = New System.Drawing.Size(105, 19)
		Me.Text8.Location = New System.Drawing.Point(128, 88)
		Me.Text8.TabIndex = 25
		Me.Text8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text8.AcceptsReturn = True
		Me.Text8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text8.BackColor = System.Drawing.SystemColors.Window
		Me.Text8.CausesValidation = True
		Me.Text8.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text8.HideSelection = True
		Me.Text8.ReadOnly = False
		Me.Text8.Maxlength = 0
		Me.Text8.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text8.MultiLine = False
		Me.Text8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text8.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text8.TabStop = True
		Me.Text8.Visible = True
		Me.Text8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text8.Name = "Text8"
		Me.Text9.AutoSize = False
		Me.Text9.Enabled = False
		Me.Text9.Size = New System.Drawing.Size(81, 19)
		Me.Text9.Location = New System.Drawing.Point(144, 56)
		Me.Text9.TabIndex = 22
		Me.Text9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text9.AcceptsReturn = True
		Me.Text9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text9.BackColor = System.Drawing.SystemColors.Window
		Me.Text9.CausesValidation = True
		Me.Text9.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text9.HideSelection = True
		Me.Text9.ReadOnly = False
		Me.Text9.Maxlength = 0
		Me.Text9.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text9.MultiLine = False
		Me.Text9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text9.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text9.TabStop = True
		Me.Text9.Visible = True
		Me.Text9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text9.Name = "Text9"
		Me.Label15.Text = "    Status"
		Me.Label15.Size = New System.Drawing.Size(65, 17)
		Me.Label15.Location = New System.Drawing.Point(40, 152)
		Me.Label15.TabIndex = 31
		Me.Label15.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label15.BackColor = System.Drawing.SystemColors.Control
		Me.Label15.Enabled = True
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label15.UseMnemonic = True
		Me.Label15.Visible = True
		Me.Label15.AutoSize = False
		Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label15.Name = "Label15"
		Me.Label14.Text = " Delivery Date"
		Me.Label14.Size = New System.Drawing.Size(73, 17)
		Me.Label14.Location = New System.Drawing.Point(32, 120)
		Me.Label14.TabIndex = 26
		Me.Label14.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label14.BackColor = System.Drawing.SystemColors.Control
		Me.Label14.Enabled = True
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.UseMnemonic = True
		Me.Label14.Visible = True
		Me.Label14.AutoSize = False
		Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label14.Name = "Label14"
		Me.Label11.Text = " Ordering Date"
		Me.Label11.Size = New System.Drawing.Size(73, 17)
		Me.Label11.Location = New System.Drawing.Point(32, 88)
		Me.Label11.TabIndex = 24
		Me.Label11.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.Enabled = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = False
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Label13.Text = "Rs"
		Me.Label13.Size = New System.Drawing.Size(25, 17)
		Me.Label13.Location = New System.Drawing.Point(120, 56)
		Me.Label13.TabIndex = 23
		Me.Label13.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label13.BackColor = System.Drawing.SystemColors.Control
		Me.Label13.Enabled = True
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.UseMnemonic = True
		Me.Label13.Visible = True
		Me.Label13.AutoSize = False
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label13.Name = "Label13"
		Me.Label12.Text = "Total Amount"
		Me.Label12.Size = New System.Drawing.Size(73, 17)
		Me.Label12.Location = New System.Drawing.Point(32, 56)
		Me.Label12.TabIndex = 21
		Me.Label12.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label12.BackColor = System.Drawing.SystemColors.Control
		Me.Label12.Enabled = True
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.UseMnemonic = True
		Me.Label12.Visible = True
		Me.Label12.AutoSize = False
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.Name = "Label12"
		Me.Label10.Text = "   Order #"
		Me.Label10.Size = New System.Drawing.Size(57, 17)
		Me.Label10.Location = New System.Drawing.Point(40, 32)
		Me.Label10.TabIndex = 5
		Me.Label10.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "View Customer's Info"
		Me.Command1.Size = New System.Drawing.Size(89, 33)
		Me.Command1.Location = New System.Drawing.Point(280, 32)
		Me.Command1.TabIndex = 2
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Text1.AutoSize = False
		Me.Text1.Enabled = False
		Me.Text1.Size = New System.Drawing.Size(81, 19)
		Me.Text1.Location = New System.Drawing.Point(144, 40)
		Me.Text1.TabIndex = 0
		Me.Text1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.BackColor = System.Drawing.SystemColors.Window
		Me.Text1.CausesValidation = True
		Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text1.HideSelection = True
		Me.Text1.ReadOnly = False
		Me.Text1.Maxlength = 0
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.MultiLine = False
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text1.TabStop = True
		Me.Text1.Visible = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text1.Name = "Text1"
		Me.Label1.Text = "    User Id"
		Me.Label1.Size = New System.Drawing.Size(57, 17)
		Me.Label1.Location = New System.Drawing.Point(48, 40)
		Me.Label1.TabIndex = 1
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(Command4)
		Me.Controls.Add(Command3)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Text7)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Text1)
		Me.Controls.Add(Label1)
		Me.Frame1.Controls.Add(Combo1)
		Me.Frame1.Controls.Add(Text2)
		Me.Frame1.Controls.Add(Text3)
		Me.Frame1.Controls.Add(Text4)
		Me.Frame1.Controls.Add(Text5)
		Me.Frame1.Controls.Add(Text6)
		Me.Frame1.Controls.Add(Label16)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label8)
		Me.Frame1.Controls.Add(Label9)
		Me.Frame2.Controls.Add(Text11)
		Me.Frame2.Controls.Add(Text10)
		Me.Frame2.Controls.Add(Text8)
		Me.Frame2.Controls.Add(Text9)
		Me.Frame2.Controls.Add(Label15)
		Me.Frame2.Controls.Add(Label14)
		Me.Frame2.Controls.Add(Label11)
		Me.Frame2.Controls.Add(Label13)
		Me.Frame2.Controls.Add(Label12)
		Me.Frame2.Controls.Add(Label10)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As Form10
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Form10
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Form10()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	'UPGRADE_WARNING: Event Combo1.SelectedIndexChanged may fire when form is intialized. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo1.SelectedIndexChanged
		Dim code As String
		If Combo1.SelectedIndex >= 0 Then
			
			code = VB6.GetItemString(Combo1, Combo1.SelectedIndex)
			
			Form1.DefInstance.RS.Open("select * from item_in_order where item_code = '" & code & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
			
			Text3.Text = Form1.DefInstance.RS.Fields("quantity").Value
			Text4.Text = Form1.DefInstance.RS.Fields("price").Value
			Text5.Text = Form1.DefInstance.RS.Fields("discount").Value
			
			Text6.Text = CStr(Val(Text4.Text) - (Val(Text4.Text) / Val(Text5.Text)))
			Form1.DefInstance.RS.Close()
			
			Form1.DefInstance.RS.Open("select name from item where code = '" & code & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
			Text2.Text = Form1.DefInstance.RS.Fields("name").Value
			Form1.DefInstance.RS.Close()
			
		End If
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Form13.DefInstance.Show()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		
		If Form11.DefInstance.Combo4.SelectedIndex >= 0 Then
			Form10.DefInstance.Close()
		Else
			Form3.DefInstance.Show()
			Form10.DefInstance.Close()
		End If
		
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		
		Command4.Enabled = True
		
		Dim num As String
		
		num = CStr(Val(Text7.Text))
		
		Form1.DefInstance.RS.Open("select * from order_info where number > '" & num & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
		
		If Form1.DefInstance.RS.EOF = True Then
			'Command3.Enabled = False
			MsgBox("No More Orders", MsgBoxStyle.OKOnly, "PROMPT")
		Else
			Text1.Text = Form1.DefInstance.RS.Fields("user_id").Value
			
			Text7.Text = Form1.DefInstance.RS.Fields("number").Value
			
			Text9.Text = Form1.DefInstance.RS.Fields("dis_price").Value
			
			Text8.Text = Form1.DefInstance.RS.Fields("date").Value
			
			Text10.Text = Form1.DefInstance.RS.Fields("del_date").Value
			
			Text11.Text = Form1.DefInstance.RS.Fields("status").Value
			
			
			
			Form1.DefInstance.RS.Close()
			
			Form1.DefInstance.RS.Open("select item_code from item_in_order where number = '" & Text7.Text & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
			
			Combo1.Items.Clear()
			
			Text2.Text = ""
			Text3.Text = ""
			Text4.Text = ""
			Text5.Text = ""
			Text6.Text = ""
			
			
			While Not Form1.DefInstance.RS.EOF
				
				Combo1.Items.Add(Form1.DefInstance.RS.Fields("item_code").Value)
				Form1.DefInstance.RS.MoveNext()
			End While
			
		End If
		
		Form1.DefInstance.RS.Close()
		
		
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		
		Command3.Enabled = True
		
		Dim num As String
		
		num = CStr(Val(Text7.Text))
		
		Form1.DefInstance.RS.Open("select * from order_info where number < '" & num & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
		
		If Form1.DefInstance.RS.EOF = True Then
			'Command4.Enabled = False
			MsgBox("No More Orders", MsgBoxStyle.OKOnly, "PROMPT")
		Else
			
			Form1.DefInstance.RS.MoveLast()
			
			Text1.Text = Form1.DefInstance.RS.Fields("user_id").Value
			
			Text7.Text = Form1.DefInstance.RS.Fields("number").Value
			
			Text9.Text = Form1.DefInstance.RS.Fields("dis_price").Value
			
			Text8.Text = Form1.DefInstance.RS.Fields("date").Value
			
			Text10.Text = Form1.DefInstance.RS.Fields("del_date").Value
			
			Text11.Text = Form1.DefInstance.RS.Fields("status").Value
			
			
			
			Form1.DefInstance.RS.Close()
			
			Form1.DefInstance.RS.Open("select item_code from item_in_order where number = '" & Text7.Text & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
			
			Combo1.Items.Clear()
			
			Text2.Text = ""
			Text3.Text = ""
			Text4.Text = ""
			Text5.Text = ""
			Text6.Text = ""
			
			
			While Not Form1.DefInstance.RS.EOF
				
				Combo1.Items.Add(Form1.DefInstance.RS.Fields("item_code").Value)
				Form1.DefInstance.RS.MoveNext()
			End While
			
		End If
		
		Form1.DefInstance.RS.Close()
		
	End Sub
End Class