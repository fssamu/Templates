﻿
'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO NOT MODIFY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Linq
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Linq.Dynamic

Namespace PetShop.Core.Data
    ''' <summary>
    ''' The query extension class for Cart.
    ''' </summary>
    Public Module CartExtensions
        ''' <summary>
        ''' Gets an instance by the primary key.
        ''' </summary>
        <System.Runtime.CompilerServices.Extension> _
        Public Function GetByKey(ByVal queryable As IQueryable(Of PetShop.Core.Data.Cart), ByVal cartID As Integer) As PetShop.Core.Data.Cart

            Dim entity As System.Data.Linq.Table(Of PetShop.Core.Data.Cart) = CType(queryable, Table(Of PetShop.Core.Data.Cart))
            If (entity IsNot Nothing AndAlso entity.Context.LoadOptions Is Nothing) Then
                Return Query.GetByKey.Invoke(DirectCast(entity.Context, PetShop.Core.Data.PetshopDataContext), cartID)
            End If

            Return queryable.FirstOrDefault(Function(c)c.CartID = cartID)
        End Function
        
        ''' <summary>
        ''' Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        ''' </summary>
        ''' <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        ''' <returns>The number of rows deleted from the database.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function Delete(ByVal table As System.Data.Linq.Table(Of PetShop.Core.Data.Cart), ByVal cartID As Integer) As Integer
            Return table.Delete(Function(c)c.CartID = cartID)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="cartID">CartID to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByCartID(queryable As IQueryable(Of PetShop.Core.Data.Cart), cartID As Integer) As IQueryable(Of PetShop.Core.Data.Cart)
            Return queryable.Where(Function(c)c.CartID = cartID)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="cartID">CartID to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByCartID(queryable As IQueryable(Of PetShop.Core.Data.Cart), cartID As Integer, ParamArray additionalValues As Integer()) As IQueryable(Of PetShop.Core.Data.Cart)
            Dim CartIDList = New List(Of Integer)()
            CartIDList.Add(cartID)
        
            If additionalValues IsNot Nothing Then
                CartIDList.AddRange(additionalValues)
            End If
        
            If CartIDList.Count = 1 Then
                Return queryable.ByCartID(CartIDList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Cart, Boolean)("CartID", CartIDList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="uniqueID">UniqueID to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByUniqueID(queryable As IQueryable(Of PetShop.Core.Data.Cart), uniqueID As Integer) As IQueryable(Of PetShop.Core.Data.Cart)
            Return queryable.Where(Function(c)c.UniqueID = uniqueID)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="uniqueID">UniqueID to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByUniqueID(queryable As IQueryable(Of PetShop.Core.Data.Cart), uniqueID As Integer, ParamArray additionalValues As Integer()) As IQueryable(Of PetShop.Core.Data.Cart)
            Dim UniqueIDList = New List(Of Integer)()
            UniqueIDList.Add(uniqueID)
        
            If additionalValues IsNot Nothing Then
                UniqueIDList.AddRange(additionalValues)
            End If
        
            If UniqueIDList.Count = 1 Then
                Return queryable.ByUniqueID(UniqueIDList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Cart, Boolean)("UniqueID", UniqueIDList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="itemId">ItemId to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByItemId(queryable As IQueryable(Of PetShop.Core.Data.Cart), itemId As String) As IQueryable(Of PetShop.Core.Data.Cart)
            Return queryable.Where(Function(c)c.ItemId = itemId)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="itemId">ItemId to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByItemId(queryable As IQueryable(Of PetShop.Core.Data.Cart), itemId As String, ParamArray additionalValues As String()) As IQueryable(Of PetShop.Core.Data.Cart)
            Dim ItemIdList = New List(Of String)()
            ItemIdList.Add(itemId)
        
            If additionalValues IsNot Nothing Then
                ItemIdList.AddRange(additionalValues)
            End If
        
            If ItemIdList.Count = 1 Then
                Return queryable.ByItemId(ItemIdList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Cart, Boolean)("ItemId", ItemIdList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="name">Name to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByName(queryable As IQueryable(Of PetShop.Core.Data.Cart), name As String) As IQueryable(Of PetShop.Core.Data.Cart)
            Return queryable.Where(Function(c)c.Name = name)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="name">Name to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByName(queryable As IQueryable(Of PetShop.Core.Data.Cart), name As String, ParamArray additionalValues As String()) As IQueryable(Of PetShop.Core.Data.Cart)
            Dim NameList = New List(Of String)()
            NameList.Add(name)
        
            If additionalValues IsNot Nothing Then
                NameList.AddRange(additionalValues)
            End If
        
            If NameList.Count = 1 Then
                Return queryable.ByName(NameList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Cart, Boolean)("Name", NameList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="type">Type to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByType(queryable As IQueryable(Of PetShop.Core.Data.Cart), type As String) As IQueryable(Of PetShop.Core.Data.Cart)
            Return queryable.Where(Function(c)c.Type = type)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="type">Type to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByType(queryable As IQueryable(Of PetShop.Core.Data.Cart), type As String, ParamArray additionalValues As String()) As IQueryable(Of PetShop.Core.Data.Cart)
            Dim TypeList = New List(Of String)()
            TypeList.Add(type)
        
            If additionalValues IsNot Nothing Then
                TypeList.AddRange(additionalValues)
            End If
        
            If TypeList.Count = 1 Then
                Return queryable.ByType(TypeList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Cart, Boolean)("Type", TypeList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="price">Price to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByPrice(queryable As IQueryable(Of PetShop.Core.Data.Cart), price As Decimal) As IQueryable(Of PetShop.Core.Data.Cart)
            Return queryable.Where(Function(c)c.Price = price)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="price">Price to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByPrice(queryable As IQueryable(Of PetShop.Core.Data.Cart), price As Decimal, ParamArray additionalValues As Decimal()) As IQueryable(Of PetShop.Core.Data.Cart)
            Dim PriceList = New List(Of Decimal)()
            PriceList.Add(price)
        
            If additionalValues IsNot Nothing Then
                PriceList.AddRange(additionalValues)
            End If
        
            If PriceList.Count = 1 Then
                Return queryable.ByPrice(PriceList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Cart, Boolean)("Price", PriceList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="categoryId">CategoryId to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByCategoryId(queryable As IQueryable(Of PetShop.Core.Data.Cart), categoryId As String) As IQueryable(Of PetShop.Core.Data.Cart)
            Return queryable.Where(Function(c)c.CategoryId = categoryId)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="categoryId">CategoryId to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByCategoryId(queryable As IQueryable(Of PetShop.Core.Data.Cart), categoryId As String, ParamArray additionalValues As String()) As IQueryable(Of PetShop.Core.Data.Cart)
            Dim CategoryIdList = New List(Of String)()
            CategoryIdList.Add(categoryId)
        
            If additionalValues IsNot Nothing Then
                CategoryIdList.AddRange(additionalValues)
            End If
        
            If CategoryIdList.Count = 1 Then
                Return queryable.ByCategoryId(CategoryIdList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Cart, Boolean)("CategoryId", CategoryIdList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="productId">ProductId to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByProductId(queryable As IQueryable(Of PetShop.Core.Data.Cart), productId As String) As IQueryable(Of PetShop.Core.Data.Cart)
            Return queryable.Where(Function(c)c.ProductId = productId)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="productId">ProductId to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByProductId(queryable As IQueryable(Of PetShop.Core.Data.Cart), productId As String, ParamArray additionalValues As String()) As IQueryable(Of PetShop.Core.Data.Cart)
            Dim ProductIdList = New List(Of String)()
            ProductIdList.Add(productId)
        
            If additionalValues IsNot Nothing Then
                ProductIdList.AddRange(additionalValues)
            End If
        
            If ProductIdList.Count = 1 Then
                Return queryable.ByProductId(ProductIdList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Cart, Boolean)("ProductId", ProductIdList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="isShoppingCart">IsShoppingCart to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByIsShoppingCart(queryable As IQueryable(Of PetShop.Core.Data.Cart), isShoppingCart As Boolean) As IQueryable(Of PetShop.Core.Data.Cart)
            Return queryable.Where(Function(c)c.IsShoppingCart = isShoppingCart)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="isShoppingCart">IsShoppingCart to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByIsShoppingCart(queryable As IQueryable(Of PetShop.Core.Data.Cart), isShoppingCart As Boolean, ParamArray additionalValues As Boolean()) As IQueryable(Of PetShop.Core.Data.Cart)
            Dim IsShoppingCartList = New List(Of Boolean)()
            IsShoppingCartList.Add(isShoppingCart)
        
            If additionalValues IsNot Nothing Then
                IsShoppingCartList.AddRange(additionalValues)
            End If
        
            If IsShoppingCartList.Count = 1 Then
                Return queryable.ByIsShoppingCart(IsShoppingCartList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Cart, Boolean)("IsShoppingCart", IsShoppingCartList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="quantity">Quantity to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByQuantity(queryable As IQueryable(Of PetShop.Core.Data.Cart), quantity As Integer) As IQueryable(Of PetShop.Core.Data.Cart)
            Return queryable.Where(Function(c)c.Quantity = quantity)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Cart"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="quantity">Quantity to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByQuantity(queryable As IQueryable(Of PetShop.Core.Data.Cart), quantity As Integer, ParamArray additionalValues As Integer()) As IQueryable(Of PetShop.Core.Data.Cart)
            Dim QuantityList = New List(Of Integer)()
            QuantityList.Add(quantity)
        
            If additionalValues IsNot Nothing Then
                QuantityList.AddRange(additionalValues)
            End If
        
            If QuantityList.Count = 1 Then
                Return queryable.ByQuantity(QuantityList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Cart, Boolean)("Quantity", QuantityList)
            Return queryable.Where(expression)
        End Function

        'Insert User Defined Extensions here.
        'Anything outside of this Region will be lost at regeneration
        #Region "User Extensions"


        #End Region

        #Region "Query"
        ''' <summary>
        ''' A private class for lazy loading static compiled queries.
        ''' </summary>
        Private Partial Class Query


            Friend Shared ReadOnly GetByKey As Func(Of PetshopDataContext, Integer, PetShop.Core.Data.Cart) = _
                CompiledQuery.Compile( _
                    Function(db As PetshopDataContext , ByVal cartID As Integer) _
                        db.Cart.FirstOrDefault(Function(c)c.CartID = cartID))

            ' Add your compiled queries here.
            'Anything outside of this Region will be lost at regeneration
            #Region "User Queries"

            #End Region

        End Class
        #End Region
    End Module
End Namespace

