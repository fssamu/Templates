//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CSLA 3.6.x CodeSmith Templates.
//	   Changes to this template will not be lost.
//
//     Template: EditableChild.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region using declarations

using System;
using Csla;

#endregion

namespace PetShop.Business
{
	public partial class Order
	{
		#region Validation Rules
		
		/// <summary>
        /// All custom rules need to be placed in this method.
        /// </summary>
        /// <returns>Return true to override the generated rules; If false generated rules will be run.</returns>
		protected bool AddBusinessValidationRules()
		{
			// TODO: add validation rules
			//ValidationRules.AddRule(RuleMethod, "");

		    return false;
		}
		
		#endregion
		
		#region Authorization Rules
		
		protected override void AddAuthorizationRules()
		{
			// TODO: add authorization rules
			//AuthorizationRules.AllowWrite(NameProperty, "Role");
		}
		
		private static void AddObjectAuthorizationRules()
		{
			// TODO: add authorization rules
			//AuthorizationRules.AllowEdit(typeof(Order), "Role");
		}
		
		#endregion

        #region Custom Factory Methods

        /// <summary>
        /// Uses the profile's uniqueID to look up the order.
        /// </summary>
        /// <param name="uniqueId">assumes UserId == Profile.UniqueId</param>
        /// <returns>an Order.</returns>
        public static Order GetOrder(string uniqueId)
        {
            return DataPortal.Fetch<Order>(new OrderCriteria { UserId = uniqueId });
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo<LineItemList> _itemsProperty = RegisterProperty<LineItemList>(p => p.Items, Csla.RelationshipTypes.LazyLoad);
        public LineItemList Items
        {
            get
            {
                if (!FieldManager.FieldExists(_itemsProperty))
                    SetProperty(_itemsProperty, LineItemList.GetLineItemList(OrderId));

                return GetProperty(_itemsProperty);
            }
        }

        public CreditCard CreditCard { get; set; }

        #endregion
    }
}