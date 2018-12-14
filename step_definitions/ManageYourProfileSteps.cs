using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class ManageYourProfileSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.DashboardPage _DashboardPage;
        readonly Pages.ManageYourProfilePage _ManageYourProfilePage;
        readonly Pages.EditProfilePage _EditProfilePage;
        readonly Pages.ManageYourProfileSubSectionsPage _ManageYourProfileSubSectionsPage;

        public ManageYourProfileSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _DashboardPage = FeatureContext.Current.Get<Pages.DashboardPage>("DashboardPage");
            _ManageYourProfilePage = FeatureContext.Current.Get<Pages.ManageYourProfilePage>("ManageYourProfilePage");
            _EditProfilePage = FeatureContext.Current.Get<Pages.EditProfilePage>("EditProfilePage");
            _ManageYourProfileSubSectionsPage = FeatureContext.Current.Get<Pages.ManageYourProfileSubSectionsPage>("ManageYourProfileSubSectionsPage");
        }

        [Given("I am on manage your profile page")]
        public void GivenIAmOnManageYourProfilePage()
        {
            Given("I am on the home page");
            When("I select the toobar item of More");
            Then("I should see more menu options");
            When("I choose Edit Profile");
        }

        [Then("I should see my profile info")]
        public void ThenIShouldSeeMyProfileInfo()
        {
            _EditProfilePage.WaitForElementPresent(_ManageYourProfilePage.ManageProfile, 8);
            Assert.IsTrue(_ManageYourProfilePage.ManageProfile.Displayed(), "The Manage profile page isnot present");
            Assert.IsTrue(_ManageYourProfilePage.AccountDetailsContentView.Displayed(), "The Account Details is not present");
            Assert.IsTrue(_ManageYourProfilePage.AccountDetailsHeader.Displayed(), "The Account Details Header is not present");
            Assert.IsTrue(_ManageYourProfilePage.Name.Displayed(), "The Account Details Name is not present");
            Assert.IsTrue(_ManageYourProfilePage.Email.Displayed(), "The Account Details Email is not present");
            Assert.IsTrue(_ManageYourProfilePage.DOB.Displayed(), "The Account Details DOB is not present");
            Assert.IsTrue(_ManageYourProfilePage.ZipCode.Displayed(), "The Account Details ZipCode is not present");
            Assert.IsTrue(_ManageYourProfilePage.InviteCode.Displayed(), "The Account Details Invite Code is not present");
            Assert.IsTrue(_ManageYourProfilePage.MobileNumber.Displayed(), "The Account Details Mobile Number is not present");
        }

        [When("I scroll to the Conditions view")]
        public void WhenIScrollToTheConditionsView()
        {
            if (!_ManageYourProfilePage.AccountConditionContentView.Displayed() && AppInitializer.CurrentPlatform == Platform.Android)
                _ManageYourProfilePage.ScrollDownTo(_ManageYourProfilePage.AccountConditionContentView.Locator);

            else if (AppInitializer.CurrentPlatform == Platform.iOS)
            _ManageYourProfilePage.ScrollDown(_ManageYourProfilePage.ScrollView.Locator);

            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.AccountConditionContentView, 3);
        }

        [Then("I should see my Conditions info")]
        public void ThenIShouldSeeMyConditionsInfo()
        {
            When("I scroll to the Conditions view");
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.AccountConditionContentView, 3);
            Assert.IsTrue(_ManageYourProfilePage.AccountConditionContentView.Displayed(), "The Account ConditionContent View is not present");
            if (_ManageYourProfilePage.NoConditionsText.Displayed())
                Assert.IsTrue(_ManageYourProfilePage.NoConditionsText.Displayed(), "The Account No Conditions View is not present");

            else if (_ManageYourProfilePage.ConditionTypeText.Displayed())
            {
                Assert.IsTrue(_ManageYourProfilePage.ConditionTypeText.Displayed(), "The Account Condition Type Text  is not present");
                Assert.IsTrue(_ManageYourProfilePage.ConditionsHeader.Displayed(), "The Account Conditions Header is not present");
                Assert.IsTrue(_ManageYourProfilePage.ConditionEdit.Displayed(), "The Account Conditions Edit button is not present");
            }
        }

        [When("I select the profile Savings Card")]
        public void WhenISelectTheProfileSavingsCard()
        {
            if (!_ManageYourProfilePage.SavingCardView.Displayed())
                _ManageYourProfilePage.ScrollDownTo(_ManageYourProfilePage.SavingCardView.Locator);
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.SavingCardView, 5);
            _ManageYourProfilePage.SavingCardView.Click();
        }

        [Then("I should be on the expanded Savigs Card view")]
        public void ThenIShouldBeOnTheExpandedSavigsCardView()
        {
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.SavingsCardExpandedView, 5);
            Assert.IsTrue(_ManageYourProfilePage.SavingsCardExpandedView.Displayed(), "The Savings Card Expanded View is not present");
            Assert.IsTrue(_ManageYourProfilePage.SavingsCardDisclaimer.Displayed(), "The Savings Card Disclaimer is not present");
            _ManageYourProfilePage.SavingsCardCancelButton.Click();
        }

        [When("I choose Manage Your Profile")]
        public void WhenIChooseManageYourProfile()
        {
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.AccountDetailsHeader, 5);
            _ManageYourProfilePage.AccountDetailsHeader.Click();
        }

        [When("I select the profile icon")]
        public void WhenISelectTheProfileIcon()
        {
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.ProfileIcon, 5);
            _ManageYourProfilePage.ProfileIcon.Click();
        }

        [When("I select the Preferences tab")]
        public void WhenISelectThePreferencesTab()
        {
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.PreferencesTabButton, 5);
            _ManageYourProfilePage.PreferencesTabButton.Click();
        }

        [Then("I should see my Preferences Preferences Dietary info")]
        public void ThenIShouldSeeMyPreferencesPreferencesDietaryInfo()
        {
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.PreferencesDietaryCard, 5);
            Assert.IsTrue(_ManageYourProfilePage.PreferencesDietaryCard.Displayed(), "The Preferences Dietary Card is not present.");
            Assert.IsTrue(_ManageYourProfilePage.DietaryHeader.Displayed(), "Missing Dietary Header.");
            if (_ManageYourProfilePage.ProvideDietaryMessage.Displayed())
            {
                Assert.IsTrue(_ManageYourProfilePage.ProvideDietaryMessage.Displayed(), "Missing Provide Dietary Message.");
                Assert.IsTrue(_ManageYourProfilePage.AddPreferencesDietaryLink.Displayed(), "Missing Add Preferences Dietary Link.");
            }
            else
            {
                Assert.IsTrue(_ManageYourProfilePage.DietPreferencesIcon.Displayed(), "Missing Diet Preferences Icon.");
                Assert.IsTrue(_ManageYourProfilePage.DietaryPreferencesText.Displayed(), "Missing Dietary Preferences Text.");
                Assert.IsTrue(_ManageYourProfilePage.DietaryValues.Displayed(), "Missing Dietary Values.");
            }
        }


        [Then("I should see my Preferences Preferred Pharmacy info")]
        public void ThenIShouldSeeMyPreferencesPreferredPharmacyInfo()
        {
            if (!_ManageYourProfilePage.AccountPreferencesContentView.Displayed())
                _ManageYourProfilePage.ScrollDownTo(_ManageYourProfilePage.AccountPreferencesContentView.Locator, ScrollStrategy.Gesture);
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.AccountPreferencesContentView, 5);
            Assert.IsTrue(_ManageYourProfilePage.AccountPreferencesContentView.Displayed(), "The Account Preferences Content View is not present.");
            Assert.IsTrue(_ManageYourProfilePage.PreferredPharmacyHeader.Displayed(), "Missing Pharmacy Header.");
            if (_ManageYourProfilePage.SetPreferredPharmacyText.Displayed())
            {
                Assert.IsTrue(_ManageYourProfilePage.SetPreferredPharmacyText.Displayed(), "Missing Preferred Pharmacy Text.");
                Assert.IsTrue(_ManageYourProfilePage.AddPreferredPharmacyLink.Displayed(), "Missing Add Preferred Pharmacy Link.");
            }
            else
            {
                Assert.IsTrue(_ManageYourProfilePage.PharmacyName.Displayed(), "Missing Pharmacy Name.");
                Assert.IsTrue(_ManageYourProfilePage.PharmacyPhoneNumber.Displayed(), "Missing Pharmacy Phone Number Header.");
                Assert.IsTrue(_ManageYourProfilePage.PharmacyAddress.Displayed(), "Missing Pharmacy Address.");
            }
        }

        [When("I select the Notifications tab")]
        public void WhenISelectTheNotificationsTab()
        {
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.SettingsTabButton, 5);
            _ManageYourProfilePage.SettingsTabButton.Click();
        }

        [Then("I should see my Notifications info")]
        public void ThenIShouldSeeMyNotificationsInfo()
        {
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.NotificationSettingsTap, 5);
            Assert.IsTrue(_ManageYourProfilePage.NotificationSettingsTap.Displayed(), "The Notification Settings View is not present");
            Assert.IsTrue(_ManageYourProfilePage.NotificationsHeader.Displayed(), "The Notifications Header is not present");
            Assert.IsTrue(_ManageYourProfilePage.PillAndRefillReminderText.Displayed(), "The Pill And Refill Reminder Text is not present");
            Assert.IsTrue(_ManageYourProfilePage.EmailNewsletterText.Displayed(), "The Email Newsletter Text is not present");
        }

        [When("I select the Notifications edit")]
        public void WhenISelectTheNotificationsEdit()
        {
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.NotificationsEdit, 5);
            _ManageYourProfilePage.NotificationsEdit.Click();
        }

        [When("I select the Edit Condition Details")]
        public void WhenISelectTheEditConditionDetails()
        {
            When("I scroll to the Conditions view");
            if (_ManageYourProfilePage.NoConditionsText.Displayed())
            {
                _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.ConditionEdit, 5);
                _ManageYourProfilePage.ConditionEdit.Click();
            }
            else if (_ManageYourProfilePage.ConditionTypeText.Displayed())
            {
                _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.ConditionEdit, 5);
                _ManageYourProfilePage.ConditionEdit.Click();
            }
        }

        [When("I scroll to the Allergens view")]
        public void WhenIScrollToTheAllergensView()
        {
            if (!_ManageYourProfilePage.AccountAllergyContentView.Displayed() && AppInitializer.CurrentPlatform == Platform.Android)
                _ManageYourProfilePage.ScrollDownTo(_ManageYourProfilePage.AccountAllergyContentView.Locator);

            else if (AppInitializer.CurrentPlatform == Platform.iOS)
            {
                _ManageYourProfilePage.ScrollDown(_ManageYourProfilePage.ScrollView.Locator);
                _ManageYourProfilePage.ScrollDown(_ManageYourProfilePage.ScrollView.Locator);
            }
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.AccountAllergyContentView, 3);
        }

        [Then("I should see my Allergens info")]
        public void ThenIShouldSeeMyAllergensInfo()
        {
            When("I scroll to the Allergens view");
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.AccountAllergyContentView, 3);
            Assert.IsTrue(_ManageYourProfilePage.AccountAllergyContentView.Displayed(), "The Account Allergy Content View is not present.");
            Assert.IsTrue(_ManageYourProfilePage.AllergensHeader.Displayed(), "Missing Allergens Header.");
            if (_ManageYourProfilePage.NoAllergensLayout.Displayed())
                Assert.IsTrue(_ManageYourProfilePage.ProvideAllergenMessage.Displayed(), "Missing Provide Allergen Message.");

            else if (_ManageYourProfilePage.AllergenTypeText.Displayed())
            {
                Assert.IsTrue(_ManageYourProfilePage.AllergenTypeText.Displayed(), "Missing Allergen Type Text.");
                Assert.IsTrue(_ManageYourProfilePage.AllergenEdit.Displayed(), "Misssing Allergen Edit.");
                Assert.IsTrue(_ManageYourProfilePage.AllergenValues.Displayed(), "Missing Allergen Values.");
            }
        }

        [When("I select the Allergens Details")]
        public void WhenISelectTheAllergensDetails()
        {
            When("I scroll to the Allergens view");
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.AllergensHeader, 3);
            _ManageYourProfilePage.AllergensHeader.Click();
        }

        [When("I select the Dietary Details")]
        public void WhenISelectTheDietaryDetails()
        {
            _ManageYourProfilePage.WaitForElementPresent(_ManageYourProfilePage.DietaryHeader, 3);
            _ManageYourProfilePage.DietaryHeader.Click();
        }
    }
}
