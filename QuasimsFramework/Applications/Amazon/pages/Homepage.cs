using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using QuasimsFramework.Helpers;


namespace QuasimsFramework.Applications.Amazon.pages
{
    public class Homepage
    {
        private Driver Webdriver;
        public IWebElement Logo => Webdriver.driver.FindElement(By.Id("nav-logo-sprites"));
        public IWebElement Searchbox => Webdriver.driver.FindElement(By.Id("twotabsearchtextbox"));
        public IWebElement SearchButton => Webdriver.driver.FindElement(By.Id("nav-search-submit-button"));
        public IWebElement BasketButton => Webdriver.driver.FindElement(By.XPath("//*[@id=\"nav-cart-count-container\"]/span[2]"));

        public IWebElement CookiesButton => Webdriver.driver.FindElement(By.XPath("//*[@id=\"sp-cc-accept\"]"));

        public IWebElement FootballHeader => Webdriver.driver.FindElement(By.XPath("//span[contains(@class, 'a-color-state a-text-bold') and contains(.,'football')]"));

        public IWebElement BasketNumber => Webdriver.driver.FindElement(By.XPath("//*[@id=\"nav-cart-count\"]"));
        public Homepage(Driver driver)
        {
            Webdriver = driver;
        }

    }
   
}
