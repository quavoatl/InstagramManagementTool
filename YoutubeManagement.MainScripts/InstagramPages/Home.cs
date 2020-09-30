using InstaTool.MainScripts.BaseInitializer;
using InstaTool.MainScripts.DriverHelpers;
using InstaTool.MainScripts.Logger;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InstaTool.MainScripts.InstagramPages
{
    public class Home : BaseInit
    {
        public Home(FirefoxDriver driver)
        {
            InstaDriver = driver;
        }

        public UserProfile GoToUserProfile(string stringToSearch = "", bool isGoByURL = false)
        {
            UserProfile userProfile = null;

            if (isGoByURL)
            {
                try
                {
                    InstaDriver.Navigate().GoToUrl(stringToSearch);
                    userProfile = new UserProfile(InstaDriver, InstaDriver.Url);
                    LogHelper.Log($"Succesfully navigated to user profile {stringToSearch}");
                }
                catch (Exception ex)
                {
                    LogHelper.Log($"Failed to navigate to user profile {stringToSearch}");
                }

            }
            else
            {
                try
                {
                    if (stringToSearch != string.Empty)
                    {
                        IWebElement searchBar = InstaDriver.FindElementByXPath("//*[contains(@placeholder,'Search')]");
                        searchBar.SendKeys(stringToSearch);

                        IWebElement firstResultFromList = DriverExtensions.FindElements(InstaDriver, By.XPath("//*[contains(@class,'yCE8d  ')]"), 20)[0];
                        firstResultFromList.Click();

                        userProfile = new UserProfile(InstaDriver, InstaDriver.Url);
                        LogHelper.Log($"Succesfully navigated to user profile {stringToSearch}");
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Log($"Failed to navigate to user profile {stringToSearch}");
                }
            }

            return userProfile;
        }



    }
}
