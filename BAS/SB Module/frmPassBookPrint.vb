Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmPassBookPrint
    Dim objSBAccount As New clsSavingsBank
    Dim NoOfLinePrintInPassBook As Integer = 26  ''Here assign the number of lines print on the pass book, it change bank to bank depend on pass book.
    Private Sub btnSBAccSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSBAccSearch.Click
        Dim objSBAccSearch As New frmSBAccSearch
        objSBAccSearch.strSBAccountNo = String.Empty
        objSBAccSearch.ShowDialog(Me)
        If objSBAccSearch.strSBAccountNo <> String.Empty Then
            txtAccountNo.Text = objSBAccSearch.strSBAccountNo
            sbloaddetails()
        End If
        objSBAccSearch.Dispose()
    End Sub
    Sub sbloaddetails()
        If Trim(txtAccountNo.Text) <> String.Empty Then
            If objSBAccount.fnGetSBAccountDetails(Trim(txtAccountNo.Text)) Then
                If objSBAccount.SBAccTable.Rows(0).Item("AccStatus") = "A" Then
                    txtAccountNo.Text = objSBAccount.SBAccTable.Rows(0).Item("AccountNo")
                    txtName.Text = objSBAccount.SBAccTable.Rows(0).Item("Name")
                    txtFatherName.Text = objSBAccount.SBAccTable.Rows(0).Item("FatherName")
                Else
                    MsgBox("Account number " & Trim(txtAccountNo.Text) & " is Closed", MsgBoxStyle.Information)
                    txtAccountNo.Focus()
                    sbClear()
                End If
            Else
                MsgBox("Account number does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                txtAccountNo.Focus()
                sbClear()
            End If
        End If
    End Sub
    Public Sub sbClear()
        txtAccountNo.ResetText()
        txtFatherName.ResetText()
        txtName.ResetText()
    End Sub
    Private Sub btnHomePage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHomePage.Click
        If txtAccountNo.Text = "" Or txtName.Text = "" Then
            MsgBox("Please select the Account Number", MsgBoxStyle.OkOnly)
        Else
            Dim cryRpt As New ReportDocument
            Dim objReportViewer As New frmReportViewer
            cryRpt.Load("E:/BAS_Software/1jun2012_Vasavi Co-operative_RD_penalty_auto_cal/BAS/Reports/PassBookHomePage.rpt")
            '' cryRpt.Load(Application.StartupPath & "/Reports/PassBookHomePage.rpt")
            Dim ActNo As New ParameterDiscreteValue
            ActNo.Value = txtAccountNo.Text
            cryRpt.SetParameterValue("AccountNo", ActNo.Value)
            objReportViewer.Show()
            objReportViewer.CrystalReportViewer1.ReportSource = cryRpt

        End If
    End Sub
    Private Sub btnNewPassBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewPassBook.Click
        If txtAccountNo.Text = "" Or txtName.Text = "" Then
            MsgBox("Please enter correct Society Application Number", MsgBoxStyle.OkOnly)
        Else
            Dim objReportViewer As New frmReportViewer()
            Dim cryRpt As New ReportDocument()
            Dim LastPrintDateApp As DateTime
            Dim PassBookLineNo As Integer = 0
            Dim slNoOld As Integer = 0
            Dim slNoOld1 As Integer = 0
            Dim j As Integer = 0
            Dim slNo As Integer = 0
            Dim NewPassBookNo As Integer = 0
            Dim datedate As String
            Dim datedate1 As String
            Dim AccountNo As String
            Dim TrDate As DateTime
            Dim Narration As String
            Dim ChequeNo As String
            Dim Deposit As Decimal = 0
            Dim Withdraw As Decimal = 0
            Dim PostBalance As Decimal = 0
            Dim WithdrawWithdraw As Decimal = 0
            Dim i As Integer = 0
            Dim SBTranTbl As DataTable
            Dim SBTranTblForOld As DataTable
            fnDeletePassBookContents()
            SBTranTbl = fnGetTransactionDetailsForPassBookReprint(txtAccountNo.Text, dtpNPBFrom.Value, dtpNPBTo.Value)
            If SBTranTbl.Rows.Count > 0 Then
                While (i < SBTranTbl.Rows.Count)                      ''both require
                    '' Merge the below 3 data as Narration.
                    AccountNo = SBTranTbl.Rows(i).Item("AccountNo").ToString()
                    TrDate = Convert.ToDateTime(SBTranTbl.Rows(i).Item("TrDate"))
                    Narration = SBTranTbl.Rows(i).Item("Narration").ToString()
                    ChequeNo = Convert.ToString(SBTranTbl.Rows(i).Item("ChequeNo"))   '' SBTranTbl.Rows[m]["ChequeNo"].ToString();
                    Deposit = Convert.ToString(SBTranTbl.Rows(i).Item("Deposit"))
                    Withdraw = Convert.ToString(SBTranTbl.Rows(i).Item("Withdraw"))
                    PostBalance = Convert.ToDecimal(SBTranTbl.Rows(i).Item("PostBal"))
                    fnInsertToPassBookValue(AccountNo, TrDate, Narration, ChequeNo, Deposit, Withdraw, PostBalance)
                    i = i + 1
                End While
                cryRpt.Load("E:/BAS_Software/1jun2012_Vasavi Co-operative_RD_penalty_auto_cal/BAS/Reports/PassBook.rpt")
                ''  cryRpt.Load("C:/Program Files/Coherent/Pass Book Printing/Reports/PassBook.rpt");
                '''-----functionality for Parameter passing---myDiscrete
                objReportViewer.Show()
                objReportViewer.CrystalReportViewer1.ReportSource = cryRpt
                ''If user Reset the PassBookLine number then exe below code.
                SBTranTblForOld = objSBAccount.fnGetLastPrintDate(txtAccountNo.Text)
                If SBTranTblForOld.Rows.Count > 0 Then
                    For j = 0 To SBTranTblForOld.Rows.Count - 1 Step 1
                        datedate1 = SBTranTblForOld.Rows(j).Item("LastPrintDate").ToString()
                        If datedate1 <> "" Then
                            LastPrintDateApp = Convert.ToDateTime(SBTranTblForOld.Rows(j).Item("LastPrintDate"))
                            PassBookLineNo = Convert.ToInt32(SBTranTblForOld.Rows(j).Item("PassBookLineNo").ToString())
                            slNoOld1 = Convert.ToInt32((SBTranTblForOld.Rows(j).Item("SlNo").ToString()))
                        End If
                    Next
                    objSBAccount.fnInsertNullToLastPrintDate(txtAccountNo.Text, LastPrintDateApp, slNoOld1)
                End If
                NewPassBookNo = SBTranTbl.Rows.Count
                NewPassBookNo = NewPassBookNo Mod NoOfLinePrintInPassBook ''%% NoOfLinePrintInPassBook represent maximum number of lines print in pass book
                If NewPassBookNo = 0 Then
                    NewPassBookNo = NoOfLinePrintInPassBook
                End If
                slNoOld = Convert.ToInt32(SBTranTbl.Rows(i - 1).Item("SlNo"))
                If PassBookLineNo <> NoOfLinePrintInPassBook + 1 Then
                    objSBAccount.fnUpdateSBTransactionTbl(TrDate, NewPassBookNo, txtAccountNo.Text, slNoOld)
                Else
                    objSBAccount.fnUpdateSBTransactionTbl(TrDate, txtAccountNo.Text, slNoOld)
                End If
                j = 0
                While (j < i)
                    slNo = Convert.ToInt32(SBTranTbl.Rows(j).Item("SlNo"))
                    objSBAccount.fnUpdateStatusToOne(slNo)
                    j = j + 1
                End While
            Else
                MsgBox("Their is no transaction to print", MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub
    Private Sub btnOldPassBookPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOldPassBookPrint.Click
        If txtAccountNo.Text = "" Then
            MsgBox("Please enter the SB Account Number", MsgBoxStyle.OkOnly)
        Else
            Dim objReportViewer As New frmReportViewer()
            Dim cryRpt As New ReportDocument()
            Dim LastPrintDateApp As DateTime
            Dim LastPrintDateOld As DateTime
            Dim SBTranTbl As New DataTable()
            Dim PassBookLineNo As Integer = 0
            Dim NewPassBookNo As Integer = 0
            Dim RowCount As Integer = 0
            Dim ActualPrintRows As Integer = 0
            Dim NoOfRowPrint As Integer = 0
            Dim CopyOfRowCount As Integer = 0
            Dim datedate As String
            Dim datedate1 As DateTime
            Dim AccountNo As String
            Dim TrDate As DateTime
            Dim Narration As String
            Dim ChequeNo As String
            Dim Deposit As Decimal
            Dim Withdraw As Decimal
            Dim PostBalance As Decimal
            Dim i As Integer
            Dim j As Integer
            Dim k As Integer
            Dim m As Integer
            Dim temp As Integer
            Dim slNo As Integer
            Dim slNoOld As Integer = 0
            Dim objclsSBPassBook As New clsSavingsBank
            '''arrayOfCRprinted =New ArrayList [12]
            fnDeletePassBookContents()                                               ''require
up:         SBTranTbl = objSBAccount.fnGetLastPrintDate(txtAccountNo.Text)
            If SBTranTbl.Rows.Count > 0 Then
                For i = 0 To SBTranTbl.Rows.Count - 1 Step 1

                    datedate = SBTranTbl.Rows(i).Item("LastPrintDate").ToString()
                    If datedate <> "" Then
                        LastPrintDateApp = Convert.ToDateTime(SBTranTbl.Rows(i).Item("LastPrintDate"))
                        PassBookLineNo = Convert.ToInt32(SBTranTbl.Rows(i).Item("PassBookLineNo").ToString())
                        slNoOld = Convert.ToInt32((SBTranTbl.Rows(i).Item("SlNo").ToString()))
                    End If
                Next
            Else
                SBTranTbl = objSBAccount.fnGetSBTransaction(txtAccountNo.Text)
                Dim FirstTrdate As DateTime = Convert.ToDateTime(SBTranTbl.Rows(0).Item("TRDATE"))
                Dim AcctNo As String = Convert.ToString(SBTranTbl.Rows(0).Item("ACCOUNTNO"))
                objclsSBPassBook.fnSetFirstTimeLastPrintDate(AcctNo, FirstTrdate)
                GoTo up
            End If
            LastPrintDateOld = LastPrintDateApp
            ' //'LastPrintDateApp = Date.ParseExact(datedate, "yyyy-mm-dd", culture)
            SBTranTbl = objclsSBPassBook.fnGetTransactionDetailsForPassBook(txtAccountNo.Text, LastPrintDateApp)
            If (SBTranTbl.Rows.Count > 0) Then
                '//'PassBookNo = Convert.ToInt32(SBTranTbl.Rows(0).Item("PassBookLineNo").ToString())
                '//'fnNullInsertToPassBook() 'this is mandatory for first line of passbook
                RowCount = SBTranTbl.Rows.Count
                '//'RowCount1 = RowCount - 1
                CopyOfRowCount = RowCount
                If (PassBookLineNo >= NoOfLinePrintInPassBook) Then       '//for number of lines print in a page of pass book
                    PassBookLineNo = 0
                End If
                temp = PassBookLineNo + 1
                j = 1   ' ///' null insertion from second line of passbook
                While (j < temp)
                    objclsSBPassBook.fnNullInsertToPassBook()
                    j = j + 1
                End While
                k = PassBookLineNo + 1
                m = 0
                While (m < SBTranTbl.Rows.Count)                     ' ///both require
                    '// //Merge the below 3 data as Narration.
                    'Dim PARTICULARS As String = SBTranTbl.Rows(m).Item("NARRATION").ToString()
                    ' Dim INSTRUMENTNO As String = SBTranTbl.Rows(m).Item("INSTRUMENTNO").ToString()
                    Narration = SBTranTbl.Rows(m).Item("NARRATION").ToString()
                    AccountNo = SBTranTbl.Rows(m).Item("ACCOUNTNO").ToString()
                    TrDate = Convert.ToDateTime(SBTranTbl.Rows(m).Item("TRDATE"))
                    '//TrDate = Convert.ToDateTime(datedate)
                    'Narration = PARTICULARS + INSTRUMENTNO + Narration
                    ChequeNo = Convert.ToString(SBTranTbl.Rows(m).Item("ChequeNo"))
                    Dim Dep As String = Convert.ToString(SBTranTbl.Rows(m).Item("DEPOSIT"))
                    If (Dep.ToString() <> "") Then
                        Deposit = Convert.ToDecimal(Dep)
                    Else
                        Deposit = 0
                    End If
                    Dim Wit As String = Convert.ToString(SBTranTbl.Rows(m).Item("WITHDRAW"))
                    If (Wit.ToString() <> "") Then
                        Withdraw = Convert.ToDecimal(Wit)
                    Else
                        Withdraw = 0
                    End If
                    PostBalance = Convert.ToDecimal(SBTranTbl.Rows(m).Item("postBAL").ToString())
                    objclsSBPassBook.fnInsertToPassBookValue(AccountNo, TrDate, Narration, ChequeNo, Deposit, Withdraw, PostBalance)
                    m = m + 1
                End While
            End If
            If (fnCheck(m)) Then
                ' //below code for insert fresh print date to  lastprintdate column 
                NewPassBookNo = (m + PassBookLineNo) Mod NoOfLinePrintInPassBook  '//NoOfLinePrintInPassBook represent maximum number of lines print in pass book
                If (NewPassBookNo = 0) Then
                    NewPassBookNo = NoOfLinePrintInPassBook
                End If
                datedate1 = Convert.ToDateTime(SBTranTbl.Rows(m - 1).Item("TRDATE"))
                slNo = Convert.ToInt32(SBTranTbl.Rows(m - 1).Item("SlNo").ToString())
                '//LastPrintDateApp = Convert.ToDateTime(datedate1);
                '//datedate = LastPrintDateApp.ToString("yyyy-MM-dd");
                '//below code for insert null to previous lastprintdate column reset
                objclsSBPassBook.fnInsertNullToLastPrintDate(txtAccountNo.Text, LastPrintDateOld, slNoOld)
                '//Above code for insert null to previous lastprintdate column reset
                If (PassBookLineNo <> NoOfLinePrintInPassBook + 1) Then
                    objclsSBPassBook.fnUpdateSBTransactionTbl(datedate1, NewPassBookNo, txtAccountNo.Text, slNo)
                Else
                    objclsSBPassBook.fnUpdateSBTransactionTbl(datedate1, txtAccountNo.Text, slNo)
                End If
                '//Above code for insert fresh print date to  lastprintdate column 
                '////'crystal R code
                '////'cryRpt.Load(Application.StartupPath & "/../PassBook.rpt")
                '//cryRpt.Load(Application.StartupPath + "/PassBookPrint.rpt");
                'cryRpt.Load("E:/BAS_Software/Copy of BASPassBookPrinting_C#/BASPassBookPrinting/Reports/PassBook.rpt")
                ''cryRpt.Load("C:/Program Files/Coherent/Pass Book Printing/Reports/PassBookPrint.rpt")
                cryRpt.Load("E:/BAS_Software/9jun2012_Vasavi Co-operative_fd_int_trans_form/BAS/Reports/PassBook.rpt")
                ''  cryRpt.Load("C:/Program Files/Coherent/Pass Book Printing/Reports/PassBook.rpt");
                ' //cryRpt.Load("C:/Program Files/Coherent/Pass Book Printing/Reports/PassBook.rpt");
                '////'-----functionality for Parameter passing---myDiscrete
                objReportViewer.CrystalReportViewer1.ReportSource = cryRpt
                objReportViewer.Show()
                '////' end of crystal  R code
                i = 0
                While (i < m)
                    slNo = Convert.ToInt32(SBTranTbl.Rows(i).Item("SlNo").ToString())
                    objclsSBPassBook.fnUpdateStatusToOne(slNo)
                    i = i + 1
                End While
            Else
                MessageBox.Show(Me, "Their is no transaction to print", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Function fnCheck(ByVal m As Integer) As Boolean
        If m = 0 Then
            MsgBox("Their is no transaction to print", MsgBoxStyle.OkOnly)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnPassSheetPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPassSheetPrint.Click
        If txtAccountNo.Text = "" Or txtName.Text = "" Then
            MsgBox("Please select the Savings Account Number", MsgBoxStyle.OkOnly)
        Else
            Dim objReportViewer As New frmReportViewer()
            Dim cryRpt As New ReportDocument()
            cryRpt.Load("E:/BAS_Software/9jun2012_Vasavi Co-operative_fd_int_trans_form/BAS/Reports/PassSheet.rpt")
            ''cryRpt.Load("C:/Program Files/Coherent/Pass Book Printing/Reports/PassSheetPrint.rpt")
            Dim ActNo As New ParameterDiscreteValue()
            Dim FromDate As New ParameterDiscreteValue()
            Dim ToDate As New ParameterDiscreteValue()

            ActNo.Value = Convert.ToString(txtAccountNo.Text)
            cryRpt.SetParameterValue("AccountNo", ActNo.Value)

            FromDate.Value = DTPFrom.Value
            cryRpt.SetParameterValue("FromDate", FromDate.Value)

            ToDate.Value = DTPTo.Value
            cryRpt.SetParameterValue("ToDate", ToDate.Value)
            objReportViewer.Show()
            objReportViewer.CrystalReportViewer1.ReportSource = cryRpt

        End If
    End Sub
End Class