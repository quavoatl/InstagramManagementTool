using InstaTool.DataAccess.DatabaseConn;
using InstaTool.DataAccess.DbModels;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaTool.ScriptsMocking
{
    public class DbQueriesTesting
    {

        [Test]
        public void RetrieveUsers()
        {
            var people = SQLiteDatabaseAccess.LoadUsers();

        }

        [Test]
        public void AddUser()
        {
            User user = new User()
            {
                Username = "cacat",
                Password = "pisat",
            };

            SQLiteDatabaseAccess.AddUser(user);
        }

        [Test]
        public void AddFollowedPerson()
        {
            var user = SQLiteDatabaseAccess.GetUser("morti", "mati");
            var instagramAccount = SQLiteDatabaseAccess.GetInstagramAccount("0765835785");

            FollowedPerson followedPerson = new FollowedPerson()
            {
              FollowedPersonLinkString = instagramAccount.FollowedPersonLinkString,
              FollowDate = DateTime.Now,
              UserURL = "https://www.instagram.com/cacat.la_punga/"
            };

            SQLiteDatabaseAccess.AddFollowedPerson(followedPerson);
        }

        [Test]
        public void GetListOfFollowedPersons()
        {
            var list = SQLiteDatabaseAccess.GetFollowedPersonsOfInstaAccount("0765835785");

        }
    }
}
