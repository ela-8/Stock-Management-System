<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStockForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMostUsed = New System.Windows.Forms.Label()
        Me.btnViewStock = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblBreadcrumb = New System.Windows.Forms.Label()
        Me.LnkMainMenu = New System.Windows.Forms.LinkLabel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(29, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lavender
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(33, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "STOCK RECORDS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(34, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Count"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(303, 119)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(224, 21)
        Me.cmbCategory.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(29, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Product Name"
        '
        'lblMostUsed
        '
        Me.lblMostUsed.AutoSize = True
        Me.lblMostUsed.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.lblMostUsed.Location = New System.Drawing.Point(627, 119)
        Me.lblMostUsed.Name = "lblMostUsed"
        Me.lblMostUsed.Size = New System.Drawing.Size(178, 24)
        Me.lblMostUsed.TabIndex = 7
        Me.lblMostUsed.Text = "Most Used Products"
        '
        'btnViewStock
        '
        Me.btnViewStock.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnViewStock.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.btnViewStock.Location = New System.Drawing.Point(33, 376)
        Me.btnViewStock.Name = "btnViewStock"
        Me.btnViewStock.Size = New System.Drawing.Size(170, 59)
        Me.btnViewStock.TabIndex = 8
        Me.btnViewStock.Text = "View Stocks"
        Me.btnViewStock.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Lavender
        Me.ListBox1.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.ListBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 23
        Me.ListBox1.Location = New System.Drawing.Point(631, 293)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(421, 165)
        Me.ListBox1.TabIndex = 9
        '
        'lblBreadcrumb
        '
        Me.lblBreadcrumb.AutoSize = True
        Me.lblBreadcrumb.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.lblBreadcrumb.Location = New System.Drawing.Point(783, 47)
        Me.lblBreadcrumb.Name = "lblBreadcrumb"
        Me.lblBreadcrumb.Size = New System.Drawing.Size(58, 22)
        Me.lblBreadcrumb.TabIndex = 10
        Me.lblBreadcrumb.Text = "Label6"
        '
        'LnkMainMenu
        '
        Me.LnkMainMenu.AutoSize = True
        Me.LnkMainMenu.Font = New System.Drawing.Font("Calibri", 13.0!)
        Me.LnkMainMenu.Location = New System.Drawing.Point(627, 47)
        Me.LnkMainMenu.Name = "LnkMainMenu"
        Me.LnkMainMenu.Size = New System.Drawing.Size(93, 22)
        Me.LnkMainMenu.TabIndex = 11
        Me.LnkMainMenu.TabStop = True
        Me.LnkMainMenu.Text = "Main Menu"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(631, 216)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(251, 20)
        Me.txtSearch.TabIndex = 12
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 14.0!)
        Me.btnSearch.Location = New System.Drawing.Point(948, 216)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(104, 42)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDelete.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.btnDelete.Location = New System.Drawing.Point(254, 376)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 59)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete Stocks"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(303, 195)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 20)
        Me.TextBox1.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(303, 264)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(224, 20)
        Me.TextBox2.TabIndex = 16
        '
        'ViewStockForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 532)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.LnkMainMenu)
        Me.Controls.Add(Me.lblBreadcrumb)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnViewStock)
        Me.Controls.Add(Me.lblMostUsed)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Name = "ViewStockForm"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMostUsed As Label
    Friend WithEvents btnViewStock As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblBreadcrumb As Label
    Friend WithEvents LnkMainMenu As LinkLabel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
