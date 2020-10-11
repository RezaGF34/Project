<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nama Barang")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Jumlah")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Harga")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Size")
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(459, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CART"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(96, 170)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"S", "L", "XL", "XXL"})
        Me.ComboBox2.Location = New System.Drawing.Point(96, 256)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(85, 28)
        Me.ComboBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ukuran"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(582, 151)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(282, 161)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(588, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "alamat"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(96, 337)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(54, 26)
        Me.NumericUpDown1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "quantity"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 55)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(125, 24)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "JNE Express"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 115)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(84, 24)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Fed Ex"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 85)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(95, 24)
        Me.RadioButton3.TabIndex = 10
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Si Cepat"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 25)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(123, 24)
        Me.RadioButton4.TabIndex = 11
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "JNT Express"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(311, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 158)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12})
        Me.ListView1.Location = New System.Drawing.Point(80, 505)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(371, 147)
        Me.ListView1.TabIndex = 13
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 394)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 464)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Keranjang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(91, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Barang"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(640, 641)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(183, 37)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Check Out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 28)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(97, 24)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Asuransi"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(15, 58)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(123, 24)
        Me.CheckBox2.TabIndex = 19
        Me.CheckBox2.Text = "BubbleWrap"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(582, 337)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(198, 105)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(582, 505)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(282, 111)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(602, 464)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 25)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Catatan"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(311, 346)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(193, 26)
        Me.TextBox3.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(96, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 52)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(998, 716)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button3 As Button
End Class
