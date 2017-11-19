using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineTicket.Models
{
    public class PassengerFlight
    {
        [Key]
        public int PFID { get; set; }
        public string airLine { get; set; }
        public string airCraft { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
        public string date { get; set; }
    }
}