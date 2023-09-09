Public Class Student_Details

    Private Sub STUDENTS_DETAILSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STUDENTS_DETAILSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.STUDENTS_DETAILSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MwikiprimaryimsDataSet)

    End Sub

    Private Sub Student_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MwikiprimaryimsDataSet.STUDENTS_DETAILS' table. You can move, or remove it, as needed.
        Me.STUDENTS_DETAILSTableAdapter.Fill(Me.MwikiprimaryimsDataSet.STUDENTS_DETAILS)

    End Sub
    Private Sub BtnStudentBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStudentRecordNavigationForm.Click
        Me.Hide()
        Record_Navigation_Form.Show()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            STUDENTS_DETAILSBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
            MsgBox("Record Saved Successfully!")
        Catch ex As Exception
            MsgBox("Error, Check Record!")
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        STUDENTS_DETAILSBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
        MsgBox("Record Deleted Successfully!")
    End Sub

    Private Sub BtnFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirstRecord.Click
        STUDENTS_DETAILSBindingSource.MoveFirst()
    End Sub

    Private Sub BtnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        STUDENTS_DETAILSBindingSource.MovePrevious()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        STUDENTS_DETAILSBindingSource.MoveNext()
    End Sub

    Private Sub BtnLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLastRecord.Click
        STUDENTS_DETAILSBindingSource.MoveLast()
    End Sub

    Private Sub BtnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddnew.Click
        STUDENTS_DETAILSBindingSource.AddNew()
    End Sub
End Class