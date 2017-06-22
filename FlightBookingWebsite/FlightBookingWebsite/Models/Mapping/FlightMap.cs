using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FlightBookingWebsite.Models.Mapping
{
    public class FlightMap : EntityTypeConfiguration<Flight>
    {
        public FlightMap()
        {
            // Primary Key
            this.HasKey(t => t.Flight_No);

            // Properties
            // Table & Column Mappings
            this.ToTable("Flight");
            this.Property(t => t.Flight_No).HasColumnName("Flight_No");
            this.Property(t => t.Departure_DateTime).HasColumnName("Departure_DateTime");
            this.Property(t => t.Arrival_DateTime).HasColumnName("Arrival_DateTime");
            this.Property(t => t.Route_ID).HasColumnName("Route_ID");
            this.Property(t => t.Airplane_ID).HasColumnName("Airplane_ID");

            // Relationships
            this.HasOptional(t => t.Airplane)
                .WithMany(t => t.Flights)
                .HasForeignKey(d => d.Airplane_ID);
            this.HasOptional(t => t.Route)
                .WithMany(t => t.Flights)
                .HasForeignKey(d => d.Route_ID);

        }
    }
}
