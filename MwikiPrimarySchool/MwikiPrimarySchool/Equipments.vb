Public Class Equipments

    Private Sub EQUIPMENTS_TABLEBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EQUIPMENTS_TABLEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EQUIPMENTS_TABLEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MwikiprimaryimsDataSet)

    End Sub

    Private Sub Equipments_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MwikiprimaryimsDataSet.EQUIPMENTS_TABLE' table. You can move, or remove it, as needed.
        Me.EQUIPMENTS_TABLETableAdapter.Fill(Me.MwikiprimaryimsDataSet.EQUIPMENTS_TABLE)

    End Sub

    Private Sub BtnEquipmentBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEquipmentRecordNavigationForm.Click
        Me.Hide()
        Record_Navigation_Form.Show()
    End Sub

    Private Sub BtnFirstRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirstRecord.Click
        EQUIPMENTS_TABLEBindingSource.MoveFirst()
    End Sub

    Private Sub BtnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        EQUIPMENTS_TABLEBindingSource.MovePrevious()
    End Sub

    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        EQUIPMENTS_TABLEBindingSource.MoveNext()
    End Sub

    Private Sub BtnLastRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLastRecord.Click
        EQUIPMENTS_TABLEBindingSource.MoveLast()
    End Sub

    Private Sub BtnAddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddnew.Click
        EQUIPMENTS_TABLEBindingSource.AddNew()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        EQUIPMENTS_TABLEBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
        MsgBox("Record Deleted Successfully!")
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            EQUIPMENTS_TABLEBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(MwikiprimaryimsDataSet)
            MsgBox("Record Saved Successfully!")
        Catch ex As Exception
            MsgBox("Error, Check Record!")
        End Try
    End Sub

    Private Sub BtnPenalty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPenalty.Click
        Dim penalty As Integer
        Dim multiplication As Integer
        If PENALTYCheckBox.Checked = True Then
            penalty = UNIT_PRICETextBox.Text
            multiplication = penalty + (penalty * 20 / 100)
            TxtPenalty.Text = multiplication.ToString
            MsgBox("Penalty Displayed")
        ElseIf PENALTYCheckBox.Checked = False Then
            MsgBox("No penalty")
            TxtPenalty.Clear()
        Else : MsgBox("Incorrect credentials")
        End If
        TxtPenalty.Text = "Student ID:" & STUDENTS_IDTextBox.Text & ControlChars.NewLine & "Item ID:" & ITEM_IDTextBox.Text & ControlChars.NewLine & "Staff ID:" & STAFF_IDTextBox.Text & ControlChars.NewLine & "Student Id:" & STUDENTS_IDTextBox.Text & ControlChars.NewLine & "Returned:" & RETURNEDCheckBox.Text & ControlChars.NewLine & "Unit Price:" & UNIT_PRICETextBox.Text & ControlChars.NewLine & "Penalty:" & TxtPenalty.Text
    End Sub

    Private Sub Btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprint.Click
        PrintDocument1.Print()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TxtPenalty.Text = "" Then
            MsgBox("Write the Text")
        Else
            PrintPreviewDialog1.ShowDialog()

        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 16, FontStyle.Regular)
        e.Graphics.DrawString(TxtPenalty.Text, font, Brushes.Black, 100, 100)
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class