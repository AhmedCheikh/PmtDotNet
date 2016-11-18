using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;

namespace Wemtek.Domain.Models.Mapping
{
    public class templateMap : EntityTypeConfiguration<template>
    {
        public templateMap()
        {
            // Primary Key
            this.HasKey(t => t.idTemplate);

            // Properties
            this.Property(t => t.Path)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("template");
            this.Property(t => t.idTemplate).HasColumnName("idTemplate");
            this.Property(t => t.Path).HasColumnName("Path");
        }
    }
}
