using System;
using System.Collections.Generic;

namespace FlightBookingWebsite.Models
{
    public partial class Payment
    {
        public int Payment_ID { get; set; }
        public Nullable<int> Booking_ID { get; set; }
        public Nullable<int> Payment_Amount { get; set; }
        public Nullable<System.DateTime> Payment_Date { get; set; }
        public virtual Booking Booking { get; set; }
    }
}
