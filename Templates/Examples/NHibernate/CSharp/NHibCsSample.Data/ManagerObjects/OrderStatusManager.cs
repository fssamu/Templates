using System;
using System.Collections.Generic;
using System.Text;

using NHibernate;
using NHibCsSample.Generated.BusinessObjects;
using NHibCsSample.Generated.Base;

namespace NHibCsSample.Generated.ManagerObjects
{
    public partial interface IOrderStatusManager : IManagerBase<OrderStatus, string>
    {
	}
	
	partial class OrderStatusManager : ManagerBase<OrderStatus, string>, IOrderStatusManager
    {
	}
}