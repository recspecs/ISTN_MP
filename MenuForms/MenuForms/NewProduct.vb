Imports System.Text.RegularExpressions

Public Class NewProduct
    Private Sub Label50_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub NewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub tbPrice_KeyPress(sender As Object, e As KeyPressEventArgs) 
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
                                                                                
        End If                    
    End Sub

    Private Sub tbPrice_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub cbUnit_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub
End Class