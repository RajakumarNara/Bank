Public Class frmRelation
#Region " form Global variables (object)"
    Dim objRelation As New clsRelations
    Dim dvRelation As DataView
#End Region
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If fncheck() Then
            If fnsetdata() Then
                If fnsavedata() Then
                    sbClear()
                    fnLoadData()
                End If
            End If
        End If
    End Sub

#Region " functions and subroutine"

    'to check all the fields in the caste form are entered
    Function fncheck() As Boolean
        If txtRelationCode.Text = "" Then
            MsgBox("Enter Relation code", MsgBoxStyle.Exclamation)
            txtRelationCode.Focus()
            Return False

        ElseIf txtRelationName.Text = "" Then
            MsgBox("Enter Relation ", MsgBoxStyle.Exclamation)
            txtRelationName.Focus()
            Return False

        Else
            Return True

        End If
    End Function


    'To set form control values to Class Properties
    Function fnsetdata() As Boolean
        objRelation.RelationCode = txtRelationCode.Text
        objRelation.RelationName = txtRelationName.Text
        Return True

    End Function

    Function fnsavedata() As Boolean

        'Check for Member Existance
        If objRelation.fnCheckRelation = False Then

            'ADD new Member  (ADD Mode)
            If objRelation.fnAddRelation() Then
                MessageBox.Show("New Relation added successfully.", "Relation module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("New Relation addition failed, because of internal error.", "Relation module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If

        Else

            'Update Details (EDIT Mode)
            If objRelation.fnUpdateRelation Then
                MessageBox.Show("Relation updated successfully.", "Relation module", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return True
            Else
                MessageBox.Show("Relation updation failed, because of internal Error.", "Relation Module", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification)
                Return False
            End If
        End If

    End Function
    Sub sbClear()
        txtRelationCode.ResetText()
        txtRelationName.ResetText()
    End Sub

    Function fnLoadData() As Boolean
        If objRelation.fnGetRelations = True Then
            dvRelation = New DataView(objRelation.RelationTable)

            Dim intCounter As Integer = 0
            Dim lvItem As ListViewItem
            lvRelation.Items.Clear()

            While intCounter < dvRelation.Count
                lvItem = lvRelation.Items.Add(dvRelation.Item(intCounter).Item(0))
                lvItem.SubItems.Add(dvRelation.Item(intCounter).Item(1))
                intCounter = intCounter + 1
            End While
            If lvRelation.Items.Count > 0 Then
                lvRelation.Items(0).Selected = True
            End If
        End If
    End Function
#End Region

    Private Sub lvRelation_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvRelation.DoubleClick
        If lvRelation.SelectedItems.Count > 0 Then
            txtRelationCode.Text = lvRelation.SelectedItems(0).SubItems(0).Text
            txtRelationName.Text = lvRelation.SelectedItems(0).SubItems(1).Text
        End If
    End Sub

    Private Sub frmRelation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fnLoadData()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class