using System;
using System.Collections.Generic;

namespace FlightBookingWebsite.Models
{
    public partial class TravelClass
    {
        public TravelClass()
        {
            this.AirplaneSeats = new List<AirplaneSeat>();
        }

        public int Travel_Class_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<AirplaneSeat> AirplaneSeats { get; set; }
    }
}
