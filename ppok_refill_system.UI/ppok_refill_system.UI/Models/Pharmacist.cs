using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ppok_refill_system.UI.Models
{
    public class Pharmacist:Person
    {
        public String userName { get; set; }
        public String passWord { get; set; }
        public bool isAdmin { get; set; }
    }
}