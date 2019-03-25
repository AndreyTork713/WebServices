using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServices.Models
{
    public class ReservationRepository
    {
        private static ReservationRepository repo = new ReservationRepository();

        public static ReservationRepository Current
        {
            get{return repo;}
           
        }

        private List<Reservation> data = new List<Reservation>
        {
            new Reservation {ReservationID = 1, ClientName = "Петр", Location = "Отель"},
            new Reservation {ReservationID = 1, ClientName = "Петр", Location = "Отель"},
            new Reservation {ReservationID = 1, ClientName = "Петр", Location = "Отель"},

        };

    }
}