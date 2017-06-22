using System;
using System.Collections.Generic;

namespace FlightBookingWebsite.Models
{
    public partial class Airplane
    {
        public Airplane()
        {
            this.AirplaneSeats = new List<AirplaneSeat>();
            this.Flights = new List<Flight>();
        }

        public int Airplane_ID { get; set; }
        public string Producer_ID { get; set; }
        public Nullable<int> Seat_Numbers { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual ICollection<AirplaneSeat> AirplaneSeats { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
