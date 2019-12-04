using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectLab.PageObjects;

namespace PageObjectLab
{
    public class PageObjectTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("D:\\bstu2019\\testing_webdrive");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

        [Test]
        public void Change—urrencyOnProductPage()
        {
            var productsPage = new ProductsPage(driver);
            productsPage.GoToPage();
            float oldPrice = productsPage.getPriceProducts();
            productsPage.Change—urrency();
            float newPrice =  productsPage.getPriceProducts();

            Assert.IsTrue(oldPrice != newPrice);
        }

        [Test]
        public void CheckChallengesPage()
        {
            var challengesPage = new ChallengesPage(driver);
            challengesPage.GoToPage();
            var existAllElements = challengesPage.CheckExistAllElements();
            Assert.IsTrue(existAllElements);
        }
    }
}