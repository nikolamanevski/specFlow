//using System;
//using OpenQA.Selenium;
//using TechTalk.SpecFlow;
//using SpecFlowCodatUI.Utilities;
//using FluentAssertions;
//using OpenQA.Selenium.Support.UI;

//namespace SpecFlowCodatUI.Pages
//{
//    [Binding]
//    public class BasePage
//    {
//        private readonly IWebDriver driver;




//        public BasePage(ScenarioContext scenarioContext)
//        {
//            driver = scenarioContext["WEB_DRIVER"] as IWebDriver;
//        }


        //public void visit(String url)
        //{
        //    driver.Navigate().GoToUrl(Config.BaseUrl + url);

        //}

        // public void checkHomePageTitle()
        //{
        //    driver.Title.Should().Be("Index - Codat.Hiring.QA.UITestingTask");
        //}

//        public IWebElement find(By locator)
//        {
//            return driver.FindElement(locator);
//        }


//        public void click(By locator)
//        {
//            find(locator).Click();
//        }


//        public void waitFor()
//        {
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
         
//        }

     
    

//    }
//}
