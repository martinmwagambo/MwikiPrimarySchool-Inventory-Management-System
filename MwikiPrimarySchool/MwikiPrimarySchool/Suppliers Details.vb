Public Class Suppliers_Details

    Private Sub SUPPLIER_DETAILSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUPPLIER_DETAILSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SUPPLIER_DETAILSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MwikiprimaryimsDataSet)

    End Sub

    Private Sub Suppliers_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MwikiprimaryimsDataSet.SUPPLIER_DETAILS' table. You can move, or remove it, as needed.
        Me.SUPPLIER_DETAILSTableAdapter.Fill(Me.MwikiprimaryimsDataSet.SUPPLIER_DETAILS)

    End Sub
    Private Sub BtnSupplierRecordNavigationForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupplierRecordNavigationForm.Click
        Me.Hide()
        Record_Navigation_Form.Show()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            SUPPLIER_DETAILSBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
            MsgBox("Record Saved Successfully!")
        Catch ex As Exception
            MsgBox("Error, Check Record!")
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        SUPPLIER_DETAILSBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
        MsgBox("Record Deleted Successfully!")
    End Sub

    Private Sub BtnFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirstRecord.Click
        SUPPLIER_DETAILSBindingSource.MoveFirst()
    End Sub

    Private Sub BtnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        SUPPLIER_DETAILSBindingSource.MovePrevious()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        SUPPLIER_DETAILSBindingSource.MoveNext()
    End Sub

    Private Sub BtnLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLastRecord.Click
        SUPPLIER_DETAILSBindingSource.MoveLast()
    End Sub

    Private Sub BtnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddnew.Click
        SUPPLIER_DETAILSBindingSource.AddNew()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(TxtReport.Text, font, Brushes.Black, 100, 100)
    End Sub

    Private Sub BtnDisplayReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplayReport.Click
        TxtReport.Text = "Company Name:" & COMPANY_NAMETextBox.Text & ControlChars.NewLine & "Supplier Id:" & SUPPLIERS_IDTextBox.Text & ControlChars.NewLine & "Contact Name:" & CONTACT_NAMETextBox.Text & ControlChars.NewLine & "Contact Title:" & CONTACT_TITLETextBox.Text & ControlChars.NewLine & "Address:" & ADRESSTextBox.Text & ControlChars.NewLine & "Item Delivered:" & ITEMS_DELIVEREDTextBox.Text & ControlChars.NewLine & "Phone:" & PHONETextBox.Text & ControlChars.NewLine & "Date of Delivery:" & DATE_OF_DELIVERYTextBox.Text & ControlChars.NewLine

    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        If TxtReport.Text = "" Then
            MsgBox("Write the Text")
        Else
            PrintPreviewDialog1.ShowDialog()

        End If
    End Sub
End Class