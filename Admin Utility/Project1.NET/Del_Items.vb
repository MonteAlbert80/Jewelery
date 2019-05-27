Option Strict Off
Option Explicit On
Friend Class Form19
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
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form19))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.Combo1 = New System.Windows.Forms.ComboBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.Text = "Form19"
		Me.ClientSize = New System.Drawing.Size(352, 231)
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
		Me.Name = "Form19"
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command3.Text = "Back"
		Me.Command3.Size = New System.Drawing.Size(129, 25)
		Me.Command3.Location = New System.Drawing.Point(200, 176)
		Me.Command3.TabIndex = 4
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
		Me.Command2.Text = "Restore"
		Me.Command2.Size = New System.Drawing.Size(129, 25)
		Me.Command2.Location = New System.Drawing.Point(32, 176)
		Me.Command2.TabIndex = 3
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
		Me.Command1.Text = "View Info"
		Me.Command1.Size = New System.Drawing.Size(129, 25)
		Me.Command1.Location = New System.Drawing.Point(200, 80)
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
		Me.Combo1.Size = New System.Drawing.Size(121, 21)
		Me.Combo1.Location = New System.Drawing.Point(160, 40)
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
		Me.Label1.Text = "Item Code"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(88, 40)
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
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(Combo1)
		Me.Controls.Add(Label1)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As Form19
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Form19
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Form19()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		If Combo1.SelectedIndex >= 0 Then
			Form6.DefInstance.Show()
			
			Form1.DefInstance.RS.Open("Select * from ditem where code = '" & VB6.GetItemString(Combo1, Combo1.SelectedIndex) & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
			
			Form6.DefInstance.Text1.Text = Form1.DefInstance.RS.Fields("code").Value
			Form6.DefInstance.Text2.Text = Form1.DefInstance.RS.Fields("name").Value
			
			Form6.DefInstance.Text3.Text = Form1.DefInstance.RS.Fields("quantity").Value
			Form6.DefInstance.Text4.Text = Form1.DefInstance.RS.Fields("price").Value
			
			Form6.DefInstance.Text5.Text = Form1.DefInstance.RS.Fields("discount").Value
			Form6.DefInstance.Text6.Text = Form1.DefInstance.RS.Fields("category").Value
			
			Form6.DefInstance.Text7.Text = Form1.DefInstance.RS.Fields("description").Value
			Form6.DefInstance.Text8.Text = Form1.DefInstance.RS.Fields("image_path").Value
			
			Form6.DefInstance.Check1.CheckState = Form1.DefInstance.RS.Fields("main").Value
			
			Form1.DefInstance.RS.Close()
			Form6.DefInstance.Command3.Visible = False
			
			Form6.DefInstance.Text1.ReadOnly = True
			Form6.DefInstance.Text2.ReadOnly = True
			Form6.DefInstance.Text3.ReadOnly = True
			Form6.DefInstance.Text4.ReadOnly = True
			
			Form6.DefInstance.Text5.ReadOnly = True
			Form6.DefInstance.Text6.ReadOnly = True
			Form6.DefInstance.Text7.ReadOnly = True
			Form6.DefInstance.Text8.ReadOnly = True
			
			Form6.DefInstance.Check1.Enabled = False
			Form6.DefInstance.Command1.Enabled = False
			
		Else
			MsgBox("First select an item", MsgBoxStyle.OKOnly, "PROMPT")
		End If
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		
		Dim qty, pe, main As Object
		Dim dis As Short
		Dim cg, ic, nm, ds As Object
		Dim ip As String
		If Combo1.SelectedIndex >= 0 Then
			
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ic. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			ic = VB6.GetItemString(Combo1, Combo1.SelectedIndex)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ic. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			Form1.DefInstance.RS.Open("Select * from ditem where code = '" & ic & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
			
			'UPGRADE_WARNING: Couldn't resolve default property of object nm. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			nm = Form1.DefInstance.RS.Fields("name").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object cg. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			cg = Form1.DefInstance.RS.Fields("category").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object ds. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			ds = Form1.DefInstance.RS.Fields("description").Value
			ip = Form1.DefInstance.RS.Fields("image_path").Value
			
			'UPGRADE_WARNING: Couldn't resolve default property of object pe. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			pe = Form1.DefInstance.RS.Fields("price").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object qty. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			qty = Form1.DefInstance.RS.Fields("quantity").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object main. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			main = Form1.DefInstance.RS.Fields("main").Value
			dis = Form1.DefInstance.RS.Fields("discount").Value
			
			Form1.DefInstance.RS.Close()
			
			'UPGRADE_WARNING: Couldn't resolve default property of object ic. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			Form1.DefInstance.OBJ.Execute("Delete * from ditem where code = '" & ic & "' ")
			
			'UPGRADE_WARNING: Couldn't resolve default property of object main. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ds. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object cg. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object pe. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object nm. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object qty. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ic. Click for more: 'ms-help://MS.VSCC/commoner/redir/redirect.htm?keyword="vbup1037"'
			Form1.DefInstance.OBJ.Execute("Insert into item values ('" & ic & "','" & qty & "','" & nm & "','" & pe & "','" & dis & "','" & cg & "','" & ds & "','" & ip & "','" & main & "')")
			
			MsgBox("Item Restored", MsgBoxStyle.OKOnly, "PROMPT")
			
			Combo1.Items.Clear()
			
			Form1.DefInstance.RS.Open("Select code from ditem", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
			
			While Not Form1.DefInstance.RS.EOF
				Combo1.Items.Add(Form1.DefInstance.RS.Fields("code").Value)
				Form1.DefInstance.RS.MoveNext()
			End While
			
			Form1.DefInstance.RS.Close()
			
		Else
			
			
		End If
		
		
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Form4.DefInstance.Show()
		Form19.DefInstance.Close()
	End Sub
End Class