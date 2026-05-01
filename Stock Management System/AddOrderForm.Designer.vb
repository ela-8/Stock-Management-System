<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOrderForm
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.lblBreadcrumb = New System.Windows.Forms.Label()
        Me.LnkMainMenu = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(52, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(52, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Product Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(52, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantity"
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(307, 218)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(294, 20)
        Me.txtItemName.TabIndex = 5
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(305, 294)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(296, 20)
        Me.txtQuantity.TabIndex = 6
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(307, 143)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(294, 21)
        Me.cmbCategory.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(190, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 28)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ADD NEW ORDER"
        '
        'btnAddOrder
        '
        Me.btnAddOrder.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAddOrder.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.btnAddOrder.Location = New System.Drawing.Point(176, 399)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(204, 54)
        Me.btnAddOrder.TabIndex = 10
        Me.btnAddOrder.Text = "Enter"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'lblBreadcrumb
        '
        Me.lblBreadcrumb.AutoSize = True
        Me.lblBreadcrumb.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.lblBreadcrumb.Location = New System.Drawing.Point(848, 54)
        Me.lblBreadcrumb.Name = "lblBreadcrumb"
        Me.lblBreadcrumb.Size = New System.Drawing.Size(116, 22)
        Me.lblBreadcrumb.TabIndex = 12
        Me.lblBreadcrumb.Text = "lblBreadcrumb"
        '
        'LnkMainMenu
        '
        Me.LnkMainMenu.AutoSize = True
        Me.LnkMainMenu.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.LnkMainMenu.Location = New System.Drawing.Point(697, 52)
        Me.LnkMainMenu.Name = "LnkMainMenu"
        Me.LnkMainMenu.Size = New System.Drawing.Size(93, 22)
        Me.LnkMainMenu.TabIndex = 13
        Me.LnkMainMenu.TabStop = True
        Me.LnkMainMenu.Text = "Main Menu"
        '
        'AddOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 523)
        Me.Controls.Add(Me.LnkMainMenu)
        Me.Controls.Add(Me.lblBreadcrumb)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "AddOrderForm"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents lblBreadcrumb As Label
    Friend WithEvents LnkMainMenu As LinkLabel
End Class
