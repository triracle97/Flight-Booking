using System;
using System.Collections.Generic;

namespace FlightBookingWebsite.Models
{
    public partial class Route
    {
        public Route()
        {
            this.Flights = new List<Flight>();
        }

        public int Route_ID { get; set; }
        public Nullable<int> Origin_Airport { get; set; }
        public Nullable<int> Destination_Airport { get; set; }
        public Nullable<int> Distance { get; set; }
        public virtual Airport Airport { get; set; }
        public virtual Airport Airport1 { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
