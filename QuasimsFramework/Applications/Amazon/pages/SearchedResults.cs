using OpenQA.Selenium;
using QuasimsFramework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuasimsFramework.Applications.Amazon.pages
{
    public class SearchedResults
    {
        public Driver driver;

        public IWebElement SearchedResult => driver.driver.FindElement(By.XPath("//*[@id=\"search\"]/div[1]/div[1]/div/span[1]/div[1]/div[8]/div/div/div/div/div[2]/span/a/div/img"));

        public IWebElement AddToBasketButton => driver.driver.FindElement(By.XPath("//*[@id=\"add-to-cart-button\"]"));

        public SearchedResults(Driver driver)
        {
            this.driver = driver;
        }
    }
}
