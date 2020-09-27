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
        private static User _loggedUser = null;

        public static bool AddInstagramAccount(InstagramAccount instagramAccount)
        {
            int res = 0;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                res = cnn.Execute("insert into InstagramAccount(EmailPhone, Password, FollowedPersonLinkString, LikedPersonLinkString, UserId) " +
                    "values (@EmailPhone, @Password, @FollowedPersonLinkString, @LikedPersonLinkString, @UserId)", instagramAccount);
            }
            if (res == 1) return true;
            else return false;
        }

        public static List<User> LoadUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var peopleOutput = cnn.Query<User>("select * from User", new DynamicParameters());
                return peopleOutput.ToList();
            }
        }

        public static void AddUser(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User(Username, Password) values (@Username, @Password)", user);
            }
        }

        public static void LoadUser(User user)
        {
            _loggedUser = user;
        }

        public static User GetLoggedUser()
        {
            return _loggedUser;
        }

        public static User GetUser(string user, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<User>($"select * from User where Username = '{user}' and Password = '{password}'").FirstOrDefault();
            }
        }

        public static InstagramAccount GetInstagramAccount(string EmailPhone)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<InstagramAccount>($"select * from InstagramAccount " +
                                                   $"where EmailPhone = '{EmailPhone}'").FirstOrDefault();
            }
        }

        public static ICollection<InstagramAccount> GetInstagramAccount(int userId)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<InstagramAccount>($"select A.EmailPhone from InstagramAccount as A " +
                                                   $"inner join User as B on A.UserId = B.Id " +
                                                   $"where A.UserId = '{userId}'").ToList();
            }
        }

        public static void AddFollowedPerson(FollowedPerson followedPerson)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into FollowedPerson(FollowedPersonLinkString, FollowDate, UserURL ) values (@FollowedPersonLinkString, @FollowDate, @UserURL)", followedPerson);
            }
        }

        public static ICollection<FollowedPerson> GetFollowedPersonsOfInstaAccount(string emailPhone)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<FollowedPerson>($"select * from FollowedPerson where EmailPhone = '{emailPhone}'").ToList();
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
