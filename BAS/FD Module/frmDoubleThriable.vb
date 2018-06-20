Imports System.Math
Imports System.IO
Public Class frmDoubleThriable
    Inherits Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        If m_FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_FormDefInstance = Me
            End If
        End If

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

    #End Region
#Region "Form Global Variables"

    Dim objCA As New clsCurrentAccount

    Dim lngPersonNo As Long = 0
    Dim objFDAccount As New clsFDAccount
    Dim objMember As New clsMember
    Dim dtInterest As New DataTable
    Dim objPerson As New clsPerson
    Dim bolVisible As Boolean
    Dim bolCumulative As Boolean = False
    Dim bolMonth As Boolean = False
    Dim objSavingsBank As New clsSavingsBank
    Dim dblAvalAmount As Double
    Dim objCurrentAccount As New clsCurrentAccount
    Dim dblOverDrawLimit As Double
    Dim dblCalIntrest As Double
    ''''''''
    Dim TempSubdays As Integer = 0
    Dim TempSubMonth As Integer = 0
    Dim TempTotalDays As Integer = 0
    Dim tempNOM As Integer = 0
    Dim timeTemp As Date
    Dim bolTemp As Boolean = True
    Dim datFDDate As Date
    Dim datFDDateTemp As Date
    Dim datFDMatDate As Date
    Dim dtMasterData As DataTable

    Dim intLedgerNo As Integer
    Public strFDNo As String
    Dim strEducation As String
    Dim strOffAddress As String
    'Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    'Friend WithEvents NaveenSirMtd As System.Windows.Forms.RadioButton
    'Friend WithEvents BTMMethod As System.Windows.Forms.RadioButton
    'Friend WithEvents StandardMtd As System.Windows.Forms.RadioButton
    'Friend WithEvents lvInterest As System.Windows.Forms.ListView
    'Friend WithEvents Sl_No As System.Windows.Forms.ColumnHeader
    'Friend WithEvents Int_Amt As System.Windows.Forms.ColumnHeader
    'Friend WithEvents Int_Date As System.Windows.Forms.ColumnHeader
    'Friend WithEvents Total_Amt As System.Windows.Forms.ColumnHeader
    Dim strOfficeNo As String

    ''
    '
    ' Dim timeTemp As Date

#End Region

#Region "Code to Create Instance Object"

    Private Shared m_FormDefInstance As frmDoubleThriable
    Private Shared m_InitializingDefInstance As Boolean

    Public Shared Property DefInstance() As frmDoubleThriable
        Get
            If m_FormDefInstance Is Nothing OrElse m_FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_FormDefInstance = New frmDoubleThriable
                m_InitializingDefInstance = False
            End If
            DefInstance = m_FormDefInstance
        End Get
        Set(ByVal Value As frmDoubleThriable)
            m_FormDefInstance = Value
        End Set
    End Property

#End Region
#Region "Sub Routines to Load Control Values from Database"


    Sub sbLoadControlValues()
        'to load database values to form controls
        sbLoadOccupation()
        sbLoadReligion()
        sbLoadCaste()
    End Sub


    'To load OccupationTbl values to the Occupation ComboBox control
    Sub sbLoadOccupation()
        Dim objOccupation As New clsOccupation
        If objOccupation.fnGetOccupations Then
            cmbOccupation.DataSource = objOccupation.OccupationTable
            cmbOccupation.DisplayMember = "OccupationName"
            cmbOccupation.ValueMember = "OccupationCode"
        End If
        objOccupation = Nothing
    End Sub


    'To load ReligionTbl values to the Religion ComboBox control
    Sub sbLoadReligion()
        Dim objReligion As New clsReligion
        If objReligion.fnGetReligions Then
            cmbReligion.DataSource = objReligion.ReligionTable
            cmbReligion.DisplayMember = "ReligionName"
            cmbReligion.ValueMember = "ReligionCode"
        End If
        objReligion = Nothing
    End Sub


    'To load CasteTbl values to the Caste ComboBox control
    Sub sbLoadCaste()
        Dim objCaste As New clsCaste
        If objCaste.fnGetCastes Then
            cmbCaste.DataSource = objCaste.CasteTable
            cmbCaste.DisplayMember = "CasteName"
            cmbCaste.ValueMember = "CasteCode"
        End If
        objCaste = Nothing
    End Sub
    'To load SchemeTbl values to the Scheme ComboBox Control
    Sub sbLoadScheme()
        Dim objScheme As New clsFDAccount
        If objScheme.fnGetScheme Then
            cmbSchemeType.DataSource = objScheme.FdMasterTbl
            cmbSchemeType.DisplayMember = "SchemeName"
            cmbSchemeType.ValueMember = "SchemeCode"
            cmbSchemeType.SelectedIndex = -1
        End If
        objScheme = Nothing
    End Sub


#End Region
    Private Sub btnSearchMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchMember.Click
        'Dim objMemberSearch As New frmMemberSearch
        'objMemberSearch.strMemberNo = ""
        'objMemberSearch.ShowDialog(Me)
        'If objMemberSearch.strMemberNo <> "" Then
        '    sbClear()
        '    txtMemberNo.Text = objMemberSearch.strMemberNo
        '    sbGeneral()
        'End If
        'objMemberSearch.Dispose()


        Dim objCustomerList As New frmCustomerSearch
        objCustomerList.strCustomerID = ""
        objCustomerList.ShowDialog(Me)
        If objCustomerList.strCustomerID <> "" Then
            sbClear()
            txtCustomerID.Text = objCustomerList.strCustomerID
            sbLoadCustomer()
        End If
        objCustomerList.Dispose()
    End Sub
    'To clear form control values
    Sub sbClear()

        sbClearPersonal()

        btnSearchMember.Enabled = True
        btnNewMember.Enabled = True
        cmbDepositType.Enabled = True

        cmbAccountType.SelectedIndex = -1
        cmbOpMode.SelectedIndex = -1
        grpFDType.Enabled = True
        grpFDDetails.Enabled = True
        'cmbFDType.SelectedIndex = -1
        txtAccNo.ResetText()
        txtReceiptNo.ResetText()
        txtFDAmount.ResetText()
        txtFDIntAmount.ResetText()
        txtFDROI.ResetText()
        txtFDMatAmount.ResetText()
        txtFDYears.ResetText()
        txtFDMonths.ResetText()
        txtFDDays.ResetText()
        dtpFDMatDate.ResetText()
        txtReceiptNo.ResetText()
        txtBondNo.ResetText()

        If lvInterest.Columns.Count > 4 Then
            lvInterest.Columns.RemoveAt(4)
        End If
        lvInterest.Items.Clear()

        picPhoto.Image = Nothing
        picSignature.Image = Nothing
        txtRemarks.ResetText()
        'Panel2.Enabled = False

        chkFundTransfer.Checked = False
        chkFundTransfer.Enabled = True
        lblAvalBal.ResetText()
        txtTransFund.ResetText()
        txtFDAccountNo.Enabled = True
        cmbSchemeType.SelectedIndex = -1
        btnSBSearch.Enabled = True
        lblAType.Text = "Amount"
        txtFDAccountNo.ReadOnly = False
        cmbPeriod.SelectedIndex = -1

        chkAdd.Checked = False
        chkSubtract.Checked = False
        chkCorrection.Checked = False
        txtCorrectionAmount.ResetText()
        txtCInterest.ResetText()
    End Sub
    'To clear Personal details 
    Sub sbClearPersonal()
        lngPersonNo = 0
        txtCustomerID.ResetText()
        txtCustomerID.Enabled = True
        txtName.ResetText()
        txtFatherName.ResetText()
        dtpDOB.ResetText()
        rdbMale.Checked = True
        rdbMajor.Checked = True
        txtAge.ResetText()
        cmbReligion.SelectedIndex = -1
        cmbCaste.SelectedIndex = -1
        cmbOccupation.SelectedIndex = -1
        txtPermAddress.ResetText()
        txtPresAddress.ResetText()
        txtPhoneNo.ResetText()
        txtMobileNo.ResetText()
        txtIntroNo.ResetText()

    End Sub
    Sub sbLoadCustomer()

        Dim objDT As DataTable
        Dim msStream As MemoryStream
        Try
            If (objPerson.fnGetCustomerID(txtCustomerID.Text)) Then

                objDT = objPerson.PersonTable

                lngPersonNo = objDT.Rows(0).Item("PersonNo")

                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")
                txtName.Text = objDT.Rows(0).Item("Name")

                txtFatherName.Text = objDT.Rows(0).Item("FatherName")
                dtpDOB.Value = CDate(objDT.Rows(0).Item("DOB"))
                txtAge.Text = objDT.Rows(0).Item("Age")

                strEducation = objDT.Rows(0).Item("Education")
                strOffAddress = objDT.Rows(0).Item("OfficeAddress")
                strOfficeNo = objDT.Rows(0).Item("OfficeNo")

                If objDT.Rows(0).Item("Gender") = "M" Then
                    rdbMale.Checked = True
                Else
                    rdbFemale.Checked = True
                End If

                cmbReligion.SelectedValue = objDT.Rows(0).Item("ReligionCode")
                cmbCaste.SelectedValue = objDT.Rows(0).Item("CasteCode")
                cmbOccupation.SelectedValue = objDT.Rows(0).Item("OccupationCode")

                txtPermAddress.Text = objDT.Rows(0).Item("PermAddress")
                txtPresAddress.Text = objDT.Rows(0).Item("PresAddress")
                txtPhoneNo.Text = objDT.Rows(0).Item("PhoneNo")
                txtMobileNo.Text = objDT.Rows(0).Item("MobileNo")


                If Not IsDBNull(objDT.Rows(0).Item("Photo")) Then
                    If objDT.Rows(0).Item("Photo").length > 0 Then
                        '  msStream = New MemoryStream(objDT.Rows(0).Item("Photo"), True)
                        '  msStream.Write(objDT.Rows(0).Item("Photo"), 0, objDT.Rows(0).Item("Photo").length)
                        '  picPhoto.Image = Image.FromStream(msStream)                        
                        picPhoto.Image = Image.FromFile(objDT.Rows(0).Item("Photo"))
                        picPhoto.ImageLocation = objDT.Rows(0).Item("Photo")


                        picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                        '  msStream.Close()
                    End If
                End If

                If Not IsDBNull(objDT.Rows(0).Item("Signature")) Then
                    If objDT.Rows(0).Item("Signature").length > 0 Then
                        ' msStream = New MemoryStream(objDT.Rows(0).Item("Signature"), True)
                        '  msStream.Write(objDT.Rows(0).Item("Signature"), 0, objDT.Rows(0).Item("Signature").length)
                        '  picSignature.Image = Image.FromStream(msStream)

                        picSignature.Image = Image.FromFile(objDT.Rows(0).Item("Signature"))
                        picSignature.ImageLocation = objDT.Rows(0).Item("Signature")


                        picSignature.SizeMode = PictureBoxSizeMode.StretchImage
                        '  msStream.Close()
                    End If
                End If

                txtCustomerID.Enabled = False
                txtName.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

    Private Sub btnNewMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewMember.Click
        'Dim objfrmMemberCreation As frmMemberCreation
        'objfrmMemberCreation = frmMemberCreation.DefInstance
        'objfrmMemberCreation.BringToFront()
        'objfrmMemberCreation.MdiParent = Me.MdiParent
        'objfrmMemberCreation.Show()
        'objfrmMemberCreation = Nothing

        Dim objCustomer As New frmCustomer
        objCustomer = frmCustomer.DefInstance
        objCustomer.MdiParent = Me.MdiParent
        objCustomer.BringToFront()
        objCustomer.Show()
        objCustomer = Nothing
    End Sub

    Private Sub chkFundTransfer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFundTransfer.CheckedChanged
        Dim objDT As DataTable

        If chkFundTransfer.Checked = True Then
            Panel3.Enabled = True

            Dim objAccountSelection As New frmAccountSelection
            objAccountSelection.ShowDialog(Me)
            txtAccNo.Text = objAccountSelection.strAccountNo
            objAccountSelection.Dispose()
            txtFDAmount.ReadOnly = True

            Dim objCA As New clsCurrentAccount
            If txtAccNo.Text <> String.Empty Then
                sbloaddetails()
            End If

        ElseIf chkFundTransfer.Checked = False Then
            Panel3.Enabled = False
            txtTransFund.ResetText()
            txtAccNo.ResetText()
            txtFDAmount.ReadOnly = False
            lblAvalBal.ResetText()
            Label42.Text = "SB No. :"
            lblAType.Text = "Amount"
        End If
    End Sub
    'To Load SB Account Balance Detail

    Sub sbloaddetails()

        Dim strType As String
        strType = Mid(txtAccNo.Text, 1, 2)
        Select Case strType
            Case "SB"
                If objSavingsBank.fnGetSBAccountDetails(Trim(txtAccNo.Text)) Then
                    dblAvalAmount = objSavingsBank.SBAccTable.Rows(0).Item("AvailBalance")
                    lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                    Label42.Text = "SB No. :"
                    lblAType.Text = "Amt From SB "
                Else
                    MsgBox("Account no. does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                    txtAccNo.SelectAll()
                End If
            Case "CA"
                If objCA.fnCheckCAccount(Trim(txtAccNo.Text)) Then
                    dblAvalAmount = objCA.CAAccTable.Rows(0).Item("AvailBalance")
                    lblAvalBal.Text = Format(dblAvalAmount, "0,00.00")
                    Label42.Text = "CA No. :"
                    lblAType.Text = "Amt From CA "
                Else
                    MsgBox("Account no. does not exist!", MsgBoxStyle.Exclamation, Me.Text)
                    txtAccNo.SelectAll()
                End If



        End Select


    End Sub


    Private Sub NewButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton3.Click
        'Dim objMemberSearch As New frmMemberSearch
        'objMemberSearch.strMemberNo = ""
        'objMemberSearch.ShowDialog(Me)
        'If objMemberSearch.strMemberNo <> "" Then
        '    txtIntroNo.Text = objMemberSearch.strMemberNo
        'End If
        'objMemberSearch.Dispose()


        Dim objCustomerList As New frmCustomerSearch
        objCustomerList.strCustomerID = ""
        objCustomerList.ShowDialog(Me)
        If objCustomerList.strCustomerID <> "" Then
            txtIntroNo.Text = objCustomerList.strCustomerID
        End If
        objCustomerList.Dispose()
    End Sub

    Private Sub NewButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton2.Click
        If objFDAccount.fnCheckFDAccount(txtFDAccountNo.Text) Then
            If objFDAccount.FDDetailstbl.Rows(0).Item("Status") = "A" Then
                Dim ObjfrmFDPayments As New frmFDProvision
                ObjfrmFDPayments.txtFDAccountNo.Text = txtFDAccountNo.Text
                Select Case cmbDepositType.SelectedItem
                    Case "FD"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "FD"
                    Case "ENNVY"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "ENNVY"
                    Case "SCC"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "SCC"
                End Select
                ObjfrmFDPayments.txtSchemeType.Visible = True
                ObjfrmFDPayments.txtSchemeType.Text = cmbSchemeType.Text
                ObjfrmFDPayments.cmbSchemeType.Visible = False
                ObjfrmFDPayments.ShowDialog(Me)
            Else
                MsgBox("Account is already closed", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Account number dosent exist", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub NewButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton1.Click
        If objFDAccount.fnCheckFDAccount(txtFDAccountNo.Text) Then
            If objFDAccount.FDDetailstbl.Rows(0).Item("Status") = "A" Then
                Dim ObjfrmFDPayments As New frmFDPayments
                ObjfrmFDPayments.txtFDAccountNo.Text = txtFDAccountNo.Text
                Select Case cmbDepositType.SelectedItem
                    Case "FD"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "FD"
                    Case "ENNVY"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "ENNVY"
                    Case "SCC"
                        ObjfrmFDPayments.cmbDepositType.SelectedItem = "SCC"
                End Select
                ObjfrmFDPayments.txtSchemeType.Visible = True
                ObjfrmFDPayments.txtSchemeType.Text = cmbSchemeType.Text
                ObjfrmFDPayments.cmbSchemeType.Visible = False
                ObjfrmFDPayments.ShowDialog(Me)
            Else
                MsgBox("Account is already closed", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Account no. dosent exist", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        sbClear()
        txtFDAccountNo.ResetText()
        cmbDepositType.SelectedIndex = -1
        'Timer1.Stop()
        TabControl1.SelectedIndex = 0
        cmbDepositType.Focus()
    End Sub

    Private Sub btnTransafer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransafer.Click
        Dim objAccountSelection As New frmAccountSelection
        objAccountSelection.ShowDialog(Me)
        txtTransferAccount.Text = objAccountSelection.strAccountNo
        objAccountSelection.Dispose()
    End Sub
    Function fnCalculateCheck() As Boolean
        If cmbSchemeType.SelectedIndex = -1 Then
            MsgBox("Select Scheme type", MsgBoxStyle.Information)
            cmbSchemeType.Focus()
            Return False
        ElseIf cmbFDType.SelectedIndex = -1 Then
            MsgBox("Select FD type", MsgBoxStyle.Information)
            cmbFDType.Focus()
            Return False
        ElseIf cmbPeriod.SelectedIndex = -1 Then
            MsgBox("Select Interest posting type", MsgBoxStyle.Information)
            cmbPeriod.Focus()
            Return False
        ElseIf txtFDAmount.Text = String.Empty Then
            MsgBox("Please enter amount", MsgBoxStyle.Information)
            txtFDAmount.Focus()
            Return False
        ElseIf txtFDYears.Text = String.Empty And txtFDMonths.Text = String.Empty And txtFDDays.Text = String.Empty Then
            MsgBox("Please enter period", MsgBoxStyle.Information)
            txtFDYears.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If fnCalculateCheck() Then
            If cmbPeriod.SelectedIndex <> -1 Then
                FnCalInterest()
            ElseIf cmbPeriod.SelectedIndex = -1 Then
                MsgBox("Please select interest posting type", MsgBoxStyle.Information)
                cmbPeriod.Focus()
            End If
        End If
    End Sub
    Function FnCalInterest() As Boolean

        If cmbFDType.Text <> "Quarterly" Then
            FnCalIntForOtherThanQterly()
            Return True
        End If
        Dim intNOM As Integer = 0
        Dim intPreNOD As Integer = 0
        Dim intPostNOD As Integer = 0
        Dim intMonth As Integer = 0
        Dim intNODTemp As Integer = 0
        Dim dblFDAmount As Double
        Dim dblInitialFDAmt As Double
        Dim dblIntAmt As Double = 0
        Dim dblIntAmtBelow As Double = 0
        Dim dblFDCumBeforeAmt As Double = 0
        Dim dblTotalInterestAmt As Double = 0
        Dim dblTotalInt As Double = 0
        Dim dblROI As Double = 0
        Dim intCounter1 As Integer = 0
        Dim intCounter As Integer = 0
        Dim Counter As Integer = 0
        Dim lngPeriod As Double = 0
        Dim intIntMode As Integer = 0
        Dim intMode As Integer = 0
        Dim iv As ListViewItem
        Dim dblFDAmt As Double = 0
        Dim x, y As Double
        Dim intTempPeriod As Integer
        Dim dblTempPower As Double

        Dim datNextDate As Date
        Dim datPrevDate As Date
        Dim intDivide As Integer
        Dim datMatdate As Date
        Dim intQuater As Integer = 0
        Dim dtTemp As Date
        TempSubdays = 0
        TempSubMonth = 0
        TempTotalDays = 0
        bolTemp = True

        '''''''''''
        Dim tempMonth As Integer
        Dim temp As Integer = 0
        timeTemp = dtpFDDate.Value
        Dim tempDayAmount As Double = 0
        Dim dblTemp As Double
        Dim dblTempFDTotal As Double
        Dim dblPrev As Double

        Dim FQuater() As Integer
        FQuater = New Integer() {"1", "2", "3"}
        Dim SQuater() As Integer
        SQuater = New Integer() {"4", "5", "6"}
        Dim TQuater() As Integer
        TQuater = New Integer() {"7", "8", "9"}
        Dim FoQuater() As Integer
        FoQuater = New Integer() {"10", "11", "12"}
        datFDDate = CDate(dtpFDDate.Value)
        lngPeriod = DateDiff(DateInterval.Day, dtpFDDate.Value, dtpFDMatDate.Value)
        datMatdate = CDate(dtpFDMatDate.Value)
        Dim PerMonthIntAmt As Double
        Dim PerDayIntAmt As Double
        Dim PerQuerterIntAmt As Double
        Dim Days As Integer
        Dim DayIntermsOfMonth As Decimal
        Dim NoOfQurters As Decimal
        Dim OnlyMonth As Integer
        Dim Number As Decimal
        Dim IntegerResult As Integer
        intCounter = 1
        If fnCheckFDDetails() = True Then
            Try
                'intCounter = 1
                Select Case cmbFDType.SelectedItem.ToString()
                    Case "Monthly"
                        intIntMode = 1
                    Case "Quarterly"
                        intIntMode = 3
                    Case "Half-Yearly"
                        intIntMode = 6
                    Case "Yearly"
                        intIntMode = 12
                End Select
                dblFDAmt = CDbl(txtFDAmount.Text)
                ''select the Scheme Type
                Select Case cmbSchemeType.SelectedItem.ToString()
                    Case "Double"
                        dblIntAmt = dblFDAmt
                    Case "Triple"
                        dblIntAmt = dblFDAmt * 2
                    Case "Lakshadhipathy(87313)"
                        dblIntAmt = 100000 - dblFDAmt
                    Case "Lakshadhipathy(76640)"
                        dblIntAmt = 100000 - dblFDAmt
                    Case "Lakshadhipathy(65980)"
                        dblIntAmt = 100000 - dblFDAmt
                    Case "Lakshadhipathy(53755)"
                        dblIntAmt = 100000 - dblFDAmt
                    Case "Lakshadhipathy(49196)"
                        dblIntAmt = 100000 - dblFDAmt
                End Select
                If txtFDYears.Text <> String.Empty Then
                    'intNOD = (Val(txtFDYears.Text) * 365)
                    intNOM += (Val(txtFDYears.Text) * 12)
                End If
                If txtFDMonths.Text <> String.Empty Then
                    'intNOD += (Val(txtFDMonths.Text) * 30)
                    intNOM += Val(txtFDMonths.Text)
                End If
                datFDDateTemp = dtpFDDate.Value
                '''''''code for total odd days calculation and per day interest calculation.If Next querter date is different from the FDDate 
                If dtpNextDate.Value <> dtpFDDate.Value Then   'If Next querter different from FDDate
                    intPreNOD = DateDiff("d", datFDDateTemp, dtpNextDate.Value)
                    dtpFDDate.Value = dtpNextDate.Value
                End If
                'Code for If NextQuerter date is same as the FDDate 
                If dtpNextDate.Value = dtpFDDate.Value Then
                    datFDDate = CDate(dtpFDDate.Value)
                    NoOfQurters = intNOM / 3 'per year
                    IntegerResult = CInt(Decimal.Truncate(NoOfQurters))  ''Important method for get only inter part of real number
                    intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, datMatdate)
                    While (intNOM / intIntMode) > intCounter
                        datPrevDate = datNextDate
                        datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                        intMonth = datNextDate.Month
                        If (intMonth = 1 Or intMonth = 3 Or intMonth = 5 Or intMonth = 7 Or intMonth = 8 Or intMonth = 10 Or intMonth = 12) Then
                            If (datNextDate.Day = 30) Then
                                datNextDate = DateAdd(DateInterval.Day, 1, datNextDate)
                            End If
                        End If
                        'intMonth = datNextDate.Month
                        datFDDate = datNextDate
                        intCounter += 1
                    End While
                    intPostNOD = DateDiff(DateInterval.Day, datFDDate, datMatdate)   'days for remaining months
                End If
                'NoOfQurters = intNOM / 4
                PerQuerterIntAmt = Round(dblIntAmt / NoOfQurters, 2)
                PerDayIntAmt = Round(PerQuerterIntAmt / (intPreNOD + intPostNOD), 2)
                dtpFDDate.Value = datFDDateTemp
                intCounter = 1
                ''''''code for If Next querter date is different from the FDDate 
                lvInterest.Items.Clear()
                If dtpNextDate.Value <> dtpFDDate.Value Then   'If Next querter different from FDDate
                    datMatdate = dtpFDMatDate.Value
                    'intNOD = DateDiff("d", datFDDateTemp, dtpNextDate.Value)
                    ' dblIntAmtBelow = dblIntAmt * intNOD
                    dtpFDDate.Value = dtpNextDate.Value
                    Counter += 1
                    iv = lvInterest.Items.Add(Counter)
                    iv.SubItems.Add(Round(PerDayIntAmt * intPreNOD, 2))
                    iv.SubItems.Add(Format(dtpNextDate.Value, "dd-MMM-yyyy"))
                    iv.SubItems.Add(Format(Round((PerDayIntAmt * intPreNOD) + dblFDAmt)))
                    dblFDAmt += Math.Round(PerDayIntAmt * intPreNOD, 2)
                    dblTotalInt += Math.Round(PerDayIntAmt * intPreNOD, 2)
                    datFDDate = dtpNextDate.Value
                End If
                'Code for If NextQuerter date is same as the FDDate 
                If dtpNextDate.Value = dtpFDDate.Value Then
                    datFDDate = CDate(dtpFDDate.Value)
                    IntegerResult = CInt(Decimal.Truncate(NoOfQurters))  ''Important method for get only inter part of real number
                    intNOM = DateDiff(DateInterval.Month, dtpFDDate.Value, datMatdate)
                    While (intNOM / intIntMode) > intCounter
                        datPrevDate = datNextDate
                        datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                        iv = lvInterest.Items.Add(intCounter + Counter)
                        intMonth = datNextDate.Month
                        If (intMonth = 1 Or intMonth = 3 Or intMonth = 5 Or intMonth = 7 Or intMonth = 8 Or intMonth = 10 Or intMonth = 12) Then
                            If (datNextDate.Day = 30) Then
                                datNextDate = DateAdd(DateInterval.Day, 1, datNextDate)
                            End If
                        End If
                        iv.SubItems.Add(Round(PerQuerterIntAmt, 2))
                        iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                        iv.SubItems.Add(Format(Round((PerQuerterIntAmt) + (dblFDAmt))))
                        dblFDAmt += Round(PerQuerterIntAmt, 2)
                        dblTotalInt += Round(PerQuerterIntAmt, 2)
                        datFDDate = datNextDate
                        intCounter += 1
                    End While
                    intPostNOD += Val(txtFDDays.Text)  'total remaining days

                    If intPostNOD > 0 Then
                        iv = lvInterest.Items.Add(intCounter + Counter)
                        iv.SubItems.Add(Round(PerDayIntAmt * intPostNOD, 2))
                        iv.SubItems.Add(Format(datMatdate, "dd-MMM-yyyy"))
                        iv.SubItems.Add(Format(Round((PerDayIntAmt * intPostNOD) + dblFDAmt)))
                        datFDDate = DateAdd(DateInterval.Day, intPostNOD, datFDDate)
                        intCounter += 1
                        dblFDAmt += Round(PerDayIntAmt * intPostNOD, 2)
                        dblTotalInt += Round(PerDayIntAmt * intPostNOD, 2)
                        datFDDate = dtpNextDate.Value
                    End If
                    txtFDMatAmount.Text = Convert.ToString(Round(dblFDAmt))
                    txtFDIntAmount.Text = Convert.ToString(Round(dblTotalInt))
                End If
                dtpFDDate.Value = datFDDateTemp
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Function
    Function fnCheckFDDetails() As Boolean
        If cmbFDType.SelectedIndex = -1 Then
            MsgBox("Select interest mode", MsgBoxStyle.Information)
            Me.TabControl1.SelectedTab = Me.tbFDDetails
            fnCheckFDDetails = False
            cmbFDType.Focus()
        ElseIf (Val(txtFDYears.Text) = 0 And Val(txtFDMonths.Text) = 0 And Val(txtFDDays.Text) = 0) Then
            MsgBox("Please enter period of deposit", MsgBoxStyle.Information)
            Me.TabControl1.SelectedTab = Me.tbFDDetails
            Me.TabControl1.SelectedTab = Me.tbFDDetails
            fnCheckFDDetails = False
            txtFDYears.Focus()
        ElseIf cmbPeriod.SelectedIndex = -1 Then
            MsgBox("Please select interest posting type", MsgBoxStyle.Information)
            fnCheckFDDetails = False
            cmbPeriod.Focus()
        ElseIf Val(txtFDAmount.Text) <= 0 Or txtFDAmount.Text = "" Then
            MsgBox("Amount should not be zero", MsgBoxStyle.Information)
            Me.TabControl1.SelectedTab = Me.tbFDDetails
            fnCheckFDDetails = False
        ElseIf cmbSchemeType.SelectedIndex = -1 Then
            MsgBox("Select Double or Triple Scheme", MsgBoxStyle.Information)
            Me.TabControl1.SelectedTab = Me.tbFDDetails
            fnCheckFDDetails = False
            cmbSchemeType.Focus()
        Else
            fnCheckFDDetails = True
        End If
    End Function

    Function FnCalIntForOtherThanQterly()
        Dim intNOM As Integer = 0
        Dim intNOD As Integer = 0
        Dim dblFDAmount As Double
        Dim dblIntAmt As Double = 0
        Dim dblTotalInt As Double = 0
        Dim dblROI As Double = 0
        Dim intCounter1 As Integer = 0
        Dim intCounter As Integer = 0
        Dim lngPeriod As Double = 0
        Dim intIntMode As Integer = 0
        Dim intMode As Integer = 0
        Dim iv As ListViewItem
        Dim dblFDAmt As Double = 0
        Dim x, y As Double
        Dim intTempPeriod As Integer
        Dim dblTempPower As Double

        Dim datNextDate As Date
        Dim intDivide As Integer
        Dim datMatdate As Date
        Dim intQuater As Integer = 0

        TempSubdays = 0
        TempSubMonth = 0
        TempTotalDays = 0
        bolTemp = True

        '''''''''''
        Dim tempMonth As Integer
        Dim temp As Integer = 0
        timeTemp = dtpFDDate.Value
        Dim tempDayAmount As Double = 0
        Dim dblTemp As Double
        Dim dblPrev As Double

        Dim FQuater() As Integer
        FQuater = New Integer() {"1", "2", "3"}
        Dim SQuater() As Integer
        SQuater = New Integer() {"4", "5", "6"}
        Dim TQuater() As Integer
        TQuater = New Integer() {"7", "8", "9"}
        Dim FoQuater() As Integer
        FoQuater = New Integer() {"10", "11", "12"}
        Dim PerMonth As Double
        Dim PerDay As Double
        Dim Days As Integer
        Dim DayIntermsOfMonth As Decimal
        'Below is the method for 30 days used in pavagada BTM for Noncumulative(Simple Interest)
        'Here D day textbox should not be empty or select the '365'
        Try

            If txtFDDays.Text = String.Empty Then
                Select Case cmbFDType.SelectedItem.ToString
                    Case "Monthly"
                        intIntMode = 1
                    Case "Quarterly"
                        intIntMode = 3
                    Case "Half-Yearly"
                        intIntMode = 6
                    Case "Yearly"
                        intIntMode = 12
                End Select
                datFDDate = CDate(dtpFDDate.Value)
                dblFDAmt = CDbl(txtFDAmount.Text)
                dblROI = Val(txtFDROI.Text)
                dblIntAmt = Round((dblFDAmt * dblROI) / (1200 + dblROI), 2) 'IntAmount without days

                If txtFDYears.Text <> String.Empty Then
                    intNOD = (Val(txtFDYears.Text) * 365)
                    intNOM += (Val(txtFDYears.Text) * 12)
                End If
                If txtFDMonths.Text <> String.Empty Then
                    intNOD += (Val(txtFDMonths.Text) * 30)
                    intNOM += Val(txtFDMonths.Text)
                End If
                If txtFDDays.Text <> String.Empty Then
                    intNOD = Val(txtFDDays.Text)
                End If

                ''PerMonth = dblIntAmt / 12

                'PerDay = dblIntAmt / 365
                lvInterest.Items.Clear()
                While (intNOM / intIntMode) > intCounter
                    datNextDate = DateAdd(DateInterval.Month, intIntMode, datFDDate)
                    intNOD = DateDiff(DateInterval.Day, datFDDate, datNextDate)
                    iv = lvInterest.Items.Add(intCounter)
                    iv.SubItems.Add(Round(dblIntAmt))
                    iv.SubItems.Add(Format(datNextDate, "dd-MMM-yyyy"))
                    iv.SubItems.Add(Format(Round(dblIntAmt) + dblFDAmt))
                    dblFDAmt += Round(dblIntAmt)
                    dblTotalInt += Round(dblIntAmt)
                    datFDDate = datNextDate
                    intCounter += 1
                End While
                txtFDIntAmount.Text = (dblTotalInt)
            Else
                MsgBox("Please not give the number of days or select the 'Monthwise'.", MsgBoxStyle.Information, "Deposit Module")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Function

    Private Sub txtFDDays_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFDDays.TextChanged, txtFDYears.TextChanged, txtFDMonths.TextChanged, dtpFDDate.ValueChanged
        sbCalcMatDate()
    End Sub
    'to calculate 'MATURITY DATE' depending on the 'FD DATE' and 'PERIOD'
    Sub sbCalcMatDate()
        dtpFDMatDate.Value = DateAdd(DateInterval.Year, Val(txtFDYears.Text), dtpFDDate.Value)
        dtpFDMatDate.Value = DateAdd(DateInterval.Month, Val(txtFDMonths.Text), dtpFDMatDate.Value)
        dtpFDMatDate.Value = DateAdd(DateInterval.Day, Val(txtFDDays.Text), dtpFDMatDate.Value)
        'If Val(txtFDDays.Text) = 0 Then
        '    dtpFDMatDate.Value = DateAdd(DateInterval.Day, 1, dtpFDMatDate.Value)
        'End If

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        sbClear()
        Me.Close()
    End Sub

    Private Sub frmDoubleThriable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel2.Enabled = True
        cmbSchemeType.Enabled = True
        cmbFDType.Enabled = True

        dtInterest.Columns.Add("SlNo")
        dtInterest.Columns.Add("IntAmount")
        dtInterest.Columns.Add("IntDate")
        dtInterest.Columns.Add("TotalAmount")
        'dtpFDDate.MaxDate = Date.Now
        dtpFDDate.Value = Date.Now
        dtpNextDate.Value = Date.Now
        'dtpDOB.MaxDate = Date.Now
        'dtpDOB.Value = Date.Now
        sbLoadControlValues()
        cmbAccountType.SelectedIndex = -1
        cmbOpMode.SelectedIndex = -1
        cmbSchemeType.SelectedIndex = -1
        cmbFDType.SelectedIndex = 0
        'If txtFDAccountNo.Text <> "FD" And txtFDAccountNo.Text <> "ENNVY" And txtFDAccountNo.Text <> "SCC" And txtFDAccountNo.Text <> "" And txtFDAccountNo.Text <> String.Empty Then
        If strFDNo <> "" Then
            txtFDAccountNo.Text = strFDNo
            sbLoadFD()
        Else
            btnAdd_Click(sender, e)
            cmbDepositType.SelectedIndex = 0
        End If

    End Sub
    Private Sub colDepositType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDepositType.SelectedIndexChanged
        Dim intCout As Integer = 0
        Select Case cmbDepositType.SelectedItem
            Case "FD"
                txtFDAccountNo.Text = "FD"
                intCout = 3
            Case "ENNVY"
                txtFDAccountNo.Text = "ENNVY"
                intCout = 6
            Case "SCC"
                txtFDAccountNo.Text = "SCC"
                intCout = 4
        End Select
        nMode = CTAdd

        If txtFDAccountNo.Text <> String.Empty Then
            Dim Temp As String
            Dim TempNewNo As String = Mid(objFDAccount.fnGetNewFDNo(cmbDepositType.Text), intCout, 8)
            If TempNewNo = "" Then
                TempNewNo = 1
            Else
                TempNewNo += 1
            End If
            If TempNewNo < 99999 Then
                Temp = cmbDepositType.Text & String.Format("{0:00000}", CInt(TempNewNo))
                txtFDAccountNo.Text = Temp
                txtFDAccountNo.Focus()
            Else
                MsgBox("FD number exceeds the maximum alloted number", MsgBoxStyle.Information, "SB Module")
            End If
        End If

    End Sub
    Private Sub btnSearchFD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchFD.Click
        If cmbDepositType.SelectedIndex <> -1 Then
            Dim objFDSearch As New frmFDSearch
            objFDSearch.strFDType = Trim(cmbDepositType.SelectedItem)
            objFDSearch.strFDNo = ""
            objFDSearch.strForm = "DoubleThriableLakshadipathi"
            objFDSearch.ShowDialog(Me)
            If objFDSearch.strFDNo <> "" Then
                txtFDAccountNo.Text = objFDSearch.strFDNo
                sbLoadFD()
                txtName.Focus()
            End If
            objFDSearch.Dispose()
        Else
            MsgBox("Select the deposit type ", MsgBoxStyle.Information)
            cmbDepositType.Focus()
        End If
    End Sub
    ''To load FD Detailst
    Sub sbLoadFD()
        Dim msStream As MemoryStream
        Dim objDT As DataTable
        Dim objIntTable As DataTable
        Panel2.Enabled = False
        cmbSchemeType.Enabled = False
        cmbFDType.Enabled = False
        Try
            If objFDAccount.fnGetDoubleThriableLakshadipathiDetails(txtFDAccountNo.Text) Then
                sbClear()
                objDT = objFDAccount.FDTable

                txtFDAccountNo.Text = objDT.Rows(0).Item("FDNo")
                txtCustomerID.Text = objDT.Rows(0).Item("CustomerID")

                'Preson Detail
                lngPersonNo = objDT.Rows(0).Item("PersonNo")
                txtCustomerID.Enabled = False
                txtName.Text = objDT.Rows(0).Item("Name")

                txtFatherName.Text = objDT.Rows(0).Item("FatherName")
                dtpDOB.Value = CDate(objDT.Rows(0).Item("DOB"))
                txtAge.Text = objDT.Rows(0).Item("Age")

                If objDT.Rows(0).Item("Gender") = "M" Then
                    rdbMale.Checked = True
                Else
                    rdbFemale.Checked = True
                End If

                If objDT.Rows(0).Item("AgeStatus") = "M" Then
                    rdbMajor.Checked = True
                Else
                    rdbMinor.Checked = True
                End If

                cmbReligion.SelectedValue = objDT.Rows(0).Item("ReligionCode")
                cmbCaste.SelectedValue = objDT.Rows(0).Item("CasteCode")
                cmbOccupation.SelectedValue = objDT.Rows(0).Item("OccupationCode")
                txtPermAddress.Text = objDT.Rows(0).Item("PermAddress")
                txtPresAddress.Text = objDT.Rows(0).Item("PresAddress")
                txtPhoneNo.Text = objDT.Rows(0).Item("PhoneNo")
                txtMobileNo.Text = objDT.Rows(0).Item("MobileNo")

                If Not IsDBNull(objDT.Rows(0).Item("Photo")) Then
                    If objDT.Rows(0).Item("Photo").length > 0 Then
                        msStream = New MemoryStream(objDT.Rows(0).Item("Photo"), True)
                        msStream.Write(objDT.Rows(0).Item("Photo"), 0, objDT.Rows(0).Item("Photo").length)
                        picPhoto.Image = Image.FromStream(msStream)
                        picPhoto.SizeMode = PictureBoxSizeMode.StretchImage
                        msStream.Close()
                    End If
                End If

                If Not IsDBNull(objDT.Rows(0).Item("Signature")) Then
                    If objDT.Rows(0).Item("Signature").length > 0 Then
                        msStream = New MemoryStream(objDT.Rows(0).Item("Signature"), True)
                        msStream.Write(objDT.Rows(0).Item("Signature"), 0, objDT.Rows(0).Item("Signature").length)
                        picSignature.Image = Image.FromStream(msStream)
                        picSignature.SizeMode = PictureBoxSizeMode.StretchImage
                        msStream.Close()
                    End If
                End If

                ''btnSearchMember.Enabled = False
                ''btnNewMember.Enabled = False
                ''grpFDType.Enabled = False
                ''grpFDDetails.Enabled = False


                Select Case objDT.Rows(0).Item("AccType").ToString
                    Case "S" : cmbAccountType.SelectedItem = "Single"
                    Case "J" : cmbAccountType.SelectedItem = "Joint"
                End Select

                Select Case objDT.Rows(0).Item("OpMode").ToString
                    Case "E" : cmbOpMode.SelectedItem = "Either"
                    Case "S" : cmbOpMode.SelectedItem = "Either or Survivor"
                    Case "B" : cmbOpMode.SelectedItem = "Both"
                End Select

                txtIntroNo.Text = objDT.Rows(0).Item("IntroName")
                txtAccNo.Text = objDT.Rows(0).Item("AccountNo")

                If objDT.Rows(0).Item("TransferedAmt") = "Y" Then
                    txtTransFund.Text = objDT.Rows(0).Item("FDAmount")
                    'chkFundTransfer.Checked = True
                    '' Panel3.Enabled = False
                End If
                ''chkFundTransfer.Enabled = False


                Select Case objDT.Rows(0).Item("FDScheme").ToString
                    Case "1001" : cmbSchemeType.SelectedItem = "Double"
                    Case "1002" : cmbSchemeType.SelectedItem = "Triple"
                    Case "1003" : cmbSchemeType.SelectedItem = "Lakshadhipathy(87313)"
                    Case "1004" : cmbSchemeType.SelectedItem = "Lakshadhipathy(76640)"
                    Case "1005" : cmbSchemeType.SelectedItem = "Lakshadhipathy(65980)"
                    Case "1006" : cmbSchemeType.SelectedItem = "Lakshadhipathy(53755)"
                    Case "1007" : cmbSchemeType.SelectedItem = "Lakshadhipathy(49196)"
                End Select
                Select Case objDT.Rows(0).Item("IntMode").ToString
                    Case "M" : cmbFDType.SelectedItem = "Monthly"
                    Case "Q" : cmbFDType.SelectedItem = "Quarterly"
                    Case "H" : cmbFDType.SelectedItem = "Half-Yearly"
                    Case "Y" : cmbFDType.SelectedItem = "Yearly"
                    Case "C" : cmbFDType.SelectedItem = "Closure Date"
                End Select

                Select Case objDT.Rows(0).Item("PostingPeriod").ToString
                    Case "P" : cmbPeriod.SelectedItem = "As Scheme Period"
                    Case "E" : cmbPeriod.SelectedItem = "At the end"
                End Select

                txtReceiptNo.Text = objDT.Rows(0).Item("ReceiptNo")
                txtBondNo.Text = objDT.Rows(0).Item("BondNo")
                dtpFDDate.Value = objDT.Rows(0).Item("FDDate")
                txtFDYears.Text = objDT.Rows(0).Item("Years")
                txtFDMonths.Text = objDT.Rows(0).Item("Months")
                txtFDDays.Text = objDT.Rows(0).Item("Days")
                txtFDAmount.Text = objDT.Rows(0).Item("FDAmount")
                ' txtFDROI.Text = objDT.Rows(0).Item("FDROI")
                txtFDIntAmount.Text = objDT.Rows(0).Item("IntAmount")
                txtFDMatAmount.Text = objDT.Rows(0).Item("MatAmount")
                dtpFDMatDate.Value = objDT.Rows(0).Item("MatDate")
                txtRemarks.Text = objDT.Rows(0).Item("Remarks")

                If objDT.Rows(0).Item("Correction") = "Y" Then
                    chkCorrection.Checked = True
                    If objDT.Rows(0).Item("CType") = "A" Then
                        chkAdd.Checked = True
                    ElseIf objDT.Rows(0).Item("CType") = "S" Then
                        chkSubtract.Checked = True
                    End If
                    txtCorrectionAmount.Text = objDT.Rows(0).Item("CAmount")
                End If


                If Not objFDAccount.InterestTable Is Nothing Then
                    objIntTable = objFDAccount.InterestTable
                    Dim intCounter As Integer = 0
                    Dim lvItem As ListViewItem
                    Dim dblSumInterest As Double = 0

                    lvInterest.Columns.Add("Status", 60, HorizontalAlignment.Left)
                    lvInterest.Columns.Add("Renewal", 100, HorizontalAlignment.Left)
                    lvInterest.Items.Clear()
                    If lvInterest.Columns.Count > 6 Then
                        lvInterest.Columns.RemoveAt(6)
                    End If

                    While intCounter < objIntTable.Rows.Count
                        lvItem = lvInterest.Items.Add(intCounter + 1)
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("IntAmount"))
                        dblSumInterest += objIntTable.Rows(intCounter).Item("IntAmount")
                        lvItem.SubItems.Add(Format(objIntTable.Rows(intCounter).Item("IntDate"), "dd-MMM-yyyy"))
                        'lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("IntAmount"))
                        lvItem.SubItems.Add(Round(dblSumInterest))
                        lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Status"))
                        If Convert.ToString(objIntTable.Rows(intCounter).Item("Renewal")) = "" Then
                            lvItem.SubItems.Add("No")
                        Else
                            lvItem.SubItems.Add(objIntTable.Rows(intCounter).Item("Renewal"))
                        End If
                        intCounter += 1
                    End While
                End If
                txtFDAccountNo.ReadOnly = True
                ''txtFDAccountNo.Enabled = False
                ''cmbDepositType.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim objTrans As IDbTransaction
        Try
            objTrans = fnGetTransaction()
            If fnCheck() Then
                If fnSetData() Then
                    If fnSaveData(objTrans) Then
                        objTrans.Commit()
                        If MsgBox("You want to make another transaction?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm Addition") = MsgBoxResult.Yes Then
                            btnAdd_Click(sender, e)
                        Else
                            Me.Close()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            objTrans.Dispose()
        End Try
    End Sub
    'To SAVE data to table, ADD or UPDATE data
    Function fnSaveData(ByVal objTrans As IDbTransaction) As Boolean

        'Check for FD Account Existance
        If objFDAccount.fnCheckFDAccount(txtFDAccountNo.Text) = False Then

            'ADD new FD Account  (ADD Mode)
            If objFDAccount.fnAddDoubleThriableLakshadipathiAccount(objTrans) Then
                fnGenerateVoucher(objTrans)
                'fnGenerateReceipt()
                fnLogEntry(pbUserId, "New deposit created " & txtFDAccountNo.Text, Date.Now, "New Deposit", objTrans)
                MessageBox.Show("New account added successfully.", "Deposit Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New account addition failed, because of internal error.", "Deposit Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        Else

            'Update Details (EDIT Mode)
            If objFDAccount.FDDetailstbl.Rows(0).Item("Status") = "A" Then
                If objFDAccount.fnUpdateFDAccount(objTrans) Then
                    fnLogEntry(pbUserId, "Account Updated " & txtFDAccountNo.Text, Date.Now, "Update Deposit", objTrans)
                    MessageBox.Show("Account updated successfully.", "Deposit Module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Return True
                Else
                    MessageBox.Show("Account updation failed, because of internal error.", "Deposit Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                    Return False
                End If
            Else
                MsgBox("Can not update,account is already closed", MsgBoxStyle.Information)
                Return False
            End If

        End If

    End Function
    'To enter Voucher details
    Function fnGenerateVoucher(ByVal objTrans As IDbTransaction) As Boolean
        Dim lngvoucherno As Long
        Dim lngslno As Long
        lngvoucherno = fnVoucherGetNewVNo(dtpFDDate.Value)
        lngslno = fnVoucherGetNewSlNo()

        If chkFundTransfer.Checked = True And txtTransFund.Text <> String.Empty Then

            Dim strnarration As String = "Transfered to " & txtFDAccountNo.Text

            Dim strType As String = Mid(Trim(txtAccNo.Text), 1, 2)

            Select Case strType

                Case "SB"

                    'transaction entry
                    'Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,bookdeposit,bookwithdraw,postbal,refno,voucherno,type,chequeno) "
                    'strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpFDDate.Value, "yyyy-mm-dd:hh:mm:ss") & "','" & strnarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & Trim(txtReceiptNo.Text) & "','" & lngvoucherno & "','cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by accountno"
                    'fnExecuteNonQuery(strsql, objTrans)

                    Dim strsql = "insert into sbtransactiontbl (accountno,trdate,narration,deposit,withdraw,BookDeposit,BookWithdraw,postbal,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpFDDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strnarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','" & Trim(txtReceiptNo.Text) & "','" & lngvoucherno & "','Cash','0' from sbtransactiontbl where accountno='" & Trim(txtAccNo.Text) & "' group by Accountno"
                    fnExecuteNonQuery(strsql, objTrans)


                    ''voucher details
                    fnVoucherEnterMain(lngvoucherno, 7, txtFDAccountNo.Text, txtReceiptNo.Text, dtpFDDate.Value, txtFDAmount.Text, " Transfered by " & txtAccNo.Text, lngslno, "y", objTrans)

                    ''credit accounts - fixed deposit account
                    fnVoucherEnterSub(lngvoucherno, 7, txtFDAccountNo.Text, dtpFDDate.Value, "Cash recived from account " & txtAccNo.Text & " by " & txtFDAccountNo.Text, "To", intLedgerNo, 0, Val(txtFDAmount.Text), 1, "y", objTrans)

                    ''debit accounts 
                    fnVoucherEnterSub(lngvoucherno, 7, txtAccNo.Text, dtpFDDate.Value, "Cash transfered to account " & txtFDAccountNo.Text & " by " & txtAccNo.Text, "By", 10, Val(txtTransFund.Text), 0, 2, "y", objTrans)

                Case "CA"

                    'transaction entry
                    Dim strsql = "insert into catransactiontbl (caccountno,trdate,narration,deposit,withdraw,BDeposit,BWithdraw,postbal,Interest,refno,voucherno,type,chequeno) "
                    strsql = strsql & " select '" & Trim(txtAccNo.Text) & "','" & Format(dtpFDDate.Value, "yyyy-MM-dd:HH:mm:ss") & "','" & strnarration & "','0','" & Trim(txtTransFund.Text) & "','0','" & Trim(txtTransFund.Text) & "',sum(Deposit)-sum(withdraw)-'" & Trim(txtTransFund.Text) & "','0.00','" & Trim(txtReceiptNo.Text) & "','" & lngvoucherno & "','Cash','0' from catransactiontbl where caccountno='" & Trim(txtAccNo.Text) & "' group by CAccountno"
                    fnExecuteNonQuery(strsql, objTrans)

                    ''voucher details
                    fnVoucherEnterMain(lngvoucherno, 7, txtFDAccountNo.Text, txtReceiptNo.Text, dtpFDDate.Value, txtFDAmount.Text, " Transfered by " & txtAccNo.Text, lngslno, "y", objTrans)

                    ''credit accounts - fixed deposit account
                    fnVoucherEnterSub(lngvoucherno, 7, txtFDAccountNo.Text, dtpFDDate.Value, "Cash recived from account " & txtAccNo.Text & " by " & txtFDAccountNo.Text, "To", intLedgerNo, 0, Val(txtFDAmount.Text), 1, "y", objTrans)

                    ''debit accounts 
                    fnVoucherEnterSub(lngvoucherno, 7, txtAccNo.Text, dtpFDDate.Value, "Cash transfered to account " & txtFDAccountNo.Text & " by " & txtAccNo.Text, "By", 11, Val(txtTransFund.Text), 0, 2, "y", objTrans)

            End Select

        Else

            ''voucher details
            fnVoucherEnterMain(lngvoucherno, 2, txtFDAccountNo.Text, txtReceiptNo.Text, dtpFDDate.Value, txtFDAmount.Text, " By new account " & txtFDAccountNo.Text, lngslno, "y", objTrans)

            ''credit accounts - fixed deposit account
            fnVoucherEnterSub(lngvoucherno, 2, txtFDAccountNo.Text, dtpFDDate.Value, "By account " & txtFDAccountNo.Text, "to", intLedgerNo, 0, Val(txtFDAmount.Text), 1, "y", objTrans)

            ''debit accounts - cash account
            fnVoucherEnterSub(lngvoucherno, 2, "", dtpFDDate.Value, "By account " & txtFDAccountNo.Text, "by", 1, Val(txtFDAmount.Text), 0, 2, "y", objTrans)

        End If

        Return True

    End Function
    'To check data entered by the User, function called when "OK" button is clicked 
    Function fnCheck() As Boolean
        If cmbDepositType.SelectedIndex = -1 Then
            MsgBox("Select deposit type", MsgBoxStyle.Information)
            cmbDepositType.Focus()
            Return False
        ElseIf txtFDAccountNo.Text = "FD" Or txtFDAccountNo.Text = "ENNVY" Or txtFDAccountNo.Text = "SCC" Then
            MsgBox("Enter account no.", MsgBoxStyle.Information)
            txtFDAccountNo.Focus()
            Return False
        ElseIf txtName.Text = "" Then
            MsgBox("Enter name ", MsgBoxStyle.Information)
            txtName.Focus()
            Return False
        ElseIf txtFatherName.Text = "" Then
            MsgBox("Enter father name ", MsgBoxStyle.Information)
            txtFatherName.Focus()
            Return False
        ElseIf Val(txtAge.Text) = 0 Then
            MsgBox("Enter age ", MsgBoxStyle.Information)
            txtAge.Focus()
            Return False
        ElseIf cmbAccountType.SelectedItem = "" Then
            MsgBox("Please select type of account", MsgBoxStyle.Exclamation, "Deposit Module")
            cmbAccountType.Focus()
            Return False
        ElseIf cmbOpMode.SelectedItem = "" Then
            MsgBox("Please select mode of operation", MsgBoxStyle.Exclamation, "Deposit Module")
            cmbOpMode.Focus()
            Return False
        ElseIf chkFundTransfer.Checked = True And Val(txtTransFund.Text) = 0 Then
            MsgBox("Please enter the transferting amount from SB", MsgBoxStyle.Exclamation, "Deposit Module")
            txtTransFund.Focus()
            Return False
        ElseIf txtPermAddress.Text = "" Then
            MsgBox("Enter address", MsgBoxStyle.Information)
            txtPermAddress.Focus()
            Return False
        ElseIf fnCheckFDDetails() = False Then
            Return False
        ElseIf Val(txtFDIntAmount.Text) = 0 Or lvInterest.Items.Count = 0 Then
            MsgBox("Run calculate", MsgBoxStyle.Information)
            btnCalculate.Focus()
            Return False
        ElseIf txtReceiptNo.Text = "" Then
            MsgBox("Enter receipt no.", MsgBoxStyle.Information)
            txtReceiptNo.Focus()
            Return False
        ElseIf txtBondNo.Text = String.Empty Then
            MsgBox("Please enter bond no.", MsgBoxStyle.Exclamation, "Deposit Module")
            txtBondNo.Focus()
            Return False
        ElseIf objFDAccount.fnCheckFDAccount(txtFDAccountNo.Text) = False And fnReceiptCheckNo(txtReceiptNo.Text, dtpFDDate.Value) = True Then
            MsgBox("Receipt no already exists. Enter correct receipt no.", MsgBoxStyle.Information)
            txtReceiptNo.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    'To set form control values to Class Properties, function called when "OK" button is clicked

    Function fnSetData() As Boolean
        Dim intCounter As Integer = 0
        Dim dtRow As DataRow
        Try
            If lngPersonNo <> 0 Then
                objFDAccount.PersonNo = lngPersonNo
            Else
                objFDAccount.PersonNo = objFDAccount.fnGetNewPersonNo()
            End If
            objFDAccount.Name = txtName.Text
            objFDAccount.CustomerID = txtCustomerID.Text
            objFDAccount.SBNo = txtAccNo.Text
            objFDAccount.FatherName = txtFatherName.Text
            objFDAccount.PermAddress = txtPermAddress.Text
            objFDAccount.PresAddress = txtPresAddress.Text
            objFDAccount.PhoneNo = txtPhoneNo.Text
            objFDAccount.MobileNo = txtMobileNo.Text
            objFDAccount.DOB = dtpDOB.Value
            objFDAccount.Age = txtAge.Text
            objFDAccount.AgeStatus = IIf(Val(txtAge.Text) > 18, "M", "N")
            objFDAccount.Gender = IIf(rdbMale.Checked = True, "M", "F")
            objFDAccount.ReligionCode = cmbReligion.SelectedValue
            objFDAccount.CasteCode = cmbCaste.SelectedValue
            objFDAccount.OccupationCode = cmbOccupation.SelectedValue
            ' objFDAccount.Photo = fnGetPhoto()
            objFDAccount.Photo = picPhoto.ImageLocation

            ' objFDAccount.Sign = fnGetSign()
            objFDAccount.Sign = picSignature.ImageLocation
            objFDAccount.OfficeNo = strOfficeNo
            objFDAccount.OffAddress = strOffAddress
            objFDAccount.Education = strEducation

            'objFDAccount.MemberNo = txtMemberNo.Text
            'objFDAccount.SBNo = txtSBNo.Text
            objFDAccount.FDNo = txtFDAccountNo.Text

            If cmbAccountType.SelectedItem = "Single" Then
                objFDAccount.AccountType = "S"
            ElseIf cmbAccountType.SelectedItem = "Joint" Then
                objFDAccount.AccountType = "J"
            End If


            Select Case cmbSchemeType.SelectedItem
                Case "Double"
                    objFDAccount.SchemeCode = 1001
                Case "Triple"
                    objFDAccount.SchemeCode = 1002
                Case "Lakshadhipathy(87313)"
                    objFDAccount.SchemeCode = 1003
                Case "Lakshadhipathy(76640)"
                    objFDAccount.SchemeCode = 1004
                Case "Lakshadhipathy(65980)"
                    objFDAccount.SchemeCode = 1005
                Case "Lakshadhipathy(53755)"
                    objFDAccount.SchemeCode = 1006
                Case "Lakshadhipathy(49196)"
                    objFDAccount.SchemeCode = 1007
            End Select

            If cmbOpMode.SelectedItem = "Either" Then
                objFDAccount.OpMode = "E"
            ElseIf cmbOpMode.SelectedItem = "Either or Survivor" Then
                objFDAccount.OpMode = "S"
            ElseIf cmbOpMode.SelectedItem = "Both" Then
                objFDAccount.OpMode = "B"
            End If

            objFDAccount.IntroName = txtIntroNo.Text
            '  objFDAccount.SchemeCode = cmbSchemeType.SelectedValue


            If cmbFDType.SelectedItem = "Monthly" Then
                objFDAccount.IntMode = "M"
            ElseIf cmbFDType.SelectedItem = "Quarterly" Then
                objFDAccount.IntMode = "Q"
            ElseIf cmbFDType.SelectedItem = "Half-Yearly" Then
                objFDAccount.IntMode = "H"
            ElseIf cmbFDType.SelectedItem = "Yearly" Then
                objFDAccount.IntMode = "Y"
            End If

            If chkFundTransfer.Checked = True Then
                objFDAccount.ChTransferAmount = "Y"
            Else
                objFDAccount.ChTransferAmount = "N"
            End If

            If cmbPeriod.SelectedItem = "At the end" Then
                objFDAccount.chPostingPeriod = "E"
                'ElseIf cmbPeriod.SelectedItem = "As Scheme Period" Then
                '    objFDAccount.chPostingPeriod = "P"
            End If

            Select Case cmbDepositType.SelectedItem
                Case "FD"
                    intLedgerNo = 27
                Case "ENNVY"
                    intLedgerNo = 53
                Case "SCC"
                    intLedgerNo = 54
            End Select


            If chkCorrection.Checked = True Then
                objFDAccount.Correction = "Y"
            Else
                objFDAccount.Correction = "N"
            End If

            If chkAdd.Checked = True Then
                objFDAccount.CorrectioType = "A"
            ElseIf chkSubtract.Checked = True Then
                objFDAccount.CorrectioType = "S"
            Else
                objFDAccount.CorrectioType = "N"
            End If

            objFDAccount.CAmount = Val(txtCorrectionAmount.Text)
            objFDAccount.TransferAccNo = txtTransferAccount.Text

            objFDAccount.FDDate = dtpFDDate.Value
            objFDAccount.FDAmount = Val(txtFDAmount.Text)
            objFDAccount.FDYears = Val(txtFDYears.Text)
            objFDAccount.FDMonths = Val(txtFDMonths.Text)
            objFDAccount.FDDays = Val(txtFDDays.Text)
            objFDAccount.FDROI = Val(txtFDROI.Text)
            objFDAccount.IntAmount = Val(txtFDIntAmount.Text)
            objFDAccount.MatAmount = Val(txtFDMatAmount.Text)
            objFDAccount.MatDate = dtpFDMatDate.Value

            dtInterest.Rows.Clear()
            While intCounter < lvInterest.Items.Count
                dtRow = dtInterest.NewRow
                dtRow.Item("SlNo") = lvInterest.Items(intCounter).SubItems(0).Text
                dtRow.Item("IntAmount") = lvInterest.Items(intCounter).SubItems(1).Text
                dtRow.Item("IntDate") = lvInterest.Items(intCounter).SubItems(2).Text
                dtRow.Item("TotalAmount") = lvInterest.Items(intCounter).SubItems(3).Text
                dtInterest.Rows.Add(dtRow)
                intCounter += 1
            End While
            objFDAccount.InterestTable = dtInterest
            objFDAccount.VoucherNo = fnVoucherGetNewVNo(dtpFDDate.Value)
            objFDAccount.ReceiptNo = txtReceiptNo.Text
            objFDAccount.BondNo = txtBondNo.Text
            objFDAccount.Status = "Active"
            objFDAccount.Remarks = txtRemarks.Text

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    'To get Byte array for Photo object, function called while setting values to the Class Properties
    Function fnGetPhoto() As Byte()
        Try
            If Not picPhoto.Image Is Nothing Then
                Dim msStream As New MemoryStream
                Dim bytArr() As Byte
                picPhoto.Image.Save(msStream, picPhoto.Image.RawFormat)
                bytArr = msStream.GetBuffer
                msStream.Close()
                Return bytArr
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    'To get Byte array for Signature object, function called while setting values to the Class Properties
    Function fnGetSign() As Byte()
        Try
            If Not picSignature.Image Is Nothing Then
                Dim msStream As New MemoryStream
                Dim bytArr() As Byte
                picSignature.Image.Save(msStream, picSignature.Image.RawFormat)
                bytArr = msStream.GetBuffer
                msStream.Close()
                Return bytArr
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub cmbSchemeType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSchemeType.SelectedIndexChanged
        If cmbSchemeType.SelectedItem = "Lakshadhipathy  87313" Then
            txtFDAmount.Text = 87313
            txtFDYears.Text = 1
            txtFDMonths.Text = 3
        ElseIf cmbSchemeType.SelectedItem = "Lakshadhipathy(76640)" Then
            txtFDAmount.Text = 76640
            txtFDYears.Text = 2
            txtFDMonths.Text = 3
        ElseIf cmbSchemeType.SelectedItem = "Lakshadhipathy(65980)" Then
            txtFDAmount.Text = 65980
            txtFDYears.Text = 3
            txtFDMonths.Text = 3
        ElseIf cmbSchemeType.SelectedItem = "Lakshadhipathy(53755)" Then
            txtFDAmount.Text = 53755
            txtFDYears.Text = 5
            txtFDMonths.Text = 3
        ElseIf cmbSchemeType.SelectedItem = "Lakshadhipathy(49196)" Then
            txtFDAmount.Text = 49196
            txtFDYears.Text = 6
            txtFDMonths.ResetText()
        End If
    End Sub

    Private Sub btnFamilyDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFamilyDetails.Click
        If Trim(txtFDAccountNo.Text) <> String.Empty Then
            If Trim(txtFDAccountNo.Text) <> "FD" Or Trim(txtFDAccountNo.Text) <> "ENNVY" Or Trim(txtFDAccountNo.Text) <> "SCC" Then
                Dim objFamilyDetails As New frmFamily_Detail
                objFamilyDetails.txtAccountNo.Text = txtFDAccountNo.Text
                objFamilyDetails.txtName.Text = txtName.Text
                objFamilyDetails.chrType = "F"
                objFamilyDetails.ShowDialog(Me)
                objFamilyDetails.Dispose()
            Else
                MsgBox("Enter valid account no.", MsgBoxStyle.Information, "Deposit Module")
                txtFDAccountNo.Focus()
            End If
        Else
            MsgBox("Enter valid account no", MsgBoxStyle.Information, "Deposit Module")
            txtFDAccountNo.Focus()

        End If

    End Sub

    Private Sub btnNominees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNominees.Click
        If Trim(txtFDAccountNo.Text) <> String.Empty Then
            If Trim(txtFDAccountNo.Text) <> "FD" Or txtFDAccountNo.Text <> "ENNVY" Or Trim(txtFDAccountNo.Text) <> "SCC" Then
                Dim objNominees As New frmNominees
                objNominees.txtAccountNo.Text = txtFDAccountNo.Text
                objNominees.txtName.Text = txtName.Text
                objNominees.chrType = "N"
                objNominees.ShowDialog(Me)
                objNominees.Dispose()
            Else
                MsgBox("Enter valid account no.", MsgBoxStyle.Information, "Deposit Module")
                txtFDAccountNo.Focus()
            End If
        Else
            MsgBox("Enter valid account no.", MsgBoxStyle.Information, "Deposit Module")
            txtFDAccountNo.Focus()
        End If
    End Sub

    Private Sub btnJointHolders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJointHolders.Click
        If cmbAccountType.SelectedItem = "Joint" Then
            If Trim(txtFDAccountNo.Text) <> String.Empty Then
                If Trim(txtFDAccountNo.Text) <> "FD" Or txtFDAccountNo.Text <> "ENNVY" Or txtFDAccountNo.Text <> "SCC" Then
                    Dim objJointHolders As New frmNominees
                    objJointHolders.txtAccountNo.Text = txtFDAccountNo.Text
                    objJointHolders.txtName.Text = txtName.Text
                    objJointHolders.Text = "Joint-Holders for Account No  " & txtFDAccountNo.Text
                    objJointHolders.chrType = "J"
                    objJointHolders.ShowDialog(Me)
                    objJointHolders = Nothing
                Else
                    MsgBox("Enter valid account no.", MsgBoxStyle.Information, "Deposit Module")
                    txtFDAccountNo.Focus()
                End If
            Else
                MsgBox("Enter valid account no.", MsgBoxStyle.Information, "Deposit Module")
                txtFDAccountNo.Focus()
            End If
        Else
            MsgBox("Account type should be joint account", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub txtReceiptNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceiptNo.TextChanged

    End Sub

    Private Sub txtTransFund_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTransFund.TextChanged
        txtFDAmount.Text = Val(txtTransFund.Text)
    End Sub

    Private Sub txtAccNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtTransferAccount.Text = txtAccNo.Text
    End Sub

    Private Sub btnSBSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSBSearch.Click
        Dim objSBSearch As New frmSBAccSearch
        objSBSearch.strSBAccountNo = ""
        objSBSearch.ShowDialog(Me)
        If objSBSearch.strSBAccountNo <> "" Then

            sbClear()
            objSBSearch.Dispose()
        End If
    End Sub
End Class