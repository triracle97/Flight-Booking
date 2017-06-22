using System;
using System.Collections.Generic;

namespace FlightBookingWebsite.Models
{
    public partial class Booking
    {
        public Booking()
        {
            this.Payments = new List<Payment>();
        }

        public int Booking_ID { get; set; }
        public Nullable<int> Ticket_ID { get; set; }
        public Nullable<int> Passenger_ID { get; set; }
        public string Booking_Status { get; set; }
        public Nullable<System.DateTime> Booking_Date { get; set; }
        public virtual Passenger Passenger { get; set; }
        public virtual Ticket Ticket { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
