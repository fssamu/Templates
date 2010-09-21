﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
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
#if SILVERLIGHT
using Csla.Serialization;
#else
using Csla.Data;
#endif

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class LineItemList : BusinessListBase< LineItemList, LineItem >
    {    
        #region Contructor(s)

#if !SILVERLIGHT
        private LineItemList()
        { 
            AllowNew = true;
        }
#else
        public LineItemList()
        { 
            AllowNew = true;
        }
#endif
        
        #endregion

#if !SILVERLIGHT
        #region Method Overrides
        
        protected override LineItem AddNewCore()
        {
            LineItem item = PetShop.Business.LineItem.NewLineItem();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Business.LineItem.NewLineItem();

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
#else
        #region Method Overrides

        protected override void AddNewCore()
        {
            PetShop.Business.LineItem.NewLineItemAsync((o, e) =>
                {
                    LineItem item = e.Object;

                    bool cancel = false;
                    OnAddNewCore(ref item, ref cancel);
                    if (!cancel)
                    {
                        // Check to see if someone set the item to null in the OnAddNewCore.
                        if(item == null)
                            return;
                        // Pass the parent value down to the child.
                        Order order = this.Parent as Order;
                        if(order != null)
                            item.OrderId = order.OrderId;
        
                        Add(item);
                    }
                });
        }
        
        #endregion

        #region Asynchronous Factory Methods
        
        public static void NewListAsync(EventHandler<DataPortalResult<LineItemList>> handler)
        {
            var dp = new DataPortal<LineItemList>();
            dp.CreateCompleted += handler;
            dp.BeginCreate();
        }


        public static void GetByOrderIdLineNumAsync(System.Int32 orderId, System.Int32 lineNum, EventHandler<DataPortalResult<LineItemList>> handler)
        {
            var criteria = new LineItemCriteria{OrderId = orderId, LineNum = lineNum};
            
            var dp = new DataPortal< LineItemList >();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetByOrderIdAsync(System.Int32 orderId, EventHandler<DataPortalResult<LineItemList>> handler)
        {
            var criteria = new LineItemCriteria{OrderId = orderId};
            
            var dp = new DataPortal< LineItemList >();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetAllAsync(EventHandler<DataPortalResult<LineItemList>> handler)
        {
            var dp = new DataPortal<LineItemList>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(new LineItemCriteria());
        }

        #endregion
#endif
        #region DataPortal partial methods

#if !SILVERLIGHT
        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(LineItemCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
#endif
        partial void OnAddNewCore(ref LineItem item, ref bool cancel);

        #endregion

        #region Exists Command

        public static bool Exists(LineItemCriteria criteria)
        {
            return PetShop.Business.LineItem.Exists(criteria);
        }

        #endregion

    }
}