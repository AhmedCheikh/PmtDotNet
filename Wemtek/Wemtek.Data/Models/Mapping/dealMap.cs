using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;


namespace Wemtek.Domain.Models.Mapping
{
    public class dealMap : EntityTypeConfiguration<deal>
    {
        public dealMap()
        {
            // Primary Key
            this.HasKey(t => t.idDeal);

            // Properties
            this.Property(t => t.idDeal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("deal");
            this.Property(t => t.idDeal).HasColumnName("idDeal");
            this.Property(t => t.dateDeal).HasColumnName("dateDeal");
            this.Property(t => t.days).HasColumnName("days");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.client_idUser).HasColumnName("client_idUser");
            this.Property(t => t.company_Id).HasColumnName("company_Id");
            this.Property(t => t.job_idJob).HasColumnName("job_idJob");
        }
    }
}
