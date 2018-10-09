Imports Craft_Industry_Database.frmUsers

Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmChangePassword

    Dim connectionString As String = String.Empty

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.connectionString = ConfigurationManager.ConnectionStrings("connectionString").ConnectionString
    End Sub

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If admin = True Then

            cboUserName.Enabled = True
            txtOldPassword.Enabled = False
        Else

            cboUserName.Enabled = False
            txtOldPassword.Enabled = True

        End If
        ' MsgBox(loginName)
        cboUserName.Text = loginName

    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click

        Dim strAvi As String = String.Empty

        Dim oldPassword, newPassword, confirmPassword, userName As String

        oldPassword = txtOldPassword.Text
        newPassword = txtNewPassword.Text
        confirmPassword = txtConfirmPassword.Text
        userName = cboUserName.Text

        If admin = False Then

            Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

                myConnection.Open()


                Using cmd As SqlCommand = myConnection.CreateCommand
                    '  MsgBox(cboUserName.Text + " " + txtPassword.Text)
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "SELECT * FROM tblUser WHERE userName = '" + cboUserName.Text + "' AND password= '" + oldPassword + "';"

                    Try
                        strAvi = cmd.ExecuteScalar
                        ' MessageBox.Show(strAvi)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

                End Using

                If strAvi <> cboUserName.Text.Trim Then
                    MessageBox.Show("Incorrect old password!")
                    txtOldPassword.Text = ""
                    txtOldPassword.Focus()
                Else

                    If newPassword.Equals(confirmPassword) Then 'new passwords are same

                        Using cmd As SqlCommand = myConnection.CreateCommand
                            cmd.CommandText = "UPDATE tblUser SET password = '" & newPassword & "' " & _
                                              "WHERE userName = '" & cboUserName.Text & "';"
                            Try
                                cmd.ExecuteNonQuery()
                                MessageBox.Show("Password successfully changed.", "CIDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.Close()
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try

                        End Using

                    Else
                        MessageBox.Show("Invalid Conformation!", "CIDS Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            End Using

        Else
            Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

                myConnection.Open()

                If newPassword.Equals(confirmPassword) Then 'new passwords are same

                    Using cmd As SqlCommand = myConnection.CreateCommand
                        cmd.CommandText = "UPDATE tblUser SET password = '" & newPassword & "' " & _
                                          "WHERE userName = '" & cboUserName.Text & "';"

                        Try
                            cmd.ExecuteNonQuery()
                            MessageBox.Show("Password successfully changed.", "CIDS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Close()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try

                    End Using

                Else
                    MessageBox.Show("Invalid Conformation!", "CIDS Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using

           End if

    End Sub
End Class