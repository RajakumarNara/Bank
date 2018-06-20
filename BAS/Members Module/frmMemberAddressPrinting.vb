Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmMemberAddressPrinting
#Region "Form Global Variables"
    Dim objMember As New clsMember
    Dim dvMembers As DataView
    Public strMemberNo As String
    Dim strFilter As String = "Name like '%'"
    Dim status As Boolean = False
    Dim ProgressBar1_max As Integer = 0
    Dim ListLoadStatus As Boolean = True
    Dim MemberInsertConfirm As Boolean = False
#End Region


    Private Sub frmMemberAddressPrinting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_lvAllMembers()
        ListLoadStatus = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
#Region "Functions"
    'to load members from database

    Function fnLoadMembers()
        lvAllMembers.Items.Clear()
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        If Not dvMembers Is Nothing Then
            lvAllMembers.Refresh()
            ProgressBar1.Maximum = dvMembers.Count
            While intCounter < dvMembers.Count
                lvItem = lvAllMembers.Items.Add(dvMembers.Item(intCounter).Item("MemberNo"))
                'lvItem.UseItemStyleForSubItems = False
                lvItem.SubItems.Add(dvMembers.Item(intCounter).Item("Name"))
                intCounter += 1
                ProgressBar1.Value += 1

            End While
        End If
        ProgressBar1.Value = 0
    End Function

#End Region

    Private Sub btnAddAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAll.Click
        Dim intCounter As Integer = 0
        Dim lvItem As New ListViewItem
        lvSelectedMembers.Refresh()
        ProgressBar1_max = lvAllMembers.Items.Count
        ProgressBar1.Maximum = ProgressBar1_max
        'Start the BackgroundWorker.
        ' BackgroundWorker1.RunWorkerAsync()
        If lvAllMembers.Items.Count <> lvSelectedMembers.Items.Count Then
            For Each item As ListViewItem In lvAllMembers.Items
                For Each item1 As ListViewItem In lvSelectedMembers.Items
                    If (item1.Text = item.Text) Then
                        status = True
                        Exit For
                    Else
                        status = False
                    End If
                Next
                If status = False Then
                    lvSelectedMembers.Items.Add(DirectCast(item.Clone(), ListViewItem))
                    ProgressBar1.Value += 1
                    status = True
                End If
                status = False
            Next
            'BackgroundWorker1.CancelAsync()
        End If
        ProgressBar1.Value = 0
    End Sub

    Private Sub btnRemoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveAll.Click
        lvSelectedMembers.Items.Clear()
    End Sub

    Private Sub btnAddSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSelected.Click
        Dim lvItem As New ListViewItem


        For Each item As ListViewItem In lvAllMembers.SelectedItems
            For Each item1 As ListViewItem In lvSelectedMembers.Items
                If (item1.Text = item.Text) Then
                    status = True
                    Exit For
                Else
                    status = False
                End If
            Next
            If status = False Then
                lvSelectedMembers.Items.Add(DirectCast(item.Clone(), ListViewItem))
                status = True
            End If
            status = False
        Next

    End Sub

    Private Sub btnRemoveSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSelected.Click
        If lvSelectedMembers.SelectedItems.Count > 0 Then
            For Each item As ListViewItem In lvSelectedMembers.SelectedItems
                lvSelectedMembers.Items.Remove(item)
            Next
        Else
            MsgBox("Please select an account from selected members box", MsgBoxStyle.Exclamation, "Info")
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        For i As Integer = 1 To ProgressBar1_max
            ' Wait 100 milliseconds.
            Threading.Thread.Sleep(100)
            ' Report progress.
            BackgroundWorker1.ReportProgress(i)
        Next
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ' Change the value of the ProgressBar to the BackgroundWorker progress.
        ProgressBar1.Value = e.ProgressPercentage
        ' Set the text.
        Me.Text = e.ProgressPercentage.ToString()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

    End Sub

    Private Sub rbAllMembers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAllMembers.CheckedChanged
        If rbAllMembers.Checked = True And ListLoadStatus = False Then
            Load_lvAllMembers()
        End If
    End Sub

    Private Sub rbActiveMembers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbActiveMembers.CheckedChanged
        If rbActiveMembers.Checked = True Then
            If objMember.fnGetMembersTableForPrintingActive Then

                dvMembers = New DataView(objMember.MemberTable, strFilter, "Name", DataViewRowState.OriginalRows)
                fnLoadMembers()
                ListLoadStatus = False
            End If
        End If
    End Sub

    Private Sub rbInActiveMembers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbInActiveMembers.CheckedChanged
        If rbInActiveMembers.Checked = True Then
            If objMember.fnGetMembersTableForPrintingInActive Then
                dvMembers = New DataView(objMember.MemberTable, strFilter, "Name", DataViewRowState.OriginalRows)
                fnLoadMembers()
                ListLoadStatus = False
            Else
                lvAllMembers.Items.Clear()
            End If

        End If
    End Sub
    Function Load_lvAllMembers()
        If objMember.fnGetMembersTableForPrintingAll Then
            dvMembers = New DataView(objMember.MemberTable, strFilter, "Name", DataViewRowState.OriginalRows)
            fnLoadMembers()
        End If
    End Function

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        InsertTblMemberLabelPrint()
        If lvSelectedMembers.Items.Count > 0 Then
            Dim objReportViewer As New frmReportViewer()
            Dim cryRpt As New ReportDocument()
            cryRpt.Load("C:\Program Files\Coherent\BAS\Reports\MemberLabelPrint1.rpt")
            objReportViewer.CrystalReportViewer1.ReportSource = cryRpt
            cryRpt.PrintToPrinter(1, False, 0, 0)
            'objReportViewer.Show()
            lvSelectedMembers.Items.Clear()
        Else
            MsgBox("Please add members in selected member box", MsgBoxStyle.Exclamation, "Info")
        End If
    End Sub
    Function InsertTblMemberLabelPrint()
        If lvSelectedMembers.Items.Count > 0 Then
            'Dim lvItem As New ListViewItem
            Dim copiedItems As ListView.ListViewItemCollection
            copiedItems = lvSelectedMembers.Items
            If objMember.fnDeleteMemberLabelPrint Then
                Dim i As Integer
                ProgressBar1.Maximum = copiedItems.Count
                For i = 0 To lvSelectedMembers.Items.Count - 1

                    Dim copy As String = Convert.ToString(copiedItems(i).Text)
                    objMember.fnInsertMemberLabelPrint(copy)
                    If ProgressBar1.Value < ProgressBar1.Maximum Then
                        ProgressBar1.Value += 1
                    End If
                Next
            Else
                MemberInsertConfirm = True
            End If
            ProgressBar1.Value = 0
        End If
    End Function

    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click
        InsertTblMemberLabelPrint()
        If lvSelectedMembers.Items.Count > 0 Then
            Dim objReportViewer As New frmReportViewer()
            Dim cryRpt As New ReportDocument()
            cryRpt.Load("C:\Program Files\Coherent\BAS\Reports\MemberLabelPrint1.rpt")
            objReportViewer.CrystalReportViewer1.ReportSource = cryRpt
            'cryRpt.PrintToPrinter(1, False, 0, 0)
            objReportViewer.Show()
            lvSelectedMembers.Items.Clear()
        Else
            MsgBox("Please add members in selected member box", MsgBoxStyle.Exclamation, "Info")
        End If
    End Sub
End Class