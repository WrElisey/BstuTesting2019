using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;

namespace wd
{
    public static class MainPage
    {
        public static string pageUrl = "https://www.amasty.com/";
        public static string searchInputTagId = "search";
        public static string firstProductPath = "//*[@class='amhighlight']";

        public static string GetSearchFieldValue(string productName, IWebDriver driver)
        {
            driver.Navigate().GoToUrl(pageUrl);
            IWebElement searchElement = driver.FindElement(By.Id(searchInputTagId));
            CartPage.SlowType(searchElement, productName);
            Thread.Sleep(3000);

            string prductTitle = driver.FindElement(By.XPath(firstProductPath)).Text;
            return prductTitle;
        }
    }

}
