Public Class Record_Navigation_Form

    Private Sub BtnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogOut.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub BtnSupplierDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSupplierDetails.Click
        Me.Hide()
        Suppliers_Details.Show()
    End Sub

    Private Sub BtnStudentDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStudentDetails.Click
        Me.Hide()
        Student_Details.Show()
    End Sub

    Private Sub BtnStoresTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStoresTable.Click
        Me.Hide()
        Stores_Table.Show()
    End Sub

    Private Sub BtnStaffDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStaffDetails.Click
        Me.Hide()
        Staff_Details.Show()
    End Sub

    Private Sub BtnRequisitionOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRequisitionOrder.Click
        Me.Hide()
        Requisition_Order_Details.Show()
    End Sub

    Private Sub BtnItemsDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItemsDetails.Click
        Me.Hide()
        Items_Details.Show()
    End Sub

    Private Sub BtnHOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHOD.Click
        Me.Hide()
        Head_Of_Department_Table.Show()
    End Sub

    Private Sub BtnEquipmentsTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEquipmentsTable.Click
        Me.Hide()
        Equipments.Show()
    End Sub

    Private Sub BtnCategoryTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCategoryTable.Click
        Me.Hide()
        Category_Table.Show()
    End Sub
End Class