using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;


namespace Wemtek.Domain.Models.Mapping
{
    public class memberMap : EntityTypeConfiguration<member>
    {
        public memberMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("members");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.member_idUser).HasColumnName("member_idUser");
            this.Property(t => t.project_id).HasColumnName("project_id");
        }
    }
}
