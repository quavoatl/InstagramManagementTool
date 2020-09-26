using Dapper;
using InstaTool.DataAccess.DbModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;

namespace InstaTool.DataAccess.DatabaseConn
{
    public class SQLiteDatabaseAccess
    {
        public static List<User> LoadUsers()
        {

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var peopleOutput = cnn.Query<User>("select * from User", new DynamicParameters());
                return peopleOutput.ToList();
            }
        }

        public static void SaveUser(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User(Username, Password, FollowedPersonLinkString) values (@Username, @Password, @FollowedPersonLinkString)", user);
            }
        }

        public static User GetUser(string user, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<User>($"select * from User where Username = '{user}' and Password = '{password}'").FirstOrDefault();
            }
        }

        public static void SaveFollowedPerson(FollowedPerson followedPerson)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into FollowedPerson(FollowedPersonLinkString, FollowDate, UserURL ) values (@FollowedPersonLinkString, @FollowDate, @UserURL)", followedPerson);
            }
        }

        public static ICollection<FollowedPerson> GetFollowedPersonsOfUser(int userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var user = cnn.Query<User>($"select * from User where Id = '{userId}'").FirstOrDefault();


                return cnn.Query<FollowedPerson>($"select A.Id, A.UserURL, A.FollowDate, A.FollowedPersonLinkString from FollowedPerson as A " +
                                                 $"inner join User as B on A.FollowedPersonLinkString = B.FollowedPersonLinkString").ToList();
            }
        }

        #region Private Sensitive Methods

        private static string LoadConnectionString()
        {
            string path = string.Empty;

            var res = TryGetSolutionDirectoryInfo().FullName;
            var result = Directory.GetDirectories(res, "*DataAccess*");
            DirectoryInfo df = new DirectoryInfo(result[0]);

            return "Data Source=" + df.GetFiles("*ModelsDb.db*").FirstOrDefault().FullName;
        }

        private static DirectoryInfo TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            var directory = new DirectoryInfo(currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }

        #endregion

    }
}
