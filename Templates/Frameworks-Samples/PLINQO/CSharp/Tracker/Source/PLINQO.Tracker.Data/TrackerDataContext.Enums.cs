﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
//
//     To make updates to Enums, please use the *.Enum.xml
//     file, hidded behind the *.dbml file.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace PLINQO.Tracker.Data
{
    [DataContract]
    public enum Priority : int
    {
        /// <summary>
        /// A High Priority
        /// </summary>
        [Description("A High Priority")]
        [EnumMember]
        High = 1,
        /// <summary>
        /// A Normal Priority
        /// </summary>
        [Description("A Normal Priority")]
        [EnumMember]
        Normal = 2,
        /// <summary>
        /// A Low Priority
        /// </summary>
        [Description("A Low Priority")]
        [EnumMember]
        Low = 3
    }
    
}