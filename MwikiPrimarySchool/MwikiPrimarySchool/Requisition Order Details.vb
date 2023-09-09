Public Class Requisition_Order_Details

    Private Sub REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REQUISITION_ORDER_DETAILSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.REQUISITION_ORDER_DETAILSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MwikiprimaryimsDataSet)

    End Sub

    Private Sub Requisition_Order_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MwikiprimaryimsDataSet.REQUISITION_ORDER_DETAILS' table. You can move, or remove it, as needed.
        Me.REQUISITION_ORDER_DETAILSTableAdapter.Fill(Me.MwikiprimaryimsDataSet.REQUISITION_ORDER_DETAILS)

    End Sub
    Private Sub BtnRequisitionOrderBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRequisitionOrderRecordNavigationForm.Click
        Me.Hide()
        Record_Navigation_Form.Show()
    End Sub

    Private Sub BtnFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirstRecord.Click
        REQUISITION_ORDER_DETAILSBindingSource.MoveFirst()
    End Sub

    Private Sub BtnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        REQUISITION_ORDER_DETAILSBindingSource.MovePrevious()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        REQUISITION_ORDER_DETAILSBindingSource.MoveNext()
    End Sub

    Private Sub BtnLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLastRecord.Click
        REQUISITION_ORDER_DETAILSBindingSource.MoveLast()
    End Sub

    Private Sub BtnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddnew.Click
        REQUISITION_ORDER_DETAILSBindingSource.AddNew()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        REQUISITION_ORDER_DETAILSBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
        MsgBox("Record Deleted Successfully!")
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            REQUISITION_ORDER_DETAILSBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
            MsgBox("Record Saved Successfully!")
        Catch ex As Exception
            MsgBox("Error, Check Record!")
        End Try
    End Sub
End Class