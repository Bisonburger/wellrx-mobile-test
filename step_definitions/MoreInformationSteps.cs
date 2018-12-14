using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class MoreInformationSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.LearnAboutPricing _LearnAboutPricingPage;
        readonly Pages.AskPharmacistPage _AskPharmacistPage;
        readonly Pages.FaqsPage _FaqsPage;
        readonly Pages.AnswerSection _AnswerSection;
        readonly Pages.ContactUsPage _ContactUsPage;
        readonly Pages.AboutUsPage _AboutUsPage;

        public MoreInformationSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _LearnAboutPricingPage = FeatureContext.Current.Get<Pages.LearnAboutPricing>("LearnAboutPricingPage");
            _AskPharmacistPage = FeatureContext.Current.Get<Pages.AskPharmacistPage>("AskPharmacistPage");
            _FaqsPage = FeatureContext.Current.Get<Pages.FaqsPage>("FaqsPage");
            _AnswerSection = FeatureContext.Current.Get<Pages.AnswerSection>("AnswerSection");
            _ContactUsPage = FeatureContext.Current.Get<Pages.ContactUsPage>("ContactUsPage");
            _AboutUsPage = FeatureContext.Current.Get<Pages.AboutUsPage>("AboutUsPage");
        }

        public static dynamic EnterInformaton = new
        {
            Email = "Automation@test.com",
            Phone = "5555555555",
            Message = "This was made by Automation",
        };

        [Given("I am on the About Our Pricing Page")]
        public void GivenIAmOnTheAboutOurPricingPage()
        {
            When("I select the toobar item of Price Medicine");
            When("I select Learn About Our Pricing link");
        }

        [Given("I am on the More Section Page")]
        public void GivenIAmOnTheMoreSectionPage()
        {
            When("I select the toobar item of More");
            Then("I should see more menu options");
        }

        [When("I am on the FAQs page")]
        public void WhenIAmOnTheFAQsPage()
        {
            When("I choose FAQs");
            Then("I should be navigated to FAQs page");
        }

        [When("I am on the Ask a Pharmacist page")]
        public void WhenIAmOnTheAskAPharmacistPage()
        {
            When("I choose Ask a Pharmacist");
            Then("I should be on the Ask a Pharmacist Page");
        }

        [When("I am on the Contact Us page")]
        public void WhenIAmOnTheContactUsPage()
        {
            When("I choose Contact Us");
            Then("I should be on the Contact Us Page");
        }

        [When("I am on the About Us page")]
        public void WhenIAmOnTheAboutUsPage()
        {
            When("I choose About Us");
            Then("I should be navigated to the About Us page");
        }

        [When("I select View Privacy Policy tab")]
        public void WhenISelectViewPrivacyPolicyTab()
        {
            _LearnAboutPricingPage.WaitForElementPresent(_LearnAboutPricingPage.PageContainer, 5);
            if (!_LearnAboutPricingPage.ViewPrivacyPolicy.Displayed())
            {
                _LearnAboutPricingPage.ScrollDownTo(_LearnAboutPricingPage.ViewPrivacyPolicy.Locator);
            }
            _LearnAboutPricingPage.ViewPrivacyPolicy.Click();
        }

        [When("I select Terms And Conditions")]
        public void WhenISelectTermsAndConditions()
        {
            if (!_AboutUsPage.TermsAndConditionsButton.Displayed())
            {
                _AboutUsPage.ScrollDownTo(_AboutUsPage.TermsAndConditionsButton.Locator);
            }
            _AboutUsPage.TermsAndConditionsButton.Click();
        }

        [When("I select View Privacy Policy")]
        public void WhenISelectViewPrivacyPolicy()
        {
            if (!_AboutUsPage.PolicyButton.Displayed())
                _AboutUsPage.ScrollDownTo(_AboutUsPage.PolicyButton.Locator);
            _AboutUsPage.PolicyButton.Click();
        }

        [When("I select Learn More About MSC Link")]
        public void WhenISelectLearnMoreAboutMSCLink()
        {
            if (!_AboutUsPage.LearnMoreAboutMSCLinkButton.Displayed())
                _AboutUsPage.ScrollDownTo(_AboutUsPage.LearnMoreAboutMSCLinkButton.Locator);
            _AboutUsPage.LearnMoreAboutMSCLinkButton.Click();
        }

        [Then("I should be on the Ask a Pharmacist Page")]
        public void ThenIShouldBeOnTheAskAPharmacistPage()
        {
            Assert.IsTrue(_AskPharmacistPage.Header.Displayed(), "not on Ask a Pharmacist page");
        }

        [When("I select View Terms & Conditions from Ask a Pharmacist page")]
        public void WhenISelectViewTermsConditionsFromAskPharmacistPage()
        {
            _AskPharmacistPage.ViewTermConditions.Click();
        }

        [When("I select the first question on the list")]
        public void WhenISelectTheFirstQuestionOnTheList()
        {
            _FaqsPage.WaitForElementPresent(_FaqsPage.FirstQuestion, 5);
            _FaqsPage.FirstQuestion.Click();
        }

        [Then("I should be navigated to its answer page")]
        public void ThenIShouldBeNavigatedToItsAnswerPage()
        {
            _FaqsPage.WaitForElementPresent(_AnswerSection.Question, 3);
            Assert.True(_AnswerSection.Question.Displayed());
            app.Back();
            Assert.True(_FaqsPage.FirstQuestion.Displayed());
        }

        [Then("I should be navigated to the About Us page")]
        public void ThenIShouldBeNavigatedToTheAboutUsPage()
        {
            _AboutUsPage.WaitForElementPresent(_AboutUsPage.AboutUsSection, 5);
            Assert.IsTrue(_AboutUsPage.AboutUsSection.Displayed(), "not on the About Us page.");
            Assert.IsTrue(_AboutUsPage.Header.Displayed(), "not on the About Us page.");
        }

        [Then("I should be navigated to the Terms And Conditions page")]
        public void ThenIShouldBeNavigatedToTheTermsAndConditionsPage()
        {
            _AboutUsPage.WaitForElementPresent(_AboutUsPage.TermsAndConditionsPage, 5);
            Assert.IsTrue(_AboutUsPage.TermsAndConditionsPage.Displayed(), "not on the Terms And Conditions page.");
            Assert.IsTrue(_AboutUsPage.TermsAndConditionsHeader.Displayed(), "not on the Terms And Conditions page.");
            app.Back();
        }

        [Then("I should be navigated to the Privacy Policy page")]
        public void ThenIShouldBeNavigatedToTheProvacyPolicyPage()
        {
            _AboutUsPage.WaitForElementPresent(_AboutUsPage.PrivacyPolicyPage, 5);
            Assert.IsTrue(_AboutUsPage.PrivacyPolicyPage.Displayed(), "not on the privacy policy page.");
            Assert.IsTrue(_AboutUsPage.PrivacyPolicyHeader.Displayed(), "not on the privacy policy page.");
            app.Back();
        }

        [Then("I should be on the Contact Us Page")]
        public void ThenIShouldBeOnTheContactUsPage()
        {
            _ContactUsPage.WaitForElementPresent(_ContactUsPage.ContactUsHeader, 5);
            Assert.IsTrue(_ContactUsPage.ContactUsHeader.Displayed(), "not on Contact Us page");
            Assert.IsTrue(_ContactUsPage.EmailEntry.Displayed(), "The Email Entry field is not present");
            //This is here due to a bug on iOS not being able to see the element via Automation
            if (AppInitializer.CurrentPlatform == Platform.Android)
            {
                Assert.IsTrue(_ContactUsPage.PhoneEntry.Displayed(), "The Phone Entry field is not present");
            }
            _ContactUsPage.WaitForElementPresent(_ContactUsPage.CommentsEntry, 5);
            Assert.IsTrue(_ContactUsPage.CommentsEntry.Displayed(), "The Comments Entry field is not present");
        }

        [When("I submit a Contact Us inquiry")]
        public void WhenISubmitAContactUsInquiry()
        {
            _ContactUsPage.WaitForElementPresent(_ContactUsPage.SubmitButton, 3);
            _ContactUsPage.SubmitButton.Click();
        }

        [Then("I should see the Contact Us error message")]
        public void ThenIShouldSeeTheContactUsErrorMessage(string message)
        {
            _ContactUsPage.WaitForElementPresent(_ContactUsPage.ContactUsError, 5);
            Assert.AreEqual(message, _ContactUsPage.ContactUsError.GetText(), "The message does not match");
        }

        [When("I Enter Contact Us contact information")]
        public void WhenIEnterContactUsContactInformation()
        {
            _ContactUsPage.WaitForElementPresent(_ContactUsPage.EmailEntry, 5);
            _ContactUsPage.EmailEntry.EnterText(EnterInformaton.Email, true);
            if (_ContactUsPage.PhoneEntry.Displayed())
            _ContactUsPage.PhoneEntry.EnterText(EnterInformaton.Phone, true);
            When("I submit a Contact Us inquiry");
        }

        [When("I Enter Contact Us contact message")]
        public void WhenIEnterContactUsContactMessage()
        {
            _ContactUsPage.CommentsEntry.Click();
            if (!_ContactUsPage.CommentsEntry.Displayed())
                _ContactUsPage.ScrollDownTo(_ContactUsPage.CommentsEntry.Locator);
            _ContactUsPage.CommentsEntry.EnterText(EnterInformaton.Message, true);
            if (_ContactUsPage.SubmitButton.Displayed())
                When("I submit a Contact Us inquiry");

        }
    }
}
