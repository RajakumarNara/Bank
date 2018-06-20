Imports System.IO
Imports System.Data
Imports System.String
Imports System
Public Class PigmyMachine

    Private Sub PigmyMachine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim i As Integer = 0
        Dim objclsPigmyMachine As New clsPigmyMachine
        Dim Import As New DataTable
        Import = objclsPigmyMachine.ImportData()
        If Import.Rows.Count > 0 Then
            Dim sw As New StreamWriter("Import.csv", True)
            For i = 0 To Import.Columns.Count
                sw.Write(Import.Columns(i))
                If (i <> Import.Columns.Count - 1) Then
                    sw.Write(",")
                End If
            Next i
            sw.Write(sw.NewLine)
            For Each dr As DataRow In Import.Rows
                For i = 0 To Import.Columns.Count
                    sw.Write(Convert.ToString(dr(i)))
                    If i <> Import.Columns.Count - 1 Then
                        sw.Write(",")
                    End If
                Next
                sw.Write(sw.NewLine)
            Next
            sw.Close()
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim objclsPigmyMachine As New clsPigmyMachine
        Dim sr As New StreamReader("Export.csv", False)
        Dim NewLine As String = sr.ReadLine()
        Dim sep As Char = ","
        Dim r1() As String
        While (True)
            NewLine = sr.ReadLine()
            If String.IsNullOrEmpty(NewLine) Then
                Exit While
            End If
            r1 = NewLine.Split(sep)
            objclsPigmyMachine.ExportData(r1(0).ToString, r1(1).ToString, r1(2).ToString, r1(3).ToString, r1(4).ToString, r1(5).ToString, r1(6).ToString, r1(7).ToString, r1(8).ToString, r1(9).ToString, r1(10).ToString, r1(11).ToString, r1(12).ToString, r1(13).ToString, r1(14).ToString, r1(15).ToString)
        End While
    End Sub
End Class