using System;
using System.Collections.Generic;

namespace FlightBookingWebsite.Models
{
    public partial class Producer
    {
        public Producer()
        {
            this.Airplanes = new List<Airplane>();
        }

        public string Producer_ID { get; set; }
        public string Producer_Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Airplane> Airplanes { get; set; }
    }
}
