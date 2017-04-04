using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace DHAssignment.Steps
{
    [Binding]
        public class ExampleSteps
    {
        private IWebDriver _driver;
        public ExampleSteps(IWebDriver driver)
        {
             //Starting the chrome driver
             _driver = driver;
        }
        [Given(@"I click on Form Button")]
        public void GivenIClickOnFormButton()
        {
            //Click button Form
            Methods.Click(_driver, "form", "Id");
            Console.WriteLine("I am clicking the Form button");
        }

        [Given(@"I type (.*)")] 
        public void GivenIType(string value)
        {
            Methods.EnterText(_driver, "hello-input", value, "Id");
            Console.WriteLine("I enter: " + value);
        }
        
        [Given(@"I click Submit Button")]
        public void GivenIClickSubmitButton()
        {
            Methods.Click(_driver, "hello-submit", "Id");
            Console.WriteLine("Click GO");
        }

        [Then(@"I am navigated to Hello Page")]
        public void ThenIAmNavigatedToHelloPage()
        {
           Assert.IsTrue(_driver.Url.Contains("http://uitest.duodecadits.com/hello.html?myName="));
           Console.WriteLine("Current page is Hello Page");
        }

        [Then(@"(.*) is shown")] //in progress
        public void ThenIsShown(string result)
        {
            var element = _driver.FindElement(By.XPath("//*[@id='hello-text']"));
            if (element.Text == result)
                return;
            Console.WriteLine(element.Text);
        }

    }
}
