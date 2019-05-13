Imports System.Data.SqlClient
Public Class Login
    Dim form1 As New GenManager
    Dim form2 As New SalesRep
    Dim form3 As New WarehouseManager

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EmployeeTableAdapter1.FillBy(RecSpecDataset1.Employee, TextBoxEmail.Text, TextBoxPassword.Text)
        If RecSpecDataset1.Employee.Rows.Count > 0 Then
            MessageBox.Show("Welcome " & RecSpecDataset1.Employee.Rows(0).Item(1).ToString & vbLf & "You will now be directed to the system")
            If RecSpecDataset1.Employee.Rows(0).Item(6).ToString = "General Manager" Then
                form1.ShowDialog()
                Me.Close()
            ElseIf RecSpecDataset1.Employee.Rows(0).Item(6).ToString = "Sales Rep" Then
                form2.ShowDialog()
                Me.Close()
            ElseIf RecSpecDataset1.Employee.Rows(0).Item(6).ToString = "Warehouse Manager" Then
                form3.ShowDialog()
                Me.Close()




            End If
        Else
            MessageBox.Show("Invalid user details entered")
            TextBoxEmail.Clear()
            TextBoxPassword.Clear()
        End If







    End Sub


End Class
