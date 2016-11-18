using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;


namespace Wemtek.Domain.Models.Mapping
{
    public class roleMap : EntityTypeConfiguration<role>
    {
        public roleMap()
        {
            // Primary Key
            this.HasKey(t => t.RoleId);

            // Properties
            this.Property(t => t.Role1)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("role");
            this.Property(t => t.RoleId).HasColumnName("RoleId");
            this.Property(t => t.Role1).HasColumnName("Role");
        }
    }
}
