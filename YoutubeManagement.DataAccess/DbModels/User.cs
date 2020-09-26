using System;
using System.Collections.Generic;
using System.Text;

namespace InstaTool.DataAccess.DbModels
{
    public class User
    {
        public int Id { get; set; }
        public string FollowedPersonLinkString { get; set; } // acts as FK to 
        public string Username { get; set; } 
        public string Password { get; set; }

        public Guid FollowedPersonLinkGUID
        {
            get { return Guid.Parse(FollowedPersonLinkString); }
            set { FollowedPersonLinkString = FollowedPersonLinkGUID.ToString("N"); }
        }

        ICollection<FollowedPerson> FollowedPerson { get; set; }
    }
}
