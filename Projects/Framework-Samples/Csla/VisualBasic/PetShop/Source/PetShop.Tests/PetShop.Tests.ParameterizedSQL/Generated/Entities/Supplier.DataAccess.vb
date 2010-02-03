'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated Imports CSLA 3.8.X CodeSmith Templates.
'     Changes to Me file will be lost after each regeneration.
'     To extend the functionality of Me class, please modify the partial class 'Supplier.vb.
'
'     Template: EditableRoot.DataAccess.ParameterizedSQL.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data
Imports Csla.Validation

Public Partial Class Supplier
    <RunLocal()> _
    Protected Shadows Sub DataPortal_Create()
        ValidationRules.CheckRules()
    End Sub

    Private Shadows Sub DataPortal_Fetch(ByVal criteria As SupplierCriteria)
        Dim commandText As String = String.Format("SELECT [SuppId], [Name], [Status], [Addr1], [Addr2], [City], [State], [Zip], [Phone] FROM [dbo].[Supplier] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Supplier' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_Insert()
        Const commandText As String = "INSERT INTO [dbo].[Supplier] ([SuppId], [Name], [Status], [Addr1], [Addr2], [City], [State], [Zip], [Phone]) VALUES (@p_SuppId, @p_Name, @p_Status, @p_Addr1, @p_Addr2, @p_City, @p_State, @p_Zip, @p_Phone)"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_SuppId", SuppId)
				command.Parameters.AddWithValue("@p_Name", Name)
				command.Parameters.AddWithValue("@p_Status", Status)
				command.Parameters.AddWithValue("@p_Addr1", Addr1)
				command.Parameters.AddWithValue("@p_Addr2", Addr2)
				command.Parameters.AddWithValue("@p_City", City)
				command.Parameters.AddWithValue("@p_State", State)
				command.Parameters.AddWithValue("@p_Zip", Zip)
				command.Parameters.AddWithValue("@p_Phone", Phone)

                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then

                    End If
                End Using
            End Using
        End Using

        FieldManager.UpdateChildren(Me)
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_Update()
        Const commandText As String = "UPDATE [dbo].[Supplier]  SET [SuppId] = @p_SuppId, [Name] = @p_Name, [Status] = @p_Status, [Addr1] = @p_Addr1, [Addr2] = @p_Addr2, [City] = @p_City, [State] = @p_State, [Zip] = @p_Zip, [Phone] = @p_Phone WHERE [SuppId] = @p_SuppId"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_SuppId", SuppId)
				command.Parameters.AddWithValue("@p_Name", Name)
				command.Parameters.AddWithValue("@p_Status", Status)
				command.Parameters.AddWithValue("@p_Addr1", Addr1)
				command.Parameters.AddWithValue("@p_Addr2", Addr2)
				command.Parameters.AddWithValue("@p_City", City)
				command.Parameters.AddWithValue("@p_State", State)
				command.Parameters.AddWithValue("@p_Zip", Zip)
				command.Parameters.AddWithValue("@p_Phone", Phone)

                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    'RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    If reader.RecordsAffected = 0 Then
                        Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
            End Using
        End Using

        FieldManager.UpdateChildren(Me)
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_DeleteSelf()
        DataPortal_Delete(New SupplierCriteria(SuppId))
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Shadows Sub DataPortal_Delete(ByVal criteria As SupplierCriteria)
        Dim commandText As String = String.Format("DELETE FROM [dbo].[Supplier] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))

				'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
				Dim result As Integer = command.ExecuteNonQuery()
				If (result = 0) Then
					throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
				End If
            End Using
        End Using
    End Sub

    Private Sub Map(ByVal reader As SafeDataReader)
        Using(BypassPropertyChecks)
            LoadProperty(_suppIdProperty, reader.GetInt32("SuppId"))
            LoadProperty(_nameProperty, reader.GetString("Name"))
            LoadProperty(_statusProperty, reader.GetString("Status"))
            LoadProperty(_addr1Property, reader.GetString("Addr1"))
            LoadProperty(_addr2Property, reader.GetString("Addr2"))
            LoadProperty(_cityProperty, reader.GetString("City"))
            LoadProperty(_stateProperty, reader.GetString("State"))
            LoadProperty(_zipProperty, reader.GetString("Zip"))
            LoadProperty(_phoneProperty, reader.GetString("Phone"))
        End Using

        MarkOld()
    End Sub
End Class