<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarehouseManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WarehouseManager))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.WMTab = New System.Windows.Forms.TabControl()
        Me.WMSupplierTab = New System.Windows.Forms.TabPage()
        Me.tlpWM = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearchWM = New System.Windows.Forms.Button()
        Me.tbQueryWM = New System.Windows.Forms.TextBox()
        Me.cbCriteriaWM = New System.Windows.Forms.ComboBox()
        Me.flpWM = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddEditWM = New System.Windows.Forms.Button()
        Me.btnSaveWN = New System.Windows.Forms.Button()
        Me.btnRemoveWM = New System.Windows.Forms.Button()
        Me.dgyWM = New System.Windows.Forms.DataGridView()
        Me.WMTab.SuspendLayout
        Me.WMSupplierTab.SuspendLayout
        Me.tlpWM.SuspendLayout
        Me.flpWM.SuspendLayout
        CType(Me.dgyWM,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'WMTab
        '
        Me.WMTab.Controls.Add(Me.WMSupplierTab)
        Me.WMTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WMTab.Location = New System.Drawing.Point(0, 0)
        Me.WMTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WMTab.Name = "WMTab"
        Me.WMTab.SelectedIndex = 0
        Me.WMTab.Size = New System.Drawing.Size(1314, 797)
        Me.WMTab.TabIndex = 0
        '
        'WMSupplierTab
        '
        Me.WMSupplierTab.Controls.Add(Me.tlpWM)
        Me.WMSupplierTab.Controls.Add(Me.flpWM)
        Me.WMSupplierTab.Controls.Add(Me.dgyWM)
        Me.WMSupplierTab.Location = New System.Drawing.Point(4, 26)
        Me.WMSupplierTab.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.WMSupplierTab.Name = "WMSupplierTab"
        Me.WMSupplierTab.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.WMSupplierTab.Size = New System.Drawing.Size(1306, 767)
        Me.WMSupplierTab.TabIndex = 14
        Me.WMSupplierTab.Text = "Supplier"
        Me.WMSupplierTab.UseVisualStyleBackColor = true
        '
        'tlpWM
        '
        Me.tlpWM.ColumnCount = 3
        Me.tlpWM.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpWM.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpWM.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpWM.Controls.Add(Me.btnSearchWM, 0, 0)
        Me.tlpWM.Controls.Add(Me.tbQueryWM, 1, 0)
        Me.tlpWM.Controls.Add(Me.cbCriteriaWM, 2, 0)
        Me.tlpWM.Location = New System.Drawing.Point(218, 250)
        Me.tlpWM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpWM.Name = "tlpWM"
        Me.tlpWM.RowCount = 1
        Me.tlpWM.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpWM.Size = New System.Drawing.Size(862, 60)
        Me.tlpWM.TabIndex = 84
        '
        'btnSearchWM
        '
        Me.btnSearchWM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchWM.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSearchWM.Image = CType(resources.GetObject("btnSearchWM.Image"),System.Drawing.Image)
        Me.btnSearchWM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearchWM.Location = New System.Drawing.Point(12, 17)
        Me.btnSearchWM.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnSearchWM.Name = "btnSearchWM"
        Me.btnSearchWM.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnSearchWM.Size = New System.Drawing.Size(263, 25)
        Me.btnSearchWM.TabIndex = 70
        Me.btnSearchWM.Text = "Search"
        Me.btnSearchWM.UseVisualStyleBackColor = true
        '
        'tbQueryWM
        '
        Me.tbQueryWM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbQueryWM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbQueryWM.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tbQueryWM.Location = New System.Drawing.Point(299, 17)
        Me.tbQueryWM.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tbQueryWM.Multiline = true
        Me.tbQueryWM.Name = "tbQueryWM"
        Me.tbQueryWM.Size = New System.Drawing.Size(263, 25)
        Me.tbQueryWM.TabIndex = 68
        Me.tbQueryWM.Text = "Enter query ..."
        '
        'cbCriteriaWM
        '
        Me.cbCriteriaWM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cbCriteriaWM.FormattingEnabled = true
        Me.cbCriteriaWM.Items.AddRange(New Object() {"By employee ID", "By first name", "By surname"})
        Me.cbCriteriaWM.Location = New System.Drawing.Point(586, 17)
        Me.cbCriteriaWM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbCriteriaWM.Name = "cbCriteriaWM"
        Me.cbCriteriaWM.Size = New System.Drawing.Size(263, 25)
        Me.cbCriteriaWM.TabIndex = 71
        Me.cbCriteriaWM.Text = "Select criteria"
        '
        'flpWM
        '
        Me.flpWM.Controls.Add(Me.btnAddEditWM)
        Me.flpWM.Controls.Add(Me.btnSaveWN)
        Me.flpWM.Controls.Add(Me.btnRemoveWM)
        Me.flpWM.Location = New System.Drawing.Point(324, 71)
        Me.flpWM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flpWM.Name = "flpWM"
        Me.flpWM.Size = New System.Drawing.Size(588, 146)
        Me.flpWM.TabIndex = 83
        '
        'btnAddEditWM
        '
        Me.btnAddEditWM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddEditWM.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.btnAddEditWM.Image = CType(resources.GetObject("btnAddEditWM.Image"),System.Drawing.Image)
        Me.btnAddEditWM.Location = New System.Drawing.Point(15, 5)
        Me.btnAddEditWM.Margin = New System.Windows.Forms.Padding(15, 5, 30, 5)
        Me.btnAddEditWM.Name = "btnAddEditWM"
        Me.btnAddEditWM.Size = New System.Drawing.Size(146, 136)
        Me.btnAddEditWM.TabIndex = 32
        Me.btnAddEditWM.Text = "Add/Edit"
        Me.btnAddEditWM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddEditWM.UseCompatibleTextRendering = true
        Me.btnAddEditWM.UseVisualStyleBackColor = true
        '
        'btnSaveWN
        '
        Me.btnSaveWN.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSaveWN.Image = CType(resources.GetObject("btnSaveWN.Image"),System.Drawing.Image)
        Me.btnSaveWN.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSaveWN.Location = New System.Drawing.Point(221, 5)
        Me.btnSaveWN.Margin = New System.Windows.Forms.Padding(30, 5, 30, 5)
        Me.btnSaveWN.Name = "btnSaveWN"
        Me.btnSaveWN.Padding = New System.Windows.Forms.Padding(0, 17, 0, 0)
        Me.btnSaveWN.Size = New System.Drawing.Size(146, 136)
        Me.btnSaveWN.TabIndex = 30
        Me.btnSaveWN.Text = "Save"
        Me.btnSaveWN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSaveWN.UseVisualStyleBackColor = true
        '
        'btnRemoveWM
        '
        Me.btnRemoveWM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRemoveWM.Image = CType(resources.GetObject("btnRemoveWM.Image"),System.Drawing.Image)
        Me.btnRemoveWM.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemoveWM.Location = New System.Drawing.Point(427, 5)
        Me.btnRemoveWM.Margin = New System.Windows.Forms.Padding(30, 5, 15, 5)
        Me.btnRemoveWM.Name = "btnRemoveWM"
        Me.btnRemoveWM.Padding = New System.Windows.Forms.Padding(0, 17, 0, 0)
        Me.btnRemoveWM.Size = New System.Drawing.Size(146, 136)
        Me.btnRemoveWM.TabIndex = 31
        Me.btnRemoveWM.Text = "Remove"
        Me.btnRemoveWM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveWM.UseVisualStyleBackColor = true
        '
        'dgyWM
        '
        Me.dgyWM.AllowUserToAddRows = false
        Me.dgyWM.AllowUserToDeleteRows = false
        Me.dgyWM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgyWM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgyWM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgyWM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgyWM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgyWM.Location = New System.Drawing.Point(45, 416)
        Me.dgyWM.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.dgyWM.Name = "dgyWM"
        Me.dgyWM.ReadOnly = true
        Me.dgyWM.Size = New System.Drawing.Size(1000, 413)
        Me.dgyWM.TabIndex = 61
        '
        'WarehouseManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 797)
        Me.Controls.Add(Me.WMTab)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WarehouseManager"
        Me.Text = "WarehouseManager"
        Me.WMTab.ResumeLayout(false)
        Me.WMSupplierTab.ResumeLayout(false)
        Me.tlpWM.ResumeLayout(false)
        Me.tlpWM.PerformLayout
        Me.flpWM.ResumeLayout(false)
        CType(Me.dgyWM,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents WMTab As TabControl
    Friend WithEvents WMSupplierTab As TabPage
    Friend WithEvents tlpWM As TableLayoutPanel
    Friend WithEvents btnSearchWM As Button
    Friend WithEvents tbQueryWM As TextBox
    Friend WithEvents cbCriteriaWM As ComboBox
    Friend WithEvents flpWM As FlowLayoutPanel
    Friend WithEvents btnAddEditWM As Button
    Friend WithEvents btnSaveWN As Button
    Friend WithEvents btnRemoveWM As Button
    Friend WithEvents dgyWM As DataGridView
End Class
