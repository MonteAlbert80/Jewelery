Option Strict Off
Option Explicit On
Friend Class Form11
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
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Combo4 As System.Windows.Forms.ComboBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Combo2 As System.Windows.Forms.ComboBox
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form11))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Command3 = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Command2 = New System.Windows.Forms.Button
		Me.Combo4 = New System.Windows.Forms.ComboBox
		Me.Label4 = New System.Windows.Forms.Label
		Me.Command1 = New System.Windows.Forms.Button
		Me.Combo2 = New System.Windows.Forms.ComboBox
		Me.Combo1 = New System.Windows.Forms.ComboBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Text = "Form11"
		Me.ClientSize = New System.Drawing.Size(417, 441)
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
		Me.Name = "Form11"
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command3.Text = "Search"
		Me.Command3.Size = New System.Drawing.Size(105, 25)
		Me.Command3.Location = New System.Drawing.Point(152, 160)
		Me.Command3.TabIndex = 9
		Me.Command3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command3.BackColor = System.Drawing.SystemColors.Control
		Me.Command3.CausesValidation = True
		Me.Command3.Enabled = True
		Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command3.TabStop = True
		Me.Command3.Name = "Command3"
		Me.Frame1.Size = New System.Drawing.Size(337, 121)
		Me.Frame1.Location = New System.Drawing.Point(48, 208)
		Me.Frame1.TabIndex = 5
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "View Record"
		Me.Command2.Size = New System.Drawing.Size(185, 25)
		Me.Command2.Location = New System.Drawing.Point(72, 72)
		Me.Command2.TabIndex = 8
		Me.Command2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Combo4.Size = New System.Drawing.Size(161, 21)
		Me.Combo4.Location = New System.Drawing.Point(144, 24)
		Me.Combo4.TabIndex = 7
		Me.Combo4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Combo4.BackColor = System.Drawing.SystemColors.Window
		Me.Combo4.CausesValidation = True
		Me.Combo4.Enabled = True
		Me.Combo4.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Combo4.IntegralHeight = True
		Me.Combo4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Combo4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Combo4.Sorted = False
		Me.Combo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.Combo4.TabStop = True
		Me.Combo4.Visible = True
		Me.Combo4.Name = "Combo4"
		Me.Label4.Text = "Search Result(s)"
		Me.Label4.Size = New System.Drawing.Size(81, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 24)
		Me.Label4.TabIndex = 6
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
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "<<Back>>"
		Me.Command1.Size = New System.Drawing.Size(185, 25)
		Me.Command1.Location = New System.Drawing.Point(120, 376)
		Me.Command1.TabIndex = 4
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Combo2.Size = New System.Drawing.Size(97, 21)
		Me.Combo2.Location = New System.Drawing.Point(200, 112)
		Me.Combo2.TabIndex = 3
		Me.Combo2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Combo2.BackColor = System.Drawing.SystemColors.Window
		Me.Combo2.CausesValidation = True
		Me.Combo2.Enabled = True
		Me.Combo2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Combo2.IntegralHeight = True
		Me.Combo2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Combo2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Combo2.Sorted = False
		Me.Combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.Combo2.TabStop = True
		Me.Combo2.Visible = True
		Me.Combo2.Name = "Combo2"
		Me.Combo1.Size = New System.Drawing.Size(177, 21)
		Me.Combo1.Location = New System.Drawing.Point(176, 48)
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
		Me.Label2.Text = "    User Id"
		Me.Label2.Size = New System.Drawing.Size(57, 17)
		Me.Label2.Location = New System.Drawing.Point(120, 112)
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
		Me.Label1.Text = "    Search All Orders "
		Me.Label1.Size = New System.Drawing.Size(105, 17)
		Me.Label1.Location = New System.Drawing.Point(40, 48)
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
		Me.Controls.Add(Command3)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Combo2)
		Me.Controls.Add(Combo1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Frame1.Controls.Add(Command2)
		Me.Frame1.Controls.Add(Combo4)
		Me.Frame1.Controls.Add(Label4)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As Form11
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Form11
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Form11()
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
			
			Combo4.Items.Clear()
			
			If Not Combo1.SelectedIndex <> 0 Then
				
				'Combo3.Visible = False
				'Label3.Visible = False
				
				Combo2.Enabled = True
				Label2.Text = "User Id"
				
				Form1.DefInstance.RS.Open("select id from customer", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
				
				Combo2.Items.Clear()
				
				While Not Form1.DefInstance.RS.EOF
					Combo2.Items.Add(Form1.DefInstance.RS.Fields("id").Value)
					Form1.DefInstance.RS.MoveNext()
				End While
				Form1.DefInstance.RS.Close()
				
			End If
			
			If Not Combo1.SelectedIndex <> 2 Then
				
				'Combo3.Visible = False
				'Label3.Visible = False
				
				Combo2.Enabled = True
				Label2.Text = "Status"
				
				Combo2.Items.Clear()
				Combo2.Items.Insert(0, "Just-Received")
				Combo2.Items.Insert(1, "In-Process")
				Combo2.Items.Insert(2, "Delivered")
				
			End If
			
			If Not Combo1.SelectedIndex <> 3 Then
				
				'Combo3.Visible = False
				'Label3.Visible = False
				
				Combo2.Enabled = True
				Label2.Text = "Item Code"
				
				Form1.DefInstance.RS.Open("select code from item", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
				Combo2.Items.Clear()
				
				While Not Form1.DefInstance.RS.EOF
					Combo2.Items.Add(Form1.DefInstance.RS.Fields("code").Value)
					Form1.DefInstance.RS.MoveNext()
				End While
				Form1.DefInstance.RS.Close()
				
			End If
			
			If Not Combo1.SelectedIndex <> 1 Then
				'Combo3.Visible = True
				'Label3.Visible = True
				
				Combo2.Enabled = True
				Label2.Text = "Item Code"
				
				Form1.DefInstance.RS.Open("select code from ditem ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
				Combo2.Items.Clear()
				
				While Not Form1.DefInstance.RS.EOF
					Combo2.Items.Add(Form1.DefInstance.RS.Fields("code").Value)
					Form1.DefInstance.RS.MoveNext()
				End While
				Form1.DefInstance.RS.Close()
			End If
			
		End If
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Form3.DefInstance.Show()
		Form11.DefInstance.Close()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		
		Dim num As String
		If Combo4.SelectedIndex >= 0 Then
			
			num = VB6.GetItemString(Combo4, Combo4.SelectedIndex)
			
			Form1.DefInstance.RS.Open("select * from order_info where number = '" & num & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
			
			Form10.DefInstance.Text1.Text = Form1.DefInstance.RS.Fields("user_id").Value
			
			Form10.DefInstance.Text7.Text = Form1.DefInstance.RS.Fields("number").Value
			
			Form10.DefInstance.Text9.Text = Form1.DefInstance.RS.Fields("dis_price").Value
			
			Form10.DefInstance.Text8.Text = Form1.DefInstance.RS.Fields("date").Value
			
			Form10.DefInstance.Text10.Text = Form1.DefInstance.RS.Fields("del_date").Value
			
			Form10.DefInstance.Text11.Text = Form1.DefInstance.RS.Fields("status").Value
			
			Form10.DefInstance.Command3.Enabled = False
			
			
			Form1.DefInstance.RS.Close()
			
			Form1.DefInstance.RS.Open("select item_code from item_in_order where number = '" & num & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
			
			While Not Form1.DefInstance.RS.EOF
				
				Form10.DefInstance.Combo1.Items.Add(Form1.DefInstance.RS.Fields("item_code").Value)
				Form1.DefInstance.RS.MoveNext()
			End While
			Form1.DefInstance.RS.Close()
			
			Form10.DefInstance.Show()
		Else
			MsgBox("Please select an order number", MsgBoxStyle.OKOnly, "Prompt")
		End If
		
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		
		If Combo1.SelectedIndex < 0 Then
			MsgBox("Please select a search criteria first", MsgBoxStyle.OKOnly, "Prompt")
		End If
		''''''''''''''''''''''''''''''''''
		'If Combo2.ListIndex < 0 And Combo3.Visible = False Then
		
		If Combo2.SelectedIndex < 0 Then
			
			If Combo1.SelectedIndex = 0 Then
				MsgBox("Please select a user id first", MsgBoxStyle.OKOnly, "Prompt")
			End If
			
			If Combo1.SelectedIndex = 1 Then
				MsgBox("Please select a Item Code first", MsgBoxStyle.OKOnly, "Prompt")
			End If
			
			If Combo1.SelectedIndex = 2 Then
				MsgBox("Please select a status first", MsgBoxStyle.OKOnly, "Prompt")
			End If
			
			If Combo1.SelectedIndex = 3 Then
				MsgBox("Please select an item first", MsgBoxStyle.OKOnly, "Prompt")
			End If
			
		End If
		'''''''''''''''''''''''''''''''''''''''''''''''''
		'If (Combo3.ListIndex < 0 Or Combo2.ListIndex < 0) And (Combo3.Visible = True) Then
		'MsgBox "Please select a date first", vbOKOnly, "Prompt"
		'End If
		''''''''''''''''''''''''''''''''''''''''''''''''''
		'''''''''''''''''''''''''''''''
		'If Combo2.ListIndex >= 0 And Combo3.Visible = False Then
		
		'UPGRADE_NOTE: str was upgraded to str_Renamed. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim str_Renamed As String
		If Combo2.SelectedIndex >= 0 Then
			'Dim table As String
			'Dim field As String
			
			
			If Combo1.SelectedIndex = 0 Then
				
				
				str_Renamed = VB6.GetItemString(Combo2, Combo2.SelectedIndex)
				
				Form1.DefInstance.RS.Open("select number from order_info where user_id = '" & str_Renamed & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
				
				'table = "customer"
				'field = "id"
			End If
			
			If Combo1.SelectedIndex = 1 Then
				
				str_Renamed = VB6.GetItemString(Combo2, Combo2.SelectedIndex)
				
				Form1.DefInstance.RS.Open("select number from item_in_order where item_code = '" & str_Renamed & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
				'table = "item_in_order"
				'field = "item_code"
			End If
			
			
			If Combo1.SelectedIndex = 2 Then
				
				str_Renamed = VB6.GetItemString(Combo2, Combo2.SelectedIndex)
				
				'If Combo2.ListIndex = 0 Then
				'str1 = 0
				'End If
				'If Combo2.ListIndex = 1 Then
				'str1 = 1
				'End If
				'If Combo2.ListIndex = 2 Then
				'str1 = 2
				'End If
				
				Form1.DefInstance.RS.Open("select number from order_info where status = '" & str_Renamed & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
				'table = "order"
				'field = "status"
			End If
			
			If Combo1.SelectedIndex = 3 Then
				
				str_Renamed = VB6.GetItemString(Combo2, Combo2.SelectedIndex)
				
				Form1.DefInstance.RS.Open("select number from item_in_order where item_code = '" & str_Renamed & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
				'table = "item_in_order"
				'field = "item_code"
			End If
			
			Combo4.Items.Clear()
			While Not Form1.DefInstance.RS.EOF
				Combo4.Items.Add(Form1.DefInstance.RS.Fields("number").Value)
				Form1.DefInstance.RS.MoveNext()
			End While
			Form1.DefInstance.RS.Close()
			
		End If
		''''''''''''''''''''''''''''''''''
	End Sub
	
	Private Sub Form11_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		
		Combo2.Items.Clear()
		'Combo3.Clear
		Combo4.Items.Clear()
		
		Combo1.Items.Insert(0, "By a particular customer")
		Combo1.Items.Insert(1, "By Deleted Item(s)")
		Combo1.Items.Insert(2, "By status")
		Combo1.Items.Insert(3, "that contains a particular item")
		
		
		'Combo2.AddItem "sarika", 0
		'Combo3.AddItem "yamin", 0
		
	End Sub
End Class