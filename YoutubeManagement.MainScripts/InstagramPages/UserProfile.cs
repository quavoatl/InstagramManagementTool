using InstaTool.MainScripts.BaseInitializer;
using InstaTool.MainScripts.DriverHelpers;
using InstaTool.MainScripts.Logger;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;
using OpenQA.Selenium.Interactions;
using InstaTool.MainScripts.Strategies;
using InstaTool.DataAccess.DbModels;

namespace InstaTool.MainScripts.InstagramPages
{
    public class UserProfile : BaseInit
    {
        private IScrapingMethod _scrapingStrategy = null;
        private string _userProfileURL = string.Empty;

        public UserProfile(FirefoxDriver driver, string userProfile)
        {
            _userProfileURL = userProfile;
            InstaDriver = driver;
        }

        public bool Follow()
        {
            IWebElement followSucces = null;
            var followButton = InstaDriver.FindElementByXPath("//*[contains(@type,'button') and text() = 'Follow']");
            followButton.Click();

            try
            {
                followSucces = DriverExtensions.FindElement(InstaDriver, By.XPath("//*[contains(@type,'button') and text() = 'Message']"), 20);
                LogHelper.Log($"Succesfully followed {_userProfileURL}");
            }
            catch (Exception ex)
            {
                LogHelper.Log($"Failed to follow {_userProfileURL} ---- {ex.GetType()}");
            }

            if (followButton != null) return true;
            else return false;
        }

        public ICollection<ScrapedUser> ScrapeUsersByStrategy(int usersToScrape, IScrapingMethod scrapingStrategy)
        {
            IWebElement followersElement = InstaDriver.FindElementByXPath("//a[contains(@href,'followers')]");
            followersElement.Click();
            IWebElement mainList = InstaDriver.FindElementByXPath("//*[contains(@class,'isgrP')]");

            ScrollDown(30);

            var listOfURLs = new List<string>();

            foreach (var userElement in InstaDriver.FindElementsByXPath("//a[contains(@class,'_2dbep qNELH kIKUG')]"))
            {
                listOfURLs.Add(userElement.GetAttribute("href"));
            }

            LogHelper.Log($"Started to scrape users of {_userProfileURL}");

            InstaDriver.Quit();
            CreateDrivers();

            var scrapeListResult = scrapingStrategy.Scrape(listOfURLs, InstaDriver).ToList();

            if (scrapeListResult.Count != 0)
            {
                LogHelper.Log($"Scraped a number of {scrapeListResult.Count} users");
                LogHelper.Log($"Scraped users are available to export in the dropdown below");
            }
            else
            {
                LogHelper.Log($"{scrapeListResult.Count} users scraped");
            }

            return scrapeListResult;
        }













        private void ScrollDown(int seconds)
        {
            Stopwatch s = new Stopwatch();
            s.Start();
            while (s.Elapsed < TimeSpan.FromSeconds(seconds))
            {
                var listOfaccs = InstaDriver.FindElementsByXPath("//a[contains(@class,'_2dbep qNELH kIKUG')]");
                var lastElement = listOfaccs[listOfaccs.Count - 2];
                InstaDriver.ExecuteScript("arguments[0].scrollIntoView(true);", lastElement);
            }
            s.Stop();
        }
    }
}
