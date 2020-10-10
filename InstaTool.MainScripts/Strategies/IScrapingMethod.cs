using InstaTool.DataAccess.DbModels;
using InstaTool.MainScripts.InstagramPages;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

namespace InstaTool.MainScripts.Strategies
{
    public interface IScrapingMethod
    {
        ICollection<ScrapedUser> Scrape(List<string> userURLs, FirefoxDriver driver);
    }
}
