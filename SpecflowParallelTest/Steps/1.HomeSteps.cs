using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DHAssignment.Steps

{
    [Binding]
    public class HomeSteps
    {
        private IWebDriver _driver;
        public HomeSteps(IWebDriver driver)
            {
                //Starting the chrome driver
                _driver = driver;
            }

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
                //Go to application
                _driver.Navigate().GoToUrl("http://uitest.duodecadits.com");
                Console.WriteLine("I enter application");
        }

        [When(@"I click on Home Button")]
        public void WhenIClickOnHomeButton()
            {
            //first click button Form, then click button Home
            Methods.Click(_driver, "form", "Id");
            Methods.Click(_driver, "home", "Id");
            Console.WriteLine("I am clicking the Home button");
            }

         [Then(@"Home button becomes active")] 
        public void ThenHomeButtonBecomesActive()
        {
            //Check that Home button is Active
            _driver.FindElement(By.XPath("//li[@class='active' and a/@id='home']"));
            Console.WriteLine("Home tab is Active");
        }

        [Then(@"I am navigated to Home Page")] 
        public void ThenIAmNavigatedToHomePage()
        {
            Assert.IsTrue(_driver.Url.Equals("http://uitest.duodecadits.com/"));
            Console.WriteLine("Current page is Home Page");
        }

        [Then(@"the Title is UI Testing Site")]
        public void ThenTheTitleIsUITestingSite()
        {
            Assert.That(_driver.Title.Equals("UI Testing Site"), Is.EqualTo(true),
            "The page title is not UI Testing Site");
            Console.WriteLine("The page title is UI Testing Site");
        }

        [Then(@"the Company Logo is visible")]
        public void ThenTheCompanyLogoIsVisible()
        {
            Assert.IsTrue(Methods.IsElementPresent(_driver, By.Id("dh_logo")));
            Console.WriteLine("The logo is present");
        }

        [Then(@"Welcome text is displayed")]
        public void ThenWelcomeTextIsDisplayed()
        {
            Assert.IsTrue(Methods.IsElementPresent(_driver, By.XPath("//h1[contains(text(),'Welcome to the Docler Holding QA Department')]")));
            Console.WriteLine("Welcome text is displayed");
        }

        [Then(@"Description text is in p tag")]
        public void ThenDescriptionTextIsInPTag()
        {
            Assert.IsTrue(Methods.IsElementPresent(_driver, By.XPath("//p[contains(text(),'This site is dedicated to perform some exercises and demonstrate automated web testing.')]")));
            Console.WriteLine("Description text is displayed");
        }

    }
}
