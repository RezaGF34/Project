<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYMENT"
        '
        'ComboBox3
        '
        Me.ComboBox3.ForeColor = System.Drawing.Color.Goldenrod
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"BCA", "OVO"})
        Me.ComboBox3.Location = New System.Drawing.Point(91, 156)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(180, 28)
        Me.ComboBox3.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(86, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(194, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Metode Pembayaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 25)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "TOTAL PRICE "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 292)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 25)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = ". . . . . . . . . "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(107, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 51)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "BAYAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(319, 167)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 232)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(545, 527)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
