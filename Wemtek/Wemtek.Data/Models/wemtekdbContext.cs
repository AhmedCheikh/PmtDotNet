using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Wemtek.Domain.Entities;
using Wemtek.Domain.Models.Mapping;

namespace Wemtek.Domain.Models
{
    public partial class wemtekdbContext : DbContext
    {
        static wemtekdbContext()
        {
            Database.SetInitializer<wemtekdbContext>(null);
        }

        public wemtekdbContext()
            : base("Name=wemtekdbContext")
        {
        }

        public DbSet<category> category { get; set; }
        public DbSet<company> company { get; set; }
        public DbSet<deal> deal { get; set; }
        public DbSet<document> document { get; set; }
        public DbSet<job> job { get; set; }
        public DbSet<jobhistory> jobhistory { get; set; }
        public DbSet<meetingdetail> meetingdetail { get; set; }
        public DbSet<member> member { get; set; }
        public DbSet<paylog> paylog { get; set; }
        public DbSet<project> project { get; set; }
        public DbSet<projectreview> projectreview { get; set; }
        public DbSet<reunion> reunion { get; set; }
        public DbSet<role> role { get; set; }
        public DbSet<task> task { get; set; }
        public DbSet<template> template { get; set; }
        public DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new categoryMap());
            modelBuilder.Configurations.Add(new companyMap());
            modelBuilder.Configurations.Add(new dealMap());
            modelBuilder.Configurations.Add(new documentMap());
            modelBuilder.Configurations.Add(new jobMap());
            modelBuilder.Configurations.Add(new jobhistoryMap());
            modelBuilder.Configurations.Add(new meetingdetailMap());
            modelBuilder.Configurations.Add(new memberMap());
            modelBuilder.Configurations.Add(new paylogMap());
            modelBuilder.Configurations.Add(new projectMap());
            modelBuilder.Configurations.Add(new projectreviewMap());
            modelBuilder.Configurations.Add(new reunionMap());
            modelBuilder.Configurations.Add(new roleMap());
            modelBuilder.Configurations.Add(new taskMap());
            modelBuilder.Configurations.Add(new templateMap());
            modelBuilder.Configurations.Add(new userMap());
        }
    }
}
