using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QuasimsFramework.Helpers
{
    public class Driver
    {
      public IWebDriver driver = new ChromeDriver();
        

     

        public void initaliseDriver()
        {
            driver.Navigate().GoToUrl("https://www.amazon.co.uk/");
        }
      
    }
}
