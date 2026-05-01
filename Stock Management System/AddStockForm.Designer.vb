<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStockForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddStockButton = New System.Windows.Forms.Button()
        Me.lblBreadcrumb = New System.Windows.Forms.Label()
        Me.LnkMainMenu = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(47, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(47, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(319, 288)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(282, 20)
        Me.txtQuantity.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(47, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Product Name"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(319, 218)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(282, 20)
        Me.txtItemName.TabIndex = 6
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(319, 144)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(282, 21)
        Me.cmbCategory.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 28)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ADD NEW STOCK"
        '
        'AddStockButton
        '
        Me.AddStockButton.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AddStockButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.AddStockButton.Location = New System.Drawing.Point(186, 397)
        Me.AddStockButton.Name = "AddStockButton"
        Me.AddStockButton.Size = New System.Drawing.Size(204, 55)
        Me.AddStockButton.TabIndex = 9
        Me.AddStockButton.Text = "Enter"
        Me.AddStockButton.UseVisualStyleBackColor = False
        '
        'lblBreadcrumb
        '
        Me.lblBreadcrumb.AutoSize = True
        Me.lblBreadcrumb.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.lblBreadcrumb.Location = New System.Drawing.Point(837, 52)
        Me.lblBreadcrumb.Name = "lblBreadcrumb"
        Me.lblBreadcrumb.Size = New System.Drawing.Size(58, 22)
        Me.lblBreadcrumb.TabIndex = 11
        Me.lblBreadcrumb.Text = "Label5"
        '
        'LnkMainMenu
        '
        Me.LnkMainMenu.AutoSize = True
        Me.LnkMainMenu.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.LnkMainMenu.Location = New System.Drawing.Point(676, 52)
        Me.LnkMainMenu.Name = "LnkMainMenu"
        Me.LnkMainMenu.Size = New System.Drawing.Size(93, 22)
        Me.LnkMainMenu.TabIndex = 12
        Me.LnkMainMenu.TabStop = True
        Me.LnkMainMenu.Text = "Main Menu"
        '
        'AddStockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 526)
        Me.Controls.Add(Me.LnkMainMenu)
        Me.Controls.Add(Me.lblBreadcrumb)
        Me.Controls.Add(Me.AddStockButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "AddStockForm"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AddStockButton As Button
    Friend WithEvents lblBreadcrumb As Label
    Friend WithEvents LnkMainMenu As LinkLabel
End Class
