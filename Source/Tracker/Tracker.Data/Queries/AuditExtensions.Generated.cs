﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Data.Linq;

namespace Tracker.Data
{
    /// <summary>
    /// The query extension class for Audit.
    /// </summary>
    public static partial class AuditExtensions
    {

        /// <summary>
        /// Gets an instance by the primary key.
        /// </summary>
        public static Tracker.Data.Audit ByKey(this IQueryable<Tracker.Data.Audit> queryable, int id)
        {
            var entity = queryable as System.Data.Linq.Table<Tracker.Data.Audit>;
            if (entity != null && entity.Context.LoadOptions == null)
                return Query.ByKey.Invoke((Tracker.Data.TrackerDataContext)entity.Context, id);
            
            return queryable.FirstOrDefault(a => a.Id == id);
        }

        /// <summary>
        /// Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        /// </summary>
        /// <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        /// <returns>The number of rows deleted from the database.</returns>
        public static int Delete(this System.Data.Linq.Table<Tracker.Data.Audit> table, int id)
        {
            return table.Delete(a => a.Id == id);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Audit.Date"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Audit> ByDate(this IQueryable<Tracker.Data.Audit> queryable, System.DateTime date)
        {
            return queryable.Where(a => a.Date == date);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Audit.UserId"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Audit> ByUserId(this IQueryable<Tracker.Data.Audit> queryable, Nullable<int> userId)
        {
            return queryable.Where(a => a.UserId == userId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Audit.TaskId"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Audit> ByTaskId(this IQueryable<Tracker.Data.Audit> queryable, Nullable<int> taskId)
        {
            return queryable.Where(a => a.TaskId == taskId);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Audit.Content"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Audit> ByContent(this IQueryable<Tracker.Data.Audit> queryable, string content)
        {
            return queryable.Where(a => a.Content == content);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Audit.Username"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Audit> ByUsername(this IQueryable<Tracker.Data.Audit> queryable, string username)
        {
            return queryable.Where(a => a.Username == username);
        }
        
        /// <summary>
        /// Gets a query for <see cref="Audit.CreatedDate"/>.
        /// </summary>
        public static IQueryable<Tracker.Data.Audit> ByCreatedDate(this IQueryable<Tracker.Data.Audit> queryable, System.DateTime createdDate)
        {
            return queryable.Where(a => a.CreatedDate == createdDate);
        }

        #region Query
        /// <summary>
        /// A private class for lazy loading static compiled queries.
        /// </summary>
        private static partial class Query
        {

            internal static readonly Func<Tracker.Data.TrackerDataContext, int, Tracker.Data.Audit> ByKey = 
                System.Data.Linq.CompiledQuery.Compile(
                    (Tracker.Data.TrackerDataContext db, int id) => 
                        db.Audit.FirstOrDefault(a => a.Id == id));

        }
        #endregion
    }
}
