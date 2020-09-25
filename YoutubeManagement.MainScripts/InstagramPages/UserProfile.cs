using InstaTool.MainScripts.BaseInitializer;
using InstaTool.MainScripts.DriverHelpers;
using InstaTool.MainScripts.Logger;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaTool.MainScripts.InstagramPages
{
    public class UserProfile : BaseInit
    {
        private string _userProfileURL = string.Empty;
        public UserProfile(FirefoxDriver driver,string userProfile)
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
            catch(Exception ex)
            {
                LogHelper.Log($"Failed to follow {_userProfileURL} ---- {ex.GetType()}");
            }

            if (followButton != null) return true;
            else return false;
        }
    }
}
