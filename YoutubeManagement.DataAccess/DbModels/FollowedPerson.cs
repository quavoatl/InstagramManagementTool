using System;

namespace InstaTool.DataAccess.DbModels
{
    public class FollowedPerson
    {
        public int Id { get; set; }
        public string FollowedPersonLinkString { get; set; }
        public DateTime FollowDate { get; set; }
        public string UserURL { get; set; }

        public Guid FollowedPersonLinkGUID
        {
            get { return Guid.Parse(FollowedPersonLinkString); }
            set { FollowedPersonLinkString = FollowedPersonLinkGUID.ToString("N"); }
        }
    }
}