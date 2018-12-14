using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WellRx.UITests.Pages;
using Xamarin.UITest;
using System.Linq;
using Xamarin.UITest.Configuration;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class NavigationSteps : TechTalk.SpecFlow.Steps
    {
        readonly IApp app;
        readonly Pages.WelcomePage _WelcomePage;
        readonly Pages.EditProfilePage _EditProfilePage;
        readonly Pages.FaqsPage _FaqsPage;
        readonly Pages.DashboardPage _DashboardPage;
        readonly Pages.LogInPage _LoginPage;
        readonly Pages.OnBoardingPage _OnBoardingPage;
        readonly Pages.CreateAccountPage _CreateAccountPage;
        readonly Pages.TeaserSearchResultsPage _TeaserSearchResultsPage;
        readonly Pages.SavingsTeaserPage _SavingsTeaserPage;
        readonly Pages.SavingscardPage _SavingsCardPage;
        readonly Pages.MedicineChestPage _MedicineChestPage;
        readonly Pages.PriceMedicinePage _PriceMedicinePage;
        readonly Pages.AboutUsPage _AboutUsPage;
        readonly Pages.BottomMenuOptionsSection _BottomMenuOptionsSection;
        readonly Pages.MoreMenuItemsSection _MoreMenuItemsSection;

        public NavigationSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _EditProfilePage = FeatureContext.Current.Get<Pages.EditProfilePage>("EditProfilePage");
            _WelcomePage = FeatureContext.Current.Get<Pages.WelcomePage>("WelcomePage");
            _DashboardPage = FeatureContext.Current.Get<Pages.DashboardPage>("DashboardPage");
            _CreateAccountPage = FeatureContext.Current.Get<Pages.CreateAccountPage>("CreateAccountPage");
            _TeaserSearchResultsPage = FeatureContext.Current.Get<Pages.TeaserSearchResultsPage>("TeaserSearchResultsPage");
            _SavingsTeaserPage = FeatureContext.Current.Get<Pages.SavingsTeaserPage>("SavingsTeaserPage");
            _OnBoardingPage = FeatureContext.Current.Get<Pages.OnBoardingPage>("OnBoardingPage");
            _SavingsCardPage = FeatureContext.Current.Get<Pages.SavingscardPage>("SavingsCardPage");
            _PriceMedicinePage = FeatureContext.Current.Get<Pages.PriceMedicinePage>("PriceMedicinePage");
            _MedicineChestPage = FeatureContext.Current.Get<Pages.MedicineChestPage>("MedicineChestPage");
            _FaqsPage = FeatureContext.Current.Get<Pages.FaqsPage>("FaqsPage");
            _AboutUsPage = FeatureContext.Current.Get<Pages.AboutUsPage>("AboutUsPage");
            _LoginPage = FeatureContext.Current.Get<Pages.LogInPage>("LoginPage");
            _BottomMenuOptionsSection = FeatureContext.Current.Get<Pages.BottomMenuOptionsSection>("BottomMenuOptionsSection");
            _MoreMenuItemsSection = FeatureContext.Current.Get<Pages.MoreMenuItemsSection>("MoreMenuItemsSection");
        }

        [Then("I should be on the Welcome page")]
        public void ThenIShouldBeOnTheWelcomePage()
        {
            int tries = 0;
            _WelcomePage.WaitForElementPresent(_WelcomePage.PageContainer, 10);
            while (!_WelcomePage.PageContainer.Displayed() && AppInitializer.CurrentPlatform == Platform.Android)
            {
                ConfigureApp.Android.WaitTimes(new CustomWaitTimes()).StartApp(AppDataMode.Clear);
                _WelcomePage.WaitForElementPresent(_WelcomePage.PageContainer, 10);
                tries++;
                if (tries == 5)
                    break;
            }
            Console.WriteLine("Is welcome page displayed: "+ _WelcomePage.AlreadyHaveAccount.Displayed());
            Assert.IsTrue(_WelcomePage.PageContainer.Displayed(), "not on the welcome page");
        }

        [When("I choose to move forward without an invite code")]
        public void WhenIChooseToMoveFowwardWithoutAnInviteCode()
        {
            Console.WriteLine("Is welcome page displayed: " + _WelcomePage.NoInviteCode.Displayed());
            _WelcomePage.WaitForElementPresent(_WelcomePage.NoInviteCode, 10);
            _WelcomePage.NoInviteCode.Click();
        }

        [When("I choose to move forward without an invite code and past on boarding tutorial screens")]
        public void WhenIChooseToMoveFowwardWithoutAnInviteCodeAndPastOnBoardingTutorial()
        {
            Console.WriteLine("Is welcome page displayed: " + _WelcomePage.NoInviteCode.Displayed());
            _WelcomePage.NoInviteCode.Click();
            Given("I am past the tutorial screens");
            When("I am past the on boarding tutorial screens");
        }

        [When("I choose to move forward with an invite code")]
        public void WhenIChooseToMoveFowwardWithAnInviteCode()
        {
            Console.WriteLine("Is welcome page displayed: " + _WelcomePage.YesInviteCode.Displayed());
            _WelcomePage.YesInviteCode.Click();
            _WelcomePage.WaitForElementPresent(_WelcomePage.InviteCodeOrGroupNumber, 5);
            _WelcomePage.InviteCodeOrGroupNumber.EnterText(CreateAccountSteps.NewUserValidData.GroupNumber);
            _WelcomePage.Continue.Click();
            Given("I am past the tutorial screens");
            When("I am past the on boarding tutorial screens");
        }

        [When("I input an invite code that does not have Personalized Wellness")]
        public void WhenIInputAnInviteCodeThatDoesNotHavePersonalizedWellness()
        {
            Console.WriteLine("Is welcome page displayed: " + _WelcomePage.YesInviteCode.Displayed());
            _WelcomePage.YesInviteCode.Click();
            _WelcomePage.WaitForElementPresent(_WelcomePage.InviteCodeOrGroupNumber, 5);
            _WelcomePage.InviteCodeOrGroupNumber.EnterText(CreateAccountSteps.NewUserValidData.NonPwGroupNumber);
            _WelcomePage.Continue.Click();
        }

        [Given("I choose to move forward with an invalid invite code")]
        public void WhenIChooseToMoveFowwardWithAnInvalidInviteCode()
        {
            Then("I should be on the Welcome page");
            Console.WriteLine("Is welcome page displayed: " + _WelcomePage.YesInviteCode.Displayed());
            _WelcomePage.YesInviteCode.Click();
            _WelcomePage.WaitForElementPresent(_WelcomePage.InviteCodeOrGroupNumber, 5);
            _WelcomePage.InviteCodeOrGroupNumber.EnterText("invalid");
            _WelcomePage.Continue.Click();
        }

        [When("I choose to move forward with an existing account")]
        public void WhenIChooseToMoveFowwardWithAnExistingAccount()
        {
            Console.WriteLine("Is welcome page displayed: " + _WelcomePage.AlreadyHaveAccount.Displayed());
            _WelcomePage.WaitForElementPresent(_WelcomePage.AlreadyHaveAccount, 5);
            _WelcomePage.AlreadyHaveAccount.Click();
        }

        [Then("I should be navigated to the create account page")]
        public void ThenIShouldBeNavigatedToTheCreateAccountPage()
        {
            When("I select the toobar item of More");
            _MoreMenuItemsSection.WaitForElementPresent(_MoreMenuItemsSection.SignInSignUpButton, 5);
            _MoreMenuItemsSection.SignInSignUpButton.Click();
            _CreateAccountPage.WaitForElementPresent(_CreateAccountPage.Title, 3);
            Assert.IsTrue(_CreateAccountPage.PageContainer.Displayed(), "not on the create account page");
        }

        [Then("I should be navigated to the teaser search page")]
        public void ThenIShouldBeNavigatedToTheTeasterSearchPage()
        {
            _CreateAccountPage.WaitForElementPresent(_SavingsTeaserPage.DrugName, 5);
            Assert.IsTrue(_SavingsTeaserPage.PageContainer.Displayed(), "not on the teaser account page");
        }

        [Then("I should be navigated to the onboarding teaser savings page")]
        public void ThenIShouldBeNavigatedToTheOnboardingTeaserSavingsPage()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.OnBoardingPriceMedsTeaserSavingsText, 5);
            Assert.IsTrue(_OnBoardingPage.OnBoardingPriceMedsTeaserSavingsText.Displayed(), "not on the teaser account page");
        }

        [Then("I should be navigated to the onboarding barcode scanner page")]
        public void ThenIShouldBeNavigatedToTheOnboardingBarcodeScannerPage()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.BarcodeScanningPage, 5);
            Assert.IsTrue(_OnBoardingPage.BarcodeScanningPage.Displayed(), "not on the Barcode Scanning page");
        }

        [Then("I should be navigated to the log in page")]
        public void ThenIShouldBeNavigatedToTheLogInPage()
        {
            _CreateAccountPage.WaitForElementPresent(_LoginPage.PageContainer, 5);
            Assert.IsTrue(_LoginPage.PageContainer.Displayed(), "not on the log in page");
        }

        [Then("I should be presented with following options")]
        public void ThenIShouldBePresentedWithFollowingOptions(Table table)
        {
            var options = table.Rows.Select(row => row["Options"]).ToList();
            foreach (var option in options)
            {
                switch (option.ToLower())
                {
                    case "yes invite code":
                        _WelcomePage.WaitForElementPresent(_WelcomePage.YesInviteCode, 5);
                        Assert.IsTrue(_WelcomePage.YesInviteCode.Displayed(), "missing yes invite code option.");
                        break;
                    case "no invite code":
                        Assert.IsTrue(_WelcomePage.NoInviteCode.Displayed(), "missing no invite code option");
                        break;
                    case "already have an account":
                        Assert.IsTrue(_WelcomePage.AlreadyHaveAccount.Displayed(), "missing already have an account option");
                        break;

                    default:
                        Assert.Fail(option + "is not a support option.");
                        break;
                }
            }
        }

        [Then("I should be navigated to the home page")]
        public void ThenIShouldBeNavigatedToTheHomePage()
        {
            _DashboardPage.WaitForElementPresent(_DashboardPage.SavingsCard, 30);
            Assert.IsTrue(_DashboardPage.SavingsCard.Displayed(), "not on home page, or missing savings card");
        }


        [Then("I should be navigated to the price medicine page")]
        public void ThenIShouldBeNavigatedToThePriceMedicinePage()
        {
            _PriceMedicinePage.WaitForElementPresent(_PriceMedicinePage.DrugName, 5);
            Assert.IsTrue(_PriceMedicinePage.DrugName.Displayed(), "not on price medicine page.");
        }

        [Then("I should be navigated to the teaser search results page")]
        public void ThenIShouldBeNavigatedToTheTeaserSearchResultsPage()
        {
            _OnBoardingPage.WaitForElementPresent(_OnBoardingPage.TeaserSavingsContinueButton, 3);
            Assert.IsTrue(_OnBoardingPage.TeaserSavingsContinueButton.Displayed(), "not on the teaser search results page.");
        }

        [Then("I should be navigated to the savings card page")]
        public void ThenIShouldBeNavigatedToTheSavingsCardPage()
        {
            _DashboardPage.ScrollDownTo(_SavingsCardPage.SaveToDashboard.Locator);
            Assert.IsTrue(_SavingsCardPage.SaveToDashboard.Displayed(), "no on the savings card page.");
        }

        [Given("I am on the create account page")]
        public void GivenIAmOnTheCreateAccountPage()
        {
            When("I choose to move forward with an invite code");
            Then("I should be navigated to the create account page");
        }

        [Then("I should be navigated to About Us page")]
        public void ThenIShouldBeNavigatedToAboutUsPage()
        {
            Assert.IsTrue(_AboutUsPage.PrivacyPolicyHeader.Displayed(), "not on about us page");
        }

        [Then("I should be navigated to FAQs page")]
        public void ThenIShouldBeNavigatedToFaqsPage()
        {
            Assert.IsTrue(_FaqsPage.Header.Displayed(), "not on about us page");
        }

        [Then("I should not see the Food Index tab")]
        public void ThenIShouldNotSeeTheFoodIndexTab()
        {
            Assert.IsFalse(_DashboardPage.BottomMenuOptions.FoodIndex.Displayed(), "Food Index tab is present.");
        }

        [Given("I am past the tutorial screens")]
        public void PastTheTutorialScreens()
        {
            int tries = 0;
            Given("I am on the onboard page");
            while (!_OnBoardingPage.OnBoardingContinueLink.Displayed())
            {
                When("I swipe to next page");
                tries++;
                if (tries > 3)
                    break;
            }
            When("I select the continue link on the On Boarding pages");
        }

        [When("I am past the on boarding tutorial screens")]
        public void PastTheOnBoardingTutorialScreens()
        {
            When("I select Skip For Now on the On Boarding pages");
            When("I select Skip For Now on the Barcode Scanner page");
            When("I choose Save to Dashboard");
        }
    }
}
