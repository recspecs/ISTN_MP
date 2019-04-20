Imports System.Data.SqlClient
Public Class Add_New_Employee
    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles EmpPositiontxb.MaskInputRejected

    End Sub
    Dim connection As New SqlConnection("Data Source=146.230.177.46\ist3;Initial Catalog=group32;Persist Security Info=True;User ID=group32;Password=6f3ge")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAddEmp.Click
        Dim command As New SqlCommand("INSERT INTO Employee(Employee_ID,Emp_FName,Emp_SName,Emp_Email,Emp_Contact_No,Emp_Type)values('" & Emptxb.Text & "'," & EmpNametxb.Text & "'," & EmpSurtxb.Text & "'," & EmpEmail.Text & "'," & EmpPasstxb.Text & "'," & EmpContacttxb.Text & "'," & EmpPositiontxb.Text & ")", connection)



        connection.Open()
        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Added!")
        Else
            MessageBox.Show("Unsuccesful")
        End If

        connection.Close()




    End Sub
End Class