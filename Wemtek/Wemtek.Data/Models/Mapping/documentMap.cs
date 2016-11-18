using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;


namespace Wemtek.Domain.Models.Mapping
{
    public class documentMap : EntityTypeConfiguration<document>
    {
        public documentMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.path)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("document");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.numberDownloading).HasColumnName("numberDownloading");
            this.Property(t => t.path).HasColumnName("path");
            this.Property(t => t.projet_id).HasColumnName("projet_id");
        }
    }
}
