<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_balance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_amount = New System.Windows.Forms.TextBox()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightPink
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.txt_balance)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_amount)
        Me.Panel1.Controls.Add(Me.lbl_amount)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 264)
        Me.Panel1.TabIndex = 0
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(94, 175)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "S A V E"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_balance
        '
        Me.txt_balance.Location = New System.Drawing.Point(133, 65)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.Size = New System.Drawing.Size(100, 20)
        Me.txt_balance.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Balance :"
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(133, 104)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(100, 20)
        Me.txt_amount.TabIndex = 1
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.Location = New System.Drawing.Point(56, 107)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(49, 13)
        Me.lbl_amount.TabIndex = 0
        Me.lbl_amount.Text = "Amount :"
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Payment"
        Me.Text = "Payment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_balance As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_amount As System.Windows.Forms.Label
End Class
