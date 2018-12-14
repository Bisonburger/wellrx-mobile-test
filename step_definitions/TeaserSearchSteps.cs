using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class TeaserSearchSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.TeaserSearchResultsPage _TeaserSearchResultsPage;
        readonly Pages.SavingsTeaserPage _SavingsTeaserPage;
        readonly Pages.PriceMedsResultsPage _PriceMedsResultsPage;
        readonly Pages.WelcomePage _WelcomePage;

        public TeaserSearchSteps()
        {
            app = FeatureContext.Current.Get<IApp>("App");
            _TeaserSearchResultsPage = FeatureContext.Current.Get<Pages.TeaserSearchResultsPage>("TeaserSearchResultsPage");
            _SavingsTeaserPage = FeatureContext.Current.Get<Pages.SavingsTeaserPage>("SavingsTeaserPage");
            _PriceMedsResultsPage = FeatureContext.Current.Get <Pages.PriceMedsResultsPage>("PriceMedsResultsPage");
            _WelcomePage = FeatureContext.Current.Get<Pages.WelcomePage>("WelcomePage");
        }

        [Given("I am on the teaser search page")]
        public void GivenIAmOnTheTeaserSearchPage()
        {
            When("I choose to move forward without an invite code");
            Given("I am past the tutorial screens");
            When("I select Try It on the On Boarding pages");
        }

        // When calling this "When" statement replace both "(.*)" with the text that you want to enter for the test 
        [When("I search (.*) with (.*) zip code")]
        public void WhenISearchDrugWithZipCode(string drugName, string zipCode)
        {
            _SavingsTeaserPage.DrugName.EnterText(drugName);
            _SavingsTeaserPage.KeyboardDone.Click();
            _SavingsTeaserPage.ZipCode.EnterText(zipCode);
            _SavingsTeaserPage.SeeSavings.Click();
        }

        [When("I enter (.*) as drug name without using the autocomplete")]
        public void WhenIEnterAsDrugNameWithoutUsingTheAutocomplete(string drugName)
        {
            _SavingsTeaserPage.DrugName.EnterText(drugName);
            _SavingsTeaserPage.KeyboardDone.Click();
        }

        [When("I enter (.*) in the zip code field")]
        public void WhenIEnterInTheZipCodeField(string zipCode)
        {
            _SavingsTeaserPage.ZipCode.EnterText(zipCode);
        }

        [When("I attempt to search (.*) with invalid zip code")]
        public void WhenIAttemptToSearchDrugWithInvalidZipcode(string drugName)
        {
            When("I search " + drugName+ " with 857112 zip code");
        }

        [When("I attempt to search invalid drug with valid zip code")]
        public void WhenIAttemptToSearchInvalidDrugWithValidZipcode()
        {
            When("I search invalid with 85711 zip code");
        }

        [When("I search (.*) with (.*) zip code via autocomplete options")]
        public void WhenISearchDrugWithZipCodeViaAutocompleteOptions(string drugName, string zipCode)
        {
            _SavingsTeaserPage.DrugName.EnterText(drugName, true);
            _SavingsTeaserPage.KeyboardDone.Click();
            _SavingsTeaserPage.ZipCode.EnterText(zipCode, true);
            _SavingsTeaserPage.SeeSavings.Click();
        }

        [Then("Let's See The Savings button should be disabled")]
        public void ThenLetsSeeTheSavingButtonShouldBeDisabled()
        {
            Assert.IsFalse(_SavingsTeaserPage.SeeSavings.Enabled(), "See savings button should not be enabled.");
        }

        [When("I choose not to search savings")]
        public void WhenIChooseNotToSearchSavings()
        {
            _TeaserSearchResultsPage.WaitForElementPresent(_TeaserSearchResultsPage.NoThanks, 5);
            _TeaserSearchResultsPage.NoThanks.Click();
        }

        [Given("I am on the teaser search results page")]
        public void GivenIAmOnTheTeaserSearchResultsPage()
        {
            Given("I am on the teaser search page");
            When("I search Zoloft with 80130 zip code via autocomplete options");
        }

        [When("I choose Yes on create an account")]
        public void WhenIChooseYesOnCreateAnAccount()
        {
            _TeaserSearchResultsPage.WaitForElementPresent(_TeaserSearchResultsPage.YesCreateAccount, 5);
            _TeaserSearchResultsPage.YesCreateAccount.Click();
        }

        [When("I choose create account on account required prompt")]
        public void WhenIChooseCreateAccountOnAccountRequiredPrompt()
        {
            _TeaserSearchResultsPage.WaitForElementPresent(_TeaserSearchResultsPage.AccountRequiredCreateAccount, 5);
            _TeaserSearchResultsPage.AccountRequiredCreateAccount.Click();
        }

        [When("I choose No Thanks on create an account")]
        public void WhenIChooseNoThanksOnCreateAnAccount()
        {
            _TeaserSearchResultsPage.NoThanks.Click();
        }

        [Then("I should see email validation message")] 
        public void ThenIShouldSeeEmailValidationMessage()
        {
            Assert.IsTrue(_TeaserSearchResultsPage.EmailValidationMsg.Displayed(), "missing email validation msg.");
        }

        [Then("I should see Pharmacy search results")]
        public void ThenIShouldSeePharmacySearchResults()
        {
            _PriceMedsResultsPage.WaitForElementPresent(_PriceMedsResultsPage.ResultsList, 5);
            Assert.IsTrue(_PriceMedsResultsPage.ResultsList.Displayed(), "Not on the Rsults page.");
        }

        [When("I enter (.*) in the email field")]
        public void WhenIEnterInTheEmailField(string email)
        {
            _TeaserSearchResultsPage.Email.EnterText(email);
            _TeaserSearchResultsPage.HideKeyboard();
        }

        [When("I select Yes from teaser search results page")]
        public void WhenISelectYesFromTeaserSearchResultsPage()
        {
            _TeaserSearchResultsPage.YesCreateAccount.Click();
        }

        [Then("I should be prompt with message reads as")]
        public void ThenIShouldBePromptWithMessageReadsAs(string multiLine)
        {
            _TeaserSearchResultsPage.WaitForElementPresent(_SavingsTeaserPage.Message, 5);
            Assert.AreEqual(multiLine, _SavingsTeaserPage.Message.GetText());
        }

        [Then("I should see (.*) in the medication field")]
        public void ThenIShouldSeeInTheMedicationField(string drugName)
        {
            _SavingsTeaserPage.WaitForElementPresent(_SavingsTeaserPage.DrugName, 3);
            Assert.AreEqual(drugName, _SavingsTeaserPage.DrugName.GetText());
        }

        [When("I choose to see savings")]
        public void WhenIChooseToSeeSavings()
        {
            _SavingsTeaserPage.SeeSavings.Click();
        }

        [When("I select a Pharmacy from the search results")]
        public void WhenISelectAPharmacyFromTheSearchResults()
        {
            _PriceMedsResultsPage.WaitForElementPresent(_PriceMedsResultsPage.FirstPharmacyResult, 5);
            _PriceMedsResultsPage.FirstPharmacyResult.Click();
        }
    }
}