﻿using System;
using System.Linq;
using System.Data.Linq;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using CodeSmith.Data.Attributes;
using CodeSmith.Data.Audit;
using CodeSmith.Data.Rules;

namespace Tester.Data
{
    public partial class UserProfile
    {
        // For more information about the features contained in this class, please visit our GoogleCode Wiki at...
        // http://code.google.com/p/codesmith/wiki/PLINQO
        // Also, you can watch our Video Tutorials at...
        // http://community.codesmithtools.com/

        #region Metadata


        [Audit]
        private class Metadata
        {
            // Only Attributes in the class will be preserved.

            public int Id { get; set; }

            public int UserId { get; set; }

            public bool AllowNotification { get; set; }

            public System.Data.Linq.Binary Avatar { get; set; }

            public User User { get; set; }

        }

        #endregion
    }
}