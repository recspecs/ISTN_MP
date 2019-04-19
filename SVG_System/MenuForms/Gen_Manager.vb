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

    Private Sub Payment_Click(sender As Object, e As EventArgs) Handles Payment.Click

    End Sub

    Private Sub DataGridView6_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellContentClick

    End Sub

    Private Sub SalesOrder_Click(sender As Object, e As EventArgs) Handles SalesOrder.Click

    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GenManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RecSpecDataset.Employee' table. You can move, or remove it, as needed.
        DataGridView6.DataSource = GetEmployeeList()
        DataGridView5.DataSource = GetProductList()
        DataGridView9.DataSource = GetSaleOrderList()
        DataGridView1.DataSource = GetPurchaseOrderList()
        DataGridView7.DataSource = GetPurchaseItemList()
        DataGridView3.DataSource = GetSupplierList()
        DataGridView2.DataSource = GetCustomerList()
        DataGridView4.DataSource = GetCustomerPaymentsList()







    End Sub
    Private Function GetCustomerPaymentsList() As DataTable
        Dim dtemployees As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("SELECT * FROM dbo.Customer_Payment", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dtemployees.Load(reader)
            End Using
        End Using
        Return dtemployees
    End Function
    Private Function GetCustomerList() As DataTable
        Dim dtemployees As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("SELECT * FROM dbo.CustomerTable", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dtemployees.Load(reader)
            End Using
        End Using
        Return dtemployees
    End Function
    Private Function GetSupplierList() As DataTable
        Dim dtemployees As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("SELECT * FROM dbo.Supplier", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dtemployees.Load(reader)
            End Using
        End Using
        Return dtemployees
    End Function
    Private Function GetPurchaseItemList() As DataTable
        Dim dtemployees As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("SELECT * FROM dbo.Purchase_Item", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dtemployees.Load(reader)
            End Using
        End Using
        Return dtemployees
    End Function
    Private Function GetPurchaseOrderList() As DataTable
        Dim dtemployees As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("SELECT * FROM dbo.Purchase_Order", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dtemployees.Load(reader)
            End Using
        End Using
        Return dtemployees
    End Function
    Private Function GetSaleOrderList() As DataTable
        Dim dtemployees As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("SELECT * FROM dbo.Sales_Order", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dtemployees.Load(reader)
            End Using
        End Using
        Return dtemployees
    End Function

    Private Function GetProductList() As DataTable
        Dim dtemployees As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("SELECT * FROM dbo.Product", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dtemployees.Load(reader)
            End Using
        End Using
        Return dtemployees
    End Function

    Private Function GetEmployeeList() As DataTable
        Dim dtemployees As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("SELECT * FROM dbo.Employee", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dtemployees.Load(reader)
            End Using
        End Using
        Return dtemployees
    End Function

    Private Sub Employee_Click(sender As Object, e As EventArgs) Handles Employee.Click

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

    End Sub

    Private Sub Products_Click(sender As Object, e As EventArgs) Handles Products.Click

    End Sub

    Private Sub PurchaseOrder_Click(sender As Object, e As EventArgs) Handles PurchaseOrder.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

    End Sub
End Class