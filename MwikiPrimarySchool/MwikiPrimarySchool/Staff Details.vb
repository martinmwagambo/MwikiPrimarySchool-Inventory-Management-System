Public Class Staff_Details

    Private Sub STAFF_DETAILSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STAFF_DETAILSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.STAFF_DETAILSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MwikiprimaryimsDataSet)

    End Sub

    Private Sub Staff_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MwikiprimaryimsDataSet.STAFF_DETAILS' table. You can move, or remove it, as needed.
        Me.STAFF_DETAILSTableAdapter.Fill(Me.MwikiprimaryimsDataSet.STAFF_DETAILS)

    End Sub
    Private Sub BtnstaffBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnstaffRecordNavigationForm.Click
        Me.Hide()
        Record_Navigation_Form.Show()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            STAFF_DETAILSBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
            MsgBox("Record Saved Successfully!")
        Catch ex As Exception
            MsgBox("Error, Check Record!")
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        STAFF_DETAILSBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
        MsgBox("Record Deleted Successfully!")
    End Sub

    Private Sub BtnFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirstRecord.Click
        STAFF_DETAILSBindingSource.MoveFirst()
    End Sub

    Private Sub BtnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        STAFF_DETAILSBindingSource.MovePrevious()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        STAFF_DETAILSBindingSource.MoveNext()
    End Sub

    Private Sub BtnLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLastRecord.Click
        STAFF_DETAILSBindingSource.MoveLast()
    End Sub

    Private Sub BtnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddnew.Click
        STAFF_DETAILSBindingSource.AddNew()
    End Sub
End Class