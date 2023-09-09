Public Class Items_Details

    Private Sub ITEMS_DETAILSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ITEMS_DETAILSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ITEMS_DETAILSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MwikiprimaryimsDataSet)

    End Sub

    Private Sub Items_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MwikiprimaryimsDataSet.ITEMS_DETAILS' table. You can move, or remove it, as needed.
        Me.ITEMS_DETAILSTableAdapter.Fill(Me.MwikiprimaryimsDataSet.ITEMS_DETAILS)

    End Sub
    Private Sub BtnItemBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItemRecordNavigationForm.Click
        Me.Hide()
        Record_Navigation_Form.Show()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            ITEMS_DETAILSBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
            MsgBox("Record Saved Successfully!")
        Catch ex As Exception
            MsgBox("Error, Check Record!")
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        ITEMS_DETAILSBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
        MsgBox("Record Deleted Successfully!")
    End Sub

    Private Sub BtnFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirstRecord.Click
        ITEMS_DETAILSBindingSource.MoveFirst()
    End Sub

    Private Sub BtnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        ITEMS_DETAILSBindingSource.MovePrevious()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        ITEMS_DETAILSBindingSource.MoveNext()
    End Sub

    Private Sub BtnLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLastRecord.Click
        ITEMS_DETAILSBindingSource.MoveLast()
    End Sub

    Private Sub BtnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddnew.Click
        ITEMS_DETAILSBindingSource.AddNew()
    End Sub
End Class