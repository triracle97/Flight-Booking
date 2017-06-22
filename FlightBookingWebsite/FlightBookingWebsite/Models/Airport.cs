using System;
using System.Collections.Generic;

namespace FlightBookingWebsite.Models
{
    public partial class Airport
    {
        public Airport()
        {
            this.Routes = new List<Route>();
            this.Routes1 = new List<Route>();
        }

        public int Airport_ID { get; set; }
        public string Airport_Name { get; set; }
        public string Location_City { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
        public virtual ICollection<Route> Routes1 { get; set; }
    }
}
