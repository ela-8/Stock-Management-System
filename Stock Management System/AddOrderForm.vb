Public Class AddOrderForm
    Public ParentMenu As MainMenu
    Public StockList As List(Of Item)
    Private Sub AddOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBreadcrumb(lblBreadcrumb, "Main Menu > Order > Add Order")
        'Category options
        cmbCategory.Items.Clear()
        cmbCategory.Items.Add("Ingredients")
        cmbCategory.Items.Add("Packaged Products")
        cmbCategory.Items.Add("Drinks")
        cmbCategory.Items.Add("Frozen Goods")

        cmbCategory.SelectedIndex = -1
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub LnkMainMenu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkMainMenu.LinkClicked
        ParentMenu.RefreshDashboard()
        ParentMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Dim itemName As String = txtItemName.Text.Trim()
        Dim quantity As Integer

        ' Validation
        If itemName = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            MessageBox.Show("Enter a valid number.")
            Exit Sub
        End If

        Dim found As Boolean = False

        If quantity <= 0 Then
            MessageBox.Show("Quantity must be greater than 0.")
            Exit Sub
        End If
        ' Search for item
        If StockList Is Nothing Then
            MessageBox.Show("Error: Stock list not loaded.")
            Exit Sub
        End If
        For Each item In StockList
            If item.itemName.Trim().ToLower() = itemName.ToLower() Then

                found = True

                ' Check stock availability

                If item.stockCount >= quantity Then
                    item.stockCount -= quantity
                    MessageBox.Show("Order processed.")
                    item.dailyUsage += quantity
                    item.weeklyUsage += quantity
                    'Low stock warning
                    If item.stockCount <= item.lowStockThreshold Then
                        MessageBox.Show("Warning: Low stock for " & item.itemName)
                    End If
                    ParentMenu.SaveToFile()

                Else
                    MessageBox.Show("Not enough stock available.")
                End If

                Exit For
            End If
        Next

        If found = False Then
            MessageBox.Show("Item not found.")
        End If
        txtItemName.Clear()
        txtQuantity.Clear()
        ParentMenu.SaveToFile()
        ParentMenu.RefreshDashboard()
    End Sub
End Class