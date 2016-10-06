using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreetUp.Models
{
    public class Event
    {
        [Key]
        public int ID { get; set; }

        public string Description { get; set; }
        public string OrganizerName { get; set; }
        public DateTime EventDate { get; set; }
        public int MaxNumOfGuests { get; set; }
        public int CurrentNumOfGuests { get; set; }

        public Event()
        {
            CurrentNumOfGuests = 0;
        }
        

    }
}