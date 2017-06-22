using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FlightBookingWebsite.Models.Mapping
{
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            // Primary Key
            this.HasKey(t => t.City);

            // Properties
            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.State_Province)
                .HasMaxLength(50);

            this.Property(t => t.Country)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Location");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State_Province).HasColumnName("State_Province");
            this.Property(t => t.Country).HasColumnName("Country");
        }
    }
}
