using QuasimsFramework.Applications.Amazon;
using QuasimsFramework.Applications.Amazon.pages;
using QuasimsFramework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using FluentAssertions;
using static System.Net.Mime.MediaTypeNames;

namespace QuasimsFramework.StepDefinitions
{
    [Binding]
    public class AmazonStepDefinitions

    {
        public Amazon _amazon;
        public Driver _driver;


        public AmazonStepDefinitions(Amazon amazon, Driver driver)
        {
            _amazon = amazon;
            _driver = driver;

        }




        [StepDefinition(@"I am on the Amazon Homepage")]
        public void GivenIAmOnTheAmazonHomepage()
        {
            _driver.initaliseDriver();
            _amazon.Homepage.CookiesButton.Click();

        }

        [StepDefinition(@"the Amazon logo will be visible")]
        public void ThenTheAmazonLogoWillBeVisible()
        {
            _amazon.Homepage.Logo.Displayed.Should().BeTrue();
        }

        /* [When(@"I search for {string}")]

         public void WhenISearchForAFootball(String text)
         {
             _amazon.Homepage.Searchbox.Click();
             _amazon.Homepage.Searchbox.SendKeys(text);


         } */

        [When(@"I search for ""([^""]*)""")]
        public void WhenISearchFor(string football)
        {


            _amazon.Homepage.Searchbox.Click();
            _amazon.Homepage.Searchbox.SendKeys(football);
            _amazon.Homepage.SearchButton.Click();

        }


        [Then(@"the header will return the searched term\.")]
        public void ThenTheHeaderWillReturnTheSearchedTerm()
        {
            _amazon.Homepage.FootballHeader.Displayed.Should().BeTrue();
        }

        [Given(@"I search for ""([^""]*)"" on the homepage")]
        public void GivenISearchForOnTheHomepage(string p0)

    
        {
            _driver.initaliseDriver();
            _amazon.Homepage.CookiesButton.Click();
            _amazon.Homepage.Searchbox.Click();
            _amazon.Homepage.Searchbox.SendKeys(p0);
            _amazon.Homepage.SearchButton.Click();
        }

        [When(@"I add the item that has been searched for to basket")]
        public void WhenIAddTheItemThatHasBeenSearchedForToBasket()
        {
            _amazon.SearchedResults.SearchedResult.Click();
            _amazon.SearchedResults.AddToBasketButton.Click();
        }

        [Then(@"I can validate that the item has been added to the basket")]
        public void ThenICanValidateThatTheItemHasBeenAddedToTheBasket()
        {
            _amazon.Homepage.BasketNumber.Displayed.Should().BeTrue();
        }

        [StepDefinition(@"I am on the Amazon Website")]
        public void GivenIAmOnTheAmazonWebsite()
        {
    
              _driver.initaliseDriver();
            _amazon.Homepage.CookiesButton.Click();

        }
        [When(@"I click the customer service button on the nav bar")]
        public void WhenIClickTheCustomerServiceButtonOnTheNavBar()
        {
            _amazon.Homepage.CustomerServicesTab.Click();
        }

        [Then(@"the ""([^""]*)"" tab will appear on the right hand side of the page")]
        public void ThenTheTabWillAppearOnTheRightHandSideOfThePage(string p0)
        {
            _amazon.Homepage.MusicHeader.Displayed.Should().BeTrue();
        }


    }

}
