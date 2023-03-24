using BBCProject.Hooks;
using BBCProject.PageObject;
using FluentAssertions;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BBCProject.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        public IWebDriver driver = SearchHook.driver;
        AutomationPage automationPage = new AutomationPage();

        [Given(@"I navigate to BBc Website ""([^""]*)""")]
        public void GivenINavigateToBBcWebsite(string Url)
        {
           driver.Navigate().GoToUrl(Url);
        }

        [Given(@"I click on search BBC")]
        public void GivenIClickOnSearchBBC()
        {
            automationPage.ClickSearchBBC();
        }

        [Given(@"I enter ""([^""]*)"" in search field")]
        public void GivenIEnterInSearchField(string Items)
        {
            automationPage.EnterInSearchfield(Items);
        }

        [When(@"I click on search")]
        public void WhenIClickOnSearch()
        {
            automationPage.Search();
        }

        [Then(@"Sport should displayed")]
        public void ThenSportShouldDisplayed()
        {
            automationPage.SportShouldBeDisplayed().Should().BeTrue();
        }

        [Then(@"European news should displayed")]
        public void ThenEuropeanNewsShouldDisplayed()
        {
           automationPage.EuropeanNewShouldBeDisplayed().Should().BeTrue();
        }

    }
}
