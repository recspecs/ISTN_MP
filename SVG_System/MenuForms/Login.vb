Imports System.Data.SqlClient
Imports System.Text

Public Class Login




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmployeeTableAdapter1.FillBy(RecSpecDataset1.Employee, TextBoxEmail.Text, TextBoxPassword.Text)
        If RecSpecDataset1.Employee.Rows.Count > 0 Then

            Dim msg As New StringBuilder
            msg.Append("Welcome ")
            msg.AppendLine(RecSpecDataset1.Employee.Rows(0).Item(1).ToString())
            msg.Append("You will now be directed to the system")
            MessageBox.Show(msg.ToString())

            Dim employeeType As New String(RecSpecDataset1.Employee.Rows(0).Item(6).ToString)

            Select Case employeeType
                Case "General Manager"
                    Dim genManagerForm As New GenManager
                    genManagerForm.Show()
                    Me.Hide()
                Case "Sales Rep"
                    Dim salesRepForm As New SalesRep
                    salesRepForm.Show()
                    Me.Hide()
                Case "Warehouse Manager"
                    Dim warehouseManagerForm As New WarehouseManager
                    warehouseManagerForm.Show()
                    Me.Hide()
            End Select

        Else
            MessageBox.Show("Invalid user details entered")
            TextBoxEmail.Clear()
            TextBoxPassword.Clear()
        End If







    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub


End Class
