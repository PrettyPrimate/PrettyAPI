using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PrettyAPI.Read;
using PrettyAPI.Read.Models;

namespace PrettyAPI.Controllers
{
    public class ClubsController : ApiController
    {
        private readonly GetClub _getClub;

        public ClubsController() { }

        public ClubsController(GetClub getclub)
        {
            _getClub = getclub;
        }

        // GET api/clubs/5
        public List<Club> GetAllClubs()
        {
            var c = new GetClub();

            var clubs = c.GetAllClubs();
            //var clubs = _getClub.GetAllClubs();

            return clubs;
        }

        public Club GetClub(int clubId)
        {
            var c = new GetClub();

            var club = c.GetClubDetails(clubId);
            
            return club;
        }

        // POST api/values
        public void UpdateClubMember(ClubMember clubMember)
        {

        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }
    }
}
