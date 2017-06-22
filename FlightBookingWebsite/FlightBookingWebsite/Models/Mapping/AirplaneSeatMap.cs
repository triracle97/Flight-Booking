using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FlightBookingWebsite.Models.Mapping
{
    public class AirplaneSeatMap : EntityTypeConfiguration<AirplaneSeat>
    {
        public AirplaneSeatMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Airplane_ID, t.Seat_No });

            // Properties
            this.Property(t => t.Airplane_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Seat_No)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AirplaneSeats");
            this.Property(t => t.Airplane_ID).HasColumnName("Airplane_ID");
            this.Property(t => t.Seat_No).HasColumnName("Seat_No");
            this.Property(t => t.Travel_Class_ID).HasColumnName("Travel_Class_ID");

            // Relationships
            this.HasRequired(t => t.Airplane)
                .WithMany(t => t.AirplaneSeats)
                .HasForeignKey(d => d.Airplane_ID);
            this.HasOptional(t => t.TravelClass)
                .WithMany(t => t.AirplaneSeats)
                .HasForeignKey(d => d.Travel_Class_ID);

        }
    }
}
