Imports System.IO
Public Class MainMenu
    Public StockList As New List(Of Item)
    Public Shared Property CurrentUser As String

    'Open stock records form
    Private Sub StockRecords_Click(sender As Object, e As EventArgs) Handles btnViewStock.Click
        SaveToFile()
        Dim form As New ViewStockForm()
        form.StockList = Me.StockList
        form.ParentMenu = Me
        form.Show()
        Me.Hide()
    End Sub
    'Open add orders form
    Private Sub AddOrders_Click(sender As Object, e As EventArgs) Handles AddOrders.Click
        SaveToFile()
        Dim form As New AddOrderForm()
        form.StockList = Me.StockList
        form.ParentMenu = Me
        form.Show()
        Me.Hide()
    End Sub
    'Open add new stock form
    Private Sub AddStock_Click(sender As Object, e As EventArgs) Handles AddNewStock.Click
        SaveToFile()
        Dim form As New AddStockForm()
        form.StockList = Me.StockList
        form.ParentMenu = Me
        form.Show()
        Me.Hide()
    End Sub
    Public Sub SaveToFile()
        Dim filePath As String = Path.Combine(Application.StartupPath, "stockdata.csv")

        Using writer As New IO.StreamWriter(filePath, False)
            For Each item In StockList
                writer.WriteLine(item.itemName & "," &
                                 item.itemCategory & "," &
                                 item.stockCount & "," &
                                 item.lowStockThreshold & "," &
                                 item.dailyUsage & "," &
                                 item.weeklyUsage)
            Next
        End Using
    End Sub

    Public Sub LoadFromFile()

        StockList.Clear()
        Dim filePath As String = Path.Combine(Application.StartupPath, "stockdata.csv")
        If IO.File.Exists(filePath) Then
            Dim lines() As String = IO.File.ReadAllLines(filePath)
            For Each line In lines
                If line.Trim() = "" Then Continue For

                Dim parts() As String = line.Split(",")

                If parts.Length < 6 Then Continue For
                Dim StockCount As Integer
                If Not Integer.TryParse(parts(2), StockCount) Then Continue For
                Dim newItem As New Item(parts(0), parts(1), StockCount)
                newItem.lowStockThreshold = Convert.ToInt32(parts(3))
                newItem.dailyUsage = Val(parts(4))
                newItem.weeklyUsage = Val(parts(5))

                StockList.Add(newItem)
            Next

        End If
        If IO.File.Exists(filePath) = False OrElse IO.File.ReadAllLines(filePath).Length = 0 Then

            StockList.Add(New Item("Milk", "Drinks", 20, 5, 2, 10))
            StockList.Add(New Item("Bread", "Packaged Products", 15, 5, 3, 12))
            StockList.Add(New Item("Flour", "Ingredients", 50, 10, 5, 30))
            StockList.Add(New Item("Sugar", "Ingredients", 40, 10, 4, 25))

            SaveToFile()

        End If

    End Sub
    Private Sub UpdateMostUsed()

        If StockList Is Nothing OrElse StockList.Count = 0 Then Exit Sub

        Dim mostUsed = StockList.OrderByDescending(Function(x) x.weeklyUsage).First()

        lblMostUsed.Text = "Most Used Product: " &
                            mostUsed.itemName &
                            " (" & mostUsed.weeklyUsage & " uses)"

    End Sub
    'Label showing total products and total stock count

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CurrentUser IsNot Nothing Then
            lblUser.Text = "Logged in as: " & CurrentUser
        End If
        LoadFromFile()
        Dim lowStockItems As String = ""

        For Each item In StockList
            If item.stockCount <= item.lowStockThreshold Then
                lowStockItems &= item.itemName & " (" & item.stockCount & ")" & Environment.NewLine
            End If
        Next

        If lowStockItems <> "" Then
            lblLowStock.Text = "LOW STOCK ITEMS:" & Environment.NewLine & lowStockItems
        Else
            lblLowStock.Text = "No low stock items"
        End If
        SetBreadcrumb(lblBreadcrumb, "Main Menu")
        lblTotalProducts.Text = "Total products: " & StockList.Count
        Dim totalStock As Integer = 0
        For Each item In StockList
            totalStock += item.stockCount
        Next
        lblTotalStock.Text = "Total items in stock: " & totalStock

    End Sub
    Public Sub RefreshDashboard()
        lblTotalProducts.Text = "Total products: " & StockList.Count

        Dim totalStock As Integer = 0
        For Each item In StockList
            totalStock += item.stockCount
        Next

        lblTotalStock.Text = "Total items in stock: " & totalStock
    End Sub
End Class