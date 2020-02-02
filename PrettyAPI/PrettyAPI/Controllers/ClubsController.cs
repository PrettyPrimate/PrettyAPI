﻿using System;
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

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}