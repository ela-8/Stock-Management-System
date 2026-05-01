Public Class ViewStockForm
    Public ParentMenu As MainMenu
    Public StockList As List(Of Item)
    Private Sub ViewStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBreadcrumb(lblBreadcrumb, "Main Menu > Stock > View Stock")
        DisplayStock()
        UpdateMostUsed()
        cmbCategory.Items.Clear()
        cmbCategory.Items.Add("Ingredients")
        cmbCategory.Items.Add("Packaged Products")
        cmbCategory.Items.Add("Drinks")
        cmbCategory.Items.Add("Frozen Goods")

        cmbCategory.SelectedIndex = -1
        cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub DisplayStock()

        If StockList Is Nothing OrElse StockList.Count = 0 Then
            MessageBox.Show("No stock available.")
            Exit Sub
        End If

        ListBox1.Items.Clear()

        For Each item In StockList
            ListBox1.Items.Add("Name: " & item.itemName &
                           " | Category: " & item.itemCategory &
                           " | Stock: " & item.stockCount)
        Next

    End Sub
    Private Sub LnkMainMenu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkMainMenu.LinkClicked
        ParentMenu.RefreshDashboard()
        ParentMenu.Show()
        Me.Hide()
    End Sub
    Private Sub btnViewStock_Click(sender As Object, e As EventArgs) Handles btnViewStock.Click
        DisplayStock()
        UpdateMostUsed()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim search As String = txtSearch.Text.Trim().ToLower()

        ListBox1.Items.Clear()

        For Each item In StockList
            If item.itemName.ToLower().Contains(search) Then
                ListBox1.Items.Add(item.itemName & " | " &
                                   item.itemCategory & " | " &
                                   item.stockCount)
            End If
        Next

    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim selected As String = ListBox1.SelectedItem

        If selected Is Nothing Then
            MessageBox.Show("Select an item first.")
            Exit Sub
        End If

        Dim itemName As String = selected.ToString().Split("|")(0).Trim()

        Dim itemToRemove As Item = Nothing

        For Each item In StockList
            If item.itemName = itemName Then
                itemToRemove = item
                Exit For
            End If
        Next

        If itemToRemove IsNot Nothing Then
            StockList.Remove(itemToRemove)
            ParentMenu.SaveToFile()
            MessageBox.Show("Item deleted.")
            DisplayStock()
        End If

    End Sub
    Private Sub UpdateMostUsed()

        If StockList Is Nothing OrElse StockList.Count = 0 Then Exit Sub

        Dim mostUsed = StockList.OrderByDescending(Function(x) x.weeklyUsage).First()

        lblMostUsed.Text = "Most Used Product: " &
                            mostUsed.itemName &
                            " (" & mostUsed.weeklyUsage & " uses)"

    End Sub
End Class