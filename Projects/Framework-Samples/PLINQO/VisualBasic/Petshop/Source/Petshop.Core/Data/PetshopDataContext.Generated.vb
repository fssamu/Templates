﻿
'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO Not MODIfY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Imports System

Namespace PetShop.Core.Data
    ''' <summary>
    ''' The DataContext class for the Petshop database.
    ''' </summary>
    public Partial Class PetshopDataContext 
        Inherits System.Data.Linq.DataContext
        Implements System.Data.Services.IUpdatable

        Private Shared ReadOnly mappingCache As System.Data.Linq.Mapping.MappingSource = New System.Data.Linq.Mapping.AttributeMappingSource()

        #Region "ConnectionString"
        Private Const CONNECTION_NAME As String = "PetshopConnectionString"
        Private Shared _connectionString As String
        Private Shared _connectionLock As New Object()
        
        ''' <summary>The application connection string read from web.config or app.config</summary>
        ''' <example>
        ''' Add the following key to the "connectionStrings" section of your config:
        ''' <code><![CDATA[
        ''' <configuration>
        '''     <connectionStrings>
        '''         <add name="PetshopConnectionString" 
        '''             connectionString="Data Source=(local);Initial Catalog=DATABASE;Integrated Security=True"
        '''             providerName="System.Data.SqlClient" />
        '''     </connectionStrings>
        ''' </configuration>
        ''' ]]></code>
        ''' </example>
        Public Shared ReadOnly Property ConnectionString() As String
        
            Get
                If _connectionString Is Nothing Then
                    SyncLock _connectionLock
                    If _connectionString Is Nothing Then
                        _connectionString = GetDefaultConnectionString()
                    End If
                    End SyncLock
                End If
                Return _connectionString
            End Get
        End Property
        
        Private Shared Function GetDefaultConnectionString() As String
            Dim settings As System.Configuration.ConnectionStringSettings = System.Configuration.ConfigurationManager.ConnectionStrings(CONNECTION_NAME)
            If settings Is Nothing Then
                Dim message As String = String.Format("Could not find the connection string '{0}' in the configuration file.  " + "Please add an entry to connectionStrings section named '{0}'.", CONNECTION_NAME)
                Throw New System.Configuration.ConfigurationErrorsException(message)
            End If
            Return settings.ConnectionString
        End Function
        #End Region

        #Region "Constructors"

        ''' <summary>
        ''' Initializes a new instance of the <see cref="PetshopDataContext"/> class.
        ''' </summary>
        <System.Diagnostics.DebuggerNonUserCode> _
        public Sub New()
            MyBase.New(ConnectionString, mappingCache)
            OnCreated()
        End Sub

        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="PetshopDataContext"/> class.
        ''' </summary>
        ''' <param name="connection">The connection string.</param>
        <System.Diagnostics.DebuggerNonUserCode> _
        public Sub New(ByVal connection As String)
            MyBase.New(connection, mappingCache)
            OnCreated()
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="PetshopDataContext"/> class.
        ''' </summary>
        ''' <param name="connection">The database connection.</param>
        <System.Diagnostics.DebuggerNonUserCode> _
        public Sub New(ByVal connection As System.Data.IDbConnection)
            MyBase.New(connection, mappingCache)
            OnCreated()
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="PetshopDataContext"/> class.
        ''' </summary>
        ''' <param name="connection">The connection string.</param>
        ''' <param name="mappingSource">The mapping source.</param>
        <System.Diagnostics.DebuggerNonUserCode> _
        public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
            MyBase.New(connection, mappingSource)
            OnCreated()
        End Sub
        
        ''' <summary>
        ''' Initializes a new instance of the <see cref="PetshopDataContext"/> class.
        ''' </summary>
        ''' <param name="connection">The database connection.</param>
        ''' <param name="mappingSource">The mapping source.</param>
        <System.Diagnostics.DebuggerNonUserCode> _
        public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
            MyBase.New(connection, mappingSource)
            OnCreated()
        End Sub
        #End Region
        
        #Region "Tables"
        ''' <summary>Represents the dbo.Account table in the underlying database.</summary>
        public ReadOnly Property Account As System.Data.Linq.Table(Of PetShop.Core.Data.Account)
            Get
                Return GetTable(Of PetShop.Core.Data.Account)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Cart table in the underlying database.</summary>
        public ReadOnly Property Cart As System.Data.Linq.Table(Of PetShop.Core.Data.Cart)
            Get
                Return GetTable(Of PetShop.Core.Data.Cart)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Category table in the underlying database.</summary>
        public ReadOnly Property Category As System.Data.Linq.Table(Of PetShop.Core.Data.Category)
            Get
                Return GetTable(Of PetShop.Core.Data.Category)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Inventory table in the underlying database.</summary>
        public ReadOnly Property Inventory As System.Data.Linq.Table(Of PetShop.Core.Data.Inventory)
            Get
                Return GetTable(Of PetShop.Core.Data.Inventory)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Item table in the underlying database.</summary>
        public ReadOnly Property Item As System.Data.Linq.Table(Of PetShop.Core.Data.Item)
            Get
                Return GetTable(Of PetShop.Core.Data.Item)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.LineItem table in the underlying database.</summary>
        public ReadOnly Property LineItem As System.Data.Linq.Table(Of PetShop.Core.Data.LineItem)
            Get
                Return GetTable(Of PetShop.Core.Data.LineItem)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Orders table in the underlying database.</summary>
        public ReadOnly Property Orders As System.Data.Linq.Table(Of PetShop.Core.Data.Orders)
            Get
                Return GetTable(Of PetShop.Core.Data.Orders)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.OrderStatus table in the underlying database.</summary>
        public ReadOnly Property OrderStatus As System.Data.Linq.Table(Of PetShop.Core.Data.OrderStatus)
            Get
                Return GetTable(Of PetShop.Core.Data.OrderStatus)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Product table in the underlying database.</summary>
        public ReadOnly Property Product As System.Data.Linq.Table(Of PetShop.Core.Data.Product)
            Get
                Return GetTable(Of PetShop.Core.Data.Product)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Profiles table in the underlying database.</summary>
        public ReadOnly Property Profile As System.Data.Linq.Table(Of PetShop.Core.Data.Profile)
            Get
                Return GetTable(Of PetShop.Core.Data.Profile)()
            End Get
        End Property
        
        ''' <summary>Represents the dbo.Supplier table in the underlying database.</summary>
        public ReadOnly Property Supplier As System.Data.Linq.Table(Of PetShop.Core.Data.Supplier)
            Get
                Return GetTable(Of PetShop.Core.Data.Supplier)()
            End Get
        End Property
        
        #End Region

        #region "Functions"
        #End Region

        #Region "Extensibility Method Definitions"
        ''' <summary>Called after this instance is created.</summary>
        Partial Private Sub OnCreated()
        End Sub
        ''' <summary>Called before a Account is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertAccount(ByVal instance As PetShop.Core.Data.Account)
        End Sub
        ''' <summary>Called before a Account is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateAccount(ByVal instance As PetShop.Core.Data.Account)
        End Sub
        ''' <summary>Called before a Account is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteAccount(ByVal instance As PetShop.Core.Data.Account)
        End Sub
        ''' <summary>Called before a Cart is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertCart(ByVal instance As PetShop.Core.Data.Cart)
        End Sub
        ''' <summary>Called before a Cart is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateCart(ByVal instance As PetShop.Core.Data.Cart)
        End Sub
        ''' <summary>Called before a Cart is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteCart(ByVal instance As PetShop.Core.Data.Cart)
        End Sub
        ''' <summary>Called before a Category is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertCategory(ByVal instance As PetShop.Core.Data.Category)
        End Sub
        ''' <summary>Called before a Category is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateCategory(ByVal instance As PetShop.Core.Data.Category)
        End Sub
        ''' <summary>Called before a Category is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteCategory(ByVal instance As PetShop.Core.Data.Category)
        End Sub
        ''' <summary>Called before a Inventory is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertInventory(ByVal instance As PetShop.Core.Data.Inventory)
        End Sub
        ''' <summary>Called before a Inventory is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateInventory(ByVal instance As PetShop.Core.Data.Inventory)
        End Sub
        ''' <summary>Called before a Inventory is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteInventory(ByVal instance As PetShop.Core.Data.Inventory)
        End Sub
        ''' <summary>Called before a Item is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertItem(ByVal instance As PetShop.Core.Data.Item)
        End Sub
        ''' <summary>Called before a Item is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateItem(ByVal instance As PetShop.Core.Data.Item)
        End Sub
        ''' <summary>Called before a Item is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteItem(ByVal instance As PetShop.Core.Data.Item)
        End Sub
        ''' <summary>Called before a LineItem is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertLineItem(ByVal instance As PetShop.Core.Data.LineItem)
        End Sub
        ''' <summary>Called before a LineItem is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateLineItem(ByVal instance As PetShop.Core.Data.LineItem)
        End Sub
        ''' <summary>Called before a LineItem is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteLineItem(ByVal instance As PetShop.Core.Data.LineItem)
        End Sub
        ''' <summary>Called before a Orders is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertOrders(ByVal instance As PetShop.Core.Data.Orders)
        End Sub
        ''' <summary>Called before a Orders is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateOrders(ByVal instance As PetShop.Core.Data.Orders)
        End Sub
        ''' <summary>Called before a Orders is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteOrders(ByVal instance As PetShop.Core.Data.Orders)
        End Sub
        ''' <summary>Called before a OrderStatus is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertOrderStatus(ByVal instance As PetShop.Core.Data.OrderStatus)
        End Sub
        ''' <summary>Called before a OrderStatus is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateOrderStatus(ByVal instance As PetShop.Core.Data.OrderStatus)
        End Sub
        ''' <summary>Called before a OrderStatus is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteOrderStatus(ByVal instance As PetShop.Core.Data.OrderStatus)
        End Sub
        ''' <summary>Called before a Product is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertProduct(ByVal instance As PetShop.Core.Data.Product)
        End Sub
        ''' <summary>Called before a Product is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateProduct(ByVal instance As PetShop.Core.Data.Product)
        End Sub
        ''' <summary>Called before a Product is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteProduct(ByVal instance As PetShop.Core.Data.Product)
        End Sub
        ''' <summary>Called before a Profile is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertProfile(ByVal instance As PetShop.Core.Data.Profile)
        End Sub
        ''' <summary>Called before a Profile is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateProfile(ByVal instance As PetShop.Core.Data.Profile)
        End Sub
        ''' <summary>Called before a Profile is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteProfile(ByVal instance As PetShop.Core.Data.Profile)
        End Sub
        ''' <summary>Called before a Supplier is inserted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub InsertSupplier(ByVal instance As PetShop.Core.Data.Supplier)
        End Sub
        ''' <summary>Called before a Supplier is updated.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub UpdateSupplier(ByVal instance As PetShop.Core.Data.Supplier)
        End Sub
        ''' <summary>Called before a Supplier is deleted.</summary>
        ''' <param name="instance">The instance.</param>
        Partial Private Sub DeleteSupplier(ByVal instance As PetShop.Core.Data.Supplier)
        End Sub
        #End Region

        #Region "IUpdatable Members"
        ''' <summary>
        ''' Adds the specified value to the collection.
        ''' </summary>
        ''' <param name="targetResource">Target object that defines the property.</param>
        ''' <param name="propertyName">The name of the collection property to which the resource should be added..</param>
        ''' <param name="resourceToBeAdded">The opaque object representing the resource to be added.</param>
        Private Sub AddReferenceToCollection(ByVal targetResource As Object, ByVal propertyName As String, ByVal resourceToBeAdded As Object) Implements System.Data.Services.IUpdatable.AddReferenceToCollection
            Dim t = targetResource.[GetType]()

            Dim collectionProperty = GetPropertyInfoForType(t, propertyName, False)
            Dim collection = TryCast(collectionProperty.GetValue(targetResource, Nothing), System.Collections.IList)
            If collection Is Nothing Then
                Exit Sub
            End If

            collection.Add(resourceToBeAdded)
        End Sub

        ''' <summary>
        ''' Cancels a change to the data.
        ''' </summary>
        Private Sub ClearChanges() Implements System.Data.Services.IUpdatable.ClearChanges
            Dim mi = [GetType]().GetMethod("ClearCache", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.InvokeMethod)

            If mi IsNot Nothing Then
                mi.Invoke(Me, Nothing)
            End If
        End Sub

        ''' <summary>
        ''' Creates the resource of the specified type and that belongs to the specified container.
        ''' </summary>
        ''' <param name="containerName">The name of the entity set to which the resource belongs.</param>
        ''' <param name="fullTypeName">The full namespace-qualified type name of the resource.</param>
        ''' <returns>
        ''' The object representing a resource of specified type and belonging to the specified container.
        ''' </returns>
        Private Function CreateResource(ByVal containerName As String, ByVal fullTypeName As String) As Object Implements System.Data.Services.IUpdatable.CreateResource
            Dim t = Type.[GetType](fullTypeName)
            Dim table = GetTableForType(t)

            Dim value As Object = Construct(t)
            table.InsertOnSubmit(value)

            Return (value)
        End Function

        ''' <summary>
        ''' Deletes the specified resource.
        ''' </summary>
        ''' <param name="targetResource">The resource to be deleted.</param>
        Private Sub DeleteResource(ByVal targetResource As Object) Implements System.Data.Services.IUpdatable.DeleteResource
            Dim t = targetResource.[GetType]()
            Dim table = GetTableForType(t)
            table.DeleteOnSubmit(targetResource)
        End Sub

        ''' <summary>
        ''' Gets the resource of the specified type identified by a query and type name.
        ''' </summary>
        ''' <param name="query">Language integratee query(LINQ) pointing to a particular resource.</param>
        ''' <param name="fullTypeName">The fully qualified type name of resource.</param>
        ''' <returns>
        ''' An opaque object representing a resource of the specified type, referenced by the specified query.
        ''' </returns>
        Private Function GetResource(ByVal query As System.Linq.IQueryable, ByVal fullTypeName As String) As Object Implements System.Data.Services.IUpdatable.GetResource
            Dim result As Object = Nothing

            For Each item As Object In query
                If result IsNot Nothing Then
                    Throw New System.Data.Services.DataServiceException("A single resource is expected")
                End If
                result = item
            Next

            If result Is Nothing Then
                Throw New System.Data.Services.DataServiceException(404, "Resource not found")
            End If

            If fullTypeName IsNot Nothing AndAlso result.[GetType]().FullName <> fullTypeName Then
                Throw New System.Data.Services.DataServiceException("Resource type mismatch")
            End If

            Return result
        End Function

        ''' <summary>
        ''' Gets the value of the specified property on the target object.
        ''' </summary>
        ''' <param name="targetResource">An opaque object that represents a resource.</param>
        ''' <param name="propertyName">The name of the property whose value needs to be retrieved.</param>
        ''' <returns></returns>
        Private Function GetValue(ByVal targetResource As Object, ByVal propertyName As String) As Object Implements System.Data.Services.IUpdatable.GetValue
            Dim t = targetResource.[GetType]()
            Dim pi = GetPropertyInfoForType(t, propertyName, False)

            Dim value As Object

            Try
                value = pi.GetValue(targetResource, Nothing)
            Catch ex As Exception
                Throw New System.Data.Services.DataServiceException(String.Format("Failed getting property {0} value", propertyName), ex)
            End Try
            Return value
        End Function

        ''' <summary>
        ''' Removes the specified value from the collection.
        ''' </summary>
        ''' <param name="targetResource">The target object that defines the property.</param>
        ''' <param name="propertyName">The name of the property whose value needs to be updated.</param>
        ''' <param name="resourceToBeRemoved">The property value that needs to be removed.</param>
        Private Sub RemoveReferenceFromCollection(ByVal targetResource As Object, ByVal propertyName As String, ByVal resourceToBeRemoved As Object) Implements System.Data.Services.IUpdatable.RemoveReferenceFromCollection
            Dim t = targetResource.[GetType]()

            Dim collectionProperty = GetPropertyInfoForType(t, propertyName, False)
            Dim collection = TryCast(collectionProperty.GetValue(targetResource, Nothing), System.Collections.IList)
            If collection Is Nothing Then
                Exit Sub
            End If
            ' throw error
            collection.Remove(resourceToBeRemoved)
        End Sub

        ''' <summary>
        ''' Returns the instance of the resource represented by the specified resource object.
        ''' </summary>
        ''' <param name="resource">The object representing the resource whose instance needs to be retrieved.</param>
        ''' <returns>
        ''' Returns the instance of the resource represented by the specified resource object.
        ''' </returns>
        Private Function ResolveResource(ByVal resource As Object) As Object Implements System.Data.Services.IUpdatable.ResolveResource
            Return resource
        End Function

        ''' <summary>
        ''' Saves all the changes that have been made by using the <see cref="T:System.Data.Services.IUpdatable"/> APIs.
        ''' </summary>
        Private Sub SaveChanges() Implements System.Data.Services.IUpdatable.SaveChanges
            Try
                SubmitChanges()
            Catch ex As Exception
                Throw New System.Data.Services.DataServiceException("Error Saving Context. " & ex.GetBaseException().Message, ex)
            End Try
        End Sub

        ''' <summary>
        ''' Sets the value of the specified reference property on the target object.
        ''' </summary>
        ''' <param name="targetResource">The target object that defines the property.</param>
        ''' <param name="propertyName">The name of the property whose value needs to be updated.</param>
        ''' <param name="propertyValue">The property value to be updated.</param>
        Private Sub SetReference(ByVal targetResource As Object, ByVal propertyName As String, ByVal propertyValue As Object) Implements System.Data.Services.IUpdatable.SetReference
            DirectCast(Me, System.Data.Services.IUpdatable).SetValue(targetResource, propertyName, propertyValue)
        End Sub

        ''' <summary>
        ''' Sets the value of the property with the specified name on the target resource to the specified property value.
        ''' </summary>
        ''' <param name="targetResource">The target object that defines the property.</param>
        ''' <param name="propertyName">The name of the property whose value needs to be updated.</param>
        ''' <param name="propertyValue">The property value for update.</param>
        Private Sub SetValue(ByVal targetResource As Object, ByVal propertyName As String, ByVal propertyValue As Object) Implements System.Data.Services.IUpdatable.SetValue
            Dim t = targetResource.[GetType]()
            Dim pi = GetPropertyInfoForType(t, propertyName, True)

            Try
                pi.SetValue(targetResource, propertyValue, Nothing)
            Catch ex As Exception
                Throw New System.Data.Services.DataServiceException(String.Format("Error setting property {0} to {1}", propertyName, propertyValue), ex)
            End Try
        End Sub

        ''' <summary>
        ''' Updates the resource identified by the parameter <paramref name="resource"/>.
        ''' </summary>
        ''' <param name="resource">The resource to be updated.</param>
        ''' <returns></returns>
        Private Function ResetResource(ByVal resource As Object) As Object Implements System.Data.Services.IUpdatable.ResetResource
            Dim t = resource.[GetType]()
            Dim table = GetTableForType(t)
            Return table.GetOriginalEntityState(resource)
        End Function

        Private Function GetPropertyInfoForType(ByVal t As Type, ByVal propertyName As String, ByVal setter As Boolean) As System.Reflection.PropertyInfo
            Dim pi As System.Reflection.PropertyInfo

            Try
                Dim flags As System.Reflection.BindingFlags = System.Reflection.BindingFlags.[Public] Or System.Reflection.BindingFlags.Instance
                flags = flags Or If(setter, System.Reflection.BindingFlags.SetProperty, System.Reflection.BindingFlags.GetProperty)

                pi = t.GetProperty(propertyName, flags)

                If pi Is Nothing Then
                    Throw New System.Data.Services.DataServiceException(String.Format("Failed to find property {0} on type {1}", propertyName, t.Name))
                End If
            Catch exception As Exception
                Throw New System.Data.Services.DataServiceException(String.Format("Error finding property {0}", propertyName), exception)
            End Try

            Return (pi)
        End Function

        Private Function GetTableForType(ByVal t As Type) As System.Data.Linq.ITable
            Dim table = GetTable(t)
            If table Is Nothing Then
                Throw New System.Data.Services.DataServiceException(String.Format("No table found for type {0}", t.Name))
            End If

            Return (table)
        End Function

        Private Shared Function Construct(ByVal t As Type) As Object
            Dim ci = t.GetConstructor(Type.EmptyTypes)

            If ci Is Nothing Then
                Throw New System.Data.Services.DataServiceException(String.Format("No default ctor found for type {0}", t.Name))
            End If

            Return (ci.Invoke(Nothing))
        End Function
        
        #End Region

        #Region "RuleManager"
        Private ReadOnly _ruleManager As New CodeSmith.Data.Rules.RuleManager()
        
        ''' <summary>
        ''' Gets the current <see cref="CodeSmith.Data.Rules.RuleManager"/> for the <see cref="System.Data.Linq.DataContext"/>.
        ''' </summary>
        Public ReadOnly Property RuleManager() As CodeSmith.Data.Rules.RuleManager
            Get
                Return _ruleManager
            End Get
        End Property
        
        ''' <summary>
        ''' Sends changes made to retrieved objects to the underlying database.
        ''' </summary>
        ''' <param name="failureMode">How concurrency conflicts should be reported.</param>
        Public Overloads Overrides Sub SubmitChanges(ByVal failureMode As System.Data.Linq.ConflictMode)
            Dim isValid As Boolean = RuleManager.Run(Me)
            
            If Not isValid Then
                Throw New CodeSmith.Data.Rules.BrokenRuleException(RuleManager.BrokenRules)
            End If
            
            PopulateLastAudit()
            BeforeSubmitChanges()
            MyBase.SubmitChanges(failureMode)
        End Sub
        #End Region

        #Region "Auditing"
        ''' <summary>Called before the underlying DataContext.SubmitChanges is called.</summary>
        Private Partial Sub BeforeSubmitChanges()
        End Sub
        
        Private _auditingEnabled As Boolean = True
        
        ''' <summary>
        ''' Gets or sets a value indicating whether auditing is enabled.
        ''' </summary>
        ''' <value><c>true</c> if auditing is enabled; otherwise, <c>false</c>.</value>
        Public Property AuditingEnabled() As Boolean
            Get
                Return _auditingEnabled
            End Get
            Set(ByVal value As Boolean)
                _auditingEnabled = value
            End Set
        End Property
        
        Private _lastAudit As CodeSmith.Data.Audit.AuditLog
        
        ''' <summary>
        ''' Gets the last <see cref="CodeSmith.Data.Audit.AuditLog"/>.
        ''' </summary>
        ''' <value>The last <see cref="CodeSmith.Data.Audit.AuditLog"/>.</value>
        ''' <remarks>
        ''' <see cref="AuditingEnabled"/> must be <c>true</c> for <see cref="LastAudit"/> to be populated.
        ''' </remarks>
        Public ReadOnly Property LastAudit() As CodeSmith.Data.Audit.AuditLog
            Get
                Return _lastAudit
            End Get
        End Property
        
        ''' <summary>
        ''' Populates the <see cref="LastAudit"/> property with the <see cref="CodeSmith.Data.Audit.AuditLog"/>
        ''' of changes in this <see cref="System.Data.Linq.DataContext"/>.
        ''' </summary>
        ''' <remarks>
        ''' <see cref="AuditingEnabled"/> must be <c>true</c> for <see cref="LastAudit"/> to be populated.
        ''' </remarks>
        Public Sub PopulateLastAudit()
            If Not AuditingEnabled Then
                Exit Sub
            End If
            
            _lastAudit = CodeSmith.Data.Audit.AuditManager.CreateAuditLog(Me)
        End Sub
        #End Region

        ''' <summary>
        ''' Sends changes made to retrieved objects to the underlying database.
        ''' </summary>
        ''' <param name="refreshMode">Defines how to handle optimistic concurrency conflicts.</param>
        Public Overloads Sub SubmitChanges(ByVal refreshMode As System.Data.Linq.RefreshMode)
            Try
                SubmitChanges(System.Data.Linq.ConflictMode.ContinueOnConflict)
            Catch generatedExceptionName As System.Data.Linq.ChangeConflictException
                For Each occ In ChangeConflicts
                    occ.Resolve(refreshMode)
                Next

                SubmitChanges()
            End Try
        End Sub

    End Class
End Namespace

