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
    public class FormSteps
    { 
        private IWebDriver _driver;
    public FormSteps(IWebDriver driver)
    {
        //Starting the chrome driver
        _driver = driver;
    }
    
        [When(@"I click on Form Button")]
        public void WhenIClickOnFormButton()
        {
           //Click button Form
           Methods.Click(_driver, "form", "Id");
           Console.WriteLine("I am clicking the Form button");  
        }

        [Then(@"Form button becomes active")]
        public void ThenFormButtonBecomesActive()
        {
            //Check that Form button is Active
            _driver.FindElement(By.XPath("//li[@class='active' and a/@id='form']"));
            Console.WriteLine("Form tab is Active");
        }


        [Then(@"I am navigated to Form Page")]
        public void ThenIAmNavigatedToFormPage()
        {
            Assert.IsTrue(_driver.Url.Equals("http://uitest.duodecadits.com/form.html"));
            Console.WriteLine("Current page is Form Page");
        }

        [Then(@"there is an Input Box")]
        public void ThenThereIsAnInputBox()
        {
            Assert.IsTrue(Methods.IsElementPresent(_driver, By.Id("hello-input"))); 
            Console.WriteLine("Input field is available");
        }

        [Then(@"there is a Submit Button")]
        public void ThenThereIsASubmitButton()
        {
            Assert.IsTrue(Methods.IsElementPresent(_driver, By.Id("hello-submit"))); 
            Console.WriteLine("Submit button is available");
        }

    }
}


            