using System;
using System.Collections.Generic;

namespace FlightBookingWebsite.Models
{
    public partial class Ticket
    {
        public Ticket()
        {
            this.Bookings = new List<Booking>();
        }

        public int Ticket_ID { get; set; }
        public Nullable<int> Flight_No { get; set; }
        public Nullable<int> Seat_No { get; set; }
        public Nullable<int> Airplane_ID { get; set; }
        public Nullable<int> Price { get; set; }
        public virtual AirplaneSeat AirplaneSeat { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual Flight Flight { get; set; }
    }
}
