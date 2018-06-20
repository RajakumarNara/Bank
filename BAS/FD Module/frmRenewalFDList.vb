Public Class frmRenewalFDList
    Inherits System.Windows.Forms.Form
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
    Private components1 As System.ComponentModel.IContainer
#End Region
#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmRenewalFDList
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmRenewalFDList
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmRenewalFDList
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmRenewalFDList)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region
#Region "variables"
    Dim objFDAcc As New clsFDAccount
    Dim lvItem As ListViewItem
    Dim objRenewal As DataTable
#End Region
    Private Sub frmRenewalFDList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim intCounter As Integer = 0
        If objFDAcc.getRenewalFDs() Then
            objRenewal = objFDAcc.RenewalFDTable
            lvRenewalList.Items.Clear()
            While intCounter < objRenewal.Rows.Count
                lvItem = lvRenewalList.Items.Add(intCounter + 1)
                lvItem.SubItems.Add(objRenewal.Rows(intCounter).Item("OldFDNo"))
                lvItem.SubItems.Add(Format(objRenewal.Rows(intCounter).Item("RenewalDate"), "dd-MMM-yyyy"))
                lvItem.SubItems.Add(objRenewal.Rows(intCounter).Item("OldFDAdditionalDetailID"))
                intCounter += 1
            End While
        Else
            MsgBox("Their is no renewal FDs", MsgBoxStyle.Exclamation, "FD Module")
        End If
    End Sub

    Private Sub lvRenewalList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRenewalList.Click
        If lvRenewalList.SelectedItems.Count > 0 Then
            objFDAcc.FDNo = lvRenewalList.SelectedItems(0).SubItems(1).Text
            objFDAcc.FDAdditionDetailID = lvRenewalList.SelectedItems(0).SubItems(3).Text
        End If
        If objFDAcc.getRenewalFDDetails() Then
            objRenewal = objFDAcc.RenewalFDTable
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class