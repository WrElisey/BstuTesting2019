using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using System.Threading;

namespace wd
{
    public static class CartPage
    {
        public static string pageUrl = "https://amasty.com/";
        public static string pageUrlCart = "https://amasty.com/checkout/cart/";

        public static string searchInputTagId = "search";
        public static string firstProductPath = "//*[@class='am_element']";
        public static string addToCartButtonPath = "//*[@class='am-button btn-cart']";
        public static string viewToCartButtonPath = "//*[@data-metrics-element='cart-popup-view-cart']";
        public static string firstProductInCartPath = "//*[@class='product-name']/a[1]";

        public static void AddToCart(string searchKey, IWebDriver driver)
        {
            driver.Navigate().GoToUrl(MainPage.pageUrl);
            IWebElement searchElement = driver.FindElement(By.Id(searchInputTagId));
            SlowType(searchElement, searchKey);
            Thread.Sleep(3000);

            driver.FindElement(By.XPath(firstProductPath)).Click();
            Thread.Sleep(3000);

            driver.FindElement(By.XPath(addToCartButtonPath)).Click();
            Thread.Sleep(3000);
        }

        public static string CheckAddingToCart(string searchKey, IWebDriver driver)
        {
            AddToCart(searchKey, driver);
            driver.Navigate().GoToUrl(pageUrlCart);
            Thread.Sleep(3000);
            IWebElement webElement = driver.FindElement(By.CssSelector(".cart-table .product-name > a"));
            return webElement.Text;
        }

        public static void SlowType(IWebElement webElement, string text)
        {
                webElement.Click();
                webElement.Clear();
                foreach (var key in text)
                {
                    webElement.SendKeys(key.ToString());
                    Thread.Sleep(150);
                }
        }
    }

}
