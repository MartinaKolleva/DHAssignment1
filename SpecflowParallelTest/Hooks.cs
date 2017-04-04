using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace DHAssignment
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;

        public Hooks (IObjectContainer objectContainer) 
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void Initialize()
        {   //_driver = new FirefoxDriver();
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);

        }
        [AfterScenario]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
 }



