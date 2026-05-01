'Item class
Public Class Item
    Public Property itemName As String
    Public Property itemCategory As String
    Private _stockCount As Integer

    Public Property stockCount As Integer
        Get
            Return _stockCount
        End Get
        Set(value As Integer)
            If value < 0 Then
                _stockCount = 0
            Else
                _stockCount = value
            End If
        End Set
    End Property
    Public Property lowStockThreshold As Integer
    Public Property dailyUsage As Integer
    Public Property weeklyUsage As Integer
    Public Sub New(name As String, category As String, stock As Integer,
                   Optional reorder As Integer = 5,
                   Optional usageInDay As Integer = 0,
                   Optional usageInWeek As Integer = 0)

        itemName = name
        itemCategory = category
        stockCount = stock
        lowStockThreshold = reorder
        dailyUsage = usageInDay
        weeklyUsage = usageInWeek

    End Sub


End Class
