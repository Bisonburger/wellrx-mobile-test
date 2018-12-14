using System;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class PriceMedsDetailsSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.PriceMedicinePage _PriceMedicinePage;
        readonly Pages.PharmacyDrugInfoPage _PharmacyDrugInfoPage;
        readonly Pages.PriceMedsResultsPage _PriceMedsResultsPage;
        readonly Pages.LearnAboutPricing _LearnAboutPricingPage;

        public PriceMedsDetailsSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //TODO Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _PriceMedicinePage = FeatureContext.Current.Get<Pages.PriceMedicinePage>("PriceMedicinePage");
            _PharmacyDrugInfoPage = FeatureContext.Current.Get<Pages.PharmacyDrugInfoPage>("PharmacyDrugInfoPage");
            _PriceMedsResultsPage = FeatureContext.Current.Get<Pages.PriceMedsResultsPage>("PriceMedsResultsPage");
            _LearnAboutPricingPage = FeatureContext.Current.Get<Pages.LearnAboutPricing>("LearnAboutPricingPage");
        }

        [Then("I should be navigated to the pharmacy drug info page")]
        public void ThenIShouldBeNavigatedToThePharmacyDrugInfoPage()
        {
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.PageContainer, 3);
            Assert.IsTrue(_PharmacyDrugInfoPage.PageContainer.Displayed(), "Not on the pharmacy drug info page.");
            Assert.IsTrue(_PharmacyDrugInfoPage.PharmacyNameLabel.Displayed(), "Missing Pharmacy Name Label.");
            Assert.IsTrue(_PharmacyDrugInfoPage.PriceLabel.Displayed(), "Missing Pharmacy Name Label.");
            Assert.IsTrue(_PharmacyDrugInfoPage.PharmacyAddressLabel.Displayed(), "Missing Pharmacy Address Label.");
            Assert.IsTrue(_PharmacyDrugInfoPage.PharmacyImage.Displayed(), "Missing Pharmacy Image.");
            Assert.IsTrue(_PharmacyDrugInfoPage.MakeCallButton.Displayed(), "Missing Make Call Button.");
            Assert.IsTrue(_PharmacyDrugInfoPage.GetDirectionsButton.Displayed(), "Missing Get Directions Button.");
        }

        [Then("I should have the option to add the medicine to my medicine chest")]
        public void ThenIShouldHaveTheOptiontoAddTheMedicineToMyMedicineChest()
        {
            if (!_PharmacyDrugInfoPage.AddToChest.Displayed())
                _PharmacyDrugInfoPage.ScrollDownTo(_PharmacyDrugInfoPage.AddToChest.Locator);
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.AddToChest, 5);
            Assert.IsTrue(_PharmacyDrugInfoPage.AddToChest.Displayed(), "missing add to med chest option");
        }

        [When("I select Add To Med Chest from the pharmacy page")]
        public void WhenISelectAddToMedChestFromThePharmacyPage()
        {
            if (!_PharmacyDrugInfoPage.AddToChest.Displayed())
                _PharmacyDrugInfoPage.ScrollDownTo(_PharmacyDrugInfoPage.AddToChest.Locator);
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.AddToChest, 5);
            _PharmacyDrugInfoPage.AddToChest.Click();
        }

        [When("I select Watch And Learn from the pharmacy page")]
        public void WhenISelectWatchAndLearnFromThePharmacyPage()
        {
            if (!_PharmacyDrugInfoPage.WatchAndLearnButton.Displayed())
                _PharmacyDrugInfoPage.ScrollDownTo(_PharmacyDrugInfoPage.WatchAndLearnButton.Locator);
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.WatchAndLearnButton, 3);
            _PharmacyDrugInfoPage.WatchAndLearnButton.Click();
            if (_PharmacyDrugInfoPage.WatchAndLearnButton.Displayed())
                _PharmacyDrugInfoPage.WatchAndLearnButton.Click();
        }

        [Then("I should have the options see the drug info in English or Spanish")]
        public void ThenIShouldHaveTheOptionsSeeTheDrugInfoInEnglishOrSpanish()
        {
            if (!_PharmacyDrugInfoPage.DrugInfoEnglish.Displayed())
                _PharmacyDrugInfoPage.ScrollDownTo(_PharmacyDrugInfoPage.DrugInfoEnglish.Locator);
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.DrugInfoEnglish, 5);
            Assert.IsTrue(_PharmacyDrugInfoPage.DrugInfoEnglish.Displayed(), "Missing English drug info option.");
            Assert.IsTrue(_PharmacyDrugInfoPage.DrugInfoSpanish.Displayed(), "Missing Spanish drug info option.");
            if (!_PharmacyDrugInfoPage.DrugInfoEnglish.Displayed() && AppInitializer.CurrentPlatform == Platform.Android)
            {
                _PharmacyDrugInfoPage.ScrollDownTo(_PharmacyDrugInfoPage.DrugInformation.Locator);
                Assert.IsTrue(_PharmacyDrugInfoPage.DrugInformation.Displayed(), "Missing Drug Information.");
            }
        }

        [Then("I should see the Pharmacy Details message reads as")]
        public void ThenIShouldSeeThePharmacyDetailsMessageReadsAs(string multiLines)
        {
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.PharmacyDetailsMessage, 3);
            Assert.AreEqual(multiLines, _PharmacyDrugInfoPage.PharmacyDetailsMessage.GetText());
            _PharmacyDrugInfoPage.WaitForElementNotPresent(_PharmacyDrugInfoPage.PharmacyDetailsMessage, 3);
        }

        [When("I select Todays Hours on Pharmacy Details")]
        public void WhenISelectTodaysHoursOnPharmacyDetails()
        {
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.TodaysHoursButton, 3);
            _PharmacyDrugInfoPage.TodaysHoursButton.Click();
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.OkButton, 3);
            _PharmacyDrugInfoPage.OkButton.Click();
        }

        [When("I select Savings Card Link on Pharmacy Details")]
        public void WhenISelectSavingsCardLinkOnPharmacyDetails()
        {
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.SavingsCardLink, 3);
            _PharmacyDrugInfoPage.SavingsCardLink.Click();
        }

        [When("I select Peffered on Pharmacy Details")]
        public void WhenISelectPefferedOnPharmacyDetails()
        {
            if (_PharmacyDrugInfoPage.SetPreferredLabel.Displayed())
                _PharmacyDrugInfoPage.SetPreferredButton.Click();
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.PreferredLabel, 3);
            _PharmacyDrugInfoPage.SetPreferredButton.Click();
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.OkButton, 3);
            _PharmacyDrugInfoPage.OkButton.Click();
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.SetPreferredLabel, 3);
            _PharmacyDrugInfoPage.SetPreferredButton.Click();
        }

        [Then("I should see the Add to Med Chest message")]
        public void ThenIShouldSeeTheAddToMedChestMessage()
        {
            string sucsess = "Your medication has been added to the medicine chest successfully!";
            string alreadyAdded = "Oops. Looks like you have already added this drug to your medicine chest.";
            _PharmacyDrugInfoPage.WaitForElementPresent(_PharmacyDrugInfoPage.PharmacyDetailsMessage, 5);
            if (alreadyAdded == _PharmacyDrugInfoPage.PharmacyDetailsMessage.GetText())
            Assert.AreEqual(alreadyAdded, _PharmacyDrugInfoPage.PharmacyDetailsMessage.GetText());
            else
            Assert.AreEqual(sucsess, _PharmacyDrugInfoPage.PharmacyDetailsMessage.GetText());
        }
    }
}