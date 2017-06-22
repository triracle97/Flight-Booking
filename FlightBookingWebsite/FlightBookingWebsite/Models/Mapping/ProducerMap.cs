using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FlightBookingWebsite.Models.Mapping
{
    public class ProducerMap : EntityTypeConfiguration<Producer>
    {
        public ProducerMap()
        {
            // Primary Key
            this.HasKey(t => t.Producer_ID);

            // Properties
            this.Property(t => t.Producer_ID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Producer_Name)
                .HasMaxLength(50);

            this.Property(t => t.Icon)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Producer");
            this.Property(t => t.Producer_ID).HasColumnName("Producer_ID");
            this.Property(t => t.Producer_Name).HasColumnName("Producer_Name");
            this.Property(t => t.Icon).HasColumnName("Icon");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
