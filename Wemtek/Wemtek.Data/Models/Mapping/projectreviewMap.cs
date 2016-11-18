using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;


namespace Wemtek.Domain.Models.Mapping
{
    public class projectreviewMap : EntityTypeConfiguration<projectreview>
    {
        public projectreviewMap()
        {
            // Primary Key
            this.HasKey(t => t.idReview);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("projectreview");
            this.Property(t => t.idReview).HasColumnName("idReview");
            this.Property(t => t.dateReview).HasColumnName("dateReview");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.rating).HasColumnName("rating");
            this.Property(t => t.client_idUser).HasColumnName("client_idUser");
            this.Property(t => t.project_id).HasColumnName("project_id");
        }
    }
}
