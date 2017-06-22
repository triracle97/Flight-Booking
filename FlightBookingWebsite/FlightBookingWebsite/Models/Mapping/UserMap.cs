using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FlightBookingWebsite.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            // Primary Key
            this.HasKey(t => t.Username);

            // Properties
            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Password)
                .HasMaxLength(50);

            this.Property(t => t.Type)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("User");
            this.Property(t => t.PassengerID).HasColumnName("PassengerID");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Type).HasColumnName("Type");

            // Relationships
            this.HasOptional(t => t.Passenger)
                .WithMany(t => t.Users)
                .HasForeignKey(d => d.PassengerID);

        }
    }
}
