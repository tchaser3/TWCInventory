'Title:         Pick List Data Tier
'Date:          2-20-15
'Author:        Terry Holmes

'Description:   This class is the pick list data tier

Option Strict On

Public Class PickListDataTier

    'Setting up the global variables
    Private aPickListDataSetTableAdapters As PickListDataSetTableAdapters.picklistTableAdapter
    Private aPickListDataSet As PickListDataSet

    Private aPickListIDDataSetTableAdpaters As PickListIDDataSetTableAdapters.picklistidTableAdapter
    Private aPickListIDDataSet As PickListIDDataSet

    Private aPickListTransactionsDataSetTableAdapters As PickListTransactionsDataSetTableAdapters.picklisttransactionsTableAdapter
    Private aPickListTransactionsDataSet As PickListTransactionsDataSet

    Private aPickListTransactionIDDataSetTableAdapter As PickListTransactionIDDataSetTableAdapters.picklisttransactionidTableAdapter
    Private aPickListTransactionIDDataSet As PickListTransactionIDDataSet

    'Setting up public functions
    Public Function GetPickListTransactionIDInformation() As PickListTransactionIDDataSet

        'Try Catch
        Try

            aPickListTransactionIDDataSet = New PickListTransactionIDDataSet
            aPickListTransactionIDDataSetTableAdapter = New PickListTransactionIDDataSetTableAdapters.picklisttransactionidTableAdapter
            aPickListTransactionIDDataSetTableAdapter.Fill(aPickListTransactionIDDataSet.picklisttransactionid)
            Return aPickListTransactionIDDataSet

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aPickListTransactionIDDataSet

        End Try
    End Function
    Public Sub UpdatePickListTransactionIDDB(ByVal aPickListTransactionIDDataSet As PickListTransactionIDDataSet)

        Try

            aPickListTransactionIDDataSetTableAdapter.Update(aPickListTransactionIDDataSet.picklisttransactionid)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function GetPickListTransactionsInformation() As PickListTransactionsDataSet

        'Try Catch
        Try

            aPickListTransactionsDataSet = New PickListTransactionsDataSet
            aPickListTransactionsDataSetTableAdapters = New PickListTransactionsDataSetTableAdapters.picklisttransactionsTableAdapter
            aPickListTransactionsDataSetTableAdapters.Fill(aPickListTransactionsDataSet.picklisttransactions)
            Return aPickListTransactionsDataSet

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aPickListTransactionsDataSet

        End Try
    End Function
    Public Sub UpdatePickListTransactionsDB(ByVal aPickListTransactionsDataSet As PickListTransactionsDataSet)

        Try

            aPickListTransactionsDataSetTableAdapters.Update(aPickListTransactionsDataSet.picklisttransactions)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function GetPickListIDInformation() As PickListIDDataSet

        'Try Catch
        Try

            aPickListIDDataSet = New PickListIDDataSet
            aPickListIDDataSetTableAdpaters = New PickListIDDataSetTableAdapters.picklistidTableAdapter
            aPickListIDDataSetTableAdpaters.Fill(aPickListIDDataSet.picklistid)
            Return aPickListIDDataSet

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aPickListIDDataSet

        End Try
    End Function
    Public Sub UpdatePickListIDDB(ByVal aPickListIDDataSet As PickListIDDataSet)

        Try

            aPickListIDDataSetTableAdpaters.Update(aPickListIDDataSet.picklistid)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function GetPickListInformation() As PickListDataSet

        'Try Catch
        Try

            aPickListDataSet = New PickListDataSet
            aPickListDataSetTableAdapters = New PickListDataSetTableAdapters.picklistTableAdapter
            aPickListDataSetTableAdapters.Fill(aPickListDataSet.picklist)
            Return aPickListDataSet

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aPickListDataSet

        End Try
    End Function
    Public Sub UpdatePickListDB(ByVal aPickListDataSet As PickListDataSet)

        Try

            aPickListDataSetTableAdapters.Update(aPickListDataSet.picklist)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
