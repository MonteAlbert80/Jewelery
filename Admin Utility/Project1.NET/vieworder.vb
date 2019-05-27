Option Strict Off
Option Explicit On
Friend Class Form3
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
	Public WithEvents Command5 As System.Windows.Forms.Button
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form3))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Command5 = New System.Windows.Forms.Button
		Me.Command4 = New System.Windows.Forms.Button
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.Text = "Form3"
		Me.ClientSize = New System.Drawing.Size(381, 354)
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
		Me.Name = "Form3"
		Me.Command5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command5.Text = "&Modify Status of order(s)"
		Me.Command5.Size = New System.Drawing.Size(193, 33)
		Me.Command5.Location = New System.Drawing.Point(88, 224)
		Me.Command5.TabIndex = 4
		Me.Command5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command5.BackColor = System.Drawing.SystemColors.Control
		Me.Command5.CausesValidation = True
		Me.Command5.Enabled = True
		Me.Command5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command5.TabStop = True
		Me.Command5.Name = "Command5"
		Me.Command4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command4.Text = "View &Orders by Search"
		Me.Command4.Size = New System.Drawing.Size(193, 33)
		Me.Command4.Location = New System.Drawing.Point(88, 160)
		Me.Command4.TabIndex = 3
		Me.Command4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command4.BackColor = System.Drawing.SystemColors.Control
		Me.Command4.CausesValidation = True
		Me.Command4.Enabled = True
		Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command4.TabStop = True
		Me.Command4.Name = "Command4"
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command3.Text = "View &All Orders"
		Me.Command3.Size = New System.Drawing.Size(193, 33)
		Me.Command3.Location = New System.Drawing.Point(88, 96)
		Me.Command3.TabIndex = 2
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
		Me.Command2.Text = "&View New Orders"
		Me.Command2.Size = New System.Drawing.Size(193, 33)
		Me.Command2.Location = New System.Drawing.Point(88, 32)
		Me.Command2.TabIndex = 1
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
		Me.Command1.Text = "Back"
		Me.Command1.Size = New System.Drawing.Size(81, 33)
		Me.Command1.Location = New System.Drawing.Point(144, 296)
		Me.Command1.TabIndex = 0
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Controls.Add(Command5)
		Me.Controls.Add(Command4)
		Me.Controls.Add(Command3)
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As Form3
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Form3
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Form3()
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
		Form3.DefInstance.Close()
		Form1.DefInstance.Show()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		
		Dim state As String
		state = "Just-Received"
		
		Form1.DefInstance.RS.Open("select * from order_info where status = '" & state & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
		
		Form9.DefInstance.Text1.Text = Form1.DefInstance.RS.Fields("user_id").Value
		
		Form9.DefInstance.Text7.Text = Form1.DefInstance.RS.Fields("number").Value
		
		Form9.DefInstance.Text9.Text = Form1.DefInstance.RS.Fields("dis_price").Value
		
		Form9.DefInstance.Text8.Text = Form1.DefInstance.RS.Fields("date").Value
		
		Form9.DefInstance.Text10.Text = Form1.DefInstance.RS.Fields("del_date").Value
		
		'Form10.Text11.Text = Form1.RS.Fields("status")
		
		'Form10.Command3.Enabled = False
		
		Dim num As String
		num = Form1.DefInstance.RS.Fields("number").Value
		
		Form1.DefInstance.RS.Close()
		
		Form1.DefInstance.RS.Open("select item_code from item_in_order where number = '" & num & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
		
		While Not Form1.DefInstance.RS.EOF
			
			Form9.DefInstance.Combo1.Items.Add(Form1.DefInstance.RS.Fields("item_code").Value)
			Form1.DefInstance.RS.MoveNext()
		End While
		
		Form1.DefInstance.RS.Close()
		
		
		Form9.DefInstance.Show()
		Form3.DefInstance.Hide()
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		
		Form1.DefInstance.RS.Open("select * from order_info", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
		
		Form10.DefInstance.Text1.Text = Form1.DefInstance.RS.Fields("user_id").Value
		
		Form10.DefInstance.Text7.Text = Form1.DefInstance.RS.Fields("number").Value
		
		Form10.DefInstance.Text9.Text = Form1.DefInstance.RS.Fields("dis_price").Value
		
		Form10.DefInstance.Text8.Text = Form1.DefInstance.RS.Fields("date").Value
		
		Form10.DefInstance.Text10.Text = Form1.DefInstance.RS.Fields("del_date").Value
		
		Form10.DefInstance.Text11.Text = Form1.DefInstance.RS.Fields("status").Value
		
		'Form10.Command3.Enabled = False
		Dim num As String
		num = Form1.DefInstance.RS.Fields("number").Value
		
		Form1.DefInstance.RS.Close()
		
		Form1.DefInstance.RS.Open("select item_code from item_in_order where number = '" & num & "' ", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
		
		While Not Form1.DefInstance.RS.EOF
			
			Form10.DefInstance.Combo1.Items.Add(Form1.DefInstance.RS.Fields("item_code").Value)
			Form1.DefInstance.RS.MoveNext()
		End While
		Form1.DefInstance.RS.Close()
		
		Form10.DefInstance.Show()
		Form3.DefInstance.Hide()
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Form11.DefInstance.Show()
		Form3.DefInstance.Hide()
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		
		Form12.DefInstance.Combo1.Items.Clear()
		Form1.DefInstance.RS.Open("select number from order_info", Form1.DefInstance.OBJ, ADODB.CursorTypeEnum.adOpenDynamic)
		
		While Not Form1.DefInstance.RS.EOF
			Form12.DefInstance.Combo1.Items.Add(Form1.DefInstance.RS.Fields("number").Value)
			Form1.DefInstance.RS.MoveNext()
		End While
		Form1.DefInstance.RS.Close()
		
		Form12.DefInstance.Combo2.Items.Clear()
		Form12.DefInstance.Combo2.Items.Insert(0, "Just-Received")
		Form12.DefInstance.Combo2.Items.Insert(1, "In-Process")
		Form12.DefInstance.Combo2.Items.Insert(2, "Delivered")
		
		Form12.DefInstance.Show()
		Form3.DefInstance.Close()
	End Sub
End Class