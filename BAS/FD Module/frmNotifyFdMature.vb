Public Class frmNotifyFdMature

    Private Shared m_FormDefInstance As frmNotifyFdMature
    Private Shared m_InitializingDefInstance As Boolean
    Dim intCounter As Integer = 0
    Dim dvFDAccounts As DataView
    Dim objIntTable As DataTable
    Dim objFDAccount As New clsFDAccount
    Dim strFilter As String = "Name like '%'"
    Dim objfrmFDList As New frmFDList


    Public Shared Property DefInstance() As frmNotifyFdMature
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmNotifyFdMature
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmNotifyFdMature)
            m_FormDefInstance = Value
        End Set
    End Property
    Private Sub frmNotifyFdMature_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 120

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - 10

            x = x - 1
            Me.Location = New Point(x, y)
            Me.Show()
            Me.Opacity = 0
        Loop
        NotifyIconReminder.Visible = True
        NotifyIconReminder.Text = "Fd Reminder"
        Display()

    End Sub

    Private Sub Display()
        Dim lvItem As New ListViewItem
        If objFDAccount.fnGetFDList("FD") Then
            dvFDAccounts = New DataView(objFDAccount.FDTable, strFilter, "FDNo", DataViewRowState.OriginalRows)
        End If
        If Not dvFDAccounts Is Nothing Then
            lvFdReminder.Items.Clear()
            While intCounter < dvFDAccounts.Count
                If (Convert.ToDateTime(dvFDAccounts.Item(intCounter).Item("MatDate"))) <= Date.Today And dvFDAccounts.Item(intCounter).Item("Status") = "A" Then
                    lvItem = lvFdReminder.Items.Add(dvFDAccounts.Item(intCounter).Item("FDNo"))
                End If
                intCounter += 1
            End While
        End If
    End Sub

    Private Sub btnFDClosure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFDClosure.Click
        Me.Close()
        objfrmFDList.Show()
        objfrmFDList.fnLoadFDAccounts(dvFDAccounts)
    End Sub


    Private Sub TimeReminderDisplay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeReminderDisplay.Tick
        ''Me.Opacity = 0
        ''Me.Top -= 10
        ''Me.Opacity += 0.05
        ''If Me.Top <= 200 Then
        ''    TimeReminderDisplay.Stop()
        ''End If
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If NumericUpDown1.Value <> 0 Then
            TimeAdd.Interval = 60 * (NumericUpDown1.Value * 1000)
            TimeAdd.Enabled = True
        End If
        AddHandler TimeAdd.Tick, AddressOf frmNotifyFdMature_Load
        Me.Close()
        GC.KeepAlive(TimeAdd)
    End Sub

    Private Sub NotifyIconReminder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIconReminder.Click
        Me.BringToFront()
    End Sub
End Class