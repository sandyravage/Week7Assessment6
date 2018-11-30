using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week7Assessment6.Models
{
    public class Guest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Attending { get; set; }
        public string PartyDate { get; set; }
        public string PlusOne { get; set; }
        public string GuestName { get; set; }

        public string GetPartyDate()
        {
            string date = "";
            if (PartyDate == "1")
            {
                date = "December 15th, 2018";
            }
            else
            {
                date = "December 18th, 2018";
            }
            return date;
        }
    }
}