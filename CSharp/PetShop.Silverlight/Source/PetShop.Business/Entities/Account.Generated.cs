﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Account.cs'.
//
//     Template: EditableChild.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Rules;
#if SILVERLIGHT
using Csla.Serialization;
#else
using Csla.Data;
using System.Data.SqlClient;
#endif

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class Account : BusinessBase< Account >
    {
        #region Contructor(s)

#if !SILVERLIGHT
        private Account()
        {
            // require use of factory method.
            MarkAsChild();
        }
#else
        public Account()
        {
            // require use of factory method.
            MarkAsChild();
        }        
#endif

        internal Account(System.Int32 accountId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_accountIdProperty, accountId);
            }

            MarkAsChild();
        }

#if !SILVERLIGHT
        internal Account(SafeDataReader reader)
        {
            Map(reader);

            MarkAsChild();
        }
#endif
        #endregion

        #region Business Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_emailProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_emailProperty, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_firstNameProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_firstNameProperty, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_lastNameProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_lastNameProperty, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_address1Property));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_address1Property, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_address2Property, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_cityProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_cityProperty, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_stateProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_stateProperty, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_zipProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_zipProperty, 20));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_countryProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_countryProperty, 20));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_phoneProperty, 20));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.Int32 > _accountIdProperty = RegisterProperty< System.Int32 >(p => p.AccountId, string.Empty);
#if !SILVERLIGHT
		[System.ComponentModel.DataObjectField(true, true)]
#endif
        public System.Int32 AccountId
        {
            get { return GetProperty(_accountIdProperty); }
            internal set{ SetProperty(_accountIdProperty, value); }
        }
        private static readonly PropertyInfo< System.Int32 > _uniqueIDProperty = RegisterProperty< System.Int32 >(p => p.UniqueID, string.Empty);
        public System.Int32 UniqueID
        {
            get { return GetProperty(_uniqueIDProperty); }
            set{ SetProperty(_uniqueIDProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _emailProperty = RegisterProperty< System.String >(p => p.Email, string.Empty);
        public System.String Email
        {
            get { return GetProperty(_emailProperty); }
            set{ SetProperty(_emailProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _firstNameProperty = RegisterProperty< System.String >(p => p.FirstName, string.Empty);
        public System.String FirstName
        {
            get { return GetProperty(_firstNameProperty); }
            set{ SetProperty(_firstNameProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _lastNameProperty = RegisterProperty< System.String >(p => p.LastName, string.Empty);
        public System.String LastName
        {
            get { return GetProperty(_lastNameProperty); }
            set{ SetProperty(_lastNameProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _address1Property = RegisterProperty< System.String >(p => p.Address1, string.Empty);
        public System.String Address1
        {
            get { return GetProperty(_address1Property); }
            set{ SetProperty(_address1Property, value); }
        }
        private static readonly PropertyInfo< System.String > _address2Property = RegisterProperty< System.String >(p => p.Address2, string.Empty, (System.String)null);
        public System.String Address2
        {
            get { return GetProperty(_address2Property); }
            set{ SetProperty(_address2Property, value); }
        }
        private static readonly PropertyInfo< System.String > _cityProperty = RegisterProperty< System.String >(p => p.City, string.Empty);
        public System.String City
        {
            get { return GetProperty(_cityProperty); }
            set{ SetProperty(_cityProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _stateProperty = RegisterProperty< System.String >(p => p.State, string.Empty);
        public System.String State
        {
            get { return GetProperty(_stateProperty); }
            set{ SetProperty(_stateProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _zipProperty = RegisterProperty< System.String >(p => p.Zip, string.Empty);
        public System.String Zip
        {
            get { return GetProperty(_zipProperty); }
            set{ SetProperty(_zipProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _countryProperty = RegisterProperty< System.String >(p => p.Country, string.Empty);
        public System.String Country
        {
            get { return GetProperty(_countryProperty); }
            set{ SetProperty(_countryProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _phoneProperty = RegisterProperty< System.String >(p => p.Phone, string.Empty, (System.String)null);
        public System.String Phone
        {
            get { return GetProperty(_phoneProperty); }
            set{ SetProperty(_phoneProperty, value); }
        }

        //AssociatedManyToOne
        private static readonly PropertyInfo< Profile > _profileMemberProperty = RegisterProperty< Profile >(p => p.ProfileMember, Csla.RelationshipTypes.Child);
        public Profile ProfileMember
        {
            get
            {
                if(!FieldManager.FieldExists(_profileMemberProperty))
                {
                    var criteria = new PetShop.Business.ProfileCriteria {UniqueID = UniqueID};
                    
#if SILVERLIGHT
                    MarkBusy();
                    if(PetShop.Business.Profile.Exists(criteria))
                        PetShop.Business.Profile.GetByUniqueIDAsync(UniqueID, (o, e) =>
                            {
                                if (e.Error != null)
                                    throw e.Error; 

                                this.LoadProperty(_profileMemberProperty, e.Object);

                                MarkIdle();
                                OnPropertyChanged(_profileMemberProperty);
                            });
#else
                    if(PetShop.Business.Profile.Exists(criteria))
                        LoadProperty(_profileMemberProperty, PetShop.Business.Profile.GetByUniqueID(UniqueID));
#endif
                }

                return GetProperty(_profileMemberProperty); 
            }
        }
        #endregion

        #region Synchronous Factory Methods 

#if !SILVERLIGHT
        internal static Account NewAccount()
        {
            return DataPortal.CreateChild< Account >();
        }

        internal static Account GetByAccountId(System.Int32 accountId)
        {
            var criteria = new AccountCriteria {AccountId = accountId};
            
        
            return DataPortal.FetchChild< Account >(criteria);
        }

        internal static Account GetByUniqueID(System.Int32 uniqueID)
        {
            var criteria = new AccountCriteria {UniqueID = uniqueID};
            
        
            return DataPortal.FetchChild< Account >(criteria);
        }
#endif

        #endregion

        #region Asynchronous Factory Methods

#if SILVERLIGHT
        internal static void NewAccountAsync(EventHandler<DataPortalResult<Account>> handler)
        {
            var dp = new DataPortal<Account>();
            dp.CreateCompleted += handler;
            dp.BeginCreate();
        }

        internal static void GetByAccountIdAsync(System.Int32 accountId, EventHandler<DataPortalResult<Account>> handler)
        {
            var criteria = new AccountCriteria{ AccountId = accountId};
            

            // Mark as child?
            var dp = new DataPortal< Account >();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        internal static void GetByUniqueIDAsync(System.Int32 uniqueID, EventHandler<DataPortalResult<Account>> handler)
        {
            var criteria = new AccountCriteria{ UniqueID = uniqueID};
            

            // Mark as child?
            var dp = new DataPortal< Account >();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }
#endif
        
        #endregion

        #region ChildPortal partial methods

#if !SILVERLIGHT
        partial void OnChildCreating(ref bool cancel);
        partial void OnChildCreated();
        partial void OnChildFetching(AccountCriteria criteria, ref bool cancel);
        partial void OnChildFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);
        partial void OnChildInserted();
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);
        partial void OnChildUpdated();
        partial void OnChildSelfDeleting(SqlConnection connection, ref bool cancel);
        partial void OnChildSelfDeleted();
        partial void OnDeleting(AccountCriteria criteria, ref bool cancel);
        partial void OnDeleting(AccountCriteria criteria, SqlConnection connection, ref bool cancel);
        partial void OnDeleted();
#endif

        #endregion

        #region Exists Command

        public static bool Exists(AccountCriteria criteria)
        {
            return PetShop.Business.ExistsCommand.Execute(criteria);
        }

        #endregion

    }
}