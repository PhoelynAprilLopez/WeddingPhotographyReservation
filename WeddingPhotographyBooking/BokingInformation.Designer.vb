<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BokingInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BokingInformation))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_contactnumber = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_fullnameofgroom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_fullnameofbride = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_dateofwedding = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_bookername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_pcnext = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_rlocation = New System.Windows.Forms.TextBox()
        Me.cmb_rtime = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_plocation = New System.Windows.Forms.TextBox()
        Me.cmb_ptime = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_clocation = New System.Windows.Forms.TextBox()
        Me.cmb_ctime = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_glocation = New System.Windows.Forms.TextBox()
        Me.cmb_gtime = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.rtb_srn = New System.Windows.Forms.RichTextBox()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_numberofguest = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(625, 468)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txt_contactnumber)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txt_address)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txt_fullnameofgroom)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txt_fullnameofbride)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txt_dateofwedding)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txt_bookername)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btn_next)
        Me.TabPage2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.DeepPink
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(617, 434)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Wedding Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt_contactnumber
        '
        Me.txt_contactnumber.Location = New System.Drawing.Point(281, 311)
        Me.txt_contactnumber.Name = "txt_contactnumber"
        Me.txt_contactnumber.Size = New System.Drawing.Size(194, 26)
        Me.txt_contactnumber.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(125, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Contact Number:"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(281, 254)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(194, 26)
        Me.txt_address.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(185, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Address:"
        '
        'txt_fullnameofgroom
        '
        Me.txt_fullnameofgroom.Location = New System.Drawing.Point(281, 196)
        Me.txt_fullnameofgroom.Name = "txt_fullnameofgroom"
        Me.txt_fullnameofgroom.Size = New System.Drawing.Size(194, 26)
        Me.txt_fullnameofgroom.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Full Name Of Groom:"
        '
        'txt_fullnameofbride
        '
        Me.txt_fullnameofbride.Location = New System.Drawing.Point(281, 139)
        Me.txt_fullnameofbride.Name = "txt_fullnameofbride"
        Me.txt_fullnameofbride.Size = New System.Drawing.Size(194, 26)
        Me.txt_fullnameofbride.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Full Name Of Bride:"
        '
        'txt_dateofwedding
        '
        Me.txt_dateofwedding.Location = New System.Drawing.Point(156, 82)
        Me.txt_dateofwedding.Name = "txt_dateofwedding"
        Me.txt_dateofwedding.Size = New System.Drawing.Size(391, 26)
        Me.txt_dateofwedding.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date Of Wedding:"
        '
        'txt_bookername
        '
        Me.txt_bookername.Location = New System.Drawing.Point(129, 32)
        Me.txt_bookername.Name = "txt_bookername"
        Me.txt_bookername.Size = New System.Drawing.Size(418, 26)
        Me.txt_bookername.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Booker Name:"
        '
        'btn_next
        '
        Me.btn_next.Location = New System.Drawing.Point(464, 376)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(101, 40)
        Me.btn_next.TabIndex = 0
        Me.btn_next.Text = "N E X T"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.btn_pcnext)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txt_rlocation)
        Me.TabPage1.Controls.Add(Me.cmb_rtime)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txt_plocation)
        Me.TabPage1.Controls.Add(Me.cmb_ptime)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txt_clocation)
        Me.TabPage1.Controls.Add(Me.cmb_ctime)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txt_glocation)
        Me.TabPage1.Controls.Add(Me.cmb_gtime)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.ForeColor = System.Drawing.Color.DeepPink
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(617, 434)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Photography Coverage"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(114, 161)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 18)
        Me.Label21.TabIndex = 21
        Me.Label21.Text = "Time :"
        '
        'btn_pcnext
        '
        Me.btn_pcnext.Location = New System.Drawing.Point(463, 386)
        Me.btn_pcnext.Name = "btn_pcnext"
        Me.btn_pcnext.Size = New System.Drawing.Size(96, 37)
        Me.btn_pcnext.TabIndex = 20
        Me.btn_pcnext.Text = "N E X T"
        Me.btn_pcnext.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(316, 340)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 18)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Location :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(114, 340)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 18)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Time :"
        '
        'txt_rlocation
        '
        Me.txt_rlocation.Location = New System.Drawing.Point(403, 337)
        Me.txt_rlocation.Name = "txt_rlocation"
        Me.txt_rlocation.Size = New System.Drawing.Size(191, 26)
        Me.txt_rlocation.TabIndex = 17
        '
        'cmb_rtime
        '
        Me.cmb_rtime.FormattingEnabled = True
        Me.cmb_rtime.Items.AddRange(New Object() {"05:00AM", "06:00AM", "07:00AM", "08:00AM", "09:00AM", "10:00AM", "11:00AM", "12:00PM", "01:00PM", "02:00PM", "03:00PM", "04:00PM", "05:00PM", "06:00PM", "07:00PM", "08:00PM", "09:00PM", "10:00PM"})
        Me.cmb_rtime.Location = New System.Drawing.Point(173, 340)
        Me.cmb_rtime.Name = "cmb_rtime"
        Me.cmb_rtime.Size = New System.Drawing.Size(127, 26)
        Me.cmb_rtime.TabIndex = 16
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(45, 299)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 18)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "RECEPTION :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(316, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 18)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Location :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(114, 254)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 18)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Time :"
        '
        'txt_plocation
        '
        Me.txt_plocation.Location = New System.Drawing.Point(403, 251)
        Me.txt_plocation.Name = "txt_plocation"
        Me.txt_plocation.Size = New System.Drawing.Size(191, 26)
        Me.txt_plocation.TabIndex = 12
        '
        'cmb_ptime
        '
        Me.cmb_ptime.FormattingEnabled = True
        Me.cmb_ptime.Items.AddRange(New Object() {"05:00AM", "06:00AM", "07:00AM", "08:00AM", "09:00AM", "10:00AM", "11:00AM", "12:00PM", "01:00PM", "02:00PM", "03:00PM", "04:00PM", "05:00PM", "06:00PM", "07:00PM", "08:00PM", "09:00PM", "10:00PM"})
        Me.cmb_ptime.Location = New System.Drawing.Point(173, 251)
        Me.cmb_ptime.Name = "cmb_ptime"
        Me.cmb_ptime.Size = New System.Drawing.Size(127, 26)
        Me.cmb_ptime.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(45, 213)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 18)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "PHOTOSHOOT :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(316, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Location :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(114, 161)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 18)
        Me.Label11.TabIndex = 8
        '
        'txt_clocation
        '
        Me.txt_clocation.Location = New System.Drawing.Point(403, 158)
        Me.txt_clocation.Name = "txt_clocation"
        Me.txt_clocation.Size = New System.Drawing.Size(191, 26)
        Me.txt_clocation.TabIndex = 7
        '
        'cmb_ctime
        '
        Me.cmb_ctime.FormattingEnabled = True
        Me.cmb_ctime.Items.AddRange(New Object() {"05:00AM", "06:00AM", "07:00AM", "08:00AM", "09:00AM", "10:00AM", "11:00AM", "12:00PM", "01:00PM", "02:00PM", "03:00PM", "04:00PM", "05:00PM", "06:00PM", "07:00PM", "08:00PM", "09:00PM", "10:00PM"})
        Me.cmb_ctime.Location = New System.Drawing.Point(173, 158)
        Me.cmb_ctime.Name = "cmb_ctime"
        Me.cmb_ctime.Size = New System.Drawing.Size(127, 26)
        Me.cmb_ctime.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(45, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 18)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "CEREMONY :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(316, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 18)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Location :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(114, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Time :"
        '
        'txt_glocation
        '
        Me.txt_glocation.Location = New System.Drawing.Point(403, 70)
        Me.txt_glocation.Name = "txt_glocation"
        Me.txt_glocation.Size = New System.Drawing.Size(191, 26)
        Me.txt_glocation.TabIndex = 2
        '
        'cmb_gtime
        '
        Me.cmb_gtime.FormattingEnabled = True
        Me.cmb_gtime.Items.AddRange(New Object() {"05:00AM", "06:00AM", "07:00AM", "08:00AM", "09:00AM", "10:00AM", "11:00AM", "12:00PM", "01:00PM", "02:00PM", "03:00PM", "04:00PM", "05:00PM", "06:00PM", "07:00PM", "08:00PM", "09:00PM", "10:00PM"})
        Me.cmb_gtime.Location = New System.Drawing.Point(173, 70)
        Me.cmb_gtime.Name = "cmb_gtime"
        Me.cmb_gtime.Size = New System.Drawing.Size(127, 26)
        Me.cmb_gtime.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "GETTING READY :"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cmb_status)
        Me.TabPage3.Controls.Add(Me.Label22)
        Me.TabPage3.Controls.Add(Me.rtb_srn)
        Me.TabPage3.Controls.Add(Me.btn_done)
        Me.TabPage3.Controls.Add(Me.Label20)
        Me.TabPage3.Controls.Add(Me.txt_numberofguest)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.ForeColor = System.Drawing.Color.DeepPink
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(617, 434)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Additional Information"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'rtb_srn
        '
        Me.rtb_srn.Location = New System.Drawing.Point(188, 195)
        Me.rtb_srn.Name = "rtb_srn"
        Me.rtb_srn.Size = New System.Drawing.Size(369, 139)
        Me.rtb_srn.TabIndex = 5
        Me.rtb_srn.Text = ""
        '
        'btn_done
        '
        Me.btn_done.Location = New System.Drawing.Point(467, 374)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(90, 40)
        Me.btn_done.TabIndex = 4
        Me.btn_done.Text = "D O N E"
        Me.btn_done.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(20, 151)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(222, 18)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "SPECIAL REQUEST / NOTES:"
        '
        'txt_numberofguest
        '
        Me.txt_numberofguest.Location = New System.Drawing.Point(188, 32)
        Me.txt_numberofguest.Name = "txt_numberofguest"
        Me.txt_numberofguest.Size = New System.Drawing.Size(209, 26)
        Me.txt_numberofguest.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(29, 35)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(142, 18)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Number of Guest :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(627, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(115, 23)
        Me.ToolStripMenuItem2.Text = "REPORTS"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(106, 89)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 18)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Status :"
        '
        'cmb_status
        '
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"RESERVERED", "CANCELLED"})
        Me.cmb_status.Location = New System.Drawing.Point(188, 86)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(209, 26)
        Me.cmb_status.TabIndex = 7
        '
        'BokingInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 510)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BokingInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BokingInformation"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txt_contactnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_fullnameofgroom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_fullnameofbride As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_dateofwedding As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_bookername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_pcnext As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_rlocation As System.Windows.Forms.TextBox
    Friend WithEvents cmb_rtime As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_plocation As System.Windows.Forms.TextBox
    Friend WithEvents cmb_ptime As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_clocation As System.Windows.Forms.TextBox
    Friend WithEvents cmb_ctime As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_glocation As System.Windows.Forms.TextBox
    Friend WithEvents cmb_gtime As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_numberofguest As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btn_done As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents rtb_srn As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmb_status As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
