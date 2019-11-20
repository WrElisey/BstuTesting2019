using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace wd
{
    class Program
    { 
        static void Main(string[] args)
        {
            WebDriverTest a = new WebDriverTest();
            a.Setup();
            a.CheckAddingToCart();
        }
    }
}

