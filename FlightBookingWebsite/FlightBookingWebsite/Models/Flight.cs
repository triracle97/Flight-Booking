using System;
using System.Collections.Generic;

namespace FlightBookingWebsite.Models
{
    public partial class Flight
    {
        public Flight()
        {
            this.Tickets = new List<Ticket>();
        }

        public int Flight_No { get; set; }
        public Nullable<System.DateTime> Departure_DateTime { get; set; }
        public Nullable<System.DateTime> Arrival_DateTime { get; set; }
        public Nullable<int> Route_ID { get; set; }
        public Nullable<int> Airplane_ID { get; set; }
        public virtual Airplane Airplane { get; set; }
        public virtual Route Route { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
