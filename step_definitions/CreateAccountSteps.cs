using System;
using System.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class CreateAccountSteps : TechTalk.SpecFlow.Steps
    {
            readonly IApp app;
            readonly Pages.CreateAccountPage _CreateAccountPage;
            readonly Pages.WelcomePage _WelcomePage;
            readonly Pages.AboutUsPage _AboutUsPage;
            readonly Pages.DashboardPage _DashboardPage;

            public CreateAccountSteps()
            {
                //Resolve App from Feature Container.  This is added with the [Setup] method.
                app = FeatureContext.Current.Get<IApp>("App");
                //Resolve pages that are set up with the AppInitializer InitializeScreens Method
                _CreateAccountPage = FeatureContext.Current.Get<Pages.CreateAccountPage>("CreateAccountPage");
                _WelcomePage = FeatureContext.Current.Get<Pages.WelcomePage>("WelcomePage");
                _AboutUsPage = FeatureContext.Current.Get<Pages.AboutUsPage>("AboutUsPage");
                _DashboardPage = FeatureContext.Current.Get<Pages.DashboardPage>("DashboardPage");

        }
        public static dynamic NewUserValidData = new
        {
            FirstName = "Neudesic",
            LastName = "Automation",
            Email = "abc@abc.com",
            Password = "Neudesic1",
            DOB = new DateTime(1980, 10, 10),
            GroupNumber = "wellrxdemo",
            //GroupNumber = "2725",
            NonPwGroupNumber = "1384",
            ZipCode = "85711",
        };

        [When("I choose already have an account")]
        public void WhenIChooseAlreadyHaveAnAccount()
        {
            if (!_CreateAccountPage.AlreadyHaveAccount.Displayed())
            {
                _DashboardPage.ScrollDownTo(_CreateAccountPage.AlreadyHaveAccount.Locator);

            }
            if (AppInitializer.CurrentPlatform == Platform.iOS)
            {
                //This is here due to the above code not working on iOS
                app.ScrollDown();
            }
            _CreateAccountPage.AlreadyHaveAccount.Click();
        }

        [Then("I should not see email and zipcode fields on the view")]
        public void ThenIShouldNotSeeEmailAndZipcodeFieldsOnTheView()
        {
            Assert.IsFalse(_CreateAccountPage.Email.Displayed(), "shouldn't see email field");
            Assert.IsFalse(_CreateAccountPage.ZipCode.Displayed(), "shouldn't see zipcode field");
        }

        [Then("I should see email and zipcode fields on the view")]
        public void ThenIShouldSeeEmailAndZipcodeFieldsOnTheView()
        {
            _CreateAccountPage.WaitForElementPresent(_CreateAccountPage.Email, 5);
            _CreateAccountPage.WaitForElementPresent(_CreateAccountPage.ZipCode, 5);
            Assert.IsTrue(_CreateAccountPage.Email.Displayed(), "should see email field");
            Assert.IsTrue(_CreateAccountPage.ZipCode.Displayed(), "should see zipcode field");
        }

        [Given("I navigated to the create an account page from welcome page")]
        public void INavigatedToTheCreateAnAccountPageFromWelcomePage()
        {
            When("I choose to move forward with an invite code");
            Then("I should be navigated to the create account page");
        }

        [Then("I should be on the create account page")]
        public void ThenIShouldBeOnTheCreateAccountPage()
        {
            _CreateAccountPage.WaitForElementPresent(_CreateAccountPage.Title, 5);
            Assert.IsTrue(_CreateAccountPage.PageContainer.Displayed(), "not on the create account page");
        }

        [Then("I should see following fields on the view")]
        public void ThenIShouldSeeFollowingFieldsOnTheView(Table table)
        {
            var fields = table.Rows.Select(row => row["Fields"]).ToList();
            foreach (var field in fields)
            {
                switch (field.ToLower())
                {
                    case "firstname":
                        Assert.IsTrue(_CreateAccountPage.FirstName.Displayed(), "missing firstname field");
                        Console.WriteLine("firstname displayed:" + _CreateAccountPage.FirstName.Displayed());
                        break;
                    case "lastname":
                        Assert.IsTrue(_CreateAccountPage.LastName.Displayed(), "missing lasttname field");
                        break;
                    case "dob":
                        Assert.IsTrue(_CreateAccountPage.DOB.Displayed(), "missing bod field");
                        break;
                    case "password":
                        Assert.IsTrue(_CreateAccountPage.Password.Displayed(), "missing password field");
                        break;
                    case "invitecode":
                        Assert.IsTrue(_CreateAccountPage.InviteCode.Displayed(), "missing invite field");
                        break;
                    case "zipcode":
                        Assert.IsTrue(_CreateAccountPage.ZipCode.Displayed(), "missing zipcode field");
                        break;
                    default:
                        Assert.Fail(field + " is not supported at the moment.");
                        break;
                }
            }
        }

        [Then("I should see following checkboxes on the view")]
        public void ThenIShouldSeeFollowingCheckBoxesOnTheView(Table table)
        {
            var checkboxes = table.Rows.Select(row => row["checkbox"]).ToList();
            foreach (var checkbox in checkboxes)
            {
                switch (checkbox.ToLower())
                {
                    case "useragreement":
                        Assert.IsTrue(_CreateAccountPage.UserAgreementCheckbox.Displayed(), "terms & conditions checkbox is not displayed");
                        break;
                    case "notifications":
                        Assert.IsTrue(_CreateAccountPage.Notifications.Displayed(), "notifications checkbox is not displayed");
                        break;

                    default:
                        Assert.Fail(checkbox + " is not supported at the moment.");
                        break;
                }
            }
        }
         
        [When("I enter an invalid InviteCode")] 
        public void WhenIEnterAnInvalidInviteCode()
        {
            _CreateAccountPage.InviteCode.EnterText("invalid", true);
        }

        [When("I enter all required info with invalid ZipCode")]
        public void WhenIEnterAllRequiredInfoWithInvalidZipCode()
        {
            _CreateAccountPage.FirstName.EnterText(NewUserValidData.FirstName, true);
            _CreateAccountPage.LastName.EnterText(NewUserValidData.LastName, true);
            _CreateAccountPage.Email.EnterText(NewUserValidData.Email, true);
            _CreateAccountPage.Password.EnterText(NewUserValidData.Password, true, hasIconEntry: true);
            _CreateAccountPage.ZipCode.EnterText("857112", true);
        }

        [When("I choose to continue")]
        public void whenIChooseToContinue()
        {
            _WelcomePage.Continue.Click();
        }

        [When("I select Get Your Savings Card")]
        public void WhenISelectGetYourSavingCard()
        {
            _CreateAccountPage.SaveNewAccount.Click();
        }

        [Then("I should see an error message reads as")]
        public void ThenIShouldSeeAnErrorMessageReadsAs(string multiline)
        {
            if (!_CreateAccountPage.ValidationMessage.Displayed())
            {
                _CreateAccountPage.ScrollUpTo(_CreateAccountPage.ValidationMessage.Locator);
            }
            _CreateAccountPage.WaitForElementPresent(_CreateAccountPage.ValidationMessage, 10);
            Assert.AreEqual(multiline, _CreateAccountPage.ValidationMessage.GetText());
        }

        [Then("I should see an error message reads as for invalid invite code")]
        public void ThenIShouldSeeAnErrorMessageReadsAsForInvalidInviteCode(string multiline)
        {
            if (!_CreateAccountPage.ValidationMessage.Displayed())
            {
                _CreateAccountPage.ScrollUpTo(_CreateAccountPage.ValidationMessage.Locator);
            }
            _CreateAccountPage.WaitForElementPresent(_CreateAccountPage.ValidationMessage, 10);
            Assert.AreEqual(multiline, _CreateAccountPage.ValidationMessage.GetText());
        }

        [When("I enter all required info with invalid Password")]
        public void WhenIEnterAllRequiredInfoWithInvalidPassword()
        {
            _CreateAccountPage.FirstName.EnterText(NewUserValidData.FirstName, true);
            _CreateAccountPage.LastName.EnterText(NewUserValidData.LastName, true);
            _CreateAccountPage.Email.EnterText(NewUserValidData.Email, true);
            _CreateAccountPage.Password.EnterText("123", true, hasIconEntry: true);
            _CreateAccountPage.ZipCode.EnterText(NewUserValidData.ZipCode, true);
        }

        [When("I select terms & conditions link")]
        public void WhenISelectTermsConditionLink()
        {
            _CreateAccountPage.TermsConditiionsLink.Click();
        }

        [Then("I should be navigated to the Terms & Conditions page")]
        public void ThenIShouldBeNavigatedToTheTermsCondiditonsPage()
        {
            _AboutUsPage.WaitForElementPresent(_AboutUsPage.TermsAndConditionsPage, 3);
            Assert.IsTrue(_AboutUsPage.TermsAndConditionsHeader.Displayed(), "not on terms & conditions page");
        }
    }
}
