Option Strict Off
Option Explicit On
Friend Class Form20
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
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Option3 As System.Windows.Forms.RadioButton
	Public WithEvents Option2 As System.Windows.Forms.RadioButton
	Public WithEvents Option1 As System.Windows.Forms.RadioButton
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form20))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.Text3 = New System.Windows.Forms.TextBox
		Me.Option3 = New System.Windows.Forms.RadioButton
		Me.Option2 = New System.Windows.Forms.RadioButton
		Me.Option1 = New System.Windows.Forms.RadioButton
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.Combo1 = New System.Windows.Forms.ComboBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Text = "Form20"
		Me.ClientSize = New System.Drawing.Size(411, 321)
		Me.Location = New System.Drawing.Point(4, 23)
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
		Me.Name = "Form20"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "Back"
		Me.Command2.Size = New System.Drawing.Size(121, 25)
		Me.Command2.Location = New System.Drawing.Point(224, 248)
		Me.Command2.TabIndex = 10
		Me.Command2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "OK"
		Me.Command1.Size = New System.Drawing.Size(121, 25)
		Me.Command1.Location = New System.Drawing.Point(64, 248)
		Me.Command1.TabIndex = 9
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Text3.AutoSize = False
		Me.Text3.Size = New System.Drawing.Size(185, 19)
		Me.Text3.Location = New System.Drawing.Point(152, 176)
		Me.Text3.TabIndex = 7
		Me.Text3.Visible = False
		Me.Text3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text3.AcceptsReturn = True
		Me.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text3.BackColor = System.Drawing.SystemColors.Window
		Me.Text3.CausesValidation = True
		Me.Text3.Enabled = True
		Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text3.HideSelection = True
		Me.Text3.ReadOnly = False
		Me.Text3.Maxlength = 0
		Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text3.MultiLine = False
		Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text3.TabStop = True
		Me.Text3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text3.Name = "Text3"
		Me.Option3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option3.Text = "Modify"
		Me.Option3.Size = New System.Drawing.Size(57, 25)
		Me.Option3.Location = New System.Drawing.Point(296, 32)
		Me.Option3.TabIndex = 6
		Me.Option3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Option3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option3.BackColor = System.Drawing.SystemColors.Control
		Me.Option3.CausesValidation = True
		Me.Option3.Enabled = True
		Me.Option3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Option3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Option3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Option3.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Option3.TabStop = True
		Me.Option3.Checked = False
		Me.Option3.Visible = True
		Me.Option3.Name = "Option3"
		Me.Option2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option2.Text = "Remove"
		Me.Option2.Size = New System.Drawing.Size(65, 25)
		Me.Option2.Location = New System.Drawing.Point(168, 32)
		Me.Option2.TabIndex = 5
		Me.Option2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Option2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option2.BackColor = System.Drawing.SystemColors.Control
		Me.Option2.CausesValidation = True
		Me.Option2.Enabled = True
		Me.Option2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Option2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Option2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Option2.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Option2.TabStop = True
		Me.Option2.Checked = False
		Me.Option2.Visible = True
		Me.Option2.Name = "Option2"
		Me.Option1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option1.Text = "ADD"
		Me.Option1.Size = New System.Drawing.Size(49, 25)
		Me.Option1.Location = New System.Drawing.Point(56, 32)
		Me.Option1.TabIndex = 4
		Me.Option1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Option1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Option1.BackColor = System.Drawing.SystemColors.Control
		Me.Option1.CausesValidation = True
		Me.Option1.Enabled = True
		Me.Option1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Option1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Option1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Option1.Appearance = System.Windows.Forms.Appearance.Normal
		Me.Option1.TabStop = True
		Me.Option1.Checked = False
		Me.Option1.Visible = True
		Me.Option1.Name = "Option1"
		Me.Text1.AutoSize = False
		Me.Text1.Size = New System.Drawing.Size(185, 19)
		Me.Text1.Location = New System.Drawing.Point(152, 136)
		Me.Text1.TabIndex = 3
		Me.Text1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.BackColor = System.Drawing.SystemColors.Window
		Me.Text1.CausesValidation = True
		Me.Text1.Enabled = True
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
		Me.Combo1.Size = New System.Drawing.Size(185, 21)
		Me.Combo1.Location = New System.Drawing.Point(152, 88)
		Me.Combo1.TabIndex = 1
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
		Me.Label3.Size = New System.Drawing.Size(73, 17)
		Me.Label3.Location = New System.Drawing.Point(48, 176)
		Me.Label3.TabIndex = 8
		Me.Label3.Visible = False
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "URL"
		Me.Label2.Size = New System.Drawing.Size(25, 17)
		Me.Label2.Location = New System.Drawing.Point(80, 136)
		Me.Label2.TabIndex = 2
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
		Me.Label1.Text = "Name"
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.Location = New System.Drawing.Point(72, 88)
		Me.Label1.TabIndex = 0
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
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Text3)
		Me.Controls.Add(Option3)
		Me.Controls.Add(Option2)
		Me.Controls.Add(Option1)
		Me.Controls.Add(Text1)
		Me.Controls.Add(Combo1)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As Form20
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Form20
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Form20()
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
		If Combo1.SelectedIndex >= 0 Then
			Form1.DefInstance.RS.Open("Select link from rlink where name = '" & Combo1.Text & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
			Text1.Text = Form1.DefInstance.RS.Fields("link").Value
			Form1.DefInstance.RS.Close()
		End If
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		
		Dim occur As Short
		If Option1.Checked = True Then
			
			If Text1.Text = "" Or Text3.Text = "" Then
				MsgBox("First fill the required field", MsgBoxStyle.OKOnly, "PROMPT")
			Else
				
				
				occur = InStr(Text1.Text, ".")
				
				If occur = 0 Then
					MsgBox("Not a valid URL", MsgBoxStyle.OKOnly, "PROMPT")
				Else
					Form1.DefInstance.RS.Open("Select link from rlink where name = '" & Text3.Text & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
					
					If Form1.DefInstance.RS.EOF Then
						Form1.DefInstance.RS.Close()
						Form1.DefInstance.OBJ.Execute("insert into rlink values('" & Text3.Text & "','" & Text1.Text & "') ")
						MsgBox("Link Inserted", MsgBoxStyle.OKOnly, "PROMPT")
						Text1.Text = ""
						Text3.Text = ""
					Else
						MsgBox("Link Already Exists.", MsgBoxStyle.OKOnly, "PROMPT")
					End If
					
				End If
				
			End If
			
		End If
		
		If Option2.Checked = True Then
			
			If Combo1.SelectedIndex >= 0 Then
				Form1.DefInstance.OBJ.Execute("Delete * from rlink where name = '" & Combo1.Text & "' ")
				MsgBox("Link Deleted", MsgBoxStyle.OKOnly, "PROMPT")
				Text1.Text = ""
				Text3.Text = ""
			Else
				MsgBox("First Select a Name", MsgBoxStyle.OKOnly, "PROMPT")
			End If
			
		End If
		
		If Option3.Checked = True Then
			
			If Combo1.SelectedIndex >= 0 Then
				
				If Text1.Text = "" Or Text3.Text = "" Then
					MsgBox("First Fill the Required Fields", MsgBoxStyle.OKOnly, "PROMPT")
				Else
					Form1.DefInstance.OBJ.Execute("delete * from rlink where name = '" & Combo1.Text & "'")
					Form1.DefInstance.OBJ.Execute("insert into rlink values('" & Text3.Text & "','" & Text1.Text & "') ")
					MsgBox("Link Modified", MsgBoxStyle.OKOnly, "PROMPT")
					Text1.Text = ""
					Text3.Text = ""
				End If
				
			Else
				MsgBox("First Select a name", MsgBoxStyle.OKOnly, "PROMPT")
			End If
			
		End If
		
		If Option1.Checked = True Or Option2.Checked = True Or Option3.Checked = True Then
			Combo1.Items.Clear()
			Form1.DefInstance.RS.Open("Select name from rlink", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
			While Not Form1.DefInstance.RS.EOF
				Combo1.Items.Add(Form1.DefInstance.RS.Fields("name").Value)
				Form1.DefInstance.RS.MoveNext()
			End While
			Form1.DefInstance.RS.Close()
			
		End If
		
		
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Form20.DefInstance.Close()
		Form16.DefInstance.Show()
	End Sub
	
	'UPGRADE_WARNING: Event Option1.CheckedChanged may fire when form is intialized. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub Option1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option1.CheckedChanged
		If eventSender.Checked Then
			
			'If Option1.Value = False Then
			'Text3.Text = ""
			'Text3.Visible = False
			'Combo1.Enabled = True
			'Label3.Visible = False
			'Label1.Enabled = False
			'Else
			Text1.Text = ""
			Text3.Text = ""
			
			Text3.Visible = True
			Text1.Visible = True
			Combo1.Enabled = False
			Label3.Visible = True
			Label3.Text = "New Name"
			Text1.Enabled = True
			
			'End If
			
		End If
	End Sub
	
	'UPGRADE_WARNING: Event Option2.CheckedChanged may fire when form is intialized. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub Option2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option2.CheckedChanged
		If eventSender.Checked Then
			
			'If Option2.Value = False Then
			'Text3.Text = ""
			'Text3.Visible = False
			'Combo1.Enabled = True
			'Text1.Enabled = True
			'Label3.Visible = False
			'Label1.Enabled = False
			'Else
			Text3.Visible = False
			Text1.Enabled = False
			Combo1.Enabled = True
			Label3.Visible = False
			'Label3.Caption = "Name"
			'End If
			
		End If
	End Sub
	
	'UPGRADE_WARNING: Event Option3.CheckedChanged may fire when form is intialized. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub Option3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option3.CheckedChanged
		If eventSender.Checked Then
			
			'If Option3.Value = False Then
			'Text3.Text = ""
			Text3.Visible = True
			'Combo1.Enabled = True
			'Text1.Enabled = True
			Label3.Visible = True
			'Label1.Enabled = False
			'Else
			'Text3.Visible = False
			Text1.Enabled = True
			Combo1.Enabled = True
			Label3.Visible = True
			Label3.Text = "New Name"
			'End If
			
		End If
	End Sub
End Class