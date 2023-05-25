using BBCProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCProject.PageObject 
{
    class FileUploadPage 
    {
        public IWebDriver driver;
        public FileUploadPage()
        {
            driver = BaseTest.driver;
        }
        private By upload = By.XPath("//*[@id=\"upload-1\"]/div/div/div/p/a");
        private By file = By.CssSelector("\"C:\\Users\\zayne\\download.jpg\"");

        public void ChooseFile()
        {
            driver.FindElement(upload).Click();
        }
        
        public void FileUpload() 
        { 
            driver.FindElement(file).Click();

        }

    }
}
