using BBCProject.Hooks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BBCProject.PageObject
{
   class AutomationPage
   {
        public IWebDriver driver;
        private By searchBBC = By.XPath("//*[text()='Search BBC']");
        private By searchField = By.Id("search-input");
        private By search = By.XPath("(//*[@class='ssrcss-xi5oyi-StyledIcon e6m7o991'])[17]");
        private By sportDly = By.CssSelector("#main-content > div.ssrcss-1v7bxtk-StyledContainer.enjd40x0 > div > div > ul > li:nth-child(1) > div");
        public AutomationPage()
        {
            driver = BaseTest.driver;
        }


        public void ClickSearchBBC()
        {
         driver.FindElement(searchBBC).Click();
        }

        public void EnterInSearchfield(string Items)
        {
            driver.FindElement(searchField).SendKeys(Items);
          
        }

        public void Search()
        {
            driver.FindElement(search).Click();
        }

        public bool SportShouldBeDisplayed()
        {
            return driver.Url.Contains("https://www.bbc.co.uk/search?q=Sport&d=HOMEPAGE_PS");
        }

        public bool EuropeanNewShouldBeDisplayed()
        {
            return driver.Url.Contains("https://www.bbc.co.uk/search?q=European+news&d=HOMEPAGE_PS");

        }

   }
}
