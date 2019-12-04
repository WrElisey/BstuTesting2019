using OpenQA.Selenium;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace PageObjectLab.PageObjects
{
    public class ProductsPage
    {
        private IWebDriver driver;
        private string homeUrl = "https://amasty.com/magento-2-extensions.html";
        private string currencySelector = ".currency-list a[title='Euro']";
        private string priceBoxSelector = ".module:nth-child(1) .price";

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public float getPriceProducts()
        {
            var productPrice = driver.FindElement(By.CssSelector(priceBoxSelector));
            var text = productPrice.Text;
            var price = Regex.Replace(text, @"\D+", "", RegexOptions.ECMAScript);
            return float.Parse(price); 
        }

        public void ChangeСurrency()
        {
            var currency = driver.FindElement(By.CssSelector(currencySelector));
            var url = currency.GetAttribute("href");
            driver.Navigate().GoToUrl(url);
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(homeUrl);
        }
    }
}
