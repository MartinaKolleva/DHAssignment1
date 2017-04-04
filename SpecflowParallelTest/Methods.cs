using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace DHAssignment
{
    class Methods
    {
        //Enter text
        public static void EnterText(IWebDriver _driver,string element, string value, string elementtype)
        {
             if (elementtype == "Id")
                _driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                _driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementtype == "XPath")
                _driver.FindElement(By.XPath(element)).SendKeys(value);
        }

        //Click button. Note: I use submit, because click did not work
        public static void Click(IWebDriver _driver, string element, string elementtype)
        {
             if (elementtype == "Id")
                _driver.FindElement(By.Id(element)).Click();
             if (elementtype == "Name")
                _driver.FindElement(By.Name(element)).Submit();  
             if (elementtype == "XPath")
                _driver.FindElement(By.XPath(element)).Submit();
        }

        //Verify that element exists
        public static bool IsElementPresent(IWebDriver _driver, By by)
        {
            try
            {
                _driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}
