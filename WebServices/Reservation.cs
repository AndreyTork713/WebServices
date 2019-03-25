using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string ClientName { get; set; }
        public string Location { get; set; }
    }
}