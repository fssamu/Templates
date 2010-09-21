﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1872, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Cart.cs'.
//
//     Template: ObjectFactory.DataAccess.StoredProcedures.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;
using Csla.Server;

using PetShop.Tests.ObjF.StoredProcedures;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures.DAL
{
    public partial class CartFactory : ObjectFactory
    {
        #region Create

        /// <summary>
        /// Creates new Cart with default values.
        /// </summary>
        /// <returns>new Cart.</returns>
        [RunLocal]
        public Cart Create()
        {
            var item = (Cart)Activator.CreateInstance(typeof(Cart), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            using (BypassPropertyChecks(item))
            {
                // Default values.
            }

            CheckRules(item);
            MarkNew(item);
            MarkAsChild(item);
            OnCreated();

            return item;
        }

        /// <summary>
        /// Creates new Cart with default values.
        /// </summary>
        /// <returns>new Cart.</returns>
        [RunLocal]
        private Cart Create(CartCriteria criteria)
        {
            var item = (Cart)Activator.CreateInstance(typeof(Cart), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            var resource = Fetch(criteria);
            using (BypassPropertyChecks(item))
            {
                item.ItemId = resource.ItemId;
                item.Name = resource.Name;
                item.Type = resource.Type;
                item.Price = resource.Price;
                item.CategoryId = resource.CategoryId;
                item.ProductId = resource.ProductId;
                item.IsShoppingCart = resource.IsShoppingCart;
                item.Quantity = resource.Quantity;
            }

            CheckRules(item);
            MarkNew(item);
            MarkAsChild(item);

            OnCreated();

            return item;
        }

        #endregion

        #region Fetch

        /// <summary>
        /// Fetch Cart.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public Cart Fetch(CartCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return null;

            Cart item;
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Cart_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                           item = Map(reader);
                        else
                            throw new Exception(string.Format("The record was not found in 'Cart' using the following criteria: {0}.", criteria));
                    }
                }
            }

            MarkOld(item);
            MarkAsChild(item);
            OnFetched();
            return item;
        }

        #endregion

        #region Insert

        private void DoInsert(ref Cart item, bool stopProccessingChildren)
        {
            // Don't update if the item isn't dirty.
            if (!item.IsDirty) return;

            bool cancel = false;
            OnInserting(ref cancel);
            if (cancel) return;

            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand("[dbo].[CSLA_Cart_Insert]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_CartId", item.CartId);
					command.Parameters["@p_CartId"].Direction = ParameterDirection.Output;
					command.Parameters.AddWithValue("@p_UniqueID", item.UniqueID);
					command.Parameters.AddWithValue("@p_ItemId", item.ItemId);
					command.Parameters.AddWithValue("@p_Name", item.Name);
					command.Parameters.AddWithValue("@p_Type", item.Type);
					command.Parameters.AddWithValue("@p_Price", item.Price);
					command.Parameters.AddWithValue("@p_CategoryId", item.CategoryId);
					command.Parameters.AddWithValue("@p_ProductId", item.ProductId);
					command.Parameters.AddWithValue("@p_IsShoppingCart", item.IsShoppingCart);
					command.Parameters.AddWithValue("@p_Quantity", item.Quantity);

                    command.ExecuteNonQuery();

                    item.CartId = (System.Int32)command.Parameters["@p_CartId"].Value;
                }
            }


            MarkOld(item);
            CheckRules(item);
            
            if(!stopProccessingChildren)
            {
            // Update Child Items.
                Update_Profile_ProfileMember_UniqueID(ref item);
            }

            OnInserted();
        }

        #endregion

        #region Update

        [Transactional(TransactionalTypes.TransactionScope)]
        public Cart Update(Cart item)
        {
            return Update(item, false);
        }

        public Cart Update(Cart item, bool stopProccessingChildren)
        {
            if(item.IsDeleted)
            {
                DoDelete(ref item);
                MarkNew(item);
            }
            else if(item.IsNew)
            {
                DoInsert(ref item, stopProccessingChildren);
            }
            else
            {
                DoUpdate(ref item, stopProccessingChildren);
            }

            return item;
        }

        private void DoUpdate(ref Cart item, bool stopProccessingChildren)
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            // Don't update if the item isn't dirty.
            if (item.IsDirty)
            {
                using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand("[dbo].[CSLA_Cart_Update]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_CartId", item.CartId);
					command.Parameters["@p_CartId"].Direction = ParameterDirection.Output;
					command.Parameters.AddWithValue("@p_UniqueID", item.UniqueID);
					command.Parameters.AddWithValue("@p_ItemId", item.ItemId);
					command.Parameters.AddWithValue("@p_Name", item.Name);
					command.Parameters.AddWithValue("@p_Type", item.Type);
					command.Parameters.AddWithValue("@p_Price", item.Price);
					command.Parameters.AddWithValue("@p_CategoryId", item.CategoryId);
					command.Parameters.AddWithValue("@p_ProductId", item.ProductId);
					command.Parameters.AddWithValue("@p_IsShoppingCart", item.IsShoppingCart);
					command.Parameters.AddWithValue("@p_Quantity", item.Quantity);

                        //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        int result = command.ExecuteNonQuery();
                        if (result == 0)
                            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                        item.CartId = (System.Int32)command.Parameters["@p_CartId"].Value;
                    }
                }
            }


            MarkOld(item);
            CheckRules(item);

            if(!stopProccessingChildren)
            {
            // Update Child Items.
                Update_Profile_ProfileMember_UniqueID(ref item);
            }

            OnUpdated();
        }

        #endregion

        #region Delete

        [Transactional(TransactionalTypes.TransactionScope)]
        public void Delete(CartCriteria criteria)
        {
            //Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
            DoDelete(criteria);
        }

        protected void DoDelete(ref Cart item)
        {
            // If we're not dirty then don't update the database.
            if (!item.IsDirty) return;

            // If we're new then don't call delete.
            if (item.IsNew) return;

            var criteria = new CartCriteria{CartId = item.CartId};
            
            DoDelete(criteria);

            MarkNew(item);
        }

        /// <summary>
        /// This call to delete is for immediate deletion and doesn't keep track of any entity state.
        /// </summary>
        /// <param name="criteria">The Criteria.</param>
        private void DoDelete(CartCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Cart_Delete]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
        }

        #endregion

        #region Helper Methods

        public Cart Map(SafeDataReader reader)
        {
            var item = (Cart)Activator.CreateInstance(typeof(Cart), true);
            using (BypassPropertyChecks(item))
            {
                item.CartId = reader.GetInt32("CartId");
                item.UniqueID = reader.GetInt32("UniqueID");
                item.ItemId = reader.GetString("ItemId");
                item.Name = reader.GetString("Name");
                item.Type = reader.GetString("Type");
                item.Price = reader.GetDecimal("Price");
                item.CategoryId = reader.GetString("CategoryId");
                item.ProductId = reader.GetString("ProductId");
                item.IsShoppingCart = reader.GetBoolean("IsShoppingCart");
                item.Quantity = reader.GetInt32("Quantity");
            }
            
            MarkOld(item);
            
            return item;
        }

        //AssociatedManyToOne
        private static void Update_Profile_ProfileMember_UniqueID(ref Cart item)
        {
				item.ProfileMember.UniqueID = item.UniqueID;

            new ProfileFactory().Update(item.ProfileMember, true);
        }

        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(CartCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(CartCriteria criteria, ref bool cancel);
        partial void OnDeleted();

        #endregion
    }
}