Public Class clsPigmyMachine
    Function ImportData() As DataTable
        Dim _dtSBTransDetailTable As DataTable
        Dim strSQL As String = "SELECT * from ImportToPigmyMachine"
        _dtSBTransDetailTable = fnExecuteQuery(strSQL, 2)
        Return _dtSBTransDetailTable
    End Function

    Function ExportData(ByVal BranchId As String, ByVal CategoryCode As String, ByVal SchemeCode As String, ByVal AccountNo As String, ByVal CustomerId As String, ByVal CustomerName As String, ByVal ClosingBal As String, ByVal AgredAmt As String, ByVal ClosingBalDt As String, ByVal AgentId As String, ByVal AmountCollected As String, ByVal DateOfCollection As String, ByVal BlankSpace As String, ByVal TimeOfCollection As String, ByVal TrNo As String, ByVal Sequence As String)
        '       Dim strSQL As String = "INSERT INTO SBPassBook(TRDATE,NARRATION,ChequeNo,DEPOSIT,WITHDRAW,postBALANCE)"
        '      strSQL = strSQL & " Values( '" & Format(TrDate, "yyyy-MM-dd") & "','" & NARRATION & "','" & ChequeNo & "','" & deposit & "','" & withdraw & "','" & PostBalance & "')"
        fnExecuteQuery(strSQL, 2)
    End Function
End Class
