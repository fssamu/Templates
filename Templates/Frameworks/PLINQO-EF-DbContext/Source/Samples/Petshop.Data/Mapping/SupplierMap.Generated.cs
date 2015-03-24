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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Petshop.Data.Mapping
{
    public partial class SupplierMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Petshop.Data.Entities.Supplier>
    {
        public SupplierMap()
        {
            // table
            ToTable("Supplier", "dbo");

            // keys
            HasKey(t => t.SuppId);

            // Properties
            Property(t => t.SuppId)
                .HasColumnName("SuppId")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(80)
                .IsOptional();
            Property(t => t.Status)
                .HasColumnName("Status")
                .HasMaxLength(2)
                .IsRequired();
            Property(t => t.Addr1)
                .HasColumnName("Addr1")
                .HasMaxLength(80)
                .IsOptional();
            Property(t => t.Addr2)
                .HasColumnName("Addr2")
                .HasMaxLength(80)
                .IsOptional();
            Property(t => t.City)
                .HasColumnName("City")
                .HasMaxLength(80)
                .IsOptional();
            Property(t => t.State)
                .HasColumnName("State")
                .HasMaxLength(80)
                .IsOptional();
            Property(t => t.Zip)
                .HasColumnName("Zip")
                .HasMaxLength(5)
                .IsOptional();
            Property(t => t.Phone)
                .HasColumnName("Phone")
                .HasMaxLength(40)
                .IsOptional();

            // Relationships

            InitializeMapping();
        }
    }
}