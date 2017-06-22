using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FlightBookingWebsite.Models.Mapping
{
    public class BookingMap : EntityTypeConfiguration<Booking>
    {
        public BookingMap()
        {
            // Primary Key
            this.HasKey(t => t.Booking_ID);

            // Properties
            this.Property(t => t.Booking_Status)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Booking");
            this.Property(t => t.Booking_ID).HasColumnName("Booking_ID");
            this.Property(t => t.Ticket_ID).HasColumnName("Ticket_ID");
            this.Property(t => t.Passenger_ID).HasColumnName("Passenger_ID");
            this.Property(t => t.Booking_Status).HasColumnName("Booking_Status");
            this.Property(t => t.Booking_Date).HasColumnName("Booking_Date");

            // Relationships
            this.HasOptional(t => t.Passenger)
                .WithMany(t => t.Bookings)
                .HasForeignKey(d => d.Passenger_ID);
            this.HasOptional(t => t.Ticket)
                .WithMany(t => t.Bookings)
                .HasForeignKey(d => d.Ticket_ID);

        }
    }
}
