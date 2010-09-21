﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1872, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'LineItemList.cs'.
//
//     Template: EditableRootList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    [Serializable]
    public partial class LineItemList : BusinessListBase< LineItemList, LineItem >
    {    
        #region Contructor(s)

        private LineItemList()
        { 
            AllowNew = true;
        }
        
        #endregion

        #region Method Overrides
        
        protected override object AddNewCore()
        {
            LineItem item = PetShop.Tests.ParameterizedSQL.LineItem.NewLineItem();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Tests.ParameterizedSQL.LineItem.NewLineItem();

                // Pass the parent value down to the child.
                Order order = this.Parent as Order;
                if(order != null)
                    item.OrderId = order.OrderId;


                Add(item);
            }

            return item;
        }
        
        #endregion

        #region Synchronous Factory Methods 
        
        public static LineItemList NewList()
        {
            return DataPortal.Create< LineItemList >();
        }      

        public static LineItemList GetByOrderIdLineNum(System.Int32 orderId, System.Int32 lineNum)
        {
            var criteria = new LineItemCriteria{OrderId = orderId, LineNum = lineNum};
            
            
            return DataPortal.Fetch< LineItemList >(criteria);
        }

        public static LineItemList GetByOrderId(System.Int32 orderId)
        {
            var criteria = new LineItemCriteria{OrderId = orderId};
            
            
            return DataPortal.Fetch< LineItemList >(criteria);
        }

        public static LineItemList GetAll()
        {
            return DataPortal.Fetch< LineItemList >(new LineItemCriteria());
        }

        #endregion
        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(LineItemCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnAddNewCore(ref LineItem item, ref bool cancel);

        #endregion

        #region Exists Command

        public static bool Exists(LineItemCriteria criteria)
        {
            return PetShop.Tests.ParameterizedSQL.LineItem.Exists(criteria);
        }

        #endregion

    }
}