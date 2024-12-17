﻿Imports System.Data.OleDb
'Imports System.Data.DataTable
Public Class adminlogin
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\TripPlanner\TripPlanner\bin\Debug\TripPlanner.accdb")
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click_1(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If Txtusername.Text = Nothing Or Txtpassword.Text = Nothing Then
            MessageBox.Show("Please enter username and password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        'read data from database table and login
        Dim useremail As String = Txtusername.Text
        Dim userpassword As String = Txtpassword.Text
        Using login As New OleDbCommand("Select count(*) FROM admins WHERE username=@username AND password=@password", con)
            login.Parameters.AddWithValue("Username", OleDbType.VarChar).Value = Txtusername.Text.Trim
            login.Parameters.AddWithValue("Password", OleDbType.VarChar).Value = Txtpassword.Text.Trim
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim logincount = Convert.ToInt32(login.ExecuteScalar())
            If logincount > 0 Then
                Txtusername.Clear()
                Txtpassword.Clear()
                setting.Show()
                Me.Hide()

            Else
                MessageBox.Show("Invalid Username and Password", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Txtusername.Clear()
                Txtpassword.Clear()
            End If
        End Using
        con.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        home.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class