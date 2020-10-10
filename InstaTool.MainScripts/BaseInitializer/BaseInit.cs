using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace InstaTool.MainScripts.BaseInitializer
{
    public class BaseInit
    {
        private string _firefoxDriverPath = Path.Combine(projectFolder, @"driver").Replace("UIApp", "MainScripts");
        private static string projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.Replace("bin", "");

        private FirefoxDriver _instaDriver = null;
        public FirefoxDriver InstaDriver { get => _instaDriver; set => _instaDriver = value; }
        public List<FirefoxDriver> listOfFirefoxDrivers = null;

        public FirefoxDriver CreateAndOpenDriver()
        {
            var options = new FirefoxOptions();
            //options.AddArgument("-headless");
            _instaDriver = new FirefoxDriver(_firefoxDriverPath, options);
            _instaDriver.Manage().Window.Maximize();
            _instaDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            _instaDriver.Navigate().GoToUrl("https://www.instagram.com/");
            return _instaDriver;
        }

        public int GetNumberOfCores()
        {
            int coreCount = 0;
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            return coreCount;
        }

    }


}
