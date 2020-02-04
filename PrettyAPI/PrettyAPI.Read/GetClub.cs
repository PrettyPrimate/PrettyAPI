using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrettyAPI.Read.Models;

namespace PrettyAPI.Read
{
    public class GetClub
    {
        public List<Club> GetAllClubs()
        {
            return new List<Club>()
            {
                new Club() { AddressLine1 = "28 Laurel", ClubId = 1, ClubName = "Home", Town = "Rainham", Postcode = "ME88HU"},
                new Club() { AddressLine1 = "12 Union Street", ClubId = 2, ClubName = "Work", Town = "Maidstone", Postcode = "ME12JJ"}
            };
        }

        public Club GetClubDetails(int clubId)
        {
            var clubs = new List<Club>()
            {
                new Club() { AddressLine1 = "28 Laurel", ClubId = 1, ClubName = "Home", Town = "Rainham", Postcode = "ME88HU"},
                new Club() { AddressLine1 = "12 Union Street", ClubId = 2, ClubName = "Work", Town = "Maidstone", Postcode = "ME12JJ"}
            };

            var club = clubs.SingleOrDefault(x => x.ClubId == clubId);

            return club;
        }

        public List<ClubMember> GetClubMembers(int clubId)
        {
            return new List<ClubMember>();
        }

        public ClubMember GetClubMember(int clubMemberId)
        {
            return new ClubMember();
        }

        public string SqlTest()
        {
            var clubList = new List<Club>();

            var cb = new SqlConnectionStringBuilder
            {
                DataSource = "wfreportingprod.database.windows.net",
                UserID = "wfandco",
                Password = "SimonSays23",
                InitialCatalog = "WFExternalData"
            };

            using (var connection = new SqlConnection(cb.ConnectionString))
            {
                connection.Open();

                string tsql = GetClubsSql();

                using (var command = new SqlCommand(tsql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var data = new Club()
                            {
                                //WatchId = reader.GetInt32(0),
                                //ViewCount = reader.GetInt32(1),
                                //SiteId = reader.GetInt32(2)
                            };

                            clubList.Add(data);
                        }
                    }
                }
                connection.Close();
            }

            return "";
        }

        static string GetClubsSql()
        {
            return $@"select watchid, count(watchid) as viewcount, isnull([site],0)
                    from [dbo].[CustomerViews2]
                    where ip != '92.207.184.194' and action = 'View'
                    
                    group by watchid, [site]
                    order by viewcount desc";
        }

        /*
         *  peta poco
         * install nuget
         * open connection
         * close
         * dispose
         * fetch
         * model
         * 
         */
    }
}
