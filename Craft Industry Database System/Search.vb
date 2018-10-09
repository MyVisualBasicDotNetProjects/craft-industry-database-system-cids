Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class frmSearch

    Dim connectionString As String = String.Empty

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.connectionString = ConfigurationManager.ConnectionStrings("connectionString").ConnectionString
    End Sub

    Private Sub btnSearchGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchGo.Click


        If cboSearchFrom.Text.Equals(String.Empty) Or cboSearchBy.Text.Equals(String.Empty) Or txtSearchText.Text.Equals(String.Empty) Then

            MessageBox.Show("Please fill all the required fields.", "CIDS - Exception Report", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf cboCriteria.Enabled = True And cboCriteria.Text.Equals(String.Empty) Then

            MessageBox.Show("Please choose one criteria.", "CIDS - Exception Report", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim searchContent As String = txtSearchText.Text.Trim

            Dim selectDataAdaptor As New SqlDataAdapter
            selectDataAdaptor.SelectCommand = New SqlCommand

            selectDataAdaptor.SelectCommand.Connection = New SqlConnection(connectionString)

           
            If (cboSearchFrom.Text.Equals("Craft Worker")) Then

                If cboSearchBy.Text.Equals("First Name") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT craftWorkerId AS 'Craft Worker Id', firstName AS 'First Name', surName AS 'Sur Name', age AS 'Age', sex AS 'Sex', ethinicGroup AS 'Ethnic Group', " & _
                        "nationality AS 'Nationality', address AS 'Address', addressOfWorkshop AS 'Address Of Workshop', dependents AS 'Dependents', formId AS 'Form Id' " & _
                        "FROM tblCraftWorker " & _
                        "WHERE firstName like '" & searchContent & "%'"

                ElseIf cboSearchBy.Text.Equals("Sur Name") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT craftWorkerId AS 'Craft Worker Id', firstName AS 'First Name', surName AS 'Sur Name', age AS 'Age', sex AS 'Sex', ethinicGroup AS 'Ethnic Group', " & _
                        "nationality AS 'Nationality', address AS 'Address', addressOfWorkshop AS 'Address Of Workshop', dependents AS 'Dependents', formId AS 'Form Id' " & _
                        "FROM tblCraftWorker " & _
                        "WHERE surName like '" & searchContent & "%'"

                ElseIf cboSearchBy.Text.Equals("Age") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT craftWorkerId AS 'Craft Worker Id', firstName AS 'First Name', surName AS 'Sur Name', age AS 'Age', sex AS 'Sex', ethinicGroup AS 'Ethnic Group', " & _
                        "nationality AS 'Nationality', address AS 'Address', addressOfWorkshop AS 'Address Of Workshop', dependents AS 'Dependents', formId AS 'Form Id' " & _
                        "FROM tblCraftWorker " & _
                        "WHERE age " & cboCriteria.Text.Trim & " '" & searchContent & "'"

                ElseIf cboSearchBy.Text.Equals("Address Of Workshop") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT craftWorkerId AS 'Craft Worker Id', firstName AS 'First Name', surName AS 'Sur Name', age AS 'Age', sex AS 'Sex', ethinicGroup AS 'Ethnic Group', " & _
                        "nationality AS 'Nationality', address AS 'Address', addressOfWorkshop AS 'Address Of Workshop', dependents AS 'Dependents', formId AS 'Form Id' " & _
                        "FROM tblCraftWorker " & _
                        "WHERE addressOfWorkshop like '" & searchContent & "%'"

                ElseIf cboSearchBy.Text.Equals("Address") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT craftWorkerId AS 'Craft Worker Id', firstName AS 'First Name', surName AS 'Sur Name', age AS 'Age', sex AS 'Sex', ethinicGroup AS 'Ethnic Group', " & _
                        "nationality AS 'Nationality', address AS 'Address', addressOfWorkshop AS 'Address Of Workshop', dependents AS 'Dependents', formId AS 'Form Id' " & _
                        "FROM tblCraftWorker " & _
                        "WHERE address like '" & searchContent & "%'"

                End If

            ElseIf (cboSearchFrom.Text.Equals("Description")) Then

                If cboSearchBy.Text.Equals("Usual Name") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT descriptionId AS 'Description Id', usualName AS 'Usual Name', localName AS 'Local Name', type AS 'Type', shape AS 'Shape', " & _
                        "measurement AS 'Measurement', rawMaterial AS 'Raw Material', decoration AS 'Decoration', used AS 'Use' " & _
                        "FROM tblDescription " & _
                        "WHERE usualName like '" & searchContent & "%'"

                ElseIf cboSearchBy.Text.Equals("Raw Material") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT descriptionId AS 'Description Id', usualName AS 'Usual Name', localName AS 'Local Name', type AS 'Type', shape AS 'Shape', " & _
                        "measurement AS 'Measurement', rawMaterial AS 'Raw Material', decoration AS 'Decoration', used AS 'Use' " & _
                        "FROM tblDescription " & _
                        "WHERE rawMaterial like '" & searchContent & "%'"

                ElseIf cboSearchBy.Text.Equals("Use") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT descriptionId AS 'Description Id', usualName AS 'Usual Name', localName AS 'Local Name', type AS 'Type', shape AS 'Shape', " & _
                        "measurement AS 'Measurement', rawMaterial AS 'Raw Material', decoration AS 'Decoration', used AS 'Use' " & _
                        "FROM tblDescription " & _
                        "WHERE used like '" & searchContent & "%'"

                End If

            ElseIf (cboSearchFrom.Text.Equals("Distribution")) Then

                If cboSearchBy.Text.Equals("Selling Method") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT distributionId AS 'Distribution Id', sellingMethod AS 'Selling Method', experienceNational AS 'Experience at National Exhibition', " & _
                        "experienceInternational  AS 'Experience at International Exhibition', experienceExport  AS 'Experience at Export', " & _
                        "havePlaceToDisplay AS 'Have Place To Display', placeToDisplay AS 'Place To Display', packaging AS 'Packaging', " & _
                        "typeOfPackaging AS 'Type of Packaging', meansOfTransportation AS 'Means of Tranaportation', formId  AS 'Form Id' " & _
                        "FROM tblDistribution " & _
                        "WHERE sellingMethod like '" & searchContent & "%'"

                End If

            ElseIf (cboSearchFrom.Text.Equals("Form")) Then

                If cboSearchBy.Text.Equals("Form ID") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT formId AS 'Form Id', formDate AS 'Form Date', formRegion AS 'Form Region', formPlace AS 'Form Place' " & _
                        "FROM tblForm " & _
                        "WHERE formId = '" & searchContent & "%'"

                ElseIf cboSearchBy.Text.Equals("Form Region") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT formId AS 'Form Id', formDate AS 'Form Date', formRegion AS 'Form Region', formPlace AS 'Form Place' " & _
                        "FROM tblForm " & _
                        "WHERE formRegion like '" & searchContent & "%'"

                ElseIf cboSearchBy.Text.Equals("Form Place") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT formId AS 'Form Id', formDate AS 'Form Date', formRegion AS 'Form Region', formPlace AS 'Form Place' " & _
                        "FROM tblForm " & _
                        "WHERE formPlace like '" & searchContent & "%'"

                End If

            ElseIf (cboSearchFrom.Text.Equals("Management")) Then

                If cboSearchBy.Text.Equals("Cost") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT managementId AS 'Management Id', costFor10 AS 'Cost For 10', costFor50 AS 'Cost For 50', costFor100 AS 'Cost For 100', otherExpenditure1 AS 'Expenditure for Object 1'," & _
                        "otherExpenditure2  AS 'Expenditure for Object 2', otherExpenditure3  AS 'Expenditure for Object 3', otherExpenditure4  AS 'Expenditure for Object 4', " & _
                        "cost AS 'Cost', sellingPrice AS 'Selling Price', priceVaryQuantity AS 'Price varies base on Quantity', priceVaryCustomer  AS 'Price varies base on Customer', " & _
                        "turnOverPerWeek AS 'Turn Over Per Week', turnOverPerMonth AS 'Turn Over Per Month', customerCredit AS 'DO you Give Customer Credit?', " & _
                        "supplierCredit AS 'Do you get credit from Suppliers?', wayOfFinancing AS 'Way of Financing', outsideFinancing AS 'Outside Financing', " & _
                        "rateOfInterest AS 'Rate Of Interese', source AS 'Source', debts AS 'Debts', debtsTurnOver AS 'Debts Turn Over', keepAccount AS 'Do you keep Account?', " & _
                        "kindOfAccount AS 'Kind of Account', bankAccount AS 'Do you use Bank Account?', chequeBook AS 'Do you use Credit Book?', formId  AS 'Form Id' " & _
                        "FROM tblManagement " & _
                        "WHERE cost " & cboCriteria.Text.Trim & " '" & searchContent & "'"

                ElseIf cboSearchBy.Text.Equals("Selling Price") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                       "SELECT managementId AS 'Management Id', costFor10 AS 'Cost For 10', costFor50 AS 'Cost For 50', costFor100 AS 'Cost For 100', otherExpenditure1 AS 'Expenditure for Object 1'," & _
                        "otherExpenditure2  AS 'Expenditure for Object 2', otherExpenditure3  AS 'Expenditure for Object 3', otherExpenditure4  AS 'Expenditure for Object 4', " & _
                        "cost AS 'Cost', sellingPrice AS 'Selling Price', priceVaryQuantity AS 'Price varies base on Quantity', priceVaryCustomer  AS 'Price varies base on Customer', " & _
                        "turnOverPerWeek AS 'Turn Over Per Week', turnOverPerMonth AS 'Turn Over Per Month', customerCredit AS 'DO you Give Customer Credit?', " & _
                        "supplierCredit AS 'Do you get credit from Suppliers?', wayOfFinancing AS 'Way of Financing', outsideFinancing AS 'Outside Financing', " & _
                        "rateOfInterest AS 'Rate Of Interese', source AS 'Source', debts AS 'Debts', debtsTurnOver AS 'Debts Turn Over', keepAccount AS 'Do you keep Account?', " & _
                        "kindOfAccount AS 'Kind of Account', bankAccount AS 'Do you use Bank Account?', chequeBook AS 'Do you use Credit Book?', formId  AS 'Form Id' " & _
                        "FROM tblManagement " & _
                        "WHERE sellingPrice " & cboCriteria.Text.Trim & " '" & searchContent & "'"

                End If

            ElseIf (cboSearchFrom.Text.Equals("Production")) Then

                If cboSearchBy.Text.Equals("Made In") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT productionId AS 'Production Id', madeIn AS 'Made In', soldIn AS 'Sold In', seenIn AS 'Seen In', nameOfCraftWorker AS 'Name of Craft Worker', addressOfCraftWorker AS 'Address of Craft Worker', " & _
                        "localPrice AS 'Local Price', observation AS 'Observation', formId AS 'Form Id' " & _
                        "FROM tblProduction " & _
                        "WHERE madeIn like '" & searchContent & "%'"

                ElseIf cboSearchBy.Text.Equals("Name Of Craft Worker") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT productionId AS 'Production Id', madeIn AS 'Made In', soldIn AS 'Sold In', seenIn AS 'Seen In', nameOfCraftWorker AS 'Name of Craft Worker', addressOfCraftWorker AS 'Address of Craft Worker', " & _
                        "localPrice AS 'Local Price', observation AS 'Observation', formId AS 'Form Id' " & _
                        "FROM tblProduction " & _
                        "WHERE nameOfCraftWorker like '" & searchContent & "%'"

                ElseIf cboSearchBy.Text.Equals("Address Of Craft Worker") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT productionId AS 'Production Id', madeIn AS 'Made In', soldIn AS 'Sold In', seenIn AS 'Seen In', nameOfCraftWorker AS 'Name of Craft Worker', addressOfCraftWorker AS 'Address of Craft Worker', " & _
                        "localPrice AS 'Local Price', observation AS 'Observation', formId AS 'Form Id' " & _
                        "FROM tblProduction " & _
                        "WHERE addressOfCraftWorker like '" & searchContent & "%'"

                ElseIf cboSearchBy.Text.Equals("Local Price") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT productionId AS 'Production Id', madeIn AS 'Made In', soldIn AS 'Sold In', seenIn AS 'Seen In', " & _
                        "nameOfCraftWorker AS 'Name of Craft Worker', addressOfCraftWorker AS 'Address of Craft Worker', " & _
                        "localPrice AS 'Local Price', observation AS 'Observation', formId AS 'Form Id' " & _
                        "FROM tblProduction " & _
                        "WHERE localPrice " & cboCriteria.Text.Trim & " '" & searchContent & "'"

                End If

            ElseIf (cboSearchFrom.Text.Equals("Definition")) Then

                If cboSearchBy.Text.Equals("Experience") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT definitionId AS 'Definition ID', experience AS 'Experiece (in years)', iDate AS 'Initial Training Date', iPlace AS 'Initial Training Place', " & _
                        "iLength AS 'Initial Training Length', iResponsible AS 'Initial Trainer', laDate AS 'Later Training Date', laPlace AS 'Later Training Place', " & _
                        "laLength AS 'Later Training Length', laResponsible AS 'Later Trainer', objectsMade AS 'Obejcts Made', rawMaterialsUsed AS 'Raw Materials Used', " & _
                        "typeOfProduct AS 'Type Of Product', activity AS 'Activity', familyHelp AS 'Number of Family Help', apprenticeHelp AS 'Number of Apprentice Help', " & _
                        "employeeHelp AS 'Number of Employee Help', formId AS 'Form Id' " & _
                        "FROM tblDefinition " & _
                        "WHERE experience " & cboCriteria.Text.Trim & " '" & searchContent & "'"

                ElseIf cboSearchBy.Text.Equals("Initial Training Length") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT definitionId AS 'Definition ID', experience AS 'Experiece (in years)', iDate AS 'Initial Training Date', iPlace AS 'Initial Training Place', " & _
                        "iLength AS 'Initial Training Length', iResponsible AS 'Initial Trainer', laDate AS 'Later Training Date', laPlace AS 'Later Training Place', " & _
                        "laLength AS 'Later Training Length', laResponsible AS 'Later Trainer', objectsMade AS 'Obejcts Made', rawMaterialsUsed AS 'Raw Materials Used', " & _
                        "typeOfProduct AS 'Type Of Product', activity AS 'Activity', familyHelp AS 'Number of Family Help', apprenticeHelp AS 'Number of Apprentice Help', " & _
                        "employeeHelp AS 'Number of Employee Help', formId AS 'Form Id' " & _
                        "FROM tblDefinition " & _
                        "WHERE iLength " & cboCriteria.Text.Trim & " '" & searchContent & "'"

                End If

            ElseIf (cboSearchFrom.Text.Equals("Social Position")) Then

                If cboSearchBy.Text.Equals("Local Status") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT socialPositionId AS 'Social Position Id', transportation AS 'Transportation?', housing AS 'Housing?', telHome AS 'Home Telephone?', telMobile AS 'Mobile Telephone?', localStatus AS 'Local Status', " & _
                        "memberOfOrganization AS 'Member Of Organization', contactWithGovenment AS 'Contact with Government', nameOfContact AS 'Name Of Contact Organization', stateAidFinance AS 'State Aid through Finance', " & _
                        "stateAidTraining AS 'State Aid through Training', stateAidEquipement AS 'State Aid through Equipment', formId AS 'Form Id' " & _
                        "FROM tblSocialPosition " & _
                        "WHERE localStatus like '" & searchContent & "%'"

                End If

            ElseIf (cboSearchFrom.Text.Equals("Supply")) Then

                If cboSearchBy.Text.Equals("Origin") Then

                    selectDataAdaptor.SelectCommand.CommandText = _
                        "SELECT socialPositionId AS 'Social Position Id', transportation AS 'Transportation?', housing AS 'Housing?', telHome AS 'Home Telephone?', telMobile AS 'Mobile Telephone?', localStatus AS 'Local Status', " & _
                        "memberOfOrganization AS 'Member Of Organization', contactWithGovenment AS 'Contact with Government', nameOfContact AS 'Name Of Contact Organization', stateAidFinance AS 'State Aid through Finance', " & _
                        "stateAidTraining AS 'State Aid through Training', stateAidEquipement AS 'State Aid through Equipment', formId AS 'Form Id' " & _
                        "FROM tblSocialPosition " & _
                        "WHERE origin like '" & searchContent & "%'"

                End If

            Else

                MessageBox.Show("Please check the Search By.", "CIDS - Search Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            Dim objDataSet As New DataSet

            selectDataAdaptor.Fill(objDataSet, "Search")
            selectDataAdaptor.AcceptChangesDuringFill = True

            gvSearch.DataSource = objDataSet
            gvSearch.DataMember = "Search"
            gvSearch.AllowUserToResizeColumns = True
            gvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader


            If gvSearch.RowCount = 0 Then
                MessageBox.Show("No Match Found!", "CIDS - No Match", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Call btnRefresh_Click(Nothing, Nothing)
            End If

        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        txtSearchText.Text = ""
        gvSearch.DataSource = Nothing
        gvSearch.DataMember = Nothing

    End Sub

    Private Sub cboSearchFrom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchFrom.SelectedIndexChanged

        If cboSearchFrom.Text.Equals("Craft Worker") Then

            cboSearchBy.Items.Clear()
            cboSearchBy.Items.Add("First Name")
            cboSearchBy.Items.Add("Sur Name")
            cboSearchBy.Items.Add("Age")
            cboSearchBy.Items.Add("Address")
            cboSearchBy.Items.Add("Address of Workshop")
            cboSearchBy.SelectedIndex = 0

        ElseIf cboSearchFrom.Text.Equals("Description") Then

            cboSearchBy.Items.Clear()
            cboSearchBy.Items.Add("Usual Name")
            cboSearchBy.Items.Add("Raw Material")
            cboSearchBy.Items.Add("Use")
            cboSearchBy.SelectedIndex = 0

        ElseIf cboSearchFrom.Text.Equals("Distribution") Then

            cboSearchBy.Items.Clear()
            cboSearchBy.Items.Add("Selling Method")
            cboSearchBy.SelectedIndex = 0

        ElseIf cboSearchFrom.Text.Equals("Form") Then

            Label2.Enabled = True
            cboCriteria.Enabled = True
            cboSearchBy.Items.Clear()
            cboSearchBy.Items.Add("Form ID")
            cboSearchBy.Items.Add("Form Region")
            cboSearchBy.Items.Add("Form Place")
            cboSearchBy.SelectedIndex = 0

        ElseIf cboSearchFrom.Text.Equals("Management") Then

            Label2.Enabled = True
            cboCriteria.Enabled = True
            cboSearchBy.Items.Clear()
            cboSearchBy.Items.Add("Cost")
            cboSearchBy.Items.Add("Selling Price")
            cboSearchBy.SelectedIndex = 0

        ElseIf cboSearchFrom.Text.Equals("Production") Then

            cboSearchBy.Items.Clear()
            cboSearchBy.Items.Add("Made In")
            cboSearchBy.Items.Add("Name Of Craft Worker")
            cboSearchBy.Items.Add("Address of Craft Worker")
            cboSearchBy.Items.Add("Local Price")
            cboSearchBy.SelectedIndex = 0

        ElseIf cboSearchFrom.Text.Equals("Social Position") Then

            cboSearchBy.Items.Clear()
            cboSearchBy.Items.Add("Local Status")
            cboSearchBy.SelectedIndex = 0

        ElseIf cboSearchFrom.Text.Equals("Supply") Then

            cboSearchBy.Items.Clear()
            cboSearchBy.Items.Add("Origin")
            cboSearchBy.SelectedIndex = 0

        ElseIf cboSearchFrom.Text.Equals("Definition") Then

            cboSearchBy.Items.Clear()
            cboSearchBy.Items.Add("Exerience")
            cboSearchBy.Items.Add("Initial Training Length")
            cboSearchBy.SelectedIndex = 0

        End If

    End Sub

    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboSearchFrom.SelectedIndex = 0
        cboCriteria.SelectedIndex = 0

        Label2.Enabled = False
        cboCriteria.Enabled = False

    End Sub

    Private Sub cboSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSearchBy.SelectedIndexChanged

        If cboSearchBy.Text.Equals("Age") Then

            Label2.Enabled = True
            cboCriteria.Enabled = True

        ElseIf cboSearchBy.Text.Equals("Local Price") Then

            Label2.Enabled = True
            cboCriteria.Enabled = True

        ElseIf cboSearchBy.Text.Equals("Experience") Then

            Label2.Enabled = True
            cboCriteria.Enabled = True

        ElseIf cboSearchBy.Text.Equals("Initial Training Length") Then

            Label2.Enabled = True
            cboCriteria.Enabled = True

        ElseIf cboSearchBy.Text.Equals("Cost") Then

            Label2.Enabled = True
            cboCriteria.Enabled = True

        ElseIf cboSearchBy.Text.Equals("Selling Price") Then

            Label2.Enabled = True
            cboCriteria.Enabled = True

        Else

            Label2.Enabled = False
            cboCriteria.Enabled = False

        End If

    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click

        Me.Text = "Please wait until the excel file is prepared."
        Me.Enabled = False
        ' Me.Enabled = False
        If gvSearch.RowCount = 0 Then

            MessageBox.Show("There is no data in the Table.", "CIDS - Blank Table", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim wapp As Microsoft.Office.Interop.Excel.Application

            Dim wsheet As New Microsoft.Office.Interop.Excel.Worksheet

            Dim wbook As Microsoft.Office.Interop.Excel.Workbook

            wapp = New Microsoft.Office.Interop.Excel.Application

            wapp.Visible = True

            wbook = wapp.Workbooks.Add()

            wsheet = wbook.ActiveSheet

            Dim iX As Integer

            Dim iY As Integer

            Dim iC As Integer

            For iC = 0 To gvSearch.Columns.Count - 1

                wsheet.Cells(1, iC + 1).Value = gvSearch.Columns(iC).HeaderText

                wsheet.Cells(1, iC + 1).font.bold = True

            Next

            wsheet.Rows(1).select()

            For iX = 0 To gvSearch.Rows.Count - 1

                For iY = 0 To gvSearch.Columns.Count - 1

                    wsheet.Cells(iX + 2, iY + 1).value = gvSearch(iY, iX).Value.ToString

                Next

            Next

            wapp.Visible = True

            wapp.UserControl = True

            'Me.Enabled = True
        End If

        Me.Text = "CIDS-Search."
        Me.Enabled = True
    End Sub

End Class