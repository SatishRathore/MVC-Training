using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpers.Models
{
    public class Registration
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public bool IsApproved { get; set; }
        public bool IsApprovedG { get; set; }
        public string Gender { get; set; }
        public string Hobbies { get; set; }
    }
}