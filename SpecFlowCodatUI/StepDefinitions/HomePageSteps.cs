
using System.Threading;
using SpecFlowCodatUI.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowCodatUI.StepDefinitions
{
    [Binding]
    public class HomePageSteps
    {
  
        HomePage home;

        public HomePageSteps(ScenarioContext scenarioContext)
        {
            home = new HomePage(scenarioContext);
        }

        [Given(@"the user is on the timesheet home page")]
        public void GivenTheUserIsOnTheTimesheetHomePage()
        {
            home.goToHomePage();
        }

        [Given(@"the user clicks on Create New button")]
        public void GivenTheUserClicksOnCreateNewButton()
        {
            home.clickOnCreateNewTimesheetButton();
        }

        [When(@"the user completes the form with invalid data")]
        public void WhenTheUserCompletesTheFormWithInvalidData()
        {
            home.submitNewTimesheetForm("CTD100", "10", "8", "45");
        }

        [When(@"click on the Save button")]
        public void WhenClickOnTheSaveButton()
        {
            home.clickOnSaveButton();
        }

        [When(@"the user clicks on Create New button")]
        public void WhenTheUserClicksOnCreateNewButton()
        {
            home.clickOnCreateNewTimesheetButton();
        }

        [Then(@"day field validation message should be triggered notifying the user")]
        public void ThenDayFieldValidationMessageShouldBeTriggeredNotifyingTheUser()
        {
            home.dayFieldValidationMessagePresent();
        }

        [Then(@"the user should be redirected to new timesheet page")]
        public void ThenTheUserShouldBeRedirectedToNewTimesheetPage()
        {
            home.checkCreateOrEditPageTitle();
        }


    }
}