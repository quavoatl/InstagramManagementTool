using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace InstaTool.MainScripts.BaseInitializer
{
    public class BaseInit
    {
        private readonly string _firefoxDriverPath = @"C:\Users\seantal\source\repos\yt\YoutubeManagement.MainScripts\driver";

        private FirefoxDriver _instaDriver = null;
        public FirefoxDriver InstaDriver { get => _instaDriver; set => _instaDriver = value; }

        public FirefoxDriver CreateAndOpenDriver()
        {
            ThreadLocal<FirefoxDriver> drivers = new ThreadLocal<FirefoxDriver>();
            var options = new FirefoxOptions();
            options.AddArgument("-headless");
            _instaDriver = new FirefoxDriver(_firefoxDriverPath, options);
            _instaDriver.Manage().Window.Maximize();
            _instaDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            _instaDriver.Navigate().GoToUrl("https://www.instagram.com/");
            return _instaDriver;
        }


    }


}
