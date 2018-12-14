using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class LogInSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.LogInPage _LoginPage;
        readonly Pages.DashboardPage _DashboardPage;


        public static dynamic ExistingUser = new
        {
            FirstName = "Neu",
            LastName = "Desic",
            Email = "neudesicSTG@mscntstg.stg",
            Password = "Neudesic1",
            NonPwEmail = "test025@neudesic.com",
            NonPwPassword = "Hello123!"
            //Email = "test01@neudesic.com",
            //Password = "Hello123!"
            //Email = "conditions@neudesic.com",
            //Password = "Hello123!" 
            //Email = "test022@neudesic.com",
            //Password = "Hello123!"
            //This account is used for production endpoints
            //Email = "mosheitt@yahoo.com",         
            //Password = "Pokemon18"  
        };

        public dynamic InvalidCredentials = new
        {
            Email = "aneudesicSTG@mscntstg.stg",
            Password = "aNeudesic1"
        };
        public LogInSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _LoginPage = FeatureContext.Current.Get<Pages.LogInPage>("LoginPage");
            _DashboardPage = FeatureContext.Current.Get<Pages.DashboardPage>("DashboardPage");

        }

        [When("I am on the login page")]
        public void WhenIAmOnTheLogInPage()
        {
            Then("I should be on the Welcome page");
            When("I choose to move forward with an existing account");
            Then("I should be navigated to the log in page");
        }

        [Given("I am on the log in page")]
        public void GivenIAmOnTheLogInPage()
        {
            Then("I should be on the Welcome page");
            When("I choose to move forward with an existing account");
            Then("I should be navigated to the log in page");
        }

        [When("I log in as existing user")]
        [When("I attempt to login again using valid credenticals")]
        public void WhenILogInAsExistingUser()
        {
            _LoginPage.WaitForElementPresent(_LoginPage.Email, 5);
            _LoginPage.Email.EnterText(ExistingUser.Email, true);
            _LoginPage.HideKeyboard();
            _LoginPage.Password.EnterText(ExistingUser.Password, true, hasIconEntry:true);
            _LoginPage.HideKeyboard();
            _LoginPage.LogIn.Click();
            _LoginPage.WaitForElementPresent(_LoginPage.AlertNoThanks, 3);
            if (_LoginPage.AlertNoThanks.Displayed())
            {
                _LoginPage.AlertNoThanks.Click();
            }
        }

        [When("I log in as existing user with out Personalized Wellness")]
        public void WhenILogInAsExistingUserWithOutPersonalizedWellness()
        {
            _LoginPage.WaitForElementPresent(_LoginPage.Email, 5);
            _LoginPage.Email.EnterText(ExistingUser.NonPwEmail, true);
            _LoginPage.HideKeyboard();
            _LoginPage.Password.EnterText(ExistingUser.NonPwPassword, true, hasIconEntry:true);
            _LoginPage.HideKeyboard();
            _LoginPage.LogIn.Click();
            _LoginPage.WaitForElementPresent(_LoginPage.AlertNoThanks, 3);
            if (_LoginPage.AlertNoThanks.Displayed())
            {
                _LoginPage.AlertNoThanks.Click();
            }
        }

        [When("I attempt to log in with invalid credentials")]
        public void WhenILogInWithInvalidCredentials()
        {
            _LoginPage.WaitForElementPresent(_LoginPage.Email, 3);
            _LoginPage.Email.EnterText("a" + ExistingUser.Email, true);
            _LoginPage.HideKeyboard();
            _LoginPage.Password.EnterText("a" + ExistingUser.Password, true, hasIconEntry: true);
            _LoginPage.HideKeyboard();
            _LoginPage.LogIn.Click();
        }

        [Then("I should see login validation message")]
        public void ThenIShouldSeeLogInValidationMessage()
        {
            _LoginPage.WaitForElementPresent(_LoginPage.ValidationMessage, 3);
            Assert.IsTrue(_LoginPage.ValidationMessage.Displayed(), "validation message is missing.");
        }

        [When("I choose forgot password link")] 
        public void WhenIChooseForgotPasswordLink()
        {
            _LoginPage.ForgotPassword.Click();
        }

        [Then("I should see (.*) popup")]
        public void ThenIShouldSeeForgotPasswordPopup(string alertTitle)
        {
            _LoginPage.WaitForElementPresent(_LoginPage.AlertTitle, 3);

            Assert.IsTrue(_LoginPage.ForgotPasswordTitle.Displayed());
            Console.WriteLine(_LoginPage.ForgotPasswordTitle.GetText());
        }

        [When("I choose to log out")]
        public void WhenIChooseToLogOut()
        {
            _DashboardPage.BottomMenuOptions.More.Click();
            _DashboardPage.WaitForElementPresent(_DashboardPage.MoreMenuOptions.LogOut, 3);
            _DashboardPage.ScrollDownTo(_DashboardPage.MoreMenuOptions.LogOut.Locator);
            _DashboardPage.MoreMenuOptions.LogOut.Click();
            _DashboardPage.WaitForElementPresent(_DashboardPage.MoreMenuOptions.YesLogOut, 3);
            _DashboardPage.MoreMenuOptions.YesLogOut.Click();
        }

        [When("I enter an invalid email address in the forgot password popup")]
        public void WhenIEnterAnInvalidEmailAddress()
        {
            ForgotPasswordClearText();
            app.EnterText("abc.com");
        }

        [When("I enter an valid email address in the forgot password popup")]
        public void WhenIEnterAnValidEmailAddress()
        {
            app.ClearText();
            app.EnterText("abc@abc.com");
        }

        [When("I enter an unregistered email address in the forgot password popup")]
        public void WhenIEnterAnUnregisteredEmailAdress()
        {
            ForgotPasswordClearText();
            app.EnterText("unregistered@abc.com");
        }

        [When("I enter an registered email address in the forgot password popup")]
        public void WhenIEnterAnRegisteredEmailAdress()
        {
            ForgotPasswordClearText();
            app.EnterText(ExistingUser.Email);
        }

        [Then("the ok button on the forgot password popups should be (disabled|enabled)")]
        public void ThenTheOkButtonOnTheForgotPasswordPopupsShouldBe(string state)
        {
            switch (state.ToLower())
            {
                case "enabled":
                    _LoginPage.ForgotPasswordDialog.Ok.Click();
                    _LoginPage.WaitForElementNotPresent(_LoginPage.ForgotPasswordDialog.ForgotMessage, 3);
                    Assert.True(!_LoginPage.ForgotPasswordDialog.ForgotMessage.Displayed(), "ok button is not enabled");
                    break;
                case "disabled":
                    _LoginPage.ForgotPasswordDialog.Ok.Click();
                    _LoginPage.WaitForElementPresent(_LoginPage.ForgotPasswordDialog.ForgotMessage, 3);
                    Assert.True(_LoginPage.ForgotPasswordDialog.ForgotMessage.Displayed(), "ok button is not disabled");
                    break;
                default:
                    break;
            }
        }

        [When("I choose Remember Login Information")]
        public void WhenIChooseRememberLoginInformation()
        {
            _LoginPage.RememberMe.Click();
        }

        [When("I select ok button on the forgot password popups")]
        public void WhenISelectOkButtonOnTheForgotPasswordPopups()
        {
            _LoginPage.ForgotPasswordDialog.Ok.Click();
        }

        [Then("I should see a message reads as")] 
        public void ThenIShouldSeeAMessageReadAs(string multiline)
        {
            _LoginPage.WaitForElementPresent(_LoginPage.ForgotPasswordDialog.Message, 5);
            Assert.AreEqual(multiline, _LoginPage.ForgotPasswordDialog.Message.GetText());
        }

        [When("I exit the app relaunch the app again")]
        public void WhenIExitTheAppRelaunchTheAooAgain()
        {
            try
            {

                Environment.Exit(0);
            }
            catch
            {
                Console.WriteLine("close app");
            }
        }
        //This is a small function that works with the coded model for forgot password
        private void ForgotPasswordClearText()
        {
            _LoginPage.WaitForElementPresent(_LoginPage.ForgotPasswordTitle, 5);
            app.EnterText("abc.com");
            app.ClearText();
        }
    }
}
