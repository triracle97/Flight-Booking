using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FlightBookingWebsite.Models.Mapping
{
    public class AirportMap : EntityTypeConfiguration<Airport>
    {
        public AirportMap()
        {
            // Primary Key
            this.HasKey(t => t.Airport_ID);

            // Properties
            this.Property(t => t.Airport_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Airport_Name)
                .HasMaxLength(50);

            this.Property(t => t.Location_City)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Airport");
            this.Property(t => t.Airport_ID).HasColumnName("Airport_ID");
            this.Property(t => t.Airport_Name).HasColumnName("Airport_Name");
            this.Property(t => t.Location_City).HasColumnName("Location_City");

            // Relationships
            this.HasOptional(t => t.Location)
                .WithMany(t => t.Airports)
                .HasForeignKey(d => d.Location_City);

        }
    }
}
