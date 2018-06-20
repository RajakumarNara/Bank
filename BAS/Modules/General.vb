Module General

    Public objfrmMain As frmMain

    Public nMode As Integer = 0
    Public Const CTAdd As Integer = 1
    Public Const CTEdit As Integer = 2
    Public Const CTDelete As Integer = 3
    Public Const CTView As Integer = 4

    Public pbFinancialYear As String
    Public pbStartingMonth As String
    Public pbEndingMonth As String
    Public pbStartDate As Date
    Public pbEndDate As Date

    Public pbUserId As String
    Public pbLanguage As String

    Enum EnumLang As Integer
        Kannada = 0
        English = 1
    End Enum

    Declare Function sndPlaySound Lib "winmm.dll" Alias "sndPlaySoundA" (ByVal Name As String, ByVal Flags As Long) As Long


    'sub routine called while starting up application
    Sub sbInitialise()
        pbLanguage = Configuration.ConfigurationSettings.AppSettings("Language")
        objfrmMain = frmMain.DefInstance
        sbGetCurrentPeriod()
    End Sub


    Sub sbConvertFont(ByVal ctrl As Object)
        For Each ctrl In ctrl.controls
            If TypeOf ctrl Is BankControls.TextControl Then
                ctrl.font = New System.Drawing.Font("BRH Kannada", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                ctrl.autosize = False
            Else
                sbConvertFont(ctrl)
            End If
        Next
    End Sub

    Sub sbChangeFont(ByVal ctrl As Object, Optional ByVal EnumKanEng As EnumLang = EnumLang.Kannada)
        If EnumKanEng = EnumLang.Kannada Then
            ctrl.font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Else
            ctrl.font = New System.Drawing.Font("BRH Kannada", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End If

        'ctrl.autosize = False
    End Sub

    Sub sbGetCurrentPeriod()

        Dim objDT As DataTable
        strSQL = "SELECT * FROM YearAccountTbl WHERE Status='Active'"
        objDT = fnExecuteQuery(strSQL, 2)
        If objDT.Rows.Count > 0 Then
            pbFinancialYear = objDT.Rows(0).Item("Period")
            pbStartingMonth = objDT.Rows(0).Item("StartMonth")
            pbEndingMonth = objDT.Rows(0).Item("EndMonth")
            pbStartDate = objDT.Rows(0).Item("StartDate")
            pbEndDate = objDT.Rows(0).Item("EndDate")
        End If

    End Sub

#Region "Data Validation Functions"


    Public Function LBFN_ACCEPT_ALPHANUMERIC(ByVal KeyAscii As Integer, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Integer
        'function used to restrict txt keypress to 
        'only aslphanumeric characters with spaces 
        'in the keypress event of textbox call this function 
        'it will check the ascii value 
        If KeyAscii > 47 And KeyAscii < 58 Then     '0 - 9
            Return KeyAscii
        ElseIf KeyAscii > 64 And KeyAscii < 91 Then     'A - Z
            Return KeyAscii
        ElseIf KeyAscii > 96 And KeyAscii < 123 Then    'a - z
            Return KeyAscii
        ElseIf KeyAscii = 32 Then   'space
            Return KeyAscii
        ElseIf KeyAscii = 8 Then    'back space
            Return KeyAscii
        Else
            Return 0
        End If
    End Function

    Public Function LBFN_ACCEPT_ALPHANUMERIC_WITHOUTSPACE(ByVal KeyAscii As Integer, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Integer
        'function used to restrict txt keypress to 
        'only aslphanumeric characters with spaces 
        'in the keypress event of textbox call this function 
        'it will check the ascii value 
        If KeyAscii > 47 And KeyAscii < 58 Then     '0 - 9
            Return KeyAscii
        ElseIf KeyAscii > 64 And KeyAscii < 91 Then     'A - Z
            Return KeyAscii
        ElseIf KeyAscii > 96 And KeyAscii < 123 Then    'a - z
            Return KeyAscii
            'ElseIf KeyAscii = 32 Then   'space
            '    Return KeyAscii
        ElseIf KeyAscii = 8 Then    'back space
            Return KeyAscii
        Else
            Return 0
        End If
    End Function

    Public Function LBFN_ACCEPT_ALPHAONLY(ByVal KeyAscii As Integer, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Integer
        'function used to restrict txt keypress to 
        'only aslphabetic characters with spaces 
        'in the keypress event of textbox call this function 
        'it will check the ascii value 
        If KeyAscii > 64 And KeyAscii < 91 Then     'A - Z
            Return KeyAscii
        ElseIf KeyAscii > 96 And KeyAscii < 123 Then    'a - z
            Return KeyAscii
        ElseIf KeyAscii = 32 Then   'space
            Return KeyAscii
        ElseIf KeyAscii = 8 Then    'back space
            Return KeyAscii
        Else
            Return 0
        End If
    End Function

    Public Function LBFN_ACCEPT_ALPHAONLY_WITHSPECIAL(ByVal KeyAscii As Integer, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Integer
        'function used to restrict txt keypress to 
        'only aslphabetic characters with spaces 
        'in the keypress event of textbox call this function 
        'it will check the ascii value 
        If KeyAscii > 64 And KeyAscii < 91 Then     'A - Z
            Return KeyAscii
        ElseIf KeyAscii > 96 And KeyAscii < 123 Then    'a - z
            Return KeyAscii
        ElseIf KeyAscii = 32 Then   'space
            Return KeyAscii
        ElseIf KeyAscii = 8 Then    'back space
            Return KeyAscii
        ElseIf KeyAscii <> 34 And KeyAscii <> 39 Then
            Return KeyAscii
        Else
            Return 0
        End If
    End Function

    Public Function LBFN_ACCEPT_ALPHAONLY_WITHSPECIAL_WITHOUTSPACE(ByVal KeyAscii As Integer, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Integer
        'function used to restrict txt keypress to 
        'only aslphabetic characters with spaces 
        'in the keypress event of textbox call this function 
        'it will check the ascii value 
        If KeyAscii > 64 And KeyAscii < 91 Then     'A - Z
            Return KeyAscii
        ElseIf KeyAscii > 96 And KeyAscii < 123 Then    'a - z
            Return KeyAscii
            'ElseIf KeyAscii = 32 Then   'space
            '    Return KeyAscii
        ElseIf KeyAscii = 8 Then    'back space
            Return KeyAscii
        ElseIf KeyAscii <> 34 And KeyAscii <> 39 Then
            Return KeyAscii
        Else
            Return 0
        End If
    End Function

    Public Function LBFN_ACCEPT_ALPHAONLY_WITHOUTSPACE(ByVal KeyAscii As Integer, ByVal e As System.Windows.Forms.KeyPressEventArgs) As Integer
        'function used to restrict txt keypress to 
        'only aslphabetic characters with spaces 
        'in the keypress event of textbox call this function 
        'it will check the ascii value 
        If KeyAscii > 64 And KeyAscii < 91 Then     'A - Z
            Return KeyAscii
        ElseIf KeyAscii > 96 And KeyAscii < 123 Then    'a - z
            Return KeyAscii
            'ElseIf KeyAscii = 32 Then   'space
            '    Return KeyAscii
        ElseIf KeyAscii = 8 Then    'back space
            Return KeyAscii
        Else
            Return 0
        End If
    End Function


    Public Function LBFN_ACCEPT_ALL_EXCEPT_SQDQ(ByVal KeyAscii As Integer) As Integer
        'Function  to Accept all the characters except Single Quote and Double Quote
        'Written by Hariharan.R
        LBFN_ACCEPT_ALL_EXCEPT_SQDQ = 0
        If ((KeyAscii > 47 And KeyAscii < 58) Or _
           (KeyAscii > 64 And KeyAscii < 91) Or _
           (KeyAscii > 96 And KeyAscii < 123)) Then
            LBFN_ACCEPT_ALL_EXCEPT_SQDQ = Asc(Chr(KeyAscii))
        ElseIf KeyAscii <> 34 And KeyAscii <> 39 Then
            LBFN_ACCEPT_ALL_EXCEPT_SQDQ = KeyAscii
        End If
    End Function

    Public Function LBFN_ACCEPT_ALL_EXCEPT_SQDQ_WITHOUTSPACE(ByVal KeyAscii As Integer) As Integer
        'Function  to Accept all the characters except Single Quote and Double Quote
        'Written by Hariharan.R
        LBFN_ACCEPT_ALL_EXCEPT_SQDQ_WITHOUTSPACE = 0
        If ((KeyAscii > 47 And KeyAscii < 58) Or _
           (KeyAscii > 64 And KeyAscii < 91) Or _
           (KeyAscii > 96 And KeyAscii < 123)) Then
            LBFN_ACCEPT_ALL_EXCEPT_SQDQ_WITHOUTSPACE = Asc(Chr(KeyAscii))
        ElseIf KeyAscii <> 34 And KeyAscii <> 39 Then
            LBFN_ACCEPT_ALL_EXCEPT_SQDQ_WITHOUTSPACE = KeyAscii
        ElseIf KeyAscii = 32 Then   'space
            Return 0
        End If
    End Function

#End Region

#Region "Convet To Words"
    Public Function GetFigures(ByRef x As String) As String
        Try
            Dim one(10) As String
            Dim two(10) As String
            Dim Three(10) As String
            Dim Hundred As String
            Dim Thousand As String
            Dim lakh As String
            Dim Crore As String
            Dim Billion As String
            Dim Million As String
            Dim Trillion As String
            one(0) = "Zero" : one(1) = "One" : one(2) = "Two" : one(3) = "Three" : one(4) = "Four" : one(5) = "Five" : one(6) = "Six" : one(7) = "Seven" : one(8) = "Eight" : one(9) = "Nine"
            two(0) = "Ten" : two(1) = "Eleven" : two(2) = "Twelve" : two(3) = "Thirteen" : two(4) = "Fourteen" : two(5) = "Fifteen" : two(6) = "Sixteen" : two(7) = "Seventeen" : two(8) = "Eightteen" : two(9) = "Nineteen"
            Three(2) = "Twenty" : Three(3) = "Thirty" : Three(4) = "Fourty" : Three(5) = "Fifty" : Three(6) = "Sixty" : Three(7) = "Seventy" : Three(8) = "Eighty" : Three(9) = "Ninety"
            Hundred = "Hundred" : Thousand = "Thousand" : lakh = "Lakh" : Crore = "Crore" : Billion = "Billion"
            Million = "Million" : Trillion = "Trillion"

            Dim inp, RetVal As String

            inp = CStr(Val(x))


            Select Case Len(inp)
                Case 1
                    RetVal = one(CInt(x))

                Case 2

                    If Int(CDbl(Right(inp, 1))) > 0 And CDbl(Left(inp, 1)) > 1 Then RetVal = GetFigures(CStr(Int(CDbl(Right(inp, 1))))) ' from 20 to 90 step 10

                    If CDbl(Left(inp, 1)) > 1 Then RetVal = Three(CInt(Left(inp, 1))) & RetVal ' from 20-99
                    If CDbl(Left(inp, 1)) = 1 Then RetVal = two(CInt(Right(inp, 1))) ' from 11-19 range

                Case 3
                    If Int(CDbl(Right(inp, 2))) > 0 Then RetVal = GetFigures(CStr(Int(CDbl(Right(inp, 2)))))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 1)))) & Hundred & RetVal

                Case 4
                    If Int(CDbl(Right(inp, 3))) > 0 Then RetVal = GetFigures(CStr(Int(CDbl(Right(inp, 3)))))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 1)))) & Thousand & RetVal

                Case 5
                    If Int(CDbl(Right(inp, 3))) > 0 Then RetVal = GetFigures(CStr(Int(CDbl(Right(inp, 3)))))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 2)))) & Thousand & RetVal

                Case 6
                    If CInt(Right(inp, 5)) > 0 Then RetVal = GetFigures(CStr(CInt(Right(inp, 5))))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 1)))) & lakh & RetVal

                Case 7
                    If CInt(Right(inp, 5)) > 0 Then RetVal = GetFigures(CStr(CInt(Right(inp, 5))))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 2)))) & lakh & RetVal

                Case 8
                    If CInt(Right(inp, 7)) > 0 Then RetVal = GetFigures(CStr(CInt(Right(inp, 7))))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 1)))) & Crore & RetVal

                Case 9
                    If CInt(Right(inp, 7)) > 0 Then RetVal = GetFigures(CStr(CInt(Right(inp, 7))))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 2)))) & Crore & RetVal

                Case 10
                    If CInt(Right(inp, 9)) > 0 Then RetVal = GetFigures(CStr(CInt(Right(inp, 9))))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 1)))) & Billion & RetVal

                Case 11
                    If CInt(Right(inp, 9)) > 0 Then RetVal = GetFigures(CStr(CInt(Right(inp, 9))))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 2)))) & Billion & RetVal

                Case 12
                    If Val(Right(inp, 11)) > 0 Then RetVal = GetFigures(Right(inp, 11))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 1)))) & Million & RetVal

                Case 13
                    If Val(Right(inp, 11)) > 0 Then RetVal = GetFigures(Right(inp, 11))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 2)))) & Million & RetVal

                Case 14
                    If Val(Right(inp, 13)) > 0 Then RetVal = GetFigures(Right(inp, 13))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 1)))) & Trillion & RetVal

                Case 15
                    If Val(Right(inp, 13)) > 0 Then RetVal = GetFigures(Right(inp, 13))
                    RetVal = GetFigures(Int(CDbl(Left(inp, 2)))) & Trillion & RetVal

            End Select

            GetFigures = " " & RetVal & " "

            GetFigures = Replace(GetFigures, "  ", " ")
        Catch ex As Exception
            MsgBox("Amount Exeeded", MsgBoxStyle.Information)
        End Try
    End Function
#End Region

End Module
