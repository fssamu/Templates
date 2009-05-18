﻿using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using CodeSmith.Data.Attributes;
using CodeSmith.Data.Rules;

namespace Tracker.Data
{
    public partial class Task
    {
        // For more information about the features contained in this class, please visit our GoogleCode Wiki at...
        // http://code.google.com/p/codesmith/wiki/PLINQO
        // Also, you can watch our Video Tutorials at...
        // http://community.codesmithtools.com/

        #region Metadata

        [CodeSmith.Data.Audit.Audit]
        private class Metadata
        {
            // Only Attributes in the class will be preserved.

            public int Id { get; set; }

            public int StatusId { get; set; }

            public Priority PriorityId { get; set; }

            public int CreatedId { get; set; }

            [Required]
            public string Summary { get; set; }

            [DataType(System.ComponentModel.DataAnnotations.DataType.MultilineText)]
            public string Details { get; set; }

            public System.DateTime StartDate { get; set; }

            public System.DateTime DueDate { get; set; }

            public System.DateTime CompleteDate { get; set; }

            public int AssignedId { get; set; }

            [Now(EntityState.New)]
            [CodeSmith.Data.Audit.NotAudited]
            public System.DateTime CreatedDate { get; set; }

            [Now(EntityState.Dirty)]
            [CodeSmith.Data.Audit.NotAudited]
            public System.DateTime ModifiedDate { get; set; }

            public System.Data.Linq.Binary RowVersion { get; set; }

            public string LastModifiedBy { get; set; }

            public Status Status { get; set; }

            public User AssignedUser { get; set; }

            public User CreatedUser { get; set; }

            public TaskExtended TaskExtended { get; set; }

            public EntitySet<Audit> AuditList { get; set; }

        }

        #endregion
    }
}