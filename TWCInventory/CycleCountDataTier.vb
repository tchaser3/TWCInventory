'Title:         Cycle Count Data Tier
'Date:          2-13-15
'Author:        Terry Holmes

'Description:   This is the data tier for cycle counts.  I am creating a speccial
'               class for this as it will be placed in the main program.

Option Strict On

Public Class CycleCountDataTier

    'Setting up the variables
    Private aCycleCountDataSetTableAdapters As CycleCountDataSetTableAdapters.cyclecountTableAdapter
    Private aCycleCountDataSet As CycleCountDataSet

    Private aCycleCountIDDataSetTableAdapters As CycleCountIDDataSetTableAdapters.cyclecountidTableAdapter
    Private aCycleCountIDDataSet As CycleCountIDDataSet

    Private aCycleCountTimesCountedDataSetTableAdapters As CycleCountTimesCountedDataSetTableAdapters.cyclecounttimescountedTableAdapter
    Private aCycleCountTimesCountedDataSet As CycleCountTimesCountedDataSet

    Public Function GetCycleCountInformation() As CycleCountDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aCycleCountDataSet = New CycleCountDataSet
            aCycleCountDataSetTableAdapters = New CycleCountDataSetTableAdapters.cyclecountTableAdapter
            aCycleCountDataSetTableAdapters.Fill(aCycleCountDataSet.cyclecount)
            Return aCycleCountDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aCycleCountDataSet

        End Try

    End Function
    Public Sub UpdateCycleCountDB(ByVal aCycleCountDataSet As CycleCountDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aCycleCountDataSetTableAdapters.Update(aCycleCountDataSet.cyclecount)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Public Function GetCycleCountIDInformation() As CycleCountIDDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aCycleCountIDDataSet = New CycleCountIDDataSet
            aCycleCountIDDataSetTableAdapters = New CycleCountIDDataSetTableAdapters.cyclecountidTableAdapter
            aCycleCountIDDataSetTableAdapters.Fill(aCycleCountIDDataSet.cyclecountid)
            Return aCycleCountIDDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aCycleCountIDDataSet

        End Try

    End Function
    Public Sub UpdateCycleCountIDDB(ByVal aCycleCountIDDataSet As CycleCountIDDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aCycleCountIDDataSetTableAdapters.Update(aCycleCountIDDataSet.cyclecountid)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Public Function GetCycleCountTimesCountedInformation() As CycleCountTimesCountedDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aCycleCountTimesCountedDataSet = New CycleCountTimesCountedDataSet
            aCycleCountTimesCountedDataSetTableAdapters = New CycleCountTimesCountedDataSetTableAdapters.cyclecounttimescountedTableAdapter
            aCycleCountTimesCountedDataSetTableAdapters.Fill(aCycleCountTimesCountedDataSet.cyclecounttimescounted)
            Return aCycleCountTimesCountedDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aCycleCountTimesCountedDataSet

        End Try

    End Function
    Public Sub UpdateCycleCountTimesCountedDB(ByVal aCycleCountTimesCountedDataSet As CycleCountTimesCountedDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aCycleCountTimesCountedDataSetTableAdapters.Update(aCycleCountTimesCountedDataSet.cyclecounttimescounted)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class
