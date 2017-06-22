using System;
using System.Collections.Generic;

namespace FlightBookingWebsite.Models
{
    public partial class AirplaneSeat
    {
        public AirplaneSeat()
        {
            this.Tickets = new List<Ticket>();
        }

        public int Airplane_ID { get; set; }
        public int Seat_No { get; set; }
        public Nullable<int> Travel_Class_ID { get; set; }
        public virtual Airplane Airplane { get; set; }
        public virtual TravelClass TravelClass { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
