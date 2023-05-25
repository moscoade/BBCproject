using BBCProject.Hooks;
using BBCProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BBCProject.StepDefinitions
{
    [Binding]
    public class UploadfileStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        FileUploadPage fileUploadPage = new FileUploadPage();

        [Given(@"I navigate to the website ""([^""]*)""")]
        public void GivenINavigateToTheWebsite(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        [When(@"I click on choose file")]
        public void WhenIClickOnChooseFile()
        {
           fileUploadPage.ChooseFile();
        }

        [When(@"I uoload my file")]
        public void WhenIUoloadMyFile()
        {
            fileUploadPage.FileUpload();
        }

        [Then(@"My file should be uploaded")]
        public void ThenMyFileShouldBeUploaded()
        {
            
        }
    }
}
