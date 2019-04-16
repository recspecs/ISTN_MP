<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_New_Employee
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label74, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label73, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label77, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MaskedTextBox1, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox6, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox7, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox8, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox9, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox10, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label70, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label72, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label75, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label76, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label71, 0, 6)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(39, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(460, 394)
        Me.TableLayoutPanel1.TabIndex = 72
        '
        'Label74
        '
        Me.Label74.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label74.AutoSize = true
        Me.Label74.Location = New System.Drawing.Point(10, 10)
        Me.Label74.Margin = New System.Windows.Forms.Padding(10)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(81, 19)
        Me.Label74.TabIndex = 57
        Me.Label74.Text = "Employee ID"
        '
        'Label73
        '
        Me.Label73.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label73.AutoSize = true
        Me.Label73.Location = New System.Drawing.Point(10, 50)
        Me.Label73.Margin = New System.Windows.Forms.Padding(10)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(71, 17)
        Me.Label73.TabIndex = 56
        Me.Label73.Text = "First Name"
        '
        'Label77
        '
        Me.Label77.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.Label77.AutoSize = true
        Me.Label77.Location = New System.Drawing.Point(10, 88)
        Me.Label77.Margin = New System.Windows.Forms.Padding(10)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(59, 19)
        Me.Label77.TabIndex = 58
        Me.Label77.Text = "Surname"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(240, 127)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(210, 25)
        Me.TextBox4.TabIndex = 65
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TextBox6.Location = New System.Drawing.Point(240, 205)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(210, 25)
        Me.TextBox6.TabIndex = 8
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Location = New System.Drawing.Point(240, 166)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(210, 25)
        Me.TextBox7.TabIndex = 6
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TextBox8.Location = New System.Drawing.Point(240, 88)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(210, 25)
        Me.TextBox8.TabIndex = 64
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TextBox9.Location = New System.Drawing.Point(240, 49)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(210, 25)
        Me.TextBox9.TabIndex = 63
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TextBox10.Location = New System.Drawing.Point(240, 10)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(210, 25)
        Me.TextBox10.TabIndex = 62
        '
        'Label70
        '
        Me.Label70.AutoSize = true
        Me.Label70.Location = New System.Drawing.Point(10, 283)
        Me.Label70.Margin = New System.Windows.Forms.Padding(10)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(78, 17)
        Me.Label70.TabIndex = 2
        Me.Label70.Text = "Full address"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(240, 283)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(10)
        Me.TextBox3.Multiline = true
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(210, 101)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "Building/Complex/Apt."&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Street"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Suburb"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"City"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Postal Code"
        '
        'Label72
        '
        Me.Label72.AutoSize = true
        Me.Label72.Location = New System.Drawing.Point(10, 205)
        Me.Label72.Margin = New System.Windows.Forms.Padding(10)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(64, 17)
        Me.Label72.TabIndex = 0
        Me.Label72.Text = "Password"
        '
        'Label75
        '
        Me.Label75.AutoSize = true
        Me.Label75.Location = New System.Drawing.Point(10, 166)
        Me.Label75.Margin = New System.Windows.Forms.Padding(10)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(39, 17)
        Me.Label75.TabIndex = 60
        Me.Label75.Text = "Email"
        '
        'Label76
        '
        Me.Label76.AutoSize = true
        Me.Label76.Location = New System.Drawing.Point(10, 127)
        Me.Label76.Margin = New System.Windows.Forms.Padding(10)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(54, 17)
        Me.Label76.TabIndex = 59
        Me.Label76.Text = "Position"
        '
        'Label71
        '
        Me.Label71.AutoSize = true
        Me.Label71.Location = New System.Drawing.Point(10, 244)
        Me.Label71.Margin = New System.Windows.Forms.Padding(10)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(77, 17)
        Me.Label71.TabIndex = 1
        Me.Label71.Text = "Contact No."
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.MenuForms.My.Resources.Resources.delete_icon__1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(294, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Button1.Size = New System.Drawing.Size(92, 40)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Cancel"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Button2
        '
        Me.Button2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = Global.MenuForms.My.Resources.Resources.Action_ok_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(122, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.Button2.Size = New System.Drawing.Size(92, 40)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "Add"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = true
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MaskedTextBox1.Location = New System.Drawing.Point(242, 241)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(206, 25)
        Me.MaskedTextBox1.TabIndex = 66
        '
        'Add_New_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 480)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Add_New_Employee"
        Me.Text = "Add_New_Employee"
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label74 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label70 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label72 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
