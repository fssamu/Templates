﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Item.vb.
'
'     Template: SwitchableObject.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Validation
Imports Csla.Data
Imports System.Data.SqlClient

Namespace PetShop.Tests.ParameterizedSQL
    <Serializable()> _
    Public Partial Class Item 
        Inherits BusinessBase(Of Item)
    
#Region "Contructor(s)"
    
        Private Sub New()
            ' require use of factory method 
        End Sub
    
        Friend Sub New(ByVal itemId As System.String)
            Using(BypassPropertyChecks)
                _itemId = itemId
            End Using
        End Sub
    
        Friend Sub New(Byval reader As SafeDataReader)
            Map(reader)
            MarkAsChild()   
        End Sub

#End Region    
    
#Region "Business Rules"
    
        Protected Overrides Sub AddBusinessRules()
    
            If AddBusinessValidationRules() Then Exit Sub
    
            ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _itemIdProperty)
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_itemIdProperty, 10))
            ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _productIdProperty)
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_productIdProperty, 10))
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_statusProperty, 2))
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_nameProperty, 80))
            ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_imageProperty, 80))
        End Sub
    
#End Region

#Region "Properties"
    
        Private Shared ReadOnly _itemIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Item) p.ItemId, String.Empty)
        Private _itemId As System.String = _itemIdProperty.DefaultValue
        
		<System.ComponentModel.DataObjectField(true, false)> _
        Public Property ItemId() As System.String
            Get 
                Return GetProperty(_itemIdProperty, _itemId) 
            End Get
            Set (value As System.String)
                SetProperty(_itemIdProperty, _itemId, value)
            End Set
        End Property

        Private Shared ReadOnly _originalItemIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Item) p.OriginalItemId, String.Empty)
        Private _originalItemId As System.String = _originalItemIdProperty.DefaultValue
        ''' <summary>
        ''' Holds the original value for ItemId. This is used for non identity primary keys.
        ''' </summary>
        Friend Property OriginalItemId() As System.String
            Get 
                Return GetProperty(_originalItemIdProperty, _originalItemId) 
            End Get
            Set (value As System.String)
                SetProperty(_originalItemIdProperty, _originalItemId, value)
            End Set
        End Property

        Private Shared ReadOnly _productIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Item) p.ProductId, String.Empty)
        Private _productId As System.String = _productIdProperty.DefaultValue
        
        Public Property ProductId() As System.String
            Get 
                Return GetProperty(_productIdProperty, _productId) 
            End Get
            Set (value As System.String)
                SetProperty(_productIdProperty, _productId, value)
            End Set
        End Property

        Private Shared ReadOnly _listPriceProperty As PropertyInfo(Of System.Nullable(Of System.Decimal)) = RegisterProperty(Of System.Nullable(Of System.Decimal))(Function(p As Item) p.ListPrice, String.Empty, CType(Nothing, System.Nullable(Of System.Decimal)))
        Private _listPrice As System.Nullable(Of System.Decimal) = _listPriceProperty.DefaultValue
        
        Public Property ListPrice() As System.Nullable(Of System.Decimal)
            Get 
                Return GetProperty(_listPriceProperty, _listPrice) 
            End Get
            Set (value As System.Nullable(Of System.Decimal))
                SetProperty(_listPriceProperty, _listPrice, value)
            End Set
        End Property

        Private Shared ReadOnly _unitCostProperty As PropertyInfo(Of System.Nullable(Of System.Decimal)) = RegisterProperty(Of System.Nullable(Of System.Decimal))(Function(p As Item) p.UnitCost, String.Empty, CType(Nothing, System.Nullable(Of System.Decimal)))
        Private _unitCost As System.Nullable(Of System.Decimal) = _unitCostProperty.DefaultValue
        
        Public Property UnitCost() As System.Nullable(Of System.Decimal)
            Get 
                Return GetProperty(_unitCostProperty, _unitCost) 
            End Get
            Set (value As System.Nullable(Of System.Decimal))
                SetProperty(_unitCostProperty, _unitCost, value)
            End Set
        End Property

        Private Shared ReadOnly _supplierProperty As PropertyInfo(Of System.Nullable(Of System.Int32)) = RegisterProperty(Of System.Nullable(Of System.Int32))(Function(p As Item) p.Supplier, String.Empty, CType(Nothing, System.Nullable(Of System.Int32)))
        Private _supplier As System.Nullable(Of System.Int32) = _supplierProperty.DefaultValue
        
        Public Property Supplier() As System.Nullable(Of System.Int32)
            Get 
                Return GetProperty(_supplierProperty, _supplier) 
            End Get
            Set (value As System.Nullable(Of System.Int32))
                SetProperty(_supplierProperty, _supplier, value)
            End Set
        End Property

        Private Shared ReadOnly _statusProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Item) p.Status, String.Empty, vbNullString)
        Private _status As System.String = _statusProperty.DefaultValue
        
        Public Property Status() As System.String
            Get 
                Return GetProperty(_statusProperty, _status) 
            End Get
            Set (value As System.String)
                SetProperty(_statusProperty, _status, value)
            End Set
        End Property

        Private Shared ReadOnly _nameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Item) p.Name, String.Empty, vbNullString)
        Private _name As System.String = _nameProperty.DefaultValue
        
        Public Property Name() As System.String
            Get 
                Return GetProperty(_nameProperty, _name) 
            End Get
            Set (value As System.String)
                SetProperty(_nameProperty, _name, value)
            End Set
        End Property

        Private Shared ReadOnly _imageProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Item) p.Image, String.Empty, vbNullString)
        Private _image As System.String = _imageProperty.DefaultValue
        
        Public Property Image() As System.String
            Get 
                Return GetProperty(_imageProperty, _image) 
            End Get
            Set (value As System.String)
                SetProperty(_imageProperty, _image, value)
            End Set
        End Property

        'AssociatedManyToOne
        Private Shared ReadOnly _productMemberProperty As PropertyInfo(Of Product) = RegisterProperty(Of Product)(Function(p As Item) p.ProductMember, Csla.RelationshipTypes.Child)
        Public ReadOnly Property ProductMember() As Product
            Get
                If(False) Then
                    Return Nothing
                End If
    
                If Not(FieldManager.FieldExists(_productMemberProperty))
                    Dim criteria As New PetShop.Tests.ParameterizedSQL.ProductCriteria()
                    criteria.ProductId = ProductId

                    If (PetShop.Tests.ParameterizedSQL.Product.Exists(criteria)) Then
                        LoadProperty(_productMemberProperty, PetShop.Tests.ParameterizedSQL.Product.GetByProductId(ProductId))
                    End If
                End If
                
                Return GetProperty(_productMemberProperty) 
            End Get
        End Property 

        'AssociatedManyToOne
        Private Shared ReadOnly _supplierMemberProperty As PropertyInfo(Of Supplier) = RegisterProperty(Of Supplier)(Function(p As Item) p.SupplierMember, Csla.RelationshipTypes.Child)
        Public ReadOnly Property SupplierMember() As Supplier
            Get
                If(Not Supplier.HasValue)  Then
                    Return Nothing
                End If
    
                If Not(FieldManager.FieldExists(_supplierMemberProperty))
                    Dim criteria As New PetShop.Tests.ParameterizedSQL.SupplierCriteria()
                    If(Supplier.HasValue) Then criteria.SuppId = Supplier.Value

                    If (PetShop.Tests.ParameterizedSQL.Supplier.Exists(criteria)) Then
                        LoadProperty(_supplierMemberProperty, PetShop.Tests.ParameterizedSQL.Supplier.GetBySuppId(Supplier.Value))
                    End If
                End If
                
                Return GetProperty(_supplierMemberProperty) 
            End Get
        End Property 

#End Region
    
#Region "Synchronous Root Factory Methods"
    
        Public Shared Function NewItem() As Item 
            Return DataPortal.Create(Of Item)()
        End Function
    
        Public Shared Function GetByItemId(ByVal itemId As System.String) As Item
            Dim criteria As New ItemCriteria()
            criteria.ItemId = itemId
    
            Return DataPortal.Fetch(Of Item)(criteria)
        End Function
    
        Public Shared Function GetByProductIdItemIdListPriceName(ByVal productId As System.String, ByVal itemId As System.String, ByVal listPrice As System.Nullable(Of System.Decimal), ByVal name As System.String) As Item
            Dim criteria As New ItemCriteria()
            criteria.ProductId = productId
			criteria.ItemId = itemId
			criteria.ListPrice = listPrice.Value
			criteria.Name = name
    
            Return DataPortal.Fetch(Of Item)(criteria)
        End Function
    
        Public Shared Function GetByProductId(ByVal productId As System.String) As Item
            Dim criteria As New ItemCriteria()
            criteria.ProductId = productId
    
            Return DataPortal.Fetch(Of Item)(criteria)
        End Function
    
        Public Shared Function GetBySupplier(ByVal supplier As System.Nullable(Of System.Int32)) As Item
            Dim criteria As New ItemCriteria()
            criteria.Supplier = supplier.Value
    
            Return DataPortal.Fetch(Of Item)(criteria)
        End Function
    
        Public Shared Sub DeleteItem(ByVal itemId As System.String)
            DataPortal.Delete(New ItemCriteria (itemId))
        End Sub
    
#End Region
#Region "Synchronous Child Factory Methods"
    
        Friend Shared Function NewItemChild() As Item
            Return DataPortal.CreateChild(Of Item)()
        End Function
    
        Friend Shared Function GetByItemIdChild(ByVal itemId As System.String) As Item
            Dim criteria As New ItemCriteria()
            criteria.ItemId = itemId
    
            Return DataPortal.FetchChild(Of Item)(criteria)
        End Function
    
        Friend Shared Function GetByProductIdItemIdListPriceNameChild(ByVal productId As System.String, ByVal itemId As System.String, ByVal listPrice As System.Nullable(Of System.Decimal), ByVal name As System.String) As Item
            Dim criteria As New ItemCriteria()
            criteria.ProductId = productId
            criteria.ItemId = itemId
            criteria.ListPrice = listPrice
            criteria.Name = name
    
            Return DataPortal.FetchChild(Of Item)(criteria)
        End Function
    
        Friend Shared Function GetByProductIdChild(ByVal productId As System.String) As Item
            Dim criteria As New ItemCriteria()
            criteria.ProductId = productId
    
            Return DataPortal.FetchChild(Of Item)(criteria)
        End Function
    
        Friend Shared Function GetBySupplierChild(ByVal supplier As System.Nullable(Of System.Int32)) As Item
            Dim criteria As New ItemCriteria()
            criteria.Supplier = supplier
    
            Return DataPortal.FetchChild(Of Item)(criteria)
        End Function
    
#End Region
#Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As ItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnInserting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnInserted()
        End Sub
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnSelfDeleted()
        End Sub
        Partial Private Sub OnDeleting(ByVal criteria As ItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleted()
        End Sub
    
#End Region
    
#Region "ChildPortal partial methods"

        Partial Private Sub OnChildCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildCreated()
        End Sub
        Partial Private Sub OnChildFetching(ByVal criteria As ItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildFetched()
        End Sub
        Partial Private Sub OnChildInserting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildInserted()
        End Sub
        Partial Private Sub OnChildUpdating(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildUpdated()
        End Sub
        Partial Private Sub OnChildSelfDeleting(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnChildSelfDeleted()
        End Sub
    
#End Region

#Region "Exists Command"

        Public Shared Function Exists(ByVal criteria As ItemCriteria ) As Boolean
            Return PetShop.Tests.ParameterizedSQL.ExistsCommand.Execute(criteria)
        End Function

#End Region
    End Class
End Namespace