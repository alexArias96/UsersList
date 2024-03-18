Imports System.Data.SqlClient

Public Class frm_Users
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Close()
    End Sub

    Sub Clear()
        txt_Identity.Clear()
        txt_Name.Clear()
        txt_LastName.Clear()
        txt_Phone.Clear()
        txt_Email.Clear()

        txt_Identity.Focus()
    End Sub

    Sub ShowDataUsers()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            OpenConnection()
            da = New SqlDataAdapter("Show_Users", conn)
            da.Fill(dt)

            dgv_UsersList.DataSource = dt
            CloseConnection()

            'Apparence'

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frm_Users_Load(sender As Object, e As EventArgs) Handles Me.Load
        ShowDataUsers()
    End Sub

    Private Sub dgv_UsersList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_UsersList.CellContentDoubleClick
        'pnl_DataCapture.Visible = True
        Try
            btn_Save.Enabled = False
            btn_Modify.Enabled = True
            btn_Cancel.Enabled = False

            txt_Identity.Enabled = False

            txt_Identity.Text = dgv_UsersList.SelectedCells(1).Value
            txt_Name.Text = dgv_UsersList.SelectedCells(2).Value
            txt_LastName.Text = dgv_UsersList.SelectedCells(3).Value
            txt_Phone.Text = dgv_UsersList.SelectedCells(4).Value
            txt_Email.Text = dgv_UsersList.SelectedCells(5).Value



        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Modify_Click_1(sender As Object, e As EventArgs) Handles btn_Modify.Click
        Dim command As New SqlCommand

        If txt_Identity.Text.Length = 9 And txt_Identity.Text <> "" Then
            Try
                OpenConnection()
                command = New SqlCommand("Edit_Users", conn)
                command.CommandType = 4

                command.Parameters.AddWithValue("@iduser", txt_Identity.Text.ToString)
                command.Parameters.AddWithValue("@name", txt_Name.Text.ToString)
                command.Parameters.AddWithValue("@lastName", txt_LastName.Text.ToString)
                command.Parameters.AddWithValue("@phone", txt_Phone.Text.ToString)
                command.Parameters.AddWithValue("@email", txt_Email.Text.ToString)

                command.ExecuteNonQuery()
                CloseConnection()

                Clear()
                ShowDataUsers()
                btn_Modify.Enabled = False
                btn_Save.Enabled = True
                btn_Cancel.Enabled = True

            Catch ex As Exception

            End Try
        Else
            MsgBox("The field 'Identity' is required", vbInformation, vbOKOnly)
        End If
    End Sub

    Private Sub btn_Save_Click_1(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim command As New SqlCommand

        If txt_Identity.Text.Length = 9 And txt_Identity.Text <> "" Then
            Try
                OpenConnection()
                command = New SqlCommand("Insert_Users", conn)
                command.CommandType = 4

                command.Parameters.AddWithValue("@iduser", txt_Identity.Text.ToString)
                command.Parameters.AddWithValue("@name", txt_Name.Text.ToString)
                command.Parameters.AddWithValue("@lastName", txt_LastName.Text.ToString)
                command.Parameters.AddWithValue("@phone", txt_Phone.Text.ToString)
                command.Parameters.AddWithValue("@email", txt_Email.Text.ToString)

                command.ExecuteNonQuery()
                CloseConnection()

                'pnl_DataCapture.Visible = False
                Clear()
                ShowDataUsers()
            Catch ex As Exception

            End Try
        Else
            MsgBox("The field 'Identity' is required", vbInformation, vbOKOnly)
        End If
    End Sub

    Private Sub dgv_UsersList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_UsersList.CellContentClick
        If e.ColumnIndex = dgv_UsersList.Columns.Item("delete").Index Then
            Dim result As DialogResult
            result = MsgBox("Are you sure you want to delete this record?", vbQuestion + vbOKOnly, "Users system")

            If result = DialogResult.OK Then
                Dim cmd As SqlCommand
                Try
                    OpenConnection()
                    cmd = New SqlCommand("Delete_Users", conn)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idUser", dgv_UsersList.SelectedCells.Item(1).Value)
                    cmd.ExecuteNonQuery()
                    CloseConnection()

                    ShowDataUsers()
                Catch ex As Exception
                    MsgBox("Failed registry deletion", vbInformation + vbOKOnly, "Users system")
                End Try
            End If
        End If

    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Clear()
    End Sub
End Class
