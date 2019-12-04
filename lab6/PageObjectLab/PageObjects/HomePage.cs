using OpenQA.Selenium;

namespace PageObjectLab.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver; 
        
        private string homeUrl = "https://amasty.com/";
        private string menuItemSelector = "#main-sidebar .item-wrapper";

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(homeUrl);
        }

        public void GoWithMenu(int number)
        {
            var selector = menuItemSelector + ":nth-child(" + number + ") > .item";
            var menuItem = driver.FindElement(By.CssSelector(selector));
            menuItem.Click();
        }
    }
}
