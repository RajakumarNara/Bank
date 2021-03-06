
Module Voucher

    'to get New Voucher Number for the Transaction this no is our Internal reference no
    'New voucher number is calculated based on the voucher Date 

    Function fnVoucherGetNewVNo(ByVal VDate As Date) As Long
        Dim objDT As New DataTable

        strSQL = "SELECT max(VoucherNo) as MaxVoucherNo from FASVoucherMainTbl where VDate='" & Format(VDate, "yyyy-MM-dd") & "'"

        objDT = fnExecuteQuery(strSQL, 2)

        If IsDBNull(objDT.Rows(0).Item("MaxVoucherNo")) = True Then
            Return 1
        Else
            Return objDT.Rows(0).Item("MaxVoucherNo") + 1
        End If

    End Function


    'to get new Serial No for the transaction voucher 
    'it indicates the actual transaction no within the bank

    Function fnVoucherGetNewSlNo() As Long
        Dim objDT As New DataTable

        strSQL = "SELECT max(SlNo) as MaxSlNo from FASVoucherMainTbl"

        objDT = fnExecuteQuery(strSQL, 2)

        If IsDBNull(objDT.Rows(0).Item("MaxSlNo")) = True Then
            Return 1
        Else
            Return objDT.Rows(0).Item("MaxSlNo") + 1
        End If

    End Function


    ' function to enter vouchers 
    Function fnVoucherEnterMain(ByVal VoucherNo As Long, ByVal TypeNo As Integer, ByVal AccountNo As String, ByVal RefNo As String, _
        ByVal VDate As Date, ByVal Amount As Double, ByVal Narration As String, ByVal SlNo As Long, ByVal Restrict As Char) As Boolean

        '*********** PARAMETERS *************
        'VoucherNo      ---- voucher no with respect to date 
        'TypeNo         ---- type voucher entered
        'AccountNo      ---- Account Number of the transaction (customer account no)
        'RefNo          ---- reference no (if any for the voucher) like receipt no, society local voucher no, bill no etc.,
        'VDate          ---- date of voucher entered 
        'Amount         ---- voucher amount 
        'Narration      ---- a brief description of transaction 
        'SlNo           ---- sl no of voucher within the society
        'RestrictUser   ---- a flag representing the user accessibility of voucher 
        '                    in our system we have two types of vouchers system defined(autogenerated) and user defined 

        strSQL = "INSERT into FASVoucherMainTbl values('" & VoucherNo & "','" & TypeNo & "','" & AccountNo & "','" & RefNo & "','" & _
        Format(VDate, "yyyy-MM-dd") & "','" & Amount & "','" & Narration & "','" & SlNo & "','" & Restrict & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function


    'to enter voucher specific sub-details
    Function fnVoucherEnterSub(ByVal VoucherNo As Long, ByVal TypeNo As Integer, ByVal AccountNo As String, ByVal VDate As Date, _
        ByVal Narration As String, ByVal ByTo As String, ByVal LedgerNo As Integer, ByVal Debit As Double, ByVal Credit As Double, ByVal SlNo As Long, _
        ByVal Restrict As Char) As Boolean

        '*********** PARAMETERS *************
        'VoucherNo      ---- voucher no with respect to date 
        'TypeNo         ---- type voucher entered
        'AccountNo      ---- Account No to be refered
        'VDate          ---- date of voucher entered 
        'Narration      ---- a brief description of transaction 
        'ByTo           ---- By or To value to be used
        'LedgerNo       ---- No of Ledger to be affected for the transaction
        'Debit          ---- amount to be debited to the account
        'Credit         ---- amount to be credited to the account, 
        '                    IMPORTANT: either Debit or Credit will be existing for every record, both values are not allowed for any transaction
        'SlNo           ---- sl no of entry within the Voucher (it is different from Voucher Main Sl No)
        'RestrictUser   ---- a flag representing the user accessibility of voucher 
        '                    in our system we have two types of vouchers system defined(autogenerated) and user defined 

        strSQL = "INSERT into FASVoucherSubTbl values('" & VoucherNo & "','" & TypeNo & "','" & AccountNo & "','" & Format(VDate, "yyyy-MM-dd") & "','" & _
        Narration & "','" & ByTo & "','" & LedgerNo & "','" & Debit & "','" & Credit & "','" & SlNo & "','" & Restrict & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function


    'to get Voucher Details for a given Voucher No and Date
    Function fnVoucherGetDetails(ByVal VoucherNo As Long, ByVal VDate As Date) As DataTable

        strSQL = "SELECT Voucher.*, Ledger.Name as Account FROM FASVoucherSubTbl Voucher, FASLedgerTbl Ledger WHERE Voucher.LedgerNo=Ledger.LedgerNo and Voucher.VoucherNo='" & VoucherNo & "' and Voucher.VDate='" & Format(VDate, "yyyy-MM-dd") & "' order by Voucher.SlNo ASC"

        Return fnExecuteQuery(strSQL, 2)

    End Function

    'to get Voucher Details for given dates

    Function fnVoucherGetVouchers(ByVal StartDate As Date, ByVal EndDate As Date) As DataTable
        strSQL = "SELECT Voucher.* , VType.Name as Type FROM FASVoucherMainTbl Voucher, FASVoucherTypeTbl VType WHERE Voucher.TypeNo=VType.TypeNo and Voucher.VDate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "' ORDER BY Voucher.VDate DESC"
        Return fnExecuteQuery(strSQL, 2)
    End Function

    'to get voucher detail for given date and ledgerNo
    Function fnVoucherGetVouchers(ByVal StartDate As Date, ByVal EndDate As Date, ByVal LedgerNo As Integer)
        strSQL = "SELECT VSub.*,VType.Name as Type,Vmain.RefNo FROM FASVoucherMainTbl Vmain,FASVoucherSubTbl Vsub,FASVoucherTypeTbl VType  WHERE VSub.TypeNo=VType.TypeNo  and Vsub.LEdgerNo='" & LedgerNo & "' and Vmain.VoucherNo=Vsub.VoucherNo and Vmain.Vdate=Vsub.Vdate and  VSub.VDate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "' ORDER BY VSub.SlNo ASC"
        Return fnExecuteQuery(strSQL, 2)
    End Function

    Function fnVoucherGetVouchers(ByVal LedgerNo As Integer)
        strSQL = "SELECT VSub.*,VType.Name as Type,Vmain.RefNo FROM FASVoucherMainTbl Vmain,FASVoucherSubTbl Vsub,FASVoucherTypeTbl VType  WHERE VSub.TypeNo=VType.TypeNo  and Vsub.LEdgerNo='" & LedgerNo & "'and Vmain.VoucherNo=Vsub.VoucherNo and Vmain.Vdate=Vsub.Vdate ORDER BY VSub.VDate DESC" 'VSub.SlNo ASC"
        Return fnExecuteQuery(strSQL, 2)
    End Function

    Function fnGetTransferedVouchers(ByVal VoucherType As Integer)
        strSQL = "SELECT VSub.*,VType.Name as Type,Vmain.RefNo FROM FASVoucherMainTbl Vmain,FASVoucherSubTbl Vsub,FASVoucherTypeTbl VType WHERE Vmain.TypeNo=VType.TypeNo and VType.TypeNo='" & VoucherType & "' and Vmain.VoucherNo=Vsub.VoucherNo and Vmain.Vdate=Vsub.Vdate"
        Return fnExecuteQuery(strSQL, 2)
    End Function

    Function fnGetTransferedVoucher(ByVal StartDate As Date, ByVal EndDate As Date, ByVal Vouchertype As Integer, ByVal Payment As Integer, ByVal Receipts As Integer)
        strSQL = "SELECT VSub.*,VType.Name as Type,Vmain.RefNo FROM FASVoucherMainTbl Vmain,FASVoucherSubTbl Vsub,FASVoucherTypeTbl VType WHERE VSub.TypeNo=VType.TypeNo and Vmain.VoucherNo=Vsub.VoucherNo and Vmain.Vdate=Vsub.Vdate and  VSub.VDate BETWEEN '" & Format(StartDate, "yyyy-MM-dd") & "' and '" & Format(EndDate, "yyyy-MM-dd") & "' and VType.TypeNo in('" & Vouchertype & "','" & Payment & "','" & Receipts & "')  ORDER BY VSub.SlNo ASC"
        Return fnExecuteQuery(strSQL, 2)
    End Function

    Public Function fnGetNewRefNo() As Integer
        Dim objDT As New DataTable

        strSQL = "SELECT max(RefNo) as MaxNo FROM fasvouchermaintbl "

        objDT = fnExecuteQuery(strSQL, 2)

        If IsDBNull(objDT.Rows(0).Item("MaxNo")) = True Then
            Return 1
        Else
            Return objDT.Rows(0).Item("MaxNo") + 1
        End If

    End Function

#Region "Transaction Methods"
    ' function to enter vouchers 
    Function fnVoucherEnterMain(ByVal VoucherNo As Long, _
                                ByVal TypeNo As Integer, _
                                ByVal AccountNo As String, _
                                ByVal RefNo As String, _
                                ByVal VDate As Date, _
                                ByVal Amount As Double, _
                                ByVal Narration As String, _
                                ByVal SlNo As Long, _
                                ByVal Restrict As Char, _
                                ByVal objTrans As IDbTransaction) As Boolean

        '*********** PARAMETERS *************
        'VoucherNo      ---- voucher no with respect to date 
        'TypeNo         ---- type voucher entered
        'AccountNo      ---- Account Number of the transaction (customer account no)
        'RefNo          ---- reference no (if any for the voucher) like receipt no, society local voucher no, bill no etc.,
        'VDate          ---- date of voucher entered 
        'Amount         ---- voucher amount 
        'Narration      ---- a brief description of transaction 
        'SlNo           ---- sl no of voucher within the society
        'RestrictUser   ---- a flag representing the user accessibility of voucher 
        '                    in our system we have two types of vouchers system defined(autogenerated) and user defined 

        strSQL = "INSERT into FASVoucherMainTbl values('" & VoucherNo & "','" & TypeNo & "','" & AccountNo & "','" & RefNo & "','" & _
        Format(VDate, "yyyy-MM-dd") & "','" & Amount & "','" & Narration & "','" & SlNo & "','" & Restrict & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

    'to enter voucher specific sub-details
    Function fnVoucherEnterSub(ByVal VoucherNo As Long, _
                              ByVal TypeNo As Integer, _
                              ByVal AccountNo As String, _
                              ByVal VDate As Date, _
                              ByVal Narration As String, _
                              ByVal ByTo As String, _
                              ByVal LedgerNo As Integer, _
                              ByVal Debit As Double, _
                              ByVal Credit As Double, _
                              ByVal SlNo As Long, _
                              ByVal Restrict As Char, _
                              ByVal objTrans As IDbTransaction) As Boolean

        '*********** PARAMETERS *************
        'VoucherNo      ---- voucher no with respect to date 
        'TypeNo         ---- type voucher entered
        'AccountNo      ---- Account No to be refered
        'VDate          ---- date of voucher entered 
        'Narration      ---- a brief description of transaction 
        'ByTo           ---- By or To value to be used
        'LedgerNo       ---- No of Ledger to be affected for the transaction
        'Debit          ---- amount to be debited to the account
        'Credit         ---- amount to be credited to the account, 
        '                    IMPORTANT: either Debit or Credit will be existing for every record, both values are not allowed for any transaction
        'SlNo           ---- sl no of entry within the Voucher (it is different from Voucher Main Sl No)
        'RestrictUser   ---- a flag representing the user accessibility of voucher 
        '                    in our system we have two types of vouchers system defined(autogenerated) and user defined 

        strSQL = "INSERT into FASVoucherSubTbl values('" & VoucherNo & "','" & TypeNo & "','" & AccountNo & "','" & Format(VDate, "yyyy-MM-dd") & "','" & _
        Narration & "','" & ByTo & "','" & LedgerNo & "','" & Debit & "','" & Credit & "','" & SlNo & "','" & Restrict & "')"

        Return fnExecuteNonQuery(strSQL, objTrans)

    End Function

#End Region

End Module
