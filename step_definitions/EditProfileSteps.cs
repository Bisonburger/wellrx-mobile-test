using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class EditProfileSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.EditProfilePage _EditProfilePage;
        readonly Pages.ManageYourProfileSubSectionsPage _ManageYourProfileSubSectionsPage;

        public EditProfileSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _EditProfilePage = FeatureContext.Current.Get<Pages.EditProfilePage>("EditProfilePage");
            _ManageYourProfileSubSectionsPage = FeatureContext.Current.Get<Pages.ManageYourProfileSubSectionsPage>("ManageYourProfileSubSectionsPage");
        }
        public dynamic LogInUser = new
        {
            FirstName = "Neu",
            LastName = "Desic",
            Email = "neudesicSTG@mscntstg.stg",
            Zipcode = "85711",
            Password = "Neudesic1"
        };


        [Given("I am on the Edit Profile page")]
        public void GivenIAmOnTheEditProfilePage()
        {
            When("I choose Manage Your Profile");
            When("I select the profile icon");
        }

        [Then("the Save Updates option should be disabled")]
        public void ThenTheSaveUpdatesOptionShouldBeDisabled()
        {
            if (!_EditProfilePage.SaveUpdates.Displayed())
            {
                _EditProfilePage.ScrollDownTo(_EditProfilePage.SaveUpdates.Locator);
            }

            Assert.IsFalse(_EditProfilePage.SaveUpdates.Enabled(), "expect save updates to be disabled");
        }

        [When("I change the profile user name")]
        public void WhenIChangeTheProfileUerName()
        {
            if (!_EditProfilePage.ProfileIcon.Displayed())
            {
                _EditProfilePage.ScrollUpTo(_EditProfilePage.ProfileIcon.Locator);
            }
            _EditProfilePage.FirstName.EnterText(LogInUser.FirstName, true);
            _EditProfilePage.LastName.EnterText(LogInUser.LastName, true);
        }

        [Then("the Save Updates option should be enabled")]
        public void ThenTheSaveUpdatesOptionShouldBeenabled()
        {
            if (!_EditProfilePage.SaveUpdates.Displayed())
            {
                _EditProfilePage.ScrollDownTo(_EditProfilePage.SaveUpdates.Locator);
            }
            _EditProfilePage.WaitForElementPresent(_EditProfilePage.SaveUpdates, 5);
            Assert.IsTrue(_EditProfilePage.SaveUpdates.Enabled(), "expect save updates to be enabled");
        }

        [When("I change the profile Zipcode")] 
        public void WhenIChangeTheProfileZipcode()
        {
            _EditProfilePage.ZipCode.EnterText(LogInUser.Zipcode, true);
        }

        [When("I choose to save the changes")]
        public void WhenIChooseToSaveTheChanges()
        {
            _EditProfilePage.WaitForElementPresent(_EditProfilePage.SaveUpdates, 5);
            _EditProfilePage.SaveUpdates.Click();
        }

        [Then("I should see the success message")] 
        public void ThenIShouldSeeTheSuccessMessage(string multiline)
        {
            _EditProfilePage.WaitForElementPresent(_EditProfilePage.Message, 3);
            Assert.AreEqual(multiline, _EditProfilePage.Message.GetText());
            _EditProfilePage.Ok.Click();

        }

        [Then("I should see profile pic placeholder")]
        public void ThenIShouldSeeProfilePicPlaceholder()
        {
            Assert.IsTrue(_EditProfilePage.ProfileIcon.Displayed(), "Missing profile file icon.");
        }

        [Then("I should see the Edit Notifications screen")]
        public void ThenIShouldSeeTheEditNotificationsScreen()
        {
            _ManageYourProfileSubSectionsPage.WaitForElementPresent(_ManageYourProfileSubSectionsPage.EditNotificationSettingsPage, 8);
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.EditNotificationSettingsPage.Displayed(), "The Edit Notification Settings Page is not present");
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.EditNotificationsText.Displayed(), "The Edit Notification text is not present");
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.PillAndRefillReminderText.Displayed(), "The Pill And Refill Reminder text is not present");
            Assert.IsTrue(_ManageYourProfileSubSectionsPage.EmailNewsletterText.Displayed(), "The Email Newsletter text is not present");
        }

        [When("I change notification settings")]
        public void WhenIChangeNotificationSettings()
        {
            _ManageYourProfileSubSectionsPage.WaitForElementPresent(_ManageYourProfileSubSectionsPage.PillReminderSwitch, 5);
            _ManageYourProfileSubSectionsPage.PillReminderSwitch.Click();
            _ManageYourProfileSubSectionsPage.EmailNotificationsSwitch.Click();
            _ManageYourProfileSubSectionsPage.SaveProfileInformationButton.Click();
           if (_ManageYourProfileSubSectionsPage.ScriptSaveWellRxAlert.Displayed())
            {
                _ManageYourProfileSubSectionsPage.ScriptSaveWellRxAlertOk.Click();
            }
        }
    }
}
