Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmUsers

    Dim connectionString As String = String.Empty
    Dim objDataAdapter As New SqlDataAdapter
    Dim objDataSet As DataSet
    Dim objDataView As DataView
    Dim objCurrencyManager As CurrencyManager

    Public Shared admin, user, dataEncoder As Boolean
    Public Shared loginName As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.connectionString = ConfigurationManager.ConnectionStrings("connectionString").ConnectionString
    End Sub

    'Private Sub FillDataSetAndView()

    '    objDataAdapter = New SqlDataAdapter("SELECT * FROM tblUser", connectionString)
    '    ' Initialize a new instance of the DataSet object...
    '    objDataSet = New DataSet()

    '    Try
    '        ' Fill the DataSet object with data...
    '        objDataAdapter.Fill(objDataSet, "user")
    '        ' Set the DataView object to the DataSet object...
    '        objDataView = New DataView(objDataSet.Tables("user"))
    '        ' Set our CurrencyManager object to the DataView object...
    '        objCurrencyManager = CType(Me.BindingContext(objDataView), CurrencyManager)
    '    Catch ex As SqlException
    '        MessageBox.Show("There is a problem with the location of the database." & vbCrLf & "Please correct this problem first.", "Database connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    '  Private Sub Clear()

    ' Clear any previous bindings...
    '  cboUserName.DataBindings.Clear()

    'Hid.DataBindings.Clear()

    'End Sub

    'Private Sub BindFields()

    '    Clear()

    '    Try
    '        Hid.DataBindings.Add("Text", objDataView, "userName")
    '    Catch ex As ArgumentNullException
    '        Me.Close()
    '    End Try

    '    Dim i As Integer = 0
    '    Dim t As String

    '    For i = 0 To cboUserName.Items.Count - 1
    '        ' MsgBox(Hid.Text + " " + cboCraftCategory.Text)
    '        cboUserName.SelectedIndex = i
    '        t = cboUserName.Text
    '        If Hid.Text.Equals(t) Then
    '            cboUserName.Text = Hid.Text
    '            Exit For
    '        End If
    '    Next

    'End Sub

    Private Sub frmUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Opacity = 0
        trVisible.Start()

        lblType.Hide()
        txtPassword.Focus()

        '  cboUserName.SelectedIndex = 0

        ' Fill the DataSet and bind the fields...
        '  FillDataSetAndView()

        ' BindFields()
        '   Hid.Visible = False

    End Sub

    Private Sub trVisible_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trVisible.Tick
        If Me.Opacity > 1 Then
            trVisible.Stop()
        Else
            Me.Opacity = Me.Opacity + 0.1
        End If

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        'Dim type As String
        'type = lblType.Text.Trim
        loginName = txtUserName.Text.Trim

        Dim strAvi As String = String.Empty

        Using myConnection As SqlConnection = New SqlConnection(Me.connectionString)

            myConnection.Open()

            Using cmd As SqlCommand = myConnection.CreateCommand
                '  MsgBox(txtUserName.Text + " " + txtPassword.Text)
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "SELECT * FROM tblUser WHERE userName = '" + txtUserName.Text + "' AND password= '" + txtPassword.Text + "';"

                Try
                    strAvi = cmd.ExecuteScalar
                    '    MessageBox.Show(strAvi)
                Catch ex As Exception
                    MessageBox.Show("There is a problem with the location of the database." & vbCrLf & "Please correct this problem first.", "Database connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'MessageBox.Show(ex.Message)
                End Try

            End Using

            ' If intAvi < 0 Then
            If strAvi <> txtUserName.Text.Trim Then
                MessageBox.Show("Access Denied!", "CIDS - Exception Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Text = ""
                txtPassword.Focus()
            Else
                If loginName.Equals("Administrator") Then

                    admin = True
                    user = False
                    dataEncoder = False

                ElseIf loginName.Equals("User") Then

                    admin = False
                    user = True
                    dataEncoder = False

                ElseIf loginName.Equals("Data Encoder") Then

                    admin = False
                    user = False
                    dataEncoder = True

                End If

                mdiHome.Show()
                Me.Hide()
            End If

        End Using

    End Sub

    Private Sub picClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picClose.Click

        Me.Finalize()
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    'Private Sub cboUserName_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUserName.SelectionChangeCommitted
    '   txtPassword.Focus()
    'End Sub

    Private Sub picMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtPassword_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Leave
        btnOk.Focus()
    End Sub
End Class