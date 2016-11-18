using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;

namespace Wemtek.Domain.Models.Mapping
{
    public class jobMap : EntityTypeConfiguration<job>
    {
        public jobMap()
        {
            // Primary Key
            this.HasKey(t => t.idJob);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("job");
            this.Property(t => t.idJob).HasColumnName("idJob");
            this.Property(t => t.datePublication).HasColumnName("datePublication");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.cat_idCategory).HasColumnName("cat_idCategory");
            this.Property(t => t.client_idUser).HasColumnName("client_idUser");
        }
    }
}
