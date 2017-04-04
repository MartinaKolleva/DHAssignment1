//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;

//namespace DHAssignment.Pages
//{
//    class DHPageObject
//    {
//        private IWebDriver _driver;

//        public DHPageObject(IWebDriver driver)
//        {
//            _driver = driver;
//            PageFactory.InitElements(_driver, this);
//        }

//        [FindsBy(How = How.Id, Using = "UITesting")]
//        public IWebElement UITesting { get; set; }

//        [FindsBy(How = How.Id, Using = "HomeTab")]
//        public IWebElement HomeTab { get; set; }

//        [FindsBy(How = How.Id, Using = "FormTab")]
//        public IWebElement FormTab { get; set; }

//        [FindsBy(How = How.Id, Using = "ErrorTab")]
//        public IWebElement ErrorTab { get; set; }
//    }
//}
