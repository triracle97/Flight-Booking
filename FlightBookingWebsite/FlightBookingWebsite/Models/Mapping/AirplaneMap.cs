using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FlightBookingWebsite.Models.Mapping
{
    public class AirplaneMap : EntityTypeConfiguration<Airplane>
    {
        public AirplaneMap()
        {
            // Primary Key
            this.HasKey(t => t.Airplane_ID);

            // Properties
            this.Property(t => t.Airplane_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Producer_ID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Airplanes");
            this.Property(t => t.Airplane_ID).HasColumnName("Airplane_ID");
            this.Property(t => t.Producer_ID).HasColumnName("Producer_ID");
            this.Property(t => t.Seat_Numbers).HasColumnName("Seat_Numbers");

            // Relationships
            this.HasOptional(t => t.Producer)
                .WithMany(t => t.Airplanes)
                .HasForeignKey(d => d.Producer_ID);

        }
    }
}
