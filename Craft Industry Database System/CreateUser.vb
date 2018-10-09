Imports Craft_Industry_Database.frmUsers

Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmCreateUser

    Dim connectionString As String = String.Empty

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.connectionString = ConfigurationManager.ConnectionStrings("connectionString").ConnectionString
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click

        Dim userName, Password, confirmPassword, type As String
        userName = txtUserName.Text
        Password = txtNewPassword.Text
        confirmPassword = txtConfirmPassword.Text

        If rdbAdministrator.Checked Then
            type = rdbAdministrator.Text
        ElseIf rdbDataEncoder.Checked Then
            type = rdbDataEncoder.Text
        Else
            type = rdbUser.Text
        End If

        If Password.Equals(confirmPassword) Then
            Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

                myConnection.Open()

                Using cmd As SqlCommand = myConnection.CreateCommand

                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "INSERT INTO tblUser " & _
                    "(UserName, Password,TypeOfUser)" & _
                    "VALUES (@userName, @Password, @TypeOfUser);"

                    cmd.Parameters.Add(New SqlParameter("@userName", userName))
                    cmd.Parameters.Add(New SqlParameter("@Password", Password))
                    cmd.Parameters.Add(New SqlParameter("@TypeOfUser", type))

                    ' Execute the SqlCommand object to insert the new data...
                    Try
                        cmd.ExecuteNonQuery()
                    Catch SqlExceptionErr As SqlException
                        MessageBox.Show(SqlExceptionErr.Message)
                    End Try


                    MessageBox.Show("User Account Created Successfully!!!", "CIDS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    myConnection.Close()

                End Using
            End Using

        Else

            MessageBox.Show("Invalid conformation!", "CIDS Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class