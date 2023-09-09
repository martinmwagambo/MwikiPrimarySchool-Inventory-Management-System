Public Class Head_Of_Department_Table

    Private Sub HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HEAD_OF_DEPARTMENT_TABLEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HEAD_OF_DEPARTMENT_TABLEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MwikiprimaryimsDataSet)

    End Sub

    Private Sub Head_Of_Department_Table_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MwikiprimaryimsDataSet.HEAD_OF_DEPARTMENT_TABLE' table. You can move, or remove it, as needed.
        Me.HEAD_OF_DEPARTMENT_TABLETableAdapter.Fill(Me.MwikiprimaryimsDataSet.HEAD_OF_DEPARTMENT_TABLE)

    End Sub

    Private Sub BtnHODBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHODRecordNavigationForm.Click
        Me.Hide()
        Record_Navigation_Form.Show()
    End Sub

    Private Sub BtnFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirstRecord.Click
        HEAD_OF_DEPARTMENT_TABLEBindingSource.MoveFirst()
    End Sub

    Private Sub BtnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        HEAD_OF_DEPARTMENT_TABLEBindingSource.MovePrevious()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        HEAD_OF_DEPARTMENT_TABLEBindingSource.MoveNext()
    End Sub

    Private Sub BtnLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLastRecord.Click
        HEAD_OF_DEPARTMENT_TABLEBindingSource.MoveLast()
    End Sub

    Private Sub BtnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddnew.Click
        HEAD_OF_DEPARTMENT_TABLEBindingSource.AddNew()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        HEAD_OF_DEPARTMENT_TABLEBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
        MsgBox("Record Deleted Successfully!")
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            HEAD_OF_DEPARTMENT_TABLEBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
            MsgBox("Record Saved Successfully!")
        Catch ex As Exception
            MsgBox("Error, Check Record!")
        End Try
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()

    End Sub

    Private Sub BtnPrintreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(HEAD_OF_DEPARTMENT_TABLEDataGridView.Text, font, Brushes.Black, 100, 100)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        PrintPreviewDialog1.ShowDialog()

    End Sub
End Class