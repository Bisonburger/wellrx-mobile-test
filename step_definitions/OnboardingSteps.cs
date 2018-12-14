using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;


namespace WellRx.UITests.Steps
{
    [Binding] 
    public class OnBoardingSteps : TechTalk.SpecFlow.Steps
    {   
        readonly IApp app;
        readonly Pages.OnBoardingPage _OnBoardingPage;

        public OnBoardingSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
             app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _OnBoardingPage = FeatureContext.Current.Get<Pages.OnBoardingPage>("OnBoardingPage");
        }

        [Given("I am on the onboard page")]
        public void GivenIAmOnTheOnBoardPage()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.OnBoardingPageContainer, 10);
            Console.WriteLine("Is onbaord page displayed: " + _OnBoardingPage.OnBoardingPageContainer.Displayed());
            Assert.IsTrue(_OnBoardingPage.OnBoardingPageContainer.Displayed(), "not on the onboard page");
        }

        [Then("I should see onboarding text as follows")]
        public void ThenIShouldSeeOnboardingTextAsFollows(string multiLines)
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.OnBoardingPageContainer, 7);
            Assert.AreEqual(multiLines, _OnBoardingPage.OnBoardingPageContainer.GetText());
        }

        [When("I swipe to next page")]
        public void WhenISwipeToNextPage()
        {
            _OnBoardingPage.SwipeRightToLeft();
        }

        [Then("I should see onboarding scan save page and text as follows")]
        public void ThenIShouldSeeOnboardingScanSavePageAndTextAsFollows(string multiLines)
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.OnBoardingPageScanSaveContainer, 5);
            Console.WriteLine("Is onbaord page displayed: " + _OnBoardingPage.OnBoardingPageScanSaveContainer.Displayed());
            Assert.IsTrue(_OnBoardingPage.OnBoardingPageScanSaveContainer.Displayed(), "not on the onboard scan save page");
            Assert.AreEqual(multiLines, _OnBoardingPage.OnBoardingPageScanSaveContainer.GetText());
        }

        [Then("I should see the onboarding grocery guidance page and text as follows")]
        public void ThenIShouldSeeTheOnboardingGroceryGuidanceTextAsFollows(string multiLines)
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.OnBoardingPageGroceryGuidanceContainer, 5);
            Console.WriteLine("Is onbaord page displayed: " + _OnBoardingPage.OnBoardingPageGroceryGuidanceContainer.Displayed());
            Assert.IsTrue(_OnBoardingPage.OnBoardingPageGroceryGuidanceContainer.Displayed(), "not on the onboard scan save page");
            Assert.AreEqual(multiLines, _OnBoardingPage.OnBoardingPageGroceryGuidanceContainer.GetText());
        }

        [When("I select the continue link on the On Boarding pages")]
        public void WhenISelectTheContinueLinkOntheOnBoardingPages()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.OnBoardingContinueLink, 5);
            _OnBoardingPage.OnBoardingContinueLink.Click();
        }

        [Then("I should be on the Try Price Meds page")]
        public void ThenIShouldBeOnTheTryMedsPage()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.OnBoardingPriceMedsContainer, 3);
            Console.WriteLine("Is onbaord page displayed: " + _OnBoardingPage.OnBoardingPriceMedsContainer.Displayed());
            Assert.IsTrue(_OnBoardingPage.OnBoardingPriceMedsContainer.Displayed(), "not on the onboard page");
        }

        [When("I select Skip For Now on the On Boarding pages")]
        public void WhenISelectSkipForNowOnTheOnBoardingPages()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.SkipForNowOboardingButton, 5);
            _OnBoardingPage.SkipForNowOboardingButton.Click();
        }

        [When("I select Try It on the On Boarding pages")]
        public void WhenISelectTryItOnTheOnBoardingPages()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.TryItOnboardingButton, 5);
            _OnBoardingPage.TryItOnboardingButton.Click();
        }

        [Then("I should be on the Try Barcode Scanning page")]
        public void ThenIShouldBeOnTheTrybarcodescanningPage()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.OnBoardingTryBarcodeScannerText, 3);
            Console.WriteLine("Is onbaord page displayed: " + _OnBoardingPage.OnBoardingTryBarcodeScannerText.Displayed());
            Assert.IsTrue(_OnBoardingPage.BarcodeScannerTryItOnboardingButton.Displayed(), "not on the onboard page"); 
        }

        [When("I select Skip For Now on the Barcode Scanner page")]
        public void WhenISelectSkipForNowOnTheBarcodeScannerPage()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.BarcodeScannerSkipForNowOboardingButton, 5);
            _OnBoardingPage.BarcodeScannerSkipForNowOboardingButton.Click();
        }

        [When("I select Try It Now on the Barcode Scanner page")]
        public void WhenIselectTryItNowOnTheBarcodeScannerPage()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.BarcodeScannerTryItOnboardingButton, 5);
            _OnBoardingPage.BarcodeScannerTryItOnboardingButton.Click();
        }

        [When("I select Continue on Teaser Savings page")]
        public void WhenISelectContinueOnTeaserSavingsPage()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.TeaserSavingsContinueButton, 5);
            _OnBoardingPage.TeaserSavingsContinueButton.Click();
        }

        [Then("I should be on the Manage Your Meds page")]
        public void ThenIShouldBeOnTheManageYourMedsPage()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.GeneralTutorialPage, 3);
            Console.WriteLine("Is onbaord page displayed: " + _OnBoardingPage.GeneralTutorialPage.Displayed());
            Assert.IsTrue(_OnBoardingPage.GeneralTutorialPage.Displayed(), "Not on the General Tutorial Page.");
            Assert.IsTrue(_OnBoardingPage.OnboardingNoWellnessLabel.Displayed(), "Missing On Boarding No Wellness Label.");
        }
    }
}
