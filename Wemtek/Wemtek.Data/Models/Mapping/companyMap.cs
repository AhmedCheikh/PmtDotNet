using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;


namespace Wemtek.Domain.Models.Mapping
{
    public class companyMap : EntityTypeConfiguration<company>
    {
        public companyMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Country)
                .HasMaxLength(255);

            this.Property(t => t.Name)
                .HasMaxLength(255);

            this.Property(t => t.Website)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("company");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Website).HasColumnName("Website");
            this.Property(t => t.tempalte_idTemplate).HasColumnName("tempalte_idTemplate");
        }
    }
}
