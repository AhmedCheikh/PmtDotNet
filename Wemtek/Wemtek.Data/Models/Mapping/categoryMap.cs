using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;


namespace Wemtek.Domain.Models.Mapping
{
    public class categoryMap : EntityTypeConfiguration<category>
    {
        public categoryMap()
        {
            // Primary Key
            this.HasKey(t => t.idCategory);

            // Properties
            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("category");
            this.Property(t => t.idCategory).HasColumnName("idCategory");
            this.Property(t => t.name).HasColumnName("name");
        }
    }
}
