﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop.Data.Entities
{
    public partial class Profile
    {
        public Profile()
        {
        }

        public string UserId { get; set; }
        public string LangPref { get; set; }
        public string FavCategory { get; set; }
        public int? MyListOpt { get; set; }
        public int? BannerOpt { get; set; }

    }
}