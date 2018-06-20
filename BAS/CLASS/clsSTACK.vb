Public Class clsSTACK
    Dim strArray(50) As String
    Dim intTOP As Integer

    Sub New()
        intTOP = -1
    End Sub

    Function PUSH(ByVal strITEM As String)
        intTOP += 1
        strArray.SetValue(strITEM, intTOP)
    End Function

    Function POP() As String
        If intTOP <> -1 Then
            intTOP -= 1
            Return strArray.GetValue(intTOP + 1)
        Else
            Return ""
        End If
    End Function

End Class
