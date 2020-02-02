using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyAPI.Read.Models
{
    public class Club
    {
        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public string AddressLine1 { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
    }
}
