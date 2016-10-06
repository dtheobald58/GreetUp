using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GreetUp.Models
{
    public class RSVP
    {
        [Key]
        public int ID { get; set; }
        public string PrimaryGuestName { get; set; }
        public int NumOfGuests { get; set; }
        public string Email { get; set; }

        [ForeignKey("Event")]
        public int EventID { get; set; }
        public virtual Event Event { get; set; }
    }
}