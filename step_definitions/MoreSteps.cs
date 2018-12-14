using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WellRx.UITests.Pages;
using Xamarin.UITest;

namespace WellRx.UITests.Steps
{
    [Binding]
    public class MoreSteps
    {
        readonly IApp app;
        readonly Pages.MoreMenuItemsSection _MoreMenuItemsSection;
        readonly Pages.DashboardPage _DashboardPage;
        readonly Pages.ManageYourProfilePage _ManageYourProfilePage;


        public MoreSteps()
        {
            //Resolve App from Feature Container.  This is added with the [Setup] method.
            app = FeatureContext.Current.Get<IApp>("App");
            //Resolve pages that are set up with the AppInitializer InitializeScreens Method
            _MoreMenuItemsSection = FeatureContext.Current.Get<Pages.MoreMenuItemsSection>("MoreMenuItemsSection");
            _DashboardPage = FeatureContext.Current.Get<Pages.DashboardPage>("DashboardPage");
            _ManageYourProfilePage = FeatureContext.Current.Get<Pages.ManageYourProfilePage>("ManageYourProfilePage");

        }
        [Then("I should be on the more page")]
        public void ThenIShouldBeOnTheMorePage()
        {
            _MoreMenuItemsSection.WaitForElementPresent(_MoreMenuItemsSection.MenuContainer, 5);
            Assert.IsTrue(_MoreMenuItemsSection.MenuContainer.Displayed(), "Not on the more page");
        }

        [When("I choose (Edit Profile|Change Password|Apply InviteCode|Ask a Pharmacist|About Us|FAQs|Contact Us)")]
        public void WhenIChooseMenuOption(string menuOption)
        {
            switch (menuOption.ToLower())
            {
                case "edit profile":
                    _DashboardPage.WaitForElementPresent(_ManageYourProfilePage.Header, 3);
                    _DashboardPage.WaitForElementPresent(_DashboardPage.MoreMenuOptions.ManageAccount, 3);
                    _DashboardPage.MoreMenuOptions.ManageAccount.Click();
                    break;
                case "change password":
                    _DashboardPage.WaitForElementPresent(_ManageYourProfilePage.Header, 3);
                    _DashboardPage.WaitForElementPresent(_DashboardPage.MoreMenuOptions.ChangePassword, 3);
                    _DashboardPage.MoreMenuOptions.ChangePassword.Click();
                    break;
                case "apply invite code":
                    _DashboardPage.WaitForElementPresent(_ManageYourProfilePage.Header, 3);
                    _DashboardPage.WaitForElementPresent(_DashboardPage.MoreMenuOptions.ApplyInviteCode, 3);
                    _DashboardPage.MoreMenuOptions.ApplyInviteCode.Click();
                    break;
                case "ask a pharmacist":
                    _DashboardPage.WaitForElementPresent(_ManageYourProfilePage.Header, 3);
                    _DashboardPage.WaitForElementPresent(_DashboardPage.MoreMenuOptions.AskPharmacist, 3);
                    _DashboardPage.MoreMenuOptions.AskPharmacist.Click();
                    break;
                case "about us":
                    _DashboardPage.WaitForElementPresent(_ManageYourProfilePage.Header, 3);
                    _DashboardPage.WaitForElementPresent(_DashboardPage.MoreMenuOptions.AboutUs, 3);
                    _DashboardPage.MoreMenuOptions.AboutUs.Click();
                    if (_DashboardPage.MoreMenuOptions.AboutUsTwo.Displayed() && _ManageYourProfilePage.Header.Displayed())
                        _DashboardPage.MoreMenuOptions.AboutUsTwo.Click();
                    break;
                case "faqs":
                    _DashboardPage.WaitForElementPresent(_ManageYourProfilePage.Header, 3);
                    _DashboardPage.WaitForElementPresent(_DashboardPage.MoreMenuOptions.FAQs, 3);
                    _DashboardPage.MoreMenuOptions.FAQs.Click();
                    break;
                case "contact us":
                    _DashboardPage.WaitForElementPresent(_ManageYourProfilePage.Header, 3);
                    _DashboardPage.WaitForElementPresent(_DashboardPage.MoreMenuOptions.ContactUs, 3);
                    _DashboardPage.MoreMenuOptions.ContactUs.Click();
                    break;
            
                default:
                    Assert.Fail(menuOption + ": menu option is not supported at the moment.");
                    break;
            }
        }

        [Then("I should see more menu options")]
        public void ThenIShouldSeeMoreMenuOptions()
        {
            _DashboardPage.WaitForElementPresent(_DashboardPage.MoreMenuOptions.MenuContainer, 3);
            Assert.IsTrue(_DashboardPage.MoreMenuOptions.MenuContainer.Displayed(), "More menu is not in the view.");
        }
    }
}
