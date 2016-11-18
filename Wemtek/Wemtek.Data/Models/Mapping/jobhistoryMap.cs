using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;


namespace Wemtek.Domain.Models.Mapping
{
    public class jobhistoryMap : EntityTypeConfiguration<jobhistory>
    {
        public jobhistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.idHistory);

            // Properties
            // Table & Column Mappings
            this.ToTable("jobhistory");
            this.Property(t => t.idHistory).HasColumnName("idHistory");
            this.Property(t => t.company_Id).HasColumnName("company_Id");
            this.Property(t => t.jobs_idJob).HasColumnName("jobs_idJob");
        }
    }
}
