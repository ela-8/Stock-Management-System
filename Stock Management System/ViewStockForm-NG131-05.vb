Public Class ViewStockForm
    Public StockList As List(Of Item)
    Private Sub ViewStockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBreadcrumb(lblBreadcrumb, "Main Menu > Stock > View Stock")
    End Sub
    Private Sub LnkMainMenu_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkMainMenu.LinkClicked

        MainMenu.Show()
        Me.Close()

    End Sub
    Private Sub btnViewStock_Click(sender As Object, e As EventArgs) Handles btnViewStock.Click

        Dim output As String = ""

        ' Check if list is empty
        If StockList Is Nothing OrElse StockList.Count = 0 Then
            MessageBox.Show("No stock available.")
            Exit Sub
        End If

        ' Loop through items
        ListBox1.Items.Clear()

        For Each item In StockList
            ListBox1.Items.Add(item.itemName & " | " &
                       item.itemCategory & " | " &
                       item.stockCount)
        Next

        MessageBox.Show(output)

    End Sub
End Class