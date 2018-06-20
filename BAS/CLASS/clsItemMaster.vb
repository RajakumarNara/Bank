Public Class clsItemMaster

#Region "Private Variables"

    Private _strItemName As String
    Private _strItemDescription As String
    Private _lngPresentStock As Long
    Private _lngPresentRate As Long
    Private _lngSellingPrice As Long
    Private _strUnit As String
    Private _strType As String
    Private _lngItemLedgerNo As Long
    Private _dtItemTable As DataTable
    Private _dtOrdertbl As DataTable
    Private _dtOrderDetailstbl As DataTable
    Private _dtOrderBillDetailstbl As DataTable
    Private _dtLedgertbl As DataTable

    Private _strReceiptNo As String
    Private _datSalesDate As Date
    Private _strRemarks As String
    Private _lngSubTotal As Long
    Private _dtSalesItemDetails As DataTable
    Private _dtBillItemDetails As DataTable

#End Region

#Region "Property Declarations"

    Public Property ItemName() As String
        Get
            Return _strItemName
        End Get
        Set(ByVal Value As String)
            _strItemName = Value
        End Set
    End Property

    Public Property ItemDescription() As String
        Get
            Return _strItemDescription
        End Get
        Set(ByVal Value As String)
            _strItemDescription = Value
        End Set
    End Property

    Public Property PresentStock() As Long
        Get
            Return _lngPresentStock
        End Get
        Set(ByVal Value As Long)
            _lngPresentStock = Value
        End Set
    End Property

    Public Property PresentRate() As Long
        Get
            Return _lngPresentRate
        End Get
        Set(ByVal Value As Long)
            _lngPresentRate = Value
        End Set
    End Property

    Public Property SellingPrice() As Long
        Get
            Return _lngSellingPrice
        End Get
        Set(ByVal Value As Long)
            _lngSellingPrice = Value
        End Set
    End Property

    Public Property Unit() As String
        Get
            Return _strUnit
        End Get
        Set(ByVal Value As String)
            _strUnit = Value
        End Set
    End Property

    Public Property ItemType() As String
        Get
            Return _strType
        End Get
        Set(ByVal Value As String)
            _strType = Value
        End Set
    End Property

    Public Property ItemTable() As DataTable
        Get
            Return _dtItemTable
        End Get
        Set(ByVal Value As DataTable)
            _dtItemTable = Value
        End Set
    End Property

    Public Property OrderTable() As DataTable
        Get
            Return _dtOrdertbl
        End Get
        Set(ByVal Value As DataTable)
            _dtOrdertbl = Value
        End Set
    End Property
    Public Property LedgerTable() As DataTable
        Get
            Return _dtLedgertbl
        End Get
        Set(ByVal Value As DataTable)
            _dtLedgertbl = Value
        End Set
    End Property

    Public Property OrderDetailsTable() As DataTable
        Get
            Return _dtOrderDetailstbl
        End Get
        Set(ByVal Value As DataTable)
            _dtOrderDetailstbl = Value
        End Set
    End Property

    Public Property OrderBillDetailsTable() As DataTable
        Get
            Return _dtOrderBillDetailstbl
        End Get
        Set(ByVal Value As DataTable)
            _dtOrderBillDetailstbl = Value
        End Set
    End Property

    Public Property ReceiptNo() As String
        Get
            Return _strReceiptNo
        End Get
        Set(ByVal Value As String)
            _strReceiptNo = Value
        End Set
    End Property

    Public Property SalesDate() As String
        Get
            Return _datSalesDate
        End Get
        Set(ByVal Value As String)
            _datSalesDate = Value
        End Set
    End Property

    Public Property Remarks() As String
        Get
            Return _strRemarks
        End Get
        Set(ByVal Value As String)
            _strRemarks = Value
        End Set
    End Property

    Public Property SubTotal() As String
        Get
            Return _lngSubTotal
        End Get
        Set(ByVal Value As String)
            _lngSubTotal = Value
        End Set
    End Property

    Public Property SalesItemDetails() As DataTable
        Get
            Return _dtSalesItemDetails
        End Get
        Set(ByVal Value As DataTable)
            _dtSalesItemDetails = Value
        End Set
    End Property


    Public Property BillItemDetails() As DataTable
        Get
            Return _dtBillItemDetails
        End Get
        Set(ByVal Value As DataTable)
            _dtBillItemDetails = Value
        End Set
    End Property

#End Region

#Region "Public Variables"
    Dim strSQL As String = ""
#End Region

#Region "Item Master Related Functions"

    Public Function fnItemSave() As Boolean
        If fnIsItemExists() = True Then

            If MsgBox("Item Already Exists do you want to Update", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                strSQL = "Update tradingitemmastertbl set PresentStock='" & _lngPresentStock & "',CostPrice='" & _lngPresentRate & "',SellingPrice ='" & _lngSellingPrice & "',unit='" & _strUnit & "',ItemDesc='" & _strItemDescription & "',Type='" & _strType & "' where itemName='" & _strItemName & "'"

                fnExecuteNonQuery(strSQL)

                MsgBox("Updated SucessFully")

            End If
            Return True
        Else
            strSQL = "insert into tradingitemmastertbl (ItemName,ItemDesc,PresentStock,CostPrice,SellingPrice,unit,Type) values('" & _strItemName & "','" & _strItemDescription & "','" & _lngPresentStock & "','" & _lngPresentRate & "','" & _lngSellingPrice & "','" & _strUnit & "','" & _strType & "')"

            fnExecuteNonQuery(strSQL)

            MsgBox("Added SucessFully")

            Return True
        End If
    End Function


    Public Function fnGetItems() As Boolean

        strSQL = "Select * from tradingitemmastertbl"

        _dtItemTable = fnExecuteQuery(strSQL, 2)

        Return True
    End Function


    Public Function fnIsItemExists() As Boolean

        strSQL = "Select * from tradingitemmastertbl where ItemName='" & _strItemName & "'"

        If fnExecuteQuery(strSQL, 2).Rows.count > 0 Then

            Return True
        Else
            Return False
        End If
    End Function

#End Region

#Region "Bill Master Related Functions"
    Public Function fnSaveOrderdList() As Long
        strSQL = "select ifNull(max(orderno),0) from orderMastertbl"
        Dim lngMaxOrderNo As Long = fnExecuteQuery("select ifNull(Max(orderNo),0)+1 from OrderMastertbl", 2).rows(0).item(0)
        Dim Strsql1 As String = "insert into orderMastertbl(OrderNo) values('" & lngMaxOrderNo & "')"
        fnExecuteNonQuery(Strsql1)
        Return lngMaxOrderNo
    End Function


    Public Function fnGetOrderList() As Boolean
        strSQL = "select orderno from ordermastertbl"
        _dtOrdertbl = fnExecuteQuery(strSQL, 2)
        Return True
    End Function


    Public Function fnGetOrderdItems(ByVal orderNo As Long) As Boolean
        strSQL = "select * from orderdetailstbl where orderno='" & orderNo & "'"
        _dtOrderDetailstbl = fnExecuteQuery(strSQL, 2)
        Return True
    End Function

#End Region

#Region "Sales Related Functions"

    Public Function fnSaveSalesMaster(ByVal lngReceiptNo As Decimal) As Boolean

        ' Dim lngReceiptNo As Long
        'Dim drRow As DataRow
        'lngReceiptNo = fnGetMaxReceiptNo()
        strSQL = "Insert into tradingSalesMastertbl(ReceiptNo,SalesDate,ReferenceNo,Remarks,SubTotal) values ('" & lngReceiptNo & "','" & Format(_datSalesDate, "yyyy-MM-dd") & "','" & _strReceiptNo & "','" & _strRemarks & "','" & _lngSubTotal & "')"
        fnExecuteNonQuery(strSQL)
        '  For Each drRow In _dtSalesItemDetails.Rows
        ' strSQL = "insert into tradingSalesdetailstbl(ReceiptNo,ItemCode,Quantity,ItemCost,Discount,Amount) values('" & lngReceiptNo & "','" & drRow("ItemCode") & "','" & drRow("Quantity") & "','" & drRow("ItemCost") & "','" & drRow("discount") & "','" & drRow("Amount") & "')"
        ' fnExecuteNonQuery(strSQL)
        ' Next
        Return True

        'strSQL = "Insert into tradingSalesMastertbl(ReceiptNo,SalesDate,ReferenceNo,Remarks,SubTotal) values ('" & lngReceiptNo & "','" & Format(_datSalesDate, "yyyy-MM-dd") & "','" & _strReceiptNo & "','" & _strRemarks & "','" & _lngSubTotal & "')"
        ' fnExecuteNonQuery(strSQL)

    End Function
    Public Function fnSaveSalesDetail(ByVal drrow As DataRow, ByVal lngReceiptNo As Double) As Boolean

        strSQL = "insert into tradingSalesdetailstbl(ReceiptNo,ItemCode,Quantity,ItemCost,Discount,Amount) values('" & lngReceiptNo & "','" & drRow("ItemCode") & "','" & drRow("Quantity") & "','" & drRow("ItemCost") & "','" & drRow("discount") & "','" & drRow("Amount") & "')"
        fnExecuteNonQuery(strSQL)
        Return True

    End Function

    Public Function fnGetLedgerNo(ByVal item As String)
        strSQL = "select LedgerNo from tradingitemmastertbl Where ItemName='" & item & "' "
        _dtLedgertbl = fnExecuteQuery(strSQL, 2)

        If _dtLedgertbl.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function fnSaveBillMaster(ByVal lngReceiptNo As Decimal) As Boolean

        'Dim lngReceiptNo As Long
        'Dim drRow As DataRow
        ' lngReceiptNo = fnGetMaxINo()

        strSQL = "Insert into tradeingbillmastertbl(Ino,BillDate,bILLNo,Remarks,SubTotal) values ('" & lngReceiptNo & "','" & Format(_datSalesDate, "yyyy-MM-dd") & "','" & _strReceiptNo & "','" & _strRemarks & "','" & _lngSubTotal & "')"
        fnExecuteNonQuery(strSQL)


        'For Each drRow In _dtBillItemDetails.Rows
        '    strSQL = "insert into tradeingbilldetailstbl(iNo,ItemCode,Quantity,CostPrice,sellingPrice,Discount,Amount) values('" & lngReceiptNo & "','" & drRow("ItemCode") & "','" & drRow("Quantity") & "','" & drRow("CostPrice") & "','" & drRow("SellingPrice") & "','" & drRow("discount") & "','" & drRow("Amount") & "')"
        '    fnExecuteNonQuery(strSQL)
        'Next

        Return True
    End Function

    Public Function fnSaveBillDetails(ByVal drRow As DataRow, ByVal lngReceiptNo As Decimal) As Boolean

        strSQL = "insert into tradeingbilldetailstbl(iNo,ItemCode,Quantity,CostPrice,sellingPrice,Discount,Amount) values('" & lngReceiptNo & "','" & drRow("ItemCode") & "','" & drRow("Quantity") & "','" & drRow("CostPrice") & "','" & drRow("SellingPrice") & "','" & drRow("discount") & "','" & drRow("Amount") & "')"
        fnExecuteNonQuery(strSQL)
        Return True

    End Function

    Public Function fnSaveMaster() As Boolean

        Dim lngReceiptNo As Long
        Dim drRow As DataRow
        lngReceiptNo = fnGetMaxReceiptNo()
        strSQL = "Insert into tradingSalesMastertbl(ReceiptNo,SalesDate,ReferenceNo,Remarks,SubTotal) values ('" & lngReceiptNo & "','" & Format(_datSalesDate, "yyyy-MM-dd") & "','" & _strReceiptNo & "','" & _strRemarks & "','" & _lngSubTotal & "')"
        fnExecuteNonQuery(strSQL)
        For Each drRow In _dtSalesItemDetails.Rows
            strSQL = "insert into tradingSalesdetailstbl(ReceiptNo,ItemCode,Quantity,ItemCost,Discount,Amount) values('" & lngReceiptNo & "','" & drRow("ItemCode") & "','" & drRow("Quantity") & "','" & drRow("ItemCost") & "','" & drRow("discount") & "','" & drRow("Amount") & "')"
            fnExecuteNonQuery(strSQL)
        Next

        Return True
    End Function

    Public Function fnGetMaxReceiptNo() As Long

        strSQL = "select ifNull(Max(ReceiptNo),0) from TradingSalesMastertbl"

        Return fnExecuteQuery(strSQL, 2).rows(0).Item(0) + 1

    End Function

    Public Function fnGetMaxINo() As Long

        strSQL = "select ifNull(Max(INo),0) from tradeingbillmastertbl"

        Return fnExecuteQuery(strSQL, 2).rows(0).Item(0) + 1

    End Function


    Public Function fnGetSalesBills() As Boolean

        strSQL = "Select * from tradingsalesmastertbl"

        _dtSalesItemDetails = fnExecuteQuery(strSQL, 2)

        Return True

    End Function

    Public Function fnGetBills() As Boolean

        strSQL = "Select * from tradeingbillmastertbl"

        _dtBillItemDetails = fnExecuteQuery(strSQL, 2)

        Return True

    End Function

    Public Function fnGetSalesItemDetails(ByVal lngInternalNo As Long)

        strSQL = "Select * from tradingsalesDetailstbl where ReceiptNo='" & lngInternalNo & "'"

        _dtOrderDetailstbl = fnExecuteQuery(strSQL, 2)


    End Function

    Public Function fnGetOrderItemDetails(ByVal lngInternalNo As Long)

        strSQL = "Select * from tradeingbilldetailstbl where iNo='" & lngInternalNo & "'"

        _dtOrderBillDetailstbl = fnExecuteQuery(strSQL, 2)


    End Function




#End Region

End Class
