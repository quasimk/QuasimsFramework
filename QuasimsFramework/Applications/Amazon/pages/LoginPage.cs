using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports.Gherkin.Model;
using OpenQA.Selenium;
using QuasimsFramework.Helpers;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;

namespace QuasimsFramework.Applications.Amazon.pages
{
    public class LoginPage
    {
        public Driver driver;

        public IWebElement Logo => driver.driver.FindElement(By.XPath("//*[@id=\"a-page\"]/div[1]/div[1]/div/a/i[1]"));
        public IWebElement Textbox => driver.driver.FindElement(By.Id("ap_email"));
        public IWebElement ContinueButton => driver.driver.FindElement(By.XPath("//*[@id=\"continue\"]"));
        public LoginPage(Driver driver)
        {
            this.driver = driver;
        }
       

    }
}
