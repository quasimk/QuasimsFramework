using AventStack.ExtentReports.Reporter;
using BoDi;
using OpenQA.Selenium.Support.Extensions;
using QuasimsFramework.Applications.Amazon;
using QuasimsFramework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace QuasimsFramework.StepDefinitions.Hooks


{
    [Binding]
    
   class Runner
    {

        Driver _driver;
        IObjectContainer _objectContainer;
        ScenarioContext _scenarioContext;
        static AventStack.ExtentReports.ExtentReports extent;
        static AventStack.ExtentReports.ExtentTest feature;
        AventStack.ExtentReports.ExtentTest scenario,step;

        static string reportpath = System.IO.Directory.GetParent(@"../../../").FullName
            + Path.DirectorySeparatorChar + "Result"
            + Path.DirectorySeparatorChar + "Result_" + DateTime.Now.ToString("ddMMyyy HHmmss");

        public Runner(IObjectContainer objectContainer, Driver driver, ScenarioContext scenarioContext)
        {
            _driver = driver;
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]

        public static void BeforeTestRun()
        {
            ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(reportpath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlreport);
        }
        [BeforeFeature]

        public static void BeforeFeature(FeatureContext context)
        {
            feature = extent.CreateTest(context.FeatureInfo.Title);

        }
        [BeforeScenario]
        public void BeforeScenario(ScenarioContext context) 
        { 
        
            

            scenario = feature.CreateNode(context.ScenarioInfo.Title);
            _driver.BrowserTypeSwitch("Edge",false);
            _driver.InitialiseDriver("https://www.amazon.co.uk");
            _objectContainer.RegisterInstanceAs<Amazon>(new Amazon(_driver));

        }
        [BeforeStep]
        public void BeforeStep()
        {
            step = scenario;
        }
        [AfterStep]
        public void AfterStep( ScenarioContext context)
        {
            if (context.TestError == null)
            {
                step.Log(AventStack.ExtentReports.Status.Pass, context.StepContext.StepInfo.Text);
            }
            else if (context.TestError  != null)
            {
                step.Log(AventStack.ExtentReports.Status.Fail, context.StepContext.StepInfo.Text);
                string screenShot =_driver.driver.TakeScreenshot().AsBase64EncodedString; 
                step.AddScreenCaptureFromBase64String(screenShot);
                string escapedStepName = Uri.EscapeDataString(context.StepContext.StepInfo.Text + DateTime.Now.ToString("dd MM HH mm ss ff"));
                _driver.TakeScreenShot(escapedStepName);
            }
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            extent.Flush();

        }



    }
}
