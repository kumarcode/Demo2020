using System;
using TechTalk.SpecFlow;

namespace DemoProject.StepDefinitions
{
    [Binding]
    public class CustomerSteps
    {
        [Given(@"I log in to TurnUp portal")]
        public void GivenILogInToTurnUpPortal()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I navigate to Customer page")]
        public void GivenINavigateToCustomerPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to create customer record with valid information")]
        public void ThenIShouldBeAbleToCreateCustomerRecordWithValidInformation()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to edit customer record with updated information")]
        public void ThenIShouldBeAbleToEditCustomerRecordWithUpdatedInformation()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
