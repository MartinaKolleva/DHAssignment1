using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DHAssignment.Steps
{
    [Binding]
    public class ErrorSteps
    {
        private IWebDriver _driver;
        public ErrorSteps(IWebDriver driver)
        {
            //Starting the chrome driver
            _driver = driver;
        }

        [When(@"I click on Error Button")]
        public void WhenIClickOnErrorButton()
        {
            //Click button Error
            Methods.Click(_driver, "error", "Id");
            Console.WriteLine("I am clicking the Error button");
        }
        

        [Then(@"I get HTTP error")]
        public void ThenIGetHTTPError()
        {
            Assert.IsTrue(Methods.IsElementPresent(_driver, By.XPath("//h1[contains(text(),'404 Error: File not found')]")));
            Console.WriteLine("Error 404 is displayed");
        }


    }
}
