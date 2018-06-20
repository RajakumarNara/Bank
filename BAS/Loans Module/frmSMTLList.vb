Public Class frmSMTLList
    Inherits System.Windows.Forms.Form
#Region "Code to create Instance Object"

    Private Shared m_frmDefInstance As frmSMTLList
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmSMTLList
        Get
            If m_frmDefInstance Is Nothing OrElse m_frmDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_frmDefInstance = New frmSMTLList
                m_InitializingDefInstance = False
            End If
            DefInstance = m_frmDefInstance
        End Get
        Set(ByVal Value As frmSMTLList)
            m_frmDefInstance = Value
        End Set
    End Property
#End Region
#Region "Global Variables"
    Dim dvLoan As New DataView
    Dim objSMTL As New clsSMTLLoan
    Dim strFilter As String = "Name like '%'"

#End Region
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    'Private components As System.ComponentModel.IContainer
#End Region

#Region "UserDefine Function"

    Public Function fnLoadData() As Boolean
        Dim intCount As Integer = 0
        Dim lstvItems As New ListViewItem

        dvLoan.RowFilter = strFilter
        lvLoanList.Items.Clear()
        While intCount < dvLoan.Count

            lstvItems = lvLoanList.Items.Add(dvLoan.Item(intCount).Item("AccountNo"))
            lstvItems.SubItems.Add(dvLoan.Item(intCount).Item("Name"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("SMTLLimit"), "0,00.00"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("Balance"), "0,00.00"))
            lstvItems.SubItems.Add(Format(dvLoan.Item(intCount).Item("IntAmount"), "0,00.00"))
            lstvItems.SubItems.Add(dvLoan.Item(intCount).Item("AccStatus"))
            lstvItems.SubItems.Add(dvLoan.Item(intCount).Item("ROI") * 100)
            intCount += 1

        End While

    End Function


#End Region
    Private Sub frmSMTLList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If objSMTL.fnGetSMTLData() Then
            dvLoan = New DataView(objSMTL.SMTLLoan, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadData()
        End If
    End Sub

    Private Sub txtSearchText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchText.TextChanged

        If cmbSearchBy.SelectedItem = "SMTLNumber" Then
            strFilter = "AccountNo"
            strFilter = "AccountNo like '" & txtSearchText.Text & "%'"
            fnLoadData()

        ElseIf cmbSearchBy.SelectedItem = "Name" Then
            strFilter = "Name"
            strFilter = "Name like '" & txtSearchText.Text & "%'"
            fnLoadData()
        ElseIf cmbSearchBy.SelectedItem = "Status" Then
            strFilter = "AccStatus"
            strFilter = "AccStatus like '" & txtSearchText.Text & "%'"
            fnLoadData()
        End If

    End Sub

    Private Sub NewButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton6.Click
        Me.Close()
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click

        If lvLoanList.SelectedItems.Count > 0 Then
            If objSMTL.fnChekSMTLAccount(lvLoanList.SelectedItems(0).SubItems(0).Text) Then
                Dim ObjWithDraw As New frmSMTLTransaction
                If lvLoanList.SelectedItems(0).SubItems(5).Text <> "A" Then
                    ObjWithDraw.Panel1.Enabled = False
                Else
                    ObjWithDraw.Panel1.Enabled = True
                End If

                ObjWithDraw.txtAccNo.Text = lvLoanList.SelectedItems(0).SubItems(0).Text
                ObjWithDraw.txtName.Text = lvLoanList.SelectedItems(0).SubItems(1).Text
                ObjWithDraw.ShowDialog(Me)
            End If
        Else
            MsgBox("Please select the item from the SMTL list", MsgBoxStyle.Information)
        End If

        'If objOverDraftLoan.fnChekSMTLLAccount(Trim(txtLoanNo.Text)) = True Then
        '    Dim ObjWithDraw As New frmSMTLTransaction
        '    ObjWithDraw.txtAccNo.Text = txtLoanNo.Text
        '    ObjWithDraw.txtName.Text = txtName.Text
        '    ObjWithDraw.ShowDialog(Me)
        'Else
        '    MsgBox("Please Enter Valid SMTL Number", MsgBoxStyle.Information)
        'End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim objfrmSMTLCreation As frmSMTLLoanDetails
        objfrmSMTLCreation = frmSMTLLoanDetails.DefInstance
        objfrmSMTLCreation.BringToFront()
        objfrmSMTLCreation.MdiParent = Me.MdiParent
        objfrmSMTLCreation.Show()
        objfrmSMTLCreation = Nothing
    End Sub

    Private Sub btnRefreshList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshList.Click
        If objSMTL.fnGetSMTLData() Then
            dvLoan = New DataView(objSMTL.SMTLLoan, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadData()
        End If
    End Sub
End Class