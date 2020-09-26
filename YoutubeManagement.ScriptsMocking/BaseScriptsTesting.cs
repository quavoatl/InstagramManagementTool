using InstaTool.MainScripts.InstagramPages;
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
    }
}
