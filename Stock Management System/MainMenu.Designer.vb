<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.btnViewStock = New System.Windows.Forms.Button()
        Me.AddNewStock = New System.Windows.Forms.Button()
        Me.AddOrders = New System.Windows.Forms.Button()
        Me.lblTotalProducts = New System.Windows.Forms.Label()
        Me.lblTotalStock = New System.Windows.Forms.Label()
        Me.lblBreadcrumb = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblLowStock = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMostUsed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnViewStock
        '
        Me.btnViewStock.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnViewStock.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.btnViewStock.Location = New System.Drawing.Point(489, 387)
        Me.btnViewStock.Name = "btnViewStock"
        Me.btnViewStock.Size = New System.Drawing.Size(158, 79)
        Me.btnViewStock.TabIndex = 0
        Me.btnViewStock.Text = "View Stock Records"
        Me.btnViewStock.UseVisualStyleBackColor = False
        '
        'AddNewStock
        '
        Me.AddNewStock.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AddNewStock.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.AddNewStock.Location = New System.Drawing.Point(863, 387)
        Me.AddNewStock.Name = "AddNewStock"
        Me.AddNewStock.Size = New System.Drawing.Size(166, 79)
        Me.AddNewStock.TabIndex = 1
        Me.AddNewStock.Text = "Add new stock"
        Me.AddNewStock.UseVisualStyleBackColor = False
        '
        'AddOrders
        '
        Me.AddOrders.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AddOrders.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.AddOrders.ForeColor = System.Drawing.Color.MidnightBlue
        Me.AddOrders.Location = New System.Drawing.Point(124, 387)
        Me.AddOrders.Name = "AddOrders"
        Me.AddOrders.Size = New System.Drawing.Size(158, 79)
        Me.AddOrders.TabIndex = 2
        Me.AddOrders.Text = "Add orders"
        Me.AddOrders.UseVisualStyleBackColor = False
        '
        'lblTotalProducts
        '
        Me.lblTotalProducts.AutoSize = True
        Me.lblTotalProducts.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblTotalProducts.Location = New System.Drawing.Point(300, 180)
        Me.lblTotalProducts.Name = "lblTotalProducts"
        Me.lblTotalProducts.Size = New System.Drawing.Size(129, 24)
        Me.lblTotalProducts.TabIndex = 3
        Me.lblTotalProducts.Text = "Total Products"
        '
        'lblTotalStock
        '
        Me.lblTotalStock.AutoSize = True
        Me.lblTotalStock.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblTotalStock.Location = New System.Drawing.Point(694, 180)
        Me.lblTotalStock.Name = "lblTotalStock"
        Me.lblTotalStock.Size = New System.Drawing.Size(100, 24)
        Me.lblTotalStock.TabIndex = 4
        Me.lblTotalStock.Text = "Total Stock"
        '
        'lblBreadcrumb
        '
        Me.lblBreadcrumb.AutoSize = True
        Me.lblBreadcrumb.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.lblBreadcrumb.Location = New System.Drawing.Point(911, 40)
        Me.lblBreadcrumb.Name = "lblBreadcrumb"
        Me.lblBreadcrumb.Size = New System.Drawing.Size(58, 22)
        Me.lblBreadcrumb.TabIndex = 5
        Me.lblBreadcrumb.Text = "Label1"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblUser.Location = New System.Drawing.Point(40, 40)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(64, 24)
        Me.lblUser.TabIndex = 6
        Me.lblUser.Text = "Label1"
        '
        'lblLowStock
        '
        Me.lblLowStock.AutoSize = True
        Me.lblLowStock.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblLowStock.Location = New System.Drawing.Point(300, 288)
        Me.lblLowStock.Name = "lblLowStock"
        Me.lblLowStock.Size = New System.Drawing.Size(143, 24)
        Me.lblLowStock.TabIndex = 7
        Me.lblLowStock.Text = "Low Stock Items"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lavender
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(424, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "STOCK MANAGEMENT SYSTEM"
        '
        'lblMostUsed
        '
        Me.lblMostUsed.AutoSize = True
        Me.lblMostUsed.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblMostUsed.Location = New System.Drawing.Point(694, 288)
        Me.lblMostUsed.Name = "lblMostUsed"
        Me.lblMostUsed.Size = New System.Drawing.Size(143, 24)
        Me.lblMostUsed.TabIndex = 9
        Me.lblMostUsed.Text = "Most Used Item"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(1150, 527)
        Me.Controls.Add(Me.lblMostUsed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLowStock)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblBreadcrumb)
        Me.Controls.Add(Me.lblTotalStock)
        Me.Controls.Add(Me.lblTotalProducts)
        Me.Controls.Add(Me.AddOrders)
        Me.Controls.Add(Me.AddNewStock)
        Me.Controls.Add(Me.btnViewStock)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "MainMenu"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewStock As Button
    Friend WithEvents AddNewStock As Button
    Friend WithEvents AddOrders As Button
    Friend WithEvents lblTotalProducts As Label
    Friend WithEvents lblTotalStock As Label
    Friend WithEvents lblBreadcrumb As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblLowStock As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMostUsed As Label
End Class
