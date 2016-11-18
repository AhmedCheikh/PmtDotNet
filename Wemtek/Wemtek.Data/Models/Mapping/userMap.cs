using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;

namespace Wemtek.Domain.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.idUser);

            // Properties
            this.Property(t => t.Email)
                .HasMaxLength(255);

            this.Property(t => t.FirstName)
                .HasMaxLength(255);

            this.Property(t => t.LastName)
                .HasMaxLength(255);

            this.Property(t => t.Password)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user");
            this.Property(t => t.idUser).HasColumnName("idUser");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.UserRole_RoleId).HasColumnName("UserRole_RoleId");
            this.Property(t => t.company_Id).HasColumnName("company_Id");
            this.Property(t => t.templateId_idTemplate).HasColumnName("templateId_idTemplate");
        }
    }
}
