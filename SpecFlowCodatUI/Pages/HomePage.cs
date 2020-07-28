using System;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowCodatUI.Utilities;
using TechTalk.SpecFlow;

namespace SpecFlowCodatUI.Pages
{
    [Binding]
    public class HomePage
    {
        private readonly IWebDriver driver;


        By createNewButton = By.LinkText("Create New");
        By employeeIdField = By.CssSelector("#Timesheet_EmployeeId");
        By hourlyRateField = By.CssSelector("#Timesheet_HourlyRate");
        By dayDropDownMenu = By.CssSelector("#newEntry_Day");
        By hoursField = By.CssSelector("#newEntry_Hours");
        By minutesField = By.CssSelector("#newEntry_Minutes");
        By saveButton = By.CssSelector("div.container:nth-child(2) main.pb-3 div.row:nth-child(4) div.col-md-4 form:nth-child(1) div.form-group:nth-child(5) > input.btn.btn-primary");
        By dayFieldValidationMessage = By.CssSelector("#newEntry_Day-error");

        public HomePage(ScenarioContext scenarioContext)
        {
            driver = scenarioContext["WEB_DRIVER"] as IWebDriver;
        }

        public void visit(String url)
        {
            driver.Navigate().GoToUrl(Config.BaseUrl + url);

        }

        public void checkHomePageTitle()
        {
            driver.Title.Should().Be("Index - Codat.Hiring.QA.UITestingTask");
        }

        public void checkCreateOrEditPageTitle()
        {
            driver.Title.Should().Be("Create - Codat.Hiring.QA.UITestingTask");
        }

        public IWebElement find(By locator)
        {
            return driver.FindElement(locator);
        }

        public void type(String inputText, By locator)
        {
            find(locator).SendKeys(inputText);
        }


        public void click(By locator)
        {
            find(locator).Click();
        }


        public void waitFor()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        public Boolean isDisplayed(By locator)
        {
            try
            {
                return find(locator).Displayed && find(locator).Enabled;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


        public void goToHomePage() {
            visit("/");
            checkHomePageTitle();
        }

        public void clickOnCreateNewTimesheetButton()
        {
            waitFor();
            click(createNewButton);
        }

        public void submitNewTimesheetForm(String employeeID, String hourlyRate, String hours, String minutes)
        {
            type(employeeID, employeeIdField);
            type(hourlyRate, hourlyRateField);
            type(hours, hoursField);
            type(minutes, minutesField);
        }

        public void clickOnSaveButton()
        {
            click(saveButton);
        }

        public void dayFieldValidationMessagePresent()
        {
            Assert.True(isDisplayed(dayFieldValidationMessage));
        }

    }
}
