using InstaTool.MainScripts.InstagramPages;
using InstaTool.MainScripts.Strategies;
using NUnit.Framework;
using System;

namespace InstaTool.ScriptsMocking
{
    public class BaseScriptsTesting
    {
        [Test]
        public void Login()
        {
            var ig = new Login();
            var homepage = ig.PerformLogin("0765835785", "qazwsxedc123!");
            var userProfile = homepage.GoToUserProfile("banankothebudgie");
            var result = userProfile.Follow();
            Assert.IsTrue(result);
        }

        [Test]
        public void testscrape()
        {
            var ig = new Login();
            var homepage = ig.PerformLogin("0765835785", "qazwsxedc123!");
            var userProfile = homepage.GoToUserProfile("babytiana.maria");
            var result = userProfile.ScrapeUsersByStrategy(1, new ScrapeByNumberOfFollowers(100, 2000));
        }



    }
}
