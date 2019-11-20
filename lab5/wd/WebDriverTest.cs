using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace wd
{
    class WebDriverTest
    {
        private IWebDriver _driver;
        private string _searchKey;
        private string _productName;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver("D:\\bstu2019\\testing_webdrive");
            _searchKey = "Checkout";
            _productName = "One Step Checkout for Magento 2";
        }

        [Test]
        public void CheckSearchField()
        {
            string searchFieldValue = MainPage.GetSearchFieldValue(_searchKey, _driver);
            bool expected = searchFieldValue == _productName;
            Assert.IsTrue(expected);
        }

        [Test]
        public void CheckAddingToCart()
        {
            string productTitle = CartPage.CheckAddingToCart(_searchKey, _driver);
            bool expected = productTitle == _productName;
            Assert.IsTrue(expected);
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }

    }
}
