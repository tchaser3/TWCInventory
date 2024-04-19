﻿'Title:         Create Last Transaction ID
'Date:          1-9-15
'Author:        Terry Holmes

'Description:   This is used to create the last Transaction ID

Option Strict On

Public Class CreateLastTransactionID

    'Setting global variables
    Private TheLastTransactionIDDataSet As LastTransactionIDDataSet
    Private TheLastTransactionIDDataTier As LastTransactionDataTier
    Private WithEvents TheLastTransactionIDBindingSource As BindingSource

    Private editingBoolean As Boolean = False
    Private addingBoolean As Boolean = False
    Private previousSelectedIndex As Integer

    Private Sub CreateLastTransactionID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Setting local variables
        Dim intNumberOfRecords As Integer

        'Try Catch to load controls
        Try

            TheLastTransactionIDDataTier = New LastTransactionDataTier
            TheLastTransactionIDDataSet = TheLastTransactionIDDataTier.GetLastTransactionIDInformation
            TheLastTransactionIDBindingSource = New BindingSource

            'Setting up the binding source
            With TheLastTransactionIDBindingSource
                .DataSource = TheLastTransactionIDDataSet
                .DataMember = "lasttransactionid"
                .MoveFirst()
                .MoveLast()
            End With

            'Setting up the combo box
            With cboTransactionID
                .DataSource = TheLastTransactionIDBindingSource
                .DisplayMember = "TransactionID"
                .DataBindings.Add("text", TheLastTransactionIDBindingSource, "TransactionID", False, DataSourceUpdateMode.Never)
            End With

            'Binding the last control
            txtCreatedTransactionID.DataBindings.Add("text", TheLastTransactionIDBindingSource, "CreatedTransactionID")

            'Beginning process to add a record
            intNumberOfRecords = CInt(txtCreatedTransactionID.Text)
            intNumberOfRecords = intNumberOfRecords + 1

            txtCreatedTransactionID.Text = CStr(intNumberOfRecords)
            Logon.mintCreatedTransactionID = CInt(intNumberOfRecords)

            'Saving the record
            TheLastTransactionIDBindingSource.EndEdit()
            TheLastTransactionIDDataTier.UpdateLastTransactionIDDB(TheLastTransactionIDDataSet)

            'closes the form
            Me.Close()

        Catch ex As Exception

            'Message to user if there is a problem
            MessageBox.Show(ex.Message, "Please Correct", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub SetComboBoxBinding()

        With cboTransactionID
            If (addingBoolean Or editingBoolean) Then
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.OnValidation
                .DropDownStyle = ComboBoxStyle.Simple
            Else
                .DataBindings!text.DataSourceUpdateMode = DataSourceUpdateMode.Never
                .DropDownStyle = ComboBoxStyle.DropDownList
            End If
        End With

    End Sub

End Class