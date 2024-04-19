'Title:         TW Inventory Data Tier
'Date:          11-27-14
'Author:        Terry Holmes

'Description:   This is the data tier for the whole application

Option Strict On

Public Class TWInventoryDataTier

    'Setting up the modular variables
    Private aBOMPartsDataSetTableAdapter As BOMPartsDataSetTableAdapters.BOMPartsTableAdapter
    Private aBOMPartsDataSet As BOMPartsDataSet

    Private aCreateIDDataSetTableAdapter As CreateIIDDataSetTableAdapters.CreateIDTableAdapter
    Private aCreateIDDataSet As CreateIIDDataSet

    Private aInventoryDataSetTableAdapter As InventoryDataSetTableAdapters.InventoryTableAdapter
    Private aInventoryDataSet As InventoryDataSet

    Private aIssuedPartsDataSetTableAdapter As IssuedPartsDataSetTableAdapters.IssuedPartsTableAdapter
    Private aIssuedPartsDataSet As New IssuedPartsDataSet

    Private aReceivedPartsDataSetTableAdapter As ReceivedPartsDataSetTableAdapters.ReceivedPartsTableAdapter
    Private aReceivedPartsDataSet As New ReceivedPartsDataSet

    Private aWarehouseInventoryDataSetTableAdapter As WarehouseInventoryDataSetTableAdapters.WarehouseInventoryTableAdapter
    Private aWarehouseInventoryDataSet As New WarehouseInventoryDataSet

    Private aEmployeesDataSetTableAdapter As employeesDataSetTableAdapters.employeesTableAdapter
    Private aEmployeesDataSet As New employeesDataSet

    Private aAdjustInventoryDataSetTableAdapter As AdjustInventoryDataSetTableAdapters.adjustinventoryTableAdapter
    Private aAdjustInventoryDataSet As New AdjustInventoryDataSet

    Private aMSROrderHeaderDataSetTableAdapter As MSROrderHeaderDataSetTableAdapters.msrorderheaderTableAdapter
    Private aMSROrderHeaderDataSet As New MSROrderHeaderDataSet

    Private aMSROrderPartsDataSetTableAdapter As MSROrderPartsDataSetTableAdapters.msrorderpartsTableAdapter
    Private aMSROrderPartsDataSet As New MSROrderPartsDataSet

    Private aMSROrderIDDataSetTableAdapter As MSROrderIDDataSetTableAdapters.msrorderidTableAdapter
    Private aMSROrderIDDataSet As New MSROrderIDDataSet

    Private aVendorReturnsDataSetTableAdapter As VendorReturnsDataSetTableAdapters.vendorreturnsTableAdapter
    Private aVendorReturnsDataSet As New VendorReturnsDataSet

    Private aVendorReturnsIDDataSetTableAdapter As VendorReturnsIDDataSetTableAdapters.vendorreturnsidTableAdapter
    Private aVendorReturnsIDDataSet As New VendorReturnsIDDataSet

    Public Function GetVendorReturnsIDInformation() As VendorReturnsIDDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aVendorReturnsIDDataSet = New VendorReturnsIDDataSet
            aVendorReturnsIDDataSetTableAdapter = New VendorReturnsIDDataSetTableAdapters.vendorreturnsidTableAdapter
            aVendorReturnsIDDataSetTableAdapter.Fill(aVendorReturnsIDDataSet.vendorreturnsid)
            Return aVendorReturnsIDDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aVendorReturnsIDDataSet

        End Try

    End Function
    Public Sub UpdateVendorReturnsIDDB(ByVal aVendorReturnsIDDataSet As VendorReturnsIDDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aVendorReturnsIDDataSetTableAdapter.Update(aVendorReturnsIDDataSet.vendorreturnsid)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetVendorReturnsInformation() As VendorReturnsDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aVendorReturnsDataSet = New VendorReturnsDataSet
            aVendorReturnsDataSetTableAdapter = New VendorReturnsDataSetTableAdapters.vendorreturnsTableAdapter
            aVendorReturnsDataSetTableAdapter.Fill(aVendorReturnsDataSet.vendorreturns)
            Return aVendorReturnsDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aVendorReturnsDataSet

        End Try

    End Function
    Public Sub UpdateVendorReturnsDB(ByVal aVendorReturnsDataSet As VendorReturnsDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aVendorReturnsDataSetTableAdapter.Update(aVendorReturnsDataSet.vendorreturns)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetMSROrderIDInformation() As MSROrderIDDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aMSROrderIDDataSet = New MSROrderIDDataSet
            aMSROrderIDDataSetTableAdapter = New MSROrderIDDataSetTableAdapters.msrorderidTableAdapter
            aMSROrderIDDataSetTableAdapter.Fill(aMSROrderIDDataSet.msrorderid)
            Return aMSROrderIDDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aMSROrderIDDataSet

        End Try

    End Function
    Public Sub UpdateMSROrderIDDB(ByVal aMSROrderIDDataSet As MSROrderIDDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aMSROrderIDDataSetTableAdapter.Update(aMSROrderIDDataSet.msrorderid)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetMSROrderPartsInformation() As MSROrderPartsDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aMSROrderPartsDataSet = New MSROrderPartsDataSet
            aMSROrderPartsDataSetTableAdapter = New MSROrderPartsDataSetTableAdapters.msrorderpartsTableAdapter
            aMSROrderPartsDataSetTableAdapter.Fill(aMSROrderPartsDataSet.msrorderparts)
            Return aMSROrderPartsDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aMSROrderPartsDataSet

        End Try

    End Function
    Public Sub UpdateMSROrderPartsDB(ByVal aMSROrderPartsDataSet As MSROrderPartsDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aMSROrderPartsDataSetTableAdapter.Update(aMSROrderPartsDataSet.msrorderparts)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetMSROrderHeaderInformation() As MSROrderHeaderDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aMSROrderHeaderDataSet = New MSROrderHeaderDataSet
            aMSROrderHeaderDataSetTableAdapter = New MSROrderHeaderDataSetTableAdapters.msrorderheaderTableAdapter
            aMSROrderHeaderDataSetTableAdapter.Fill(aMSROrderHeaderDataSet.msrorderheader)
            Return aMSROrderHeaderDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aMSROrderHeaderDataSet

        End Try

    End Function
    Public Sub UpdateMSROrderHeaderDB(ByVal aMSROrderHeaderDataSet As MSROrderHeaderDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aMSROrderHeaderDataSetTableAdapter.Update(aMSROrderHeaderDataSet.msrorderheader)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetAdjustInventoryInformation() As AdjustInventoryDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aAdjustInventoryDataSet = New AdjustInventoryDataSet
            aAdjustInventoryDataSetTableAdapter = New AdjustInventoryDataSetTableAdapters.adjustinventoryTableAdapter
            aAdjustInventoryDataSetTableAdapter.Fill(aAdjustInventoryDataSet.adjustinventory)
            Return aAdjustInventoryDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aAdjustInventoryDataSet

        End Try

    End Function
    Public Sub UpdateAdjustInventoryDB(ByVal aAdjustInventoryDataSet As AdjustInventoryDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aAdjustInventoryDataSetTableAdapter.Update(aAdjustInventoryDataSet.adjustinventory)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetEmployeesInformation() As employeesDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aEmployeesDataSet = New employeesDataSet
            aEmployeesDataSetTableAdapter = New employeesDataSetTableAdapters.employeesTableAdapter
            aEmployeesDataSetTableAdapter.Fill(aEmployeesDataSet.employees)
            Return aEmployeesDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aEmployeesDataSet

        End Try

    End Function
    Public Sub UpdateEmployeesDB(ByVal aEmployeesDataSet As employeesDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aEmployeesDataSetTableAdapter.Update(aEmployeesDataSet.employees)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetWarehouseInventoryInformation() As WarehouseInventoryDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aWarehouseInventoryDataSet = New WarehouseInventoryDataSet
            aWarehouseInventoryDataSetTableAdapter = New WarehouseInventoryDataSetTableAdapters.WarehouseInventoryTableAdapter
            aWarehouseInventoryDataSetTableAdapter.Fill(aWarehouseInventoryDataSet.WarehouseInventory)
            Return aWarehouseInventoryDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aWarehouseInventoryDataSet

        End Try

    End Function
    Public Sub UpdateWarehouseInventoryDB(ByVal aWarehouseInventoryDataSet As WarehouseInventoryDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aWarehouseInventoryDataSetTableAdapter.Update(aWarehouseInventoryDataSet.WarehouseInventory)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetReceivedPartsInformation() As ReceivedPartsDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aReceivedPartsDataSet = New ReceivedPartsDataSet
            aReceivedPartsDataSetTableAdapter = New ReceivedPartsDataSetTableAdapters.ReceivedPartsTableAdapter
            aReceivedPartsDataSetTableAdapter.Fill(aReceivedPartsDataSet.ReceivedParts)
            Return aReceivedPartsDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aReceivedPartsDataSet

        End Try

    End Function
    Public Sub UpdateReceivedPartsDB(ByVal aReceivedPartsDataSet As ReceivedPartsDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aReceivedPartsDataSetTableAdapter.Update(aReceivedPartsDataSet.ReceivedParts)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetIssuedPartsInformation() As IssuedPartsDataSet
        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aIssuedPartsDataSet = New IssuedPartsDataSet
            aIssuedPartsDataSetTableAdapter = New IssuedPartsDataSetTableAdapters.IssuedPartsTableAdapter
            aIssuedPartsDataSetTableAdapter.Fill(aIssuedPartsDataSet.IssuedParts)
            Return aIssuedPartsDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aIssuedPartsDataSet

        End Try

    End Function
    Public Sub UpdateIssuedPartsDB(ByVal aIssuedPartsDataSet As IssuedPartsDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aIssuedPartsDataSetTableAdapter.Update(aIssuedPartsDataSet.IssuedParts)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetInventoryInformation() As InventoryDataSet

        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aInventoryDataSet = New InventoryDataSet
            aInventoryDataSetTableAdapter = New InventoryDataSetTableAdapters.InventoryTableAdapter
            aInventoryDataSetTableAdapter.Fill(aInventoryDataSet.Inventory)
            Return aInventoryDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aInventoryDataSet

        End Try

    End Function
    Public Sub UpdateInventoryDB(ByVal aInventoryDataSet As InventoryDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aInventoryDataSetTableAdapter.Update(aInventoryDataSet.Inventory)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetCreateIDInformation() As CreateIIDDataSet

        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aCreateIDDataSet = New CreateIIDDataSet
            aCreateIDDataSetTableAdapter = New CreateIIDDataSetTableAdapters.CreateIDTableAdapter
            aCreateIDDataSetTableAdapter.Fill(aCreateIDDataSet.CreateID)
            Return aCreateIDDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aCreateIDDataSet

        End Try

    End Function
    Public Sub UpdateCreateIDDB(ByVal aCreateIDDataSet As CreateIIDDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aCreateIDDataSetTableAdapter.Update(aCreateIDDataSet.CreateID)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Function GetBOMPartsInformation() As BOMPartsDataSet

        'Try Catch for execeptions
        Try

            'Loading up the data tier
            aBOMPartsDataSet = New BOMPartsDataSet
            aBOMPartsDataSetTableAdapter = New BOMPartsDataSetTableAdapters.BOMPartsTableAdapter
            aBOMPartsDataSetTableAdapter.Fill(aBOMPartsDataSet.BOMParts)
            Return aBOMPartsDataSet

        Catch ex As Exception

            'This will run if the procedure throws and exception
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return aBOMPartsDataSet

        End Try

    End Function
    Public Sub UpdateBOMPartsDB(ByVal aBOMPartsDataSet As BOMPartsDataSet)

        'Try Catch if procedure throws an exeption
        Try

            aBOMPartsDataSetTableAdapter.Update(aBOMPartsDataSet.BOMParts)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

End Class
