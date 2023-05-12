using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Extensions;
using Gherkin.CucumberMessages.Types;
using LivingDoc.Dtos;
using NUnit.Framework;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace QuasimsFramework.Helpers
{
    public class Driver
    {
      public IWebDriver driver { get; set; }

        
        
     

        public void BrowserTypeSwitch(string browserType, Boolean remoteExecution)
        {
            if (remoteExecution == true)
            {

                if (browserType.Equals("Chrome"))
                {
                   
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--start-maximized");
                    driver = new RemoteWebDriver(options);

                }
                else if (browserType.Equals("Edge"))
                {
                    EdgeOptions options = new EdgeOptions();
                    options.AddArgument("--start-maximized");

                    driver = new RemoteWebDriver(options);
                }
            }

            else
            {
                if (browserType.Equals("Chrome"))
                {
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--start-maximized");
                    driver = new ChromeDriver(options);

                }
                else if (browserType.Equals("Edge"))
                {
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig(), VersionResolveStrategy.MatchingBrowser);
                    EdgeOptions options = new EdgeOptions();
                    options.AddArgument("--start-maximized");

                    driver = new EdgeDriver(options);
                }

            }
        }

        public void InitialiseDriver(string url)
        {
             driver.Navigate().GoToUrl(url);
        }

        public void TakeScreenShot(string name)
        {
            var screenshot = driver.TakeScreenshot();
            var filePath =$"C:\\Users\\qas.khan\\source\\repos\\QuasimsFramework\\QuasimsFramework\\Screenshot\\{name}.png";
            screenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
           

        }
      
    }
}
