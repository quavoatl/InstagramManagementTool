using System;
using System.Collections.Generic;
using System.Text;

namespace InstaTool.DataAccess.DbModels
{
    public class InstagramAccount
    {
        public int Id { get; set; }
        public string EmailPhone { get; set; }
        public string Password { get; set; }
        public string FollowedPersonLinkString { get; set; } // acts as FK to FollowedPerson
        public string LikedPersonLinkString { get; set; } // acts as FK to LikedPerson
        public int UserId { get; set; } //acts as FK to UserClass

        ICollection<FollowedPerson> FollowedPerson { get; set; }
        ICollection<LikedPerson> LikedPerson { get; set; }


        #region GUID accessors
        public Guid FollowedPersonLinkGUID
        {
            get { return Guid.Parse(FollowedPersonLinkString); }
            set { FollowedPersonLinkString = FollowedPersonLinkGUID.ToString("N"); }
        }

        public Guid LikedPersonLinkGUID
        {
            get { return Guid.Parse(LikedPersonLinkString); }
            set { LikedPersonLinkString = LikedPersonLinkGUID.ToString("N"); }
        }
        #endregion



    }
}
