using InstaTool.MainScripts.BaseInitializer;
using InstaTool.MainScripts.DriverHelpers;
using InstaTool.MainScripts.InstagramPages;
using InstaTool.MainScripts.Logger;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace InstaTool.MainScripts.YoutubeUpload
{
    public class Login : BaseInit
    {
        private readonly FirefoxDriver driver = null;

        public Login()
        {
            BaseInit baseDriver = new BaseInit();
            InstaDriver = baseDriver.CreateAndOpenDriver();
        }

        public Home PerformLogin(string emailOrPhone, string password)
        {
            try
            {
                IWebElement loginEmail = InstaDriver.FindElementByXPath("//*[contains(@aria-label,'Phone number, username, or email')]");
                loginEmail.SendKeys(emailOrPhone);

                IWebElement loginPassword = InstaDriver.FindElementByXPath("//*[contains(@aria-label,'Password')]");
                loginPassword.SendKeys(password);

                IWebElement loginButton = InstaDriver.FindElementByXPath("//*[contains(@type,'submit')]");
                loginButton.Click();

                if (CheckIsLoggedIn())
                {
                    IWebElement saveLoginInfo = DriverExtensions.FindElement(InstaDriver, By.XPath("//*[contains(@class,'sqdOP yWX7d    y3zKF     ')]"), 20);
                    saveLoginInfo.Click();


                    IWebElement turnOnNotifications = DriverExtensions.FindElement(InstaDriver, By.XPath("//*[contains(@class,'aOOlW   HoLwm ')]"), 20);
                    turnOnNotifications.Click();

                    LogHelper.Log("Succesfully logged in");

                    return new Home(InstaDriver);
                }
            }
            catch(Exception ex)
            {
                LogHelper.Log($"Succesfully logged in, {ex.GetType()}");
            }
            return null;
        }

        public bool CheckIsLoggedIn()
        {
            IWebElement searchBar = null;
            int maxRetry = 10;

            while (searchBar ==null &&  maxRetry > 0)
            {
                searchBar = InstaDriver.FindElementByXPath("//*[contains(@class,'LWmhU _0aCwM')]");
                maxRetry--;
            }

            if (searchBar != null) return true;
            else return false;
        }

       


       

    }
}
