using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using FlightBookingWebsite.Models.Mapping;

namespace FlightBookingWebsite.Models
{
    public partial class AirlineTicketBookingDBContext : DbContext
    {
        static AirlineTicketBookingDBContext()
        {
            Database.SetInitializer<AirlineTicketBookingDBContext>(null);
        }

        public AirlineTicketBookingDBContext()
            : base("Name=AirlineTicketBookingDBContext")
        {
        }

        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<AirplaneSeat> AirplaneSeats { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TravelClass> TravelClasses { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AirplaneMap());
            modelBuilder.Configurations.Add(new AirplaneSeatMap());
            modelBuilder.Configurations.Add(new AirportMap());
            modelBuilder.Configurations.Add(new BookingMap());
            modelBuilder.Configurations.Add(new FlightMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new PassengerMap());
            modelBuilder.Configurations.Add(new PaymentMap());
            modelBuilder.Configurations.Add(new ProducerMap());
            modelBuilder.Configurations.Add(new RouteMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TicketMap());
            modelBuilder.Configurations.Add(new TravelClassMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
