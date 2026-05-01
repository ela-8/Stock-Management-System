Imports System.IO
Public Class AddStockForm
    Public ParentMenu As MainMenu
    Public StockList As List(Of Item)

    Private Sub AddStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBreadcrumb(lblBreadcrumb, "Main Menu > Stock > Add Stock")

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

    'Add new stock button
    Private Sub AddStockButton_Click(sender As Object, e As EventArgs) Handles AddStockButton.Click

        Dim itemName As String = txtItemName.Text.Trim()
        Dim category As String = cmbCategory.Text.Trim()
        Dim quantity As Integer
        Dim usageInDay As Integer = 0
        Dim usageInWeek As Integer = 0
        Dim reorder As Integer = 5
        ' Validation
        If itemName = "" Or category = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        If cmbCategory.SelectedIndex = -1 Then
            MessageBox.Show("Please select a category.")
            Exit Sub
        End If

        If Not Integer.TryParse(txtQuantity.Text, quantity) Then
            MessageBox.Show("Please enter a valid number.")
            Exit Sub
        End If

        If quantity < 1 Or quantity > 1000 Then
            MessageBox.Show("Quantity must be between 1 and 1000.")
            Exit Sub
        End If

        Dim found As Boolean = False

        ' Search for existing item
        If StockList Is Nothing Then
            MessageBox.Show("Error: Stock list not loaded.")
            Exit Sub
        End If
        For Each item In StockList
            If item.itemName.Trim().ToLower() = itemName.ToLower() Then
                item.stockCount += quantity
                found = True

                Exit For
            End If
        Next

        ' If not found, create new item
        If Not found Then
            StockList.Add(New Item(itemName, category, quantity, reorder, usageInDay, usageInWeek))
        End If

        MessageBox.Show("Stock updated successfully.")
        txtItemName.Clear()
        txtQuantity.Clear()
        cmbCategory.SelectedIndex = -1

    End Sub

End Class
