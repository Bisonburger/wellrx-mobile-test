using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class SavingsCardSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.SavingscardPage _SavingsCardPage;

        public SavingsCardSteps()
        {
            app = FeatureContext.Current.Get<IApp>("App");
            _SavingsCardPage = FeatureContext.Current.Get<Pages.SavingscardPage>("SavingsCardPage");
        }
        [When("I choose Save to Dashboard")] 
        public void WhenIChooseSaveToDashboard()
        {
            _SavingsCardPage.WaitForElementPresent(_SavingsCardPage.PageContainer, 5);
            if (!_SavingsCardPage.SaveToDashboard.Displayed())
                _SavingsCardPage.ScrollDownTo(_SavingsCardPage.SaveToDashboard.Locator); 
            _SavingsCardPage.SaveToDashboard.Click();
            _SavingsCardPage.WaitForElementNotPresent(_SavingsCardPage.SaveToDashboard, 3);
            if (_SavingsCardPage.SaveToDashboard.Displayed())
                _SavingsCardPage.SaveToDashboard.Click();
        }

        [Given("I navigated to the savings card page without login")]
        public void GivenINavigatedToTheSavingsCardPageWithoutLogin()
        {
            Then("I should be on the Welcome page");
            When("I choose to move forward without an invite code and past on boarding tutorial screens");
        }
    }
}
