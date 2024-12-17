﻿Imports System.Data.OleDb
'Imports System.Data.DataTable
Public Class mahendracave
    Dim str As String
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\TripPlanner\TripPlanner\bin\Debug\TripPlanner.accdb")
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Places.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        map.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        map.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox("Do you want to add Mahendra cave in your selected place? Currently Mahendra cave is closed. ")

        Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM selectedplaces WHERE[placename]=@placename", con)
        cmd.Parameters.AddWithValue("@placename", OleDbType.VarChar).Value = Label1.Text.Trim
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("This Place is already add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Exit Sub
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        str = "INSERT INTO selectedplaces ([placename]) VALUES (?)"
        Dim create As OleDbCommand = New OleDbCommand(str, con)
        create.Parameters.Add(New OleDbParameter("placename", CType(Label1.Text, String)))

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Try
            create.ExecuteNonQuery()
            MsgBox("Add successfull")
            Me.Refresh()
            Me.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        con.Close()
    End Sub

    Private Sub mahendracave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class