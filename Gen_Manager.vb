Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class GenManager
    Private Sub Label58_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Supplier_Click(sender As Object, e As EventArgs) Handles Supplier.Click

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub Payment_Click(sender As Object, e As EventArgs) Handles GeneralManager.Click

    End Sub

    Private Sub DataGridView6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellContentClick

    End Sub

    Private Sub SalesOrder_Click(sender As Object, e As EventArgs) Handles SalesOrder.Click

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GenManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Employee' table. You can move, or remove it, as needed.

        Me.SupplierTableAdapter1.Fill(Me.RecSpecDataset.Supplier)
        Me.Sales_OrderTableAdapter1.Fill(Me.RecSpecDataset.Sales_Order)
        Me.ProductTableAdapter1.Fill(Me.RecSpecDataset.Product)
        Me.CustomerTableTableAdapter1.Fill(Me.RecSpecDataset.CustomerTable)
        Me.Purchase_OrderTableAdapter1.Fill(Me.RecSpecDataset.Purchase_Order)
        Me.Purchase_ItemTableAdapter1.Fill(Me.RecSpecDataset.Purchase_Item)
        Me.Customer_PaymentTableAdapter1.Fill(Me.RecSpecDataset.Customer_Payment)








    End Sub





    Private Sub Employee_Click(sender As Object, e As EventArgs) Handles Employee.Click

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Products_Click(sender As Object, e As EventArgs) Handles Products.Click

    End Sub

    Private Sub PurchaseOrder_Click(sender As Object, e As EventArgs) Handles PurchaseOrder.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btnEmpSave.Click
        BindingSource1.EndEdit()
        EmployeeTableAdapter1.Update(RecSpecDataset.Employee)
        MsgBox("Info saved")
        DataGridView6.ReadOnly = True
        DataGridView6.AllowUserToAddRows = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DataGridView6.ReadOnly = False
        DataGridView6.AllowUserToDeleteRows = True

        Dim ans As MsgBoxResult
        ans = MsgBox("are you sure", MsgBoxStyle.YesNo)
        If ans = MsgBoxResult.Yes Then
            BindingSource1.RemoveCurrent()

        End If




    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        DataGridView6.ReadOnly = False
        DataGridView6.AllowUserToAddRows = True


    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged



    End Sub








    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click


    End Sub

    Private Sub btnNewEmp_Click(sender As Object, e As EventArgs) Handles btnAddPurchase.Click
        DataGridView1.ReadOnly = False
        DataGridView1.AllowUserToAddRows = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DataGridView3.ReadOnly = False
        DataGridView3.AllowUserToAddRows = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        BindingSource1.EndEdit()
        SupplierTableAdapter1.Update(RecSpecDataset.Supplier)
        MsgBox("Info saved")
        DataGridView3.ReadOnly = True
        DataGridView3.AllowUserToAddRows = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView3.ReadOnly = False
        DataGridView3.AllowUserToDeleteRows = True

        Dim ans As New MsgBoxResult
        ans = MsgBox("are you sure", MsgBoxStyle.YesNo)
        If ans = MsgBoxResult.Yes Then
            BindingSource1.RemoveCurrent()
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        DGVPayment.ReadOnly = False
        DGVPayment.AllowUserToAddRows = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        BindingSource1.EndEdit()
        ProductTableAdapter1.Update(RecSpecDataset.Product)
        MsgBox("Info saved")
        DataGridView5.ReadOnly = True
        DataGridView5.AllowUserToAddRows = False
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        BindingSource1.EndEdit()
        Purchase_OrderTableAdapter1.Update(RecSpecDataset.Purchase_Order)
        MsgBox("Info saved")
        DataGridView1.ReadOnly = True
        DataGridView1.AllowUserToAddRows = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        BindingSource1.EndEdit()
        CustomerTableTableAdapter1.Update(RecSpecDataset.CustomerTable)
        MsgBox("Info saved")
        DataGridView2.ReadOnly = True
        DataGridView2.AllowUserToAddRows = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        BindingSource1.EndEdit()
        Customer_PaymentTableAdapter1.Update(RecSpecDataset.Customer_Payment)
        MsgBox("Info saved")
        DGVPayment.ReadOnly = True
        DGVPayment.AllowUserToAddRows = False
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        DataGridView5.ReadOnly = False
        DataGridView5.AllowUserToAddRows = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        DataGridView2.ReadOnly = False
        DataGridView2.AllowUserToAddRows = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView5.ReadOnly = False
        DataGridView5.AllowUserToDeleteRows = True

        Dim ans As MsgBoxResult
        ans = MsgBox("are you sure", MsgBoxStyle.YesNo)
        If ans = MsgBoxResult.Yes Then
            BindingSource1.RemoveCurrent()

        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        DataGridView1.ReadOnly = False
        DataGridView1.AllowUserToDeleteRows = True

        Dim ans As MsgBoxResult
        ans = MsgBox("are you sure", MsgBoxStyle.YesNo)
        If ans = MsgBoxResult.Yes Then
            BindingSource1.RemoveCurrent()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView2.ReadOnly = False
        DataGridView2.AllowUserToDeleteRows = True

        Dim ans As MsgBoxResult
        ans = MsgBox("are you sure", MsgBoxStyle.YesNo)
        If ans = MsgBoxResult.Yes Then
            BindingSource1.RemoveCurrent()

        End If
    End Sub

    Private Sub DGVPayment_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPayment.CellContentClick

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        DGVPayment.ReadOnly = False
        DGVPayment.AllowUserToDeleteRows = True

        Dim ans As MsgBoxResult
        ans = MsgBox("are you sure", MsgBoxStyle.YesNo)
        If ans = MsgBoxResult.Yes Then
            BindingSource1.RemoveCurrent()

        End If
    End Sub

    Private Sub DataGridView5_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellContentClick

    End Sub


End Class