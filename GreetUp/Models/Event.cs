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
        [Display(Name = "Organizer Name")]
        public string OrganizerName { get; set; }
        [Display(Name ="Event Date")]
        public DateTime EventDate { get; set; }
        [Display(Name ="Max Number of Guests")]
        public int MaxNumOfGuests { get; set; }
        [Display(Name ="Current Number of Guests")]
        public int CurrentNumOfGuests { get; set; }

        public Event()
        {
            CurrentNumOfGuests = 0;
        }
        

    }
}