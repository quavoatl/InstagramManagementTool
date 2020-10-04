using InstaTool.DataAccess.DbModels;
using InstaTool.MainScripts.DriverHelpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaTool.MainScripts.Strategies
{
    public class ScrapeByNumberOfFollowers : IScrapingMethod
    {
        private int minFollowersCount = 0;
        private int maxFollowersCount = 0;
        private int minFollowingCount = 0;
        private int maxFollowingCount = 0;

        public ScrapeByNumberOfFollowers(FollowSpecifications fFpecs)
        {
            minFollowersCount = fFpecs.MinFollowers;
            maxFollowersCount = fFpecs.MaxFollowers;
            minFollowingCount = fFpecs.MinFollowing;
            maxFollowingCount = fFpecs.MaxFollowing;
        }

        public ICollection<ScrapedUser> Scrape(List<string> userURLs, FirefoxDriver driver)
        {
            int nrOfFollowers = 0;
            int nrOfFollowing = 0;

            var resultsOfThisScraping = new List<ScrapedUser>();




            foreach (var url in userURLs)
            {
                driver.Navigate().GoToUrl(url);

                try
                {
                    nrOfFollowers = int.Parse(driver.FindElementByXPath("//a[contains(@href,'followers')]/span").GetAttribute("title").Replace(",", ""));
                }
                catch (Exception ex)
                {
                    //for private profiles where followers is not clickable
                    nrOfFollowers = int.Parse(driver.FindElementsByXPath("//*[contains(@class,'g47SY ')]")[1].Text.Replace(",", ""));
                }

                try
                {
                    nrOfFollowing = int.Parse(driver.FindElementByXPath("//a[contains(@href,'following')]/span").GetAttribute("title").Replace(",", ""));
                }
                catch (Exception ex)
                {
                    //for private profiles where following is not clickable
                    nrOfFollowing = int.Parse(driver.FindElementsByXPath("//*[contains(@class,'g47SY ')]")[2].Text.Replace(",", ""));
                }

                if (nrOfFollowers >= minFollowersCount && nrOfFollowers <= maxFollowersCount &&
                    nrOfFollowing >= minFollowingCount && nrOfFollowing <= maxFollowingCount)
                {
                    bool isAccountPrivate = false;
                    IWebElement accountPrivateElement = null;
                    try
                    {
                        accountPrivateElement = driver.FindElementByXPath("//h2[contains(@class,'rkEop')]");
                        if (accountPrivateElement != null) isAccountPrivate = true;
                    }
                    catch (Exception ex) { }

                    string descOfUser = string.Empty;
                    try
                    {
                        descOfUser = driver.FindElementByXPath("//*[contains(@class,'-vDIg')]/span").Text;
                    }
                    catch (Exception ex)
                    {
                        // this user doesnt have a desc
                        descOfUser = "NO DESCRIPTION";
                    }

                    resultsOfThisScraping.Add(new ScrapedUser()
                    {
                        UserURL = url,
                        Description = descOfUser,
                        IsPrivate = isAccountPrivate
                    });

                    nrOfFollowers = 0;
                    nrOfFollowing = 0;
                }
            }

            return resultsOfThisScraping;
        }


        

        
    }
}
