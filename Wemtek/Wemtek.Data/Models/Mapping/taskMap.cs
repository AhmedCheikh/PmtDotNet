using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;

namespace Wemtek.Domain.Models.Mapping
{
    public class taskMap : EntityTypeConfiguration<task>
    {
        public taskMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.etat)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("task");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.complexity).HasColumnName("complexity");
            this.Property(t => t.deadLine).HasColumnName("deadLine");
            this.Property(t => t.duration).HasColumnName("duration");
            this.Property(t => t.etat).HasColumnName("etat");
            this.Property(t => t.assignedTo_idUser).HasColumnName("assignedTo_idUser");
            this.Property(t => t.projet_id).HasColumnName("projet_id");
        }
    }
}
