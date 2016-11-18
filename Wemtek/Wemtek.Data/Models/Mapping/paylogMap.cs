using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Wemtek.Domain.Entities;


namespace Wemtek.Domain.Models.Mapping
{
    public class paylogMap : EntityTypeConfiguration<paylog>
    {
        public paylogMap()
        {
            // Primary Key
            this.HasKey(t => t.idPay);

            // Properties
            // Table & Column Mappings
            this.ToTable("paylog");
            this.Property(t => t.idPay).HasColumnName("idPay");
            this.Property(t => t.progressValue).HasColumnName("progressValue");
            this.Property(t => t.unitPrice).HasColumnName("unitPrice");
            this.Property(t => t.deal_idDeal).HasColumnName("deal_idDeal");
        }
    }
}
