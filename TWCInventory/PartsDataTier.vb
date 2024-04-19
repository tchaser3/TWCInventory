'Title:         Parts Data Tier
'Date:          2-4-15
'Author:        Terry Holmes

'Description    This data tier is used for all parts

Option Strict On

Public Class PartsDataTier

    Private aPartNumberTableAdapter As PartNumberDataSetTableAdapters.partnumbersTableAdapter
    Private aPartNumberDataSet As PartNumberDataSet

    Private aPartNumberIDTableAdapter As PartNumberIDDataSetTableAdapters.PartNumberIDTableAdapter
    Private aPartNumberIDDataSet As PartNumberIDDataSet

    Public Function GetPartNumberIDInformation() As PartNumberIDDataSet

        'Setting up the Datatier
        Try
            aPartNumberIDDataSet = New PartNumberIDDataSet
            aPartNumberIDTableAdapter = New PartNumberIDDataSetTableAdapters.PartNumberIDTableAdapter
            aPartNumberIDTableAdapter.Fill(aPartNumberIDDataSet.PartNumberID)
            Return aPartNumberIDDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aPartNumberIDDataSet
        End Try
    End Function

    Public Sub UpdatePartNumberIDDB(ByVal aPartNumberIDDataSet As PartNumberIDDataSet)

        'This will update the database
        Try
            aPartNumberIDTableAdapter.Update(aPartNumberIDDataSet.PartNumberID)
        Catch ex As Exception

        End Try
    End Sub

    Public Function GetPartNumberInformation() As PartNumberDataSet

        'Setting up the Datatier
        Try
            aPartNumberDataSet = New PartNumberDataSet
            aPartNumberTableAdapter = New PartNumberDataSetTableAdapters.partnumbersTableAdapter
            aPartNumberTableAdapter.Fill(aPartNumberDataSet.partnumbers)
            Return aPartNumberDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aPartNumberDataSet
        End Try
    End Function

    Public Sub UpdatePartNumberDB(ByVal aPartNumberDataSet As PartNumberDataSet)

        'This will update the database
        Try
            aPartNumberTableAdapter.Update(aPartNumberDataSet.partnumbers)
        Catch ex As Exception

        End Try
    End Sub

End Class
