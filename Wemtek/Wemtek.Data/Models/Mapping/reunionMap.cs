using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;


namespace Wemtek.Domain.Models.Mapping
{
    public class reunionMap : EntityTypeConfiguration<reunion>
    {
        public reunionMap()
        {
            // Primary Key
            this.HasKey(t => t.IdR);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(255);

            this.Property(t => t.Type)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("reunion");
            this.Property(t => t.IdR).HasColumnName("IdR");
            this.Property(t => t.DateR).HasColumnName("DateR");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}
