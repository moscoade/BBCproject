using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BBCProject.Hooks
{
    [Binding]
    public class SearchHook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
           driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Manage().Window.Maximize();
        }

        

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}