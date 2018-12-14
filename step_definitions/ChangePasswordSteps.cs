using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class ChangePasswordSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.ChangePasswordPage _ChangePasswordPage;

        public ChangePasswordSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _ChangePasswordPage = FeatureContext.Current.Get<Pages.ChangePasswordPage>("ChangePasswordPage");
        }

        [Given("I am on change password page")]
        public void GivenIAmOnChangePasswordPage()
        {
            Given("I am on the home page");
            When("I select the toobar item of More");
            Then("I should see more menu options");
            When("I choose Change Password");
        }

        [Then("the update password button should be disabled")]
        public void ThenTheUpdatePasswordButtonShouldBeDisabled()
        {
            _ChangePasswordPage.WaitForElementPresent(_ChangePasswordPage.UpdatePassword, 3);
            Assert.IsFalse(_ChangePasswordPage.UpdatePassword.Enabled(), "update password button should be disabled");
        }

        [When("I enter valid current and new Password")]
        public void WhenIEnterValidCurrentAndNewPassword()
        {
            _ChangePasswordPage.WaitForElementPresent(_ChangePasswordPage.CurrentPassword, 3);
            _ChangePasswordPage.CurrentPassword.EnterText(LogInSteps.ExistingUser.Password, true);
            _ChangePasswordPage.NewPassword.EnterText(LogInSteps.ExistingUser.Password, true);
            _ChangePasswordPage.VerifyNewPassword.EnterText(LogInSteps.ExistingUser.Password, true);
        }

        [When("I enter invalid current and new Password")]
        public void WhenIEnterInvalidCurrentAndNewPassword()
        {
            _ChangePasswordPage.WaitForElementPresent(_ChangePasswordPage.CurrentPassword, 3);
            _ChangePasswordPage.CurrentPassword.EnterText(LogInSteps.ExistingUser.Password + "!", true);
            _ChangePasswordPage.NewPassword.EnterText(LogInSteps.ExistingUser.Password, true);
            _ChangePasswordPage.VerifyNewPassword.EnterText(LogInSteps.ExistingUser.Password, true);
        }

        [When("I enter valid current and invalid new Password")]
        public void WhenIEntervalidCurrentAndInvalidNewPassword()
        {
            _ChangePasswordPage.WaitForElementPresent(_ChangePasswordPage.CurrentPassword, 3);
            _ChangePasswordPage.CurrentPassword.EnterText(LogInSteps.ExistingUser.Password, true);
            _ChangePasswordPage.NewPassword.EnterText(LogInSteps.ExistingUser.Password.ToLower(), true);
            _ChangePasswordPage.VerifyNewPassword.EnterText(LogInSteps.ExistingUser.Password.ToLower(), true);
        }

        [When("I choose to update the password")]
        public void WhenIChooseToUpdateThePassword()
        {
            _ChangePasswordPage.WaitForElementPresent(_ChangePasswordPage.UpdatePassword, 5);
            _ChangePasswordPage.UpdatePassword.Click();
        }

        [When("I select OK on the message popup")]
        public void WhenISelectzOkOnTheMessagePopup()
        {
            _ChangePasswordPage.WaitForElementPresent(_ChangePasswordPage.MessageOkButton, 5);
            _ChangePasswordPage.MessageOkButton.Click();
        }

        [Then("I should be back on the More menu")]
        public void ThenIShouldBeBackOnTheMoreMenu()
        {
            When("I select the toobar item of More");
            _ChangePasswordPage.WaitForElementPresent(_ChangePasswordPage.CurrentPassword, 5);
            Assert.IsTrue(_ChangePasswordPage.MoreMenuOptions.ChangePassword.Displayed(), "not on More menu options view");
        }

        [Then("I should be back on the change password page")] 
        public void ThenIShouldBeBackOnTheChangePasswordPage()
        {
            Assert.IsTrue(_ChangePasswordPage.CurrentPassword.Displayed(), "not on the change password page");
        }

        [Then("I should see Change Password message reads as")]
        public void ThenIShouldSeeChangePasswordMessageReadsAs(string multiline)
        {
            _ChangePasswordPage.WaitForElementPresent(_ChangePasswordPage.Message, 5);
            Assert.AreEqual(multiline, _ChangePasswordPage.Message.GetText(), "The message does not match");
        }
    }
}
