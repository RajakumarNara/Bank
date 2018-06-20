Imports System.Math
Public Class frmDayEnd
    Inherits System.Windows.Forms.Form
#Region "global variables"
    Dim objCA As New clsCurrentAccount
    Dim MaximumDate As DataTable
    Dim PGbarc As Integer
    Dim objSB As New clsSavingsBank
    Dim rowCount As Integer
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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnExit As NewButton.NewButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnMonthToYear As NewButton.NewButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpNextDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents dtpPostDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDayEnd))
        Me.btnExit = New NewButton.NewButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.btnMonthToYear = New NewButton.NewButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpPostDate = New System.Windows.Forms.DateTimePicker
        Me.DtpNextDate = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.GotFocusColour = System.Drawing.Color.Empty
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnExit.Location = New System.Drawing.Point(376, 240)
        Me.btnExit.LostFocusColour = System.Drawing.Color.Empty
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 48)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.btnMonthToYear)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 144)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Processing"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 104)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(416, 23)
        Me.ProgressBar1.TabIndex = 29
        '
        'btnMonthToYear
        '
        Me.btnMonthToYear.BackColor = System.Drawing.SystemColors.Control
        Me.btnMonthToYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMonthToYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMonthToYear.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonthToYear.ForeColor = System.Drawing.Color.Black
        Me.btnMonthToYear.GotFocusColour = System.Drawing.Color.Empty
        Me.btnMonthToYear.Location = New System.Drawing.Point(16, 32)
        Me.btnMonthToYear.LostFocusColour = System.Drawing.Color.Empty
        Me.btnMonthToYear.Name = "btnMonthToYear"
        Me.btnMonthToYear.Size = New System.Drawing.Size(176, 56)
        Me.btnMonthToYear.TabIndex = 2
        Me.btnMonthToYear.Text = "Process Day End"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Current Date :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Next Date :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpPostDate
        '
        Me.dtpPostDate.CustomFormat = "dd - MMM - yyyy"
        Me.dtpPostDate.Enabled = False
        Me.dtpPostDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPostDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPostDate.Location = New System.Drawing.Point(144, 16)
        Me.dtpPostDate.Name = "dtpPostDate"
        Me.dtpPostDate.Size = New System.Drawing.Size(144, 23)
        Me.dtpPostDate.TabIndex = 24
        Me.dtpPostDate.Value = New Date(2009, 4, 30, 0, 0, 0, 0)
        '
        'DtpNextDate
        '
        Me.DtpNextDate.CustomFormat = "dd - MMM - yyyy"
        Me.DtpNextDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpNextDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpNextDate.Location = New System.Drawing.Point(144, 48)
        Me.DtpNextDate.Name = "DtpNextDate"
        Me.DtpNextDate.Size = New System.Drawing.Size(144, 23)
        Me.DtpNextDate.TabIndex = 1
        Me.DtpNextDate.Value = New Date(2009, 4, 30, 0, 0, 0, 0)
        '
        'frmDayEnd
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(512, 301)
        Me.Controls.Add(Me.DtpNextDate)
        Me.Controls.Add(Me.dtpPostDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDayEnd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Day End"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim objCurrentAccount As New clsCurrentAccount
    Dim objDayEnd As New clsDayEnd

    Dim objRDAccount As New clsRDAccount
    Dim objPigmyAccount As New clsPigmyAccount
    Dim ROI As Double
    Dim intInterestDiff As Integer
    Dim datLastPaid As Date
    Dim dblCalIntrest As Double
    Dim IntTotal As Double = 0

    'FD 
    Dim objFDAccount As New clsFDAccount
    Dim TempSubdays As Integer = 0
    Dim TempSubMonth As Integer = 0
    Dim TempTotalDays As Integer = 0
    Dim tempNOM As Integer = 0
    Dim timeTemp As Date
    Dim bolTemp As Boolean = True
    Dim datFDDate As Date
    Dim bolMonth As Boolean = False
    Dim bolCumulative As Boolean

    Dim objDT As DataTable

    Dim objLoanDetails As New clsLoanDet
    Dim objclsRepayment As New clsRePayment
    Dim objRd As New clsRDAccount
    Dim dtDayDtl As New DataTable
    Dim Today As Date
    Dim AccountNo As String
    Dim Balance As Double
    Dim intCount As Integer
    Dim row As Integer
    Dim AccountNotbl As DataTable
    Dim NoRows As Integer
    Dim BalanceTabel As DataTable
    Dim intLop As Integer = 0

#End Region


    Function fnCheckDate() As Boolean
        Dim MDate As Date
        If (objCA.fnGetMaxDate(date.now)) Then
            

            MsgBox(Date.Now & "th's Day end has already been done", MsgBoxStyle.Exclamation)
            Return False
        Else

            Return True
        End If
    End Function

    Function fnProcessCurrentAccount(ByVal objTrans As IDbTransaction) As Boolean

        Dim dtDayDtl As DataTable
        Dim intCount As Integer
        Dim row As Integer
        Dim AccountNo As String
        Dim Balance As Double
        If (fnCheckDate()) Then
            If (objCA.fnGetDayDetails()) Then
                dtDayDtl = objCA.AccountDetails()
                intCount = dtDayDtl.Rows.Count
                row = 0

                ProgressBar1.Maximum = rowCount
                While (intCount > 0)


                    AccountNo = dtDayDtl.Rows(row).Item("CAccountNo")
                    Balance = dtDayDtl.Rows(row).Item("AvailBalance")
                    Today = dtpPostDate.Value
                    objCA.fnInsertCADetails(AccountNo, Balance, Today, objTrans)


                    intCount -= 1
                    row += 1
                    ProgressBar1.Value += 1
                End While



            End If
            Return True
        Else
            Return False
        End If
    End Function
    Function fnProcessODAccount(ByVal objTrans As IDbTransaction) As Boolean

        If (objRd.fnGetAccountNos()) Then
            dtDayDtl = objRd.AccountNostbl()
            intCount = dtDayDtl.Rows.Count
            row = 0

            While (intCount > 0)


                AccountNo = dtDayDtl.Rows(row).Item("AccountNo")
                Balance = dtDayDtl.Rows(row).Item("Balance")
                Today = dtpPostDate.Value
                objRd.fnInsertODDetails(AccountNo, Balance, Today, objTrans)


                intCount -= 1
                row += 1
                ProgressBar1.Value += 1
            End While



            Return True
        Else
            Return False
        End If
      




    End Function
    Function fnProcessSBAccount(ByVal objTrans As IDbTransaction) As Boolean



        Dim dtDayDtl As DataTable
        Dim intCount As Integer
        Dim row As Integer
        Dim AccountNo As String
        Dim Balance As Double

        If (objSB.fnGetDayDetails()) Then
            dtDayDtl = objSB.AccountDetails()
            intCount = dtDayDtl.Rows.Count
            row = 0


            While (intCount > 0)


                AccountNo = dtDayDtl.Rows(row).Item("AccountNo")
                Balance = dtDayDtl.Rows(row).Item("AvailBalance")
                Today = dtpPostDate.Value
                objSB.fnInsertSBDetails(AccountNo, Balance, Today, objTrans)


                intCount -= 1
                row += 1
                ProgressBar1.Value += 1
            End While

            Return True
        Else
            Return False


        End If

    End Function
    Function fnRefresh()
        Dim dtCrtDate As DataTable
        objCA.fnGetDates()
        dtCrtDate = objCA.MaxNextDate()
        If (dtCrtDate.Rows(0).Item("NextDate") > Date.Now) Then
            dtpPostDate.Value = Date.Now
        Else
            dtpPostDate.Value = dtCrtDate.Rows(0).Item("NextDate")
        End If
        DtpNextDate.Value = dtpPostDate.Value.AddDays(1)
        ProgressBar1.Maximum = 0
        rowCount = 0
    End Function
    Function fnPBLength()

        If (objSB.fnGetDayDetails()) Then
            dtDayDtl = objSB.AccountDetails()
            rowCount = dtDayDtl.Rows.Count + rowCount
        End If
        If (objRd.fnGetAccountNos()) Then
            dtDayDtl = objRd.AccountNostbl()
            rowCount = dtDayDtl.Rows.Count + rowCount
        End If
        If (objCA.fnGetDayDetails()) Then
            dtDayDtl = objCA.AccountDetails()
            rowCount = dtDayDtl.Rows.Count + rowCount
        End If

    End Function
    Private Sub btnMonthToYear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonthToYear.Click
        Dim tblMaxNextDate As DataTable
        Dim MaxNextDate As Date
        Dim check As Boolean
        Dim objTrans As IDbTransaction
        objTrans = fnGetTransaction()
        fnPBLength()
        Try
            If (dtpPostDate.Value < DtpNextDate.Value) Then

                objTrans = fnGetTransaction()

                If (objCA.fnDateEntry = False) Then
                    objCA.fnEnterDate(dtpPostDate.Value, DtpNextDate.Value, objTrans)
                    check = True
                End If
                If (check = False) Then
                    If (objCA.fnGetDates()) Then
                        tblMaxNextDate = objCA.MaxNextDate
                        MaxNextDate = tblMaxNextDate.Rows(0).Item("NextDate")
                        objCA.fnEnterDate(MaxNextDate, DtpNextDate.Value, objTrans)
                    End If
                End If

                If MsgBox("Are You Sure You want To Process End Of Day? ", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    If (fnProcessCurrentAccount(objTrans)) Then
                        If (fnProcessODAccount(objTrans)) Then
                            If (fnProcessSBAccount(objTrans)) Then
                               
                                MsgBox("Day End Processed Successfully" & Chr(13) & "You can Start With a New Day")
                                objTrans.Commit()
                                fnRefresh()

                            End If
                        End If
                    End If

                End If
            Else
                MsgBox("Current date cannot be greater than or equalto nextdate", MsgBoxStyle.Exclamation)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            objTrans.Dispose()

        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmDayEnd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Dim dtCrtDate As DataTable
        If (objCA.fnGetDates()) Then
            dtCrtDate = objCA.MaxNextDate()
            If (IsDBNull(dtCrtDate.Rows(0).Item("NextDate"))) Then
                dtpPostDate.Value = Date.Now
                DtpNextDate.Value = dtpPostDate.Value.AddDays(1)
            Else

                dtpPostDate.Value = dtCrtDate.Rows(0).Item("NextDate")
                DtpNextDate.Value = dtpPostDate.Value.AddDays(1)
            End If
        End If

    End Sub

End Class
