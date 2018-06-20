Module Receipts

    Function fnReceiptEnterMain(ByVal strReceiptNo As String, ByVal Name As String, ByVal RecDate As Date, ByVal Amount As Double, ByVal Remarks As String) As Boolean

        strSQL = "INSERT INTO ReceiptMainTbl VALUES('" & strReceiptNo & "','" & Name & "','" & Format(RecDate, "yyyy-MM-dd") & "','" & Amount & "','" & Remarks & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function



    Function fnReceiptEnterSub(ByVal strReceiptNo As String, ByVal datRecDate As Date, ByVal Description As String, ByVal Amount As Double, ByVal SlNo As Integer) As Boolean

        strSQL = "INSERT INTO ReceiptSubTbl VALUES('" & strReceiptNo & "','" & Format(datRecDate, "yyyy-MM-dd") & "','" & Description & "','" & Amount & "','" & SlNo & "')"

        Return fnExecuteNonQuery(strSQL)

    End Function


    Function fnReceiptCheckNo(ByVal strReceiptNo As String, ByVal datRecDate As Date) As Boolean

        Dim objDT As DataTable

        strSQL = "SELECT * FROM ReceiptMainTbl WHERE ReceiptNo='" & strReceiptNo & "' and ReceiptDate='" & Format(datRecDate, "yyyy-MM-dd") & "'"

        objDT = fnExecuteQuery(strSQL, 2)

        If objDT.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

End Module
