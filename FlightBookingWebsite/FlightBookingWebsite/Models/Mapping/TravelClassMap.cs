using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FlightBookingWebsite.Models.Mapping
{
    public class TravelClassMap : EntityTypeConfiguration<TravelClass>
    {
        public TravelClassMap()
        {
            // Primary Key
            this.HasKey(t => t.Travel_Class_ID);

            // Properties
            this.Property(t => t.Travel_Class_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TravelClass");
            this.Property(t => t.Travel_Class_ID).HasColumnName("Travel_Class_ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}
