using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FlightBookingWebsite.Models.Mapping
{
    public class PassengerMap : EntityTypeConfiguration<Passenger>
    {
        public PassengerMap()
        {
            // Primary Key
            this.HasKey(t => t.PassengerID);

            // Properties
            this.Property(t => t.PassengerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FullName)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.Street)
                .HasMaxLength(50);

            this.Property(t => t.Location_City)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Passenger");
            this.Property(t => t.PassengerID).HasColumnName("PassengerID");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Street).HasColumnName("Street");
            this.Property(t => t.Location_City).HasColumnName("Location_City");
        }
    }
}
