using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyAPI.Read.Models
{
    public class ClubMember
    {
        public int ClubId { get; set; }
        public int ClubMemberId { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
    }
}
