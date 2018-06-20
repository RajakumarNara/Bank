Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System
Imports System.Windows.Forms

Public Class PendingBiils
    Inherits System.Windows.Forms.Form

#Region "Form Global Variables"

    Dim dvCBPAccounts As DataView
    Dim strFilter As String = "Name like '%'"
    Friend WithEvents dtp As New DateTimePicker
    Dim intCount As Integer
    Dim objCBP As New clsCBPDet

#End Region
    Private Shared m_FormDefInstance As PendingBiils
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As PendingBiils
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New PendingBiils
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As PendingBiils)
            m_FormDefInstance = Value
        End Set
    End Property
    Dim objReportViewer As New frmReportViewer
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim objReportViewer As New frmReportViewer
        Dim cryRpt As New ReportDocument
        cryRpt.Load(Application.StartupPath & "/../Reports/CBPPendingBills.rpt")
        '-----functionality for Parameter passing---myDiscrete
        Dim CAcctNo As New ParameterDiscreteValue
        'Dim FrmDt As New ParameterDiscreteValue
        'Dim ToDate As New ParameterDiscreteValue

        CAcctNo.Value = Convert.ToString(dtpDate.Text)
        cryRpt.SetParameterValue("CBPBillDate", CAcctNo)

        'FrmDt.Value = Convert.ToString(DTPFrom.Text)
        'cryRpt.SetParameterValue("FromDt", FrmDt)

        'ToDate.Value = Convert.ToString(DTPTo.Text)
        'cryRpt.SetParameterValue("ToDt", ToDate)
        objReportViewer.Show()
        objReportViewer.CrystalReportViewer1.ReportSource = cryRpt

    End Sub

    Private Sub PendingBiils_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbType.SelectedIndex = 0
        If objCBP.fnGetCBPPendingDetail Then
            fnLoadCBPAccounts()
        End If
    End Sub
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged, dtp.ValueChanged
        Select Case cmbType.SelectedItem
            Case "Name"
                strFilter = "Name like '" & txtSearch.Text & "%'"
                fnLoadCBPAccounts()
            Case "AccountNo"
                strFilter = "AccountNo like '" & txtSearch.Text & "%'"
                fnLoadCBPAccounts()
            Case "Transfered AccNo"
                strFilter = "TrAccNo like '" & txtSearch.Text & "%'"
                fnLoadCBPAccounts()
            Case "Status"
                strFilter = "ChequeStatus like '" & txtSearch.Text & "%'"
                fnLoadCBPAccounts()
            Case "Type"
                strFilter = "ChequrType like '" & txtSearch.Text & "%'"
                fnLoadCBPAccounts()
            Case "Amount"
                strFilter = "ChequeAmount =" & Val(txtSearch.Text) & ""
                fnLoadCBPAccounts()
        End Select

    End Sub
#Region "Function"

    Function fnLoadCBPAccounts() As Boolean
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        Dim intTotalBal As Integer = 0
        lblMessage.Text = "There are " & objCBP.CBPdetail.Rows.Count & " records found for your search"
        DataGridView1.DataSource = objCBP.CBPdetail
        DataGridView1.Columns(7).DefaultCellStyle.Format = "dd/MM/yyyy"
        DataGridView1.Visible = True
        
    End Function

#End Region




    Public Class CalendarColumn
        Inherits DataGridViewColumn

        Public Sub New()
            MyBase.New(New CalendarCell())
        End Sub

        Public Overrides Property CellTemplate() As DataGridViewCell
            Get
                Return MyBase.CellTemplate
            End Get
            Set(ByVal value As DataGridViewCell)

                ' Ensure that the cell used for the template is a CalendarCell.
                If (value IsNot Nothing) AndAlso _
                    Not value.GetType().IsAssignableFrom(GetType(CalendarCell)) _
                    Then
                    Throw New InvalidCastException("Must be a CalendarCell")
                End If
                MyBase.CellTemplate = value

            End Set
        End Property

    End Class

    Public Class CalendarCell
        Inherits DataGridViewTextBoxCell

        Public Sub New()
            ' Use the short date format.
            Me.Style.Format = "dd-MM-yyyy"
        End Sub

        Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, _
            ByVal initialFormattedValue As Object, _
            ByVal dataGridViewCellStyle As DataGridViewCellStyle)

            ' Set the value of the editing control to the current cell value.
            MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, _
                dataGridViewCellStyle)

            Dim ctl As CalendarEditingControl = _
                CType(DataGridView.EditingControl, CalendarEditingControl)

            ' Use the default row value when Value property is null.
            If (Me.Value Is Nothing) Then
                ctl.Value = CType(Me.DefaultNewRowValue, DateTime)
            Else
                ctl.Value = CType(Me.Value, DateTime)
            End If
        End Sub

        Public Overrides ReadOnly Property EditType() As Type
            Get
                ' Return the type of the editing control that CalendarCell uses.
                Return GetType(CalendarEditingControl)
            End Get
        End Property

        Public Overrides ReadOnly Property ValueType() As Type
            Get
                ' Return the type of the value that CalendarCell contains.
                Return GetType(DateTime)
            End Get
        End Property

        Public Overrides ReadOnly Property DefaultNewRowValue() As Object
            Get
                ' Use the current date and time as the default value.
                Return DateTime.Now
            End Get
        End Property

    End Class

    Class CalendarEditingControl
        Inherits DateTimePicker
        Implements IDataGridViewEditingControl

        Private dataGridViewControl As DataGridView
        Private valueIsChanged As Boolean = False
        Private rowIndexNum As Integer

        Public Sub New()
            Me.Format = DateTimePickerFormat.Custom '.Format("dd-MM-yyyy")
            Me.CustomFormat = "dd/MM/yyyy"


        End Sub

        Public Property EditingControlFormattedValue() As Object _
            Implements IDataGridViewEditingControl.EditingControlFormattedValue

            Get
                Return Me.Value.ToShortDateString()
            End Get

            Set(ByVal value As Object)
                Try
                    ' This will throw an exception of the string is 
                    ' null, empty, or not in the format of a date.
                    Me.Value = DateTime.Parse(CStr(value))
                Catch
                    ' In the case of an exception, just use the default
                    ' value so we're not left with a null value.
                    Me.Value = DateTime.Now
                End Try
            End Set

        End Property

        Public Function GetEditingControlFormattedValue(ByVal context _
            As DataGridViewDataErrorContexts) As Object _
            Implements IDataGridViewEditingControl.GetEditingControlFormattedValue

            Return Me.Value.ToShortDateString()

        End Function

        Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As  _
            DataGridViewCellStyle) _
            Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl

            Me.Font = dataGridViewCellStyle.Font
            Me.CalendarForeColor = dataGridViewCellStyle.ForeColor
            Me.CalendarMonthBackground = dataGridViewCellStyle.BackColor

        End Sub

        Public Property EditingControlRowIndex() As Integer _
            Implements IDataGridViewEditingControl.EditingControlRowIndex

            Get
                Return rowIndexNum
            End Get
            Set(ByVal value As Integer)
                rowIndexNum = value
            End Set

        End Property

        Public Function EditingControlWantsInputKey(ByVal key As Keys, _
            ByVal dataGridViewWantsInputKey As Boolean) As Boolean _
            Implements IDataGridViewEditingControl.EditingControlWantsInputKey

            ' Let the DateTimePicker handle the keys listed.
            Select Case key And Keys.KeyCode
                Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, _
                    Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp

                    Return True

                Case Else
                    Return Not dataGridViewWantsInputKey
            End Select

        End Function

        Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) _
            Implements IDataGridViewEditingControl.PrepareEditingControlForEdit

            ' No preparation needs to be done.

        End Sub

        Public ReadOnly Property RepositionEditingControlOnValueChange() _
            As Boolean Implements _
            IDataGridViewEditingControl.RepositionEditingControlOnValueChange

            Get
                Return False
            End Get

        End Property

        Public Property EditingControlDataGridView() As DataGridView _
            Implements IDataGridViewEditingControl.EditingControlDataGridView

            Get
                Return dataGridViewControl
            End Get
            Set(ByVal value As DataGridView)
                dataGridViewControl = value
            End Set

        End Property

        Public Property EditingControlValueChanged() As Boolean _
            Implements IDataGridViewEditingControl.EditingControlValueChanged

            Get
                Return valueIsChanged
            End Get
            Set(ByVal value As Boolean)
                valueIsChanged = value
            End Set

        End Property

        Public ReadOnly Property EditingControlCursor() As Cursor _
            Implements IDataGridViewEditingControl.EditingPanelCursor

            Get
                Return MyBase.Cursor
            End Get

        End Property

        Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs)

            ' Notify the DataGridView that the contents of the cell have changed.
            valueIsChanged = True
            Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
            MyBase.OnValueChanged(eventargs)

        End Sub

    End Class

    Public Class Form1
        Inherits Form

        Private dataGridView1 As New DataGridView()

        <STAThreadAttribute()> _
        Public Shared Sub Main()
            Application.Run(New Form1())
        End Sub

        Public Sub New()
            Me.dataGridView1.Dock = DockStyle.Fill
            Me.Controls.Add(Me.dataGridView1)
            Me.Text = "DataGridView calendar column demo"
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
            Handles Me.Load

            Dim col As New CalendarColumn()
            Me.dataGridView1.Columns.Add(col)
            Me.dataGridView1.RowCount = 5
            Dim row As DataGridViewRow
            For Each row In Me.dataGridView1.Rows
                row.Cells(0).Value = DateTime.Now
            Next row

        End Sub

    End Class
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()
        Dim i As Integer
        Dim temp As String
        temp = e.ColumnIndex
        If e.ColumnIndex = 1 Then
            i = DataGridView1.CurrentRow.Index
            objCBP.CBPNo = DataGridView1.Item(2, i).Value
            objCBP.Amount = Convert.ToDouble(DataGridView1.Item(6, i).Value)
            objCBP.DepositDate = DataGridView1.Item(7, i).Value
            temp = DataGridView1.Item(0, i).Value
            If temp = "" Then
                MsgBox("Please Select the Clearing Date", MsgBoxStyle.Exclamation)

            Else
                objCBP.ChequeClearedDate = DataGridView1.Item(0, i).Value
                If objCBP.ChequeClearedDate >= objCBP.DepositDate Then
                    'If MsgBox("CBP accountno  :  " & objCBP.CBPNo " " & Chr(13) & "Cheque clearing amount  :  " & txtAmount.Text & " " & Chr(13) & " Type  :  Cash", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    fnGenerateVoucher(objTrans)
                    fnLogEntry(pbUserId, "Cheque clearing by " & objCBP.CBPNo & " Amount " & objCBP.Amount, Date.Now, "Transaction Cheque Clearing ")
                    objTrans.Commit()
                    If MsgBox("You want to make another transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Conform Transaction") = MsgBoxResult.Yes Then
                        objCBP.fnGetCBPPendingDetail()
                        fnLoadCBPAccounts()
                    Else
                        Me.Close()
                    End If
                Else
                    MsgBox("Please Select the Clearing Date Greater then or equual to Deposit Date", MsgBoxStyle.Exclamation)

                End If
                'End If
            End If

            
        End If
    End Sub
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean

        'Loan Repayment With Securety Deposit Dr to repay Loan 

        Dim lngVoucherNo As Long
        Dim lngSlNo As Long
        Dim strLoan As String
        Dim dblRemPrinciple As Double

        lngVoucherNo = fnVoucherGetNewVNo(objCBP.ChequeClearedDate)
        lngSlNo = fnVoucherGetNewSlNo()

        objCBP.fnUpdateCVoucherNo(lngVoucherNo, objTrans)

        Dim strNarration As String = "Cheque Clearing BY " & objCBP.CBPNo & " "

        'voucher details
        fnVoucherEnterMain(lngVoucherNo, 2, objCBP.CBPNo, 0, objCBP.ChequeClearedDate, objCBP.Amount, "Cheque clearing by" & objCBP.Amount, lngSlNo, "Y", objTrans)

        'Credit accounts 
        fnVoucherEnterSub(lngVoucherNo, 2, objCBP.CBPNo, objCBP.ChequeClearedDate, "Cheque clearing by account " & objCBP.CBPNo, "To", 50, 0, objCBP.Amount, 1, "Y", objTrans)

        'Debit Account
        fnVoucherEnterSub(lngVoucherNo, 2, " ", objCBP.ChequeClearedDate, "Cheque clearing by account " & objCBP.CBPNo, "By", 1, objCBP.Amount, 0, 2, "Y", objTrans)

        Return True

    End Function

    
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim objfrmFDCreation As frmCBPCreation
        objfrmFDCreation = frmCBPCreation.DefInstance
        objfrmFDCreation.BringToFront()
        objfrmFDCreation.MdiParent = Me.MdiParent
        objfrmFDCreation.Show()
        objfrmFDCreation = Nothing
    End Sub

End Class