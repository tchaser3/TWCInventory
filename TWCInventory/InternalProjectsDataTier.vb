'Title:         Internal Projects Data Tier
'Data:          1-21-15
'Author:        Terry Holmes

'Description:   This is the Data Tier for the Internal Projects Form

Option Strict On

Public Class InternalProjectsDataTier

    'Setting Up Internal Projects Modular Variables
    Private aInternalProjectsDataSetTableAdapter As InternalProjectsDataSetTableAdapters.internalprojectsTableAdapter
    Private aInternalProjectsDataSet As InternalProjectsDataSet

    'Setting Up Internal Projects Modular Variables
    Private aInternalProjectsIDCreationDataSetTableAdapter As InternalProjectsIDCreationDataSetTableAdapters.internalprojectsidcreationTableAdapter
    Private aInternalProjectsIDCreationDataSet As InternalProjectsIDCreationDataSet

    Public Function GetInternalProjectsIDCreationInformation() As InternalProjectsIDCreationDataSet

        'Setting up this Function of the Data Tier
        Try

            aInternalProjectsIDCreationDataSet = New InternalProjectsIDCreationDataSet
            aInternalProjectsIDCreationDataSetTableAdapter = New InternalProjectsIDCreationDataSetTableAdapters.internalprojectsidcreationTableAdapter
            aInternalProjectsIDCreationDataSetTableAdapter.Fill(aInternalProjectsIDCreationDataSet.internalprojectsidcreation)
            Return aInternalProjectsIDCreationDataSet

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aInternalProjectsIDCreationDataSet

        End Try
    End Function

    Public Sub UpdateInternalProjectsIDCreationDB(ByVal aInternalProjectsIDCreationDataSet As InternalProjectsIDCreationDataSet)

        Try

            aInternalProjectsIDCreationDataSetTableAdapter.Update(aInternalProjectsIDCreationDataSet.internalprojectsidcreation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function GetInternalProjectsInformation() As InternalProjectsDataSet

        'Setting up this Function of the Data Tier
        Try

            aInternalProjectsDataSet = New InternalProjectsDataSet
            aInternalProjectsDataSetTableAdapter = New InternalProjectsDataSetTableAdapters.internalprojectsTableAdapter
            aInternalProjectsDataSetTableAdapter.Fill(aInternalProjectsDataSet.internalprojects)
            Return aInternalProjectsDataSet

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aInternalProjectsDataSet

        End Try
    End Function

    Public Sub UpdateInternalProjectsDB(ByVal aInternalProjectsDataSet As InternalProjectsDataSet)

        Try

            aInternalProjectsDataSetTableAdapter.Update(aInternalProjectsDataSet.internalprojects)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
