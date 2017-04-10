<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_rcontactnumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_rfullnameofgroom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_rfullnameofbride = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_rdateofwedding = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_rbookername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmb_rrtime = New System.Windows.Forms.ComboBox()
        Me.cmb_rptime = New System.Windows.Forms.ComboBox()
        Me.cmb_rctime = New System.Windows.Forms.ComboBox()
        Me.cmb_rgtime = New System.Windows.Forms.ComboBox()
        Me.txt_rrlocation = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_rclocation = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_rplocation = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_rglocation = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_rspecialrequestnotes = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_rnumberofguest = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmb_rstatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DeepPink
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 401)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reports"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(298, 401)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_rcontactnumber)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_address)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_rfullnameofgroom)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_rfullnameofbride)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_rdateofwedding)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_rbookername)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DeepPink
        Me.GroupBox2.Location = New System.Drawing.Point(310, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(565, 154)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "WEDDING DETAILS"
        '
        'txt_rcontactnumber
        '
        Me.txt_rcontactnumber.Location = New System.Drawing.Point(396, 105)
        Me.txt_rcontactnumber.Name = "txt_rcontactnumber"
        Me.txt_rcontactnumber.Size = New System.Drawing.Size(100, 22)
        Me.txt_rcontactnumber.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepPink
        Me.Label6.Location = New System.Drawing.Point(281, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Contact Number :"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(141, 105)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(100, 22)
        Me.txt_address.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepPink
        Me.Label5.Location = New System.Drawing.Point(26, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Address :"
        '
        'txt_rfullnameofgroom
        '
        Me.txt_rfullnameofgroom.Location = New System.Drawing.Point(396, 63)
        Me.txt_rfullnameofgroom.Name = "txt_rfullnameofgroom"
        Me.txt_rfullnameofgroom.Size = New System.Drawing.Size(100, 22)
        Me.txt_rfullnameofgroom.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepPink
        Me.Label4.Location = New System.Drawing.Point(281, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Full Name Of Groom :"
        '
        'txt_rfullnameofbride
        '
        Me.txt_rfullnameofbride.Location = New System.Drawing.Point(141, 67)
        Me.txt_rfullnameofbride.Name = "txt_rfullnameofbride"
        Me.txt_rfullnameofbride.Size = New System.Drawing.Size(100, 22)
        Me.txt_rfullnameofbride.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepPink
        Me.Label3.Location = New System.Drawing.Point(26, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Full Name Of Bride :"
        '
        'txt_rdateofwedding
        '
        Me.txt_rdateofwedding.Location = New System.Drawing.Point(396, 29)
        Me.txt_rdateofwedding.Name = "txt_rdateofwedding"
        Me.txt_rdateofwedding.Size = New System.Drawing.Size(100, 22)
        Me.txt_rdateofwedding.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepPink
        Me.Label2.Location = New System.Drawing.Point(281, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date Of Wedding :"
        '
        'txt_rbookername
        '
        Me.txt_rbookername.Location = New System.Drawing.Point(141, 29)
        Me.txt_rbookername.Name = "txt_rbookername"
        Me.txt_rbookername.Size = New System.Drawing.Size(100, 22)
        Me.txt_rbookername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepPink
        Me.Label1.Location = New System.Drawing.Point(26, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booker Name:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmb_rrtime)
        Me.GroupBox3.Controls.Add(Me.cmb_rptime)
        Me.GroupBox3.Controls.Add(Me.cmb_rctime)
        Me.GroupBox3.Controls.Add(Me.cmb_rgtime)
        Me.GroupBox3.Controls.Add(Me.txt_rrlocation)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txt_rclocation)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_rplocation)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_rglocation)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.DeepPink
        Me.GroupBox3.Location = New System.Drawing.Point(310, 201)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(565, 210)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "PHOTOCOVERAGE"
        '
        'cmb_rrtime
        '
        Me.cmb_rrtime.FormattingEnabled = True
        Me.cmb_rrtime.Items.AddRange(New Object() {"05:00AM", "06:00AM", "07:00AM", "08:00AM", "09:00AM", "10:00AM", "11:00AM", "12:00PM", "01:00PM", "02:00PM", "03:00PM", "04:00PM", "05:00PM", "06:00PM", "07:00PM", "08:00PM", "09:00PM", "10:00PM"})
        Me.cmb_rrtime.Location = New System.Drawing.Point(360, 139)
        Me.cmb_rrtime.Name = "cmb_rrtime"
        Me.cmb_rrtime.Size = New System.Drawing.Size(121, 22)
        Me.cmb_rrtime.TabIndex = 23
        '
        'cmb_rptime
        '
        Me.cmb_rptime.FormattingEnabled = True
        Me.cmb_rptime.Items.AddRange(New Object() {"05:00AM", "06:00AM", "07:00AM", "08:00AM", "09:00AM", "10:00AM", "11:00AM", "12:00PM", "01:00PM", "02:00PM", "03:00PM", "04:00PM", "05:00PM", "06:00PM", "07:00PM", "08:00PM", "09:00PM", "10:00PM"})
        Me.cmb_rptime.Location = New System.Drawing.Point(68, 144)
        Me.cmb_rptime.Name = "cmb_rptime"
        Me.cmb_rptime.Size = New System.Drawing.Size(121, 22)
        Me.cmb_rptime.TabIndex = 22
        '
        'cmb_rctime
        '
        Me.cmb_rctime.FormattingEnabled = True
        Me.cmb_rctime.Items.AddRange(New Object() {"05:00AM", "06:00AM", "07:00AM", "08:00AM", "09:00AM", "10:00AM", "11:00AM", "12:00PM", "01:00PM", "02:00PM", "03:00PM", "04:00PM", "05:00PM", "06:00PM", "07:00PM", "08:00PM", "09:00PM", "10:00PM"})
        Me.cmb_rctime.Location = New System.Drawing.Point(355, 50)
        Me.cmb_rctime.Name = "cmb_rctime"
        Me.cmb_rctime.Size = New System.Drawing.Size(121, 22)
        Me.cmb_rctime.TabIndex = 21
        '
        'cmb_rgtime
        '
        Me.cmb_rgtime.FormattingEnabled = True
        Me.cmb_rgtime.Items.AddRange(New Object() {"05:00AM", "06:00AM", "07:00AM", "08:00AM", "09:00AM", "10:00AM", "11:00AM", "12:00PM", "01:00PM", "02:00PM", "03:00PM", "04:00PM", "05:00PM", "06:00PM", "07:00PM", "08:00PM", "09:00PM", "10:00PM"})
        Me.cmb_rgtime.Location = New System.Drawing.Point(73, 53)
        Me.cmb_rgtime.Name = "cmb_rgtime"
        Me.cmb_rgtime.Size = New System.Drawing.Size(121, 22)
        Me.cmb_rgtime.TabIndex = 20
        '
        'txt_rrlocation
        '
        Me.txt_rrlocation.Location = New System.Drawing.Point(355, 167)
        Me.txt_rrlocation.Name = "txt_rrlocation"
        Me.txt_rrlocation.Size = New System.Drawing.Size(190, 22)
        Me.txt_rrlocation.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DeepPink
        Me.Label16.Location = New System.Drawing.Point(295, 170)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Location :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DeepPink
        Me.Label17.Location = New System.Drawing.Point(313, 145)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Time :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DeepPink
        Me.Label18.Location = New System.Drawing.Point(298, 119)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "RECEPTION:"
        '
        'txt_rclocation
        '
        Me.txt_rclocation.Location = New System.Drawing.Point(355, 85)
        Me.txt_rclocation.Name = "txt_rclocation"
        Me.txt_rclocation.Size = New System.Drawing.Size(190, 22)
        Me.txt_rclocation.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DeepPink
        Me.Label13.Location = New System.Drawing.Point(295, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Location :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DeepPink
        Me.Label14.Location = New System.Drawing.Point(313, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Time :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DeepPink
        Me.Label15.Location = New System.Drawing.Point(298, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "CEREMONY:"
        '
        'txt_rplocation
        '
        Me.txt_rplocation.Location = New System.Drawing.Point(68, 172)
        Me.txt_rplocation.Name = "txt_rplocation"
        Me.txt_rplocation.Size = New System.Drawing.Size(211, 22)
        Me.txt_rplocation.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DeepPink
        Me.Label10.Location = New System.Drawing.Point(8, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Location :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DeepPink
        Me.Label11.Location = New System.Drawing.Point(26, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Time :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DeepPink
        Me.Label12.Location = New System.Drawing.Point(11, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "PHOTOSHOOT:"
        '
        'txt_rglocation
        '
        Me.txt_rglocation.Location = New System.Drawing.Point(68, 82)
        Me.txt_rglocation.Name = "txt_rglocation"
        Me.txt_rglocation.Size = New System.Drawing.Size(211, 22)
        Me.txt_rglocation.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DeepPink
        Me.Label9.Location = New System.Drawing.Point(8, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Location :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DeepPink
        Me.Label8.Location = New System.Drawing.Point(26, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Time :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DeepPink
        Me.Label7.Location = New System.Drawing.Point(11, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "GETTING READY:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmb_rstatus)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txt_rspecialrequestnotes)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txt_rnumberofguest)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DeepPink
        Me.GroupBox4.Location = New System.Drawing.Point(310, 417)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(565, 90)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ADDITIONAL INFORMATION"
        '
        'txt_rspecialrequestnotes
        '
        Me.txt_rspecialrequestnotes.Location = New System.Drawing.Point(165, 60)
        Me.txt_rspecialrequestnotes.Name = "txt_rspecialrequestnotes"
        Me.txt_rspecialrequestnotes.Size = New System.Drawing.Size(380, 22)
        Me.txt_rspecialrequestnotes.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DeepPink
        Me.Label20.Location = New System.Drawing.Point(12, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(147, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Special Request / Notes :"
        '
        'txt_rnumberofguest
        '
        Me.txt_rnumberofguest.Location = New System.Drawing.Point(128, 32)
        Me.txt_rnumberofguest.Name = "txt_rnumberofguest"
        Me.txt_rnumberofguest.Size = New System.Drawing.Size(78, 22)
        Me.txt_rnumberofguest.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DeepPink
        Me.Label19.Location = New System.Drawing.Point(13, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(108, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Tag = ""
        Me.Label19.Text = "Number Of Guest :"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DeepPink
        Me.btn_update.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(12, 467)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(292, 40)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "U P D A T E"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.ToolStripMenuItem1, Me.ToolStripMenuItem3})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(887, 27)
        Me.MenuStrip2.TabIndex = 10
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(12, 23)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(85, 23)
        Me.ToolStripMenuItem1.Text = "HOME"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(115, 23)
        Me.ToolStripMenuItem3.Text = "REPORTS"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(295, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 14)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Status :"
        '
        'cmb_rstatus
        '
        Me.cmb_rstatus.FormattingEnabled = True
        Me.cmb_rstatus.Items.AddRange(New Object() {"RESERVERED", "CANCELLED"})
        Me.cmb_rstatus.Location = New System.Drawing.Point(377, 31)
        Me.cmb_rstatus.Name = "cmb_rstatus"
        Me.cmb_rstatus.Size = New System.Drawing.Size(121, 22)
        Me.cmb_rstatus.TabIndex = 5
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 519)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_rcontactnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_rfullnameofgroom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_rfullnameofbride As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_rdateofwedding As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_rbookername As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_rclocation As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_rplocation As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_rglocation As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_rrlocation As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_rnumberofguest As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents txt_rspecialrequestnotes As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmb_rrtime As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_rptime As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_rctime As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_rgtime As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_rstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
