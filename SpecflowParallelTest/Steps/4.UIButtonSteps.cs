using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace DHAssignment.Steps
{
    [Binding]
    public class UIButtonSteps
    {
        private IWebDriver _driver;
        public UIButtonSteps(IWebDriver driver)
        {
            //Starting the chrome driver
            _driver = driver;
        }

        [When(@"I click on UI Testing Button")]
        public void WhenIClickOnUITestingButton()
        {
            //Click UI Testing button 
            Methods.Click(_driver, "site", "Id");
            Console.WriteLine("I am clicking the UI testing button");
        }

    }
}
